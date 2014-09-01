//-----------------------------------------------------------------------
// <copyright file="InvoiceRefund.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.CaseMgr;
using CMBC.EasyFactor.Controls;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceRefund : UserControl
    {
        #region OpRefundType enum

        /// <summary>
        /// 
        /// </summary>
        public enum OpRefundType
        {
            /// <summary>
            /// 
            /// </summary>
            BUYER_PAYMENT,

            /// <summary>
            /// 
            /// </summary>
            SELLER_REFUND,
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly ARCaseBasic _caseBasic;

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;

        /// <summary>
        /// 
        /// </summary>
        private readonly OpRefundType _refundType;

        /// <summary>
        /// 
        /// </summary>
        private Case _case;

        /// <summary>
        /// 
        /// </summary>
        private decimal _totalPayment;


        /// <summary>
        /// 
        /// </summary>
        public InvoiceRefund(ARCaseBasic caseBasic, OpRefundType refundType)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            dgvLogs.ImeMode = ImeMode.OnHalf;

            var checkBoxCell = new DataGridViewCheckboxHeaderCell();
            checkBoxCell.OnCheckBoxClicked += OnCheckBoxClicked;
            var checkBoxCol = dgvLogs.Columns[0] as DataGridViewCheckBoxColumn;
            if (checkBoxCol != null)
            {
                checkBoxCol.HeaderCell = checkBoxCell;
                checkBoxCol.HeaderCell.Value = string.Empty;
            }

            _caseBasic = caseBasic;
            _refundType = refundType;
            dgvLogs.AutoGenerateColumns = false;
            superValidator.Enabled = false;
            ControlUtil.SetDoubleBuffered(dgvLogs);

            foreach (DataGridViewColumn column in dgvLogs.Columns)
            {
                column.ReadOnly = true;
            }

            colCheckBox.ReadOnly = false;

            _context = new DBDataContext();
        }


        /// <summary>
        /// 
        /// </summary>
        public Case Case
        {
            get { return _case; }
            set
            {
                _case = _context.Cases.SingleOrDefault(c => c.CaseCode == value.CaseCode);
                NewBatch(null, null);
            }
        }


        //?Public?Methods?(2)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        /// <param name="paymentBatch"></param>
        public void NewBatchFromPayment(List<Invoice> invoiceList, InvoicePaymentBatch paymentBatch)
        {
            if (invoiceList == null || invoiceList.Count == 0)
            {
                return;
            }

            _case = _context.Cases.SingleOrDefault(c => c.CaseCode == invoiceList[0].InvoiceAssignBatch.Case.CaseCode);
            _caseBasic.Case = _case;

            var refundList = (from invoice in invoiceList
                              select _context.Invoices.SingleOrDefault(i => i.InvoiceID == invoice.InvoiceID)
                                  into newInvoice
                                  from financeLog in newInvoice.InvoiceFinanceLogs
                                  select new InvoiceRefundLog(financeLog)).ToList();

            _totalPayment = paymentBatch.InvoicePaymentLogs.Sum(log => log.PaymentAmount).GetValueOrDefault();
            tbTotalPayment.Text = String.Format("{0:N2}", _totalPayment);
            tbTotalRefund.Text = string.Empty;
            var batch = new InvoiceRefundBatch();
            if (paymentBatch.PaymentType == PAYMENT.BUYER_PAYMENT)
            {
                batch.RefundType = REFUND.BUYER_PAYMENT;
            }
            else if (paymentBatch.PaymentType == PAYMENT.INDIRECT_PAYMENT ||
                     paymentBatch.PaymentType == PAYMENT.SELLER_REASSIGN ||
                     paymentBatch.PaymentType == PAYMENT.CREDIT_NOTE_PAYMENT)
            {
                batch.RefundType = REFUND.SELLER_REFUND;
            }
            batch.RefundDate = paymentBatch.PaymentDate;
            batch.CreateUserName = App.Current.CurUser.Name;
            //batch.CheckStatus = BATCH.UNCHECK;
            batchBindingSource.DataSource = batch;
            logsBindingSource.DataSource = refundList;

            for (int i = 0; i < logsBindingSource.List.Count; i++)
            {
                var cell = (DataGridViewCheckBoxCell)dgvLogs.Rows[i].Cells[0];
                cell.Value = 0;
            }

            StatBatch();
        }

        /// <summary>
        /// 
        /// </summary>
        public void ResetControlsStatus()
        {
            foreach (Control comp in panelRefundBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }

            batchBindingSource.DataSource = typeof(InvoiceRefundBatch);
            logsBindingSource.DataSource = typeof(InvoiceRefundLog);
        }

        //?Private?Methods?(19)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        private void ClickLog(InvoiceRefundLog log)
        {
            if (_totalPayment>0)
            {
                IList logList = logsBindingSource.List;
                decimal totalRefund = logList.Cast<object>().Where((t, i) => Boolean.Parse(dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString())).Cast<InvoiceRefundLog>().Sum(l => l.RefundAmount.GetValueOrDefault());

                log.RefundAmount = Math.Min(log.FinanceOutstanding.GetValueOrDefault(), _totalPayment - totalRefund);
            }
            else
            {
                log.RefundAmount = log.FinanceOutstanding.GetValueOrDefault();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            if (dgvLogs.CurrentCell == null)
            {
                return;
            }

            var selectedLog = (InvoiceRefundLog)logsBindingSource.List[dgvLogs.CurrentCell.RowIndex];
            var caseDetail = new CaseDetail(selectedLog.InvoiceFinanceLog.Invoice.InvoiceAssignBatch.Case,
                                            CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCDA(object sender, EventArgs e)
        {
            if (dgvLogs.CurrentCell == null)
            {
                return;
            }

            var selectedLog = (InvoiceRefundLog)logsBindingSource.List[dgvLogs.CurrentCell.RowIndex];
            var cdaDetail = new CDADetail(selectedLog.InvoiceFinanceLog.Invoice.InvoiceAssignBatch.Case.ActiveCDA,
                                          CDADetail.OpCDAType.DETAIL_CDA);
            cdaDetail.ShowDialog(this);
        }

        /// <summary>
        /// Show detail info of selected inovice
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailInvoice(object sender, EventArgs e)
        {
            if (dgvLogs.CurrentCell == null)
            {
                return;
            }

            var selectedLog = (InvoiceRefundLog)logsBindingSource.List[dgvLogs.CurrentCell.RowIndex];
            var invoiceDetail = new InvoiceDetail(selectedLog.InvoiceFinanceLog.Invoice,
                                                  InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
            invoiceDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            IList invoiceRefundList = logsBindingSource.List;
            var log = (InvoiceRefundLog)invoiceRefundList[e.RowIndex];
            dgvLogs.EndEdit();
            if (dgvLogs.Columns[e.ColumnIndex] == colCheckBox)
            {
                var checkBoxCell = (DataGridViewCheckBoxCell)dgvLogs.Rows[e.RowIndex].Cells[0];

                if (Boolean.Parse(checkBoxCell.EditedFormattedValue.ToString()))
                {
                    ClickLog(log);
                    ResetRow(e.RowIndex, true);
                }
                else
                {
                    ResetRow(e.RowIndex, false);
                }

                StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }

            DataGridViewColumn col = dgvLogs.Columns[e.ColumnIndex];
            if (col == colFinanceDate || col == colFinanceDueDate)
            {
                var date = (DateTime)e.Value;
                e.Value = date.ToString("yyyyMMdd");
                e.FormattingApplied = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesCellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }

            if (e.Value.Equals(string.Empty))
            {
                e.Value = null;
                e.ParsingApplied = true;
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue == null || e.FormattedValue.Equals(string.Empty))
            {
                return;
            }

            DataGridViewColumn col = dgvLogs.Columns[e.ColumnIndex];
            if (col == colRefundAmount)
            {
                var str = (string)e.FormattedValue;
                double result;
                bool ok = Double.TryParse(str, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }

                if (result < 0)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (dgvLogs.Columns[e.ColumnIndex] == colRefundAmount)
            {
                StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesRowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DetailInvoice(sender, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportBatch(object sender, EventArgs e)
        {
            if (_case == null)
            {
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(batchBindingSource.DataSource is InvoiceRefundBatch))
            {
                return;
            }

            if (logsBindingSource.List.Count == 0)
            {
                return;
            }

            var exportForm = new ExportForm(ExportForm.ExportType.EXPORT_REFUND_BY_BATCH, logsBindingSource.List);
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportBatch(object sender, EventArgs e)
        {
            if (_case == null)
            {
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(batchBindingSource.DataSource is InvoiceRefundBatch))
            {
                return;
            }

            var importForm = new ImportForm(ImportForm.ImportType.IMPORT_REFUND_BY_BATCH);
            importForm.ShowDialog(this);
            var logList = (List<InvoiceRefundLog>)importForm.ImportedList;
            if (logList != null)
            {
                for (int i = 0; i < logsBindingSource.List.Count; i++)
                {
                    var cell = (DataGridViewCheckBoxCell)dgvLogs.Rows[i].Cells[0];
                    cell.Value = 0;
                    var oldLog = (InvoiceRefundLog)logsBindingSource.List[i];

                    InvoiceRefundLog newLog = logList.SingleOrDefault(log => log.FinanceLogID2 == oldLog.FinanceLogID2);
                    if (newLog != null)
                    {
                        oldLog.RefundAmount = newLog.RefundAmount;
                        oldLog.Comment = newLog.Comment;


                        if (oldLog.RefundAmount>0)
                        {
                            cell.Value = 1;
                        }

                        ResetRow(i, 1 == (int)cell.Value ? true : false);
                    }
                }

                dgvLogs.Refresh();
                StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewBatch(object sender, EventArgs e)
        {
            if (_case == null)
            {
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            tbTotalRefund.Text = string.Empty;
            var batch = new InvoiceRefundBatch();
            switch (_refundType)
            {
                case OpRefundType.BUYER_PAYMENT:
                    batch.RefundType = REFUND.BUYER_PAYMENT;
                    break;
                case OpRefundType.SELLER_REFUND:
                    batch.RefundType = REFUND.SELLER_REFUND;
                    break;
                default:
                    break;
            }

            batch.RefundDate = DateTime.Now.Date;
            batch.CreateUserName = App.Current.CurUser.Name;
            //batch.CheckStatus = BATCH.UNCHECK;
            batchBindingSource.DataSource = batch;

            IQueryable<InvoiceFinanceLog> queryResult = from log in _context.InvoiceFinanceLogs
                                                        where log.Invoice.InvoiceAssignBatch.CaseCode == _case.CaseCode
                                                              &&
                                                              ((from refundLog in log.InvoiceRefundLogs select refundLog.RefundAmount).Sum().GetValueOrDefault() <
                                                               log.FinanceAmount.GetValueOrDefault() )
                                                               && log.Invoice.InvoiceFinanceBatches.All(f=>f.CheckStatus == BATCH.CHECK)
                                                        orderby log.FinanceDueDate
                                                        select log;

            var logs = new List<InvoiceRefundLog>();
            foreach (InvoiceFinanceLog financeLog in queryResult)
            {
                InvoiceRefundLog log = new InvoiceRefundLog(financeLog);
                logs.Add(log);
            }

            logsBindingSource.DataSource = logs;
            StatBatch();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCheckBoxClicked(object sender, DataGridViewCheckboxHeaderEventArgs e)
        {
            IList logList = logsBindingSource.List;
            foreach (DataGridViewRow dgvRow in dgvLogs.Rows)
            {
                var log = (InvoiceRefundLog)logList[dgvRow.Index];
                if (e.CheckedState)
                {
                    dgvRow.Cells[0].Value = true;
                    ClickLog(log);
                    ResetRow(dgvRow.Index, true);
                }
                else
                {
                    dgvRow.Cells[0].Value = false;
                    ResetRow(dgvRow.Index, false);
                }
            }

            dgvLogs.Refresh();
            StatBatch();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="editable"></param>
        private void ResetRow(int rowIndex, bool editable)
        {
            dgvLogs.Rows[rowIndex].Cells["colRefundAmount"].ReadOnly = !editable;

            if (!editable)
            {
                IList logList = logsBindingSource.List;
                var log = (InvoiceRefundLog)logList[rowIndex];
                log.RefundAmount = 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (_case == null)
            {
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!superValidator.Validate())
            {
                return;
            }

            if (!(batchBindingSource.DataSource is InvoiceRefundBatch))
            {
                return;
            }

            if (!ValidateBatch())
            {
                return;
            }

            bool isSaveOK = true;
            var batch = (InvoiceRefundBatch)batchBindingSource.DataSource;
            var logList = new List<InvoiceRefundLog>();

            try
            {
                batch.Case = _case;
                if (batch.RefundBatchNo == null)
                {
                    batch.RefundBatchNo = InvoiceRefundBatch.GenerateRefundBatchNo(batch.RefundDate);
                    batch.InputDate = DateTime.Today;
                    batch.CheckStatus = BATCH.UNCHECK;
                }
                for (int i = 0; i < logsBindingSource.List.Count; i++)
                {
                    if (Boolean.Parse(dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                    {
                        var log = (InvoiceRefundLog)logsBindingSource.List[i];
                        logList.Add(log);
                        log.InvoiceFinanceLog =
                            _context.InvoiceFinanceLogs.SingleOrDefault(fl => fl.FinanceLogID == log.FinanceLogID2);
                        log.InvoiceRefundBatch = batch;
                        log.InvoiceFinanceLog.Invoice.CaculateRefund();
                    }
                }
                if (batch.InvoiceRefundLogs.Count == 0)
                {
                    batch.Case = null;
                    batch.RefundBatchNo = null;
                    return;
                }

                batch.CaculateRefundAmount();

                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (InvoiceRefundLog log in logList)
                {
                    InvoiceFinanceLog financeLog = log.InvoiceFinanceLog;
                    log.InvoiceFinanceLog = null;
                    financeLog.Invoice.CaculateRefund();
                }

                isSaveOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isSaveOK)
            {
                MessageBoxEx.Show("数据保存成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                _caseBasic.CaculateOutstanding(_case);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBatch(object sender, EventArgs e)
        {
            if (_case == null)
            {
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var batchMgr = new RefundBatchMgr(_case, _context);
            var queryUI = new QueryForm(batchMgr, "选择付款批次");
            batchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoiceRefundBatch selectedBatch = batchMgr.Selected;
            if (selectedBatch != null)
            {
                logsBindingSource.DataSource = selectedBatch.InvoiceRefundLogs;

                for (int i = 0; i < logsBindingSource.List.Count; i++)
                {
                    var log = (InvoiceRefundLog)logsBindingSource.List[i];
                    log.InvoiceNo2 = log.InvoiceNo;

                    var cell = (DataGridViewCheckBoxCell)dgvLogs.Rows[i].Cells[0];
                    cell.Value = 1;
                    ResetRow(i, true);
                }

                StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void StatBatch()
        {
            IList refundLogList = logsBindingSource.List;
            decimal totalRefund = 0;
            for (int i = 0; i < refundLogList.Count; i++)
            {
                if (Boolean.Parse(dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    var refundLog = (InvoiceRefundLog)refundLogList[i];
                    decimal refundAmount = refundLog.RefundAmount.GetValueOrDefault();
                    if (refundLog.RefundCurrency != _case.InvoiceCurrency)
                    {
                        decimal rate = Exchange.GetExchangeRate(refundLog.RefundCurrency, _case.InvoiceCurrency);
                        refundAmount *= rate;
                    }

                    totalRefund += refundAmount;
                }
            }

            tbTotalRefund.Text = String.Format("{0:N2}", totalRefund);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidateBatch()
        {
            IList logList = logsBindingSource.List;

            //double totalRefund = 0;
            for (int i = 0; i < logList.Count; i++)
            {
                if (Boolean.Parse(dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    var log = (InvoiceRefundLog)logList[i];
                    if (log.FinanceAmount < log.RefundAmount)
                    {
                        MessageBoxEx.Show("还款金额不能大于融资余额: " + log.InvoiceNo2, MESSAGE.TITLE_INFORMATION,
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    //if (log.InvoiceFinanceLog == null)
                    //{
                    //    if (TypeUtil.LessZero(log.InvoicePaymentAmount - log.InvoiceRefundAmount - log.RefundAmount))
                    //    {
                    //        MessageBoxEx.Show("还款金额不能大于付款金额: " + log.InvoiceNo2, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        return false;
                    //    }
                    //}
                    //totalRefund += log.RefundAmount.GetValueOrDefault();
                }
            }

            //if (TypeUtil.GreaterZero(this.totalPayment))
            //{
            //    if (TypeUtil.GreaterZero(totalRefund - this.totalPayment))
            //    {
            //        MessageBoxEx.Show("本次还款总额不能大于付款总额", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return false;
            //    }
            //}

            return true;
        }
    }
}
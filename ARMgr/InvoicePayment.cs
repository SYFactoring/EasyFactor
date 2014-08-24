//-----------------------------------------------------------------------
// <copyright file="InvoicePayment.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
    public partial class InvoicePayment : UserControl
    {
        #region OpPaymentType enum

        /// <summary>
        /// 
        /// </summary>
        public enum OpPaymentType
        {
            /// <summary>
            /// 
            /// </summary>
            BUYER_PAYMENT,

            /// <summary>
            /// 
            /// </summary>
            INDIRECT_PAYMENT,

            /// <summary>
            /// 
            /// </summary>
            GUARANTEE_PAYMENT,

            /// <summary>
            /// 
            /// </summary>
            SELLER_REASSIGN,

            /// <summary>
            /// 
            /// </summary>
            CREDIT_NOTE_PAYMENT,
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
        private readonly OpPaymentType _paymentType;

        /// <summary>
        /// 
        /// </summary>
        private Case _case;


        /// <summary>
        /// 
        /// </summary>
        public InvoicePayment(ARCaseBasic caseBasic, OpPaymentType paymentType)
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
            _paymentType = paymentType;
            dgvLogs.AutoGenerateColumns = false;
            superValidator.Enabled = false;
            ControlUtil.SetDoubleBuffered(dgvLogs);

            foreach (DataGridViewColumn column in dgvLogs.Columns)
            {
                column.ReadOnly = true;
            }
            if (paymentType == OpPaymentType.CREDIT_NOTE_PAYMENT)
            {
                colCreditNoteDate2.Visible = true;
                colCreditNoteNo2.Visible = true;
            }
            else
            {
                colCreditNoteDate2.Visible = false;
                colCreditNoteNo2.Visible = false;
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


        //?Public?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        public void ResetControlsStatus()
        {
            foreach (Control comp in panelPaymentBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }

            batchBindingSource.DataSource = typeof(InvoicePaymentBatch);
            logsBindingSource.DataSource = typeof(InvoicePaymentLog);
        }

        //?Private?Methods?(19)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        private static void ClickLog(InvoicePaymentLog log)
        {
            log.PaymentAmount = log.AssignOutstanding;
            log.CreditNoteDate2 = DateTime.Now;
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

            var selectedLog = (InvoicePaymentLog)logsBindingSource.List[dgvLogs.CurrentCell.RowIndex];
            var caseDetail = new CaseDetail(selectedLog.Invoice.InvoiceAssignBatch.Case,
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

            var selectedLog = (InvoicePaymentLog)logsBindingSource.List[dgvLogs.CurrentCell.RowIndex];
            var cdaDetail = new CDADetail(selectedLog.Invoice.InvoiceAssignBatch.Case.ActiveCDA,
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

            var selectedLog = (InvoicePaymentLog)logsBindingSource.List[dgvLogs.CurrentCell.RowIndex];
            var invoiceDetail = new InvoiceDetail(selectedLog.Invoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
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

            IList logList = logsBindingSource.List;
            var log = (InvoicePaymentLog)logList[e.RowIndex];
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
            if (col == colAssignDate || col == colDueDate || col == colCreditNoteDate2)
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

            DataGridViewColumn col = dgvLogs.Columns[e.ColumnIndex];
            if (col == colCreditNoteDate2)
            {
                var str = (string)e.Value;
                e.Value = DateTime.ParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
                e.ParsingApplied = true;
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
            if (col == colCreditNoteDate2)
            {
                var str = (string)e.FormattedValue;
                DateTime result;
                bool ok = DateTime.TryParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None,
                                                 out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
            else if (col == colPaymentAmount)
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

            if (dgvLogs.Columns[e.ColumnIndex] == colPaymentAmount)
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

            if (!(batchBindingSource.DataSource is InvoicePaymentBatch))
            {
                return;
            }

            if (logsBindingSource.List.Count == 0)
            {
                return;
            }

            var exportForm = new ExportForm(ExportForm.ExportType.EXPORT_PAYMENT_BY_BATCH, logsBindingSource.List);
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

            if (!(batchBindingSource.DataSource is InvoicePaymentBatch))
            {
                return;
            }

            var importForm = new ImportForm(ImportForm.ImportType.IMPORT_PAYMENT_BY_BATCH);
            importForm.ShowDialog(this);
            var logList = (List<InvoicePaymentLog>)importForm.ImportedList;
            if (logList != null)
            {
                for (int i = 0; i < logsBindingSource.List.Count; i++)
                {
                    var cell = (DataGridViewCheckBoxCell)dgvLogs.Rows[i].Cells[0];
                    cell.Value = 0;
                    var oldLog = (InvoicePaymentLog)logsBindingSource.List[i];

                    InvoicePaymentLog newLog = logList.SingleOrDefault(log => log.InvoiceNo2 == oldLog.InvoiceNo2);
                    if (newLog != null)
                    {
                        oldLog.PaymentAmount = newLog.PaymentAmount;
                        oldLog.Comment = newLog.Comment;


                        if (oldLog.PaymentAmount>0)
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

            tbTotalPayment.Text = string.Empty;
            var batch = new InvoicePaymentBatch();
            switch (_paymentType)
            {
                case OpPaymentType.BUYER_PAYMENT:
                    batch.PaymentType = PAYMENT.BUYER_PAYMENT;
                    break;
                case OpPaymentType.INDIRECT_PAYMENT:
                    batch.PaymentType = PAYMENT.INDIRECT_PAYMENT;
                    break;
                case OpPaymentType.GUARANTEE_PAYMENT:
                    batch.PaymentType = PAYMENT.GUARANTEE_PAYMENT;
                    break;
                case OpPaymentType.SELLER_REASSIGN:
                    batch.PaymentType = PAYMENT.SELLER_REASSIGN;
                    break;
                case OpPaymentType.CREDIT_NOTE_PAYMENT:
                    batch.PaymentType = PAYMENT.CREDIT_NOTE_PAYMENT;
                    break;
                default:
                    break;
            }

            batch.PaymentDate = DateTime.Now.Date;
            batch.CreateUserName = App.Current.CurUser.Name;
            //batch.CheckStatus = BATCH.UNCHECK;
            batchBindingSource.DataSource = batch;

            IQueryable<Invoice> queryResult = from invoice in _context.Invoices
                                              where
                                                  invoice.InvoiceAssignBatch.CaseCode == _case.CaseCode &&
                                                  (invoice.PaymentAmount.GetValueOrDefault() < invoice.AssignAmount)
                                                  && invoice.InvoiceAssignBatch.CheckStatus == BATCH.CHECK
                                              orderby invoice.InvoiceAssignBatch.AssignDate
                                              select invoice;

            var logs = new List<InvoicePaymentLog>();
            foreach (Invoice invoice in queryResult)
            {
                InvoicePaymentLog log = new InvoicePaymentLog(invoice);
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
                var log = (InvoicePaymentLog)logList[dgvRow.Index];
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
            dgvLogs.Rows[rowIndex].Cells["colPaymentAmount"].ReadOnly = !editable;
            dgvLogs.Rows[rowIndex].Cells["colCreditNoteNo2"].ReadOnly = !editable;
            dgvLogs.Rows[rowIndex].Cells["colCreditNoteDate2"].ReadOnly = !editable;
            if (!editable)
            {
                var log = (InvoicePaymentLog)logsBindingSource.List[rowIndex];
                log.PaymentAmount = 0;
                if (log.CreditNote != null)
                {
                    log.CreditNoteDate2 = default(DateTime);
                    log.CreditNoteNo2 = null;
                }
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

            if (!(batchBindingSource.DataSource is InvoicePaymentBatch))
            {
                return;
            }

            if (!ValidateBatch())
            {
                return;
            }

            bool isSaveOK = true;
            var batch = (InvoicePaymentBatch)batchBindingSource.DataSource;
            var logList = new List<InvoicePaymentLog>();
            var invoiceList = new List<Invoice>();

            try
            {
                batch.Case = _case;
                if (batch.PaymentBatchNo == null)
                {
                    batch.PaymentBatchNo = InvoicePaymentBatch.GeneratePaymentBatchNo(batch.PaymentDate);
                    batch.InputDate = DateTime.Today;
                    batch.CheckStatus = BATCH.UNCHECK;
                }

                for (int i = 0; i < logsBindingSource.List.Count; i++)
                {
                    if (Boolean.Parse(dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                    {
                        var log = (InvoicePaymentLog)logsBindingSource.List[i];
                        log.Invoice = _context.Invoices.SingleOrDefault(invoice => invoice.InvoiceID == log.InvoiceID2);
                        logList.Add(log);
                        log.InvoicePaymentBatch = batch;
                        log.Invoice.CaculatePayment();

                        if (log.Invoice.FinanceOutstanding > 0 && !invoiceList.Contains(log.Invoice))
                        {
                            invoiceList.Add(log.Invoice);
                        }

                        if (!String.IsNullOrEmpty(log.CreditNoteNo2))
                        {
                            var note = new CreditNote
                                           {
                                               CreditNoteNo = log.CreditNoteNo2,
                                               CreditNoteDate = log.CreditNoteDate2.GetValueOrDefault(),
                                               InvoiceAssignBatch = log.Invoice.InvoiceAssignBatch
                                           };
                            log.CreditNote = note;
                        }
                    }
                }

                if (batch.InvoicePaymentLogs.Count == 0)
                {
                    batch.Case = null;
                    batch.PaymentBatchNo = null;
                    return;
                }

                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (InvoicePaymentLog log in logList)
                {
                    Invoice invoice = log.Invoice;
                    log.Invoice = null;
                    log.InvoicePaymentBatch = null;
                    log.CreditNote = null;
                    invoice.CaculatePayment();
                }

                batch.Case = null;
                isSaveOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isSaveOK)
            {
                MessageBoxEx.Show("数据保存成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                _caseBasic.CaculateOutstanding(_case);
                if (invoiceList.Count > 0)
                {
                    MainWindow mainWindow = App.Current.MainWindow;
                    mainWindow.InvoiceRefundFromPayment(invoiceList, batch);
                }
                else
                {
                    NewBatch(null, null);
                }
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

            var batchMgr = new PaymentBatchMgr(_case, _context);
            var queryUI = new QueryForm(batchMgr, "选择付款批次");
            batchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoicePaymentBatch selectedBatch = batchMgr.Selected;
            if (selectedBatch != null)
            {
                batchBindingSource.DataSource = selectedBatch;

                logsBindingSource.DataSource = selectedBatch.InvoicePaymentLogs;
                for (int i = 0; i < logsBindingSource.List.Count; i++)
                {
                    var log = (InvoicePaymentLog)logsBindingSource.List[i];
                    log.InvoiceNo2 = log.Invoice.InvoiceNo;
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
            IList logList = logsBindingSource.List;
            decimal totalPayment = logList.Cast<object>().Where((t, i) => Boolean.Parse(dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString())).Sum(t => ((InvoicePaymentLog)t).PaymentAmount.GetValueOrDefault());

            tbTotalPayment.Text = String.Format("{0:N2}", totalPayment);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidateBatch()
        {
            IList logList = logsBindingSource.List;

            for (int i = 0; i < logList.Count; i++)
            {
                if (Boolean.Parse(dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    var log = (InvoicePaymentLog)logList[i];
                    if (log.AssignOutstanding<0)
                    {
                        MessageBoxEx.Show("付款金额不能大于转让金额: " + log.InvoiceNo2, MESSAGE.TITLE_INFORMATION,
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    //if (TypeUtil.GreaterZero(log.PaymentAmount - log.FinanceOutstanding))
                    //{
                    //    if (batch.PaymentType == "贷项通知")
                    //    {
                    //        MessageBoxEx.Show("账款调整金额大于融资余额，需要求客户偿还融资款差额后，才可调整: " + log.InvoiceNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        return false;
                    //    }
                    //    if (batch.PaymentType == "卖方回购")
                    //    {
                    //        MessageBoxEx.Show("回购金额大于融资余额，需要求客户偿还融资款差额后，才可调整: " + log.InvoiceNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        return false;
                    //    }
                    //}
                }
            }
            return true;
        }
    }
}
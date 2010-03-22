//-----------------------------------------------------------------------
// <copyright file="InvoiceRefund.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar;
    using CMBC.EasyFactor.Controls;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceRefund : UserControl
    {
        #region Fields (4)

        /// <summary>
        /// 
        /// </summary>
        private Case _case;
        /// <summary>
        /// 
        /// </summary>
        private ARCaseBasic caseBasic;
        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;
        /// <summary>
        /// 
        /// </summary>
        private OpRefundType refundType;

        #endregion Fields

        #region Enums (1)

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
            INDIRECT_PAYMENT,

            /// <summary>
            /// 
            /// </summary>
            SELLER_REFUND,

            /// <summary>
            /// 
            /// </summary>
            GUARANTEE_PAYMENT,
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        public InvoiceRefund(ARCaseBasic caseBasic, OpRefundType refundType)
        {
            InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.dgvLogs.ImeMode = ImeMode.OnHalf;

            DataGridViewCheckboxHeaderCell checkBoxCell = new DataGridViewCheckboxHeaderCell();
            checkBoxCell.OnCheckBoxClicked += new DataGridViewCheckboxHeaderEventHander(OnCheckBoxClicked);
            DataGridViewCheckBoxColumn checkBoxCol = this.dgvLogs.Columns[0] as DataGridViewCheckBoxColumn;
            checkBoxCol.HeaderCell = checkBoxCell;
            checkBoxCol.HeaderCell.Value = string.Empty;

            this.caseBasic = caseBasic;
            this.refundType = refundType;
            this.dgvLogs.AutoGenerateColumns = false;
            this.superValidator.Enabled = false;
            ControlUtil.SetDoubleBuffered(this.dgvLogs);

            foreach (DataGridViewColumn column in this.dgvLogs.Columns)
            {
                column.ReadOnly = true;
            }

            colCheckBox.ReadOnly = false;

            this.context = new DBDataContext();
        }

        #endregion Constructors

        #region Properties (1)

        /// <summary>
        /// 
        /// </summary>
        public Case Case
        {
            set
            {
                this._case = this.context.Cases.SingleOrDefault(c => c.CaseCode == value.CaseCode);
                this.NewBatch(null, null);
            }
        }

        #endregion Properties

        #region Methods (21)

        // Public Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        /// <param name="refundType"></param>
        /// <param name="date"></param>
        public void NewBatchFromPayment(List<Invoice> invoiceList, String refundType, DateTime date)
        {
            if (invoiceList == null || invoiceList.Count == 0)
            {
                return;
            }

            this._case = context.Cases.SingleOrDefault(c => c.CaseCode == invoiceList[0].InvoiceAssignBatch.Case.CaseCode);
            this.caseBasic.Case = this._case;

            List<InvoiceRefundLog> refundList = new List<InvoiceRefundLog>();
            foreach (Invoice invoice in invoiceList)
            {
                Invoice newInvoice = context.Invoices.SingleOrDefault(i => i.InvoiceNo == invoice.InvoiceNo);
                foreach (InvoiceFinanceLog financeLog in newInvoice.InvoiceFinanceLogs)
                {
                    InvoiceRefundLog refundLog = new InvoiceRefundLog();
                    refundLog.InvoiceFinanceLog = financeLog;
                    refundList.Add(refundLog);
                }
            }


            this.tbTotalRefund.Text = string.Empty;
            InvoiceRefundBatch batch = new InvoiceRefundBatch();
            batch.RefundType = refundType;
            batch.RefundDate = date;
            batch.CreateUserName = App.Current.CurUser.Name;
            batch.CheckStatus = "未复核";
            this.batchBindingSource.DataSource = batch;
            this.logsBindingSource.DataSource = refundList;

            for (int i = 0; i < this.logsBindingSource.List.Count; i++)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvLogs.Rows[i].Cells[0];
                cell.Value = 1;
                InvoiceRefundLog log = (InvoiceRefundLog)logsBindingSource.List[i];
                log.RefundAmount = log.FinanceOutstanding.GetValueOrDefault();
            }

            this.StatBatch();
        }

        /// <summary>
        /// 
        /// </summary>
        public void ResetControlsStatus()
        {
            foreach (Control comp in this.panelRefundBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }

            this.batchBindingSource.DataSource = typeof(InvoiceRefundBatch);
            this.logsBindingSource.DataSource = typeof(InvoiceRefundLog);
        }
        // Private Methods (19) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        private void ClickLog(InvoiceRefundLog log)
        {
            log.RefundAmount = log.FinanceOutstanding.GetValueOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            if (this.dgvLogs.CurrentCell == null)
            {
                return;
            }

            InvoiceRefundLog selectedLog = (InvoiceRefundLog)this.logsBindingSource.List[this.dgvLogs.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedLog.InvoiceFinanceLog.Invoice.InvoiceAssignBatch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCDA(object sender, EventArgs e)
        {
            if (this.dgvLogs.CurrentCell == null)
            {
                return;
            }

            InvoiceRefundLog selectedLog = (InvoiceRefundLog)this.logsBindingSource.List[this.dgvLogs.CurrentCell.RowIndex];
            CDADetail cdaDetail = new CDADetail(selectedLog.InvoiceFinanceLog.Invoice.InvoiceAssignBatch.Case.ActiveCDA, CDADetail.OpCDAType.DETAIL_CDA);
            cdaDetail.ShowDialog(this);
        }

        /// <summary>
        /// Show detail info of selected inovice
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailInvoice(object sender, System.EventArgs e)
        {
            if (this.dgvLogs.CurrentCell == null)
            {
                return;
            }

            InvoiceRefundLog selectedLog = (InvoiceRefundLog)this.logsBindingSource.List[this.dgvLogs.CurrentCell.RowIndex];
            InvoiceDetail invoiceDetail = new InvoiceDetail(selectedLog.InvoiceFinanceLog.Invoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
            invoiceDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            IList invoiceRefundList = this.logsBindingSource.List;
            InvoiceRefundLog log = (InvoiceRefundLog)invoiceRefundList[e.RowIndex];
            this.dgvLogs.EndEdit();
            if (this.dgvLogs.Columns[e.ColumnIndex] == colCheckBox)
            {

                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)this.dgvLogs.Rows[e.RowIndex].Cells[0];

                if (Boolean.Parse(checkBoxCell.EditedFormattedValue.ToString()))
                {
                    ClickLog(log);
                    this.ResetRow(e.RowIndex, true);
                }
                else
                {
                    this.ResetRow(e.RowIndex, false);
                }

                this.StatBatch();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }

            DataGridViewColumn col = this.dgvLogs.Columns[e.ColumnIndex];
            if (col == this.colFinanceDate || col == this.colFinanceDueDate)
            {
                DateTime date = (DateTime)e.Value;
                e.Value = date.ToString("yyyyMMdd");
                e.FormattingApplied = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dgvInvoices_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
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

            DataGridViewColumn col = this.dgvLogs.Columns[e.ColumnIndex];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue == null || e.FormattedValue.Equals(string.Empty))
            {
                return;
            }

            DataGridViewColumn col = this.dgvLogs.Columns[e.ColumnIndex];
            if (col == this.colRefundAmount)
            {
                string str = (string)e.FormattedValue;
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
        private void dgvInvoices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (this.dgvLogs.Columns[e.ColumnIndex] == colRefundAmount)
            {
                this.StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.DetailInvoice(null, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportBatch(object sender, EventArgs e)
        {
            if (this._case == null)
            {
                MessageBoxEx.Show("没有选定案件", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.batchBindingSource.DataSource is InvoiceRefundBatch))
            {
                return;
            }

            if (this.logsBindingSource.List.Count == 0)
            {
                return;
            }

            ExportForm exportForm = new ExportForm(ExportForm.ExportType.EXPORT_REFUND_BY_BATCH, this.logsBindingSource.List);
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportBatch(object sender, EventArgs e)
        {
            if (this._case == null)
            {
                MessageBoxEx.Show("没有选定案件", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.batchBindingSource.DataSource is InvoiceRefundBatch))
            {
                return;
            }

            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_REFUND_BY_BATCH, context);
            importForm.ShowDialog(this);
            IList logList = importForm.ImportedList;
            if (logList != null)
            {
                for (int i = 0; i < this.logsBindingSource.List.Count; i++)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvLogs.Rows[i].Cells[0];
                    cell.Value = 0;
                    InvoiceRefundLog oldLog = (InvoiceRefundLog)this.logsBindingSource.List[i];
                    if (logList.Contains(oldLog) && oldLog.RefundAmount > 0)
                    {
                        cell.Value = 1;
                    }

                    this.ResetRow(i, 1 == (int)cell.Value ? true : false);
                }

                this.StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewBatch(object sender, EventArgs e)
        {
            if (this._case == null)
            {
                MessageBoxEx.Show("没有选定案件", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.tbTotalRefund.Text = string.Empty;
            InvoiceRefundBatch batch = new InvoiceRefundBatch();
            switch (refundType)
            {
                case OpRefundType.BUYER_PAYMENT:
                    batch.RefundType = "买方还款";
                    break;
                case OpRefundType.INDIRECT_PAYMENT:
                    batch.RefundType = "间接还款";
                    break;
                case OpRefundType.SELLER_REFUND:
                    batch.RefundType = "卖方还款";
                    break;
                case OpRefundType.GUARANTEE_PAYMENT:
                    batch.RefundType = "担保付款";
                    break;
                default:
                    break;
            }

            batch.RefundDate = DateTime.Now.Date;
            batch.CreateUserName = App.Current.CurUser.Name;
            batch.CheckStatus = "未复核";
            this.batchBindingSource.DataSource = batch;

            var queryResult = from log in context.InvoiceFinanceLogs
                              where log.Invoice.InvoiceAssignBatch.CaseCode == this._case.CaseCode
                              && (log.Invoice.RefundAmount.GetValueOrDefault() - log.Invoice.FinanceAmount.GetValueOrDefault() < -0.0001)
                              select log;

            List<InvoiceRefundLog> result = new List<InvoiceRefundLog>();
            foreach (InvoiceFinanceLog financeLog in queryResult)
            {
                if (financeLog.InvoiceFinanceBatch.CheckStatus == "已复核")
                {
                    InvoiceRefundLog refundLog = new InvoiceRefundLog();
                    refundLog.InvoiceFinanceLog = financeLog;
                    result.Add(refundLog);
                }
            }

            this.logsBindingSource.DataSource = result;
            this.StatBatch();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCheckBoxClicked(object sender, DataGridViewCheckboxHeaderEventArgs e)
        {
            this.dgvLogs.EndEdit();
            IList logList = this.logsBindingSource.List;
            foreach (DataGridViewRow dgvRow in this.dgvLogs.Rows)
            {
                InvoiceRefundLog log = (InvoiceRefundLog)logList[dgvRow.Index];
                if (e.CheckedState)
                {
                    dgvRow.Cells[0].Value = true;
                    ClickLog(log);
                    this.ResetRow(dgvRow.Index, true);
                }
                else
                {
                    dgvRow.Cells[0].Value = false;
                    this.ResetRow(dgvRow.Index, false);
                }
            }

            this.StatBatch();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="editable"></param>
        private void ResetRow(int rowIndex, bool editable)
        {
            this.dgvLogs.Rows[rowIndex].Cells["colRefundAmount"].ReadOnly = !editable;

            if (!editable)
            {
                IList logList = this.logsBindingSource.List;
                InvoiceRefundLog log = (InvoiceRefundLog)logList[rowIndex];
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
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            if (this._case == null)
            {
                MessageBoxEx.Show("没有选定案件", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!this.superValidator.Validate())
            {
                return;
            }

            if (!(this.batchBindingSource.DataSource is InvoiceRefundBatch))
            {
                return;
            }

            if (!ValidateBatch())
            {
                return;
            }

            bool isSaveOK = true;
            InvoiceRefundBatch batch = (InvoiceRefundBatch)this.batchBindingSource.DataSource;
            List<InvoiceRefundLog> logList = new List<InvoiceRefundLog>();
            try
            {
                batch.Case = this._case;
                if (batch.RefundBatchNo == null)
                {
                    batch.RefundBatchNo = InvoiceRefundBatch.GenerateRefundBatchNo(batch.RefundDate);
                }
                for (int i = 0; i < this.logsBindingSource.List.Count; i++)
                {
                    if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                    {
                        InvoiceRefundLog log = (InvoiceRefundLog)this.logsBindingSource.List[i];
                        logList.Add(log);
                        log.InvoiceRefundBatch = batch;
                        log.InvoiceFinanceLog.Invoice.CaculateRefund();
                    }
                }
                if (batch.InvoiceRefundLogs.Count == 0)
                {
                    return;
                }

                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (InvoiceRefundLog log in logList)
                {
                    InvoiceFinanceLog financeLog = log.InvoiceFinanceLog;
                    financeLog.InvoiceRefundLogs.Remove(log);
                    financeLog.Invoice.CaculateRefund();
                }

                isSaveOK = false;
                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isSaveOK)
            {
                MessageBoxEx.Show("数据保存成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.caseBasic.CaculateOutstanding(this._case);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBatch(object sender, EventArgs e)
        {
            if (this._case == null)
            {
                MessageBoxEx.Show("没有选定案件", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RefundBatchMgr batchMgr = new RefundBatchMgr(this._case, this.context);
            QueryForm queryUI = new QueryForm(batchMgr, "选择付款批次");
            batchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoiceRefundBatch selectedBatch = batchMgr.Selected;
            if (selectedBatch != null)
            {
                this.logsBindingSource.DataSource = selectedBatch.InvoiceRefundLogs;

                for (int i = 0; i < this.logsBindingSource.List.Count; i++)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvLogs.Rows[i].Cells[0];
                    cell.Value = 1;
                    ResetRow(i, true);
                }

                this.StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void StatBatch()
        {
            IList refundLogList = this.logsBindingSource.List;
            double totalRefund = 0;
            double totalPayment = 0;
            for (int i = 0; i < refundLogList.Count; i++)
            {
                if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    //totalPayment += ((InvoiceRefundLog)refundLogList[i]).PaymentAmount.GetValueOrDefault();
                    totalRefund += ((InvoiceRefundLog)refundLogList[i]).RefundAmount.GetValueOrDefault();
                }
            }

            this.tbTotalPayment.Text = String.Format("{0:N2}", totalPayment);
            this.tbTotalRefund.Text = String.Format("{0:N2}", totalRefund);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidateBatch()
        {
            IList invoiceList = this.logsBindingSource.List;

            for (int i = 0; i < invoiceList.Count; i++)
            {
                if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    Invoice invoice = (Invoice)invoiceList[i];
                    if (TypeUtil.LessZero(invoice.FinanceOutstanding))
                    {
                        MessageBoxEx.Show("还款金额不能大于融资金额: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    //double paymentAmount = invoice.PaymentAmount.GetValueOrDefault();
                    //if (invoice.InvoiceAssignBatch.BatchCurrency != invoice.InvoiceFinanceBatch.BatchCurrency)
                    //{
                    //    double exchangeRate = Exchange.GetExchangeRate(invoice.InvoiceAssignBatch.BatchCurrency, invoice.InvoiceFinanceBatch.BatchCurrency);
                    //    paymentAmount *= exchangeRate;
                    //}

                    //if (invoice.PaymentAmount.HasValue)
                    //{
                    //    if (TypeUtil.GreaterZero(invoice.RefundAmount - Math.Min(invoice.FinanceOutstanding.GetValueOrDefault(), paymentAmount)))
                    //    {
                    //        MessageBoxEx.Show("还款金额不能大于付款金额: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        return false;
                    //    }
                    //}
                    //else
                    //{
                    //    if (TypeUtil.GreaterZero(invoice.RefundAmount - invoice.FinanceOutstanding.GetValueOrDefault()))
                    //    {
                    //        MessageBoxEx.Show("还款金额不能大于融资余额: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        return false;
                    //    }
                    //}
                }
            }
            return true;
        }

        #endregion Methods
    }
}

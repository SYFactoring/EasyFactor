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
    using CMBC.EasyFactor.Utils.ConstStr;

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

        /// <summary>
        /// 
        /// </summary>
        private double totalPayment = 0;

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
            SELLER_REFUND,
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
            get
            {
                return this._case;
            }
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
        /// <param name="batch"></param>
        public void NewBatchFromPayment(List<Invoice> invoiceList, InvoicePaymentBatch paymentBatch)
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
                    InvoiceRefundLog refundLog = new InvoiceRefundLog(financeLog);
                    refundList.Add(refundLog);
                }
            }

            totalPayment = paymentBatch.InvoicePaymentLogs.Sum(log => log.PaymentAmount).GetValueOrDefault();
            this.tbTotalPayment.Text = String.Format("{0:N2}", totalPayment);
            this.tbTotalRefund.Text = string.Empty;
            InvoiceRefundBatch batch = new InvoiceRefundBatch();
            batch.RefundType = paymentBatch.PaymentType;
            batch.RefundDate = paymentBatch.PaymentDate;
            batch.CreateUserName = App.Current.CurUser.Name;
            batch.CheckStatus = BATCH.UNCHECK;
            this.batchBindingSource.DataSource = batch;
            this.logsBindingSource.DataSource = refundList;

            for (int i = 0; i < this.logsBindingSource.List.Count; i++)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvLogs.Rows[i].Cells[0];
                cell.Value = 0;
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
            if (TypeUtil.GreaterZero(this.totalPayment))
            {
                IList logList = this.logsBindingSource.List;
                double totalRefund = 0;
                for (int i = 0; i < logList.Count; i++)
                {
                    if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                    {
                        InvoiceRefundLog l = (InvoiceRefundLog)logList[i];
                        totalRefund += l.RefundAmount.GetValueOrDefault();
                    }
                }

                log.RefundAmount = Math.Min(log.FinanceOutstanding.GetValueOrDefault(), totalPayment - totalRefund);
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
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.batchBindingSource.DataSource is InvoiceRefundBatch))
            {
                return;
            }

            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_REFUND_BY_BATCH, context);
            importForm.ShowDialog(this);
            List<InvoiceRefundLog> logList = (List<InvoiceRefundLog>)importForm.ImportedList;
            if (logList != null)
            {
                for (int i = 0; i < this.logsBindingSource.List.Count; i++)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvLogs.Rows[i].Cells[0];
                    cell.Value = 0;
                    InvoiceRefundLog oldLog = (InvoiceRefundLog)this.logsBindingSource.List[i];

                    InvoiceRefundLog newLog = logList.SingleOrDefault(log => log.InvoiceNo2 == oldLog.InvoiceNo2);
                    if (newLog != null)
                    {
                        oldLog.RefundAmount = newLog.RefundAmount;
                        oldLog.Comment = newLog.Comment;


                        if (TypeUtil.GreaterZero(oldLog.RefundAmount))
                        {
                            cell.Value = 1;
                        }

                        this.ResetRow(i, 1 == (int)cell.Value ? true : false);
                    }
                }

                this.dgvLogs.Refresh();
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
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.tbTotalRefund.Text = string.Empty;
            InvoiceRefundBatch batch = new InvoiceRefundBatch();
            switch (refundType)
            {
                case OpRefundType.BUYER_PAYMENT:
                    batch.RefundType = "买方直接还款";
                    break;
                case OpRefundType.SELLER_REFUND:
                    batch.RefundType = "卖方还款";
                    break;
                default:
                    break;
            }

            batch.RefundDate = DateTime.Now.Date;
            batch.CreateUserName = App.Current.CurUser.Name;
            batch.CheckStatus = BATCH.UNCHECK;
            this.batchBindingSource.DataSource = batch;

            var queryResult = from log in context.InvoiceFinanceLogs
                              where log.Invoice.InvoiceAssignBatch.CaseCode == this._case.CaseCode
                              && (log.Invoice.RefundAmount.GetValueOrDefault() - log.Invoice.FinanceAmount.GetValueOrDefault() < -0.0001)
                              select log;

            List<InvoiceRefundLog> result = new List<InvoiceRefundLog>();
            foreach (InvoiceFinanceLog financeLog in queryResult)
            {
                if (financeLog.InvoiceFinanceBatch.CheckStatus == BATCH.CHECK)
                {
                    InvoiceRefundLog refundLog = new InvoiceRefundLog(financeLog);
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

            this.dgvLogs.Refresh();
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
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    batch.InputDate = DateTime.Today;
                }
                for (int i = 0; i < this.logsBindingSource.List.Count; i++)
                {
                    if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                    {
                        InvoiceRefundLog log = (InvoiceRefundLog)this.logsBindingSource.List[i];
                        logList.Add(log);
                        log.InvoiceFinanceLog = context.InvoiceFinanceLogs.SingleOrDefault(fl => fl.FinanceLogID == log.FinanceLogID2);
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

                context.SubmitChanges();
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
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    InvoiceRefundLog log = (InvoiceRefundLog)this.logsBindingSource.List[i];
                    log.InvoiceNo2 = log.InvoiceNo;

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
            for (int i = 0; i < refundLogList.Count; i++)
            {
                if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    InvoiceRefundLog refundLog = (InvoiceRefundLog)refundLogList[i];
                    double refundAmount = refundLog.RefundAmount.GetValueOrDefault();
                    if (refundLog.RefundCurrency != this._case.InvoiceCurrency)
                    {
                        double rate = Exchange.GetExchangeRate(refundLog.RefundCurrency, this._case.InvoiceCurrency);
                        refundAmount *= rate;
                    }

                    totalRefund += refundAmount;
                }
            }

            this.tbTotalRefund.Text = String.Format("{0:N2}", totalRefund);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidateBatch()
        {
            IList logList = this.logsBindingSource.List;

            //double totalRefund = 0;
            for (int i = 0; i < logList.Count; i++)
            {
                if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    InvoiceRefundLog log = (InvoiceRefundLog)logList[i];
                    if (TypeUtil.LessZero(log.FinanceAmount - log.RefundAmount))
                    {
                        MessageBoxEx.Show("还款金额不能大于融资余额: " + log.InvoiceNo2, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #endregion Methods
    }
}

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

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceRefund : UserControl
    {
        #region Fields (3)

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
        private OpRefundType refundType;

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;

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
            this.caseBasic = caseBasic;
            this.refundType = refundType;
            this.dgvInvoices.AutoGenerateColumns = false;
            this.superValidator.Enabled = false;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);

            foreach (DataGridViewColumn column in this.dgvInvoices.Columns)
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

        #region Methods (19)

        // Public Methods (2) 

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
            this.invoiceBindingSource.DataSource = typeof(Invoice);
        }
        // Private Methods (17) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[this.dgvInvoices.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedInvoice.InvoiceAssignBatch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCDA(object sender, EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[this.dgvInvoices.CurrentCell.RowIndex];
            CDADetail cdaDetail = new CDADetail(selectedInvoice.InvoiceAssignBatch.Case.ActiveCDA, CDADetail.OpCDAType.DETAIL_CDA);
            cdaDetail.ShowDialog(this);
        }

        /// <summary>
        /// Show detail info of selected inovice
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailInvoice(object sender, System.EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[this.dgvInvoices.CurrentCell.RowIndex];
            InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
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

            IList invoiceRefundList = this.invoiceBindingSource.List;
            Invoice invoice = (Invoice)invoiceRefundList[e.RowIndex];
            this.dgvInvoices.EndEdit();
            if (this.dgvInvoices.Columns[e.ColumnIndex] == colCheckBox)
            {

                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)this.dgvInvoices.Rows[e.RowIndex].Cells[0];

                if (Boolean.Parse(checkBoxCell.EditedFormattedValue.ToString()))
                {
                    invoice.RefundAmount2 = Math.Min(invoice.FinanceOutstanding.GetValueOrDefault(), invoice.PaymentAmount2.GetValueOrDefault());
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

            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == this.colAssignDate || col == this.colDueDate || col == this.colFinanceDate || col == this.colFinanceDueDate)
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

            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
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

            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == this.colRefundAmount2)
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

            if (this.dgvInvoices.Columns[e.ColumnIndex] == colRefundAmount2)
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

            if (this.invoiceBindingSource.List.Count == 0)
            {
                return;
            }

            ExportForm exportForm = new ExportForm(ExportForm.ExportType.EXPORT_REFUND_BY_BATCH, this.invoiceBindingSource.List);
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
            IList invoiceList = importForm.ImportedList;
            if (invoiceList != null)
            {
                for (int i = 0; i < this.invoiceBindingSource.List.Count; i++)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvInvoices.Rows[i].Cells[0];
                    cell.Value = 0;
                    Invoice oldInvoice = (Invoice)this.invoiceBindingSource.List[i];
                    if (invoiceList.Contains(oldInvoice) && oldInvoice.RefundAmount2 > 0)
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
        /// <param name="refundList"></param>
        public void NewBatch(List<Invoice> refundList, String refundType)
        {
            if (refundList == null || refundList.Count == 0)
            {
                return;
            }

            this.caseBasic.Case = refundList[0].InvoiceAssignBatch.Case;
            this._case = refundList[0].InvoiceAssignBatch.Case;
            this.tbTotalRefund.Text = string.Empty;
            InvoiceRefundBatch batch = new InvoiceRefundBatch();
            batch.RefundType = refundType;
            batch.RefundDate = DateTime.Now.Date;
            batch.CreateUserName = App.Current.CurUser.Name;
            batch.CheckStatus = "未复核";
            this.batchBindingSource.DataSource = batch;
            this.invoiceBindingSource.DataSource = refundList;

            for (int i = 0; i < this.invoiceBindingSource.List.Count; i++)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvInvoices.Rows[i].Cells[0];
                cell.Value = 1;
                Invoice invoice = (Invoice)invoiceBindingSource.List[i];
                invoice.RefundAmount2 = Math.Min(invoice.FinanceOutstanding.GetValueOrDefault(), invoice.PaymentAmount2.GetValueOrDefault());
            }

            this.StatBatch();
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

            var queryResult = from invoice in context.Invoices
                              where invoice.InvoiceAssignBatch.CaseCode == this._case.CaseCode && invoice.InvoiceFinanceBatch.CheckStatus == "已复核" && (invoice.RefundAmount.GetValueOrDefault() - invoice.FinanceAmount.GetValueOrDefault() < -0.00000001)
                              select invoice;
            this.invoiceBindingSource.DataSource = queryResult;
            this.StatBatch();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="editable"></param>
        private void ResetRow(int rowIndex, bool editable)
        {
            this.dgvInvoices.Rows[rowIndex].Cells["colRefundAmount2"].ReadOnly = !editable;

            if (!editable)
            {
                IList invoiceList = this.invoiceBindingSource.List;
                Invoice invoice = (Invoice)invoiceList[rowIndex];
                invoice.RefundAmount2 = null;
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
            IList invoiceList = this.invoiceBindingSource.List;
            List<InvoiceRefundLog> logList = new List<InvoiceRefundLog>();
            try
            {
                batch.Case = this._case;
                if (batch.RefundBatchNo == null)
                {
                    batch.RefundBatchNo = Invoice.GenerateRefundBatchNo(batch.RefundDate);
                }
                for (int i = 0; i < invoiceList.Count; i++)
                {
                    if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                    {
                        Invoice invoice = (Invoice)invoiceList[i];
                        InvoiceRefundLog log;
                        if (invoice.RefundLogID2 == null)
                        {
                            log = new InvoiceRefundLog();
                            logList.Add(log);
                        }
                        else
                        {
                            log = context.InvoiceRefundLogs.SingleOrDefault(refundlog => refundlog.RefundLogID == invoice.RefundLogID2);
                            if (log == null)
                            {
                                throw new Exception("还款ID错误");
                            }
                        }

                        log.Invoice = invoice;
                        log.RefundAmount = invoice.RefundAmount2.GetValueOrDefault();
                        log.InvoiceRefundBatch = batch;
                        invoice.CaculateRefund();
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
                    Invoice invoice = log.Invoice;
                    invoice.InvoiceRefundLogs.Remove(log);
                    invoice.CaculateRefund();
                    log.InvoiceRefundBatch = null;
                }

                batch.Case = null;
                isSaveOK = false;
                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isSaveOK)
            {
                MessageBoxEx.Show("数据保存成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (InvoiceRefundLog log in logList)
                {
                    Invoice invoice = log.Invoice;
                    invoice.RefundAmount2 = null;
                }

                context.SubmitChanges();
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

            RefundBatchMgr batchMgr = new RefundBatchMgr(this._case);
            QueryForm queryUI = new QueryForm(batchMgr, "选择付款批次");
            batchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoiceRefundBatch selectedBatch = batchMgr.Selected;
            if (selectedBatch != null)
            {
                InvoiceRefundBatch batch = context.InvoiceRefundBatches.SingleOrDefault(i => i.RefundBatchNo == selectedBatch.RefundBatchNo);
                this.batchBindingSource.DataSource = batch;
                Func<InvoiceRefundLog, Invoice> makeInvoice =
                i => new Invoice { InvoiceNo = i.InvoiceNo, RefundLogID2 = i.RefundLogID };

                var invoiceList = from log in batch.InvoiceRefundLogs
                                  select makeInvoice(log);

                this.invoiceBindingSource.DataSource = invoiceList;
                for (int i = 0; i < this.invoiceBindingSource.List.Count; i++)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvInvoices.Rows[i].Cells[0];
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
            IList refundLogList = this.invoiceBindingSource.List;
            double totalRefund = 0;
            double totalPayment = 0;
            for (int i = 0; i < refundLogList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    totalPayment += ((Invoice)refundLogList[i]).PaymentAmount2.GetValueOrDefault();
                    totalRefund += ((Invoice)refundLogList[i]).RefundAmount2.GetValueOrDefault();
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
            IList invoiceList = this.invoiceBindingSource.List;

            for (int i = 0; i < invoiceList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    Invoice invoice = (Invoice)invoiceList[i];
                    if (TypeUtil.LessZero(invoice.FinanceOutstanding))
                    {
                        MessageBoxEx.Show("还款金额不能大于融资金额: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    double paymentAmount = invoice.PaymentAmount.GetValueOrDefault();
                    if (invoice.InvoiceAssignBatch.BatchCurrency != invoice.InvoiceAssignBatch.BatchCurrency)
                    {
                        double exchangeRate = Exchange.GetExchangeRate(invoice.InvoiceAssignBatch.BatchCurrency, invoice.InvoiceFinanceBatch.BatchCurrency);
                        paymentAmount *= exchangeRate;
                    }

                    if (TypeUtil.GreaterZero(invoice.RefundAmount2 - Math.Min(invoice.FinanceOutstanding.GetValueOrDefault(), paymentAmount)))
                    {
                        MessageBoxEx.Show("还款金额不能大于付款金额: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            return true;
        }

        #endregion Methods
    }
}

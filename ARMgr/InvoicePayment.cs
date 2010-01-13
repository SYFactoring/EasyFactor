//-----------------------------------------------------------------------
// <copyright file="InvoicePayment.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoicePayment : UserControl
    {
        #region Fields (3)

        private CDA _CDA;
        private ARCaseBasic caseBasic;
        private PaymentType paymentType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum PaymentType
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
            SELLER_PAYMENT,

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

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        public InvoicePayment(ARCaseBasic caseBasic, PaymentType paymentType)
        {
            InitializeComponent();
            this.caseBasic = caseBasic;
            this.paymentType = paymentType;
            this.dgvPaymentLog.AutoGenerateColumns = false;
            this.superValidator.Enabled = false;
            ControlUtil.SetDoubleBuffered(this.dgvPaymentLog);

            this.dgvPaymentLog.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvInvoices_CellFormatting);
            this.dgvPaymentLog.CellParsing += new DataGridViewCellParsingEventHandler(dgvInvoices_CellParsing);

            foreach (DataGridViewColumn column in this.dgvPaymentLog.Columns)
            {
                column.ReadOnly = true;
            }
            colCheckBox.ReadOnly = false;
        }

        #endregion Constructors

        #region Properties (1)

        /// <summary>
        /// 
        /// </summary>
        public CDA CDA
        {
            set
            {
                this._CDA = value;
                NewBatch(null, null);
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
            foreach (Control comp in this.panelPaymentBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }
            this.batchBindingSource.DataSource = typeof(InvoicePaymentBatch);
            this.invoiceBindingSource.DataSource = typeof(InvoicePaymentLog);
        }
        // Private Methods (17) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            if (this.dgvPaymentLog.CurrentCell == null)
            {
                return;
            }

            InvoicePaymentLog selectedInvoicePaymentLog = (InvoicePaymentLog)this.invoiceBindingSource.List[this.dgvPaymentLog.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedInvoicePaymentLog.Invoice.InvoiceAssignBatch.CDA.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCDA(object sender, EventArgs e)
        {
            if (this.dgvPaymentLog.CurrentCell == null)
            {
                return;
            }

            InvoicePaymentLog selectedInvoicePaymentLog = (InvoicePaymentLog)this.invoiceBindingSource.List[this.dgvPaymentLog.CurrentCell.RowIndex];
            CDADetail cdaDetail = new CDADetail(selectedInvoicePaymentLog.Invoice.InvoiceAssignBatch.CDA, CDADetail.OpCDAType.DETAIL_CDA);
            cdaDetail.ShowDialog(this);
        }

        /// <summary>
        /// Show detail info of selected inovice
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailInvoice(object sender, System.EventArgs e)
        {
            if (this.dgvPaymentLog.CurrentCell == null)
            {
                return;
            }

            InvoicePaymentLog selectedInvoicePaymentLog = (InvoicePaymentLog)this.invoiceBindingSource.List[this.dgvPaymentLog.CurrentCell.RowIndex];
            InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoicePaymentLog.Invoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
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
                return;
            IList invoicePaymentList = this.invoiceBindingSource.List;
            InvoicePaymentLog invoicePaymentLog = (InvoicePaymentLog)invoicePaymentList[e.RowIndex];
            this.dgvPaymentLog.EndEdit();
            if (this.dgvPaymentLog.Columns[e.ColumnIndex] == colCheckBox)
            {

                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)this.dgvPaymentLog.Rows[e.RowIndex].Cells[0];

                if (Boolean.Parse(checkBoxCell.EditedFormattedValue.ToString()))
                {
                    invoicePaymentLog.PaymentAmount = invoicePaymentLog.Invoice.AssignAmount;
                    invoicePaymentLog.PaymentDate = DateTime.Now.Date;
                    invoicePaymentLog.RefundAmount = invoicePaymentLog.Invoice.FinanceAmount;
                    invoicePaymentLog.RefundDate = DateTime.Now.Date;

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
        void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;
            DataGridViewColumn col = this.dgvPaymentLog.Columns[e.ColumnIndex];
            if (col == colAssignDate || col == colDueDate || col == colFinanceDate || col == colFinanceDueDate || col == colPaymentDate || col == colRefundDate)
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
            DataGridViewColumn col = this.dgvPaymentLog.Columns[e.ColumnIndex];
            if (col == colPaymentDate || col == colRefundDate)
            {
                string str = (string)e.Value;
                e.Value = DateTime.ParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
                e.ParsingApplied = true;
            }
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
            DataGridViewColumn col = this.dgvPaymentLog.Columns[e.ColumnIndex];
            if (col == colPaymentDate || col == colRefundDate)
            {
                string str = (string)e.FormattedValue;
                DateTime result;
                bool ok = DateTime.TryParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
            else if (col == colPaymentAmount || col == colRefundAmount)
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
            if (this.dgvPaymentLog.Columns[e.ColumnIndex] == colPaymentAmount || this.dgvPaymentLog.Columns[e.ColumnIndex] == colRefundAmount)
            {
                StatBatch();
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
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!(this.batchBindingSource.DataSource is InvoicePaymentBatch))
            {
                return;
            }
            if (this.invoiceBindingSource.List.Count == 0)
            {
                return;
            }

            ExportUtil exportUtil = new ExportUtil(ExportUtil.ExportType.EXPORT_PAYMENT_LOG);
            exportUtil.StartExport(this.invoiceBindingSource.List);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!(this.batchBindingSource.DataSource is InvoicePaymentBatch))
            {
                return;
            }

            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_PAYMENT_LOG_BY_BATCH);
            importForm.ShowDialog(this);
            IList invoiceList = importForm.ImportedList;
            if (invoiceList != null)
            {
                for (int i = 0; i < this.invoiceBindingSource.List.Count; i++)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvPaymentLog.Rows[i].Cells[0];
                    cell.Value = 0;
                    InvoicePaymentLog oldInvoice = (InvoicePaymentLog)this.invoiceBindingSource.List[i];
                    int index = invoiceList.IndexOf(oldInvoice);
                    if (invoiceList.Contains(oldInvoice) && oldInvoice.PaymentAmount > 0)
                    {
                        cell.Value = 1;
                    }
                    ResetRow(i, 1 == (int)cell.Value ? true : false);
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
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.tbTotalPayment.Text = string.Empty;
            InvoicePaymentBatch batch = new InvoicePaymentBatch();
            switch (paymentType)
            {
                case PaymentType.BUYER_PAYMENT:
                    batch.PaymentType = "买方还款";
                    break;
                case PaymentType.INDIRECT_PAYMENT:
                    batch.PaymentType = "间接还款";
                    break;
                case PaymentType.SELLER_PAYMENT:
                    batch.PaymentType = "卖方还款";
                    break;
                case PaymentType.GUARANTEE_PAYMENT:
                    batch.PaymentType = "担保付款";
                    break;
                case PaymentType.SELLER_REASSIGN:
                    batch.PaymentType = "卖方回购";
                    break;
                case PaymentType.CREDIT_NOTE_PAYMENT:
                    batch.PaymentType = "CREDIT NOTE";
                    break;
                default:
                    break;
            }
            batch.PaymentDate = DateTime.Now.Date;
            batch.CreateUserName = App.Current.CurUser.Name;
            batch.CheckStatus = "未复核";
            this.batchBindingSource.DataSource = batch;
            Func<Invoice, InvoicePaymentLog> makePaymentLog =
            i => new InvoicePaymentLog { Invoice = i };

            var queryResult = from invoice in App.Current.DbContext.Invoices
                              where invoice.InvoiceAssignBatch.CDACode == this._CDA.CDACode && (invoice.PaymentAmount.HasValue == false || invoice.RefundAmount.HasValue == false)
                              select makePaymentLog(invoice);
            this.invoiceBindingSource.DataSource = queryResult.ToList();
            this.StatBatch();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="editable"></param>
        private void ResetRow(int rowIndex, bool editable)
        {
            this.dgvPaymentLog.Rows[rowIndex].Cells["colPaymentAmount"].ReadOnly = !editable;
            this.dgvPaymentLog.Rows[rowIndex].Cells["colPaymentDate"].ReadOnly = !editable;
            this.dgvPaymentLog.Rows[rowIndex].Cells["colRefundAmount"].ReadOnly = !editable;
            this.dgvPaymentLog.Rows[rowIndex].Cells["colRefundDate"].ReadOnly = !editable;
            if (!editable)
            {
                IList invoiceList = this.invoiceBindingSource.List;
                InvoicePaymentLog paymentLog = (InvoicePaymentLog)invoiceList[rowIndex];
                paymentLog.PaymentAmount = 0;
                paymentLog.PaymentDate = default(DateTime);
                paymentLog.RefundAmount = null;
                paymentLog.RefundDate = default(DateTime);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!this.superValidator.Validate())
            {
                return;
            }
            if (!(this.batchBindingSource.DataSource is InvoicePaymentBatch))
            {
                return;
            }
            if (!ValidateBatch())
            {
                return;
            }

            bool isSaveOK = true;
            InvoicePaymentBatch batch = (InvoicePaymentBatch)this.batchBindingSource.DataSource;
            batch.CDA = this._CDA;

            IList paymentLogList = this.invoiceBindingSource.List;
            for (int i = 0; i < paymentLogList.Count; i++)
            {
                if (Boolean.Parse(this.dgvPaymentLog.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    ((InvoicePaymentLog)paymentLogList[i]).InvoicePaymentBatch = batch;
                }
            }
            if (batch.InvoicePaymentLogs.Count == 0)
            {
                return;
            }
            if (batch.PaymentBatchNo == null)
            {
                batch.PaymentBatchNo = Invoice.GeneratePaymentBatchNo(DateTime.Now.Date);
            }
            try
            {
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                for (int i = 0; i < paymentLogList.Count; i++)
                {
                    if (Boolean.Parse(this.dgvPaymentLog.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                    {
                        ((InvoicePaymentLog)paymentLogList[i]).InvoicePaymentBatch = null;
                    }
                }
                batch.CDA = null;
                isSaveOK = false;
                MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (isSaveOK)
            {
                MessageBox.Show("数据保存成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.caseBasic.CaculateOutstanding(this._CDA);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PaymentBatchMgr batchMgr = new PaymentBatchMgr(this._CDA);
            QueryForm queryUI = new QueryForm(batchMgr, "选择付款批次");
            batchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoicePaymentBatch selectedBatch = batchMgr.Selected;
            if (selectedBatch != null)
            {
                this.batchBindingSource.DataSource = selectedBatch;
                this.invoiceBindingSource.DataSource = selectedBatch.InvoicePaymentLogs.ToList();
                for (int i = 0; i < this.invoiceBindingSource.List.Count; i++)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvPaymentLog.Rows[i].Cells[0];
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
            IList paymentLogList = this.invoiceBindingSource.List;
            double totalPayment = 0;
            double totalRefund = 0;
            for (int i = 0; i < paymentLogList.Count; i++)
            {
                if (Boolean.Parse(this.dgvPaymentLog.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    totalPayment += ((Invoice)paymentLogList[i]).PaymentAmount.GetValueOrDefault();
                    totalRefund += ((Invoice)paymentLogList[i]).RefundAmount.GetValueOrDefault();
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
            foreach (InvoicePaymentLog paymentLog in this.invoiceBindingSource.List)
            {
                //if (paymentLog.AssignOutstanding < 0)
                //{
                //    MessageBox.Show("付款金额不能大于转让金额: " + paymentLog.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return false;
                //}
                //if (paymentLog.FinanceOutstanding < 0)
                //{
                //    MessageBox.Show("还款金额不能大于融资金额: " + paymentLog.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return false;
                //}
                if (paymentLog.RefundAmount > paymentLog.PaymentAmount)
                {
                    MessageBox.Show("还款金额不能大于付款金额: " + paymentLog.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        #endregion Methods
    }
}

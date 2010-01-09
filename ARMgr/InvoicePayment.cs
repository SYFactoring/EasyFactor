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
            SELLER_REASSIGN
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
            this.dgvInvoices.AutoGenerateColumns = false;
            this.superValidator.Enabled = false;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);

            this.dgvInvoices.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvInvoices_CellFormatting);
            this.dgvInvoices.CellParsing += new DataGridViewCellParsingEventHandler(dgvInvoices_CellParsing);

            foreach (DataGridViewColumn column in this.dgvInvoices.Columns)
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
        /// <param name="cda"></param>
        /// <returns></returns>
        public static string GenerateBatchNo(DateTime date)
        {
            DateTime begin = new DateTime(date.Year, date.Month, date.Day);
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoicePaymentBatches.Count(batch => batch.PaymentDate >= begin && batch.PaymentDate < end);
            string paymentNo = String.Format("PAY{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return paymentNo;
        }

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
            CaseDetail caseDetail = new CaseDetail(selectedInvoice.InvoiceAssignBatch.CDA.Case, CaseDetail.OpCaseType.DETAIL_CASE);
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
            CDADetail cdaDetail = new CDADetail(selectedInvoice.InvoiceAssignBatch.CDA, CDADetail.OpCDAType.DETAIL_CDA);
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
                return;
            IList invoiceList = this.invoiceBindingSource.List;
            Invoice invoice = (Invoice)invoiceList[e.RowIndex];
            this.dgvInvoices.EndEdit();
            if (this.dgvInvoices.Columns[e.ColumnIndex] == colCheckBox)
            {

                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)this.dgvInvoices.Rows[e.RowIndex].Cells[0];

                if (Boolean.Parse(checkBoxCell.EditedFormattedValue.ToString()))
                {
                    invoice.PaymentAmount = invoice.AssignAmount;
                    invoice.PaymentDate = DateTime.Now.Date;
                    invoice.RefundAmount = invoice.FinanceAmount;
                    invoice.RefundDate = DateTime.Now.Date;

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
            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colAssignDate || col == colDueDate || col == colFinanceDate || col == colFinanceDueDate || col == colPaymentDate || col == colRefundDate || col == colCommissionDate || col == colInterestDate)
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
            if (col == colPaymentDate || col == colRefundDate || col == colCommissionDate || col == colInterestDate)
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
            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colPaymentDate || col == colRefundDate || col == colCommissionDate || col == colInterestDate)
            {
                string str = (string)e.FormattedValue;
                DateTime result;
                bool ok = DateTime.TryParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
            else if (col == colPaymentAmount || col == colRefundAmount || col == colCommission || col == colInterest)
            {
                string str = (string)e.FormattedValue;
                double result;
                bool ok = Double.TryParse(str, out result);
                if (!ok)
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
            if (this.dgvInvoices.Columns[e.ColumnIndex] == colPaymentAmount)
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
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            ExportUtil exportUtil = new ExportUtil(ExportUtil.ExportType.EXPORT_INVOICES);
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
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!(this.batchBindingSource.DataSource is InvoicePaymentBatch))
            {
                return;
            }

            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_INVOICES_BY_BATCH);
            importForm.ShowDialog(this);
            IList invoiceList = importForm.ImportedList;
            if (invoiceList != null)
            {
                for (int i = 0; i < this.invoiceBindingSource.List.Count; i++)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvInvoices.Rows[i].Cells[0];
                    cell.Value = 0;
                    Invoice oldInvoice = (Invoice)this.invoiceBindingSource.List[i];
                    int index = invoiceList.IndexOf(oldInvoice);
                    if (invoiceList.Contains(oldInvoice) && oldInvoice.PaymentAmount.HasValue)
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
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                default:
                    break;
            }
            batch.PaymentDate = DateTime.Now.Date;
            batch.CreateUserName = App.Current.CurUser.Name;
            batch.CheckStatus = "未审核";
            this.batchBindingSource.DataSource = batch;
            this.invoiceBindingSource.DataSource = App.Current.DbContext.Invoices.Where(i => i.InvoiceAssignBatch.CDACode == this._CDA.CDACode && i.PaymentAmount.HasValue == false).ToList();
            this.StatBatch();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="editable"></param>
        private void ResetRow(int rowIndex, bool editable)
        {
            this.dgvInvoices.Rows[rowIndex].Cells["colPaymentAmount"].ReadOnly = !editable;
            this.dgvInvoices.Rows[rowIndex].Cells["colPaymentDate"].ReadOnly = !editable;
            this.dgvInvoices.Rows[rowIndex].Cells["colRefundAmount"].ReadOnly = !editable;
            this.dgvInvoices.Rows[rowIndex].Cells["colRefundDate"].ReadOnly = !editable;
            this.dgvInvoices.Rows[rowIndex].Cells["colInterest"].ReadOnly = !editable;
            this.dgvInvoices.Rows[rowIndex].Cells["colInterestDate"].ReadOnly = !editable;
            this.dgvInvoices.Rows[rowIndex].Cells["colCommission"].ReadOnly = !editable;
            this.dgvInvoices.Rows[rowIndex].Cells["colCommissionDate"].ReadOnly = !editable;
            if (!editable)
            {
                IList invoiceList = this.invoiceBindingSource.List;
                Invoice invoice = (Invoice)invoiceList[rowIndex];
                invoice.PaymentAmount = null;
                invoice.PaymentDate = null;
                invoice.RefundAmount = null;
                invoice.RefundDate = null;
                invoice.Commission = null;
                invoice.CommissionDate = null;
                invoice.Interest = null;
                invoice.InterestDate = null;
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
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            IList invoiceList = this.invoiceBindingSource.List;
            for (int i = 0; i < invoiceList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    ((Invoice)invoiceList[i]).InvoicePaymentBatch = batch;
                }
            }
            if (batch.Invoices.Count == 0)
            {
                return;
            }
            if (batch.PaymentBatchNo == null)
            {
                batch.PaymentBatchNo = GenerateBatchNo(DateTime.Now.Date);
            }
            try
            {
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                isSaveOK = false;
                MessageBox.Show(e1.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (isSaveOK)
            {
                MessageBox.Show("数据保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                this.invoiceBindingSource.DataSource = selectedBatch.Invoices.ToList();
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
            IList invoiceList = this.invoiceBindingSource.List;
            double totalPayment = 0;
            double totalRefund = 0;
            for (int i = 0; i < invoiceList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    totalPayment += ((Invoice)invoiceList[i]).PaymentAmount.GetValueOrDefault();
                    totalRefund += ((Invoice)invoiceList[i]).RefundAmount.GetValueOrDefault();
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
            foreach (Invoice invoice in this.invoiceBindingSource.List)
            {

            }
            return true;
        }

        #endregion Methods
    }
}

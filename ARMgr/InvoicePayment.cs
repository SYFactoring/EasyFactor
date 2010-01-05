﻿//-----------------------------------------------------------------------
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
            GUARANTEE_PAYMENT
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
            this.dgvInvoices.ReadOnly = true;
            this.superValidator.Enabled = false;

            this.dgvInvoices.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvInvoices_CellFormatting);
            this.dgvInvoices.CellParsing += new DataGridViewCellParsingEventHandler(dgvInvoices_CellParsing);
        }

        #endregion Constructors

        #region Properties (1)

        public CDA CDA
        {
            set
            {
                this._CDA = value;
                this.dgvInvoices.ReadOnly = false;
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
                    default:
                        break;
                }
                this.invoicePaymentBatchBindingSource.DataSource = batch;
                this.invoiceBindingSource.DataSource = App.Current.DbContext.Invoices.Where(i => i.InvoiceAssignBatch.CDACode == this._CDA.CDACode && i.PaymentAmount.HasValue == false).ToList();
            }
        }

        #endregion Properties

        #region Methods (10)

        // Public Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <returns></returns>
        public static string GeneratePaymentBatchNo(CDA cda, System.Nullable<DateTime> date)
        {
            Client seller = cda.Case.SellerClient;
            Client buyer = cda.Case.BuyerClient;
            int batchCount = cda.InvoicePaymentBatches.Count;
            if (date == null)
            {
                date = DateTime.Now;
            }
            string paymentNo = String.Format("PAY{0:G}{1:yyyyMMdd}-{2:d2}", cda.CDACode, date, batchCount + 1);
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
            this.invoicePaymentBatchBindingSource.DataSource = typeof(InvoicePaymentBatch);
            this.invoiceBindingSource.DataSource = typeof(Invoice);
        }
        // Private Methods (8) 

        private void CaculateCurrentPaymentAmount()
        {
            IList invoiceList = this.invoiceBindingSource.List;
            double currentPaymentAmount = 0;
            for (int i = 0; i < this.dgvInvoices.Rows.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    currentPaymentAmount += ((Invoice)invoiceList[i]).PaymentAmount.GetValueOrDefault();
                }
            }
            this.tbPaymentAmount.Text = String.Format("{0:N2}", currentPaymentAmount);
        }

        /// <summary>
        /// Show detail info of selected inovice
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailInvoice(object sender, System.EventArgs e)
        {
            if (this.dgvInvoices.SelectedRows.Count == 0)
            {
                return;
            }

            string ino = (string)dgvInvoices["colInvoiceNo", dgvInvoices.SelectedRows[0].Index].Value;
            if (ino != null)
            {
                Invoice selectedInvoice = ((InvoicePaymentBatch)this.invoicePaymentBatchBindingSource.DataSource).Invoices.SingleOrDefault(i => i.InvoiceNo == ino);
                if (selectedInvoice != null)
                {
                    InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
                    invoiceDetail.ShowDialog(this);
                }
            }
        }

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
                    invoice.PaymentDate = DateTime.Now;
                    invoice.RefundAmount = invoice.FinanceAmount;
                    invoice.RefundDate = DateTime.Now;
                }
                else
                {
                    invoice.PaymentAmount = null;
                    invoice.PaymentDate = null;
                    invoice.RefundAmount = null;
                    invoice.RefundDate = null;
                }
                CaculateCurrentPaymentAmount();
            }

        }

        void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;
            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colDueDate || col == colFinanceDueDate || col == colPaymentDate || col == colRefundDate || col == colCommissionDate || col == colInterestDate)
            {
                DateTime date = (DateTime)e.Value;
                e.Value = date.ToString("yyyyMMdd");
                e.FormattingApplied = true;
            }
        }

        void dgvInvoices_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }
            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colDueDate || col == colFinanceDueDate || col == colPaymentDate || col == colRefundDate || col == colCommissionDate || col == colInterestDate)
            {
                string str = (string)e.Value;
                DateTime result;
                bool ok = DateTime.TryParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result);
                if (ok)
                {
                    e.Value = result;
                    e.ParsingApplied = true;
                }
            }
        }

        private void dgvInvoices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvInvoices.Columns[e.ColumnIndex] == colPaymentAmount)
            {
                CaculateCurrentPaymentAmount();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportPaymentBatch(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_PAYMENT);
            importForm.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavePaymentBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                return;
            }
            if (!this.superValidator.Validate())
            {
                return;
            }

            bool isSaveOK = true;
            InvoicePaymentBatch paymentBatch = (InvoicePaymentBatch)this.invoicePaymentBatchBindingSource.DataSource;
            paymentBatch.CDA = this._CDA;
            if (paymentBatch.PaymentBatchNo == null)
            {
                paymentBatch.PaymentBatchNo = GeneratePaymentBatchNo(this._CDA, DateTime.Now);
                paymentBatch.CreateUserName = App.Current.CurUser.Name;
            }
            IList invoiceList = this.invoiceBindingSource.List;
            for (int i = 0; i < this.dgvInvoices.Rows.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    ((Invoice)invoiceList[i]).InvoicePaymentBatch = paymentBatch;
                }
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

        #endregion Methods
    }
}

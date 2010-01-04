//-----------------------------------------------------------------------
// <copyright file="InvoicePayment.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoicePayment : UserControl
    {
        #region Fields (1)

        private CDA _CDA;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        public InvoicePayment()
        {
            InitializeComponent();
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.ReadOnly = true;
            this.superValidator.Enabled = false;


        }

        #endregion Constructors

        #region Properties (1)

        public CDA CDA
        {
            set
            {
                this._CDA = value;
                this.dgvInvoices.ReadOnly = false;
                this.superValidator.Enabled = true;
                InvoicePaymentBatch paymentBatch = new InvoicePaymentBatch();
                paymentBatch.PaymentBatchNo = GeneratePaymentBatchNo(this._CDA, DateTime.Now);
                paymentBatch.CreateUserName = App.Current.CurUser.Name;
                this.invoicePaymentBatchBindingSource.DataSource = paymentBatch;
                this.invoiceBindingSource.DataSource = App.Current.DbContext.Invoices.Where(i => i.InvoiceAssignBatch.CDACode == this._CDA.CDACode && i.PaymentAmount.HasValue == false).ToList();
            }
        }

        #endregion Properties

        #region Methods (3)

        // Public Methods (1) 

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
            string paymentNo = String.Format("PAY{0:G}{1:G}{2:yyyyMMdd}-{3:d2}", seller.ClientEDICode.Substring(0, 5), buyer.ClientEDICode.Substring(3, 2), date, batchCount + 1);
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
        // Private Methods (2) 

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
            foreach (Invoice invoice in this.invoiceBindingSource.DataSource as List<Invoice>)
            {
                invoice.InvoicePaymentBatch = paymentBatch;
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
            }
        }

        #endregion Methods
    }
}

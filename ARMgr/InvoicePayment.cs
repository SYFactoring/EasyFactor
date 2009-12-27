//-----------------------------------------------------------------------
// <copyright file="InvoicePayment.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System.Windows.Forms;
    using System.Linq;
    using CMBC.EasyFactor.DB.dbml;
    using System;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoicePayment : UserControl
    {
        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        public InvoicePayment()
        {
            InitializeComponent();
            this.dgvInvoices.AutoGenerateColumns = false;

            InvoicePaymentBatch paymentBatch = new InvoicePaymentBatch();
            paymentBatch.PaymentBatchNo = GeneratePaymentBatchNo(this._CDA);
            paymentBatch.CreateUserName = App.Current.CurUser.Name;
            this.invoicePaymentBatchBindingSource.DataSource = paymentBatch;
        }

        private CDA _CDA;

        public CDA CDA
        {
            set
            {
                this._CDA = value;
                InvoicePaymentBatch paymentBatch = (InvoicePaymentBatch)this.invoicePaymentBatchBindingSource.DataSource;
                paymentBatch.CDA = this._CDA;
                this.invoicesBindingSource.DataSource = App.Current.DbContext.Invoices.Where(i => i.InvoiceAssignBatch.CDACode == this._CDA.CDACode && i.PaymentAmount.HasValue == false).ToList();
            }
        }

        #endregion Constructors

        private string GeneratePaymentBatchNo(CDA CDA)
        {
            Client seller = CDA.Case.SellerClient;
            Client buyer = CDA.Case.BuyerClient;
            string date = String.Format("{0:yyyy}{0:MM}{0:dd}", DateTime.Today);
            int batchCount = CDA.InvoiceAssignBatches.Count;
            string assignNo = seller.ClientEDICode.Substring(0, 5) + buyer.ClientEDICode.Substring(3, 2) + date + "-" + String.Format("{0:D2}", batchCount + 1);
            return assignNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavePaymentBatch(object sender, EventArgs e)
        {

            bool isSaveOK = true;
            InvoicePaymentBatch paymentBatch = (InvoicePaymentBatch)this.invoicePaymentBatchBindingSource.DataSource;
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
    }
}

//-----------------------------------------------------------------------
// <copyright file="InvoiceDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using CMBC.EasyFactor.DB.dbml;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceDetail : DevComponents.DotNetBar.Office2007Form
    {
        private OpInvoiceType opInvoiceType;

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpInvoiceType
        {
            /// <summary>
            /// 
            /// </summary>
            DETAIL_INVOICE,

            /// <summary>
            /// 
            /// </summary>
            UPDATE_INVOICE,

            /// <summary>
            /// 
            /// </summary>
            FLAW
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoice"></param>
        /// <param name="opInvoiceType"></param>
        public InvoiceDetail(Invoice invoice, OpInvoiceType opInvoiceType)
        {
            InitializeComponent();
            this.opInvoiceType = opInvoiceType;
            this.invoiceBindingSource.DataSource = invoice;
            
            invoice.Backup();
            UpdateInvoiceControlStatus();
        }

        private void UpdateInvoiceControlStatus()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceDetail_Leave(object sender, EventArgs e)
        {
            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            if (this.opInvoiceType == OpInvoiceType.UPDATE_INVOICE)
            {
                invoice.Restore();
            }
            this.Close();
        }

        private void ResetInvoice(object sender, EventArgs e)
        {
            if (opInvoiceType == OpInvoiceType.UPDATE_INVOICE)
            {
                Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
                invoice.Restore();
            }
        }

        private void SaveInvoice(object sender, EventArgs e)
        {
            if (!this.superValidator.Validate())
            {
                return;
            }
            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            bool isUpdateOK = true;

            try
            {
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e2)
            {
                isUpdateOK = false;
                MessageBox.Show(e2.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isUpdateOK)
            {
                MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                invoice.Backup();
            }

        }

        private void UpdateInvoice(object sender, EventArgs e)
        {
            this.opInvoiceType = OpInvoiceType.UPDATE_INVOICE;
            this.UpdateInvoiceControlStatus();
        }

        #endregion Constructors
    }
}

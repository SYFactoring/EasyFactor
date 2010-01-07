//-----------------------------------------------------------------------
// <copyright file="InvoiceDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Windows.Forms;
    using System.Linq;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceDetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (1)

        private OpInvoiceType opInvoiceType;

        #endregion Fields

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
            FLAW,

            /// <summary>
            /// 
            /// </summary>
            DISPUTE
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

            this.invoiceCurrencyComboBox.DataSource = Currency.AllCurrencies().ToList();
            this.invoiceCurrencyComboBox.DisplayMember = "CurrencyCode";
            this.invoiceCurrencyComboBox.ValueMember = "CurrencyCode";

            invoice.Backup();
            UpdateInvoiceControlStatus();

            if (opInvoiceType == OpInvoiceType.FLAW)
            {
                this.tabControl.SelectedTab = this.tabItemFlaw;
            }
            else if (opInvoiceType == OpInvoiceType.DISPUTE)
            {
                this.tabControl.SelectedTab=this.tabItemDispute;
            }
        }

        #endregion Constructors

        #region Methods (5)

        // Private Methods (5) 

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

        private void UpdateInvoiceControlStatus()
        {
            if (opInvoiceType == OpInvoiceType.DETAIL_INVOICE)
            {
                foreach (Control comp in this.groupPanelInvoiceBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelInvoiceProcess.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelFlaw.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelFlawResolve.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelDispute.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelDisputeResolve.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelInvoiceAdv.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (opInvoiceType == OpInvoiceType.UPDATE_INVOICE)
            {
                foreach (Control comp in this.groupPanelInvoiceBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                foreach (Control comp in this.groupPanelInvoiceProcess.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                foreach (Control comp in this.groupPanelFlaw.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelFlawResolve.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelDispute.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelDisputeResolve.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelInvoiceAdv.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (opInvoiceType == OpInvoiceType.FLAW)
            {
                foreach (Control comp in this.groupPanelInvoiceBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelInvoiceProcess.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelFlaw.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                foreach (Control comp in this.groupPanelFlawResolve.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                foreach (Control comp in this.groupPanelDispute.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelDisputeResolve.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelInvoiceAdv.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (opInvoiceType == OpInvoiceType.DISPUTE)
            {
                foreach (Control comp in this.groupPanelInvoiceBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelInvoiceProcess.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelFlaw.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelFlawResolve.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelDispute.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                foreach (Control comp in this.groupPanelDisputeResolve.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                foreach (Control comp in this.groupPanelInvoiceAdv.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            this.invoiceNoTextBox.ReadOnly = true;
        }

        #endregion Methods
    }
}

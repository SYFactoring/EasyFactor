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
    using System.Collections.Generic;

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
            this.ImeMode = ImeMode.OnHalf;
            this.opInvoiceType = opInvoiceType;
            this.invoiceBindingSource.DataSource = invoice;

            this.invoiceCurrencyComboBox.DataSource = Currency.AllCurrencies().ToList();
            this.invoiceCurrencyComboBox.DisplayMember = "CurrencyCode";
            this.invoiceCurrencyComboBox.ValueMember = "CurrencyCode";

            if (invoice.FlawReason != null)
            {
                List<string> reasonList = new List<string>();
                reasonList.AddRange(invoice.FlawReason.Split(';'));
                for (int i = 0; i < this.flawReasonCheckedListBox.Items.Count; i++)
                {
                    string item = (string)this.flawReasonCheckedListBox.Items[i];
                    if (reasonList.Contains(item))
                    {
                        this.flawReasonCheckedListBox.SetItemChecked(i, true);
                        reasonList.Remove(item);
                    }
                }
                string otherReason = string.Empty;
                foreach (string other in reasonList)
                {
                    otherReason += (other + Environment.NewLine);
                }
                this.tbFlawReason.Text = otherReason;
            }
            if (invoice.DisputeReason != null)
            {
                List<string> disputeList = new List<string>();
                disputeList.AddRange(invoice.DisputeReason.Split(';'));
                for (int i = 0; i < this.disputeReasonCheckedListBox.Items.Count; i++)
                {
                    string item = (string)this.disputeReasonCheckedListBox.Items[i];
                    if (disputeList.Contains(item))
                    {
                        this.disputeReasonCheckedListBox.SetItemChecked(i, true);
                        disputeList.Remove(item);
                    }
                }
                string otherReason = string.Empty;
                foreach (string other in disputeList)
                {
                    otherReason += (other + Environment.NewLine);
                }
                this.tbDisputeReason.Text = otherReason;
            }
            invoice.Backup();
            UpdateInvoiceControlStatus();

            if (opInvoiceType == OpInvoiceType.FLAW)
            {
                this.tabControl.SelectedTab = this.tabItemFlaw;
            }
            else if (opInvoiceType == OpInvoiceType.DISPUTE)
            {
                this.tabControl.SelectedTab = this.tabItemDispute;
            }
        }

        #endregion Constructors

        #region Methods (9)

        // Private Methods (9) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dispute(object sender, EventArgs e)
        {
            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            invoice.DisputeDate = DateTime.Now.Date;
            invoice.DisputeUserName = App.Current.CurUser.Name;
            invoice.IsDispute = true;
            foreach (Control comp in this.groupPanelDispute.Controls)
            {
                ControlUtil.SetComponetEditable(comp, true);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisputeResolve(object sender, EventArgs e)
        {
            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            invoice.DisputeResolveDate = DateTime.Now.Date;
            invoice.DisputeResolveUserName = App.Current.CurUser.Name;
            invoice.IsDispute = false;
            foreach (Control comp in this.groupPanelDisputeResolve.Controls)
            {
                ControlUtil.SetComponetEditable(comp, true);
            }

            List<string> reasonList = new List<string>();
            reasonList.AddRange(invoice.DisputeReason.Split(';'));
            string disputeResolveReason = string.Empty;
            foreach (string reason in reasonList)
            {
                disputeResolveReason += (reason + " 已解除" + Environment.NewLine);
            }
            invoice.DisputeResolveReason = disputeResolveReason;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Flaw(object sender, EventArgs e)
        {
            this.flawReasonCheckedListBox.Enabled = true;
            this.tbFlawReason.ReadOnly = false;
            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            invoice.IsFlaw = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlawResolve(object sender, EventArgs e)
        {
            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            invoice.FlawResolveDate = DateTime.Now.Date;
            invoice.FlawResolveUserName = App.Current.CurUser.Name;
            invoice.IsFlaw = false;

            this.flawResolveDateDateTimePicker.Enabled = true;
            this.tbFlawResolveReason.ReadOnly = false;
            this.flawResolveUserNameTextBox.ReadOnly = false;

            List<string> reasonList = new List<string>();
            reasonList.AddRange(invoice.FlawReason.Split(';'));
            string flawResolveReason = string.Empty;
            foreach (string reason in reasonList)
            {
                flawResolveReason += (reason + " 已解除" + Environment.NewLine);
            }
            invoice.FlawResolveReason = flawResolveReason;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceDetail_Leave(object sender, EventArgs e)
        {
            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            invoice.Restore();

            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetInvoice(object sender, EventArgs e)
        {
            if (opInvoiceType == OpInvoiceType.UPDATE_INVOICE)
            {
                Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
                invoice.Restore();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveInvoice(object sender, EventArgs e)
        {
            if (!this.superValidator.Validate())
            {
                return;
            }
            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;

            string flawReason = string.Empty;
            foreach (string item in this.flawReasonCheckedListBox.CheckedItems)
            {
                flawReason += (item + ";");
            }
            if (this.tbFlawReason.Text != string.Empty)
            {
                flawReason += this.tbFlawReason.Text;
            }
            invoice.FlawReason = flawReason;

            string disputeReason = string.Empty;
            foreach (string item in this.disputeReasonCheckedListBox.CheckedItems)
            {
                disputeReason += (item + ";");
            }
            if (this.tbDisputeReason.Text != string.Empty)
            {
                disputeReason += this.tbDisputeReason.Text;
            }
            invoice.DisputeReason = disputeReason;

            bool isUpdateOK = true;
            try
            {
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e2)
            {
                isUpdateOK = false;
                MessageBox.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isUpdateOK)
            {
                MessageBox.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                invoice.Backup();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateInvoice(object sender, EventArgs e)
        {
            this.opInvoiceType = OpInvoiceType.UPDATE_INVOICE;
            this.UpdateInvoiceControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateInvoiceControlStatus()
        {
            if (opInvoiceType == OpInvoiceType.DETAIL_INVOICE || opInvoiceType == OpInvoiceType.FLAW || opInvoiceType == OpInvoiceType.DISPUTE)
            {
                foreach (Control comp in this.groupPanelInvoiceBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelInvoiceProcess.Controls)
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
                foreach (Control comp in this.groupPanelInvoiceAdv.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                this.assignOutstandingTextBox.ReadOnly = true;
                this.financeOutstandingTextBox.ReadOnly = true;
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
            this.invoiceNoTextBox.ReadOnly = true;
            this.btnFlaw.Enabled = true;
            this.btnFlawResolve.Enabled = true;
            this.isDisputeCheckBox.Enabled = true;
            this.isFlawCheckBox.Enabled = true;
        }

        #endregion Methods
    }
}

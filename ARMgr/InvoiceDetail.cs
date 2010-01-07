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
                    }
                }
                if (reasonList.Count > this.flawReasonCheckedListBox.CheckedItems.Count)
                {
                    this.tbFlawReason.Text = reasonList[reasonList.Count - 1];
                }
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
                    }
                }
                if (disputeList.Count > this.disputeReasonCheckedListBox.CheckedItems.Count)
                {
                    this.tbDisputeReason.Text = disputeList[disputeList.Count - 1];
                }
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
            if (!invoice.DisputeDate.HasValue)
            {
                invoice.DisputeDate = DateTime.Now;
            }
            if (invoice.DisputeUserName == null)
            {
                invoice.DisputeUserName = App.Current.CurUser.Name;
            }
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
            invoice.DisputeResolveDate = DateTime.Now;
            invoice.DisputeResolveUserName = App.Current.CurUser.Name;

            foreach (Control comp in this.groupPanelDisputeResolve.Controls)
            {
                ControlUtil.SetComponetEditable(comp, true);
            }
            for (int i = 0; i < this.disputeReasonCheckedListBox.Items.Count; i++)
            {
                bool check = this.disputeReasonCheckedListBox.GetItemChecked(i);
                if (check)
                {
                    invoice.DisputeResolveReason += (this.disputeReasonCheckedListBox.Items[i].ToString() + " 已解决" + Environment.NewLine);
                    this.disputeReasonCheckedListBox.SetItemChecked(i, false);
                }
            }
            if (this.tbDisputeReason.Text != string.Empty)
            {
                invoice.DisputeResolveReason += (this.tbDisputeReason.Text + " 已解决");
                this.tbDisputeReason.Text = string.Empty;
            }
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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlawResolve(object sender, EventArgs e)
        {
            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            invoice.FlawResolveDate = DateTime.Now;
            invoice.FlawResolveUserName = App.Current.CurUser.Name;

            this.flawResolveDateDateTimePicker.Enabled = true;
            this.tbFlawResolveReason.ReadOnly = false;
            for (int i = 0; i < this.flawReasonCheckedListBox.Items.Count; i++)
            {
                bool check = this.flawReasonCheckedListBox.GetItemChecked(i);
                if (check)
                {
                    invoice.FlawResolveReason += (this.flawReasonCheckedListBox.Items[i].ToString() + " 已解决" + Environment.NewLine);
                    this.flawReasonCheckedListBox.SetItemChecked(i, false);
                }
            }
            if (this.tbFlawReason.Text != string.Empty)
            {
                invoice.FlawResolveReason += (this.tbFlawReason.Text + " 已解决");
                this.tbFlawReason.Text = string.Empty;
            }
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

            invoice.FlawReason = string.Empty;
            foreach (string item in this.flawReasonCheckedListBox.CheckedItems)
            {
                invoice.FlawReason += (item + ";");
            }
            if (!this.tbFlawReason.Text.Equals(string.Empty))
            {
                invoice.FlawReason += this.tbFlawReason.Text;
            }
            if (!invoice.FlawReason.Equals(string.Empty))
            {
                invoice.IsFlaw = true;
            }
            else
            {
                invoice.IsFlaw = false;
            }
            invoice.DisputeReason = string.Empty;
            foreach (string item in this.disputeReasonCheckedListBox.CheckedItems)
            {
                invoice.DisputeReason += (item + ";");
            }
            if (!this.tbDisputeReason.Text.Equals(string.Empty))
            {
                invoice.DisputeReason += this.tbDisputeReason.Text;
            }
            if (!invoice.DisputeReason.Equals(string.Empty))
            {
                invoice.IsDispute = true;
            }
            else
            {
                invoice.IsDispute = false;
            }
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
            this.invoiceNoTextBox.ReadOnly = true;
            this.btnFlaw.Enabled = true;
            this.btnFlawResolve.Enabled = true;
        }

        #endregion Methods
    }
}

//-----------------------------------------------------------------------
// <copyright file="ClientDetail.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    using System;
    using System.Windows.Forms;
    using System.Linq;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// Client Detail
    /// </summary>
    public partial class ClientDetail : DevComponents.DotNetBar.Office2007Form
    {
        private readonly OpType opType;

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="client">selected client</param>
        /// <param name="opType">operation type</param>
        public ClientDetail(Client client, OpType opType)
        {
            this.InitializeComponent();
            this.InitComboBox();
            this.opType = opType;
            if (opType == OpType.NEW_CLIENT)
            {
                this.clientBindingSource.DataSource = new Client();
            }
            else
            {
                this.clientBindingSource.DataSource = client;
                this.dgvClientCreditLines.DataSource = client.ClientAccounts;
                this.FillForms(client);
            }

            this.UpdateEditableStatus();
            if (opType == OpType.NEW_CLIENT_CREDIT_COVER)
            {
                this.tabControl.SelectedTab = this.tabItemClientCreditLine;
            }
        }

        /// <summary>
        /// Operation Type 
        /// </summary>
        public enum OpType
        {
            /// <summary>
            /// New Client
            /// </summary>
            NEW_CLIENT,

            /// <summary>
            /// Update Client
            /// </summary>
            UPDATE_CLIENT,

            /// <summary>
            /// Detail Client
            /// </summary>
            DETAIL_CLIENT,

            /// <summary>
            /// Update Client Credit Cover
            /// </summary>
            NEW_CLIENT_CREDIT_COVER
        }

        /// <summary>
        /// Initial ComboBox
        /// </summary>
        private void InitComboBox()
        {
            this.countryCodeComboBox.DataSource = App.Current.DbContext.Countries;
            this.countryCodeComboBox.DisplayMember = "CountryFormatCN";
            this.countryCodeComboBox.ValueMember = "CountryCode";
            this.countryCodeComboBox.SelectedIndex = -1;

            this.departmentComboTree.DataSource = App.Current.DbContext.Departments;
            this.departmentComboTree.DisplayMembers = "DepartmentName";
            this.departmentComboTree.ValueMember = "DepartmentCode";
            this.departmentComboTree.GroupingMembers = "Domain";
            this.departmentComboTree.SelectedIndex = -1;

            this.creditLineCurrencyComboBox.DataSource = App.Current.DbContext.Currencies;
            this.creditLineCurrencyComboBox.DisplayMember = "CurrencyFormat";
            this.creditLineCurrencyComboBox.ValueMember = "CurrencyCode";
            this.creditLineCurrencyComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Fill Forms
        /// </summary>
        /// <param name="client">Selected Client</param>
        private void FillForms(Client client)
        {
            foreach (Country country in this.countryCodeComboBox.Items)
            {
                if (country.CountryCode.Equals(client.CountryCode))
                {
                    this.countryCodeComboBox.SelectedItem = country;
                    break;
                }
            }
        }

        /// <summary>
        /// udpate editable status
        /// </summary>
        private void UpdateEditableStatus()
        {
            if (this.opType == OpType.DETAIL_CLIENT)
            {
                foreach (Control comp in this.groupPanelClientBasic.Controls)
                {
                    ControlUtil.setComponetEditable(comp, false);
                }

                foreach (Control comp in this.groupPanelClientContact.Controls)
                {
                    ControlUtil.setComponetEditable(comp, false);
                }

                foreach (Control comp in this.groupPanelClientGroup.Controls)
                {
                    ControlUtil.setComponetEditable(comp, false);
                }

                foreach (Control comp in this.groupPanelClientStat.Controls)
                {
                    ControlUtil.setComponetEditable(comp, false);
                }

                ControlUtil.setComponetEditable(this.btnClientCancel, true);
                ControlUtil.setComponetEditable(this.btnClientSave, false);
            }
            else if (this.opType == OpType.NEW_CLIENT)
            {
                foreach (Control comp in this.groupPanelClientBasic.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelClientContact.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelClientGroup.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelClientStat.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }

                ControlUtil.setComponetEditable(this.btnClientCancel, true);
                ControlUtil.setComponetEditable(this.btnClientSave, true);
            }
            else if (this.opType == OpType.UPDATE_CLIENT)
            {
                foreach (Control comp in this.groupPanelClientBasic.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelClientContact.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelClientGroup.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelClientStat.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }

                ControlUtil.setComponetEditable(this.btnClientCancel, true);
                ControlUtil.setComponetEditable(this.btnClientSave, true);
                this.clientNoTextBox.ReadOnly = true;
            }

            foreach (Control comp in this.groupPanelClientCreditCover.Controls)
            {
                ControlUtil.setComponetEditable(comp, false);
            }

            if (opType == OpType.NEW_CLIENT_CREDIT_COVER)
            {
                ControlUtil.setComponetEditable(this.btnClientCreditLineNew, true);
                ControlUtil.setComponetEditable(this.btnClientCreditLineSave, true);
                ControlUtil.setComponetEditable(this.btnClientCreditLineCancel, true);
            }

            ControlUtil.setComponetEditable(this.btnClientCreditLineRefresh, true);
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Save(object sender, EventArgs e)
        {
            this.clientBindingSource.EndEdit();
            Client client = (Client)this.clientBindingSource.DataSource;
            client.ClientType = this.clientTypeComboBox.Text;
            client.ClientLevel = this.clientLevelComboBox.Text;
            client.IsGroup = this.isGroupComboBox.Text;
            client.BranchCode = (string)this.departmentComboTree.SelectedValue;
            client.CountryCode = (string)this.countryCodeComboBox.SelectedValue;
            client.Industry = this.industryComboBox.Text;

            if (this.opType == OpType.NEW_CLIENT)
            {
                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.Clients.InsertOnSubmit(client);
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBox.Show(e1.Message);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (this.opType == OpType.UPDATE_CLIENT)
            {
                bool isUpdateOK = true;
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (System.Data.Linq.ChangeConflictException e2)
                {
                    isUpdateOK = false;
                    MessageBox.Show(e2.GetType().ToString() + " " + e2.Message);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Cancel current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClientCreditLine(object sender, EventArgs e)
        {
            this.creditLineCommentTextBox.ReadOnly = false;
            this.creditLineCurrencyComboBox.Enabled = true;
            this.creditLineTextBox.ReadOnly = false;
            this.creditLineTypeComboBox.Enabled = true;
            this.approveNoTextBox.ReadOnly = false;
            this.approveTypeComboBox.Enabled = true;
            this.btnClientCreditLineSave.Enabled = true;
            this.btnClientCreditLineCancel.Enabled = true;
            this.periodBeginDateTimePicker.Enabled = true;
            this.periodEndDateTimePicker.Enabled = true;
            ClientCreditLine newClientCreditLine = new ClientCreditLine();
            newClientCreditLine.Client = (Client)this.clientBindingSource.DataSource;
            this.clientCreditLineBindingSource.DataSource = newClientCreditLine;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveClientCreditLine(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            ClientCreditLine creditLine = (ClientCreditLine)this.clientCreditLineBindingSource.DataSource;
            creditLine.CreditLineCurrency = (string)this.creditLineCurrencyComboBox.SelectedValue;
            creditLine.PeriodBegin = this.periodBeginDateTimePicker.Value;
            creditLine.PeriodEnd = this.periodEndDateTimePicker.Value;

            if (creditLine.CreditLineID == 0)
            {
                creditLine.Client = client;

                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.ClientCreditLines.InsertOnSubmit(creditLine);
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBox.Show(e1.Message);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                bool isUpdateOK = true;
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (System.Data.Linq.ChangeConflictException e2)
                {
                    isUpdateOK = false;
                    MessageBox.Show(e2.GetType().ToString() + " " + e2.Message);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelClientCreditLine(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FreezeClientCreditLine(object sender, EventArgs e)
        {
            this.freezeReasonTextBox.ReadOnly = false;
            this.freezerTextBox.Text = App.Current.CurUser.Name;
            this.freezeDateDateTimePicker.Value = System.DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnfreezeClientCreditLine(object sender, EventArgs e)
        {
            this.unfreezeReasonTextBox.ReadOnly = false;
            this.unfreezerTextBox.Text = App.Current.CurUser.Name;
            this.unfreezeDateDateTimePicker.Value = System.DateTime.Now;
        }

        private void RefreshClientCreditLine(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client != null)
            {
                this.dgvClientCreditLines.DataSource = App.Current.DbContext.ClientCreditLines.Where(c => c.Client.ClientEDICode == client.ClientEDICode).ToList();
            }
        }

        private void SelectClientCreditLine(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvClientCreditLines.SelectedRows.Count == 0)
            {
                return;
            }
            int cid = (int)dgvClientCreditLines["creditLineIDColumn", dgvClientCreditLines.SelectedRows[0].Index].Value;
            if (cid != 0)
            {
                ClientCreditLine selectedClientCreditLine = App.Current.DbContext.ClientCreditLines.SingleOrDefault(c => c.CreditLineID == cid);
                if (selectedClientCreditLine != null)
                {
                    this.clientCreditLineBindingSource.DataSource = selectedClientCreditLine;
                    this.btnClientCreditCoverFreeze.Enabled = true;
                    this.btnClientCreditCoverUnfreeze.Enabled = true;
                    this.btnClientCreditLineNew.Enabled = true;
                    this.btnClientCreditLineCancel.Enabled = true;
                    this.btnClientCreditLineSave.Enabled = true;
                }
            }
        }
    }
}

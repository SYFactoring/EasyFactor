//-----------------------------------------------------------------------
// <copyright file="ClientDetailUI.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    using System;
    using System.Windows.Forms;
    using System.Linq;
    using CMBC.EasyFactor.DB.dbml;
    using DevComponents.DotNetBar.Controls;
    using DevComponents.DotNetBar;
    using CMBC.EasyFactor.Utils;
    using DevComponents.Editors;

    public partial class ClientDetail : DevComponents.DotNetBar.Office2007Form
    {

        public enum OpType { NEW_CLIENT, UPDATE_CLIENT, DETAIL_CLIENT, UPDATE_CLIENT_CREDIT_COVER };

        private readonly OpType opType;

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="client">selected client</param>
        /// <param name="isEditable">true if editable</param>
        public ClientDetail(Client client, OpType opType)
        {
            this.InitializeComponent();
            this.opType = opType;
            if (opType == OpType.NEW_CLIENT)
            {
                 this.clientBindingSource.DataSource = new Client();
            }
            else
            {
                 this.clientBindingSource.DataSource = client;
            }

            this.UpdateEditableStatus();
            InitComboBox(client);
            // this.creditLineMgrBindingSource.DataSource = updateClient.ClientCreditLines;
            // this.clientAccountMgrBindingSource.DataSource = updateClient.ClientAccounts;
        }

        private void InitComboBox(Client updateClient)
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



            foreach (Country country in this.countryCodeComboBox.Items)
            {
                if (country.CountryCode.Equals(updateClient.CountryCode))
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
            if (opType == OpType.DETAIL_CLIENT)
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
            else if (opType == OpType.NEW_CLIENT)
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
            else if (opType == OpType.UPDATE_CLIENT)
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
            else if (opType == OpType.UPDATE_CLIENT_CREDIT_COVER)
            {

            }
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

            //System.Data.Linq.EntitySet<ClientAccount> cAccounts = (System.Data.Linq.EntitySet<ClientAccount>)this.clientAccountMgrBindingSource.DataSource;
            //ClientAccount cAccount = (ClientAccount)this.clientAccountBindingSource.DataSource;
            //cAccounts.Add(cAccount);
            //System.Data.Linq.EntitySet<ClientCreditLine> cCreditLines = (System.Data.Linq.EntitySet<ClientCreditLine>)this.creditLineMgrBindingSource.DataSource;
            //ClientCreditLine cCreditLine = (ClientCreditLine)this.creditLineBindingSource.DataSource;
            //cCreditLines.Add(cCreditLine);
            //updateClient.ClientAccounts = cAccounts;
            //updateClient.ClientCreditLines = cCreditLines;
            if (opType == OpType.NEW_CLIENT)
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
            else if (opType == OpType.UPDATE_CLIENT)
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

        private void NewClientCreditCover(object sender, EventArgs e)
        {

        }

        private void SaveClientCreditCover(object sender, EventArgs e)
        {

        }

        private void CancelClientCreditCover(object sender, EventArgs e)
        {

        }

        private void FreezeClientCreditCover(object sender, EventArgs e)
        {

        }

        private void UnfreezeClientCreditCover(object sender, EventArgs e)
        {

        }

    }
}

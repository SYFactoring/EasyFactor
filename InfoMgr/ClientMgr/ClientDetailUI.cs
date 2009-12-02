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

    /// <summary>
    /// Client Detail User Interface 
    /// </summary>
    public partial class ClientDetailUI : DevComponents.DotNetBar.Office2007Form
    {
        /// <summary>
        /// flag indicates if add
        /// </summary>
        private readonly bool isAdd;

        /// <summary>
        /// original client
        /// </summary>
        private readonly CMBC.EasyFactor.DB.dbml.Client originalClient;

        /// <summary>
        /// Initializes a new instance of the ClientDetailUI class
        /// </summary>
        /// <param name="client">selected client</param>
        /// <param name="isEditable">true if editable</param>
        public ClientDetailUI(CMBC.EasyFactor.DB.dbml.Client client, bool isEditable)
        {
            this.InitializeComponent();
            Client updateClient = new Client();
            if (client == null)
            {
                this.isAdd = true;
            }
            else
            {
                this.originalClient = client;
                updateClient.Copy(client);
            }

            this.clientBindingSource.DataSource = updateClient;
            this.UpdateEditableStatus(isEditable);
            this.creditLineBindingSource.DataSource = updateClient.ClientCreditLines;
            this.clientAccountBindingSource.DataSource = updateClient.ClientAccounts;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ca"></param>
        /// <param name="isEditable"></param>
        public ClientDetailUI(ClientAccount ca, bool isEditable)
        {
        }
        /// <summary>
        /// update editable status
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        private void UpdateEditableStatus(bool isEditable)
        {
            if (!isEditable)
            {
                this.btnCancel.Enabled = false;
                this.btnSave.Enabled = false;
                this.btnCancel.Visible = false;
                this.btnSave.Visible = false;

                this.tbAddressCN.ReadOnly = true;
                this.tbAddressEN.ReadOnly = true;
                this.tbBranchID.ReadOnly = true;
                this.tbCellPhone.ReadOnly = true;
                this.tbCityCN.ReadOnly = true;
                this.tbCityEN.ReadOnly = true;
                this.tbClientNameCN.ReadOnly = true;
                this.tbClientNameEN1.ReadOnly = true;
                this.tbClientNameEN2.ReadOnly = true;
                this.tbComment.ReadOnly = true;
                this.tbCompanyCode.ReadOnly = true;
                this.tbCompanyRegistrationNumber.ReadOnly = true;
                this.tbContactName.ReadOnly = true;
                this.tbCountryCode.Enabled = false;
              //  this.tbCountryEN.ReadOnly = true;
                this.tbEDINo.ReadOnly = true;
                this.tbEmail.ReadOnly = true;
                this.tbFaxNumber.ReadOnly = true;
                this.tbPMName.ReadOnly = true;
                this.tbPostCode.ReadOnly = true;
                this.tbProvinceCN.ReadOnly = true;
                this.tbProvinceEN.ReadOnly = true;
                this.tbResponsibleAgency.ReadOnly = true;
                this.tbTelephone.ReadOnly = true;
                this.tbWetsite.ReadOnly = true;

                this.tbAccountComment.ReadOnly = true;
                this.tbAccountCurrency.ReadOnly = true;
                this.tbAccountNo.ReadOnly = true;
                this.tbAccountType.ReadOnly = true;
                this.tbBank.ReadOnly = true;
                this.tbBranch.ReadOnly = true;

                this.tbCreditComment.ReadOnly = true;
                this.tbCreditLineCurrency.ReadOnly = true;
                this.tbCreditLineLimit.ReadOnly = true;
                this.tbCreditLineType.ReadOnly = true;
                this.tbAuthorizationNo.ReadOnly = true;
                this.tpPeriodBeginDate.Enabled = false;
                this.tpPeriodEndDate.Enabled = false;
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
            Client updateClient = (Client)this.clientBindingSource.DataSource;

            System.Data.Linq.EntitySet<ClientAccount> cAccounts = (System.Data.Linq.EntitySet<ClientAccount>)this.clientAccountBindingSource.DataSource;
            ClientAccount cAccount = (ClientAccount)this.clientAccountBindingSource1.DataSource;
            cAccounts.Add(cAccount);
            System.Data.Linq.EntitySet<ClientCreditLine> cCreditLines = (System.Data.Linq.EntitySet<ClientCreditLine>)this.creditLineBindingSource.DataSource;
            ClientCreditLine cCreditLine = (ClientCreditLine)this.creditLineBindingSource1.DataSource;
            cCreditLines.Add(cCreditLine);
            updateClient.ClientAccounts = cAccounts;
            updateClient.ClientCreditLines = cCreditLines;
            if (this.isAdd)
            {
                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.Clients.InsertOnSubmit(updateClient);
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
                    Close();
                }
            }
            else
            {
                bool isUpdateOK = true;
                Client tempClient = new Client();
                tempClient.Copy(this.originalClient);
                this.originalClient.Copy(updateClient);
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (System.Data.Linq.ChangeConflictException e2)
                {
                    isUpdateOK = false;
                    this.originalClient.Copy(tempClient);
                    MessageBox.Show(e2.GetType().ToString()+" "+e2.Message);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
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

        private void dgvClientAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvClientAccount.SelectedRows.Count == 0 || this.clientAccountBindingSource == null)
            {
                return;
            }

            string cid = (string)dgvClientAccount["AccountID", dgvClientAccount.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                ClientAccount selectedClient = App.Current.DbContext.ClientAccounts.FirstOrDefault(c => c.AccountID == cid);
                if (selectedClient != null)
                {
                    this.clientAccountBindingSource1.DataSource = selectedClient;
                }
            }
        }

        private void dgvClientCreditLine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvClientCreditLine.SelectedRows.Count == 0 || this.creditLineBindingSource == null)
            {
                return;
            }

            string cid = (string)dgvClientCreditLine["CreditLineID", dgvClientCreditLine.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                ClientCreditLine selectedClient = App.Current.DbContext.ClientCreditLines.FirstOrDefault(c => c.CreditLineID == cid);
                if (selectedClient != null)
                {
                    this.creditLineBindingSource1.DataSource = selectedClient;
                }
            }
        }
    }
}

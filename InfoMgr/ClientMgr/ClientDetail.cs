﻿//-----------------------------------------------------------------------
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
        private OpType opType;

        //private Client oldClient;

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
                client.Backup();
                this.FillClientForms(client);
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
        private void FillClientForms(Client client)
        {
            foreach (Country country in this.countryCodeComboBox.Items)
            {
                if (country.CountryCode.Equals(client.CountryCode))
                {
                    this.countryCodeComboBox.SelectedItem = country;
                    break;
                }
            }
            int deptIndex = -1;
            foreach (Department dept in (IQueryable<Department>)this.departmentComboTree.DataSource)
            {
                deptIndex++;
                if (dept.DepartmentCode.Equals(client.BranchCode))
                {
                    this.departmentComboTree.SelectedIndex = deptIndex;
                    break;
                }
            }
            this.dgvClientCreditLines.DataSource = client.ClientCreditLines.ToList();

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

                ControlUtil.setComponetEditable(this.btnClientClose, true);
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

                ControlUtil.setComponetEditable(this.btnClientClose, true);
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

                ControlUtil.setComponetEditable(this.btnClientClose, true);
                ControlUtil.setComponetEditable(this.btnClientSave, true);
                this.clientEDICodeTextBox.ReadOnly = true;
            }

            foreach (Control comp in this.groupPanelClientCreditCover.Controls)
            {
                ControlUtil.setComponetEditable(comp, false);
            }

            if (opType == OpType.NEW_CLIENT_CREDIT_COVER)
            {
                ControlUtil.setComponetEditable(this.btnClientCreditLineSave, true);
                ControlUtil.setComponetEditable(this.btnClientCreditLineDelete, true);
            }
            ControlUtil.setComponetEditable(this.btnClientCreditLineNew, true);
            ControlUtil.setComponetEditable(this.btnClientCreditLineRefresh, true);
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ClientSave(object sender, EventArgs e)
        {
            this.clientBindingSource.EndEdit();
            Client client = (Client)this.clientBindingSource.DataSource;
            client.ClientType = this.clientTypeComboBox.Text;
            client.ClientLevel = this.clientLevelComboBox.Text;
            client.IsGroup = this.isGroupComboBox.Text;
            client.Department = (Department)this.departmentComboTree.SelectedValue;
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
                    client.Backup();
                    MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Cancel current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ClientCancel(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            client.Restore();
            //client.Copy(oldClient);
           // Close();
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
            this.btnClientCreditLineDelete.Enabled = true;
            this.periodBeginDateTimePicker.Enabled = true;
            this.periodEndDateTimePicker.Enabled = true;
            ClientCreditLine newClientCreditLine = new ClientCreditLine();
            newClientCreditLine.Client = (Client)this.clientBindingSource.DataSource;
            this.clientCreditLineBindingSource.DataSource = newClientCreditLine;
            this.creditLineCurrencyComboBox.SelectedIndex = -1;
            this.creditLineTypeComboBox.SelectedIndex = -1;
            this.periodBeginDateTimePicker.Value = DateTime.Now;
            this.periodEndDateTimePicker.Value = DateTime.Now;
            this.approveTypeComboBox.SelectedIndex = -1;
            this.freezeReasonTextBox.Text = string.Empty;
            this.freezeReasonTextBox.ReadOnly = true;
            this.freezerTextBox.Text = string.Empty;
            this.unfreezeReasonTextBox.Text = string.Empty;
            this.unfreezeReasonTextBox.ReadOnly = true;
            this.unfreezerTextBox.Text = string.Empty;
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
            if (!this.freezerTextBox.Text.Equals(string.Empty) && creditLine.Freezer == null)
            {
                creditLine.Freezer = this.freezerTextBox.Text;
                creditLine.FreezeReason = this.freezeReasonTextBox.Text;
                creditLine.FreezeDate = this.freezeDateDateTimePicker.Value;
            }
            if (!this.unfreezerTextBox.Text.Equals(string.Empty) && creditLine.Unfreezer == null)
            {
                creditLine.Unfreezer = this.unfreezerTextBox.Text;
                creditLine.UnfreezeReason = this.unfreezeReasonTextBox.Text;
                creditLine.UnfreezeDate = this.unfreezeDateDateTimePicker.Value;
            }
            if (client == null)
            {
                MessageBox.Show("请首先选定一个客户", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                    this.dgvClientCreditLines.DataSource = client.ClientCreditLines.ToList();
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
        private void DeleteClientCreditLine(object sender, EventArgs e)
        {
            ClientCreditLine creditLine = (ClientCreditLine)this.clientCreditLineBindingSource.DataSource;
            Client client = (Client)this.clientBindingSource.DataSource;
            bool isDeleteOK = true;
            try
            {
                App.Current.DbContext.ClientCreditLines.DeleteOnSubmit(creditLine);
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBox.Show(e1.Message);
            }

            if (isDeleteOK)
            {
                MessageBox.Show("数据删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvClientCreditLines.DataSource = client.ClientCreditLines;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FreezeClientCreditLine(object sender, EventArgs e)
        {
            ClientCreditLine creditLine = (ClientCreditLine)this.clientCreditLineBindingSource.DataSource;
            this.freezeReasonTextBox.ReadOnly = false;
            if (creditLine.Freezer == null)
            {
                creditLine.Freezer =  App.Current.CurUser.Name;
                creditLine.FreezeDate = System.DateTime.Now;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnfreezeClientCreditLine(object sender, EventArgs e)
        {
            ClientCreditLine creditLine = (ClientCreditLine)this.clientCreditLineBindingSource.DataSource;
            this.unfreezeReasonTextBox.ReadOnly = false;
            if (creditLine.Unfreezer == null)
            {
                creditLine.Unfreezer = App.Current.CurUser.Name;
                creditLine.UnfreezeDate = System.DateTime.Now;
            }
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
                Client clinet = (Client)this.clientBindingSource.DataSource;
                ClientCreditLine selectedClientCreditLine = clinet.ClientCreditLines.SingleOrDefault(c => c.CreditLineID == cid);
                if (selectedClientCreditLine != null)
                {
                    this.clientCreditLineBindingSource.DataSource = selectedClientCreditLine;
                    this.btnClientCreditCoverFreeze.Enabled = true;
                    this.btnClientCreditCoverUnfreeze.Enabled = true;
                    this.btnClientCreditLineNew.Enabled = true;
                    this.btnClientCreditLineDelete.Enabled = true;
                    this.btnClientCreditLineSave.Enabled = true;
                    foreach (Currency currency in this.creditLineCurrencyComboBox.Items)
                    {
                        if (currency.CurrencyCode.Equals(selectedClientCreditLine.CreditLineCurrency))
                        {
                            this.creditLineCurrencyComboBox.SelectedItem = currency;
                            break;
                        }
                    }
                }
            }
        }

        private void ClientUpdate(object sender, EventArgs e)
        {
            this.opType = OpType.UPDATE_CLIENT;
            this.UpdateEditableStatus();
        }

        private void creditLineTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlUtil.CheckIntegerInput(sender, e);
        }

    }
}

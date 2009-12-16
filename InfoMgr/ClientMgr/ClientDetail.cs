//-----------------------------------------------------------------------
// <copyright file="ClientDetail.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// Client Detail
    /// </summary>
    public partial class ClientDetail : DevComponents.DotNetBar.Office2007Form
    {
        /// <summary>
        /// 
        /// </summary>
        private OpClientType opClientType;

        /// <summary>
        /// 
        /// </summary>
        private OpClientCreditLineType opClientCreditLineType;

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="client">selected client</param>
        /// <param name="opType">operation type</param>
        public ClientDetail(Client client, OpClientType opClientType, OpClientCreditLineType opClientCreditLineType)
        {
            this.InitializeComponent();
            this.InitComboBox();
            this.opClientType = opClientType;
            this.opClientCreditLineType = opClientCreditLineType;
            if (opClientType == OpClientType.NEW_CLIENT)
            {
                this.clientBindingSource.DataSource = new Client();
            }
            else
            {
                this.clientBindingSource.DataSource = client;
                client.Backup();
            }

            this.UpdateClientControlStatus();
            this.UpdateClientCreditLineControlStatus();
            if (opClientCreditLineType == OpClientCreditLineType.NEW_CLIENT_CREDIT_LINE)
            {
                this.tabControl.SelectedTab = this.tabItemClientCreditLine;
                this.clientCreditLineBindingSource.DataSource = new ClientCreditLine();
            }
        }

        /// <summary>
        /// Operation Type 
        /// </summary>
        public enum OpClientType
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
            DETAIL_CLIENT
        }

        /// <summary>
        /// 
        /// </summary>
        public enum OpClientCreditLineType
        {
            /// <summary>
            /// Update Client Credit Line
            /// </summary>
            NEW_CLIENT_CREDIT_LINE,

            /// <summary>
            /// 
            /// </summary>
            UPDATE_CLIENT_CREDIT_LINE,

            /// <summary>
            /// 
            /// </summary>
            DETAIL_CLIENT_CREDIT_LINE
        }

        /// <summary>
        /// Initial ComboBox
        /// </summary>
        private void InitComboBox()
        {
            this.cbCountryCode.DataSource = App.Current.DbContext.Countries;
            this.cbCountryCode.DisplayMember = "CountryFormatCN";
            this.cbCountryCode.ValueMember = "CountryCode";
            this.cbCountryCode.SelectedIndex = -1;

            this.cbDepartments.DataSource = App.Current.DbContext.Departments;
            this.cbDepartments.DisplayMembers = "DepartmentName";
            this.cbDepartments.GroupingMembers = "Domain";
            this.cbDepartments.SelectedIndex = -1;

            this.creditLineCurrencyComboBox.DataSource = App.Current.DbContext.Currencies;
            this.creditLineCurrencyComboBox.DisplayMember = "CurrencyFormat";
            this.creditLineCurrencyComboBox.ValueMember = "CurrencyCode";
            this.creditLineCurrencyComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// udpate editable status
        /// </summary>
        private void UpdateClientControlStatus()
        {
            if (this.opClientType == OpClientType.DETAIL_CLIENT)
            {
                foreach (Control comp in this.groupPanelClientBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in this.groupPanelClientContact.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in this.groupPanelClientGroup.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in this.groupPanelClientStat.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (this.opClientType == OpClientType.NEW_CLIENT)
            {
                foreach (Control comp in this.groupPanelClientBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelClientContact.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelClientGroup.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelClientStat.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (this.opClientType == OpClientType.UPDATE_CLIENT)
            {
                foreach (Control comp in this.groupPanelClientBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelClientContact.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelClientGroup.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelClientStat.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                this.clientEDICodeTextBox.ReadOnly = true;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client.ClientEDICode != null)
            {
                foreach (Country country in this.cbCountryCode.Items)
                {
                    if (country.CountryCode.Equals(client.CountryCode))
                    {
                        this.cbCountryCode.SelectedItem = country;
                        break;
                    }
                }

                int deptIndex = -1;
                foreach (Department dept in (IQueryable<Department>)this.cbDepartments.DataSource)
                {
                    deptIndex++;
                    if (dept.DepartmentCode.Equals(client.BranchCode))
                    {
                        this.cbDepartments.SelectedIndex = deptIndex;
                        break;
                    }
                }

                this.dgvClientCreditLines.DataSource = client.ClientCreditLines.ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateClientCreditLineControlStatus()
        {
            if (this.opClientCreditLineType == OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE)
            {
                foreach (Control comp in this.groupPanelClientCreditLine.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (this.opClientCreditLineType == OpClientCreditLineType.NEW_CLIENT_CREDIT_LINE)
            {
                foreach (Control comp in this.groupPanelClientCreditLine.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                this.freezeReasonTextBox.ReadOnly = true;
                this.freezerTextBox.ReadOnly = true;
                this.freezeDateDateTimePicker.Enabled = false;
                this.unfreezeReasonTextBox.ReadOnly = true;
                this.unfreezerTextBox.ReadOnly = true;
                this.unfreezeDateDateTimePicker.Enabled = false;
            }
            else if (this.opClientCreditLineType == OpClientCreditLineType.UPDATE_CLIENT_CREDIT_LINE)
            {
                foreach (Control comp in this.groupPanelClientCreditLine.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                this.freezeReasonTextBox.ReadOnly = true;
                this.freezerTextBox.ReadOnly = true;
                this.freezeDateDateTimePicker.Enabled = false;
                this.unfreezeReasonTextBox.ReadOnly = true;
                this.unfreezerTextBox.ReadOnly = true;
                this.unfreezeDateDateTimePicker.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientUpdate(object sender, EventArgs e)
        {
            this.opClientType = OpClientType.UPDATE_CLIENT;
            this.UpdateClientControlStatus();
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
            client.Department = (Department)this.cbDepartments.SelectedValue;
            client.CountryCode = (string)this.cbCountryCode.SelectedValue;
            client.Industry = this.cbIndustry.Text;

            if (this.opClientType == OpClientType.NEW_CLIENT)
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
                    client.Backup();
                    this.opClientType = OpClientType.UPDATE_CLIENT;
                }
            }
            else
            {
                bool isUpdateOK = true;
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBox.Show(e2.Message);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    client.Backup();
                }
            }
        }

        /// <summary>
        /// Cancel current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ClientClose(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (this.opClientType == OpClientType.UPDATE_CLIENT)
            {
                client.Restore();
            }

            if (this.opClientCreditLineType == OpClientCreditLineType.UPDATE_CLIENT_CREDIT_LINE)
            {
                if (this.clientCreditLineBindingSource.DataSource is ClientCreditLine)
                {
                    ClientCreditLine creditLine = (ClientCreditLine)this.clientCreditLineBindingSource.DataSource;
                    if (creditLine.CreditLineID != 0)
                    {
                        creditLine.Restore();
                    }
                }
            }

            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshClientCreditLine(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client != null)
            {
                this.dgvClientCreditLines.DataSource = client.ClientCreditLines.ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCreditLine(object sender, EventArgs e)
        {
            this.opClientCreditLineType = OpClientCreditLineType.UPDATE_CLIENT_CREDIT_LINE;
            this.UpdateClientCreditLineControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClientCreditLine(object sender, EventArgs e)
        {
            this.ResetClientCreditLine();
            this.clientCreditLineBindingSource.DataSource = new ClientCreditLine();
            this.opClientCreditLineType = OpClientCreditLineType.NEW_CLIENT_CREDIT_LINE;
            this.UpdateClientCreditLineControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveClientCreditLine(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null)
            {
                MessageBox.Show("请首先选定一个客户", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                    this.NewClientCreditLine(null, null);
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
                    creditLine.Backup();
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
            if (this.clientCreditLineBindingSource.DataSource is ClientCreditLine)
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
                    this.dgvClientCreditLines.DataSource = client.ClientCreditLines.ToList();
                }
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
                creditLine.Freezer = App.Current.CurUser.Name;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectClientCreditLine(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvClientCreditLines.SelectedRows.Count == 0)
            {
                return;
            }

            int cid = (int)this.dgvClientCreditLines["creditLineIDColumn", this.dgvClientCreditLines.SelectedRows[0].Index].Value;
            if (cid != 0)
            {
                Client clinet = (Client)this.clientBindingSource.DataSource;
                ClientCreditLine selectedClientCreditLine = clinet.ClientCreditLines.SingleOrDefault(c => c.CreditLineID == cid);
                if (selectedClientCreditLine != null && this.clientCreditLineBindingSource.DataSource != selectedClientCreditLine)
                {
                    this.ResetClientCreditLine();
                    this.clientCreditLineBindingSource.DataSource = selectedClientCreditLine;
                    this.btnClientCreditLineFreeze.Enabled = true;
                    this.btnClientCreditLineUnfreeze.Enabled = true;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientDetail_Leave(object sender, EventArgs e)
        {
            this.ClientClose(sender, e);
        }

        /// <summary>
        /// 
        /// </summary>
        private void ResetClientCreditLine()
        {
            foreach (Control comp in this.groupPanelClientCreditLine.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }
        }
    }
}

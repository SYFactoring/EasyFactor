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
        /// 
        /// </summary>
        private OpContractType opContractType;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="opClientType"></param>
        public ClientDetail(Client client, OpClientType opClientType)
            : this(client, opClientType, OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE, OpContractType.DETAIL_CONTRACT)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="opClientCreditLineType"></param>
        public ClientDetail(Client client, OpClientCreditLineType opClientCreditLineType)
            : this(client, OpClientType.DETAIL_CLIENT, opClientCreditLineType, OpContractType.DETAIL_CONTRACT)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="opContractType"></param>
        public ClientDetail(Client client, OpContractType opContractType)
            : this(client, OpClientType.DETAIL_CLIENT, OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE, opContractType)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="client">selected client</param>
        /// <param name="opClientType">client operation type</param>
        /// <param name="opClientCreditLineType">client credit line operation type</param>
        /// <param name="opContractType">client contract opertion type</param>
        private ClientDetail(Client client, OpClientType opClientType, OpClientCreditLineType opClientCreditLineType, OpContractType opContractType)
        {
            this.InitializeComponent();
            this.InitComboBox();
            this.opClientType = opClientType;
            this.opClientCreditLineType = opClientCreditLineType;
            this.opContractType = opContractType;

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
            this.UpdateContractControlStatus();

            if (opClientCreditLineType == OpClientCreditLineType.NEW_CLIENT_CREDIT_LINE)
            {
                this.tabControl.SelectedTab = this.tabItemClientCreditLine;
                this.clientCreditLineBindingSource.DataSource = new ClientCreditLine();
            }

            if (opContractType == OpContractType.NEW_CONTRACT)
            {
                this.tabControl.SelectedTab = this.tabItemContract;
                this.contractBindingSource.DataSource = new Contract();
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
        /// 
        /// </summary>
        public enum OpContractType
        {
            /// <summary>
            /// 
            /// </summary>
            NEW_CONTRACT,

            /// <summary>
            /// 
            /// </summary>
            UPDATE_CONTRACT,

            /// <summary>
            /// 
            /// </summary>
            DETAIL_CONTRACT
        }

        /// <summary>
        /// Initial ComboBox
        /// </summary>
        private void InitComboBox()
        {
            this.cbCountryCode.DataSource = Country.AllCountries();
            this.cbCountryCode.DisplayMember = "CountryFormatCN";
            this.cbCountryCode.ValueMember = "CountryCode";

            this.cbDepartments.DataSource = Department.AllDepartments();
            this.cbDepartments.DisplayMembers = "DepartmentName";
            this.cbDepartments.GroupingMembers = "Domain";
            this.cbDepartments.ValueMember = "DepartmentCode";

            this.creditLineCurrencyComboBox.DataSource = Currency.AllCurrencies();
            this.creditLineCurrencyComboBox.DisplayMember = "CurrencyFormat";
            this.creditLineCurrencyComboBox.ValueMember = "CurrencyCode";
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
                this.dgvClientCreditLines.DataSource = client.ClientCreditLines.ToList();
                this.dgvContracts.DataSource = client.Contracts.ToList();
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

                this.creditLineStatusTextBox.ReadOnly = true;
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

                this.creditLineStatusTextBox.ReadOnly = true;
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
        private void UpdateContractControlStatus()
        {
            if (this.opContractType == OpContractType.DETAIL_CONTRACT)
            {
                foreach (Control comp in this.groupPanelContract.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (this.opContractType == OpContractType.NEW_CONTRACT)
            {
                foreach (Control comp in this.groupPanelContract.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (this.opContractType == OpContractType.UPDATE_CONTRACT)
            {
                foreach (Control comp in this.groupPanelContract.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                this.tbContractCode.ReadOnly = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientDetail_Leave(object sender, EventArgs e)
        {
            this.CloseClient(sender, e);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateClient(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBox.Show("请首先选定一个客户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.opClientType = OpClientType.UPDATE_CLIENT;
            this.UpdateClientControlStatus();
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SaveClient(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;

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
                if (client.ClientEDICode == null)
                {
                    return;
                }

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
        private void CloseClient(object sender, EventArgs e)
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

            if (this.opContractType == OpContractType.UPDATE_CONTRACT)
            {
                if (this.contractBindingSource.DataSource is Contract)
                {
                    Contract contract = (Contract)this.contractBindingSource.DataSource;
                    if (contract.ContractCode != null)
                    {
                        contract.Restore();
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
            if (client == null || client.ClientEDICode == null)
            {
                MessageBox.Show("请首先选定一个客户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.dgvClientCreditLines.DataSource = client.ClientCreditLines.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClientCreditLine(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBox.Show("请首先选定一个客户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
        private void UpdateCreditLine(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBox.Show("请首先选定一个客户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.clientCreditLineBindingSource.DataSource is ClientCreditLine))
            {
                return;
            }

            this.opClientCreditLineType = OpClientCreditLineType.UPDATE_CLIENT_CREDIT_LINE;
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
            if (client == null || client.ClientEDICode == null)
            {
                MessageBox.Show("请首先选定一个客户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.clientCreditLineBindingSource.DataSource is ClientCreditLine))
            {
                return;
            }

            ClientCreditLine creditLine = (ClientCreditLine)this.clientCreditLineBindingSource.DataSource;

            if (creditLine.Freezer == null && this.freezeDateDateTimePicker.Enabled)
            {
                creditLine.Freezer = App.Current.CurUser.Name;
            }

            if (creditLine.Unfreezer == null && this.unfreezeDateDateTimePicker.Enabled)
            {
                creditLine.Unfreezer = App.Current.CurUser.Name;
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
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBox.Show(e2.Message);
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
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBox.Show("请首先选定一个客户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.clientCreditLineBindingSource.DataSource is ClientCreditLine))
            {
                return;
            }

            ClientCreditLine creditLine = (ClientCreditLine)this.clientCreditLineBindingSource.DataSource;
            if (creditLine.CreditLineID == 0)
            {
                return;
            }

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
                this.ResetClientCreditLine();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FreezeClientCreditLine(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBox.Show("请首先选定一个客户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.clientCreditLineBindingSource.DataSource is ClientCreditLine))
            {
                return;
            }

            ClientCreditLine creditLine = (ClientCreditLine)this.clientCreditLineBindingSource.DataSource;
            if (creditLine.CreditLineID == 0)
            {
                return;
            }

            this.freezeReasonTextBox.ReadOnly = false;
            this.freezeDateDateTimePicker.Enabled = true;
            if (creditLine.Freezer == null)
            {
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
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBox.Show("请首先选定一个客户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.clientCreditLineBindingSource.DataSource is ClientCreditLine))
            {
                return;
            }

            ClientCreditLine creditLine = (ClientCreditLine)this.clientCreditLineBindingSource.DataSource;
            if (creditLine.CreditLineID == 0)
            {
                return;
            }

            this.unfreezeReasonTextBox.ReadOnly = false;
            this.unfreezeDateDateTimePicker.Enabled = true;
            if (creditLine.Unfreezer == null)
            {
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
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateContract(object sender, EventArgs e)
        {
            this.opContractType = OpContractType.UPDATE_CONTRACT;
            this.UpdateContractControlStatus();
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SaveContract(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null)
            {
                MessageBox.Show("请首先选定一个客户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.contractBindingSource.DataSource is Contract))
            {
                return;
            }

            Contract contract = (Contract)this.contractBindingSource.DataSource;

            if (this.opContractType == OpContractType.NEW_CONTRACT)
            {
                contract.ContractCode = GenerateContractCode();
                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.Contracts.InsertOnSubmit(contract);
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
                    contract.Backup();
                    this.opContractType = OpContractType.UPDATE_CONTRACT;
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
                    contract.Backup();
                }
            }
        }

        private string GenerateContractCode()
        {
            return string.Empty;
        }
    }
}

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
    using System.Collections.Generic;

    /// <summary>
    /// Client Detail
    /// </summary>
    public partial class ClientDetail : DevComponents.DotNetBar.Office2007Form
    {
		#region Fields (3) 

        /// <summary>
        /// 
        /// </summary>
        private OpClientCreditLineType opClientCreditLineType;
        /// <summary>
        /// 
        /// </summary>
        private OpClientType opClientType;
        /// <summary>
        /// 
        /// </summary>
        private OpContractType opContractType;

		#endregion Fields 

		#region Enums (3) 

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

		#endregion Enums 

		#region Constructors (4) 

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
                this.dgvClientCreditLines.DataSource = client.ClientCreditLines.ToList();
                this.dgvContracts.DataSource = client.Contracts.ToList();
                List<Department> deptsList = (List<Department>)this.cbDepartments.DataSource;
                this.cbDepartments.SelectedIndex = deptsList.IndexOf(client.Department);
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

		#endregion Constructors 

		#region Methods (24) 

		// Private Methods (24) 

        private void cbDepartments_SelectionChanged(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            if (this.clientBindingSource.DataSource is Client)
            {
                Client client = (Client)this.clientBindingSource.DataSource;
                if (this.cbDepartments.SelectedNode != null)
                {
                    client.Department = (Department)this.cbDepartments.SelectedNode.DataKey;
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
            this.CloseClient(sender, e);
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

        private void DeleteContract(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBox.Show("请首先选定一个客户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.contractBindingSource.DataSource is Contract))
            {
                return;
            }

            Contract contract = (Contract)this.contractBindingSource.DataSource;
            if (contract.ContractCode == null)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                App.Current.DbContext.Contracts.DeleteOnSubmit(contract);
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
                this.dgvContracts.DataSource = client.Contracts.ToList();
                this.ResetContract();
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

            if (creditLine.CreditLineStatus == "已生效")
            {
                this.freezeReasonTextBox.ReadOnly = false;
                this.freezeDateDateTimePicker.Enabled = true;
                creditLine.Freezer = App.Current.CurUser.Name;
                creditLine.FreezeDate = System.DateTime.Now;
            }
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

        private void NewContract(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBox.Show("请首先选定一个客户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.ResetContract();
            this.contractBindingSource.DataSource = new Contract();
            this.opContractType = OpContractType.NEW_CONTRACT;
            this.UpdateContractControlStatus();
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
        private void RefreshContracts(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBox.Show("请首先选定一个客户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.dgvContracts.DataSource = client.Contracts.ToList();
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
        private void ResetContract()
        {
            foreach (Control comp in this.groupPanelContract.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }
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

            DateTime today = DateTime.Now;
            if (creditLine.PeriodEnd < today)
            {
                creditLine.CreditLineStatus = "已过期";
            }
            else
            {
                creditLine.CreditLineStatus = "已生效";
            }

            if (this.freezeDateDateTimePicker.Enabled)
            {
                creditLine.CreditLineStatus = "已冻结";
            }

            if (this.unfreezeDateDateTimePicker.Enabled)
            {
                if (creditLine.PeriodEnd < today)
                {
                    creditLine.CreditLineStatus = "已过期";
                }
                else
                {
                    creditLine.CreditLineStatus = "已生效";
                }
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
            this.dgvClientCreditLines.DataSource = client.ClientCreditLines.ToList();
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

            DateTime today = DateTime.Now;
            if (contract.ContractDueDate < today)
            {
                contract.ContractStatus = "已过期";
            }
            else
            {
                contract.ContractStatus = "已生效";
            }

            if (opContractType == OpContractType.NEW_CONTRACT)
            {
                bool isAddOK = true;
                contract.Client = client;
                contract.CreateUserName = App.Current.CurUser.Name;

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
                    this.NewContract(null, null);
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
            this.dgvContracts.DataSource = client.Contracts.ToList();
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

        private void SelectContract(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvContracts.SelectedRows.Count == 0)
            {
                return;
            }

            string ccode = (String)this.dgvContracts["colContractCode", this.dgvContracts.SelectedRows[0].Index].Value;
            if (ccode != null)
            {
                Client clinet = (Client)this.clientBindingSource.DataSource;
                Contract selectedContract = clinet.Contracts.SingleOrDefault(c => c.ContractCode == ccode);
                if (selectedContract != null && this.contractBindingSource.DataSource != selectedContract)
                {
                    this.ResetContract();
                    this.contractBindingSource.DataSource = selectedContract;
                }
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

            if (creditLine.CreditLineStatus == "已冻结")
            {
                this.unfreezeReasonTextBox.ReadOnly = false;
                this.unfreezeDateDateTimePicker.Enabled = true;
                creditLine.Unfreezer = App.Current.CurUser.Name;
                creditLine.UnfreezeDate = System.DateTime.Now;
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateClientCreditLine(object sender, EventArgs e)
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateContract(object sender, EventArgs e)
        {
            this.opContractType = OpContractType.UPDATE_CONTRACT;
            this.UpdateContractControlStatus();
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
            this.tbContractStatus.ReadOnly = true;
            this.tbCreateUserName.ReadOnly = true;
        }

		#endregion Methods 
    }
}

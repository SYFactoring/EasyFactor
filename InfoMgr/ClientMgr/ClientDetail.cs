//-----------------------------------------------------------------------
// <copyright file="ClientDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

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

        #endregion Enums

        #region Constructors (5)

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
            this.ImeMode = ImeMode.OnHalf;
            this.dgvClientCreditLines.AutoGenerateColumns = false;
            this.dgvContracts.AutoGenerateColumns = false;

            this.cbCountryCode.DataSource = Country.AllCountries();
            this.cbCountryCode.DisplayMember = "CountryFormatCN";
            this.cbCountryCode.ValueMember = "CountryCode";

            this.cbDepartments.DataSource = Department.AllDepartments();
            this.cbDepartments.DisplayMembers = "DepartmentName";
            this.cbDepartments.GroupingMembers = "Domain";
            this.cbDepartments.ValueMember = "DepartmentCode";
            this.cbDepartments.SelectedIndex = -1;

            this.creditLineCurrencyComboBox.DataSource = Currency.AllCurrencies();
            this.creditLineCurrencyComboBox.DisplayMember = "CurrencyFormat";
            this.creditLineCurrencyComboBox.ValueMember = "CurrencyCode";
            this.creditLineCurrencyComboBox.SelectedIndex = -1;

            this.opClientType = opClientType;
            this.opClientCreditLineType = opClientCreditLineType;
            this.opContractType = opContractType;

            if (opClientType == OpClientType.NEW_CLIENT)
            {
                client = new Client();
                this.clientBindingSource.DataSource = client;
            }
            else
            {
                this.clientBindingSource.DataSource = client;
                this.dgvClientCreditLines.DataSource = client.ClientCreditLines.ToList();
                this.dgvContracts.DataSource = client.Contracts.ToList();
                List<Department> deptsList = (List<Department>)this.cbDepartments.DataSource;
                this.cbDepartments.SelectedIndex = deptsList.IndexOf(client.Department);
                if (client.ClientGroup != null)
                {
                    this.tbGroupNameCN.Text = client.ClientGroup.ClientNameCN;
                    this.tbGroupNameEN.Text = client.ClientGroup.ClientNameEN;
                }

                client.Backup();
            }

            if (opClientCreditLineType == OpClientCreditLineType.NEW_CLIENT_CREDIT_LINE)
            {
                this.clientCreditLineBindingSource.DataSource = new ClientCreditLine();
                this.tabControl.SelectedTab = this.tabItemClientCreditLine;
            }

            if (opContractType == OpContractType.NEW_CONTRACT)
            {
                this.contractBindingSource.DataSource = new Contract();
                this.tabControl.SelectedTab = this.tabItemContract;
            }

            this.UpdateClientControlStatus();
            this.UpdateClientCreditLineControlStatus();
            this.UpdateContractControlStatus();
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="client"></param>
        /// <param name="opClientType"></param>
        public ClientDetail(Client client, OpClientType opClientType)
            : this(client, opClientType, OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE, OpContractType.DETAIL_CONTRACT)
        {
            this.tabControl.SelectedTab = this.tabItemClient;
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
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
        /// <param name="client"></param>
        /// <param name="opClientCreditLineType"></param>
        public ClientDetail(Client client, OpClientCreditLineType opClientCreditLineType)
            : this(client, OpClientType.DETAIL_CLIENT, opClientCreditLineType, OpContractType.DETAIL_CONTRACT)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="opContractType"></param>
        public ClientDetail(Contract contract, OpContractType opContractType)
            : this(contract.Client, OpClientType.DETAIL_CLIENT, OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE, opContractType)
        {
            this.tabControl.SelectedTab = this.tabItemContract;
            if (opContractType == OpContractType.DETAIL_CONTRACT || opContractType == OpContractType.UPDATE_CONTRACT)
            {
                this.contractBindingSource.DataSource = contract;
            }
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="creditLine"></param>
        /// <param name="opClientCreditLineType"></param>
        public ClientDetail(ClientCreditLine creditLine, OpClientCreditLineType opClientCreditLineType)
            : this(creditLine.Client, OpClientType.DETAIL_CLIENT, opClientCreditLineType, OpContractType.DETAIL_CONTRACT)
        {
            this.tabControl.SelectedTab = this.tabItemClientCreditLine;
            if (opClientCreditLineType == OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE || opClientCreditLineType == OpClientCreditLineType.UPDATE_CLIENT_CREDIT_LINE)
            {
                this.clientCreditLineBindingSource.DataSource = creditLine;
            }
        }

        #endregion Constructors

        #region Methods (30)

        // Private Methods (30) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        private void ClientDetail_Closing(object sender, FormClosingEventArgs e)
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

            if (client.ClientGroup != null)
            {
                if (client.ClientEDICode == null || client.ClientEDICode.Trim() == string.Empty)
                {
                    client.ClientGroup = null;
                }
                else
                {
                    if (App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == client.ClientEDICode) == null)
                    {
                        client.ClientGroup = null;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customValidator4_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            if (this.freezeDateDateTimePicker.Enabled)
            {
                if (e.ControlToValidate.Text == string.Empty)
                {
                    e.IsValid = false;
                }
                else
                {
                    e.IsValid = true;
                }
            }
            else
            {
                e.IsValid = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customValidator5_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            if (this.unfreezeDateDateTimePicker.Enabled)
            {
                if (e.ControlToValidate.Text == string.Empty)
                {
                    e.IsValid = false;
                }
                else
                {
                    e.IsValid = true;
                }
            }
            else
            {
                e.IsValid = true;
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
                MessageBox.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (MessageBox.Show("是否打算删除此额度信息", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                client.ClientCreditLines.Remove(creditLine);
                App.Current.DbContext.ClientCreditLines.DeleteOnSubmit(creditLine);
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBox.Show("数据删除成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvClientCreditLines.DataSource = client.ClientCreditLines.ToList();
                this.clientCreditLineBindingSource.DataSource = typeof(ClientCreditLine);
                this.SetClientCreditLineEditable(false);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteContract(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBox.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (MessageBox.Show("是否打算删除保理合同: " + contract.ContractCode, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                var CDAList = App.Current.DbContext.CDAs.Where(c => c.CDACode.StartsWith(contract.ContractCode));
                foreach (CDA cda in CDAList)
                {
                    foreach (InvoiceAssignBatch assignBatch in cda.InvoiceAssignBatches)
                    {
                        foreach (Invoice invoice in assignBatch.Invoices)
                        {
                            App.Current.DbContext.InvoicePaymentLogs.DeleteAllOnSubmit(invoice.InvoicePaymentLogs);
                            App.Current.DbContext.InvoiceRefundLogs.DeleteAllOnSubmit(invoice.InvoiceRefundLogs);
                        }

                        App.Current.DbContext.Invoices.DeleteAllOnSubmit(assignBatch.Invoices);
                    }

                    App.Current.DbContext.InvoiceAssignBatches.DeleteAllOnSubmit(cda.InvoiceAssignBatches);
                    App.Current.DbContext.InvoiceFinanceBatches.DeleteAllOnSubmit(cda.InvoiceFinanceBatches);
                    App.Current.DbContext.InvoicePaymentBatches.DeleteAllOnSubmit(cda.InvoicePaymentBatches);
                    App.Current.DbContext.InvoiceRefundBatches.DeleteAllOnSubmit(cda.InvoiceRefundBatches);
                }

                App.Current.DbContext.CDAs.DeleteAllOnSubmit(CDAList);
                App.Current.DbContext.Contracts.DeleteOnSubmit(contract);
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBox.Show("数据删除成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvContracts.DataSource = client.Contracts.ToList();
                this.contractBindingSource.DataSource = typeof(Contract);
                this.SetContractEditable(false);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void diContractValueDate_ValueChanged(object sender, EventArgs e)
        {
            if (this.opContractType == OpContractType.NEW_CONTRACT)
            {
                Contract contract = this.contractBindingSource.DataSource as Contract;
                contract.ContractValueDate = this.diContractValueDate.Value.Date;
                contract.ContractDueDate = this.diContractValueDate.Value.Date.AddYears(1);
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
                MessageBox.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (creditLine.CreditLineStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY)
            {
                this.freezeReasonTextBox.ReadOnly = false;
                this.freezeDateDateTimePicker.Enabled = true;
                creditLine.Freezer = App.Current.CurUser.Name;
                creditLine.FreezeDate = System.DateTime.Now.Date;
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
                MessageBox.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.clientCreditLineBindingSource.DataSource = typeof(ClientCreditLine);
            this.clientCreditLineBindingSource.DataSource = new ClientCreditLine();
            this.opClientCreditLineType = OpClientCreditLineType.NEW_CLIENT_CREDIT_LINE;
            this.UpdateClientCreditLineControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewContract(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBox.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.contractBindingSource.DataSource = typeof(Contract);
            this.contractBindingSource.DataSource = new Contract();
            this.opContractType = OpContractType.NEW_CONTRACT;
            this.UpdateContractControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void periodBeginDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (this.opClientCreditLineType == OpClientCreditLineType.NEW_CLIENT_CREDIT_LINE)
            {
                ClientCreditLine creditLine = this.clientCreditLineBindingSource.DataSource as ClientCreditLine;
                creditLine.PeriodBegin = this.periodBeginDateTimePicker.Value;
                creditLine.PeriodEnd = this.periodBeginDateTimePicker.Value.AddYears(1);
            }
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
                MessageBox.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.dgvContracts.DataSource = client.Contracts.ToList();
        }

        /// <summary>
        /// Reset Client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ResetClient(object sender, EventArgs e)
        {
            if (this.opClientType == OpClientType.UPDATE_CLIENT)
            {
                Client client = this.clientBindingSource.DataSource as Client;
                client.Restore();
            }
            else if (this.opClientType == OpClientType.NEW_CLIENT)
            {
                this.clientBindingSource.DataSource = new Client();
            }
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SaveClient(object sender, EventArgs e)
        {
            if (!this.clientValidator.Validate())
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            client.CreateUserName = App.Current.CurUser.Name;

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
                    MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!this.creditLineValidator.Validate())
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBox.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.clientCreditLineBindingSource.DataSource is ClientCreditLine))
            {
                return;
            }

            ClientCreditLine creditLine = (ClientCreditLine)this.clientCreditLineBindingSource.DataSource;

            DateTime today = DateTime.Now.Date;
            if (creditLine.PeriodEnd < today)
            {
                creditLine.CreditLineStatus = ConstStr.CLIENT_CREDIT_LINE.EXPIRY;
            }
            else
            {
                creditLine.CreditLineStatus = ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY;
            }

            if (this.freezeDateDateTimePicker.Enabled)
            {
                creditLine.CreditLineStatus = ConstStr.CLIENT_CREDIT_LINE.FREEZE;
            }

            if (this.unfreezeDateDateTimePicker.Enabled)
            {
                if (creditLine.PeriodEnd < today)
                {
                    creditLine.CreditLineStatus = ConstStr.CLIENT_CREDIT_LINE.EXPIRY;
                }
                else
                {
                    creditLine.CreditLineStatus = ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY;
                }
            }

            if (creditLine.CreditLineID == 0)
            {
                bool isAddOK = true;
                try
                {
                    creditLine.Client = client;
                    creditLine.CreateUserName = App.Current.CurUser.Name;

                    App.Current.DbContext.ClientCreditLines.InsertOnSubmit(creditLine);
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    creditLine.Client = null;
                    isAddOK = false;
                    MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (creditLine.CreditLineStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY)
                    {
                        foreach (ClientCreditLine ccl in client.ClientCreditLines)
                        {
                            if (ccl != creditLine && ccl.CreditLineStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY && ccl.CreditLineType == creditLine.CreditLineType)
                            {
                                ccl.CreditLineStatus = ConstStr.CLIENT_CREDIT_LINE.EXPIRY;
                            }
                        }

                        App.Current.DbContext.SubmitChanges();
                    }

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
                    MessageBox.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (creditLine.CreditLineStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY)
                    {
                        foreach (ClientCreditLine ccl in client.ClientCreditLines)
                        {
                            if (ccl != creditLine && ccl.CreditLineStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY && ccl.CreditLineType == creditLine.CreditLineType && ccl.CreditLineCurrency == creditLine.CreditLineCurrency)
                            {
                                ccl.CreditLineStatus = ConstStr.CLIENT_CREDIT_LINE.EXPIRY;
                            }
                        }

                        App.Current.DbContext.SubmitChanges();
                    }

                    this.dgvClientCreditLines.Refresh();
                    creditLine.Backup();
                }
            }
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SaveContract(object sender, EventArgs e)
        {
            if (!this.contractValidator.Validate())
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null)
            {
                MessageBox.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.contractBindingSource.DataSource is Contract))
            {
                return;
            }

            Contract contract = (Contract)this.contractBindingSource.DataSource;

            if (this.opContractType == OpContractType.NEW_CONTRACT)
            {
                bool isAddOK = true;
                try
                {
                    contract.Client = client;
                    contract.CreateUserName = App.Current.CurUser.Name;
                    DateTime today = DateTime.Now.Date;
                    if (contract.ContractDueDate < today)
                    {
                        contract.ContractStatus = ConstStr.CONTRACT.EXPIRY;
                    }
                    else
                    {
                        contract.ContractStatus = ConstStr.CONTRACT.AVAILABILITY;
                    }

                    App.Current.DbContext.Contracts.InsertOnSubmit(contract);
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    contract.Client = null;
                    isAddOK = false;
                    MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (contract.ContractStatus == ConstStr.CONTRACT.AVAILABILITY)
                    {
                        foreach (Contract c in client.Contracts)
                        {
                            if (c != contract && c.ContractStatus == ConstStr.CONTRACT.AVAILABILITY)
                            {
                                c.ContractStatus = ConstStr.CONTRACT.EXPIRY;
                            }
                        }

                        App.Current.DbContext.SubmitChanges();
                    }

                    this.dgvContracts.DataSource = client.Contracts.ToList();
                    this.NewContract(null, null);
                }
            }
            else
            {
                bool isUpdateOK = true;
                DateTime today = DateTime.Now.Date;
                if (contract.ContractDueDate < today)
                {
                    contract.ContractStatus = ConstStr.CONTRACT.EXPIRY;
                }
                else
                {
                    contract.ContractStatus = ConstStr.CONTRACT.AVAILABILITY;
                }

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
                    MessageBox.Show(ConstStr.MESSAGE.DATA_UPDATE_SUCCESS, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (contract.ContractStatus == ConstStr.CONTRACT.AVAILABILITY)
                    {
                        foreach (Contract c in client.Contracts)
                        {
                            if (c != contract && c.ContractStatus == ConstStr.CONTRACT.AVAILABILITY)
                            {
                                c.ContractStatus = ConstStr.CONTRACT.EXPIRY;
                            }
                        }

                        App.Current.DbContext.SubmitChanges();
                    }

                    this.dgvContracts.Refresh();
                    contract.Backup();
                }
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

            ClientCreditLine selectedClientCreditLine = ((List<ClientCreditLine>)this.dgvClientCreditLines.DataSource)[this.dgvClientCreditLines.SelectedRows[0].Index];
            this.SetClientCreditLineEditable(false);
            this.clientCreditLineBindingSource.DataSource = selectedClientCreditLine;
            this.btnClientCreditLineFreeze.Enabled = true;
            this.btnClientCreditLineUnfreeze.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectContract(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvContracts.SelectedRows.Count == 0)
            {
                return;
            }

            Contract selectedContract = ((List<Contract>)this.dgvContracts.DataSource)[this.dgvClientCreditLines.SelectedRows[0].Index];
            this.SetContractEditable(false);
            this.contractBindingSource.DataSource = selectedContract;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectGroup(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            ClientMgr clientMgr = new ClientMgr(false);
            QueryForm queryUI = new QueryForm(clientMgr, "选择集团");
            clientMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            if (clientMgr.Selected != null)
            {
                client.ClientGroup = clientMgr.Selected;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectGroupCreditLine(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            ClientCreditLineMgr mgr = new ClientCreditLineMgr(client.ClientGroup);
            QueryForm queryFrom = new QueryForm(mgr, "选择集团额度");
            mgr.OwnerForm = queryFrom;
            queryFrom.ShowDialog(this);
            ClientCreditLine selected = mgr.Selected;
            if (selected != null)
            {
                ClientCreditLine clientCreditLine = (ClientCreditLine)this.clientCreditLineBindingSource.DataSource;
                if (clientCreditLine.CreditLineType != selected.CreditLineType)
                {
                    MessageBox.Show("所选集团的额度类型与客户的额度类型不相同", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (clientCreditLine.CreditLine > selected.CreditLine)
                {
                    MessageBox.Show("所选集团的保理预付款融资额度必须大于客户的保理预付款融资额度", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                clientCreditLine.GroupCreditLine = selected;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="editable"></param>
        private void SetClientCreditLineEditable(bool editable)
        {
            foreach (Control comp in this.groupPanelClientCreditLine.Controls)
            {
                ControlUtil.SetComponetEditable(comp, editable);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="editable"></param>
        private void SetContractEditable(bool editable)
        {
            foreach (Control comp in this.groupPanelContract.Controls)
            {
                ControlUtil.SetComponetEditable(comp, editable);
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
                MessageBox.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                creditLine.UnfreezeDate = System.DateTime.Now.Date;
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
                MessageBox.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                this.btnGroupSelect.Visible = false;
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
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in this.groupPanelClientStat.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                this.btnGroupSelect.Visible = true;
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

                this.btnGroupSelect.Visible = true;
                this.clientEDICodeTextBox.ReadOnly = true;
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
                MessageBox.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                this.btnGroupCreditLineSelect.Visible = false;
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
                this.btnGroupCreditLineSelect.Visible = true;
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
                this.btnGroupCreditLineSelect.Visible = true;
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
            this.tbContractCreateUserName.ReadOnly = true;
        }

        #endregion Methods
    }
}

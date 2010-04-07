//-----------------------------------------------------------------------
// <copyright file="ClientDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    using System;
    using System.Collections.Generic;
    using System.Data.Linq;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar;

    /// <summary>
    /// Client Detail
    /// </summary>
    public partial class ClientDetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (10)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bsContracts;
        /// <summary>
        /// 
        /// </summary>
        private BindingSource bsCreditLines;
        /// <summary>
        /// 
        /// </summary>
        private BindingSource bsGDs;
        /// <summary>
        /// 
        /// </summary>
        private BindingSource bsReviews;
        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;
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
        /// <summary>
        /// 
        /// </summary>
        private OpGDType opGDType;
        /// <summary>
        /// 
        /// </summary>
        private OpReviewType opReviewType;

        #endregion Fields

        #region Enums (5)

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
        /// <summary>
        /// Review Type
        /// </summary>
        public enum OpReviewType
        {
            /// <summary>
            /// 
            /// </summary>
            NEW_REVIEW,

            /// <summary>
            /// 
            /// </summary>
            UPDATE_REVIEW,

            /// <summary>
            /// 
            /// </summary>
            DETAIL_REVIEW
        }
        /// <summary>
        /// Guarantee Deposite Type
        /// </summary>
        public enum OpGDType
        {
            /// <summary>
            /// 
            /// </summary>
            NEW_GD,
            /// <summary>
            /// 
            /// </summary>
            UPDATE_GD,
            /// <summary>
            /// 
            /// </summary>
            DETAIL_GD
        }

        #endregion Enums

        #region Constructors (7)

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="client">selected client</param>
        /// <param name="opClientType">client operation type</param>
        /// <param name="opClientCreditLineType">client credit line operation type</param>
        /// <param name="opContractType">client contract opertion type</param>
        /// <param name="opReviewType">client review operation type</param>
        private ClientDetail(Client client, OpClientType opClientType, OpClientCreditLineType opClientCreditLineType, OpContractType opContractType, OpReviewType opReviewType)
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.bsCreditLines = new BindingSource();
            this.bsContracts = new BindingSource();
            this.bsReviews = new BindingSource();
            this.bsGDs = new BindingSource();
            this.dgvClientCreditLines.AutoGenerateColumns = false;
            this.dgvContracts.AutoGenerateColumns = false;
            this.dgvReviews.AutoGenerateColumns = false;
            this.dgvClientCreditLines.DataSource = this.bsCreditLines;
            this.dgvContracts.DataSource = this.bsContracts;
            this.dgvReviews.DataSource = this.bsReviews;
            this.dgvGDs.DataSource = this.bsGDs;
            this.context = new DBDataContext();

            this.cbCountryCode.DataSource = Country.AllCountries();
            this.cbCountryCode.DisplayMember = "CountryFormatCN";
            this.cbCountryCode.ValueMember = "CountryCode";

            List<Department> allDepartments = Department.AllDepartments(context);
            this.cbDepartments.DataSource = allDepartments;
            this.cbDepartments.DisplayMembers = "DepartmentName";
            this.cbDepartments.GroupingMembers = "Domain";
            this.cbDepartments.ValueMember = "DepartmentCode";
            this.cbDepartments.SelectedIndex = -1;

            this.creditLineCurrencyComboBox.DataSource = Currency.AllCurrencies();
            this.creditLineCurrencyComboBox.DisplayMember = "CurrencyFormat";
            this.creditLineCurrencyComboBox.ValueMember = "CurrencyCode";
            this.creditLineCurrencyComboBox.SelectedIndex = -1;

            this.requestCurrencyComboBox.DataSource = Currency.AllCurrencies();
            this.requestCurrencyComboBox.DisplayMember = "CurrencyCode";
            this.requestCurrencyComboBox.ValueMember = "CurrencyCode";
            this.requestCurrencyComboBox.SelectedIndex = -1;

            this.cbGDCurr.DataSource = Currency.AllCurrencies();
            this.cbGDCurr.DisplayMember = "CurrencyCode";
            this.cbGDCurr.ValueMember = "CurrencyCode";
            this.cbGDCurr.SelectedIndex = -1;

            this.opClientType = opClientType;
            this.opClientCreditLineType = opClientCreditLineType;
            this.opContractType = opContractType;
            this.opReviewType = opReviewType;
            this.opGDType = OpGDType.DETAIL_GD;

            if (opClientType == OpClientType.NEW_CLIENT)
            {
                client = new Client();
                this.clientBindingSource.DataSource = client;
            }
            else
            {
                client = context.Clients.SingleOrDefault(c => c.ClientEDICode == client.ClientEDICode);
            }

            this.clientBindingSource.DataSource = client;
            this.bsCreditLines.DataSource = client.ClientCreditLines;
            this.bsContracts.DataSource = client.Contracts;
            this.bsReviews.DataSource = client.ClientReviews;
            this.bsGDs.DataSource = client.GuaranteeDeposits;

            List<Department> deptsList = (List<Department>)this.cbDepartments.DataSource;
            this.cbDepartments.SelectedIndex = deptsList.IndexOf(client.Department);
            if (client.ClientGroup != null)
            {
                this.tbGroupNameCN.Text = client.ClientGroup.ClientNameCN;
                this.tbGroupNameEN.Text = client.ClientGroup.ClientNameEN;
                this.btnGroupCreditLineSelect.Enabled = true;
            }

            if (this.opClientCreditLineType == OpClientCreditLineType.NEW_CLIENT_CREDIT_LINE)
            {
                this.clientCreditLineBindingSource.DataSource = new ClientCreditLine();
                this.tabControl.SelectedTab = this.tabItemClientCreditLine;
            }

            if (this.opContractType == OpContractType.NEW_CONTRACT)
            {
                this.contractBindingSource.DataSource = new Contract();
                this.tabControl.SelectedTab = this.tabItemContract;
            }

            if (this.opReviewType == OpReviewType.NEW_REVIEW)
            {
                this.reviewBindingSource.DataSource = new ClientReview();
                this.tabControl.SelectedTab = this.tabItemReview;
            }

            this.UpdateClientControlStatus();
            this.UpdateClientCreditLineControlStatus();
            this.UpdateContractControlStatus();
            this.UpdateReviewControlStatus();
            this.UpdateGDControlStatus();

            this.requestCommissionRateTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.requestCommissionRateTextBox.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="client"></param>
        /// <param name="opClientType"></param>
        public ClientDetail(Client client, OpClientType opClientType)
            : this(client, opClientType, OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE, OpContractType.DETAIL_CONTRACT, OpReviewType.DETAIL_REVIEW)
        {
            this.tabControl.SelectedTab = this.tabItemClient;
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="client"></param>
        /// <param name="opContractType"></param>
        public ClientDetail(Client client, OpContractType opContractType)
            : this(client, OpClientType.DETAIL_CLIENT, OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE, opContractType, OpReviewType.DETAIL_REVIEW)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="client"></param>
        /// <param name="opClientCreditLineType"></param>
        public ClientDetail(Client client, OpClientCreditLineType opClientCreditLineType)
            : this(client, OpClientType.DETAIL_CLIENT, opClientCreditLineType, OpContractType.DETAIL_CONTRACT, OpReviewType.DETAIL_REVIEW)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="opContractType"></param>
        public ClientDetail(Contract contract, OpContractType opContractType)
            : this(contract.Client, OpClientType.DETAIL_CLIENT, OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE, opContractType, OpReviewType.DETAIL_REVIEW)
        {
            this.tabControl.SelectedTab = this.tabItemContract;
            if (this.opContractType == OpContractType.DETAIL_CONTRACT || this.opContractType == OpContractType.UPDATE_CONTRACT)
            {
                contract = context.Contracts.SingleOrDefault(c => c.ContractCode == contract.ContractCode);
                this.contractBindingSource.DataSource = contract;
            }
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="creditLine"></param>
        /// <param name="opClientCreditLineType"></param>
        public ClientDetail(ClientCreditLine creditLine, OpClientCreditLineType opClientCreditLineType)
            : this(creditLine.Client, OpClientType.DETAIL_CLIENT, opClientCreditLineType, OpContractType.DETAIL_CONTRACT, OpReviewType.DETAIL_REVIEW)
        {
            this.tabControl.SelectedTab = this.tabItemClientCreditLine;
            if (this.opClientCreditLineType == OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE || this.opClientCreditLineType == OpClientCreditLineType.UPDATE_CLIENT_CREDIT_LINE)
            {
                creditLine = context.ClientCreditLines.SingleOrDefault(c => c.CreditLineID == creditLine.CreditLineID);
                this.clientCreditLineBindingSource.DataSource = creditLine;
            }
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="review"></param>
        /// <param name="opReviewType"></param>
        public ClientDetail(ClientReview review, OpReviewType opReviewType)
            : this(review.Client, OpClientType.DETAIL_CLIENT, OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE, OpContractType.DETAIL_CONTRACT, opReviewType)
        {
            this.tabControl.SelectedTab = this.tabItemReview;
            if (this.opReviewType == OpReviewType.DETAIL_REVIEW || this.opReviewType == OpReviewType.UPDATE_REVIEW)
            {
                review = context.ClientReviews.SingleOrDefault(r => r.ReviewNo == review.ReviewNo);
                this.reviewBindingSource.DataSource = review;
                if (review.RequestFinanceType != null)
                {
                    List<string> financeList = new List<string>();
                    financeList.AddRange(review.RequestFinanceType.Split(';'));
                    for (int i = 0; i < this.requestFinanceTypeCheckedListBox.Items.Count; i++)
                    {
                        string item = this.requestFinanceTypeCheckedListBox.Items[i] as string;
                        if (financeList.Contains(item))
                        {
                            this.requestFinanceTypeCheckedListBox.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        #endregion Constructors

        #region Methods (45)

        // Private Methods (45) 

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
        private void customValidator1_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            ClientCreditLine creditLine = (ClientCreditLine)this.clientCreditLineBindingSource.DataSource;
            if (!TypeUtil.GreaterZero(creditLine.CreditLine))
            {
                e.IsValid = false;
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
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (MessageBoxEx.Show("是否打算删除此额度信息", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                context.ClientCreditLines.DeleteOnSubmit(creditLine);
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clientCreditLineBindingSource.DataSource = typeof(ClientCreditLine);
                this.SetClientCreditLineEditable(false);
                this.bsCreditLines.DataSource = typeof(ClientCreditLine);
                this.bsCreditLines.DataSource = client.ClientCreditLines;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteContract(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (MessageBoxEx.Show("是否打算删除保理合同: " + contract.ContractCode, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                context.Contracts.DeleteOnSubmit(contract);
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.contractBindingSource.DataSource = typeof(Contract);
                this.SetContractEditable(false);
                this.bsContracts.DataSource = typeof(Contract);
                this.bsContracts.DataSource = client.Contracts;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteGD(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.gdBindingSource.DataSource is GuaranteeDeposit))
            {
                return;
            }

            GuaranteeDeposit gd = (GuaranteeDeposit)this.gdBindingSource.DataSource;
            if (gd.GuaranteeDepositID == 0)
            {
                return;
            }

            if (MessageBoxEx.Show("是否打算删除保证金: " + gd.GuaranteeDepositAmount, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                context.GuaranteeDeposits.DeleteOnSubmit(gd);
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gdBindingSource.DataSource = typeof(GuaranteeDeposit);
                this.SetGDEditable(false);
                this.bsGDs.DataSource = typeof(GuaranteeDeposit);
                this.bsGDs.DataSource = client.GuaranteeDeposits;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteReview(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.reviewBindingSource.DataSource is ClientReview))
            {
                return;
            }

            ClientReview review = (ClientReview)this.reviewBindingSource.DataSource;
            if (review.ReviewNo == null)
            {
                return;
            }

            if (MessageBoxEx.Show("是否打算删除此协查意见信息", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                context.ClientReviews.DeleteOnSubmit(review);
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.reviewBindingSource.DataSource = typeof(ClientReview);
                this.SetReviewEditable(false);
                this.bsReviews.DataSource = typeof(ClientReview);
                this.bsReviews.DataSource = client.ClientReviews;
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
                contract.ContractDueDate = this.diContractValueDate.Value.Date.AddYears(2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FreezeClientCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void NewGD(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.gdBindingSource.DataSource = typeof(GuaranteeDeposit);
            this.gdBindingSource.DataSource = new GuaranteeDeposit();
            this.opGDType = OpGDType.NEW_GD;
            this.UpdateGDControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewReview(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.reviewBindingSource.DataSource = typeof(ClientReview);
            this.reviewBindingSource.DataSource = new ClientReview();
            this.opReviewType = OpReviewType.NEW_REVIEW;
            this.UpdateReviewControlStatus();
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
                creditLine.PeriodBegin = this.periodBeginDateTimePicker.Value.Date;
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
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.bsCreditLines.DataSource = typeof(ClientCreditLine);
            this.bsCreditLines.DataSource = client.ClientCreditLines;
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
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.bsContracts.DataSource = typeof(Contract);
            this.bsContracts.DataSource = client.Contracts;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshGDs(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.bsGDs.DataSource = typeof(GuaranteeDeposit);
            this.bsGDs.DataSource = client.GuaranteeDeposits;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshReviews(object sender, EventArgs e)
        {
            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.bsReviews.DataSource = typeof(ClientReview);
            this.bsReviews.DataSource = client.ClientReviews;
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SaveClient(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

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
                    context.Clients.InsertOnSubmit(client);
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    context.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    foreach (ObjectChangeConflict cc in context.ChangeConflicts)
                    {
                        foreach (MemberChangeConflict mc in cc.MemberConflicts)
                        {
                            mc.Resolve(RefreshMode.KeepChanges);
                        }
                    }

                    context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            if (!this.creditLineValidator.Validate())
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.clientCreditLineBindingSource.DataSource is ClientCreditLine))
            {
                return;
            }

            ClientCreditLine creditLine = (ClientCreditLine)this.clientCreditLineBindingSource.DataSource;
            creditLine.CreateUserName = App.Current.CurUser.Name;

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

                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    creditLine.Client = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (creditLine.CreditLineStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY)
                    {
                        foreach (ClientCreditLine ccl in client.ClientCreditLines)
                        {
                            if (ccl != creditLine && ccl.CreditLineStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY && ccl.CreditLineType == creditLine.CreditLineType)
                            {
                                ccl.CreditLineStatus = ConstStr.CLIENT_CREDIT_LINE.EXPIRY;
                            }
                        }

                        try
                        {
                            context.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    this.bsCreditLines.DataSource = typeof(ClientCreditLine);
                    this.bsCreditLines.DataSource = client.ClientCreditLines;
                    this.NewClientCreditLine(null, null);
                }
            }
            else
            {
                bool isUpdateOK = true;

                try
                {
                    context.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    foreach (ObjectChangeConflict cc in context.ChangeConflicts)
                    {
                        foreach (MemberChangeConflict mc in cc.MemberConflicts)
                        {
                            mc.Resolve(RefreshMode.KeepChanges);
                        }
                    }

                    context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (creditLine.CreditLineStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY)
                    {
                        foreach (ClientCreditLine ccl in client.ClientCreditLines)
                        {
                            if (ccl != creditLine && ccl.CreditLineStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY && ccl.CreditLineType == creditLine.CreditLineType && ccl.CreditLineCurrency == creditLine.CreditLineCurrency)
                            {
                                ccl.CreditLineStatus = ConstStr.CLIENT_CREDIT_LINE.EXPIRY;
                            }
                        }

                        try
                        {
                            context.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
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
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            if (!this.contractValidator.Validate())
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.contractBindingSource.DataSource is Contract))
            {
                return;
            }

            Contract contract = (Contract)this.contractBindingSource.DataSource;
            contract.CreateUserName = App.Current.CurUser.Name;

            if (this.opContractType == OpContractType.NEW_CONTRACT)
            {
                bool isAddOK = true;

                Contract oldContract = this.context.Contracts.SingleOrDefault(c => c.ContractCode == contract.ContractCode);
                if (oldContract != null)
                {
                    MessageBoxEx.Show("该合同编号已存在，请重新编码", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    contract.Client = client;

                    DateTime today = DateTime.Now.Date;
                    if (contract.ContractDueDate < today)
                    {
                        contract.ContractStatus = ConstStr.CONTRACT.EXPIRY;
                    }
                    else
                    {
                        contract.ContractStatus = ConstStr.CONTRACT.AVAILABILITY;
                    }

                    context.Contracts.InsertOnSubmit(contract);
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    contract.Client = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (contract.ContractStatus == ConstStr.CONTRACT.AVAILABILITY)
                    {
                        foreach (Contract c in client.Contracts)
                        {
                            if (c != contract && c.ContractStatus == ConstStr.CONTRACT.AVAILABILITY)
                            {
                                c.ContractStatus = ConstStr.CONTRACT.EXPIRY;
                            }
                        }

                        try
                        {
                            context.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    this.bsContracts.DataSource = typeof(Contract);
                    this.bsContracts.DataSource = client.Contracts;
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
                    context.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    foreach (ObjectChangeConflict cc in context.ChangeConflicts)
                    {
                        foreach (MemberChangeConflict mc in cc.MemberConflicts)
                        {
                            mc.Resolve(RefreshMode.KeepChanges);
                        }
                    }

                    context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show(ConstStr.MESSAGE.DATA_UPDATE_SUCCESS, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (contract.ContractStatus == ConstStr.CONTRACT.AVAILABILITY)
                    {
                        foreach (Contract c in client.Contracts)
                        {
                            if (c != contract && c.ContractStatus == ConstStr.CONTRACT.AVAILABILITY)
                            {
                                c.ContractStatus = ConstStr.CONTRACT.EXPIRY;
                            }
                        }

                        try
                        {
                            context.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void SaveGD(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.gdBindingSource.DataSource is GuaranteeDeposit))
            {
                return;
            }

            GuaranteeDeposit gd = (GuaranteeDeposit)this.gdBindingSource.DataSource;
            gd.CreateUserName = App.Current.CurUser.Name;

            if (this.opGDType == OpGDType.NEW_GD)
            {
                bool isAddOK = true;
                try
                {
                    client.GuaranteeDeposits.Add(gd);

                    context.GuaranteeDeposits.InsertOnSubmit(gd);
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    gd.Client = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.bsGDs.DataSource = typeof(GuaranteeDeposit);
                    this.bsGDs.DataSource = client.GuaranteeDeposits;
                    this.NewGD(null, null);
                }
            }
            else
            {
                bool isUpdateOK = true;
                try
                {
                    context.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    foreach (ObjectChangeConflict cc in context.ChangeConflicts)
                    {
                        foreach (MemberChangeConflict mc in cc.MemberConflicts)
                        {
                            mc.Resolve(RefreshMode.KeepChanges);
                        }
                    }

                    context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show(ConstStr.MESSAGE.DATA_UPDATE_SUCCESS, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveReview(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            if (!this.reviewValidator.Validate())
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.reviewBindingSource.DataSource is ClientReview))
            {
                return;
            }

            ClientReview review = (ClientReview)this.reviewBindingSource.DataSource;
            review.CreateUserName = App.Current.CurUser.Name;

            string financeType = string.Empty;
            foreach (string item in this.requestFinanceTypeCheckedListBox.CheckedItems)
            {
                financeType += (item + ";");
            }

            review.RequestFinanceType = financeType;

            if (this.opReviewType == OpReviewType.NEW_REVIEW)
            {
                bool isAddOK = true;
                try
                {
                    client.ClientReviews.Add(review);

                    context.ClientReviews.InsertOnSubmit(review);
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    review.Client = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.bsReviews.DataSource = typeof(ClientReview);
                    this.bsReviews.DataSource = client.ClientReviews;
                    this.NewReview(null, null);
                }
            }
            else
            {
                bool isUpdateOK = true;
                try
                {
                    context.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    foreach (ObjectChangeConflict cc in context.ChangeConflicts)
                    {
                        foreach (MemberChangeConflict mc in cc.MemberConflicts)
                        {
                            mc.Resolve(RefreshMode.KeepChanges);
                        }
                    }

                    context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show(ConstStr.MESSAGE.DATA_UPDATE_SUCCESS, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            ClientCreditLine selectedClientCreditLine = (ClientCreditLine)this.bsCreditLines.List[this.dgvClientCreditLines.SelectedRows[0].Index];
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

            Contract selectedContract = (Contract)this.bsContracts.List[this.dgvContracts.SelectedRows[0].Index];
            this.SetContractEditable(false);
            this.contractBindingSource.DataSource = selectedContract;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectGD(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvGDs.SelectedRows.Count == 0)
            {
                return;
            }

            GuaranteeDeposit selectedGD = (GuaranteeDeposit)this.bsGDs.List[this.dgvGDs.SelectedRows[0].Index];
            this.SetGDEditable(false);
            this.gdBindingSource.DataSource = selectedGD;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectGroup(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            ClientMgr clientMgr = new ClientMgr();
            QueryForm queryUI = new QueryForm(clientMgr, "选择集团");
            clientMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            if (clientMgr.Selected != null)
            {
                client.ClientGroup = context.Clients.SingleOrDefault(c => c.ClientEDICode == clientMgr.Selected.ClientEDICode);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectGroupCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client.ClientGroup == null)
            {
                return;
            }

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
                    MessageBoxEx.Show("所选集团的额度类型与客户的额度类型不相同", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (clientCreditLine.CreditLine > selected.CreditLine)
                {
                    MessageBoxEx.Show("所选集团的保理预付款融资额度必须大于客户的保理预付款融资额度", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                clientCreditLine.GroupCreditLine = selected;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectReview(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvReviews.SelectedRows.Count == 0)
            {
                return;
            }

            ClientReview selectedReview = (ClientReview)this.bsReviews.List[this.dgvReviews.SelectedRows[0].Index];
            this.SetReviewEditable(false);
            this.reviewBindingSource.DataSource = selectedReview;
            if (selectedReview.RequestFinanceType != null)
            {
                List<string> financeList = new List<string>();
                financeList.AddRange(selectedReview.RequestFinanceType.Split(';'));
                for (int i = 0; i < this.requestFinanceTypeCheckedListBox.Items.Count; i++)
                {
                    string item = this.requestFinanceTypeCheckedListBox.Items[i] as string;
                    if (financeList.Contains(item))
                    {
                        this.requestFinanceTypeCheckedListBox.SetItemChecked(i, true);
                    }
                }
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
        /// <param name="editable"></param>
        private void SetGDEditable(bool editable)
        {
            foreach (Control comp in this.groupPanelGuaranteePanel.Controls)
            {
                ControlUtil.SetComponetEditable(comp, editable);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="editable"></param>
        private void SetReviewEditable(bool editable)
        {
            foreach (Control comp in this.groupPanelReview.Controls)
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
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            ControlUtil.SetComponetEditable(this.tbCreateUserName, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateClientCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Client client = (Client)this.clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            this.tbGroupCreditLine.ReadOnly = true;
            this.tbGroupCreditLineCurr.ReadOnly = true;
            ControlUtil.SetComponetEditable(this.tbCreditLineCreateUserName, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateContract(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

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
                    ControlUtil.SetComponetDefault(comp);
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

            //ControlUtil.SetComponetEditable(this.tbContractStatus, false);
            ControlUtil.SetComponetEditable(this.tbContractCreateUserName, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateGD(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            this.opGDType = OpGDType.UPDATE_GD;
            this.UpdateGDControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateGDControlStatus()
        {
            if (this.opGDType == OpGDType.DETAIL_GD)
            {
                foreach (Control comp in this.groupPanelGuaranteePanel.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (this.opGDType == OpGDType.NEW_GD)
            {
                foreach (Control comp in this.groupPanelGuaranteePanel.Controls)
                {
                    ControlUtil.SetComponetDefault(comp);
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (this.opGDType == OpGDType.UPDATE_GD)
            {
                foreach (Control comp in this.groupPanelGuaranteePanel.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }

            ControlUtil.SetComponetEditable(this.tbGDCreateUserName, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateReivew(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            this.opReviewType = OpReviewType.UPDATE_REVIEW;
            this.UpdateReviewControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateReviewControlStatus()
        {
            if (this.opReviewType == OpReviewType.DETAIL_REVIEW)
            {
                foreach (Control comp in this.groupPanelReview.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (this.opReviewType == OpReviewType.NEW_REVIEW)
            {
                foreach (Control comp in this.groupPanelReview.Controls)
                {
                    ControlUtil.SetComponetDefault(comp);
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (this.opReviewType == OpReviewType.UPDATE_REVIEW)
            {
                foreach (Control comp in this.groupPanelReview.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                this.reviewNoTextBox.ReadOnly = true;
            }

            ControlUtil.SetComponetEditable(this.tbReviewCreateUserName, false);
        }

        #endregion Methods
    }
}

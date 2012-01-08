//-----------------------------------------------------------------------
// <copyright file="ClientDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Validator;

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    /// <summary>
    /// Client Detail
    /// </summary>
    public partial class ClientDetail : Office2007Form
    {

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bsContracts;
        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bsCreditLines;
        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bsGDs;
        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bsReviews;
        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;
        /// <summary>
        /// 
        /// </summary>
        private OpClientCreditLineType _opClientCreditLineType;
        /// <summary>
        /// 
        /// </summary>
        private OpClientType _opClientType;
        /// <summary>
        /// 
        /// </summary>
        private OpContractType _opContractType;
        /// <summary>
        /// 
        /// </summary>
        private OpGDType _opGdType;
        /// <summary>
        /// 
        /// </summary>
        private OpReviewType _opReviewType;



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
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="client">selected client</param>
        /// <param name="opClientType">client operation type</param>
        /// <param name="opClientCreditLineType">client credit line operation type</param>
        /// <param name="opContractType">client contract opertion type</param>
        /// <param name="opReviewType">client review operation type</param>
        private ClientDetail(Client client, OpClientType opClientType, OpClientCreditLineType opClientCreditLineType,
                             OpContractType opContractType, OpReviewType opReviewType)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _bsCreditLines = new BindingSource();
            _bsContracts = new BindingSource();
            _bsReviews = new BindingSource();
            _bsGDs = new BindingSource();
            dgvClientCreditLines.AutoGenerateColumns = false;
            dgvContracts.AutoGenerateColumns = false;
            dgvReviews.AutoGenerateColumns = false;
            dgvGDs.AutoGenerateColumns = false;
            dgvClientCreditLines.DataSource = _bsCreditLines;
            dgvContracts.DataSource = _bsContracts;
            dgvReviews.DataSource = _bsReviews;
            dgvGDs.DataSource = _bsGDs;
            _context = new DBDataContext();

            cbCountryCode.DataSource = Country.AllCountries();
            cbCountryCode.DisplayMember = "CountryFormatCN";
            cbCountryCode.ValueMember = "CountryCode";

            List<Department> allDepartments = Department.GetAllDepartments(_context);
            cbDepartments.DataSource = allDepartments;
            cbDepartments.DisplayMembers = "DepartmentName";
            cbDepartments.GroupingMembers = "Domain";
            cbDepartments.ValueMember = "DepartmentCode";
            cbDepartments.SelectedIndex = -1;

            creditLineCurrencyComboBox.DataSource = Currency.AllCurrencies;
            creditLineCurrencyComboBox.DisplayMember = "CurrencyFormat";
            creditLineCurrencyComboBox.ValueMember = "CurrencyCode";
            creditLineCurrencyComboBox.SelectedIndex = -1;

            requestCurrencyComboBox.DataSource = Currency.AllCurrencies;
            requestCurrencyComboBox.DisplayMember = "CurrencyCode";
            requestCurrencyComboBox.ValueMember = "CurrencyCode";
            requestCurrencyComboBox.SelectedIndex = -1;

            cbGDCurr.DataSource = Currency.AllCurrencies;
            cbGDCurr.DisplayMember = "CurrencyCode";
            cbGDCurr.ValueMember = "CurrencyCode";
            cbGDCurr.SelectedIndex = -1;

            _opClientType = opClientType;
            _opClientCreditLineType = opClientCreditLineType;
            _opContractType = opContractType;
            _opReviewType = opReviewType;
            _opGdType = OpGDType.DETAIL_GD;

            if (opClientType == OpClientType.NEW_CLIENT)
            {
                client = new Client();
                clientBindingSource.DataSource = client;
                client.CountryCode = "CN";
            }
            else
            {
                if (client != null)
                {
                    client = _context.Clients.SingleOrDefault(c => c.ClientEDICode == client.ClientEDICode);
                }
            }

            clientBindingSource.DataSource = client;
            _bsCreditLines.DataSource = client.ClientCreditLines;
            _bsContracts.DataSource = client.Contracts;
            _bsReviews.DataSource = client.ClientReviews;
            _bsGDs.DataSource = client.GuaranteeDeposits;

            var deptsList = (List<Department>)cbDepartments.DataSource;
            cbDepartments.SelectedIndex = deptsList.IndexOf(client.Department);
            if (client.ClientGroup != null)
            {
                tbGroupNameCN.Text = client.ClientGroup.ClientNameCN;
                tbGroupNameEN.Text = client.ClientGroup.ClientNameEN;
                btnGroupCreditLineSelect.Enabled = true;
            }

            if (_opClientCreditLineType == OpClientCreditLineType.NEW_CLIENT_CREDIT_LINE)
            {
                clientCreditLineBindingSource.DataSource = new ClientCreditLine();
                tabControl.SelectedTab = tabItemClientCreditLine;
            }

            if (_opContractType == OpContractType.NEW_CONTRACT)
            {
                contractBindingSource.DataSource = new Contract();
                tabControl.SelectedTab = tabItemContract;
            }

            if (_opReviewType == OpReviewType.NEW_REVIEW)
            {
                reviewBindingSource.DataSource = new ClientReview();
                tabControl.SelectedTab = tabItemReview;
            }

            UpdateClientControlStatus();
            UpdateClientCreditLineControlStatus();
            UpdateContractControlStatus();
            UpdateReviewControlStatus();
            UpdateGDControlStatus();

            requestCommissionRateTextBox.DataBindings[0].Format +=
                TypeUtil.FormatFloatToPercent;
            requestCommissionRateTextBox.DataBindings[0].Parse +=
                TypeUtil.ParsePercentToFloat;
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="client"></param>
        /// <param name="opClientType"></param>
        public ClientDetail(Client client, OpClientType opClientType)
            : this(
                client, opClientType, OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE, OpContractType.DETAIL_CONTRACT,
                OpReviewType.DETAIL_REVIEW)
        {
            tabControl.SelectedTab = tabItemClient;
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="client"></param>
        /// <param name="opContractType"></param>
        public ClientDetail(Client client, OpContractType opContractType)
            : this(
                client, OpClientType.DETAIL_CLIENT, OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE, opContractType,
                OpReviewType.DETAIL_REVIEW)
        {
            tabControl.SelectedTab = tabItemContract;
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="client"></param>
        /// <param name="opClientCreditLineType"></param>
        public ClientDetail(Client client, OpClientCreditLineType opClientCreditLineType)
            : this(
                client, OpClientType.DETAIL_CLIENT, opClientCreditLineType, OpContractType.DETAIL_CONTRACT,
                OpReviewType.DETAIL_REVIEW)
        {
            tabControl.SelectedTab = tabItemClientCreditLine;
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="opContractType"></param>
        public ClientDetail(Contract contract, OpContractType opContractType)
            : this(
                contract.Client, OpClientType.DETAIL_CLIENT, OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE,
                opContractType, OpReviewType.DETAIL_REVIEW)
        {
            tabControl.SelectedTab = tabItemContract;
            if (_opContractType == OpContractType.DETAIL_CONTRACT ||
                _opContractType == OpContractType.UPDATE_CONTRACT)
            {
                contract = _context.Contracts.SingleOrDefault(c => c.ContractCode == contract.ContractCode);
                contractBindingSource.DataSource = contract;
            }
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="creditLine"></param>
        /// <param name="opClientCreditLineType"></param>
        public ClientDetail(ClientCreditLine creditLine, OpClientCreditLineType opClientCreditLineType)
            : this(
                creditLine.Client, OpClientType.DETAIL_CLIENT, opClientCreditLineType, OpContractType.DETAIL_CONTRACT,
                OpReviewType.DETAIL_REVIEW)
        {
            tabControl.SelectedTab = tabItemClientCreditLine;
            if (_opClientCreditLineType == OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE ||
                _opClientCreditLineType == OpClientCreditLineType.UPDATE_CLIENT_CREDIT_LINE)
            {
                creditLine = _context.ClientCreditLines.SingleOrDefault(c => c.CreditLineID == creditLine.CreditLineID);
                clientCreditLineBindingSource.DataSource = creditLine;
            }
        }

        /// <summary>
        /// Initializes a new instance of the ClientDetail class
        /// </summary>
        /// <param name="review"></param>
        /// <param name="opReviewType"></param>
        public ClientDetail(ClientReview review, OpReviewType opReviewType)
            : this(
                review.Client, OpClientType.DETAIL_CLIENT, OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE,
                OpContractType.DETAIL_CONTRACT, opReviewType)
        {
            tabControl.SelectedTab = tabItemReview;
            if (_opReviewType != OpReviewType.DETAIL_REVIEW && _opReviewType != OpReviewType.UPDATE_REVIEW)
                return;
            review = _context.ClientReviews.SingleOrDefault(r => r.ReviewNo == review.ReviewNo);
            reviewBindingSource.DataSource = review;
            if (review.RequestFinanceType != null)
            {
                var financeList = new List<string>();
                financeList.AddRange(review.RequestFinanceType.Split(';'));
                for (int i = 0; i < requestFinanceTypeCheckedListBox.Items.Count; i++)
                {
                    var item = requestFinanceTypeCheckedListBox.Items[i] as string;
                    if (financeList.Contains(item))
                    {
                        requestFinanceTypeCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
        }




        //?Private?Methods?(45)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbDepartmentsSelectionChanged(object sender, AdvTreeNodeEventArgs e)
        {
            if (clientBindingSource.DataSource is Client)
            {
                var client = (Client)clientBindingSource.DataSource;
                if (cbDepartments.SelectedNode != null)
                {
                    client.Department = (Department)cbDepartments.SelectedNode.DataKey;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator1ValidateValue(object sender,
                                                   ValidateValueEventArgs e)
        {
            var creditLine = (ClientCreditLine)clientCreditLineBindingSource.DataSource;
            e.IsValid = creditLine.CreditLine>0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator4ValidateValue(object sender,
                                                   ValidateValueEventArgs e)
        {
            if (freezeDateDateTimePicker.Enabled)
            {
                e.IsValid = !String.IsNullOrEmpty(e.ControlToValidate.Text);
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
        private void CustomValidator5ValidateValue(object sender,
                                                   ValidateValueEventArgs e)
        {
            if (unfreezeDateDateTimePicker.Enabled)
            {
                e.IsValid = !String.IsNullOrEmpty(e.ControlToValidate.Text);
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
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(clientCreditLineBindingSource.DataSource is ClientCreditLine))
            {
                return;
            }

            var creditLine = (ClientCreditLine)clientCreditLineBindingSource.DataSource;
            if (creditLine.CreditLineID == 0)
            {
                return;
            }

            if (
                MessageBoxEx.Show("是否打算删除此额度信息", MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                _context.ClientCreditLines.DeleteOnSubmit(creditLine);
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                clientCreditLineBindingSource.DataSource = typeof(ClientCreditLine);
                SetClientCreditLineEditable(false);
                _bsCreditLines.DataSource = typeof(ClientCreditLine);
                _bsCreditLines.DataSource = client.ClientCreditLines;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteContract(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(contractBindingSource.DataSource is Contract))
            {
                return;
            }

            var contract = (Contract)contractBindingSource.DataSource;
            if (contract.ContractCode == null)
            {
                return;
            }

            if (
                MessageBoxEx.Show("是否打算删除保理合同: " + contract.ContractCode, MESSAGE.TITLE_WARNING,
                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                _context.Contracts.DeleteOnSubmit(contract);
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                contractBindingSource.DataSource = typeof(Contract);
                SetContractEditable(false);
                _bsContracts.DataSource = typeof(Contract);
                _bsContracts.DataSource = client.Contracts;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteGD(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(gdBindingSource.DataSource is GuaranteeDeposit))
            {
                return;
            }

            var gd = (GuaranteeDeposit)gdBindingSource.DataSource;
            if (gd.GuaranteeDepositID == 0)
            {
                return;
            }

            if (
                MessageBoxEx.Show("是否打算删除保证金: " + gd.GuaranteeDepositAmount, MESSAGE.TITLE_WARNING,
                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                _context.GuaranteeDeposits.DeleteOnSubmit(gd);
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                gdBindingSource.DataSource = typeof(GuaranteeDeposit);
                SetGDEditable(false);
                _bsGDs.DataSource = typeof(GuaranteeDeposit);
                _bsGDs.DataSource = client.GuaranteeDeposits;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteReview(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(reviewBindingSource.DataSource is ClientReview))
            {
                return;
            }

            var review = (ClientReview)reviewBindingSource.DataSource;
            if (review.ReviewNo == null)
            {
                return;
            }

            if (
                MessageBoxEx.Show("是否打算删除此协查意见信息", MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                _context.ClientReviews.DeleteOnSubmit(review);
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                reviewBindingSource.DataSource = typeof(ClientReview);
                SetReviewEditable(false);
                _bsReviews.DataSource = typeof(ClientReview);
                _bsReviews.DataSource = client.ClientReviews;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiContractValueDateValueChanged(object sender, EventArgs e)
        {
            if (_opContractType == OpContractType.NEW_CONTRACT)
            {
                var contract = contractBindingSource.DataSource as Contract;
                if (contract != null)
                {
                    contract.ContractValueDate = diContractValueDate.Value.Date;
                    contract.ContractDueDate = diContractValueDate.Value.Date.AddYears(2);
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
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(clientCreditLineBindingSource.DataSource is ClientCreditLine))
            {
                return;
            }

            var creditLine = (ClientCreditLine)clientCreditLineBindingSource.DataSource;
            if (creditLine.CreditLineID == 0)
            {
                return;
            }

            if (creditLine.CreditLineStatus == CLIENT_CREDIT_LINE.AVAILABILITY)
            {
                freezeReasonTextBox.ReadOnly = false;
                freezeDateDateTimePicker.Enabled = true;
                creditLine.Freezer = App.Current.CurUser.Name;
                creditLine.FreezeDate = DateTime.Now.Date;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClientCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            clientCreditLineBindingSource.DataSource = typeof(ClientCreditLine);
            clientCreditLineBindingSource.DataSource = new ClientCreditLine();
            _opClientCreditLineType = OpClientCreditLineType.NEW_CLIENT_CREDIT_LINE;
            UpdateClientCreditLineControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewContract(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            contractBindingSource.DataSource = typeof(Contract);
            contractBindingSource.DataSource = new Contract();
            _opContractType = OpContractType.NEW_CONTRACT;
            UpdateContractControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGD(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            gdBindingSource.DataSource = typeof(GuaranteeDeposit);
            gdBindingSource.DataSource = new GuaranteeDeposit();
            _opGdType = OpGDType.NEW_GD;
            UpdateGDControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewReview(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            reviewBindingSource.DataSource = typeof(ClientReview);
            reviewBindingSource.DataSource = new ClientReview();
            _opReviewType = OpReviewType.NEW_REVIEW;
            UpdateReviewControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PeriodBeginDateTimePickerValueChanged(object sender, EventArgs e)
        {
            if (_opClientCreditLineType == OpClientCreditLineType.NEW_CLIENT_CREDIT_LINE)
            {
                var creditLine = clientCreditLineBindingSource.DataSource as ClientCreditLine;
                if (creditLine != null)
                {
                    creditLine.PeriodBegin = periodBeginDateTimePicker.Value.Date;
                    creditLine.PeriodEnd = periodBeginDateTimePicker.Value.AddYears(1);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshClientCreditLine(object sender, EventArgs e)
        {
            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            _bsCreditLines.DataSource = typeof(ClientCreditLine);
            _bsCreditLines.DataSource = client.ClientCreditLines;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshContracts(object sender, EventArgs e)
        {
            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            _bsContracts.DataSource = typeof(Contract);
            _bsContracts.DataSource = client.Contracts;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshGDs(object sender, EventArgs e)
        {
            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            _bsGDs.DataSource = typeof(GuaranteeDeposit);
            _bsGDs.DataSource = client.GuaranteeDeposits;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshReviews(object sender, EventArgs e)
        {
            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            _bsReviews.DataSource = typeof(ClientReview);
            _bsReviews.DataSource = client.ClientReviews;
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SaveClient(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (!clientValidator.Validate())
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            client.CreateUserName = App.Current.CurUser.Name;

            if (_opClientType == OpClientType.NEW_CLIENT)
            {
                bool isAddOK = true;
                try
                {
                    if (_context.Clients.Any(c => c.ClientEDICode == client.ClientEDICode))
                    {
                        MessageBoxEx.Show("保理代码重复，不能保存", MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    _context.Clients.InsertOnSubmit(client);
                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    _opClientType = OpClientType.UPDATE_CLIENT;
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
                    _context.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    foreach (ObjectChangeConflict cc in _context.ChangeConflicts)
                    {
                        foreach (MemberChangeConflict mc in cc.MemberConflicts)
                        {
                            mc.Resolve(RefreshMode.KeepChanges);
                        }
                    }

                    _context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
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
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (!creditLineValidator.Validate())
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(clientCreditLineBindingSource.DataSource is ClientCreditLine))
            {
                return;
            }

            var creditLine = (ClientCreditLine)clientCreditLineBindingSource.DataSource;
            creditLine.CreateUserName = App.Current.CurUser.Name;

            DateTime today = DateTime.Now.Date;
            creditLine.CreditLineStatus = creditLine.PeriodEnd < today
                                              ? CLIENT_CREDIT_LINE.EXPIRY
                                              : CLIENT_CREDIT_LINE.AVAILABILITY;

            if (freezeDateDateTimePicker.Enabled)
            {
                creditLine.CreditLineStatus = CLIENT_CREDIT_LINE.FREEZE;
            }

            if (creditLine.CreditLineID == 0)
            {
                bool isAddOK = true;
                try
                {
                    creditLine.Client = client;

                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    creditLine.Client = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    if (creditLine.CreditLineStatus == CLIENT_CREDIT_LINE.AVAILABILITY)
                    {
                        foreach (ClientCreditLine ccl in client.ClientCreditLines)
                        {
                            if (ccl != creditLine && ccl.CreditLineStatus == CLIENT_CREDIT_LINE.AVAILABILITY &&
                                ccl.CreditLineType == creditLine.CreditLineType)
                            {
                                ccl.CreditLineStatus = CLIENT_CREDIT_LINE.EXPIRY;
                            }
                        }

                        try
                        {
                            _context.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                        }
                    }

                    _bsCreditLines.DataSource = client.ClientCreditLines.ToList();
                    NewClientCreditLine(null, null);
                }
            }
            else
            {
                bool isUpdateOK = true;

                try
                {
                    _context.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    foreach (ObjectChangeConflict cc in _context.ChangeConflicts)
                    {
                        foreach (MemberChangeConflict mc in cc.MemberConflicts)
                        {
                            mc.Resolve(RefreshMode.KeepChanges);
                        }
                    }

                    _context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    if (creditLine.CreditLineStatus == CLIENT_CREDIT_LINE.AVAILABILITY)
                    {
                        foreach (ClientCreditLine ccl in client.ClientCreditLines)
                        {
                            if (ccl != creditLine && ccl.CreditLineStatus == CLIENT_CREDIT_LINE.AVAILABILITY &&
                                ccl.CreditLineType == creditLine.CreditLineType &&
                                ccl.CreditLineCurrency == creditLine.CreditLineCurrency)
                            {
                                ccl.CreditLineStatus = CLIENT_CREDIT_LINE.EXPIRY;
                            }
                        }

                        try
                        {
                            _context.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                        }
                    }

                    dgvClientCreditLines.Refresh();
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
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (!contractValidator.Validate())
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(contractBindingSource.DataSource is Contract))
            {
                return;
            }

            var contract = (Contract)contractBindingSource.DataSource;
            contract.CreateUserName = App.Current.CurUser.Name;

            if (_opContractType == OpContractType.NEW_CONTRACT)
            {
                bool isAddOK = true;

                Contract oldContract =
                    _context.Contracts.SingleOrDefault(c => c.ContractCode == contract.ContractCode);
                if (oldContract != null)
                {
                    MessageBoxEx.Show("该合同编号已存在，请重新编码", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    contract.Client = client;

                    DateTime today = DateTime.Now.Date;
                    contract.ContractStatus = contract.ContractDueDate < today ? CONTRACT.EXPIRY : CONTRACT.AVAILABILITY;

                    _context.Contracts.InsertOnSubmit(contract);
                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    contract.Client = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    if (contract.ContractStatus == CONTRACT.AVAILABILITY)
                    {
                        foreach (Contract c in client.Contracts)
                        {
                            if (c != contract && c.ContractStatus == CONTRACT.AVAILABILITY)
                            {
                                c.ContractStatus = CONTRACT.EXPIRY;
                            }
                        }

                        try
                        {
                            _context.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                        }
                    }

                    _bsContracts.DataSource = client.Contracts.ToList();
                    NewContract(null, null);
                }
            }
            else
            {
                bool isUpdateOK = true;
                DateTime today = DateTime.Now.Date;
                contract.ContractStatus = contract.ContractDueDate < today ? CONTRACT.EXPIRY : CONTRACT.AVAILABILITY;

                try
                {
                    _context.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    foreach (ObjectChangeConflict cc in _context.ChangeConflicts)
                    {
                        foreach (MemberChangeConflict mc in cc.MemberConflicts)
                        {
                            mc.Resolve(RefreshMode.KeepChanges);
                        }
                    }

                    _context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show(MESSAGE.DATA_UPDATE_SUCCESS, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    if (contract.ContractStatus == CONTRACT.AVAILABILITY)
                    {
                        foreach (Contract c in client.Contracts)
                        {
                            if (c != contract && c.ContractStatus == CONTRACT.AVAILABILITY)
                            {
                                c.ContractStatus = CONTRACT.EXPIRY;
                            }
                        }

                        try
                        {
                            _context.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                        }
                    }

                    dgvContracts.Refresh();
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
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(gdBindingSource.DataSource is GuaranteeDeposit))
            {
                return;
            }

            var gd = (GuaranteeDeposit)gdBindingSource.DataSource;
            gd.CreateUserName = App.Current.CurUser.Name;

            if (_opGdType == OpGDType.NEW_GD)
            {
                bool isAddOK = true;
                try
                {
                    client.GuaranteeDeposits.Add(gd);

                    _context.GuaranteeDeposits.InsertOnSubmit(gd);
                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    gd.Client = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);

                    _bsGDs.DataSource = client.GuaranteeDeposits.ToList();
                    NewGD(null, null);
                }
            }
            else
            {
                bool isUpdateOK = true;
                try
                {
                    _context.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    foreach (ObjectChangeConflict cc in _context.ChangeConflicts)
                    {
                        foreach (MemberChangeConflict mc in cc.MemberConflicts)
                        {
                            mc.Resolve(RefreshMode.KeepChanges);
                        }
                    }

                    _context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show(MESSAGE.DATA_UPDATE_SUCCESS, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    dgvContracts.Refresh();
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
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (!reviewValidator.Validate())
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(reviewBindingSource.DataSource is ClientReview))
            {
                return;
            }

            var review = (ClientReview)reviewBindingSource.DataSource;
            review.CreateUserName = App.Current.CurUser.Name;

            string financeType = requestFinanceTypeCheckedListBox.CheckedItems.Cast<string>().Aggregate(string.Empty,
                                                                                                        (current, item)
                                                                                                        =>
                                                                                                        current +
                                                                                                        (item + ";"));

            review.RequestFinanceType = financeType;

            if (_opReviewType == OpReviewType.NEW_REVIEW)
            {
                bool isAddOK = true;
                try
                {
                    if (_context.ClientReviews.Any(c => c.ReviewNo == review.ReviewNo))
                    {
                        MessageBoxEx.Show("协查意见编号重复，不能保存", MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    client.ClientReviews.Add(review);

                    _context.ClientReviews.InsertOnSubmit(review);
                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    review.Client = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);

                    _bsReviews.DataSource = client.ClientReviews.ToList();
                    NewReview(null, null);
                }
            }
            else
            {
                bool isUpdateOK = true;
                try
                {
                    _context.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    foreach (ObjectChangeConflict cc in _context.ChangeConflicts)
                    {
                        foreach (MemberChangeConflict mc in cc.MemberConflicts)
                        {
                            mc.Resolve(RefreshMode.KeepChanges);
                        }
                    }

                    _context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show(MESSAGE.DATA_UPDATE_SUCCESS, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    dgvGDs.Refresh();
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
            if (dgvClientCreditLines.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedClientCreditLine =
                (ClientCreditLine)_bsCreditLines.List[dgvClientCreditLines.SelectedRows[0].Index];
            SetClientCreditLineEditable(false);
            clientCreditLineBindingSource.DataSource = selectedClientCreditLine;
            btnClientCreditLineFreeze.Enabled = true;
            btnClientCreditLineUnfreeze.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectContract(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContracts.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedContract = (Contract)_bsContracts.List[dgvContracts.SelectedRows[0].Index];
            SetContractEditable(false);
            contractBindingSource.DataSource = selectedContract;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectGD(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGDs.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedGD = (GuaranteeDeposit)_bsGDs.List[dgvGDs.SelectedRows[0].Index];
            SetGDEditable(false);
            gdBindingSource.DataSource = selectedGD;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectGroup(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            var clientMgr = new ClientMgr();
            var queryUI = new QueryForm(clientMgr, "选择集团");
            clientMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            if (clientMgr.Selected != null)
            {
                client.ClientGroup =
                    _context.Clients.SingleOrDefault(c => c.ClientEDICode == clientMgr.Selected.ClientEDICode);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectGroupCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client.ClientGroup == null)
            {
                return;
            }

            var mgr = new ClientCreditLineMgr(client.ClientGroup);
            var queryFrom = new QueryForm(mgr, "选择集团额度");
            mgr.OwnerForm = queryFrom;
            queryFrom.ShowDialog(this);
            ClientCreditLine selected = mgr.Selected;
            if (selected != null)
            {
                var clientCreditLine = (ClientCreditLine)clientCreditLineBindingSource.DataSource;
                if (clientCreditLine.CreditLineType != selected.CreditLineType)
                {
                    MessageBoxEx.Show("所选集团的额度类型与客户的额度类型不相同", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    return;
                }

                if (clientCreditLine.CreditLine > selected.CreditLine)
                {
                    MessageBoxEx.Show("所选集团的保理预付款融资额度必须大于客户的保理预付款融资额度", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
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
            if (dgvReviews.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedReview = (ClientReview)_bsReviews.List[dgvReviews.SelectedRows[0].Index];
            SetReviewEditable(false);
            reviewBindingSource.DataSource = selectedReview;
            if (selectedReview.RequestFinanceType != null)
            {
                var financeList = new List<string>();
                financeList.AddRange(selectedReview.RequestFinanceType.Split(';'));
                for (int i = 0; i < requestFinanceTypeCheckedListBox.Items.Count; i++)
                {
                    var item = requestFinanceTypeCheckedListBox.Items[i] as string;
                    if (financeList.Contains(item))
                    {
                        requestFinanceTypeCheckedListBox.SetItemChecked(i, true);
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
            foreach (Control comp in groupPanelClientCreditLine.Controls)
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
            foreach (Control comp in groupPanelContract.Controls)
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
            foreach (Control comp in groupPanelGuaranteePanel.Controls)
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
            foreach (Control comp in groupPanelReview.Controls)
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
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(clientCreditLineBindingSource.DataSource is ClientCreditLine))
            {
                return;
            }

            var creditLine = (ClientCreditLine)clientCreditLineBindingSource.DataSource;
            if (creditLine.CreditLineID == 0)
            {
                return;
            }

            if (creditLine.CreditLineStatus == "已冻结")
            {
                unfreezeReasonTextBox.ReadOnly = false;
                unfreezeDateDateTimePicker.Enabled = true;
                creditLine.Unfreezer = App.Current.CurUser.Name;
                creditLine.UnfreezeDate = DateTime.Now.Date;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateClient(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            _opClientType = OpClientType.UPDATE_CLIENT;
            UpdateClientControlStatus();
        }

        /// <summary>
        /// udpate editable status
        /// </summary>
        private void UpdateClientControlStatus()
        {
            if (_opClientType == OpClientType.DETAIL_CLIENT)
            {
                foreach (Control comp in groupPanelClientBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in groupPanelClientContact.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in groupPanelClientGroup.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in groupPanelClientStat.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                btnGroupSelect.Visible = false;
            }
            else if (_opClientType == OpClientType.NEW_CLIENT)
            {
                foreach (Control comp in groupPanelClientBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in groupPanelClientContact.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in groupPanelClientGroup.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in groupPanelClientStat.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                btnGroupSelect.Visible = true;
            }
            else if (_opClientType == OpClientType.UPDATE_CLIENT)
            {
                foreach (Control comp in groupPanelClientBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in groupPanelClientContact.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in groupPanelClientGroup.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in groupPanelClientStat.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                btnGroupSelect.Visible = true;
                clientEDICodeTextBox.ReadOnly = true;
            }

            ControlUtil.SetComponetEditable(tbCreateUserName, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateClientCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var client = (Client)clientBindingSource.DataSource;
            if (client == null || client.ClientEDICode == null)
            {
                MessageBoxEx.Show("请首先选定一个客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(clientCreditLineBindingSource.DataSource is ClientCreditLine))
            {
                return;
            }

            _opClientCreditLineType = OpClientCreditLineType.UPDATE_CLIENT_CREDIT_LINE;
            UpdateClientCreditLineControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateClientCreditLineControlStatus()
        {
            if (_opClientCreditLineType == OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE)
            {
                foreach (Control comp in groupPanelClientCreditLine.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (_opClientCreditLineType == OpClientCreditLineType.NEW_CLIENT_CREDIT_LINE)
            {
                foreach (Control comp in groupPanelClientCreditLine.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                creditLineStatusTextBox.ReadOnly = true;
                freezeReasonTextBox.ReadOnly = true;
                freezerTextBox.ReadOnly = true;
                freezeDateDateTimePicker.Enabled = false;
                unfreezeReasonTextBox.ReadOnly = true;
                unfreezerTextBox.ReadOnly = true;
                unfreezeDateDateTimePicker.Enabled = false;
            }
            else if (_opClientCreditLineType == OpClientCreditLineType.UPDATE_CLIENT_CREDIT_LINE)
            {
                foreach (Control comp in groupPanelClientCreditLine.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                creditLineStatusTextBox.ReadOnly = true;
                freezeReasonTextBox.ReadOnly = true;
                freezerTextBox.ReadOnly = true;
                freezeDateDateTimePicker.Enabled = false;
                unfreezeReasonTextBox.ReadOnly = true;
                unfreezerTextBox.ReadOnly = true;
                unfreezeDateDateTimePicker.Enabled = false;
            }

            tbGroupCreditLine.ReadOnly = true;
            tbGroupCreditLineCurr.ReadOnly = true;
            ControlUtil.SetComponetEditable(tbCreditLineCreateUserName, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateContract(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            _opContractType = OpContractType.UPDATE_CONTRACT;
            UpdateContractControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContractControlStatus()
        {
            if (_opContractType == OpContractType.DETAIL_CONTRACT)
            {
                foreach (Control comp in groupPanelContract.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (_opContractType == OpContractType.NEW_CONTRACT)
            {
                foreach (Control comp in groupPanelContract.Controls)
                {
                    ControlUtil.SetComponetDefault(comp);
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (_opContractType == OpContractType.UPDATE_CONTRACT)
            {
                foreach (Control comp in groupPanelContract.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                tbContractCode.ReadOnly = true;
            }

            //ControlUtil.SetComponetEditable(this.tbContractStatus, false);
            ControlUtil.SetComponetEditable(tbContractCreateUserName, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateGD(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            _opGdType = OpGDType.UPDATE_GD;
            UpdateGDControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateGDControlStatus()
        {
            if (_opGdType == OpGDType.DETAIL_GD)
            {
                foreach (Control comp in groupPanelGuaranteePanel.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (_opGdType == OpGDType.NEW_GD)
            {
                foreach (Control comp in groupPanelGuaranteePanel.Controls)
                {
                    ControlUtil.SetComponetDefault(comp);
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (_opGdType == OpGDType.UPDATE_GD)
            {
                foreach (Control comp in groupPanelGuaranteePanel.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }

            ControlUtil.SetComponetEditable(tbGDCreateUserName, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateReivew(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            _opReviewType = OpReviewType.UPDATE_REVIEW;
            UpdateReviewControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateReviewControlStatus()
        {
            if (_opReviewType == OpReviewType.DETAIL_REVIEW)
            {
                foreach (Control comp in groupPanelReview.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (_opReviewType == OpReviewType.NEW_REVIEW)
            {
                foreach (Control comp in groupPanelReview.Controls)
                {
                    ControlUtil.SetComponetDefault(comp);
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (_opReviewType == OpReviewType.UPDATE_REVIEW)
            {
                foreach (Control comp in groupPanelReview.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                reviewNoTextBox.ReadOnly = true;
            }

            ControlUtil.SetComponetEditable(tbReviewCreateUserName, false);
        }
    }
}
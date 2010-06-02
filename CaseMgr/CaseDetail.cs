//-----------------------------------------------------------------------
// <copyright file="CaseDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.ARMgr;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.InfoMgr.ClientMgr;
using CMBC.EasyFactor.InfoMgr.FactorMgr;
using CMBC.EasyFactor.Utils;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Validator;

namespace CMBC.EasyFactor.CaseMgr
{
    /// <summary>
    /// Case Detail
    /// </summary>
    public partial class CaseDetail : Office2007Form
    {
        #region OpCaseType enum

        /// <summary>
        /// Operation types of Case
        /// </summary>
        public enum OpCaseType
        {
            /// <summary>
            /// New case
            /// </summary>
            NEW_CASE,

            /// <summary>
            /// Update case
            /// </summary>
            UPDATE_CASE,

            /// <summary>
            /// Detail case
            /// </summary>
            DETAIL_CASE,
        }

        #endregion

        #region OpCreditCoverNegType enum

        /// <summary>
        /// Operation types of Credit Cover Negotiation
        /// </summary>
        public enum OpCreditCoverNegType
        {
            /// <summary>
            /// New CreditCoverNegotiation
            /// </summary>
            NEW_CREDIT_COVER_NEG,

            /// <summary>
            /// Update CreditCoverNegotiation
            /// </summary>
            UPDATE_CREDIT_COVER_NEG,

            /// <summary>
            /// Detail CreditCoverNegotiation
            /// </summary>
            DETAIL_CREDIT_COVER_NEG
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bsCDAs;

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bsCreditCoverNegs;

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;

        /// <summary>
        /// Operation type of Case
        /// </summary>
        private OpCaseType _opCaseType;

        /// <summary>
        /// Operation type of Credit Cover Negotiation
        /// </summary>
        private OpCreditCoverNegType _opCreditCoverNegType;


        /// <summary>
        /// Initializes a new instance of the CaseDetail class
        /// </summary>
        /// <param name="curCase">Selected case</param>
        /// <param name="opCaseType">operation type of Case</param>
        /// <param name="opCreditCoverNegType">operation type of CreditCoverNegotiation</param>
        private CaseDetail(Case curCase, OpCaseType opCaseType, OpCreditCoverNegType opCreditCoverNegType)
        {
            InitializeComponent();
            _bsCDAs = new BindingSource();
            _bsCreditCoverNegs = new BindingSource();
            ImeMode = ImeMode.OnHalf;
            dgvCDAs.AutoGenerateColumns = false;
            dgvCreditCoverNegs.AutoGenerateColumns = false;
            dgvCDAs.DataSource = _bsCDAs;
            dgvCreditCoverNegs.DataSource = _bsCreditCoverNegs;
            _context = new DBDataContext();

            cbCaseInvoiceCurrency.DataSource = Currency.AllCurrencies;
            cbCaseInvoiceCurrency.DisplayMember = "CurrencyFormat";
            cbCaseInvoiceCurrency.ValueMember = "CurrencyCode";

            List<Department> allDepartments = Department.AllDepartments(_context);
            cbCaseOwnerDepts.DataSource = allDepartments;
            cbCaseOwnerDepts.DisplayMembers = "DepartmentName";
            cbCaseOwnerDepts.GroupingMembers = "Domain";
            cbCaseOwnerDepts.ValueMember = "DepartmentCode";
            cbCaseOwnerDepts.SelectedIndex = -1;

            _opCaseType = opCaseType;
            _opCreditCoverNegType = opCreditCoverNegType;

            cbReviews.DisplayMember = "ReviewNo";
            cbReviews.ValueMember = "ReviewNo";

            tbIFPrice.DataBindings[0].Format += TypeUtil.FormatFloatToPercent;
            tbIFPrice.DataBindings[0].Parse += TypeUtil.ParsePercentToFloat;

            if (opCaseType == OpCaseType.NEW_CASE)
            {
                curCase = new Case
                              {
                                  CreateUserName = App.Current.CurUser.Name,
                                  CaseAppDate = DateTime.Now.Date,
                                  OperationType = "自营",
                                  CaseMark = "申请案"
                              };
                caseBindingSource.DataSource = curCase;
            }
            else
            {
                curCase = _context.Cases.SingleOrDefault(c => c.CaseCode == curCase.CaseCode);
                caseBindingSource.DataSource = curCase;
                _bsCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations;
                _bsCDAs.DataSource = curCase.CDAs;

                switch (curCase.TransactionType)
                {
                    case "国内卖方保理":
                    case "出口保理":
                        tbCaseFactorCode.Text = curCase.BuyerFactor.FactorCode;
                        tbCaseFactorNameCN.Text = curCase.BuyerFactor.CompanyNameCN;
                        tbCaseFactorNameEN.Text = curCase.BuyerFactor.CompanyNameEN;
                        break;
                    case "国内买方保理":
                    case "进口保理":
                        tbCaseFactorCode.Text = curCase.SellerFactor.FactorCode;
                        tbCaseFactorNameCN.Text = curCase.SellerFactor.CompanyNameCN;
                        tbCaseFactorNameEN.Text = curCase.SellerFactor.CompanyNameEN;
                        break;
                    default:
                        break;
                }

                cbReviews.DataSource = curCase.ClientReviews;

                var deptsList = (List<Department>) cbCaseOwnerDepts.DataSource;
                cbCaseOwnerDepts.SelectedIndex = deptsList.IndexOf(curCase.OwnerDepartment);
            }

            if (opCreditCoverNegType == OpCreditCoverNegType.NEW_CREDIT_COVER_NEG)
            {
                tabControl.SelectedTab = tabItemCreditCoverNeg;
            }

            var invoiceMgr = new InvoiceMgr(curCase.GetInvoices(), _context) {Dock = DockStyle.Fill};
            tabPanelInvoice.Controls.Add(invoiceMgr);

            UpdateCaseControlStatus();
            UpdateCreditCoverNegControlStatus();
        }

        /// <summary>
        /// Initializes a new instance of the CaseDetail class
        /// </summary>
        /// <param name="curCase">Selected case</param>
        /// <param name="opCaseType">Operation type of Case</param>
        public CaseDetail(Case curCase, OpCaseType opCaseType)
            : this(curCase, opCaseType, OpCreditCoverNegType.DETAIL_CREDIT_COVER_NEG)
        {
            tabControl.SelectedTab = tabItemCase;
        }

        /// <summary>
        /// Initializes a new instance of the CaseDetail class
        /// </summary>
        /// <param name="curCase">Selected case</param>
        /// <param name="opCreditCoverNegType">Operation type of CreditCoverNegotiation</param>
        public CaseDetail(Case curCase, OpCreditCoverNegType opCreditCoverNegType)
            : this(curCase, OpCaseType.DETAIL_CASE, opCreditCoverNegType)
        {
            tabControl.SelectedTab = tabItemCreditCoverNeg;
        }

        /// <summary>
        /// Initializes a new instance of the CaseDetail class
        /// </summary>
        /// <param name="neg"></param>
        /// <param name="opCreditCoverNegType"></param>
        public CaseDetail(CreditCoverNegotiation neg, OpCreditCoverNegType opCreditCoverNegType)
            : this(neg.Case, OpCaseType.DETAIL_CASE, opCreditCoverNegType)
        {
            tabControl.SelectedTab = tabItemCreditCoverNeg;

            if (opCreditCoverNegType == OpCreditCoverNegType.DETAIL_CREDIT_COVER_NEG ||
                opCreditCoverNegType == OpCreditCoverNegType.UPDATE_CREDIT_COVER_NEG)
            {
                neg = _context.CreditCoverNegotiations.SingleOrDefault(n => n.NegoID == neg.NegoID);
                creditCoverNegBindingSource.DataSource = neg;
            }
        }


        //?Private?Methods?(24)?
        /// <summary>
        /// Case owner deparment changed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseOwnerDeptsChanged(object sender, AdvTreeNodeEventArgs e)
        {
            if (caseBindingSource.DataSource is Case)
            {
                var curCase = (Case) caseBindingSource.DataSource;
                if (cbCaseOwnerDepts.SelectedNode != null)
                {
                    curCase.OwnerDepartment = (Department) cbCaseOwnerDepts.SelectedNode.DataKey;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseTransactionTypeChanged(object sender, EventArgs e)
        {
            string transactionType = cbCaseTransactionType.Text;

            var curCase = (Case) caseBindingSource.DataSource;

            Factor cmbc = _context.Factors.SingleOrDefault(f => f.FactorCode == Factor.CMBC_CODE);
            switch (transactionType)
            {
                case "国内卖方保理":
                case "国内买方保理":
                    btnCaseFactorSelect.Enabled = false;
                    curCase.SellerFactor = cmbc;
                    curCase.BuyerFactor = cmbc;
                    curCase.InvoiceCurrency = "CNY";
                    cbCaseInvoiceCurrency.Enabled = false;
                    break;
                case "出口保理":
                    btnCaseFactorSelect.Enabled = true;
                    curCase.SellerFactor = cmbc;
                    curCase.InvoiceCurrency = "USD";
                    cbCaseInvoiceCurrency.Enabled = true;
                    break;
                case "进口保理":
                    btnCaseFactorSelect.Enabled = true;
                    curCase.BuyerFactor = cmbc;
                    curCase.InvoiceCurrency = "USD";
                    cbCaseInvoiceCurrency.Enabled = true;
                    break;
                default:
                    break;
            }

            if (!"进口保理".Equals(curCase.TransactionType) && curCase.SellerClient != null)
            {
                if (curCase.SellerClient.Contract == null)
                {
                    curCase.SellerClient = null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator1ValidateValue(object sender, ValidateValueEventArgs e)
        {
            var curCase = (Case) caseBindingSource.DataSource;
            var caseTypes = new[] {"出口保理", "进口保理"};
            if (caseTypes.Contains(curCase.TransactionType))
            {
                e.IsValid = !String.IsNullOrEmpty(tbCaseFactorCode.Text);
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
        private void DeleteCDA(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CDA_UPDATE))
            {
                return;
            }

            if (dgvCDAs.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedCDA = (CDA) _bsCDAs.List[dgvCDAs.SelectedRows[0].Index];
            if (
                MessageBoxEx.Show("是否打算删除额度通知书: " + selectedCDA.CDACode, MESSAGE.TITLE_WARNING,
                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;

            try
            {
                _context.CDAs.DeleteOnSubmit(selectedCDA);
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show("不能删除此额度通知书: " + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCDAs.Rows.RemoveAt(dgvCDAs.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// Delete current CreditCoverNegotiation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCreditCoverNeg(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            var curCase = (Case) caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("请首先选择一个案子", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(creditCoverNegBindingSource.DataSource is CreditCoverNegotiation))
            {
                return;
            }

            var creditCoverNeg = (CreditCoverNegotiation) creditCoverNegBindingSource.DataSource;
            if (creditCoverNeg.NegoID == 0)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                _context.CreditCoverNegotiations.DeleteOnSubmit(creditCoverNeg);
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
                _bsCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations.ToList();
                creditCoverNegBindingSource.DataSource = new CreditCoverNegotiation();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailBuyer(object sender, EventArgs e)
        {
            var curCase = (Case) caseBindingSource.DataSource;
            if (curCase == null || curCase.BuyerClient == null)
            {
                return;
            }

            var clientDetail = new ClientDetail(curCase.BuyerClient, ClientDetail.OpClientType.DETAIL_CLIENT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// Show detail of the selected CDA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCDA(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCDAs.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedCDA = (CDA) _bsCDAs.List[dgvCDAs.SelectedRows[0].Index];
            var cdaDetail = new CDADetail(selectedCDA, CDADetail.OpCDAType.DETAIL_CDA);
            cdaDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailFactor(object sender, EventArgs e)
        {
            var curCase = (Case) caseBindingSource.DataSource;
            if (curCase == null || curCase.TransactionType == null)
            {
                return;
            }

            Factor factor = null;
            switch (curCase.TransactionType)
            {
                case "国内卖方保理":
                case "出口保理":
                    factor = curCase.BuyerFactor;
                    break;
                case "国内买方保理":
                case "进口保理":
                    factor = curCase.SellerFactor;
                    break;
                default:
                    break;
            }

            if (factor != null)
            {
                var factorDetail = new FactorDetail(factor, FactorDetail.OpFactorType.DETAIL_FACTOR);
                factorDetail.ShowDialog(this);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailSeller(object sender, EventArgs e)
        {
            var curCase = (Case) caseBindingSource.DataSource;
            if (curCase == null || curCase.SellerClient == null)
            {
                return;
            }

            var clientDetail = new ClientDetail(curCase.SellerClient, ClientDetail.OpClientType.DETAIL_CLIENT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCDAsCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = dgvCDAs.Columns[e.ColumnIndex];
            if (column == colIsRecoarse)
            {
                Object originalData = e.Value;
                if (originalData != null)
                {
                    var result = (bool) originalData;
                    e.Value = result ? "Y" : "N";
                }
            }
        }

        /// <summary>
        /// Create new CDA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCDA(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CDA_UPDATE))
            {
                return;
            }

            var curCase = (Case) caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("请首先选择一个案子", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            var cdaDetail = new CDADetail(curCase, CDADetail.OpCDAType.NEW_CDA);
            cdaDetail.Show(this);
        }

        /// <summary>
        /// Create new CreditCoverNegotiation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCreditCoverNeg(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            var curCase = (Case) caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("请首先选择一个案子", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (curCase.TransactionType == "出口保理" || curCase.TransactionType == "进口保理")
            {
                var creditCoverNeg = new CreditCoverNegotiation {CreateUserName = App.Current.CurUser.Name};
                creditCoverNegBindingSource.DataSource = creditCoverNeg;
                _opCreditCoverNegType = OpCreditCoverNegType.NEW_CREDIT_COVER_NEG;
                UpdateCreditCoverNegControlStatus();
            }
            else
            {
                MessageBoxEx.Show("国内保理案不需要向国外保理商申请额度", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Refresh the CDA list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshCDAList(object sender, EventArgs e)
        {
            var curCase = (Case) caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("请首先选择一个案子", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            _bsCDAs.DataSource = curCase.CDAs.ToList();
        }

        /// <summary>
        /// Refresh the CreditCoverNegotiation list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshCreditCoverNegList(object sender, EventArgs e)
        {
            var curCase = (Case) caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("请首先选择一个案子", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            _bsCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations.ToList();
        }

        /// <summary>
        /// Save current Case
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCase(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            if (!caseValidator.Validate())
            {
                return;
            }

            var curCase = (Case) caseBindingSource.DataSource;
            curCase.CreateUserName = App.Current.CurUser.Name;

            if (curCase.CaseCode == null)
            {
                bool isAddOK = true;
                try
                {
                    curCase.CaseCode = Case.GenerateCaseCode(curCase.TransactionType,
                                                             curCase.OwnerDepartment.LocationCode, curCase.CaseAppDate);
                    _context.Cases.InsertOnSubmit(curCase);
                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    curCase.CaseCode = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    _opCaseType = OpCaseType.UPDATE_CASE;
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
                    if (curCase.CaseMark == "已结案")
                    {
                        foreach (CDA cda in curCase.CDAs)
                        {
                            cda.CDAStatus = "已失效";
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

                    MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Save current CreditCoverNegotiation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCreditCoverNeg(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            if (!creditCoverValidator.Validate())
            {
                return;
            }

            var curCase = (Case) caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("请首先选择一个案子", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(creditCoverNegBindingSource.DataSource is CreditCoverNegotiation))
            {
                return;
            }

            var creditCoverNeg = (CreditCoverNegotiation) creditCoverNegBindingSource.DataSource;
            creditCoverNeg.CreateUserName = App.Current.CurUser.Name;

            if (creditCoverNeg.NegoID == 0)
            {
                bool isAddOK = true;
                try
                {
                    creditCoverNeg.Case = curCase;
                    _context.CreditCoverNegotiations.InsertOnSubmit(creditCoverNeg);
                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    creditCoverNeg.Case = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    _bsCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations.ToList();
                    NewCreditCoverNeg(null, null);
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
                    dgvCreditCoverNegs.Refresh();
                }
            }
        }

        /// <summary>
        /// Select the case buyer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCaseBuyer(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            var curCase = (Case) caseBindingSource.DataSource;
            var clientMgr = new ClientMgr();
            var queryUI = new QueryForm(clientMgr, "选择买方");
            clientMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            if (clientMgr.Selected != null)
            {
                curCase.BuyerClient =
                    _context.Clients.SingleOrDefault(c => c.ClientEDICode == clientMgr.Selected.ClientEDICode);
                switch (cbCaseTransactionType.Text)
                {
                    case "国内卖方保理":
                    case "出口保理":
                        break;
                    case "国内买方保理":
                    case "进口保理":
                        curCase.OwnerDepartment = curCase.BuyerClient.Department;
                        if (curCase.OwnerDepartment != null)
                        {
                            if (!curCase.OwnerDepartment.DepartmentName.Contains("贸金"))
                            {
                                curCase.OperationType = "协销";
                            }
                            var deptsList = (List<Department>) cbCaseOwnerDepts.DataSource;
                            cbCaseOwnerDepts.SelectedIndex = deptsList.IndexOf(curCase.OwnerDepartment);
                        }

                        cbReviews.DataSource = curCase.ClientReviews;
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Select the case seller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCaseSeller(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            var curCase = (Case) caseBindingSource.DataSource;
            var clientMgr = new ClientMgr();
            var queryUI = new QueryForm(clientMgr, "选择卖方");
            clientMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            if (clientMgr.Selected != null)
            {
                curCase.SellerClient =
                    _context.Clients.SingleOrDefault(c => c.ClientEDICode == clientMgr.Selected.ClientEDICode);
                switch (cbCaseTransactionType.Text)
                {
                    case "国内卖方保理":
                    case "出口保理":
                        curCase.OwnerDepartment = curCase.SellerClient.Department;
                        if (curCase.OwnerDepartment != null)
                        {
                            if (!curCase.OwnerDepartment.DepartmentName.Contains("贸金"))
                            {
                                curCase.OperationType = "协销";
                            }

                            var deptsList = (List<Department>) cbCaseOwnerDepts.DataSource;
                            cbCaseOwnerDepts.SelectedIndex = deptsList.IndexOf(curCase.OwnerDepartment);
                        }

                        cbReviews.DataSource = curCase.ClientReviews;
                        break;
                    case "国内买方保理":
                    case "进口保理":
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Select CreditCoverNegotiation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCreditCoverNeg(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCreditCoverNegs.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedCreditCoverNeg =
                (CreditCoverNegotiation) _bsCreditCoverNegs.List[dgvCreditCoverNegs.SelectedRows[0].Index];
            creditCoverNegBindingSource.DataSource = selectedCreditCoverNeg;
        }

        /// <summary>
        /// Select the factor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFactor(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            var curCase = (Case) caseBindingSource.DataSource;
            var factorMgr = new FactorMgr();
            var queryUI = new QueryForm(factorMgr, "选择保理商");
            factorMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);

            Factor factor = factorMgr.Selected;
            if (factor != null)
            {
                factor = _context.Factors.SingleOrDefault(f => f.FactorCode == factor.FactorCode);
                tbCaseFactorCode.Text = factor.FactorCode;
                tbCaseFactorNameCN.Text = factor.CompanyNameCN;
                tbCaseFactorNameEN.Text = factor.CompanyNameEN;

                switch (cbCaseTransactionType.Text)
                {
                    case "国内卖方保理":
                    case "出口保理":
                        curCase.BuyerFactor = factor;
                        break;
                    case "国内买方保理":
                    case "进口保理":
                        curCase.SellerFactor = factor;
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Turn case into update status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCase(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            var curCase = (Case) caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("请首先选择一个案子", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            _opCaseType = OpCaseType.UPDATE_CASE;
            UpdateCaseControlStatus();
        }

        /// <summary>
        /// Update case control status
        /// </summary>
        private void UpdateCaseControlStatus()
        {
            if (_opCaseType == OpCaseType.NEW_CASE)
            {
                foreach (Control comp in groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                btnCaseBuyerSelect.Visible = true;
                btnCaseFactorSelect.Visible = true;
                btnCaseSellerSelect.Visible = true;
            }
            else if (_opCaseType == OpCaseType.UPDATE_CASE)
            {
                foreach (Control comp in groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                btnCaseBuyerSelect.Visible = true;
                btnCaseFactorSelect.Visible = true;
                btnCaseSellerSelect.Visible = true;
            }
            else if (_opCaseType == OpCaseType.DETAIL_CASE)
            {
                foreach (Control comp in groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                btnCaseBuyerSelect.Visible = false;
                btnCaseFactorSelect.Visible = false;
                btnCaseSellerSelect.Visible = false;
            }

            tbCaseCreateUser.ReadOnly = true;
            tbCaseCode.ReadOnly = true;
            tbCaseSellerNo.ReadOnly = true;
            tbCaseSellerNameCN.ReadOnly = true;
            tbCaseSellerNameEN.ReadOnly = true;
            tbCaseBuyerNo.ReadOnly = true;
            tbCaseBuyerNameCN.ReadOnly = true;
            tbCaseBuyerNameEN.ReadOnly = true;
            tbCaseFactorCode.ReadOnly = true;
            tbCaseFactorNameCN.ReadOnly = true;
            tbCaseFactorNameEN.ReadOnly = true;
        }

        /// <summary>
        /// Turn CreditCoverNegotiation into update status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCreditCoverNeg(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            var curCase = (Case) caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("请首先选择一个案子", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(creditCoverNegBindingSource.DataSource is CreditCoverNegotiation))
            {
                return;
            }

            _opCreditCoverNegType = OpCreditCoverNegType.UPDATE_CREDIT_COVER_NEG;
            UpdateCreditCoverNegControlStatus();
        }

        /// <summary>
        /// Update CreditCoverNegotiation Control Status
        /// </summary>
        private void UpdateCreditCoverNegControlStatus()
        {
            if (_opCreditCoverNegType == OpCreditCoverNegType.DETAIL_CREDIT_COVER_NEG)
            {
                foreach (Control comp in groupPanelCreditCoverNeg.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (_opCreditCoverNegType == OpCreditCoverNegType.NEW_CREDIT_COVER_NEG)
            {
                foreach (Control comp in groupPanelCreditCoverNeg.Controls)
                {
                    ControlUtil.SetComponetDefault(comp);
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (_opCreditCoverNegType == OpCreditCoverNegType.UPDATE_CREDIT_COVER_NEG)
            {
                foreach (Control comp in groupPanelCreditCoverNeg.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }

            ControlUtil.SetComponetEditable(tbCreditCoverCreateUserName, false);
        }
    }
}
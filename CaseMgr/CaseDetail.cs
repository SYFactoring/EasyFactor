﻿//-----------------------------------------------------------------------
// <copyright file="CaseDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Collections.Generic;
    using System.Data.Linq;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// Case Detail
    /// </summary>
    public partial class CaseDetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (2)

        /// <summary>
        /// Operation type of Case
        /// </summary>
        private OpCaseType opCaseType;
        /// <summary>
        /// Operation type of Credit Cover Negotiation
        /// </summary>
        private OpCreditCoverNegType opCreditCoverNegType;

        private DBDataContext context;

        #endregion Fields

        #region Enums (2)

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

        #endregion Enums

        #region Constructors (4)

        /// <summary>
        /// Initializes a new instance of the CaseDetail class
        /// </summary>
        /// <param name="curCase">Selected case</param>
        /// <param name="opCaseType">operation type of Case</param>
        /// <param name="opCreditCoverNegType">operation type of CreditCoverNegotiation</param>
        private CaseDetail(Case curCase, OpCaseType opCaseType, OpCreditCoverNegType opCreditCoverNegType)
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.dgvCDAs.AutoGenerateColumns = false;
            this.dgvCreditCoverNegs.AutoGenerateColumns = false;

            this.cbCaseInvoiceCurrency.DataSource = Currency.AllCurrencies().ToList();
            this.cbCaseInvoiceCurrency.DisplayMember = "CurrencyFormat";
            this.cbCaseInvoiceCurrency.ValueMember = "CurrencyCode";

            this.cbCaseCoDepts.DataSource = Department.AllDepartments("贸易金融事业部").ToList();
            this.cbCaseCoDepts.ValueMember = "DepartmentCode";
            this.cbCaseCoDepts.DisplayMember = "DepartmentName";
            this.cbCaseCoDepts.SelectedIndex = -1;

            this.cbCaseOwnerDepts.DataSource = Department.AllDepartments();
            this.cbCaseOwnerDepts.DisplayMembers = "DepartmentName";
            this.cbCaseOwnerDepts.GroupingMembers = "Domain";
            this.cbCaseOwnerDepts.ValueMember = "DepartmentCode";
            this.cbCaseOwnerDepts.SelectedIndex = -1;

            this.opCaseType = opCaseType;
            this.opCreditCoverNegType = opCreditCoverNegType;

            this.cbReviews.DisplayMember = "ReviewNo";
            this.cbReviews.ValueMember = "ReviewNo";

            this.tbIFPrice.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.tbIFPrice.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

            if (opCaseType == OpCaseType.NEW_CASE)
            {
                curCase = new Case();
                curCase.CreateUserName = App.Current.CurUser.Name;
                curCase.CaseAppDate = DateTime.Now.Date;
                curCase.OperationType = "自营";
                curCase.CaseMark = "申请案";
                this.caseBindingSource.DataSource = curCase;
            }
            else
            {
                this.caseBindingSource.DataSource = curCase;
                this.dgvCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations;
                this.dgvCDAs.DataSource = curCase.CDAs;

                switch (curCase.TransactionType)
                {
                    case "国内卖方保理":
                    case "出口保理":
                    case "国内信保保理":
                    case "国际信保保理":
                    case "租赁保理":
                        this.tbCaseFactorCode.Text = curCase.BuyerFactor.FactorCode;
                        this.tbCaseFactorNameCN.Text = curCase.BuyerFactor.CompanyNameCN;
                        this.tbCaseFactorNameEN.Text = curCase.BuyerFactor.CompanyNameEN;
                        break;
                    case "国内买方保理":
                    case "进口保理":
                        this.tbCaseFactorCode.Text = curCase.SellerFactor.FactorCode;
                        this.tbCaseFactorNameCN.Text = curCase.SellerFactor.CompanyNameCN;
                        this.tbCaseFactorNameEN.Text = curCase.SellerFactor.CompanyNameEN;
                        break;
                    default: break;
                }

                this.cbReviews.DataSource = curCase.ClientReviews;

                List<Department> deptsList = (List<Department>)this.cbCaseOwnerDepts.DataSource;
                this.cbCaseOwnerDepts.SelectedIndex = deptsList.IndexOf(curCase.OwnerDepartment);
            }

            this.UpdateCaseControlStatus();
            this.UpdateCreditCoverNegControlStatus();
            this.context = new DBDataContext();

            if (opCreditCoverNegType == OpCreditCoverNegType.NEW_CREDIT_COVER_NEG)
            {
                this.tabControl.SelectedTab = this.tabItemCreditCoverNeg;
            }
        }

        /// <summary>
        /// Initializes a new instance of the CaseDetail class
        /// </summary>
        /// <param name="curCase">Selected case</param>
        /// <param name="opCaseType">Operation type of Case</param>
        public CaseDetail(Case curCase, OpCaseType opCaseType)
            : this(curCase, opCaseType, OpCreditCoverNegType.DETAIL_CREDIT_COVER_NEG)
        {
            this.tabControl.SelectedTab = this.tabItemCase;
        }

        /// <summary>
        /// Initializes a new instance of the CaseDetail class
        /// </summary>
        /// <param name="curCase">Selected case</param>
        /// <param name="opCreditCoverNegType">Operation type of CreditCoverNegotiation</param>
        public CaseDetail(Case curCase, OpCreditCoverNegType opCreditCoverNegType)
            : this(curCase, OpCaseType.DETAIL_CASE, opCreditCoverNegType)
        {
            this.tabControl.SelectedTab = this.tabItemCreditCoverNeg;
        }

        /// <summary>
        /// Initializes a new instance of the CaseDetail class
        /// </summary>
        /// <param name="neg"></param>
        /// <param name="opCreditCoverNegType"></param>
        public CaseDetail(CreditCoverNegotiation neg, OpCreditCoverNegType opCreditCoverNegType)
            : this(neg.Case, OpCaseType.DETAIL_CASE, opCreditCoverNegType)
        {
            this.tabControl.SelectedTab = this.tabItemCreditCoverNeg;
            if (opCreditCoverNegType == OpCreditCoverNegType.DETAIL_CREDIT_COVER_NEG || opCreditCoverNegType == OpCreditCoverNegType.UPDATE_CREDIT_COVER_NEG)
            {
                this.creditCoverNegBindingSource.DataSource = neg;
            }
        }

        #endregion Constructors

        #region Methods (26)

        // Private Methods (26) 

        /// <summary>
        /// Case operation type changed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseOpTypeChanged(object sender, EventArgs e)
        {
            string operationType = this.cbCaseOpType.Text;

            Case curCase = (Case)this.caseBindingSource.DataSource;

            if (operationType != curCase.OperationType)
            {
                if ("自营".Equals(operationType))
                {
                    this.cbCaseCoDepts.Enabled = false;
                    curCase.CoDepartment = null;
                }
                else
                {
                    this.cbCaseCoDepts.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Case owner deparment changed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseOwnerDeptsChanged(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            if (this.caseBindingSource.DataSource is Case)
            {
                Case curCase = (Case)this.caseBindingSource.DataSource;
                if (this.cbCaseOwnerDepts.SelectedNode != null)
                {
                    curCase.OwnerDepartment = (Department)this.cbCaseOwnerDepts.SelectedNode.DataKey;
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
            string transactionType = this.cbCaseTransactionType.Text;

            Case curCase = (Case)this.caseBindingSource.DataSource;

            Factor cmbc = Factor.FindFactorByCode(Factor.CMBC_CODE);
            switch (transactionType)
            {
                case "国内卖方保理":
                case "国内买方保理":
                case "租赁保理":
                    this.btnCaseFactorSelect.Enabled = false;
                    curCase.SellerFactor = cmbc;
                    curCase.BuyerFactor = cmbc;
                    curCase.InvoiceCurrency = "CNY";
                    this.cbCaseInvoiceCurrency.Enabled = false;
                    break;
                case "出口保理":
                    this.btnCaseFactorSelect.Enabled = true;
                    curCase.SellerFactor = cmbc;
                    curCase.InvoiceCurrency = "USD";
                    this.cbCaseInvoiceCurrency.Enabled = true;
                    break;
                case "进口保理":
                    this.btnCaseFactorSelect.Enabled = true;
                    curCase.BuyerFactor = cmbc;
                    curCase.InvoiceCurrency = "USD";
                    this.cbCaseInvoiceCurrency.Enabled = true;
                    break;
                case "国际信保保理":
                    this.btnCaseFactorSelect.Enabled = true;
                    curCase.SellerFactor = cmbc;
                    curCase.InvoiceCurrency = "USD";
                    this.cbCaseInvoiceCurrency.Enabled = true;
                    break;
                case "国内信保保理":
                    this.btnCaseFactorSelect.Enabled = true;
                    curCase.SellerFactor = cmbc;
                    curCase.InvoiceCurrency = "CNY";
                    this.cbCaseInvoiceCurrency.Enabled = false;
                    break;
                default: break;
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
        private void DeleteCDA(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CDA_UPDATE))
            {
                return;
            }

            if (this.dgvCDAs.SelectedRows.Count == 0)
            {
                return;
            }

            string cdaCode = (string)this.dgvCDAs["colCDACode", dgvCDAs.SelectedRows[0].Index].Value;
            if (cdaCode != null)
            {
                CDA selectedCDA = context.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                if (selectedCDA != null)
                {
                    if (MessageBox.Show("是否打算删除额度通知书: " + cdaCode, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    {
                        return;
                    }

                    bool isDeleteOK = true;

                    try
                    {
                        context.CDAs.DeleteOnSubmit(selectedCDA);
                        context.SubmitChanges();
                    }
                    catch (Exception e1)
                    {
                        isDeleteOK = false;
                        MessageBox.Show("不能删除此额度通知书: " + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (isDeleteOK)
                    {
                        MessageBox.Show("数据删除成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dgvCDAs.Rows.RemoveAt(this.dgvCDAs.SelectedRows[0].Index);
                    }
                }
            }
        }

        /// <summary>
        /// Delete current CreditCoverNegotiation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCreditCoverNeg(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBox.Show("请首先选择一个案子", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.creditCoverNegBindingSource.DataSource is CreditCoverNegotiation))
            {
                return;
            }

            CreditCoverNegotiation creditCoverNeg = (CreditCoverNegotiation)this.creditCoverNegBindingSource.DataSource;
            if (creditCoverNeg.NegoID == 0)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                context.CreditCoverNegotiations.DeleteOnSubmit(creditCoverNeg);
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBox.Show("数据删除成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations.ToList();
                this.creditCoverNegBindingSource.DataSource = new CreditCoverNegotiation();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailBuyer(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.BuyerClient == null)
            {
                return;
            }

            ClientDetail clientDetail = new ClientDetail(curCase.BuyerClient, ClientDetail.OpClientType.DETAIL_CLIENT);
            clientDetail.Show();
        }

        /// <summary>
        /// Show detail of the selected CDA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCDA(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCDAs.SelectedRows.Count == 0)
            {
                return;
            }

            string cdaCode = (string)this.dgvCDAs["colCDACode", dgvCDAs.SelectedRows[0].Index].Value;
            if (cdaCode != null)
            {
                CDA selectedCDA = context.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                if (selectedCDA != null)
                {
                    CDADetail cdaDetail = new CDADetail(selectedCDA, CDADetail.OpCDAType.DETAIL_CDA);
                    cdaDetail.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailFactor(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.TransactionType == null)
            {
                return;
            }

            Factor factor = null;
            switch (curCase.TransactionType)
            {
                case "国内卖方保理":
                case "出口保理":
                case "国内信保保理":
                case "国际信保保理":
                case "租赁保理":
                    factor = curCase.BuyerFactor;
                    break;
                case "国内买方保理":
                case "进口保理":
                    factor = curCase.SellerFactor;
                    break;
                default: break;
            }

            if (factor != null)
            {
                FactorDetail factorDetail = new FactorDetail(factor, FactorDetail.OpFactorType.DETAIL_FACTOR);
                factorDetail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailSeller(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.SellerClient == null)
            {
                return;
            }

            ClientDetail clientDetail = new ClientDetail(curCase.SellerClient, ClientDetail.OpClientType.DETAIL_CLIENT);
            clientDetail.Show();
        }

        /// <summary>
        /// Create new CDA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCDA(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CDA_UPDATE))
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBox.Show("请首先选择一个案子", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CDADetail cdaDetail = new CDADetail(curCase, CDADetail.OpCDAType.NEW_CDA);
            cdaDetail.Show(this);
        }

        /// <summary>
        /// Create new CreditCoverNegotiation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCreditCoverNeg(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBox.Show("请首先选择一个案子", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (curCase.TransactionType == "出口保理" || curCase.TransactionType == "进口保理" || curCase.TransactionType == "国际信保保理")
            {
                CreditCoverNegotiation creditCoverNeg = new CreditCoverNegotiation();
                creditCoverNeg.CreateUserName = App.Current.CurUser.Name;
                this.creditCoverNegBindingSource.DataSource = creditCoverNeg;
                this.opCreditCoverNegType = OpCreditCoverNegType.NEW_CREDIT_COVER_NEG;
                this.UpdateCreditCoverNegControlStatus();
            }
            else
            {
                MessageBox.Show("国内保理案不需要向国外保理商申请额度", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Refresh the CDA list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshCDAList(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBox.Show("请首先选择一个案子", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.dgvCDAs.DataSource = curCase.CDAs.ToList();
        }

        /// <summary>
        /// Refresh the CreditCoverNegotiation list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshCreditCoverNegList(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBox.Show("请首先选择一个案子", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.dgvCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations.ToList();
        }

        /// <summary>
        /// Close the case form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetCase(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            if (this.opCaseType == OpCaseType.UPDATE_CASE)
            {
                Case curCase = this.caseBindingSource.DataSource as Case;
                DBDataContext context = new DBDataContext();
                this.caseBindingSource.DataSource = context.Cases.SingleOrDefault(c => c.CaseCode == curCase.CaseCode);
            }
            else if (this.opCaseType == OpCaseType.NEW_CASE)
            {
                this.caseBindingSource.DataSource = new Case();
            }
        }

        /// <summary>
        /// Save current Case
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCase(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            if (!this.caseValidator.Validate())
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;

            if (curCase.CaseCode == null)
            {
                bool isAddOK = true;
                try
                {
                    curCase.CaseCode = curCase.GenerateCaseCode();
                    context.Cases.InsertOnSubmit(curCase);
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    curCase.CaseCode = null;
                    isAddOK = false;
                    MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.opCaseType = OpCaseType.UPDATE_CASE;
                }
            }
            else
            {
                bool isUpdateOK = true;
                if (curCase.CaseCode == null)
                {
                    return;
                }

                try
                {
                    context.Cases.Attach(curCase);
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
                    MessageBox.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    if (curCase.CaseMark == "已结案")
                    {
                        foreach (CDA cda in curCase.CDAs)
                        {
                            cda.CDAStatus = "已失效";
                        }

                        context.SubmitChanges();
                    }

                    MessageBox.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            if (!this.creditCoverValidator.Validate())
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBox.Show("请首先选择一个案子", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.creditCoverNegBindingSource.DataSource is CreditCoverNegotiation))
            {
                return;
            }

            CreditCoverNegotiation creditCoverNeg = (CreditCoverNegotiation)this.creditCoverNegBindingSource.DataSource;

            if (creditCoverNeg.NegoID == 0)
            {
                bool isAddOK = true;
                try
                {
                    creditCoverNeg.Case = curCase;
                    context.CreditCoverNegotiations.InsertOnSubmit(creditCoverNeg);
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    creditCoverNeg.Case = null;
                    isAddOK = false;
                    MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgvCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations.ToList();
                    this.NewCreditCoverNeg(null, null);
                }
            }
            else
            {
                bool isUpdateOK = true;
                try
                {
                    context.CreditCoverNegotiations.Attach(creditCoverNeg);
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
                    MessageBox.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgvCreditCoverNegs.Refresh();
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
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            ClientMgr clientMgr = new ClientMgr();
            QueryForm queryUI = new QueryForm(clientMgr, "选择买方");
            clientMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            if (clientMgr.Selected != null)
            {
                curCase.BuyerClient = clientMgr.Selected;
                switch (this.cbCaseTransactionType.Text)
                {
                    case "国内卖方保理":
                    case "国内信保保理":
                    case "国际信保保理":
                    case "租赁保理":
                    case "出口保理":
                        break;
                    case "国内买方保理":
                    case "进口保理":
                        curCase.OwnerDepartment = curCase.BuyerClient.Department;
                        List<Department> deptsList = (List<Department>)this.cbCaseOwnerDepts.DataSource;
                        this.cbCaseOwnerDepts.SelectedIndex = deptsList.IndexOf(curCase.OwnerDepartment);
                        this.cbReviews.DataSource = curCase.ClientReviews;
                        break;
                    default: break;
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
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            ClientMgr clientMgr = new ClientMgr();
            QueryForm queryUI = new QueryForm(clientMgr, "选择卖方");
            clientMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            if (clientMgr.Selected != null)
            {
                curCase.SellerClient = clientMgr.Selected;
                switch (this.cbCaseTransactionType.Text)
                {
                    case "国内卖方保理":
                    case "国内信保保理":
                    case "国际信保保理":
                    case "租赁保理":
                    case "出口保理":
                        curCase.OwnerDepartment = curCase.SellerClient.Department;
                        List<Department> deptsList = (List<Department>)this.cbCaseOwnerDepts.DataSource;
                        this.cbCaseOwnerDepts.SelectedIndex = deptsList.IndexOf(curCase.OwnerDepartment);
                        this.cbReviews.DataSource = curCase.ClientReviews;
                        break;
                    case "国内买方保理":
                    case "进口保理":
                        break;
                    default: break;
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
            if (this.dgvCreditCoverNegs.SelectedRows.Count == 0)
            {
                return;
            }

            int cid = (int)this.dgvCreditCoverNegs["colNegoID", dgvCreditCoverNegs.SelectedRows[0].Index].Value;
            if (cid != 0)
            {
                CreditCoverNegotiation selectedCreditCoverNeg = context.CreditCoverNegotiations.SingleOrDefault(c => c.NegoID == cid);
                if (selectedCreditCoverNeg != null)
                {
                    this.creditCoverNegBindingSource.DataSource = selectedCreditCoverNeg;
                }
            }
        }

        /// <summary>
        /// Select the factor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFactor(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            FactorMgr factorMgr = new FactorMgr();
            QueryForm queryUI = new QueryForm(factorMgr, "选择保理商");
            factorMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);

            Factor factor = factorMgr.Selected;
            if (factor != null)
            {
                this.tbCaseFactorCode.Text = factor.FactorCode;
                this.tbCaseFactorNameCN.Text = factor.CompanyNameCN;
                this.tbCaseFactorNameEN.Text = factor.CompanyNameEN;

                switch (this.cbCaseTransactionType.Text)
                {
                    case "国内卖方保理":
                    case "出口保理":
                    case "国内信保保理":
                    case "国际信保保理":
                    case "租赁保理":
                        curCase.BuyerFactor = factor;
                        break;
                    case "国内买方保理":
                    case "进口保理":
                        curCase.SellerFactor = factor;
                        break;
                    default: break;
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
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBox.Show("请首先选择一个案子", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.opCaseType = OpCaseType.UPDATE_CASE;
            this.UpdateCaseControlStatus();
        }

        /// <summary>
        /// Update case control status
        /// </summary>
        private void UpdateCaseControlStatus()
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;

            if (this.opCaseType == OpCaseType.NEW_CASE)
            {
                foreach (Control comp in this.groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                this.btnCaseBuyerSelect.Visible = true;
                this.btnCaseFactorSelect.Visible = true;
                this.btnCaseSellerSelect.Visible = true;
            }
            else if (this.opCaseType == OpCaseType.UPDATE_CASE)
            {
                foreach (Control comp in this.groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                this.btnCaseBuyerSelect.Visible = true;
                this.btnCaseFactorSelect.Visible = true;
                this.btnCaseSellerSelect.Visible = true;

                if ("自营".Equals(curCase.OperationType))
                {
                    this.cbCaseCoDepts.Enabled = false;
                }
                else
                {
                    this.cbCaseCoDepts.Enabled = true;
                }
            }
            else if (this.opCaseType == OpCaseType.DETAIL_CASE)
            {
                foreach (Control comp in this.groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                this.btnCaseBuyerSelect.Visible = false;
                this.btnCaseFactorSelect.Visible = false;
                this.btnCaseSellerSelect.Visible = false;
            }

            this.tbCaseCreateUser.ReadOnly = true;
            this.tbCaseCode.ReadOnly = true;
            this.tbCaseSellerNo.ReadOnly = true;
            this.tbCaseSellerNameCN.ReadOnly = true;
            this.tbCaseSellerNameEN.ReadOnly = true;
            this.tbCaseBuyerNo.ReadOnly = true;
            this.tbCaseBuyerNameCN.ReadOnly = true;
            this.tbCaseBuyerNameEN.ReadOnly = true;
            this.tbCaseFactorCode.ReadOnly = true;
            this.tbCaseFactorNameCN.ReadOnly = true;
            this.tbCaseFactorNameEN.ReadOnly = true;
        }

        /// <summary>
        /// Turn CreditCoverNegotiation into update status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCreditCoverNeg(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBox.Show("请首先选择一个案子", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.creditCoverNegBindingSource.DataSource is CreditCoverNegotiation))
            {
                return;
            }

            this.opCreditCoverNegType = OpCreditCoverNegType.UPDATE_CREDIT_COVER_NEG;
            this.UpdateCreditCoverNegControlStatus();
        }

        /// <summary>
        /// Update CreditCoverNegotiation Control Status
        /// </summary>
        private void UpdateCreditCoverNegControlStatus()
        {
            if (this.opCreditCoverNegType == OpCreditCoverNegType.DETAIL_CREDIT_COVER_NEG)
            {
                foreach (Control comp in this.groupPanelCreditCoverNeg.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (this.opCreditCoverNegType == OpCreditCoverNegType.NEW_CREDIT_COVER_NEG)
            {
                foreach (Control comp in this.groupPanelCreditCoverNeg.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (this.opCreditCoverNegType == OpCreditCoverNegType.UPDATE_CREDIT_COVER_NEG)
            {
                foreach (Control comp in this.groupPanelCreditCoverNeg.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }

            this.tbCreateUserName.ReadOnly = true;
        }

        #endregion Methods
    }
}

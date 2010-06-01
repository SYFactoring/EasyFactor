//-----------------------------------------------------------------------
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
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;
    using CMBC.EasyFactor.ARMgr;

    /// <summary>
    /// Case Detail
    /// </summary>
    public partial class CaseDetail : DevComponents.DotNetBar.Office2007Form
    {
        #region?Fields?(3)?

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bsCreditCoverNegs;

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bsCDAs;

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bsCommissionRemit;
        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;
        /// <summary>
        /// Operation type of Case
        /// </summary>
        private OpCaseType opCaseType;
        /// <summary>
        /// Operation type of Credit Cover Negotiation
        /// </summary>
        private OpCreditCoverNegType opCreditCoverNegType;

        /// <summary>
        /// Operation type of Commission Remit
        /// </summary>
        private OpCommissionRemitType opCommissionRemitType;

        #endregion?Fields?

        #region?Enums?(2)?

        /// <summary>
        /// 
        /// </summary>
        public enum OpCommissionRemitType
        {
            /// <summary>
            /// 
            /// </summary>
            NEW_COMMISSION_REMIT,

            /// <summary>
            /// 
            /// </summary>
            UPDATE_COMMISSION_REMIT,

            /// <summary>
            /// 
            /// </summary>
            DETAIL_COMMISSION_REMIT
        }

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

        #endregion?Enums?

        #region?Constructors?(4)?

        /// <summary>
        /// Initializes a new instance of the CaseDetail class
        /// </summary>
        /// <param name="curCase">Selected case</param>
        /// <param name="opCaseType">operation type of Case</param>
        /// <param name="opCreditCoverNegType">operation type of CreditCoverNegotiation</param>
        /// <param name="opCommissionRemit">operation type of CommisionRemit</param>
        private CaseDetail(Case curCase, OpCaseType opCaseType, OpCreditCoverNegType opCreditCoverNegType, OpCommissionRemitType opCommissionRemitType)
        {
            this.InitializeComponent();
            this.bsCDAs = new BindingSource();
            this.bsCreditCoverNegs = new BindingSource();
            this.bsCommissionRemit = new BindingSource();
            this.ImeMode = ImeMode.OnHalf;
            this.dgvCDAs.AutoGenerateColumns = false;
            this.dgvCreditCoverNegs.AutoGenerateColumns = false;
            this.dgvCommissionRemit.AutoGenerateColumns = false;
            this.dgvCDAs.DataSource = this.bsCDAs;
            this.dgvCreditCoverNegs.DataSource = this.bsCreditCoverNegs;
            this.dgvCommissionRemit.DataSource = this.bsCommissionRemit;
            this.context = new DBDataContext();

            this.cbCaseInvoiceCurrency.DataSource = Currency.AllCurrencies;
            this.cbCaseInvoiceCurrency.DisplayMember = "CurrencyFormat";
            this.cbCaseInvoiceCurrency.ValueMember = "CurrencyCode";

            this.cbMsgCurrency.DataSource = Currency.AllCurrencies;
            this.cbMsgCurrency.DisplayMember = "CurrencyFormat";
            this.cbMsgCurrency.ValueMember = "CurrencyCode";

            this.cbRemitCurrency.DataSource = Currency.AllCurrencies;
            this.cbRemitCurrency.DisplayMember = "CurrencyFormat";
            this.cbRemitCurrency.ValueMember = "CurrencyCode";

            List<Department> allDepartments = Department.AllDepartments(this.context);
            this.cbCaseOwnerDepts.DataSource = allDepartments;
            this.cbCaseOwnerDepts.DisplayMembers = "DepartmentName";
            this.cbCaseOwnerDepts.GroupingMembers = "Domain";
            this.cbCaseOwnerDepts.ValueMember = "DepartmentCode";
            this.cbCaseOwnerDepts.SelectedIndex = -1;

            this.opCaseType = opCaseType;
            this.opCreditCoverNegType = opCreditCoverNegType;
            this.opCommissionRemitType = opCommissionRemitType;

            this.cbReviews.DisplayMember = "ReviewNo";
            this.cbReviews.ValueMember = "ReviewNo";

            this.tbIFPrice.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.tbIFPrice.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

            if (opCaseType == OpCaseType.NEW_CASE)
            {
                curCase = new Case();
                curCase.CreateUserName = App.Current.CurUser.Name;
                curCase.CaseAppDate = DateTime.Now.Date;
                curCase.OperationType = "��Ӫ";
                curCase.CaseMark = "���밸";
                this.caseBindingSource.DataSource = curCase;
            }
            else
            {
                curCase = this.context.Cases.SingleOrDefault(c => c.CaseCode == curCase.CaseCode);
                this.caseBindingSource.DataSource = curCase;
                this.bsCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations;
                this.bsCDAs.DataSource = curCase.CDAs;
                this.bsCommissionRemit.DataSource = curCase.InvoiceAssignBatches;

                switch (curCase.TransactionType)
                {
                    case "������������":
                    case "���ڱ���":
                        this.tbCaseFactorCode.Text = curCase.BuyerFactor.FactorCode;
                        this.tbCaseFactorNameCN.Text = curCase.BuyerFactor.CompanyNameCN;
                        this.tbCaseFactorNameEN.Text = curCase.BuyerFactor.CompanyNameEN;
                        break;
                    case "�����򷽱���":
                    case "���ڱ���":
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

            if (opCreditCoverNegType == OpCreditCoverNegType.NEW_CREDIT_COVER_NEG)
            {
                this.tabControl.SelectedTab = this.tabItemCreditCoverNeg;
            }

            if (opCommissionRemitType == OpCommissionRemitType.NEW_COMMISSION_REMIT)
            {
                this.tabControl.SelectedTab = this.tabItemCommissionRemit;
            }

            InvoiceMgr invoiceMgr = new InvoiceMgr(curCase.GetInvoices(), context);
            invoiceMgr.Dock = DockStyle.Fill;
            this.tabPanelInvoice.Controls.Add(invoiceMgr);

            this.UpdateCaseControlStatus();
            this.UpdateCreditCoverNegControlStatus();
            this.UpdateCommissionRemitControlStatus();
        }

        /// <summary>
        /// Initializes a new instance of the CaseDetail class
        /// </summary>
        /// <param name="curCase">Selected case</param>
        /// <param name="opCaseType">Operation type of Case</param>
        public CaseDetail(Case curCase, OpCaseType opCaseType)
            : this(curCase, opCaseType, OpCreditCoverNegType.DETAIL_CREDIT_COVER_NEG, OpCommissionRemitType.DETAIL_COMMISSION_REMIT)
        {
            this.tabControl.SelectedTab = this.tabItemCase;
        }

        /// <summary>
        /// Initializes a new instance of the CaseDetail class
        /// </summary>
        /// <param name="curCase">Selected case</param>
        /// <param name="opCreditCoverNegType">Operation type of CreditCoverNegotiation</param>
        public CaseDetail(Case curCase, OpCreditCoverNegType opCreditCoverNegType)
            : this(curCase, OpCaseType.DETAIL_CASE, opCreditCoverNegType, OpCommissionRemitType.DETAIL_COMMISSION_REMIT)
        {
            this.tabControl.SelectedTab = this.tabItemCreditCoverNeg;
        }

        /// <summary>
        /// Initializes a new instance of the CaseDetail class
        /// </summary>
        /// <param name="neg"></param>
        /// <param name="opCreditCoverNegType"></param>
        public CaseDetail(CreditCoverNegotiation neg, OpCreditCoverNegType opCreditCoverNegType)
            : this(neg.Case, OpCaseType.DETAIL_CASE, opCreditCoverNegType, OpCommissionRemitType.DETAIL_COMMISSION_REMIT)
        {
            this.tabControl.SelectedTab = this.tabItemCreditCoverNeg;
            if (neg == null)
            {
                return;
            }

            if (opCreditCoverNegType == OpCreditCoverNegType.DETAIL_CREDIT_COVER_NEG || opCreditCoverNegType == OpCreditCoverNegType.UPDATE_CREDIT_COVER_NEG)
            {
                neg = this.context.CreditCoverNegotiations.SingleOrDefault(n => n.NegoID == neg.NegoID);
                this.creditCoverNegBindingSource.DataSource = neg;
            }
        }

        public CaseDetail(CommissionRemittance commissionRemit, OpCommissionRemitType opCommissionRemitType)
            : this(commissionRemit.Case, OpCaseType.DETAIL_CASE, OpCreditCoverNegType.DETAIL_CREDIT_COVER_NEG, opCommissionRemitType)
        {
            this.tabControl.SelectedTab = this.tabItemCommissionRemit;
            if (commissionRemit == null)
            {
                return;
            }

            if (opCommissionRemitType == OpCommissionRemitType.DETAIL_COMMISSION_REMIT || opCommissionRemitType == OpCommissionRemitType.UPDATE_COMMISSION_REMIT)
            {
                commissionRemit = this.context.CommissionRemittances.SingleOrDefault(c => c.MsgID == commissionRemit.MsgID);
                this.commissionRemitBindingSource.DataSource = commissionRemit;
            }
        }
        #endregion?Constructors?

        #region?Methods?(24)?

        //?Private?Methods?(24)?

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

            Factor cmbc = this.context.Factors.SingleOrDefault(f => f.FactorCode == Factor.CMBC_CODE);
            switch (transactionType)
            {
                case "������������":
                case "�����򷽱���":
                    this.btnCaseFactorSelect.Enabled = false;
                    curCase.SellerFactor = cmbc;
                    curCase.BuyerFactor = cmbc;
                    curCase.InvoiceCurrency = "CNY";
                    this.cbCaseInvoiceCurrency.Enabled = false;
                    break;
                case "���ڱ���":
                    this.btnCaseFactorSelect.Enabled = true;
                    curCase.SellerFactor = cmbc;
                    curCase.InvoiceCurrency = "USD";
                    this.cbCaseInvoiceCurrency.Enabled = true;
                    break;
                case "���ڱ���":
                    this.btnCaseFactorSelect.Enabled = true;
                    curCase.BuyerFactor = cmbc;
                    curCase.InvoiceCurrency = "USD";
                    this.cbCaseInvoiceCurrency.Enabled = true;
                    break;
                default: break;
            }

            if (!"���ڱ���".Equals(curCase.TransactionType) && curCase.SellerClient != null)
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
        private void customValidator1_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;
            string[] caseTypes = new string[] { "���ڱ���", "���ڱ���" };
            if (caseTypes.Contains(curCase.TransactionType))
            {
                if (!String.IsNullOrEmpty(this.tbCaseFactorCode.Text))
                {
                    e.IsValid = true;
                }
                else
                {
                    e.IsValid = false;
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
        private void DeleteCDA(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CDA_UPDATE))
            {
                return;
            }

            if (this.dgvCDAs.SelectedRows.Count == 0)
            {
                return;
            }

            CDA selectedCDA = (CDA)this.bsCDAs.List[this.dgvCDAs.SelectedRows[0].Index];
            if (MessageBoxEx.Show("�Ƿ����ɾ�����֪ͨ��: " + selectedCDA.CDACode, MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;

            try
            {
                this.context.CDAs.DeleteOnSubmit(selectedCDA);
                this.context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show("����ɾ���˶��֪ͨ��: " + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("����ɾ���ɹ�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvCDAs.Rows.RemoveAt(this.dgvCDAs.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCommissionRemit(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("������ѡ��һ������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.commissionRemitBindingSource.DataSource is CommissionRemittance))
            {
                return;
            }

            CommissionRemittance commissionRemit = (CommissionRemittance)this.commissionRemitBindingSource.DataSource;
            if (commissionRemit.MsgID == 0)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                this.context.CommissionRemittances.DeleteOnSubmit(commissionRemit);
                this.context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("����ɾ���ɹ�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bsCommissionRemit.DataSource = curCase.InvoiceAssignBatches.ToList();
                this.commissionRemitBindingSource.DataSource = new CommissionRemittance();
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

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("������ѡ��һ������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                this.context.CreditCoverNegotiations.DeleteOnSubmit(creditCoverNeg);
                this.context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("����ɾ���ɹ�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bsCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations.ToList();
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
            clientDetail.ShowDialog(this);
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

            CDA selectedCDA = (CDA)this.bsCDAs.List[this.dgvCDAs.SelectedRows[0].Index];
            CDADetail cdaDetail = new CDADetail(selectedCDA, CDADetail.OpCDAType.DETAIL_CDA);
            cdaDetail.ShowDialog(this);
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
                case "������������":
                case "���ڱ���":
                    factor = curCase.BuyerFactor;
                    break;
                case "�����򷽱���":
                case "���ڱ���":
                    factor = curCase.SellerFactor;
                    break;
                default: break;
            }

            if (factor != null)
            {
                FactorDetail factorDetail = new FactorDetail(factor, FactorDetail.OpFactorType.DETAIL_FACTOR);
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
            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.SellerClient == null)
            {
                return;
            }

            ClientDetail clientDetail = new ClientDetail(curCase.SellerClient, ClientDetail.OpClientType.DETAIL_CLIENT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCDAs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = this.dgvCDAs.Columns[e.ColumnIndex];
            if (column == colIsRecoarse)
            {
                Object originalData = e.Value;
                if (originalData != null)
                {
                    bool result = (bool)originalData;
                    if (result)
                    {
                        e.Value = "Y";
                    }
                    else
                    {
                        e.Value = "N";
                    }
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

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("������ѡ��һ������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CDADetail cdaDetail = new CDADetail(curCase, CDADetail.OpCDAType.NEW_CDA);
            cdaDetail.Show(this);
        }

        /// <summary>
        /// Create new CommissionRemittance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCommissionRemit(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("������ѡ��һ������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (curCase.TransactionType == "���ڱ���" || curCase.TransactionType == "���ڱ���")
            {
                CommissionRemittance commissionRemit = new CommissionRemittance();
                commissionRemit.CreateUserName = App.Current.CurUser.Name;
                this.commissionRemitBindingSource.DataSource = commissionRemit;
                this.opCommissionRemitType = OpCommissionRemitType.NEW_COMMISSION_REMIT;
                this.UpdateCommissionRemitControlStatus();
            }
            else
            {
                MessageBoxEx.Show("���ڱ�������Ҫ������ո�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("������ѡ��һ������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (curCase.TransactionType == "���ڱ���" || curCase.TransactionType == "���ڱ���")
            {
                CreditCoverNegotiation creditCoverNeg = new CreditCoverNegotiation();
                creditCoverNeg.CreateUserName = App.Current.CurUser.Name;
                this.creditCoverNegBindingSource.DataSource = creditCoverNeg;
                this.opCreditCoverNegType = OpCreditCoverNegType.NEW_CREDIT_COVER_NEG;
                this.UpdateCreditCoverNegControlStatus();
            }
            else
            {
                MessageBoxEx.Show("���ڱ�������Ҫ����Ᵽ����������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBoxEx.Show("������ѡ��һ������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.bsCDAs.DataSource = curCase.CDAs.ToList();
        }

        /// <summary>
        /// Refresh the CommissionRemit list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshCommissionRemitList(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("������ѡ��һ������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.bsCommissionRemit.DataSource = curCase.InvoiceAssignBatches.ToList();
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
                MessageBoxEx.Show("������ѡ��һ������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.bsCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations.ToList();
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

            if (!this.caseValidator.Validate())
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            curCase.CreateUserName = App.Current.CurUser.Name;

            if (curCase.CaseCode == null)
            {
                bool isAddOK = true;
                try
                {
                    curCase.CaseCode = Case.GenerateCaseCode(curCase.TransactionType, curCase.OwnerDepartment.LocationCode, curCase.CaseAppDate);
                    this.context.Cases.InsertOnSubmit(curCase);
                    this.context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    curCase.CaseCode = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("�����½��ɹ�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    this.context.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    foreach (ObjectChangeConflict cc in this.context.ChangeConflicts)
                    {
                        foreach (MemberChangeConflict mc in cc.MemberConflicts)
                        {
                            mc.Resolve(RefreshMode.KeepChanges);
                        }
                    }

                    this.context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    if (curCase.CaseMark == "�ѽ᰸")
                    {
                        foreach (CDA cda in curCase.CDAs)
                        {
                            cda.CDAStatus = "��ʧЧ";
                        }

                        try
                        {
                            this.context.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    MessageBoxEx.Show("���ݸ��³ɹ�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Save current CommissionRemit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCommissionRemit(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            if (!this.commissionRemitValidator.Validate())
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("������ѡ��һ������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.commissionRemitBindingSource.DataSource is CommissionRemittance))
            {
                return;
            }

            CommissionRemittance commissionRemit = (CommissionRemittance)this.commissionRemitBindingSource.DataSource;
            commissionRemit.CreateUserName = App.Current.CurUser.Name;

            if (commissionRemit.MsgID == 0)
            {
                bool isAddOK = true;
                try
                {
                    commissionRemit.Case = curCase;
                    this.context.CommissionRemittances.InsertOnSubmit(commissionRemit);
                    this.context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    commissionRemit.Case = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("�����½��ɹ�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.bsCommissionRemit.DataSource = curCase.InvoiceAssignBatches.ToList();
                    this.NewCommissionRemit(null, null);
                }
            }
            else
            {
                bool isUpdateOK = true;
                try
                {
                    this.context.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    foreach (ObjectChangeConflict cc in this.context.ChangeConflicts)
                    {
                        foreach (MemberChangeConflict mc in cc.MemberConflicts)
                        {
                            mc.Resolve(RefreshMode.KeepChanges);
                        }
                    }

                    this.context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show("���ݸ��³ɹ�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgvCommissionRemit.Refresh();
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

            if (!this.creditCoverValidator.Validate())
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("������ѡ��һ������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.creditCoverNegBindingSource.DataSource is CreditCoverNegotiation))
            {
                return;
            }

            CreditCoverNegotiation creditCoverNeg = (CreditCoverNegotiation)this.creditCoverNegBindingSource.DataSource;
            creditCoverNeg.CreateUserName = App.Current.CurUser.Name;

            if (creditCoverNeg.NegoID == 0)
            {
                bool isAddOK = true;
                try
                {
                    creditCoverNeg.Case = curCase;
                    this.context.CreditCoverNegotiations.InsertOnSubmit(creditCoverNeg);
                    this.context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    creditCoverNeg.Case = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("�����½��ɹ�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.bsCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations.ToList();
                    this.NewCreditCoverNeg(null, null);
                }
            }
            else
            {
                bool isUpdateOK = true;
                try
                {
                    this.context.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    foreach (ObjectChangeConflict cc in this.context.ChangeConflicts)
                    {
                        foreach (MemberChangeConflict mc in cc.MemberConflicts)
                        {
                            mc.Resolve(RefreshMode.KeepChanges);
                        }
                    }

                    this.context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show("���ݸ��³ɹ�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            ClientMgr clientMgr = new ClientMgr();
            QueryForm queryUI = new QueryForm(clientMgr, "ѡ����");
            clientMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            if (clientMgr.Selected != null)
            {
                curCase.BuyerClient = this.context.Clients.SingleOrDefault(c => c.ClientEDICode == clientMgr.Selected.ClientEDICode);
                switch (this.cbCaseTransactionType.Text)
                {
                    case "������������":
                    case "���ڱ���":
                        break;
                    case "�����򷽱���":
                    case "���ڱ���":
                        curCase.OwnerDepartment = curCase.BuyerClient.Department;
                        if (curCase.OwnerDepartment != null)
                        {
                            if (!curCase.OwnerDepartment.DepartmentName.Contains("ó��"))
                            {
                                curCase.OperationType = "Э��";
                            }
                            List<Department> deptsList = (List<Department>)this.cbCaseOwnerDepts.DataSource;
                            this.cbCaseOwnerDepts.SelectedIndex = deptsList.IndexOf(curCase.OwnerDepartment);
                        }

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
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            ClientMgr clientMgr = new ClientMgr();
            QueryForm queryUI = new QueryForm(clientMgr, "ѡ������");
            clientMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            if (clientMgr.Selected != null)
            {
                curCase.SellerClient = this.context.Clients.SingleOrDefault(c => c.ClientEDICode == clientMgr.Selected.ClientEDICode);
                switch (this.cbCaseTransactionType.Text)
                {
                    case "������������":
                    case "���ڱ���":
                        curCase.OwnerDepartment = curCase.SellerClient.Department;
                        if (curCase.OwnerDepartment != null)
                        {
                            if (!curCase.OwnerDepartment.DepartmentName.Contains("ó��"))
                            {
                                curCase.OperationType = "Э��";
                            }

                            List<Department> deptsList = (List<Department>)this.cbCaseOwnerDepts.DataSource;
                            this.cbCaseOwnerDepts.SelectedIndex = deptsList.IndexOf(curCase.OwnerDepartment);
                        }

                        this.cbReviews.DataSource = curCase.ClientReviews;
                        break;
                    case "�����򷽱���":
                    case "���ڱ���":
                        break;
                    default: break;
                }
            }
        }

        /// <summary>
        /// Select CommissionRemit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCommissionRemit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCommissionRemit.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceAssignBatch invoiceAssignBatch = (InvoiceAssignBatch)this.bsCommissionRemit.List[this.dgvCommissionRemit.SelectedRows[0].Index];
            CommissionRemittance commissionRemit = invoiceAssignBatch.CommissionRemitteance;
            if (commissionRemit != null)
            {
                this.commissionRemitBindingSource.DataSource = commissionRemit;
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

            CreditCoverNegotiation selectedCreditCoverNeg = (CreditCoverNegotiation)this.bsCreditCoverNegs.List[this.dgvCreditCoverNegs.SelectedRows[0].Index];
            this.creditCoverNegBindingSource.DataSource = selectedCreditCoverNeg;
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

            Case curCase = (Case)this.caseBindingSource.DataSource;
            FactorMgr factorMgr = new FactorMgr();
            QueryForm queryUI = new QueryForm(factorMgr, "ѡ������");
            factorMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);

            Factor factor = factorMgr.Selected;
            if (factor != null)
            {
                factor = this.context.Factors.SingleOrDefault(f => f.FactorCode == factor.FactorCode);
                this.tbCaseFactorCode.Text = factor.FactorCode;
                this.tbCaseFactorNameCN.Text = factor.CompanyNameCN;
                this.tbCaseFactorNameEN.Text = factor.CompanyNameEN;

                switch (this.cbCaseTransactionType.Text)
                {
                    case "������������":
                    case "���ڱ���":
                        curCase.BuyerFactor = factor;
                        break;
                    case "�����򷽱���":
                    case "���ڱ���":
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
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("������ѡ��һ������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// Turn CommissionRemit into update status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCommissionRemit(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("������ѡ��һ������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.commissionRemitBindingSource.DataSource is CommissionRemittance))
            {
                return;
            }

            this.opCommissionRemitType = OpCommissionRemitType.UPDATE_COMMISSION_REMIT;
            this.UpdateCommissionRemitControlStatus();
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

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBoxEx.Show("������ѡ��һ������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// Update CommissionRemit Control Status
        /// </summary>
        private void UpdateCommissionRemitControlStatus()
        {
            if (this.opCommissionRemitType == OpCommissionRemitType.DETAIL_COMMISSION_REMIT)
            {
                foreach (Control comp in this.groupPanelCommissionRemit.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (this.opCommissionRemitType == OpCommissionRemitType.NEW_COMMISSION_REMIT)
            {
                foreach (Control comp in this.groupPanelCommissionRemit.Controls)
                {
                    ControlUtil.SetComponetDefault(comp);
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (this.opCommissionRemitType == OpCommissionRemitType.UPDATE_COMMISSION_REMIT)
            {
                foreach (Control comp in this.groupPanelCommissionRemit.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }

            ControlUtil.SetComponetEditable(this.tbCreditCoverCreateUserName, false);
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
                    ControlUtil.SetComponetDefault(comp);
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (this.opCreditCoverNegType == OpCreditCoverNegType.UPDATE_CREDIT_COVER_NEG)
            {
                foreach (Control comp in this.groupPanelCreditCoverNeg.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }

            ControlUtil.SetComponetEditable(this.tbCreditCoverCreateUserName, false);
        }

        #endregion?Methods?
    }
}

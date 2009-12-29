//-----------------------------------------------------------------------
// <copyright file="CaseDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.Utils;
    using DevComponents.Editors;

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

        #region Constructors (3)

        /// <summary>
        /// Initializes a new instance of the CaseDetail class
        /// </summary>
        /// <param name="curCase">Selected case</param>
        /// <param name="opCaseType">operation type of Case</param>
        /// <param name="opCreditCoverNegType">operation type of CreditCoverNegotiation</param>
        private CaseDetail(Case curCase, OpCaseType opCaseType, OpCreditCoverNegType opCreditCoverNegType)
        {
            this.InitializeComponent();

            this.cbCaseInvoiceCurrency.DataSource = Currency.AllCurrencies().ToList();
            this.cbCaseInvoiceCurrency.DisplayMember = "CurrencyFormat";
            this.cbCaseInvoiceCurrency.ValueMember = "CurrencyCode";

            this.cbCaseTransactionType.DataSource = Case.ConstantTransTypes();

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

            if (opCaseType == OpCaseType.NEW_CASE)
            {
                curCase = new Case();
                curCase.CreateUserName = App.Current.CurUser.Name;
                curCase.CaseAppDate = DateTime.Now;
                this.caseBindingSource.DataSource = curCase;
            }
            else
            {
                this.caseBindingSource.DataSource = curCase;
                this.dgvCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations;
                this.dgvCDAs.DataSource = curCase.CDAs;

                List<Department> deptsList = (List<Department>)this.cbCaseOwnerDepts.DataSource;
                this.cbCaseOwnerDepts.SelectedIndex = deptsList.IndexOf(curCase.OwnerDepartment);
                curCase.Backup();
            }

            curCase.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(curCase_PropertyChanged);
            this.UpdateCaseControlStatus();
            this.UpdateCreditCoverNegControlStatus();

            if (opCreditCoverNegType == OpCreditCoverNegType.NEW_CREDIT_COVER_NEG)
            {
                this.tabControl.SelectedTab = this.tabItemCreditCoverNeg;
            }
        }

        void curCase_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ("TransactionType".Equals(e.PropertyName))
            {
                Case curCase = sender as Case;
                Factor cmbc = Factor.FindFactorByCode(Factor.CMBC_CODE);
                switch (curCase.TransactionType)
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
                    if (!curCase.SellerClient.Contracts.Any(con => con.ContractStatus == "已生效"))
                    {
                        curCase.SellerClient = null;
                    }
                }
 
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

        #endregion Constructors

        #region Methods (23)

        // Private Methods (23) 

        /// <summary>
        /// Leave event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseDetail_Leave(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (this.opCaseType == OpCaseType.UPDATE_CASE)
            {
                curCase.Restore();
            }

            if (this.opCreditCoverNegType == OpCreditCoverNegType.UPDATE_CREDIT_COVER_NEG)
            {
                if (this.creditCoverNegBindingSource.DataSource is CreditCoverNegotiation)
                {
                    CreditCoverNegotiation creditCoverNeg = (CreditCoverNegotiation)this.creditCoverNegBindingSource.DataSource;
                    if (creditCoverNeg.NegoID != 0)
                    {
                        creditCoverNeg.Restore();
                    }
                }
            }
            Close();
        }

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
        /// Close the case form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetClose(object sender, EventArgs e)
        {
            if (opCaseType == OpCaseType.UPDATE_CASE)
            {
                Case curCase = this.caseBindingSource.DataSource as Case;
                curCase.Restore();
            }
            else if (opCaseType == OpCaseType.NEW_CASE)
            {
                this.caseBindingSource.DataSource = new Case();
            }
        }

        /// <summary>
        /// Delete current CreditCoverNegotiation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCreditCoverNeg(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBox.Show("请首先选择一个案子", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                App.Current.DbContext.CreditCoverNegotiations.DeleteOnSubmit(creditCoverNeg);
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBox.Show(e1.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBox.Show("数据删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations.ToList();
                this.creditCoverNegBindingSource.DataSource = new CreditCoverNegotiation();
            }
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

            string cdaCode = (String)dgvCDAs["colCDACode", dgvCDAs.SelectedRows[0].Index].Value;
            if (cdaCode != null)
            {
                CDA selectedCDA = App.Current.DbContext.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                if (selectedCDA != null)
                {
                    CDADetail cdaDetail = new CDADetail(selectedCDA, CDADetail.OpCDAType.DETAIL_CDA);
                    cdaDetail.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Generate Case code
        /// </summary>
        /// <returns></returns>
        private string GenerateCaseCode(Case curCase)
        {
            string caseCode = null;
            string yearMonth = String.Format("{0:yyyy}{0:MM}", DateTime.Today);
            switch (curCase.TransactionType)
            {
                case "国内卖方保理":

                case "国内买方保理":
                    caseCode = "LF" + yearMonth + "-" + String.Format("{0:D4}", App.Current.DbContext.Cases.Count(c => c.CaseCode.StartsWith("LF" + yearMonth)) + 1);
                    break;
                case "出口保理":
                    caseCode = "EF" + yearMonth + "-" + String.Format("{0:D4}", App.Current.DbContext.Cases.Count(c => c.CaseCode.StartsWith("LF" + yearMonth)) + 1);
                    break;
                case "进口保理":
                    caseCode = "IF" + yearMonth + "-" + String.Format("{0:D4}", App.Current.DbContext.Cases.Count(c => c.CaseCode.StartsWith("IF" + yearMonth)) + 1);
                    break;
                case "国际信保保理":

                case "国内信保保理":
                    caseCode = "SF" + yearMonth + "-" + String.Format("{0:D4}", App.Current.DbContext.Cases.Count(c => c.CaseCode.StartsWith("SF" + yearMonth)) + 1);
                    break;
                case "租赁保理":
                    caseCode = "LF" + yearMonth + "-" + String.Format("{0:D4}", App.Current.DbContext.Cases.Count(c => c.CaseCode.StartsWith("LF" + yearMonth)) + 1);
                    break;
                default:
                    caseCode = string.Empty;
                    break;
            }

            return caseCode;
        }

        /// <summary>
        /// Create new CDA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCDA(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBox.Show("请首先选择一个案子", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBox.Show("请首先选择一个案子", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CreditCoverNegotiation creditCoverNeg = new CreditCoverNegotiation();
            creditCoverNeg.CreateUserName = App.Current.CurUser.Name;
            this.creditCoverNegBindingSource.DataSource = creditCoverNeg;
            this.opCreditCoverNegType = OpCreditCoverNegType.NEW_CREDIT_COVER_NEG;
            this.UpdateCreditCoverNegControlStatus();
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
                MessageBox.Show("请首先选择一个案子", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("请首先选择一个案子", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.dgvCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations.ToList();
        }

        /// <summary>
        /// Save current Case
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCase(object sender, EventArgs e)
        {
            if (!this.caseValidator.Validate())
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;

            if (curCase.CaseCode == null)
            {
                curCase.CaseCode = this.GenerateCaseCode(curCase);
                curCase.CaseMark = "申请案";

                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.Cases.InsertOnSubmit(curCase);
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBox.Show(e1.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    curCase.Backup();
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
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBox.Show(e2.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    curCase.Backup();
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
            if (!this.creditCoverValidator.Validate())
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBox.Show("请首先选择一个案子", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.creditCoverNegBindingSource.DataSource is CreditCoverNegotiation))
            {
                return;
            }

            CreditCoverNegotiation creditCoverNeg = (CreditCoverNegotiation)this.creditCoverNegBindingSource.DataSource;

            if (creditCoverNeg.NegoID == 0)
            {
                creditCoverNeg.Case = curCase;
                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.CreditCoverNegotiations.InsertOnSubmit(creditCoverNeg);
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBox.Show(e1.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgvCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations.ToList();
                    this.NewCreditCoverNeg(null, null);
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
                    MessageBox.Show(e2.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgvCreditCoverNegs.Refresh();
                    creditCoverNeg.Backup();
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
            Case curCase = (Case)this.caseBindingSource.DataSource;
            ClientMgr clientMgr = new ClientMgr(false);
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
            Case curCase = (Case)this.caseBindingSource.DataSource;
            ClientMgr clientMgr;
            if (!"进口保理".Equals(this.cbCaseTransactionType.Text))
            {
                clientMgr = new ClientMgr(ClientMgr.OpClientMgrType.NEED_CONTRACT);
            }
            else
            {
                clientMgr = new ClientMgr(false);
            }
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

            int cid = (int)dgvCreditCoverNegs["colNegoID", dgvCreditCoverNegs.SelectedRows[0].Index].Value;
            if (cid != 0)
            {
                CreditCoverNegotiation selectedCreditCoverNeg = App.Current.DbContext.CreditCoverNegotiations.SingleOrDefault(c => c.NegoID == cid);
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
            Case curCase = (Case)this.caseBindingSource.DataSource;
            FactorMgr factorMgr = new FactorMgr(false);
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
                        curCase.SellerFactor = factor;
                        break;
                    case "国内买方保理":
                    case "进口保理":
                        curCase.BuyerFactor = factor;
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
            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBox.Show("请首先选择一个案子", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.cbCaseMark.Enabled = false;

        }

        /// <summary>
        /// Turn CreditCoverNegotiation into update status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCreditCoverNeg(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase == null || curCase.CaseCode == null)
            {
                MessageBox.Show("请首先选择一个案子", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

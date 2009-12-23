
namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.Utils;
    using DevComponents.Editors;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public partial class CaseDetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private OpCaseType opCaseType;
        /// <summary>
        /// 
        /// </summary>
        private OpCreditCoverNegType opCreditCoverNegType;

        #endregion Fields

        #region Enums (2)

        /// <summary>
        /// 
        /// </summary>
        public enum OpCreditCoverNegType
        {
            /// <summary>
            /// 
            /// </summary>
            NEW_CREDIT_COVER_NEG,

            /// <summary>
            /// 
            /// </summary>
            UPDATE_CREDIT_COVER_NEG,

            /// <summary>
            /// 
            /// </summary>
            DETAIL_CREDIT_COVER_NEG
        }
        /// <summary>
        /// 
        /// </summary>
        public enum OpCaseType
        {
            /// <summary>
            /// 
            /// </summary>
            NEW_CASE,

            /// <summary>
            /// 
            /// </summary>
            UPDATE_CASE,

            /// <summary>
            /// 
            /// </summary>
            DETAIL_CASE,
        }

        #endregion Enums

        #region Constructors (3)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="curCase"></param>
        /// <param name="opCaseType"></param>
        /// <param name="opCreditCoverNegType"></param>
        public CaseDetail(Case curCase, OpCaseType opCaseType, OpCreditCoverNegType opCreditCoverNegType)
        {
            this.InitializeComponent();

            this.cbCaseInvoiceCurrency.DataSource = Currency.AllCurrencies();
            this.cbCaseInvoiceCurrency.DisplayMember = "CurrencyFormat";
            this.cbCaseInvoiceCurrency.ValueMember = "CurrencyCode";

            string[] transactionList = new string[] { "国内保理", "出口保理", "进口保理", "信保保理" };
            this.cbCaseTransactionType.DataSource = transactionList;

            this.cbCaseCoDepts.DataSource = Department.AllDepartments();
            this.cbCaseCoDepts.ValueMember = "DepartmentCode";
            this.cbCaseCoDepts.DisplayMember = "DepartmentName";

            this.cbCaseOwnerDepts.DataSource = Department.AllDepartments();
            this.cbCaseOwnerDepts.DisplayMembers = "DepartmentName";
            this.cbCaseOwnerDepts.GroupingMembers = "Domain";
            this.cbCaseOwnerDepts.ValueMember = "DepartmentCode";

            this.opCaseType = opCaseType;
            this.opCreditCoverNegType = opCreditCoverNegType;

            if (opCaseType == OpCaseType.NEW_CASE)
            {
                curCase = new Case();
                curCase.CreateUserName = App.Current.CurUser.Name;
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

            this.UpdateCaseControlStatus();
            this.UpdateCreditCoverNegControlStatus();

            if (opCreditCoverNegType == OpCreditCoverNegType.NEW_CREDIT_COVER_NEG)
            {
                this.tabControl.SelectedTab = this.tabItemCreditCoverNeg;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="curCase"></param>
        /// <param name="opCaseType"></param>
        public CaseDetail(Case curCase, OpCaseType opCaseType)
            : this(curCase, opCaseType, OpCreditCoverNegType.DETAIL_CREDIT_COVER_NEG)
        {
            this.tabControl.SelectedTab = this.tabItemCase;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="curCase"></param>
        /// <param name="opCreditCoverNegType"></param>
        public CaseDetail(Case curCase, OpCreditCoverNegType opCreditCoverNegType)
            : this(curCase, OpCaseType.DETAIL_CASE, opCreditCoverNegType)
        {
            this.tabControl.SelectedTab = this.tabItemCreditCoverNeg;
        }

        #endregion Constructors

        #region Methods (23)

        // Private Methods (23) 

        private void CaseDetail_Leave(object sender, EventArgs e)
        {
            this.CloseCase(sender, e);
        }

        /// <summary>
        /// 
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

            string transationType = this.cbCaseTransactionType.SelectedItem.ToString();
            if (transationType == null || string.Empty.Equals(transationType))
            {
                return;
            }

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if ("国内保理".Equals(transationType))
            {
                Factor selectedFactor = Factor.FindFactorByCode(Factor.CMBC_CODE);
                curCase.SellerFactor = selectedFactor;
                curCase.BuyerFactor = selectedFactor;
            }
            else if ("出口保理".Equals(transationType))
            {
                Factor selectedFactor = Factor.FindFactorByCode(Factor.CMBC_CODE);
                curCase.SellerFactor = selectedFactor;
                curCase.BuyerFactor = null;
            }
            else if ("进口保理".Equals(transationType))
            {
                Factor selectedFactor = Factor.FindFactorByCode(Factor.CMBC_CODE);
                curCase.SellerFactor = null;
                curCase.BuyerFactor = selectedFactor;
            }
            else if ("信保保理".Equals(transationType))
            {
                Factor selectedFactor = Factor.FindFactorByCode(Factor.CMBC_CODE);
                curCase.SellerFactor = selectedFactor;
                curCase.BuyerFactor = null;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseCase(object sender, EventArgs e)
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
        /// 
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
                MessageBox.Show(e1.Message);
            }

            if (isDeleteOK)
            {
                MessageBox.Show("数据删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations.ToList();
                this.creditCoverNegBindingSource.DataSource = new CreditCoverNegotiation();
            }
        }

        private void DetailCDA(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCDAs.SelectedRows.Count == 0)
            {
                return;
            }

            int cid = (int)dgvCDAs["colCDAID", dgvCDAs.SelectedRows[0].Index].Value;
            if (cid != 0)
            {
                CDA selectedCDA = App.Current.DbContext.CDAs.SingleOrDefault(c => c.CDAID == cid);
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
        /// <returns></returns>
        private string GenerateCaseCode(Case curCase)
        {
            string caseCode = null;
            string yearMonth = String.Format("{0:yyyy}{0:MM}", DateTime.Today);
            switch (curCase.TransactionType)
            {
                case "国内保理":
                    caseCode = "LF" + yearMonth + "-" + String.Format("{0:D4}", App.Current.DbContext.Cases.Count(c => c.CaseCode.StartsWith("LF" + yearMonth)) + 1);
                    break;
                case "出口保理":
                    caseCode = "EF" + yearMonth + "-" + String.Format("{0:D4}", App.Current.DbContext.Cases.Count(c => c.CaseCode.StartsWith("LF" + yearMonth)) + 1);
                    break;
                case "进口保理":
                    caseCode = "IF" + yearMonth + "-" + String.Format("{0:D4}", App.Current.DbContext.Cases.Count(c => c.CaseCode.StartsWith("IF" + yearMonth)) + 1);
                    break;
                case "信保保理":
                    caseCode = "SF" + yearMonth + "-" + String.Format("{0:D4}", App.Current.DbContext.Cases.Count(c => c.CaseCode.StartsWith("SF" + yearMonth)) + 1);
                    break;
                default:
                    caseCode = string.Empty;
                    break;
            }

            return caseCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCDA(object sender, EventArgs e)
        {
            CDADetail cdaDetail = new CDADetail(null, CDADetail.OpCDAType.NEW_CDA);
            cdaDetail.Show(this);
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCase(object sender, EventArgs e)
        {
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
                    MessageBox.Show(e1.Message);
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
                    MessageBox.Show(e2.Message);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    curCase.Backup();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCreditCoverNeg(object sender, EventArgs e)
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
                    MessageBox.Show(e1.Message);
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
                    MessageBox.Show(e2.Message);
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
        /// 
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
            curCase.BuyerClient = clientMgr.Selected;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCaseBuyerFactor(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;
            FactorMgr factorMgr = new FactorMgr(false);
            QueryForm queryUI = new QueryForm(factorMgr, "选择买方保理商");
            factorMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            curCase.BuyerFactor = factorMgr.Selected;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCaseSeller(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;
            ClientMgr clientMgr = new ClientMgr(false);
            QueryForm queryUI = new QueryForm(clientMgr, "选择卖方");
            clientMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            curCase.SellerClient = clientMgr.Selected;
        }

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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSellerFactor(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;
            FactorMgr factorMgr = new FactorMgr(false);
            QueryForm queryUI = new QueryForm(factorMgr, "选择卖方保理商");
            factorMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            curCase.SellerFactor = factorMgr.Selected;
        }

        /// <summary>
        /// 
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
        /// 
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
                this.btnCaseBuyerFactorSelect.Visible = true;
                this.btnCaseBuyerSelect.Visible = true;
                this.btnCaseSellerFactorSelect.Visible = true;
                this.btnCaseSellerSelect.Visible = true;
            }
            else if (this.opCaseType == OpCaseType.UPDATE_CASE)
            {
                foreach (Control comp in this.groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                this.btnCaseBuyerFactorSelect.Visible = true;
                this.btnCaseBuyerSelect.Visible = true;
                this.btnCaseSellerFactorSelect.Visible = true;
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
                this.btnCaseBuyerFactorSelect.Visible = false;
                this.btnCaseBuyerSelect.Visible = false;
                this.btnCaseSellerFactorSelect.Visible = false;
                this.btnCaseSellerSelect.Visible = false;
            }

            this.tbCaseCreateUser.ReadOnly = true;
            this.cbCaseMark.Enabled = false;

        }

        /// <summary>
        /// 
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
        /// 
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

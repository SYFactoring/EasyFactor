
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

    public partial class CaseDetail : DevComponents.DotNetBar.Office2007Form
    {
        private OpCaseType opCaseType;

        private OpCreditCoverNegType opCreditCoverNegType;

        public CaseDetail(Case curCase, OpCaseType opCaseType, OpCreditCoverNegType opCreditCoverNegType)
        {
            this.InitializeComponent();
            this.InitComboBox();
            this.opCaseType = opCaseType;
            this.opCreditCoverNegType = opCreditCoverNegType;

            if (opCaseType == OpCaseType.NEW_CASE)
            {
                this.caseBindingSource.DataSource = new Case();
            }
            else
            {
                this.caseBindingSource.DataSource = curCase;
                curCase.Backup();
            }

            this.UpdateCaseControlStatus();

            if (opCreditCoverNegType == OpCreditCoverNegType.NEW_CREDIT_COVER_NEG)
            {
                this.tabControl.SelectedTab = this.tabItemCreditCoverNeg;
            }
        }

        public enum OpCaseType
        {
            NEW_CASE,

            UPDATE_CASE,

            DETAIL_CASE,
        }

        public enum OpCreditCoverNegType
        {
            NEW_CREDIT_COVER_NEG,

            UPDATE_CREDIT_COVER_NEG,

            DETAIL_CREDIT_COVER_NEG
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitComboBox()
        {
            this.cbCaseInvoiceCurrency.DataSource = App.Current.DbContext.Currencies.ToList();
            this.cbCaseInvoiceCurrency.DisplayMember = "CurrencyFormat";
            this.cbCaseInvoiceCurrency.ValueMember = "CurrencyCode";
        }

        private void UpdateCaseControlStatus()
        {
            if (this.opCaseType == OpCaseType.NEW_CASE)
            {
                foreach (Control comp in this.groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (this.opCaseType == OpCaseType.UPDATE_CASE)
            {
                foreach (Control comp in this.groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (this.opCaseType == OpCaseType.DETAIL_CASE)
            {
                foreach (Control comp in this.groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            this.tbCaseCreateUser.ReadOnly = true;
            this.tbCaseMark.ReadOnly = true;

            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (curCase.CaseCode != null)
            {
                this.dgvCreditCoverNegs.DataSource = curCase.CreditCoverNegotiations.ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseSellerFactorSelect(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;

            string transactionType = this.cbCaseTransactionType.Text;
            FactorMgr factorMgr = new FactorMgr(false);
            QueryForm queryUI = new QueryForm(factorMgr, "选择卖方保理商");
            factorMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            Factor sellerFactor = factorMgr.Selected;
            if (sellerFactor != null)
            {
                this.tbCaseSellerFactorCode.Text = sellerFactor.FactorCode;
                if (sellerFactor.CompanyNameCN == null || string.Empty.Equals(sellerFactor.CompanyNameCN))
                {
                    this.tbCaseSellerFactor.Text = sellerFactor.CompanyNameEN;
                }
                else
                {
                    this.tbCaseSellerFactor.Text = sellerFactor.CompanyNameCN;
                }

                curCase.SellerFactor = sellerFactor;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseBuyerFactorSelect(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;

            string transactionType = cbCaseTransactionType.Text;
            FactorMgr factorMgr = new FactorMgr(false);
            QueryForm queryUI = new QueryForm(factorMgr, "选择买方保理商");
            factorMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            Factor buyerFactor = factorMgr.Selected;
            if (buyerFactor != null)
            {
                this.tbCaseBuyerFactorCode.Text = buyerFactor.FactorCode;
                if (buyerFactor.CompanyNameCN == null || string.Empty.Equals(buyerFactor.CompanyNameCN))
                {
                    this.tbCaseBuyerFactor.Text = buyerFactor.CompanyNameEN;
                }
                else
                {
                    this.tbCaseBuyerFactor.Text = buyerFactor.CompanyNameCN;
                }

                curCase.BuyerFactor = buyerFactor;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseSellerSelect(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;

            ClientMgr clientMgr = new ClientMgr(false);
            QueryForm queryUI = new QueryForm(clientMgr, "选择卖方");
            clientMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            Client seller = clientMgr.Selected;
            if (seller != null)
            {
                this.tbCaseSellerNo.Text = seller.ClientEDICode;
                this.tbCaseSellerNameCN.Text = seller.ClientNameCN;
                this.tbCaseSellerNameEN.Text = seller.ClientNameEN_1;
                curCase.SellerClient = seller;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseBuyerSelect(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;

            ClientMgr clientMgr = new ClientMgr(false);
            QueryForm queryUI = new QueryForm(clientMgr, "选择买方");
            clientMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            Client buyer = clientMgr.Selected;
            if (buyer != null)
            {
                this.tbCaseBuyerNo.Text = buyer.ClientEDICode;
                this.tbCaseBuyerNameCN.Text = buyer.ClientNameCN;
                this.tbCaseBuyerNameEN.Text = buyer.ClientNameEN_1;
                curCase.BuyerClient = buyer;
            }
        }

        private void CaseUpdate(object sender, EventArgs e)
        {
            this.opCaseType = OpCaseType.UPDATE_CASE;
            this.UpdateCaseControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseClose(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;
            if (this.opCaseType == OpCaseType.UPDATE_CASE)
            {
                curCase.Restore();
            }
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseSave(object sender, EventArgs e)
        {
            Case curCase = (Case)this.caseBindingSource.DataSource;

            //curCase.InvoiceCurrency = (string)this.cbCaseInvoiceCurrency.SelectedValue;
            //curCase.OwnerDepartment = (Department)this.cbCaseOwnerDepts.SelectedValue;
            //curCase.CoDepartment = (Department)this.cbCaseCoDepts.SelectedValue;

            if (curCase.CaseCode == null)
            {
                curCase.CaseCode = this.GenerateCaseCode(curCase);
                curCase.CaseAppDate = diCaseAppDate.Value;
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
        private void cbCaseTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem selectedItem = (ComboItem)this.cbCaseTransactionType.SelectedItem;
            if (selectedItem == null)
            {
                return;
            }
            Case curCase = (Case)this.caseBindingSource.DataSource;

            curCase.TransactionType = selectedItem.Text;

            if ("国内保理".Equals(selectedItem.Text))
            {
                Factor selectedFactor = Factor.FindFactorByCode(Factor.CMBC_CODE);
                this.tbCaseBuyerFactor.Text = selectedFactor.CompanyNameCN;
                curCase.BuyerFactor = selectedFactor;

                this.tbCaseSellerFactor.Text = selectedFactor.CompanyNameCN;
                curCase.SellerFactor = selectedFactor;
            }
            else
            {
                this.ResetCaseApp();
            }

            if ("出口保理".Equals(selectedItem.Text))
            {
                Factor selectedFactor = Factor.FindFactorByCode(Factor.CMBC_CODE);
                this.tbCaseSellerFactor.Text = selectedFactor.CompanyNameCN;
                curCase.SellerFactor = selectedFactor;
            }
            else if ("进口保理".Equals(selectedItem.Text))
            {
                Factor selectedFactor = Factor.FindFactorByCode(Factor.CMBC_CODE);
                this.tbCaseBuyerFactor.Text = selectedFactor.CompanyNameCN;
                curCase.BuyerFactor = selectedFactor;
            }
            else if ("信保保理".Equals(selectedItem.Text))
            {
                Factor selectedFactor = Factor.FindFactorByCode(Factor.CMBC_CODE);
                this.tbCaseSellerFactor.Text = selectedFactor.CompanyNameCN;
                curCase.SellerFactor = selectedFactor;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCaseOpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem selectedItem = (ComboItem)this.cbCaseOpType.SelectedItem;
            if (selectedItem == null)
            {
                return;
            }
            Case curCase = (Case)this.caseBindingSource.DataSource;
            curCase.OperationType = selectedItem.Text;

            if ("自营".Equals(selectedItem.Text))
            {
                this.cbCaseCoDepts.Enabled = false;
                this.cbCaseOwnerDepts.DataSource = App.Current.DbContext.Departments.Where(d => d.Domain == "贸易金融事业部").ToList();
                this.cbCaseOwnerDepts.DisplayMembers = "DepartmentName";
                this.cbCaseOwnerDepts.GroupingMembers = "Domain";
                this.cbCaseOwnerDepts.SelectedIndex = -1;
            }
            else
            {
                this.cbCaseCoDepts.Enabled = true;
                this.cbCaseCoDepts.DataSource = App.Current.DbContext.Departments.Where(d => d.Domain == "贸易金融事业部").ToList();
                this.cbCaseCoDepts.DisplayMembers = "DepartmentName";
                this.cbCaseCoDepts.GroupingMembers = "Domain";
                this.cbCaseCoDepts.SelectedIndex = -1;

                this.cbCaseOwnerDepts.DataSource = App.Current.DbContext.Departments.Where(d => d.Domain != "贸易金融事业部").ToList();
                this.cbCaseOwnerDepts.DisplayMembers = "DepartmentName";
                this.cbCaseOwnerDepts.GroupingMembers = "Domain";
                this.cbCaseOwnerDepts.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ResetCaseApp()
        {
            foreach (Control comp in this.groupPanelCase.Controls)
            {
                if (comp == cbCaseTransactionType)
                {
                    continue;
                }

                ControlUtil.SetComponetDefault(comp);
            }
        }
    }
}


namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.InfoMgr.DepartmentMgr;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar.Controls;
    using DevComponents.Editors;

    /// <summary>
    /// 
    /// </summary>
    public partial class CaseApp : DevComponents.DotNetBar.Office2007Form
    {
        /// <summary>
        /// 
        /// </summary>
        private Case appCase;

        /// <summary>
        /// Initializes a new instance of the CaseApp class.
        /// </summary>
        public CaseApp()
        {
            this.InitializeComponent();
            this.InitComboBox();

            this.appCase = new Case();
            this.diCaseAppDate.Value = DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitComboBox()
        {
            this.cbInvoiceCurrency.DataSource = App.Current.DbContext.Currencies.ToList();
            this.cbInvoiceCurrency.DisplayMember = "CurrencyFormat";
            this.cbInvoiceCurrency.ValueMember = "CurrencyCode";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellerFactorSelect(object sender, EventArgs e)
        {
            string transactionType = cbTransactionType.Text;
            FactorMgr factorMgr = new FactorMgr(false);
            QueryForm queryUI = new QueryForm(factorMgr, "选择卖方保理商");
            factorMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            Factor sellerFactor = factorMgr.Selected;
            if (sellerFactor != null)
            {
                this.tbSellerFactorCode.Text = sellerFactor.FactorCode;
                if (sellerFactor.CompanyNameCN == null || string.Empty.Equals(sellerFactor.CompanyNameCN))
                {
                    this.tbSellerFactor.Text = sellerFactor.CompanyNameEN;
                }
                else
                {
                    this.tbSellerFactor.Text = sellerFactor.CompanyNameCN;
                }

                this.appCase.SellerFactor = sellerFactor;
                this.appCase.SellerFactorCode = sellerFactor.FactorCode;
            }
            else
            {
                MessageBox.Show("请先选择业务类别", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuyerFactorSelect(object sender, EventArgs e)
        {
            string transactionType = cbTransactionType.Text;
            FactorMgr factorMgr = new FactorMgr(false);
            QueryForm queryUI = new QueryForm(factorMgr, "选择买方保理商");
            factorMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            Factor buyerFactor = factorMgr.Selected;
            if (buyerFactor != null)
            {
                this.tbBuyerFactorCode.Text = buyerFactor.FactorCode;
                if (buyerFactor.CompanyNameCN == null || string.Empty.Equals(buyerFactor.CompanyNameCN))
                {
                    this.tbBuyerFactor.Text = buyerFactor.CompanyNameEN;
                }
                else
                {
                    this.tbBuyerFactor.Text = buyerFactor.CompanyNameCN;
                }

                this.appCase.BuyerFactor = buyerFactor;
                this.appCase.BuyerFactorCode = buyerFactor.FactorCode;
            }
            else
            {
                MessageBox.Show("请先选择业务类别", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellerSelect(object sender, EventArgs e)
        {
            ClientMgr clientMgr = new ClientMgr(false);
            QueryForm queryUI = new QueryForm(clientMgr, "选择卖方");
            clientMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            Client seller = clientMgr.Selected;
            if (seller != null)
            {
                this.tbSellerNo.Text = seller.ClientEDICode;
                this.tbSellerNameCN.Text = seller.ClientNameCN;
                this.tbSellerNameEN.Text = seller.ClientNameEN_1;
                this.appCase.SellerClient = seller;
                this.appCase.SellerCode = seller.ClientEDICode;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuyerSelect(object sender, EventArgs e)
        {
            ClientMgr clientMgr = new ClientMgr(false);
            QueryForm queryUI = new QueryForm(clientMgr, "选择买方");
            clientMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            Client buyer = clientMgr.Selected;
            if (buyer != null)
            {
                this.tbBuyerNo.Text = buyer.ClientEDICode;
                this.tbBuyerNameCN.Text = buyer.ClientNameCN;
                this.tbBuyerNameEN.Text = buyer.ClientNameEN_1;
                this.appCase.BuyerClient = buyer;
                this.appCase.BuyerCode = buyer.ClientEDICode;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseClose(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseSave(object sender, EventArgs e)
        {
            this.appCase.InvoiceCurrency = (string)this.cbInvoiceCurrency.SelectedValue;
            this.appCase.OwnerDepartment = (Department)this.cbOwnerDepts.SelectedValue;
            this.appCase.CoDepartment = (Department)this.cbCoDepts.SelectedValue;
            this.appCase.CaseAppDate = diCaseAppDate.Value;
            this.appCase.CreateUserName = App.Current.CurUser.Name;
            this.appCase.CaseMark = "申请案";

            if (this.appCase.CaseCode == null)
            {
                this.appCase.CaseCode = this.GenerateCaseCode();
                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.Cases.InsertOnSubmit(this.appCase);
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
                    this.tbCaseMark.Text = this.appCase.CaseMark;
                    this.tbCreateUser.Text = this.appCase.CreateUserName;
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
        private string GenerateCaseCode()
        {
            string caseCode = null;
            string yearMonth = String.Format("{0:yyyy}{0:MM}", DateTime.Today);
            switch (this.appCase.TransactionType)
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
        private void cbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem selectedItem = (ComboItem)this.cbTransactionType.SelectedItem;
            if (selectedItem == null)
            {
                return;
            }

            this.appCase.TransactionType = selectedItem.Text;

            if ("国内保理".Equals(selectedItem.Text))
            {
                Factor selectedFactor = Factor.FindFactorByCode(Factor.CMBC_CODE);
                this.tbBuyerFactor.Text = selectedFactor.CompanyNameCN;
                this.tbBuyerFactorCode.Text = selectedFactor.FactorCode;
                this.appCase.BuyerFactor = selectedFactor;
                this.appCase.BuyerFactorCode = selectedFactor.FactorCode;

                this.tbSellerFactor.Text = selectedFactor.CompanyNameEN;
                this.tbSellerFactor.Text = selectedFactor.CompanyNameCN;
                this.tbSellerFactorCode.Text = selectedFactor.FactorCode;
                this.appCase.SellerFactor = selectedFactor;
                this.appCase.SellerFactorCode = selectedFactor.FactorCode;
            }
            else
            {
                this.ResetCaseApp();
            }

            if ("出口保理".Equals(selectedItem.Text))
            {
                Factor selectedFactor = Factor.FindFactorByCode(Factor.CMBC_CODE);
                this.tbSellerFactor.Text = selectedFactor.CompanyNameEN;
                this.tbSellerFactor.Text = selectedFactor.CompanyNameCN;
                this.tbSellerFactorCode.Text = selectedFactor.FactorCode;
                this.appCase.SellerFactor = selectedFactor;
                this.appCase.SellerFactorCode = selectedFactor.FactorCode;
            }
            else if ("进口保理".Equals(selectedItem.Text))
            {
                Factor selectedFactor = Factor.FindFactorByCode(Factor.CMBC_CODE);
                this.tbBuyerFactor.Text = selectedFactor.CompanyNameCN;
                this.tbBuyerFactorCode.Text = selectedFactor.FactorCode;
                this.appCase.BuyerFactor = selectedFactor;
                this.appCase.BuyerFactorCode = selectedFactor.FactorCode;
            }
            else if ("信保保理".Equals(selectedItem.Text))
            {
                Factor selectedFactor = Factor.FindFactorByCode(Factor.CMBC_CODE);
                this.tbSellerFactor.Text = selectedFactor.CompanyNameEN;
                this.tbSellerFactor.Text = selectedFactor.CompanyNameCN;
                this.tbSellerFactorCode.Text = selectedFactor.FactorCode;
                this.appCase.SellerFactor = selectedFactor;
                this.appCase.SellerFactorCode = selectedFactor.FactorCode;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbOpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem selectedItem = (ComboItem)this.cbOpType.SelectedItem;
            if (selectedItem == null)
            {
                return;
            }

            this.appCase.OperationType = selectedItem.Text;

            if ("自营".Equals(selectedItem.Text))
            {
                this.cbCoDepts.Enabled = false;
                this.cbOwnerDepts.DataSource = App.Current.DbContext.Departments.Where(d => d.Domain == "贸易金融事业部").ToList();
                this.cbOwnerDepts.DisplayMembers = "DepartmentName";
                this.cbOwnerDepts.GroupingMembers = "Domain";
                this.cbOwnerDepts.SelectedIndex = -1;
            }
            else
            {
                this.cbCoDepts.Enabled = true;
                this.cbCoDepts.DataSource = App.Current.DbContext.Departments.Where(d => d.Domain == "贸易金融事业部").ToList();
                this.cbCoDepts.DisplayMembers = "DepartmentName";
                this.cbCoDepts.GroupingMembers = "Domain";
                this.cbCoDepts.SelectedIndex = -1;

                this.cbOwnerDepts.DataSource = App.Current.DbContext.Departments.Where(d => d.Domain != "贸易金融事业部").ToList();
                this.cbOwnerDepts.DisplayMembers = "DepartmentName";
                this.cbOwnerDepts.GroupingMembers = "Domain";
                this.cbOwnerDepts.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ResetCaseApp()
        {
            foreach (Control comp in this.groupPanelCaseApp.Controls)
            {
                if (comp == cbTransactionType)
                {
                    continue;
                }

                ControlUtil.SetComponetDefault(comp);
            }
        }
    }
}

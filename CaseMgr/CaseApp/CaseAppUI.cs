
namespace CMBC.EasyFactor.CaseMgr.CaseApp
{
    using System;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.DB.dbml;
    using System.Windows.Forms;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.InfoMgr.DepartmentMgr;

    public partial class CaseAppUI : DevComponents.DotNetBar.Office2007Form
    {
        public CaseAppUI()
        {
            InitializeComponent();
            this.cbInvoiceCurrency.DataSource = App.Current.DbContext.Currencies;
            this.cbInvoiceCurrency.DisplayMember = "CurrencyFormat";
            this.cbInvoiceCurrency.ValueMember = "CurrencyCode";
        }

        private void SellerFactorSelect(object sender, EventArgs e)
        {
            string transactionType = cbTransactionType.Text;
            if ("出口保理".Equals(transactionType) || "进口保理".Equals(transactionType))
            {
                FactorMgr factorMgr = new FactorMgr(false);
                QueryForm queryUI = new QueryForm(factorMgr, "选择卖方保理商");
                factorMgr.OwnerForm = queryUI;
                queryUI.ShowDialog(this);
                Factor sellerFactor = factorMgr.Selected;
                if (sellerFactor != null)
                {
                    this.tbSellerFactorCode.Text = sellerFactor.FactorCode;
                    this.tbSellerFactor.Text = sellerFactor.CompanyName;
                }
            }
            else if ("国内保理".Equals(transactionType) || "信保保理".Equals(transactionType))
            {
                DepartmentMgr deptMgr = new DepartmentMgr(false);
                QueryForm queryUI = new QueryForm(deptMgr, "选择卖方所属分部");
                deptMgr.OwnerForm = queryUI;
                queryUI.ShowDialog(this);
                Department sellerDept = deptMgr.Selected;
                if (sellerDept != null)
                {
                    this.tbSellerFactorCode.Text = sellerDept.DepartmentCode;
                    this.tbSellerFactor.Text = sellerDept.DepartmentName;
                }
            }
        }

        private void BuyerFactorSelect(object sender, EventArgs e)
        {
            string transactionType = cbTransactionType.Text;
            if ("出口保理".Equals(transactionType) || "进口保理".Equals(transactionType))
            {
                FactorMgr factorMgr = new FactorMgr(false);
                QueryForm queryUI = new QueryForm(factorMgr, "选择买方保理商");
                factorMgr.OwnerForm = queryUI;
                queryUI.ShowDialog(this);
                Factor buyerFactor = factorMgr.Selected;
                if (buyerFactor != null)
                {
                    this.tbBuyerFactorCode.Text = buyerFactor.FactorCode;
                    this.tbBuyerFactor.Text = buyerFactor.CompanyName;
                }
            }
            else if ("国内保理".Equals(transactionType) || "信保保理".Equals(transactionType))
            {
                DepartmentMgr deptMgr = new DepartmentMgr(false);
                QueryForm queryUI = new QueryForm(deptMgr, "选择买方所属分部");
                deptMgr.OwnerForm = queryUI;
                queryUI.ShowDialog(this);
                Department buyerDept = deptMgr.Selected;
                if (buyerDept != null)
                {
                    this.tbBuyerFactorCode.Text = buyerDept.DepartmentCode;
                    this.tbBuyerFactor.Text = buyerDept.DepartmentName;
                }
            }
        }

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
                this.tbSellerName.Text = seller.ClientNameCN;
            }
        }

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
                this.tbBuyerName.Text = buyer.ClientNameCN;
            }
        }
    }
}

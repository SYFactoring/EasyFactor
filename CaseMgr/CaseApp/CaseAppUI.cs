
namespace CMBC.EasyFactor.CaseMgr.CaseApp
{
    using System;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.DB.dbml;
    using System.Windows.Forms;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;

    public partial class CaseAppUI : DevComponents.DotNetBar.Office2007Form
    {
        public CaseAppUI()
        {
            InitializeComponent();
        }

        private void SellerFactorSelect(object sender, EventArgs e)
        {
            FactorMgr factorMgr = new FactorMgr(false);
            QueryUI queryUI = new QueryUI(factorMgr, "选择卖方保理商");
            queryUI.ShowDialog(this);
            Factor sellerFactor = factorMgr.Selected;
            if (sellerFactor != null)
            {
                this.tbSellerFactorCode.Text = sellerFactor.FactorCode;
                this.tbSellerFactor.Text = sellerFactor.CompanyName;
            }
        }

        private void BuyerFactorSelect(object sender, EventArgs e)
        {
            FactorMgr factorMgr = new FactorMgr(false);
            QueryUI queryUI = new QueryUI(factorMgr, "选择买方保理商");
            queryUI.ShowDialog(this);
            Factor buyerFactor = factorMgr.Selected;
            if (buyerFactor != null)
            {
                this.tbBuyerFactorCode.Text = buyerFactor.FactorCode;
                this.tbBuyerFactor.Text = buyerFactor.CompanyName;
            }
        }

        private void SellerSelect(object sender, EventArgs e)
        {
            ClientMgr clientMgr = new ClientMgr(false);
            QueryUI queryUI = new QueryUI(clientMgr, "选择卖方");
            queryUI.ShowDialog(this);
            Client seller = clientMgr.Selected;
            if (seller != null)
            {
                this.tbSellerNo.Text = seller.ClientNo;
                this.tbSellerName.Text = seller.ClientNameCN;
            }
        }

        private void BuyerSelect(object sender, EventArgs e)
        {
            ClientMgr clientMgr = new ClientMgr(false);
            QueryUI queryUI = new QueryUI(clientMgr, "选择买方");
            queryUI.ShowDialog(this);
            Client buyer = clientMgr.Selected;
            if (buyer != null)
            {
                this.tbBuyerNo.Text = buyer.ClientNo;
                this.tbBuyerName.Text = buyer.ClientNameCN;
            }
        }
    }
}

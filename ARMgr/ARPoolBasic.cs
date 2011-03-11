using System;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.InfoMgr.ClientMgr;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpPoolARType
    {
        /// <summary>
        /// 融资
        /// </summary>
        FINANCE,

        /// <summary>
        /// 卖方还款
        /// </summary>
        REFUND
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class ARPoolBasic : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private Client _client;

        /// <summary>
        /// 
        /// </summary>
        private OpPoolARType _opArType;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="opARType"></param>
        public ARPoolBasic(OpPoolARType opARType)
        {
            InitializeComponent();

            _opArType = opARType;
            switch (opARType)
            {
                case OpPoolARType.FINANCE:
                    PoolControl = new PoolFinance(this);
                    break;
                case OpPoolARType.REFUND:
                    PoolControl = new PoolRefund(this, PoolRefund.OpRefundType.SELLER_REFUND);
                    break;
                default:
                    PoolControl = new UserControl();
                    break;
            }

            PoolControl.Dock = DockStyle.Fill;
            panelPool.Controls.Add(PoolControl);
        }


        /// <summary>
        /// Gets or sets
        /// </summary>
        public Client Client
        {
            get { return _client; }
            set
            {
                _client = value;
                FillClientBasic();
            }
        }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public UserControl PoolControl { get; set; }


        //?Public?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedClient"></param>
        public void CaculateOutstanding(Client selectedClient)
        {
            if (selectedClient == null)
            {
                throw new ArgumentNullException("selectedClient", @"selectedClient cannot be a null reference");
            }

            tbPoolTotalAssignOutstanding.Text = String.Format("{0:N2}", selectedClient.PoolTotalAssignOutstading);
            tbPoolValuedAssignOutstanding.Text = String.Format("{0:N2}", selectedClient.GetPoolCanBeFinance("CNY"));
            tbPoolCashOutstanding.Text = String.Format("{0:N2}", selectedClient.PoolCashOutstanding);
            tbPoolFinanceOutstanding.Text = String.Format("{0:N2}", selectedClient.PoolFinanceOutstanding);
        }

        //?Private?Methods?(3)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailClient(object sender, EventArgs e)
        {
            if (_client != null)
            {
                var clientDetail = new ClientDetail(_client, ClientDetail.OpClientType.DETAIL_CLIENT);
                clientDetail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillClientBasic()
        {
            tbClientEDICode.Text = Client.ClientEDICode;
            tbClientName.Text = Client.ToString();

            CaculateOutstanding(Client);

            Control control = panelPool.Controls[0];
            if (control is PoolFinance)
            {
                (control as PoolFinance).Client = Client;
            }
            else if (control is PoolRefund)
            {
                (control as PoolRefund).Client = Client;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectClient(object sender, EventArgs e)
        {
            var clientMgr = new ClientMgr();
            var queryForm = new QueryForm(clientMgr, "选择客户");
            clientMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);
            Client curClient = clientMgr.Selected;
            if (curClient != null)
            {
                Client = curClient;
            }
        }
    }
}
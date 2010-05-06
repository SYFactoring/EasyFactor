namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.Utils;

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

    public partial class ARPoolBasic : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private Client _client;

        /// <summary>
        /// 
        /// </summary>
        private OpPoolARType opARType;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opARType"></param>
        public ARPoolBasic(OpPoolARType opARType)
        {
            this.InitializeComponent();

            this.opARType = opARType;
            switch (opARType)
            {
                case OpPoolARType.FINANCE:
                    this.PoolControl = new PoolFinance(this);
                    break;
                case OpPoolARType.REFUND:
                    this.PoolControl = new PoolRefund(this, PoolRefund.OpRefundType.SELLER_REFUND);
                    break;
                default:
                    this.PoolControl = new UserControl();
                    break;
            }


            this.PoolControl.Dock = DockStyle.Fill;
            this.panelPool.Controls.Add(this.PoolControl);
        }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public Client Client
        {
            get
            {
                return this._client;
            }
            set
            {
                this._client = value;
                this.FillClientBasic();
            }
        }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public UserControl PoolControl
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedClient"></param>
        public void CaculateOutstanding(Client selectedClient)
        {
            this.tbTotalAssignOutstanding.Text = String.Format("{0:N2}", selectedClient.PoolTotalAssignOutstading);
            this.tbValuedAssignOutstanding.Text = String.Format("{0:N2}", selectedClient.PoolValuedAssignOutstanding);
            this.tbCashOutstanding.Text = String.Format("{0:N2}", selectedClient.PoolCashOutstanding);
            this.tbFinanceOutstanding.Text = String.Format("{0:N2}", selectedClient.PoolFinanceOutstanding);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailClient(object sender, EventArgs e)
        {
            if (this._client != null)
            {
                ClientDetail clientDetail = new ClientDetail(this._client, ClientDetail.OpClientType.DETAIL_CLIENT);
                clientDetail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillClientBasic()
        {
            this.tbClientEDICode.Text = this.Client.ClientEDICode;
            this.tbClientName.Text = this.Client.ToString();

            this.CaculateOutstanding(this.Client);

            Control control = this.panelPool.Controls[0];
            if (control is PoolFinance)
            {
                (control as PoolFinance).Client = this.Client;
            }
            else if (control is PoolRefund)
            {
                (control as PoolRefund).Client = this.Client;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectClient(object sender, EventArgs e)
        {
            ClientMgr clientMgr = new ClientMgr();
            QueryForm queryForm = new QueryForm(clientMgr, "选择客户");
            clientMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);
            Client curClient = clientMgr.Selected;
            if (curClient != null)
            {
                this.Client = curClient;
            }
        }
    }
}

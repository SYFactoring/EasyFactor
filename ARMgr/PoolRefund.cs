using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;

namespace CMBC.EasyFactor.ARMgr
{
    public partial class PoolRefund : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private Client _client;
        /// <summary>
        /// 
        /// </summary>
        private ARPoolBasic poolBasic;
        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;
        /// <summary>
        /// 
        /// </summary>
        private OpRefundType refundType;

        /// <summary>
        /// 
        /// </summary>
        public enum OpRefundType
        {
            /// <summary>
            /// 
            /// </summary>
            BUYER_PAYMENT,

            /// <summary>
            /// 
            /// </summary>
            INDIRECT_PAYMENT,

            /// <summary>
            /// 
            /// </summary>
            SELLER_REFUND,

            /// <summary>
            /// 
            /// </summary>
            GUARANTEE_PAYMENT,
        }

        public PoolRefund(ARPoolBasic poolBasic, OpRefundType refundType)
        {
            InitializeComponent();

            this.poolBasic = poolBasic;
            this.refundType = refundType;

            this.context = new DBDataContext();
        }


        /// <summary>
        /// 
        /// </summary>
        public Client Client
        {
            set
            {
                this._client = this.context.Clients.SingleOrDefault(c => c.ClientEDICode == value.ClientEDICode);
                this.NewBatch(null, null);
            }
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewBatch(object sender, EventArgs e)
        {
        }
    }
}

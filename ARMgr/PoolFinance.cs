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
    public partial class PoolFinance : UserControl
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

        public PoolFinance(ARPoolBasic poolBasic)
        {
            InitializeComponent();

            this.poolBasic = poolBasic;

            this.context = new DBDataContext();
        }

        /// <summary>
        /// Sets
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

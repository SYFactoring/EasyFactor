using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    public partial class ClientCreditLineMgr : UserControl
    {
        public ClientCreditLineMgr()
        {
            InitializeComponent();
            this.dgvClientCreditLines.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvClientCreditLines);
        }

        private void Query(object sender, EventArgs e)
        {
            string clientEDICode = tbClientEDICode.Text;
            string clientName = tbClientName.Text;

            var queryResult =  App.Current.DbContext.ClientCreditLines.Where(c=>c.Client.ClientEDICode.Contains(clientEDICode)&&(c.Client.ClientNameCN.Contains(clientName)||c.Client.ClientNameEN_1.Contains(clientName)||c.Client.ClientNameEN_2.Contains(clientName)));
            this.dgvClientCreditLines.DataSource = queryResult;
        }
    }
}

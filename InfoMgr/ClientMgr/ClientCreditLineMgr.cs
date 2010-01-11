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
        #region Fields (1)

        private OpClientCreditMgrType opType;

        #endregion Fields

        #region Enums (1)

        public enum OpClientCreditMgrType
        {
            QUERY_CLINET,

            QUERY_GROUP,
        }

        #endregion Enums

        #region Constructors (1)

        public ClientCreditLineMgr(OpClientCreditMgrType opType)
        {
            InitializeComponent();
            this.opType = opType;
            this.dgvClientCreditLines.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvClientCreditLines);

            if (opType == OpClientCreditMgrType.QUERY_GROUP)
            {
                lblClientName.Text = "集团名称";
                this.colClientNameCN.HeaderText = "集团客户名称（中）";
                this.colClientNameEN_1.HeaderText = "集团客户名称（英1）";
                this.cbClientGroupType.Text = "集团";
            }
            else
            {
                this.cbClientGroupType.Text = "客户";
            }
        }

        #endregion Constructors

        #region Methods (1)

        // Private Methods (1) 

        private void Query(object sender, EventArgs e)
        {
            string clientEDICode = tbClientEDICode.Text;
            string clientName = tbClientName.Text;
            string clientGroupType = cbClientGroupType.Text;
            if (clientGroupType == "全部")
            {
                clientGroupType = string.Empty;
            }

            var queryResult = App.Current.DbContext.ClientCreditLines.Where(c =>
                c.Client.ClientEDICode.Contains(clientEDICode)
             && (c.Client.ClientNameCN.Contains(clientName) || c.Client.ClientNameEN_1.Contains(clientName) || c.Client.ClientNameEN_2.Contains(clientName))
             && (c.Client.ClientGroupType == null ? string.Empty : c.Client.ClientGroupType).Contains(clientGroupType)
                 );
            this.dgvClientCreditLines.DataSource = queryResult;
        }

        #endregion Methods
    }
}

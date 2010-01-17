using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.Utils;
using CMBC.EasyFactor.DB.dbml;

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    public partial class ClientCreditLineMgr : UserControl
    {
        #region Fields (2)

        private BindingSource bs;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupClient"></param>
        public ClientCreditLineMgr(Client groupClient):this(OpClientCreditMgrType.QUERY_GROUP)
        {
            this.panelQuery.Visible = false;
            this.bs.DataSource = groupClient.ClientCreditLines;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opType"></param>
        public ClientCreditLineMgr(OpClientCreditMgrType opType)
        {
            InitializeComponent();
            this.bs = new BindingSource();
            this.opType = opType;
            this.dgvClientCreditLines.DataSource = bs;
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

        #region Properties (2)

        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets selected ClientCreditLine
        /// </summary>
        public ClientCreditLine Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (5)

        // Private Methods (5) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.OwnerForm == null)
            {
                this.DetailClientCreditLine(sender, e);
            }
            else
            {
                this.SelectClientCreditLine(sender, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailClientCreditLine(object sender, EventArgs e)
        {
            if (this.dgvClientCreditLines.CurrentCell == null)
            {
                return;
            }
            ClientCreditLine creditLine = (ClientCreditLine)this.bs.List[this.dgvClientCreditLines.CurrentCell.RowIndex];
            ClientDetail detail = new ClientDetail(creditLine, ClientDetail.OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClientCreditLines_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                this.dgvClientCreditLines.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                this.dgvClientCreditLines.RowHeadersDefaultCellStyle.Font,
                rectangle,
                this.dgvClientCreditLines.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Query(object sender, EventArgs e)
        {
            string clientEDICode = tbClientEDICode.Text;
            string clientName = tbClientName.Text;
            string clientGroupType = cbClientGroupType.Text;
            bool isGroup = false;
            if (clientGroupType == "集团")
            {
                isGroup = true;
            }

            var queryResult = App.Current.DbContext.ClientCreditLines.Where(c =>
                c.Client.ClientEDICode.Contains(clientEDICode)
             && (c.Client.ClientNameCN.Contains(clientName) || c.Client.ClientNameEN_1.Contains(clientName) || c.Client.ClientNameEN_2.Contains(clientName))
             && (isGroup == true ? c.Client.GroupClients.Count > 0 : true)
                 );
            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectClientCreditLine(object sender, EventArgs e)
        {
            if (this.dgvClientCreditLines.CurrentCell == null)
            {
                return;
            }

            ClientCreditLine creditLine = (ClientCreditLine)this.bs.List[this.dgvClientCreditLines.CurrentCell.RowIndex];
            this.Selected = creditLine;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
            }
        }

        #endregion Methods
    }
}

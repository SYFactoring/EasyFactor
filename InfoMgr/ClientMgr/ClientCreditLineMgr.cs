//-----------------------------------------------------------------------
// <copyright file="ClientCreditLineMgr.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class ClientCreditLineMgr : UserControl
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;

        /// <summary>
        /// 
        /// </summary>
        private OpClientCreditMgrType opType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpClientCreditMgrType
        {
            /// <summary>
            /// 
            /// </summary>
            QUERY_CLINET,

            /// <summary>
            /// 
            /// </summary>
            QUERY_GROUP,
        }

        #endregion Enums

        #region Constructors (2)

        /// <summary>
        /// Initializes a new instance of the ClientCreditLineMgr class.
        /// </summary>
        /// <param name="groupClient"></param>
        public ClientCreditLineMgr(Client groupClient)
            : this(OpClientCreditMgrType.QUERY_GROUP)
        {
            this.panelQuery.Visible = false;
            this.bs.DataSource = groupClient.ClientCreditLines;
        }

        /// <summary>
        /// Initializes a new instance of the ClientCreditLineMgr class.
        /// </summary>
        /// <param name="opType"></param>
        public ClientCreditLineMgr(OpClientCreditMgrType opType)
        {
            this.InitializeComponent();
            this.bs = new BindingSource();
            this.opType = opType;
            this.dgvClientCreditLines.DataSource = this.bs;
            this.dgvClientCreditLines.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvClientCreditLines);

            if (opType == OpClientCreditMgrType.QUERY_GROUP)
            {
                this.lblClientName.Text = "集团名称";
                this.colClientNameCN.HeaderText = "集团客户名称（中）";
                this.colClientNameEN.HeaderText = "集团客户名称（英）";
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

        #region Methods (6)

        // Private Methods (6) 

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
        private void dgvClientCreditLines_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.bs.List.Count; i++)
            {
                ClientCreditLine creditLine = (ClientCreditLine)this.bs.List[i];
                if (creditLine.PeriodEnd < DateTime.Now.Date)
                {
                    this.dgvClientCreditLines["colPeriodEnd", i].Style.BackColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClientCreditLines_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvClientCreditLines.RowHeadersWidth - 4, e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), this.dgvClientCreditLines.RowHeadersDefaultCellStyle.Font, rectangle, this.dgvClientCreditLines.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Query(object sender, EventArgs e)
        {
            string clientEDICode = this.tbClientEDICode.Text;
            string clientName = this.tbClientName.Text;
            string clientGroupType = this.cbClientGroupType.Text;
            bool isGroup = false;
            if (clientGroupType == "集团")
            {
                isGroup = true;
            }

            DBDataContext context = new DBDataContext();
            var queryResult = context.ClientCreditLines.Where(c =>
                c.Client.ClientEDICode.Contains(clientEDICode)
             && (c.Client.ClientNameCN.Contains(clientName) || c.Client.ClientNameEN.Contains(clientName))
             && (isGroup == true ? c.Client.GroupClients.Count > 0 : true));

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

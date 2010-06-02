//-----------------------------------------------------------------------
// <copyright file="ClientCreditLineMgr.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ClientCreditLineMgr : UserControl
    {
        #region OpClientCreditMgrType enum

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

            /// <summary>
            /// 
            /// </summary>
            DUE,
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;

        /// <summary>
        /// 
        /// </summary>
        private OpClientCreditMgrType _opType;


        /// <summary>
        /// Initializes a new instance of the ClientCreditLineMgr class.
        /// </summary>
        /// <param name="groupClient"></param>
        public ClientCreditLineMgr(Client groupClient)
            : this(OpClientCreditMgrType.QUERY_GROUP)
        {
            panelQuery.Visible = false;
            _bs.DataSource = groupClient.ClientCreditLines;
        }

        /// <summary>
        /// Initializes a new instance of the ClientCreditLineMgr class.
        /// </summary>
        /// <param name="opType"></param>
        public ClientCreditLineMgr(OpClientCreditMgrType opType)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _bs = new BindingSource();
            _opType = opType;
            dgvClientCreditLines.DataSource = _bs;
            dgvClientCreditLines.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(dgvClientCreditLines);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);

            if (opType == OpClientCreditMgrType.QUERY_GROUP)
            {
                lblClientName.Text = @"集团名称";
                colClientNameCN.HeaderText = @"集团客户名称（中）";
                colClientNameEN.HeaderText = @"集团客户名称（英）";
                cbClientGroupType.Text = @"集团";
            }
            else if (opType == OpClientCreditMgrType.QUERY_CLINET)
            {
                cbClientGroupType.Text = @"客户";
            }
            else if (opType == OpClientCreditMgrType.DUE)
            {
                var context = new DBDataContext();

                DateTime overDueDate = DateTime.Now.Date;

                IQueryable<ClientCreditLine> queryResult =
                    context.ClientCreditLines.Where(
                        c => c.CreditLineStatus == CLIENT_CREDIT_LINE.AVAILABILITY && c.PeriodEnd < overDueDate);

                _bs.DataSource = queryResult;
                lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
        }


        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm { get; set; }

        /// <summary>
        /// Gets or sets selected ClientCreditLine
        /// </summary>
        public ClientCreditLine Selected { get; set; }


        //?Private?Methods?(6)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OwnerForm == null)
            {
                DetailClientCreditLine(sender, e);
            }
            else
            {
                SelectClientCreditLine(sender, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailClientCreditLine(object sender, EventArgs e)
        {
            if (dgvClientCreditLines.CurrentCell == null)
            {
                return;
            }

            var creditLine = (ClientCreditLine) _bs.List[dgvClientCreditLines.CurrentCell.RowIndex];
            var detail = new ClientDetail(creditLine, ClientDetail.OpClientCreditLineType.DETAIL_CLIENT_CREDIT_LINE);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvClientCreditLinesDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < _bs.List.Count; i++)
            {
                var creditLine = (ClientCreditLine) _bs.List[i];
                if (creditLine.PeriodEnd < DateTime.Now.Date)
                {
                    dgvClientCreditLines["colPeriodEnd", i].Style.BackColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvClientCreditLinesRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                                          dgvClientCreditLines.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                                  dgvClientCreditLines.RowHeadersDefaultCellStyle.Font, rectangle,
                                  dgvClientCreditLines.RowHeadersDefaultCellStyle.ForeColor,
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

            var context = new DBDataContext();

            IQueryable<ClientCreditLine> queryResult = context.ClientCreditLines.Where(c =>
                                                                                       c.Client.ClientEDICode.Contains(
                                                                                           clientEDICode)
                                                                                       &&
                                                                                       (c.Client.ClientNameCN.Contains(
                                                                                           clientName) ||
                                                                                        c.Client.ClientNameEN.Contains(
                                                                                            clientName))
                                                                                       &&
                                                                                       (isGroup
                                                                                            ? c.Client.GroupClients.
                                                                                                  Count > 0
                                                                                            : true));

            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectClientCreditLine(object sender, EventArgs e)
        {
            if (dgvClientCreditLines.CurrentCell == null)
            {
                return;
            }

            var creditLine = (ClientCreditLine) _bs.List[dgvClientCreditLines.CurrentCell.RowIndex];
            Selected = creditLine;
            if (OwnerForm != null)
            {
                OwnerForm.DialogResult = DialogResult.Yes;
                OwnerForm.Close();
            }
        }
    }
}
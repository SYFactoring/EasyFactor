//-----------------------------------------------------------------------
// <copyright file="RevenueMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.InfoMgr.ClientMgr;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RevenueMgr : UserControl
    {
        #region OpRevenueType enum

        /// <summary>
        /// 
        /// </summary>
        public enum OpRevenueType
        {
            /// <summary>
            /// 
            /// </summary>
            QUERY,

        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;

        /// <summary>
        /// 
        /// </summary>
        private OpRevenueType _opType;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="opType"></param>
        public RevenueMgr(OpRevenueType opType)
            : this()
        {
            _opType = opType;
        }

        /// <summary>
        /// 
        /// </summary>
        public RevenueMgr()
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            dgvRevenues.AutoGenerateColumns = false;
            _bs = new BindingSource();
            dgvRevenues.DataSource = _bs;
            ControlUtil.SetDoubleBuffered(dgvRevenues);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);
        }


        /// <summary>
        /// 
        /// </summary>
        private DBDataContext Context { get; set; }

        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm { get; set; }

        /// <summary>
        /// Gets or sets selected Client
        /// </summary>
        public RevenueLog Selected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvRevenuesRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                                          dgvRevenues.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvRevenues.RowHeadersDefaultCellStyle.Font,
                                  rectangle, dgvRevenues.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRevenues(object sender, EventArgs e)
        {
            string invoiceNo = tbInvoiceNo.Text;
            string revenueType = cbRevenueType.Text;
            DateTime beginBatchDate = String.IsNullOrEmpty(dateFrom.Text)
                              ? dateFrom.MinDate
                              : dateFrom.Value.Date;
            DateTime endBatchDate = String.IsNullOrEmpty(dateTo.Text)
                                        ? dateTo.MinDate
                                        : dateTo.Value.Date;

            Context = new DBDataContext();
            if (!PermUtil.ValidatePermission(Permissions.BASICINFO_UPDATE))
            {
                Context.ObjectTrackingEnabled = false;
            }

            IQueryable<RevenueLog> queryResult = from revenue in Context.RevenueLog
                                                 where
                                                    (String.IsNullOrEmpty(invoiceNo) ? true : revenue.Invoice.InvoiceNo.Contains(invoiceNo))
                                                    && (String.IsNullOrEmpty(revenueType) ? true : revenue.RevenueType == revenueType)
                                                     && (beginBatchDate != dateFrom.MinDate
                                                                     ? revenue.RevenueDate >= beginBatchDate
                                                                     : true)
                                                                &&
                                                                (endBatchDate != dateTo.MinDate
                                                                     ? revenue.RevenueDate <= endBatchDate
                                                                     : true)
                                                 select revenue;

            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailInvoice(object sender, EventArgs e)
        {
            if (dgvRevenues.CurrentCell == null)
            {
                return;
            }

            var selectedRevenueLog = (RevenueLog)_bs.List[dgvRevenues.CurrentCell.RowIndex];
            var invoiceDetail = new InvoiceDetail(selectedRevenueLog.Invoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
            invoiceDetail.ShowDialog(this);
        }

        private void dgvRevenues_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailInvoice(sender, e);
        }

    }
}
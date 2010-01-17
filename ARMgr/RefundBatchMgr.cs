﻿//-----------------------------------------------------------------------
// <copyright file="RefundBatchMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using System.Drawing;
    /// <summary>
    /// 
    /// </summary>
    public partial class RefundBatchMgr : UserControl
    {
        #region Fields (3)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs = new BindingSource();
        /// <summary>
        /// 
        /// </summary>
        private CDA cda;
        /// <summary>
        /// 
        /// </summary>
        private OpBatchType opBatchType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpBatchType
        {
            /// <summary>
            /// 
            /// </summary>
            CHECK,

            /// <summary>
            /// 
            /// </summary>
            DETAIL,

            /// <summary>
            /// 
            /// </summary>
            QUERY
        }

        #endregion Enums

        #region Constructors (2)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedCDA"></param>
        public RefundBatchMgr(CDA selectedCDA)
            : this(OpBatchType.DETAIL)
        {
            this.cda = selectedCDA;
            this.panelQuery.Visible = false;
            this.bs.DataSource = cda.InvoiceRefundBatches;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchType"></param>
        public RefundBatchMgr(OpBatchType batchType)
        {
            InitializeComponent();
            ControlUtil.SetDoubleBuffered(this.dgvBatches);
            this.dgvBatches.AutoGenerateColumns = false;
            this.dgvBatches.DataSource = bs;
            this.opBatchType = batchType;
            if (batchType == OpBatchType.CHECK)
            {
                this.cbCheckStatus.Text = "未复核";
                var queryResult = App.Current.DbContext.InvoiceRefundBatches.Where(i => i.CheckStatus == "未复核");
                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
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
        /// Gets or sets selected RefundBatch
        /// </summary>
        public InvoiceRefundBatch Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (7)

        // Private Methods (7) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }
            foreach (DataGridViewRow row in this.dgvBatches.SelectedRows)
            {
                InvoiceRefundBatch batch = (InvoiceRefundBatch)this.bs.List[row.Index];
                batch.CheckStatus = "已复核";
                batch.CheckUserName = App.Current.CurUser.Name;
                batch.CheckDate = DateTime.Now.Date;
            }
            App.Current.DbContext.SubmitChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailBatch(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }
            InvoiceRefundBatch selectedBatch = (InvoiceRefundBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            RefundBatchDetail logMgr = new RefundBatchDetail(selectedBatch.InvoiceRefundLogs.ToList());
            QueryForm queryUI = new QueryForm(logMgr, "批次详情");
            logMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBatches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.OwnerForm == null)
            {
                this.DetailBatch(sender, e);
            }
            else
            {
                this.SelectBatch(sender, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryBatch(object sender, EventArgs e)
        {
            if (opBatchType == OpBatchType.QUERY || opBatchType == OpBatchType.CHECK)
            {
                DateTime beginDate = this.dateFrom.Text != string.Empty ? this.dateFrom.Value : this.dateFrom.MinDate;
                DateTime endDate = this.dateTo.Text != string.Empty ? this.dateTo.Value : this.dateTo.MinDate;
                string status = this.cbCheckStatus.Text;
                string refundType = this.cbRefundType.Text;

                var queryResult = App.Current.DbContext.InvoiceRefundBatches.Where(i =>
                    i.RefundBatchNo.Contains(this.tbRefundBatchNo.Text)
                    && (beginDate != this.dateFrom.MinDate ? i.RefundDate >= beginDate : true)
                    && (endDate != this.dateTo.MinDate ? i.RefundDate <= endDate : true)
                    && (status != string.Empty ? i.CheckStatus == status : true)
                    && (refundType!=string.Empty?i.RefundType==refundType:true)
                    );
                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
            else if (opBatchType == OpBatchType.DETAIL)
            {
                var queryResult = cda.InvoiceRefundBatches.Where(i => i.RefundBatchNo.Contains(this.tbRefundBatchNo.Text));
                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reject(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }
            foreach (DataGridViewRow row in this.dgvBatches.SelectedRows)
            {
                InvoiceAssignBatch batch = (InvoiceAssignBatch)this.bs.List[row.Index];
                batch.CheckStatus = "复核未通过";
                batch.CheckUserName = App.Current.CurUser.Name;
                batch.CheckDate = DateTime.Now.Date;
            }
            App.Current.DbContext.SubmitChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBatch(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }
            InvoiceRefundBatch selectedBatch = (InvoiceRefundBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            this.Selected = selectedBatch;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
            }
        }

        #endregion Methods

        private void dgvBatches_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                dgvBatches.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvBatches.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvBatches.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void DeleteBatch(object sender, EventArgs e)
        {

            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }
            InvoiceRefundBatch selectedBatch = (InvoiceRefundBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            if (MessageBox.Show("是否打算删除此" + selectedBatch.BatchCount + "条还款记录", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                App.Current.DbContext.InvoiceRefundLogs.DeleteAllOnSubmit(selectedBatch.InvoiceRefundLogs);
                App.Current.DbContext.InvoiceRefundBatches.DeleteOnSubmit(selectedBatch);
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBox.Show("删除失败," + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                this.dgvBatches.Rows.RemoveAt(this.dgvBatches.SelectedRows[0].Index);
            }

        }
    }
}
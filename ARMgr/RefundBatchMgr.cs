//-----------------------------------------------------------------------
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
        private Case _case;
        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;
        /// <summary>
        /// 
        /// </summary>
        private OpBatchType opBatchType;

        private DBDataContext context;

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
        public RefundBatchMgr(Case selectedCase)
            : this(OpBatchType.DETAIL)
        {
            this._case = selectedCase;
            this.panelQuery.Visible = false;
            this.bs.DataSource = selectedCase.InvoiceRefundBatches;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchType"></param>
        public RefundBatchMgr(OpBatchType batchType)
        {
            this.InitializeComponent();
            ControlUtil.SetDoubleBuffered(this.dgvBatches);
            this.dgvBatches.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvBatches.DataSource = bs;

            this.opBatchType = batchType;

            this.UpdateContextMenu();
            this.context = new DBDataContext();

            if (batchType == OpBatchType.CHECK)
            {
                this.cbCheckStatus.Text = "未复核";
                var queryResult = context.InvoiceRefundBatches.Where(i => i.CheckStatus == "未复核");
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

        #region Methods (9)

        // Private Methods (9) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_CHECK))
            {
                return;
            }

            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceRefundBatch batch = (InvoiceRefundBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            if (MessageBox.Show("是否确认复核通过该批次", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            batch.CheckStatus = "已复核";
            batch.CheckUserName = App.Current.CurUser.Name;
            batch.CheckDate = DateTime.Now.Date;

            context.InvoiceRefundBatches.Attach(batch);
            context.SubmitChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceRefundBatch selectedBatch = (InvoiceRefundBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            if (MessageBox.Show("是否打算删除此" + selectedBatch.BatchCount + "条还款记录", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            foreach (InvoiceRefundLog log in selectedBatch.InvoiceRefundLogs)
            {
                Invoice invoice = log.Invoice;
                log.Invoice = null;
                invoice.CaculateRefund();
                context.InvoiceRefundLogs.DeleteOnSubmit(log);
            }

            context.InvoiceRefundBatches.DeleteOnSubmit(selectedBatch);
            try
            {
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBox.Show("删除失败," + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.dgvBatches.Rows.RemoveAt(this.dgvBatches.SelectedRows[0].Index);
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
            RefundBatchDetail detail = new RefundBatchDetail(selectedBatch);
            detail.ShowDialog(this);
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
        private void dgvBatches_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvBatches.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvBatches.RowHeadersDefaultCellStyle.Font, rectangle, dgvBatches.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryBatch(object sender, EventArgs e)
        {
            DateTime beginDate = this.dateFrom.Text != string.Empty ? this.dateFrom.Value : this.dateFrom.MinDate;
            DateTime endDate = this.dateTo.Text != string.Empty ? this.dateTo.Value : this.dateTo.MinDate;
            string status = this.cbCheckStatus.Text;
            string refundType = this.cbRefundType.Text;
            string createUserName = this.tbCreateUserName.Text;
            string clientName = this.tbClientName.Text;

            var queryResult = context.InvoiceRefundBatches.Where(i =>
                i.RefundBatchNo.Contains(this.tbRefundBatchNo.Text)
                && (beginDate != this.dateFrom.MinDate ? i.RefundDate >= beginDate : true)
                && (endDate != this.dateTo.MinDate ? i.RefundDate <= endDate : true)
                && (status != string.Empty ? i.CheckStatus == status : true)
                && (refundType != string.Empty ? i.RefundType == refundType : true)
                && (i.CreateUserName.Contains(createUserName))
                && (i.Case.SellerClient.ClientNameCN.Contains(clientName) || i.Case.SellerClient.ClientNameEN.Contains(clientName) || i.Case.BuyerClient.ClientNameCN.Contains(clientName) || i.Case.BuyerClient.ClientNameEN.Contains(clientName))
                );

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reject(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_CHECK))
            {
                return;
            }

            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceRefundBatch batch = (InvoiceRefundBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            if (MessageBox.Show("是否确认复核退回该批次", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            batch.CheckStatus = "复核未通过";
            batch.CheckUserName = App.Current.CurUser.Name;
            batch.CheckDate = DateTime.Now.Date;

            context.InvoiceRefundBatches.Attach(batch);
            context.SubmitChanges();
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

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permission.INVOICE_UPDATE))
            {
                this.menuItemBatchDelete.Enabled = true;
            }
            else
            {
                this.menuItemBatchDelete.Enabled = false;
            }

            if (PermUtil.ValidatePermission(Permission.INVOICE_CHECK))
            {
                this.menuItemCheck.Enabled = true;
                this.menuItemReject.Enabled = true;
            }
            else
            {
                this.menuItemCheck.Enabled = false;
                this.menuItemReject.Enabled = false;
            }
        }

        #endregion Methods
    }
}

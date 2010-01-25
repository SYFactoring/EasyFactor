//-----------------------------------------------------------------------
// <copyright file="FinanceBatchMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
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
    public partial class FinanceBatchMgr : UserControl
    {
        #region Fields (3)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;

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
        /// Initializes a new instance of the FinanceBatchMgr class
        /// </summary>
        /// <param name="selectedCDA"></param>
        public FinanceBatchMgr(CDA selectedCDA)
            : this(OpBatchType.DETAIL)
        {
            this.cda = selectedCDA;
            this.panelQuery.Visible = false;
            this.bs.DataSource = this.cda.InvoiceFinanceBatches;
        }

        /// <summary>
        /// Initializes a new instance of the FinanceBatchMgr class
        /// </summary>
        /// <param name="batchType"></param>
        public FinanceBatchMgr(OpBatchType batchType)
        {
            this.InitializeComponent();
            ControlUtil.SetDoubleBuffered(this.dgvBatches);
            this.dgvBatches.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvBatches.DataSource = this.bs;
            this.opBatchType = batchType;

            if (batchType == OpBatchType.CHECK)
            {
                this.cbCheckStatus.Text = "未复核";
                var queryResult = App.Current.DbContext.InvoiceFinanceBatches.Where(i => i.CheckStatus == "未复核");
                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }

            this.UpdateContextMenu();
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
        /// Gets or sets selected FinanceBatch
        /// </summary>
        public InvoiceFinanceBatch Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (8)

        // Private Methods (8) 

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
                InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.bs.List[row.Index];
                batch.CheckStatus = "已复核";
                batch.CheckUserName = App.Current.CurUser.Name;
                batch.CheckDate = DateTime.Now.Date;
            }

            App.Current.DbContext.SubmitChanges();
        }

        private void DeleteBatch(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceFinanceBatch selectedBatch = (InvoiceFinanceBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            if (MessageBox.Show("是否打算删除此融资批次", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (selectedBatch.Invoices.Count > 0)
                {
                    MessageBox.Show("不能删除此批次，它包含相关发票信息", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                App.Current.DbContext.InvoiceFinanceBatches.DeleteOnSubmit(selectedBatch);
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

            InvoiceFinanceBatch selectedBatch = (InvoiceFinanceBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            FinanceBatchDetail detail = new FinanceBatchDetail(selectedBatch);
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
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvBatches.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvBatches.RowHeadersDefaultCellStyle.Font, rectangle, dgvBatches.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryBatch(object sender, EventArgs e)
        {
            if (this.opBatchType == OpBatchType.QUERY || this.opBatchType == OpBatchType.CHECK)
            {
                DateTime beginDate = this.dateFrom.Text != string.Empty ? this.dateFrom.Value.Date : this.dateFrom.MinDate;
                DateTime endDate = this.dateTo.Text != string.Empty ? this.dateTo.Value.Date : this.dateTo.MinDate;
                string status = this.cbCheckStatus.Text;

                var queryResult = App.Current.DbContext.InvoiceFinanceBatches.Where(i =>
                    i.FinanceBatchNo.Contains(this.tbFinanceBatchNo.Text)
                    && (beginDate != this.dateFrom.MinDate ? i.FinancePeriodBegin >= beginDate : true)
                    && (endDate != this.dateTo.MinDate ? i.FinancePeriodBegin <= endDate : true)
                    && (status != string.Empty ? i.CheckStatus == status : true));
                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());

            }
            else if (this.opBatchType == OpBatchType.DETAIL)
            {
                var queryResult = this.cda.InvoiceFinanceBatches.Where(i => i.FinanceBatchNo.Contains(this.tbFinanceBatchNo.Text));
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
                InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.bs.List[row.Index];
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
            InvoiceFinanceBatch selectedBatch = (InvoiceFinanceBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
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
            if (App.Current.CurUser.Role == "审核员")
            {
                this.menuItemCheck.Visible = true;
                this.menuItemReject.Visible = true;
                this.toolStripSeparator2.Visible = true;
            }
            else
            {
                this.menuItemCheck.Visible = false;
                this.menuItemReject.Visible = false;
                this.toolStripSeparator2.Visible = false;
            }
        }
        #endregion Methods
    }
}

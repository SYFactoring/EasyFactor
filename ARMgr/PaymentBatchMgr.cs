//-----------------------------------------------------------------------
// <copyright file="PaymentBatchMgr.cs" company="Yiming Liu@Fudan">
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
    using System.Data.Linq;
    /// <summary>
    /// 
    /// </summary>
    public partial class PaymentBatchMgr : UserControl
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
            QUERY,
        }

        #endregion Enums

        #region Constructors (2)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedCDA"></param>
        public PaymentBatchMgr(Case selectedCase)
            : this(OpBatchType.DETAIL)
        {
            this._case = selectedCase;
            this.panelQuery.Visible = false;
            this.bs.DataSource = this._case.InvoicePaymentBatches;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchType"></param>
        public PaymentBatchMgr(OpBatchType batchType)
        {
            this.InitializeComponent();
            ControlUtil.SetDoubleBuffered(this.dgvBatches);
            this.dgvBatches.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvBatches.DataSource = bs;
            this.opBatchType = batchType;

            this.UpdateContextMenu();

            if (batchType == OpBatchType.CHECK)
            {
                this.cbCheckStatus.Text = "未复核";
                context = new DBDataContext();
                var queryResult = context.InvoicePaymentBatches.Where(i => i.CheckStatus == "未复核");
                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
        }

        #endregion Constructors

        #region Properties (3)

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets selected PaymentBatch
        /// </summary>
        public InvoicePaymentBatch Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (12)

        // Private Methods (12) 

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

            InvoicePaymentBatch batch = (InvoicePaymentBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            if (MessageBox.Show("是否确认复核通过该批次", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            batch.CheckStatus = "已复核";
            batch.CheckUserName = App.Current.CurUser.Name;
            batch.CheckDate = DateTime.Now.Date;

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

            InvoicePaymentBatch selectedBatch = (InvoicePaymentBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            if (MessageBox.Show("是否打算删除此" + selectedBatch.BatchCount + "条付款记录", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            foreach (InvoicePaymentLog log in selectedBatch.InvoicePaymentLogs)
            {
                Invoice invoice = log.Invoice;
                log.Invoice = null;
                invoice.CaculatePayment();
                context.InvoicePaymentLogs.DeleteOnSubmit(log);
            }

            context.InvoicePaymentBatches.DeleteOnSubmit(selectedBatch);
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

            InvoicePaymentBatch selectedBatch = (InvoicePaymentBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            PaymentBatchDetail detail = new PaymentBatchDetail(selectedBatch);
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
        private void dgvBatches_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = this.dgvBatches.Columns[e.ColumnIndex];
            if (column == colIsMsgCreate)
            {
                Object originalData = e.Value;
                if (originalData != null)
                {
                    bool result = (bool)originalData;
                    if (result)
                    {
                        e.Value = "Y";
                    }
                    else
                    {
                        e.Value = "N";
                    }
                }
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
        private void ExportMSG11(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoicePaymentBatch selectedBatch = (InvoicePaymentBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];

            if (selectedBatch.PaymentType != "买方付款")
            {
                MessageBox.Show("只有间接付款可以生成MSG12", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ExportForm form = new ExportForm(ExportForm.ExportType.EXPORT_MSG11, selectedBatch.InvoicePaymentLogs);
            form.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportMSG12(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoicePaymentBatch selectedBatch = (InvoicePaymentBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];

            if (selectedBatch.PaymentType != "间接付款")
            {
                MessageBox.Show("只有间接付款可以生成MSG12", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ExportForm form = new ExportForm(ExportForm.ExportType.EXPORT_MSG12, selectedBatch.InvoicePaymentLogs);
            form.Show();
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
            string paymentType = this.cbPaymentType.Text;
            string createUserName = this.tbCreateUserName.Text;
            string clientName = this.tbClientName.Text;

            context = new DBDataContext();

            var queryResult = context.InvoicePaymentBatches.Where(i =>
                i.PaymentBatchNo.Contains(this.tbPaymentBatchNo.Text)
                && (beginDate != this.dateFrom.MinDate ? i.PaymentDate >= beginDate : true)
                && (endDate != this.dateTo.MinDate ? i.PaymentDate <= endDate : true)
                && (status != string.Empty ? i.CheckStatus == status : true)
                && (paymentType != string.Empty ? i.PaymentType == paymentType : true)
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

            InvoicePaymentBatch batch = (InvoicePaymentBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            if (MessageBox.Show("是否确认复核退回该批次", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            batch.CheckStatus = "复核未通过";
            batch.CheckUserName = App.Current.CurUser.Name;
            batch.CheckDate = DateTime.Now.Date;

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

            InvoicePaymentBatch selectedBatch = (InvoicePaymentBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
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

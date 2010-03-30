
namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using System.Data.Linq;
    using System.Linq;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class PaymentBatchDetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;
        /// <summary>
        /// 
        /// </summary>
        private OpBatchType opBatchType;

        /// <summary>
        /// 
        /// </summary>
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
            DETAIL_BATCH,

            /// <summary>
            /// 
            /// </summary>
            UPDATE_BATCH,
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batch"></param>
        public PaymentBatchDetail(InvoicePaymentBatch batch)
        {
            this.InitializeComponent();
            this.context = new DBDataContext();
            this.bs = new BindingSource();
            this.dgvPaymentLogs.AutoGenerateColumns = false;
            this.dgvPaymentLogs.DataSource = this.bs;
            this.opBatchType = OpBatchType.DETAIL_BATCH;
            ControlUtil.SetDoubleBuffered(this.dgvPaymentLogs);

            batch = context.InvoicePaymentBatches.SingleOrDefault(i => i.PaymentBatchNo == batch.PaymentBatchNo);
            this.batchBindingSource.DataSource = batch;
            this.bs.DataSource = batch.InvoicePaymentLogs;

            if (((InvoicePaymentLog)bs.List[0]).CreditNote == null)
            {
                colCreditNoteDate.Visible = false;
                colCreditNoteNo.Visible = false;
            }

            this.UpdateBatchControlStatus();
        }

        #endregion Constructors

        #region Methods (7)

        // Private Methods (7) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteLog(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            if (this.dgvPaymentLogs.SelectedRows.Count == 0)
            {
                return;
            }

            InvoicePaymentLog log = (InvoicePaymentLog)this.bs.List[this.dgvPaymentLogs.SelectedRows[0].Index];

            try
            {
                Invoice invoice = log.Invoice;
                log.Invoice = null;
                invoice.CaculatePayment();
                context.InvoicePaymentLogs.DeleteOnSubmit(log);
                log.InvoicePaymentBatch.CheckStatus = "未复核";
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.dgvPaymentLogs.Rows.RemoveAt(this.dgvPaymentLogs.SelectedRows[0].Index);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            InvoicePaymentBatch batch = (InvoicePaymentBatch)this.batchBindingSource.DataSource;
            CaseDetail detail = new CaseDetail(batch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            detail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPaymentLogs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvPaymentLogs.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvPaymentLogs.RowHeadersDefaultCellStyle.Font, rectangle, dgvPaymentLogs.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            if (!this.superValidator.Validate())
            {
                return;
            }

            InvoicePaymentBatch batch = (InvoicePaymentBatch)this.batchBindingSource.DataSource;

            bool isUpdateOK = true;
            try
            {
                context.SubmitChanges(ConflictMode.ContinueOnConflict);
            }
            catch (ChangeConflictException)
            {
                foreach (ObjectChangeConflict cc in context.ChangeConflicts)
                {
                    foreach (MemberChangeConflict mc in cc.MemberConflicts)
                    {
                        mc.Resolve(RefreshMode.KeepChanges);
                    }
                }

                context.SubmitChanges();
            }
            catch (Exception e2)
            {
                isUpdateOK = false;
                MessageBoxEx.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isUpdateOK)
            {
                MessageBoxEx.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            this.opBatchType = OpBatchType.UPDATE_BATCH;
            this.UpdateBatchControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateBatchControlStatus()
        {
            if (this.opBatchType == OpBatchType.DETAIL_BATCH)
            {
                foreach (Control comp in this.panelBatch.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (this.opBatchType == OpBatchType.UPDATE_BATCH)
            {
                foreach (Control comp in this.panelBatch.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                this.caseCodeTextBox.ReadOnly = true;
                this.paymentBatchNoTextBox.ReadOnly = true;
            }

            ControlUtil.SetComponetEditable(this.createUserNameTextBox, false);
        }

        #endregion Methods
    }
}

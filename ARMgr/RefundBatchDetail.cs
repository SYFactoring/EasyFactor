﻿
namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.CaseMgr;
    using System.Data.Linq;

    /// <summary>
    /// 
    /// </summary>
    public partial class RefundBatchDetail : DevComponents.DotNetBar.Office2007Form
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
        public RefundBatchDetail(InvoiceRefundBatch batch)
        {
            this.InitializeComponent();
            this.bs = new BindingSource();
            this.dgvRefundLogs.AutoGenerateColumns = false;
            this.dgvRefundLogs.DataSource = bs;
            this.opBatchType = OpBatchType.DETAIL_BATCH;
            ControlUtil.SetDoubleBuffered(this.dgvRefundLogs);

            this.batchBindingSource.DataSource = batch;
            this.bs.DataSource = batch.InvoiceRefundLogs;

            batch.Backup();
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
        private void BatchDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            InvoiceRefundBatch batch = (InvoiceRefundBatch)this.batchBindingSource.DataSource;
            batch.Restore();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteLog(object sender, EventArgs e)
        {
            if (this.dgvRefundLogs.SelectedRows.Count == 0)
            {
                return;
            }
            InvoiceRefundLog log = (InvoiceRefundLog)this.bs.List[this.dgvRefundLogs.SelectedRows[0].Index];
            try
            {
                Invoice invoice = log.Invoice;
                log.Invoice = null;
                invoice.CaculateRefund();
                App.Current.DbContext.InvoiceRefundLogs.DeleteOnSubmit(log);
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBox.Show("删除失败," + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvRefundLogs.Rows.RemoveAt(this.dgvRefundLogs.SelectedRows[0].Index);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            InvoiceRefundBatch batch = (InvoiceRefundBatch)this.batchBindingSource.DataSource;
            CaseDetail detail = new CaseDetail(batch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            detail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRefundLogs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvRefundLogs.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvRefundLogs.RowHeadersDefaultCellStyle.Font, rectangle, dgvRefundLogs.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBatch(object sender, EventArgs e)
        {
            if (!this.superValidator.Validate())
            {
                return;
            }

            InvoiceRefundBatch batch = (InvoiceRefundBatch)this.batchBindingSource.DataSource;

            bool isUpdateOK = true;
            try
            {
                App.Current.DbContext.SubmitChanges(ConflictMode.ContinueOnConflict);
            }
            catch (ChangeConflictException)
            {
                foreach (ObjectChangeConflict cc in App.Current.DbContext.ChangeConflicts)
                {
                    foreach (MemberChangeConflict mc in cc.MemberConflicts)
                    {
                        mc.Resolve(RefreshMode.KeepChanges);
                    }
                }
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e2)
            {
                isUpdateOK = false;
                MessageBox.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isUpdateOK)
            {
                MessageBox.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                batch.Backup();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBatch(object sender, EventArgs e)
        {
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

                this.CaseCodeTextBox.ReadOnly = true;
                this.refundBatchNoTextBox.ReadOnly = true;
            }
        }

        #endregion Methods
    }
}

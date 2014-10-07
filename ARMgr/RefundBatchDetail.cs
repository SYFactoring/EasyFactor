//-----------------------------------------------------------------------
// <copyright file="RefundBatchDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.CaseMgr;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RefundBatchDetail : Office2007Form
    {
        #region OpBatchType enum

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

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;

        /// <summary>
        /// 
        /// </summary>
        private OpBatchType _opBatchType;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="batch"></param>
        public RefundBatchDetail(InvoiceRefundBatch batch)
        {
            InitializeComponent();
            _context = new DBDataContext();
            _bs = new BindingSource();
            dgvRefundLogs.AutoGenerateColumns = false;
            dgvRefundLogs.DataSource = _bs;
            _opBatchType = OpBatchType.DETAIL_BATCH;
            ControlUtil.SetDoubleBuffered(dgvRefundLogs);

            batch = _context.InvoiceRefundBatches.SingleOrDefault(i => i.RefundBatchNo == batch.RefundBatchNo);
            batchBindingSource.DataSource = batch;
            _bs.DataSource = batch.InvoiceRefundLogs;

            UpdateBatchControlStatus();
        }


        //?Private?Methods?(8)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteLog(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (dgvRefundLogs.SelectedRows.Count == 0)
            {
                return;
            }

            var log = (InvoiceRefundLog) _bs.List[dgvRefundLogs.SelectedRows[0].Index];

            try
            {
                InvoiceFinanceLog financeLog = log.InvoiceFinanceLog;
                log.InvoiceFinanceLog = null;
                InvoiceRefundBatch batch = log.InvoiceRefundBatch;
                log.InvoiceRefundBatch = null;

                financeLog.Invoice.CaculateRefund();
                batch.CaculateRefundAmount();
                _context.InvoiceRefundLogs.DeleteOnSubmit(log);
                //batch.CheckStatus = BATCH.UNCHECK;
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
            }

            dgvRefundLogs.Rows.RemoveAt(dgvRefundLogs.SelectedRows[0].Index);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            var batch = (InvoiceRefundBatch) batchBindingSource.DataSource;
            if (batch.Case != null)
            {
                var detail = new CaseDetail(batch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
                detail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailFinanceBatch(object sender, EventArgs e)
        {
            var batch = (InvoiceRefundBatch) batchBindingSource.DataSource;
            if (batch.InvoiceFinanceBatch != null)
            {
                var detail = new FinanceBatchDetail(batch.InvoiceFinanceBatch);
                detail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailInvoice(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRefundLogs.SelectedRows.Count == 0)
            {
                return;
            }

            var log = (InvoiceRefundLog) _bs.List[dgvRefundLogs.SelectedRows[0].Index];
            var detail = new InvoiceDetail(log.InvoiceFinanceLog.Invoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
            detail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvRefundLogsRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                                          dgvRefundLogs.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvRefundLogs.RowHeadersDefaultCellStyle.Font,
                                  rectangle, dgvRefundLogs.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (!superValidator.Validate())
            {
                return;
            }

            bool isUpdateOK = true;
            try
            {
                _context.SubmitChanges(ConflictMode.ContinueOnConflict);
            }
            catch (ChangeConflictException)
            {
                foreach (ObjectChangeConflict cc in _context.ChangeConflicts)
                {
                    foreach (MemberChangeConflict mc in cc.MemberConflicts)
                    {
                        mc.Resolve(RefreshMode.KeepChanges);
                    }
                }

                _context.SubmitChanges();
            }
            catch (Exception e2)
            {
                isUpdateOK = false;
                MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isUpdateOK)
            {
                MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            _opBatchType = OpBatchType.UPDATE_BATCH;
            UpdateBatchControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateBatchControlStatus()
        {
            if (_opBatchType == OpBatchType.DETAIL_BATCH)
            {
                foreach (Control comp in panelBatch.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (_opBatchType == OpBatchType.UPDATE_BATCH)
            {
                foreach (Control comp in panelBatch.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }

            ControlUtil.SetComponetEditable(caseCodeTextBox, false);
            ControlUtil.SetComponetEditable(createUserNameTextBox, false);
            ControlUtil.SetComponetEditable(refundBatchNoTextBox, false);
            ControlUtil.SetComponetEditable(diInputDate, false);
            ControlUtil.SetComponetEditable(tbCheckStatus, false);
        }
    }
}
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
    public partial class PaymentBatchDetail : Office2007Form
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
        public PaymentBatchDetail(InvoicePaymentBatch batch)
        {
            InitializeComponent();
            _context = new DBDataContext();
            _bs = new BindingSource();
            dgvPaymentLogs.AutoGenerateColumns = false;
            dgvPaymentLogs.DataSource = _bs;
            _opBatchType = OpBatchType.DETAIL_BATCH;
            ControlUtil.SetDoubleBuffered(dgvPaymentLogs);

            batch = _context.InvoicePaymentBatches.SingleOrDefault(i => i.PaymentBatchNo == batch.PaymentBatchNo);
            batchBindingSource.DataSource = batch;
            _bs.DataSource = batch.InvoicePaymentLogs;

            if (((InvoicePaymentLog) _bs.List[0]).CreditNote == null)
            {
                colCreditNoteDate.Visible = false;
                colCreditNoteNo.Visible = false;
            }

            UpdateBatchControlStatus();
        }


        //?Private?Methods?(7)?
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

            if (dgvPaymentLogs.SelectedRows.Count == 0)
            {
                return;
            }

            var log = (InvoicePaymentLog) _bs.List[dgvPaymentLogs.SelectedRows[0].Index];

            try
            {
                Invoice invoice = log.Invoice;
                log.Invoice = null;
                invoice.CaculatePayment();
                _context.InvoicePaymentLogs.DeleteOnSubmit(log);
                //log.InvoicePaymentBatch.CheckStatus = BATCH.UNCHECK;
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
            }

            dgvPaymentLogs.Rows.RemoveAt(dgvPaymentLogs.SelectedRows[0].Index);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            var batch = (InvoicePaymentBatch) batchBindingSource.DataSource;
            var detail = new CaseDetail(batch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            detail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailInvoice(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPaymentLogs.SelectedRows.Count == 0)
            {
                return;
            }

            var log = (InvoicePaymentLog) _bs.List[dgvPaymentLogs.SelectedRows[0].Index];
            var detail = new InvoiceDetail(log.Invoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
            detail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvPaymentLogsRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                                          dgvPaymentLogs.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                                  dgvPaymentLogs.RowHeadersDefaultCellStyle.Font, rectangle,
                                  dgvPaymentLogs.RowHeadersDefaultCellStyle.ForeColor,
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
            ControlUtil.SetComponetEditable(paymentBatchNoTextBox, false);
            ControlUtil.SetComponetEditable(diInputDate, false);
        }
    }
}
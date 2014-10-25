//-----------------------------------------------------------------------
// <copyright file="InvoiceDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceDetail : Office2007Form
    {
        #region OpInvoiceType enum

        /// <summary>
        /// 
        /// </summary>
        public enum OpInvoiceType
        {
            /// <summary>
            /// 
            /// </summary>
            DETAIL_INVOICE,

            /// <summary>
            /// 
            /// </summary>
            UPDATE_INVOICE,

            /// <summary>
            /// 
            /// </summary>
            FLAW,

            /// <summary>
            /// 
            /// </summary>
            DISPUTE
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;

        /// <summary>
        /// 
        /// </summary>
        private OpInvoiceType _opInvoiceType;


        /// <summary>
        /// Initializes a new instance of the InvoiceDetail class
        /// </summary>
        /// <param name="invoice"></param>
        /// <param name="opInvoiceType"></param>
        public InvoiceDetail(Invoice invoice, OpInvoiceType opInvoiceType)
        {
            InitializeComponent();
            _context = new DBDataContext();
            ImeMode = ImeMode.OnHalf;
            _opInvoiceType = opInvoiceType;
            invoice = _context.Invoices.SingleOrDefault(i => i.InvoiceID == invoice.InvoiceID);
            invoiceBindingSource.DataSource = invoice;
            dgvFinanceLogs.AutoGenerateColumns = false;
            dgvPaymentLogs.AutoGenerateColumns = false;
            dgvRefundLogs.AutoGenerateColumns = false;

            invoiceCurrencyComboBox.DataSource = Currency.AllCurrencies;
            invoiceCurrencyComboBox.DisplayMember = "CurrencyCode";
            invoiceCurrencyComboBox.ValueMember = "CurrencyCode";

            flawReasonCheckedListBox.DataSource = FlawReason.AllFlawReasons;
            flawReasonCheckedListBox.DisplayMember = "Reason";
            flawReasonCheckedListBox.ValueMember = "Index";

            disputeReasonCheckedListBox.DataSource = DisputeReason.AllDisputeReasons;
            disputeReasonCheckedListBox.DisplayMember = "Reason";
            disputeReasonCheckedListBox.ValueMember = "Index";

            dgvFinanceLogs.DataSource = invoice.InvoiceFinanceLogs;
            dgvPaymentLogs.DataSource = invoice.InvoicePaymentLogs;
            var refundLogs = new List<InvoiceRefundLog>();
            foreach (InvoiceFinanceLog financeLog in invoice.InvoiceFinanceLogs)
            {
                refundLogs.AddRange(financeLog.InvoiceRefundLogs);
            }

            dgvRefundLogs.DataSource = refundLogs;

            if (invoice.InvoicePaymentLogs.Count > 0)
            {
                if ((invoice.InvoicePaymentLogs[0]).CreditNote != null)
                {
                    colCreditNoteDate.Visible = true;
                    colCreditNoteNo.Visible = true;
                }
            }

            if (invoice.FlawReason != null)
            {
                var reasonList = new List<string>();
                reasonList.AddRange(invoice.FlawReason.Split(';'));
                for (int i = 0; i < flawReasonCheckedListBox.Items.Count; i++)
                {
                    string item = ((FlawReason) flawReasonCheckedListBox.Items[i]).Index;
                    if (reasonList.Contains(item))
                    {
                        flawReasonCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }

            if (invoice.DisputeReason != null)
            {
                var disputeList = new List<string>();
                disputeList.AddRange(invoice.DisputeReason.Split(';'));
                for (int i = 0; i < disputeReasonCheckedListBox.Items.Count; i++)
                {
                    string item = ((DisputeReason) disputeReasonCheckedListBox.Items[i]).Index;
                    if (disputeList.Contains(item))
                    {
                        disputeReasonCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }

            UpdateInvoiceControlStatus();

            if (opInvoiceType == OpInvoiceType.FLAW)
            {
                tabControl.SelectedTab = tabItemFlaw;
            }
            else if (opInvoiceType == OpInvoiceType.DISPUTE)
            {
                tabControl.SelectedTab = tabItemDispute;
            }

            UpdateContextMenu();
        }


        //?Private?Methods?(15)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeletePaymentLog(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (dgvPaymentLogs.SelectedRows.Count == 0)
            {
                return;
            }

            InvoicePaymentLog log =
                ((EntitySet<InvoicePaymentLog>) dgvPaymentLogs.DataSource)[dgvPaymentLogs.SelectedRows[0].Index];

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
        private void DeleteRefundLog(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (dgvRefundLogs.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceRefundLog log =
                ((List<InvoiceRefundLog>) dgvRefundLogs.DataSource)[dgvRefundLogs.SelectedRows[0].Index];

            try
            {
                InvoiceFinanceLog financeLog = log.InvoiceFinanceLog;
                financeLog.InvoiceRefundLogs.Remove(log);
                financeLog.Invoice.CaculateRefund();
                _context.InvoiceRefundLogs.DeleteOnSubmit(log);
                //log.InvoiceRefundBatch.CheckStatus = BATCH.UNCHECK;
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
            }

           // dgvRefundLogs.Rows.RemoveAt(dgvRefundLogs.SelectedRows[0].Index);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailAssignBatch(object sender, EventArgs e)
        {
            var invoice = (Invoice) invoiceBindingSource.DataSource;
            if (invoice.InvoiceAssignBatch != null)
            {
                var detail = new AssignBatchDetail(invoice.InvoiceAssignBatch);
                detail.ShowDialog(this);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailFinanceBatch(object sender, EventArgs e)
        {
            var invoice = (Invoice) invoiceBindingSource.DataSource;
            string[] batchNoes = invoice.FinanceBatchNos.Split(new[] {';'});
            foreach (var detail in from batchNo in batchNoes
                                   select _context.InvoiceFinanceBatches.Single(i => i.FinanceBatchNo == batchNo)
                                   into batch where batch != null select new FinanceBatchDetail(batch))
            {
                detail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailPaymentBatch(object sender, EventArgs e)
        {
            var invoice = (Invoice) invoiceBindingSource.DataSource;
            string[] batchNoes = invoice.PaymentBatchNos.Split(new[] {';'});
            foreach (string batchNo in batchNoes)
            {
                if (batchNo != null)
                {
                    InvoicePaymentBatch batch =
                        _context.InvoicePaymentBatches.SingleOrDefault(i => i.PaymentBatchNo == batchNo);
                    if (batch != null)
                    {
                        var detail = new PaymentBatchDetail(batch);
                        detail.Show();
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailRefundBatch(object sender, EventArgs e)
        {
            var invoice = (Invoice) invoiceBindingSource.DataSource;
            string[] batchNoes = invoice.RefundBatchNos.Split(new[] {';'});
            foreach (string batchNo in batchNoes)
            {
                if (batchNo != null)
                {
                    InvoiceRefundBatch batch = _context.InvoiceRefundBatches.SingleOrDefault(i => i.RefundBatchNo == batchNo);
                    if (batch != null)
                    {
                        var detail = new RefundBatchDetail(batch);
                        detail.Show();
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dispute(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            var invoice = (Invoice) invoiceBindingSource.DataSource;
            invoice.DisputeDate = DateTime.Today;
            invoice.DisputeUserName = App.Current.CurUser.Name;
            invoice.IsDispute = true;
            foreach (Control comp in groupPanelDispute.Controls)
            {
                ControlUtil.SetComponetEditable(comp, true);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisputeResolve(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            var invoice = (Invoice) invoiceBindingSource.DataSource;
            invoice.DisputeResolveDate = DateTime.Today;
            invoice.DisputeResolveUserName = App.Current.CurUser.Name;
            invoice.IsDispute = false;
            foreach (Control comp in groupPanelDisputeResolve.Controls)
            {
                ControlUtil.SetComponetEditable(comp, true);
            }

            var reasonList = new List<string>();
            reasonList.AddRange(invoice.DisputeReason.Split(';'));
            string disputeResolveReason = reasonList.Aggregate(string.Empty, (current, reason) => current + (reason + " 已解除" + Environment.NewLine));

            invoice.DisputeResolveReason = disputeResolveReason;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Flaw(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            flawReasonCheckedListBox.Enabled = true;
            tbFlawReason.ReadOnly = false;
            var invoice = (Invoice) invoiceBindingSource.DataSource;
            invoice.IsFlaw = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlawResolve(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            var invoice = (Invoice) invoiceBindingSource.DataSource;
            invoice.FlawResolveDate = DateTime.Today;
            invoice.FlawResolveUserName = App.Current.CurUser.Name;
            invoice.IsFlaw = false;

            flawResolveDateDateTimePicker.Enabled = true;
            tbFlawResolveReason.ReadOnly = false;
            flawResolveUserNameTextBox.ReadOnly = false;

            var reasonList = new List<string>();
            reasonList.AddRange(invoice.FlawReason.Split(';'));
            string flawResolveReason = reasonList.Aggregate(string.Empty, (current, reason) => current + (reason + " 已解除" + Environment.NewLine));

            invoice.FlawResolveReason = flawResolveReason;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveEDI(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (!superValidator.Validate())
            {
                return;
            }

            var invoice = (Invoice) invoiceBindingSource.DataSource;

            string flawReason = flawReasonCheckedListBox.CheckedItems.Cast<FlawReason>().Aggregate(string.Empty, (current, item) => current + (item.Index + ";"));

            invoice.FlawReason = flawReason;

            string disputeReason = disputeReasonCheckedListBox.CheckedItems.Cast<string>().Aggregate(string.Empty, (current, item) => current + (item + ";"));

            invoice.DisputeReason = disputeReason;

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
        private void SaveInvoice(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (!superValidator.Validate())
            {
                return;
            }

            var invoice = (Invoice) invoiceBindingSource.DataSource;

            string flawReason = flawReasonCheckedListBox.CheckedItems.Cast<FlawReason>().Aggregate(string.Empty, (current, item) => current + (item.Index + ";"));

            invoice.FlawReason = flawReason;

            string disputeReason = disputeReasonCheckedListBox.CheckedItems.Cast<DisputeReason>().Aggregate(string.Empty, (current, item) => current + (item.Index + ";"));

            invoice.DisputeReason = disputeReason;

            bool isUpdateOK = true;
            //if (invoice.InvoiceAssignBatch.CheckStatus != BATCH.CHECK)
            //{
            //    invoice.InvoiceAssignBatch.CheckStatus = BATCH.UNCHECK;
            //}

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
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permissions.INVOICE_UPDATE))
            {
                menuItemPaymentLogDelete.Enabled = true;
                menuItemRefundLogDelete.Enabled = true;
            }
            else
            {
                menuItemPaymentLogDelete.Enabled = false;
                menuItemRefundLogDelete.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateInvoice(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            _opInvoiceType = OpInvoiceType.UPDATE_INVOICE;
            UpdateInvoiceControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateInvoiceControlStatus()
        {
            if (_opInvoiceType == OpInvoiceType.DETAIL_INVOICE || _opInvoiceType == OpInvoiceType.FLAW ||
                _opInvoiceType == OpInvoiceType.DISPUTE)
            {
                foreach (Control comp in groupPanelInvoiceBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in groupPanelInvoiceProcess.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in groupPanelInvoiceAdv.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (_opInvoiceType == OpInvoiceType.UPDATE_INVOICE)
            {
                foreach (Control comp in groupPanelInvoiceBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in groupPanelInvoiceProcess.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                invoiceNoTextBox.ReadOnly = false;
                invoiceAmountTextBox.ReadOnly = false;
                invoiceDateTextBox.Enabled = true;
                dueDateTextBox.Enabled = true;
                commentTextBox.ReadOnly = false;
                assignAmountTextBox.ReadOnly = false;
                paidCommissionTextBox.ReadOnly = false;
                tbFactorCommission.ReadOnly = false;

                foreach (Control comp in groupPanelInvoiceAdv.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }

            foreach (Control comp in groupPanelFlaw.Controls)
            {
                ControlUtil.SetComponetEditable(comp, false);
            }

            foreach (Control comp in groupPanelFlawResolve.Controls)
            {
                ControlUtil.SetComponetEditable(comp, false);
            }

            foreach (Control comp in groupPanelDispute.Controls)
            {
                ControlUtil.SetComponetEditable(comp, false);
            }

            foreach (Control comp in groupPanelDisputeResolve.Controls)
            {
                ControlUtil.SetComponetEditable(comp, false);
            }

            btnFlaw.Enabled = true;
            btnFlawResolve.Enabled = true;
            isDisputeCheckBox.Enabled = true;
            isFlawCheckBox.Enabled = true;

            ControlUtil.SetComponetEditable(flawResolveUserNameTextBox, false);
            ControlUtil.SetComponetEditable(disputeResolveUserNameTextBox, false);
            ControlUtil.SetComponetEditable(disputeUserNameTextBox, false);
        }

    }
}
//-----------------------------------------------------------------------
// <copyright file="InvoiceDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections.Generic;
    using System.Data.Linq;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using System.Collections;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceDetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;
        /// <summary>
        /// 
        /// </summary>
        private OpInvoiceType opInvoiceType;

        #endregion Fields

        #region Enums (1)

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

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the InvoiceDetail class
        /// </summary>
        /// <param name="invoice"></param>
        /// <param name="opInvoiceType"></param>
        public InvoiceDetail(Invoice invoice, OpInvoiceType opInvoiceType)
        {
            this.InitializeComponent();
            this.context = new DBDataContext();
            this.ImeMode = ImeMode.OnHalf;
            this.opInvoiceType = opInvoiceType;
            invoice = context.Invoices.SingleOrDefault(i => i.InvoiceNo == invoice.InvoiceNo);
            this.invoiceBindingSource.DataSource = invoice;
            this.dgvFinanceLogs.AutoGenerateColumns = false;
            this.dgvPaymentLogs.AutoGenerateColumns = false;
            this.dgvRefundLogs.AutoGenerateColumns = false;

            this.invoiceCurrencyComboBox.DataSource = Currency.AllCurrencies();
            this.invoiceCurrencyComboBox.DisplayMember = "CurrencyCode";
            this.invoiceCurrencyComboBox.ValueMember = "CurrencyCode";

            this.flawReasonCheckedListBox.DataSource = FlawReason.GetAllFlawReasons();
            this.flawReasonCheckedListBox.DisplayMember = "Reason";
            this.flawReasonCheckedListBox.ValueMember = "Index";

            this.disputeReasonCheckedListBox.DataSource = DisputeReason.GetAllDisputeReasons();
            this.disputeReasonCheckedListBox.DisplayMember = "Reason";
            this.disputeReasonCheckedListBox.ValueMember = "Index";

            this.dgvFinanceLogs.DataSource = invoice.InvoiceFinanceLogs;
            this.dgvPaymentLogs.DataSource = invoice.InvoicePaymentLogs;
            List<InvoiceRefundLog> refundLogs = new List<InvoiceRefundLog>();
            foreach (InvoiceFinanceLog financeLog in invoice.InvoiceFinanceLogs)
            {
                refundLogs.AddRange(financeLog.InvoiceRefundLogs);
            }

            this.dgvRefundLogs.DataSource = refundLogs;

            if (invoice.InvoicePaymentLogs.Count > 0)
            {
                if (((InvoicePaymentLog)invoice.InvoicePaymentLogs[0]).CreditNote != null)
                {
                    colCreditNoteDate.Visible = true;
                    colCreditNoteNo.Visible = true;
                }
            }

            if (invoice.FlawReason != null)
            {
                List<string> reasonList = new List<string>();
                reasonList.AddRange(invoice.FlawReason.Split(';'));
                for (int i = 0; i < this.flawReasonCheckedListBox.Items.Count; i++)
                {
                    string item = ((FlawReason)this.flawReasonCheckedListBox.Items[i]).Index;
                    if (reasonList.Contains(item))
                    {
                        this.flawReasonCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }

            if (invoice.DisputeReason != null)
            {
                List<string> disputeList = new List<string>();
                disputeList.AddRange(invoice.DisputeReason.Split(';'));
                for (int i = 0; i < this.disputeReasonCheckedListBox.Items.Count; i++)
                {
                    string item = ((DisputeReason)this.disputeReasonCheckedListBox.Items[i]).Index;
                    if (disputeList.Contains(item))
                    {
                        this.disputeReasonCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }

            this.UpdateInvoiceControlStatus();

            if (opInvoiceType == OpInvoiceType.FLAW)
            {
                this.tabControl.SelectedTab = this.tabItemFlaw;
            }
            else if (opInvoiceType == OpInvoiceType.DISPUTE)
            {
                this.tabControl.SelectedTab = this.tabItemDispute;
            }

            this.UpdateContextMenu();
        }

        #endregion Constructors

        #region Methods (15)

        // Private Methods (15) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeletePaymentLog(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            if (this.dgvPaymentLogs.SelectedRows.Count == 0)
            {
                return;
            }

            InvoicePaymentLog log = (InvoicePaymentLog)((EntitySet<InvoicePaymentLog>)this.dgvPaymentLogs.DataSource)[this.dgvPaymentLogs.SelectedRows[0].Index];

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
        private void DeleteRefundLog(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            if (this.dgvRefundLogs.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceRefundLog log = (InvoiceRefundLog)((EntitySet<InvoiceRefundLog>)this.dgvRefundLogs.DataSource)[this.dgvRefundLogs.SelectedRows[0].Index];

            try
            {
                InvoiceFinanceLog financeLog = log.InvoiceFinanceLog;
                financeLog.InvoiceRefundLogs.Remove(log);
                financeLog.Invoice.CaculateRefund();
                context.InvoiceRefundLogs.DeleteOnSubmit(log);
                log.InvoiceRefundBatch.CheckStatus = "未复核";
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.dgvRefundLogs.Rows.RemoveAt(this.dgvRefundLogs.SelectedRows[0].Index);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailAssignBatch(object sender, EventArgs e)
        {
            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            if (invoice.InvoiceAssignBatch != null)
            {
                AssignBatchDetail detail = new AssignBatchDetail(invoice.InvoiceAssignBatch);
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
            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            string[] batchNoes = invoice.FinanceBatchNos.Split(new char[] { ';' });
            foreach (string batchNo in batchNoes)
            {
                InvoiceFinanceBatch batch = context.InvoiceFinanceBatches.Single(i => i.FinanceBatchNo == batchNo);
                if (batch != null)
                {
                    FinanceBatchDetail detail = new FinanceBatchDetail(batch);
                    detail.Show();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailPaymentBatch(object sender, EventArgs e)
        {
            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            string[] batchNoes = invoice.PaymentBatchNos.Split(new char[] { ';' });
            foreach (string batchNo in batchNoes)
            {
                InvoicePaymentBatch batch = context.InvoicePaymentBatches.SingleOrDefault(i => i.PaymentBatchNo == batchNo);
                if (batch != null)
                {
                    PaymentBatchDetail detail = new PaymentBatchDetail(batch);
                    detail.Show();
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
            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            string[] batchNoes = invoice.RefundBatchNos.Split(new char[] { ';' });
            foreach (string batchNo in batchNoes)
            {
                InvoiceRefundBatch batch = context.InvoiceRefundBatches.SingleOrDefault(i => i.RefundBatchNo == batchNo);
                if (batch != null)
                {
                    RefundBatchDetail detail = new RefundBatchDetail(batch);
                    detail.Show();
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
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            invoice.DisputeDate = DateTime.Now.Date;
            invoice.DisputeUserName = App.Current.CurUser.Name;
            invoice.IsDispute = true;
            foreach (Control comp in this.groupPanelDispute.Controls)
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
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            invoice.DisputeResolveDate = DateTime.Now.Date;
            invoice.DisputeResolveUserName = App.Current.CurUser.Name;
            invoice.IsDispute = false;
            foreach (Control comp in this.groupPanelDisputeResolve.Controls)
            {
                ControlUtil.SetComponetEditable(comp, true);
            }

            List<string> reasonList = new List<string>();
            reasonList.AddRange(invoice.DisputeReason.Split(';'));
            string disputeResolveReason = string.Empty;
            foreach (string reason in reasonList)
            {
                disputeResolveReason += (reason + " 已解除" + Environment.NewLine);
            }

            invoice.DisputeResolveReason = disputeResolveReason;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Flaw(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            this.flawReasonCheckedListBox.Enabled = true;
            this.tbFlawReason.ReadOnly = false;
            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            invoice.IsFlaw = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlawResolve(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;
            invoice.FlawResolveDate = DateTime.Now.Date;
            invoice.FlawResolveUserName = App.Current.CurUser.Name;
            invoice.IsFlaw = false;

            this.flawResolveDateDateTimePicker.Enabled = true;
            this.tbFlawResolveReason.ReadOnly = false;
            this.flawResolveUserNameTextBox.ReadOnly = false;

            List<string> reasonList = new List<string>();
            reasonList.AddRange(invoice.FlawReason.Split(';'));
            string flawResolveReason = string.Empty;
            foreach (string reason in reasonList)
            {
                flawResolveReason += (reason + " 已解除" + Environment.NewLine);
            }

            invoice.FlawResolveReason = flawResolveReason;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveEDI(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            if (!this.superValidator.Validate())
            {
                return;
            }

            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;

            string flawReason = string.Empty;
            foreach (FlawReason item in this.flawReasonCheckedListBox.CheckedItems)
            {
                flawReason += (item.Index + ";");
            }

            invoice.FlawReason = flawReason;

            string disputeReason = string.Empty;
            foreach (string item in this.disputeReasonCheckedListBox.CheckedItems)
            {
                disputeReason += (item + ";");
            }

            invoice.DisputeReason = disputeReason;

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
        private void SaveInvoice(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            if (!this.superValidator.Validate())
            {
                return;
            }

            Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;

            string flawReason = string.Empty;
            foreach (FlawReason item in this.flawReasonCheckedListBox.CheckedItems)
            {
                flawReason += (item.Index + ";");
            }

            invoice.FlawReason = flawReason;

            string disputeReason = string.Empty;
            foreach (string item in this.disputeReasonCheckedListBox.CheckedItems)
            {
                disputeReason += (item + ";");
            }

            invoice.DisputeReason = disputeReason;

            bool isUpdateOK = true;
            if (invoice.InvoiceAssignBatch.CheckStatus != ConstStr.BATCH.CHECK)
            {
                invoice.InvoiceAssignBatch.CheckStatus = ConstStr.BATCH.UNCHECK;
            }

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
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permission.INVOICE_UPDATE))
            {
                this.menuItemPaymentLogDelete.Enabled = true;
                this.menuItemRefundLogDelete.Enabled = true;
            }
            else
            {
                this.menuItemPaymentLogDelete.Enabled = false;
                this.menuItemRefundLogDelete.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateInvoice(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            this.opInvoiceType = OpInvoiceType.UPDATE_INVOICE;
            this.UpdateInvoiceControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateInvoiceControlStatus()
        {
            if (this.opInvoiceType == OpInvoiceType.DETAIL_INVOICE || this.opInvoiceType == OpInvoiceType.FLAW || this.opInvoiceType == OpInvoiceType.DISPUTE)
            {
                foreach (Control comp in this.groupPanelInvoiceBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in this.groupPanelInvoiceProcess.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in this.groupPanelInvoiceAdv.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (this.opInvoiceType == OpInvoiceType.UPDATE_INVOICE)
            {
                foreach (Control comp in this.groupPanelInvoiceBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in this.groupPanelInvoiceProcess.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                Invoice invoice = (Invoice)this.invoiceBindingSource.DataSource;

                if (invoice.InvoiceAssignBatch.CheckStatus == ConstStr.BATCH.CHECK)
                {
                    this.invoiceAmountTextBox.ReadOnly = true;
                    this.invoiceDateTextBox.Enabled = false;
                    this.dueDateTextBox.Enabled = false;
                    this.commentTextBox.ReadOnly = true;
                    this.assignAmountTextBox.ReadOnly = true;
                }
                else
                {
                    this.invoiceAmountTextBox.ReadOnly = false;
                    this.invoiceDateTextBox.Enabled = true;
                    this.dueDateTextBox.Enabled = true;
                    this.commentTextBox.ReadOnly = false;
                    this.assignAmountTextBox.ReadOnly = false;
                }

                foreach (Control comp in this.groupPanelInvoiceAdv.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

            }

            foreach (Control comp in this.groupPanelFlaw.Controls)
            {
                ControlUtil.SetComponetEditable(comp, false);
            }

            foreach (Control comp in this.groupPanelFlawResolve.Controls)
            {
                ControlUtil.SetComponetEditable(comp, false);
            }

            foreach (Control comp in this.groupPanelDispute.Controls)
            {
                ControlUtil.SetComponetEditable(comp, false);
            }

            foreach (Control comp in this.groupPanelDisputeResolve.Controls)
            {
                ControlUtil.SetComponetEditable(comp, false);
            }

            this.btnFlaw.Enabled = true;
            this.btnFlawResolve.Enabled = true;
            this.isDisputeCheckBox.Enabled = true;
            this.isFlawCheckBox.Enabled = true;

            ControlUtil.SetComponetEditable(this.flawResolveUserNameTextBox, false);
            ControlUtil.SetComponetEditable(this.disputeResolveUserNameTextBox, false);
            ControlUtil.SetComponetEditable(this.disputeUserNameTextBox, false);
        }

        #endregion Methods

    }
}

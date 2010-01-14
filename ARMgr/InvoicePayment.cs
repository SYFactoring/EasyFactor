﻿//-----------------------------------------------------------------------
// <copyright file="InvoicePayment.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoicePayment : UserControl
    {
        #region Fields (3)

        private CDA _CDA;
        private ARCaseBasic caseBasic;
        private OpPaymentType paymentType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpPaymentType
        {
            /// <summary>
            /// 
            /// </summary>
            BUYER_PAYMENT,

            /// <summary>
            /// 
            /// </summary>
            INDIRECT_PAYMENT,

            /// <summary>
            /// 
            /// </summary>
            SELLER_PAYMENT,

            /// <summary>
            /// 
            /// </summary>
            GUARANTEE_PAYMENT,

            /// <summary>
            /// 
            /// </summary>
            SELLER_REASSIGN,

            /// <summary>
            /// 
            /// </summary>
            CREDIT_NOTE_PAYMENT,
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        public InvoicePayment(ARCaseBasic caseBasic, OpPaymentType paymentType)
        {
            InitializeComponent();
            this.caseBasic = caseBasic;
            this.paymentType = paymentType;
            this.dgvInvoices.AutoGenerateColumns = false;
            this.superValidator.Enabled = false;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);

            this.dgvInvoices.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvInvoices_CellFormatting);
            this.dgvInvoices.CellParsing += new DataGridViewCellParsingEventHandler(dgvInvoices_CellParsing);

            foreach (DataGridViewColumn column in this.dgvInvoices.Columns)
            {
                column.ReadOnly = true;
            }
            if (paymentType == OpPaymentType.CREDIT_NOTE_PAYMENT)
            {
                colCreditNoteDate2.Visible = true;
                colCreditNoteNo2.Visible = true;
            }
            colCheckBox.ReadOnly = false;
        }

        #endregion Constructors

        #region Properties (1)

        /// <summary>
        /// 
        /// </summary>
        public CDA CDA
        {
            set
            {
                this._CDA = value;
                NewBatch(null, null);
            }
        }

        #endregion Properties

        #region Methods (19)

        // Public Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        public void ResetControlsStatus()
        {
            foreach (Control comp in this.panelPaymentBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }
            this.batchBindingSource.DataSource = typeof(InvoicePaymentBatch);
            this.invoiceBindingSource.DataSource = typeof(Invoice);
        }
        // Private Methods (17) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[this.dgvInvoices.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedInvoice.InvoiceAssignBatch.CDA.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCDA(object sender, EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[this.dgvInvoices.CurrentCell.RowIndex];
            CDADetail cdaDetail = new CDADetail(selectedInvoice.InvoiceAssignBatch.CDA, CDADetail.OpCDAType.DETAIL_CDA);
            cdaDetail.ShowDialog(this);
        }

        /// <summary>
        /// Show detail info of selected inovice
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailInvoice(object sender, System.EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[this.dgvInvoices.CurrentCell.RowIndex];
            InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
            invoiceDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            IList invoicePaymentList = this.invoiceBindingSource.List;
            Invoice invoice = (Invoice)invoicePaymentList[e.RowIndex];
            this.dgvInvoices.EndEdit();
            if (this.dgvInvoices.Columns[e.ColumnIndex] == colCheckBox)
            {

                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)this.dgvInvoices.Rows[e.RowIndex].Cells[0];

                if (Boolean.Parse(checkBoxCell.EditedFormattedValue.ToString()))
                {
                    invoice.PaymentAmount2 = invoice.AssignAmount;
                    if (invoice.PaymentAmount2.HasValue)
                    {
                        invoice.PaymentDate2 = DateTime.Now.Date;
                    }
                    invoice.RefundAmount2 = invoice.FinanceAmount;
                    if (invoice.RefundAmount2.HasValue)
                    {
                        invoice.RefundDate2 = DateTime.Now.Date;
                    }
                    ResetRow(e.RowIndex, true);
                }
                else
                {
                    ResetRow(e.RowIndex, false);
                }
                StatBatch();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }
            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colAssignDate || col == colDueDate || col == colFinanceDate || col == colFinanceDueDate || col == colPaymentDate2 || col == colRefundDate2 || col == colCreditNoteDate2)
            {
                DateTime date = (DateTime)e.Value;
                e.Value = date.ToString("yyyyMMdd");
                e.FormattingApplied = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dgvInvoices_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }
            if (e.Value.Equals(string.Empty))
            {
                e.Value = null;
                e.ParsingApplied = true;
                return;
            }
            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colPaymentDate2 || col == colRefundDate2 || col == colCreditNoteDate2)
            {
                string str = (string)e.Value;
                e.Value = DateTime.ParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
                e.ParsingApplied = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue == null || e.FormattedValue.Equals(string.Empty))
            {
                return;
            }
            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colPaymentDate2 || col == colRefundDate2 || col == colCreditNoteDate2)
            {
                string str = (string)e.FormattedValue;
                DateTime result;
                bool ok = DateTime.TryParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
            else if (col == colPaymentAmount2 || col == colRefundAmount2)
            {
                string str = (string)e.FormattedValue;
                double result;
                bool ok = Double.TryParse(str, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
                if (result < 0)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (this.dgvInvoices.Columns[e.ColumnIndex] == colPaymentAmount2 || this.dgvInvoices.Columns[e.ColumnIndex] == colRefundAmount2)
            {
                StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.DetailInvoice(null, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!(this.batchBindingSource.DataSource is InvoicePaymentBatch))
            {
                return;
            }
            if (this.invoiceBindingSource.List.Count == 0)
            {
                return;
            }

            ExportUtil exportUtil = new ExportUtil(ExportUtil.ExportType.EXPORT_PAYMENTS);
            exportUtil.StartExport(this.invoiceBindingSource.List);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!(this.batchBindingSource.DataSource is InvoicePaymentBatch))
            {
                return;
            }

            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_PAYMENTS_BY_BATCH);
            importForm.ShowDialog(this);
            IList invoiceList = importForm.ImportedList;
            if (invoiceList != null)
            {
                for (int i = 0; i < this.invoiceBindingSource.List.Count; i++)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvInvoices.Rows[i].Cells[0];
                    cell.Value = 0;
                    Invoice oldInvoice = (Invoice)this.invoiceBindingSource.List[i];
                    int index = invoiceList.IndexOf(oldInvoice);
                    if (invoiceList.Contains(oldInvoice) && oldInvoice.PaymentAmount2 > 0)
                    {
                        cell.Value = 1;
                    }
                    ResetRow(i, 1 == (int)cell.Value ? true : false);
                }
                this.StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.tbTotalPayment.Text = string.Empty;
            InvoicePaymentBatch batch = new InvoicePaymentBatch();
            switch (paymentType)
            {
                case OpPaymentType.BUYER_PAYMENT:
                    batch.PaymentType = "买方还款";
                    break;
                case OpPaymentType.INDIRECT_PAYMENT:
                    batch.PaymentType = "间接还款";
                    break;
                case OpPaymentType.SELLER_PAYMENT:
                    batch.PaymentType = "卖方还款";
                    break;
                case OpPaymentType.GUARANTEE_PAYMENT:
                    batch.PaymentType = "担保付款";
                    break;
                case OpPaymentType.SELLER_REASSIGN:
                    batch.PaymentType = "卖方回购";
                    break;
                case OpPaymentType.CREDIT_NOTE_PAYMENT:
                    batch.PaymentType = "贷项通知";
                    break;
                default:
                    break;
            }
            batch.PaymentDate = DateTime.Now.Date;
            batch.CreateUserName = App.Current.CurUser.Name;
            batch.CheckStatus = "未复核";
            this.batchBindingSource.DataSource = batch;

            var queryResult = from invoice in App.Current.DbContext.Invoices
                              where invoice.InvoiceAssignBatch.CDACode == this._CDA.CDACode && (invoice.PaymentAmount.HasValue == false || invoice.RefundAmount.HasValue == false)
                              select invoice;
            this.invoiceBindingSource.DataSource = queryResult;
            this.StatBatch();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="editable"></param>
        private void ResetRow(int rowIndex, bool editable)
        {
            this.dgvInvoices.Rows[rowIndex].Cells["colPaymentAmount2"].ReadOnly = !editable;
            this.dgvInvoices.Rows[rowIndex].Cells["colPaymentDate2"].ReadOnly = !editable;
            this.dgvInvoices.Rows[rowIndex].Cells["colRefundAmount2"].ReadOnly = !editable;
            this.dgvInvoices.Rows[rowIndex].Cells["colRefundDate2"].ReadOnly = !editable;
            this.dgvInvoices.Rows[rowIndex].Cells["colCreditNoteNo2"].ReadOnly = !editable;
            this.dgvInvoices.Rows[rowIndex].Cells["colCreditNoteDate2"].ReadOnly = !editable;
            if (!editable)
            {
                IList invoiceList = this.invoiceBindingSource.List;
                Invoice invoice = (Invoice)invoiceList[rowIndex];
                invoice.PaymentAmount2 = null;
                invoice.PaymentDate2 = null;
                invoice.RefundAmount2 = null;
                invoice.RefundDate2 = null;
                invoice.CreditNoteDate2 = null;
                invoice.CreditNoteNo2 = null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!this.superValidator.Validate())
            {
                return;
            }
            if (!(this.batchBindingSource.DataSource is InvoicePaymentBatch))
            {
                return;
            }
            if (!ValidateBatch())
            {
                return;
            }

            bool isSaveOK = true;
            InvoicePaymentBatch batch = (InvoicePaymentBatch)this.batchBindingSource.DataSource;
            IList invoiceList = this.invoiceBindingSource.List;
            List<InvoicePaymentLog> logList = new List<InvoicePaymentLog>();
            try
            {
                batch.CDA = this._CDA;
                if (batch.PaymentBatchNo == null)
                {
                    batch.PaymentBatchNo = Invoice.GeneratePaymentBatchNo(DateTime.Now.Date);
                }
                for (int i = 0; i < invoiceList.Count; i++)
                {
                    if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                    {
                        Invoice invoice = (Invoice)invoiceList[i];
                        InvoicePaymentLog log;
                        if (invoice.PaymentLogID2 == null)
                        {
                            log = new InvoicePaymentLog();
                            logList.Add(log);
                        }
                        else
                        {
                            log = App.Current.DbContext.InvoicePaymentLogs.SingleOrDefault(paymentlog => paymentlog.PaymentLogID == invoice.PaymentLogID2);
                            if (log == null)
                            {
                                throw new Exception("还款ID错误");
                            }
                        }
                        log.PaymentAmount = invoice.PaymentAmount2;
                        log.PaymentDate = invoice.PaymentDate2;
                        log.RefundAmount = invoice.RefundAmount2;
                        log.RefundDate = invoice.RefundDate2;
                        log.Invoice = invoice;
                        CreditNote creditNote = null;
                        if (invoice.CreditNoteNo2 != null && invoice.CreditNoteNo2 != string.Empty)
                        {
                            creditNote = App.Current.DbContext.CreditNotes.SingleOrDefault(c => c.CreditNoteNo == invoice.CreditNoteNo2);
                            if (creditNote == null)
                            {
                                creditNote = new CreditNote();
                                creditNote.CreditNoteNo = invoice.CreditNoteNo2;
                                if (invoice.CreditNoteDate2.HasValue)
                                {
                                    creditNote.CreditNoteDate = invoice.CreditNoteDate2.Value;
                                }
                            }
                        }
                        if (creditNote != null)
                        {
                            log.CreditNote = creditNote;
                        }
                        log.InvoicePaymentBatch = batch;
                    }
                }
                if (batch.InvoicePaymentLogs.Count == 0)
                {
                    return;
                }

                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (InvoicePaymentLog log in logList)
                {
                    log.Invoice = null;
                    log.CreditNote = null;
                    log.InvoicePaymentBatch = null;
                }
                batch.CDA = null;
                isSaveOK = false;
                MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (isSaveOK)
            {
                MessageBox.Show("数据保存成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (InvoicePaymentLog log in logList)
                {
                    Invoice invoice = log.Invoice;
                    invoice.PaymentAmount = invoice.InvoicePaymentLogs.Sum(logs => logs.PaymentAmount);
                    invoice.PaymentDate = invoice.InvoicePaymentLogs.Max(logs => logs.PaymentDate);
                    invoice.RefundAmount = invoice.InvoicePaymentLogs.Sum(logs => logs.RefundAmount);
                    invoice.RefundDate = invoice.InvoicePaymentLogs.Max(logs => logs.RefundDate);
                    invoice.PaymentAmount2 = null;
                    invoice.RefundAmount2 = null;
                }
                App.Current.DbContext.SubmitChanges();
                this.caseBasic.CaculateOutstanding(this._CDA);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PaymentBatchMgr batchMgr = new PaymentBatchMgr(this._CDA);
            QueryForm queryUI = new QueryForm(batchMgr, "选择付款批次");
            batchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoicePaymentBatch selectedBatch = batchMgr.Selected;
            if (selectedBatch != null)
            {
                this.batchBindingSource.DataSource = selectedBatch;
                Func<InvoicePaymentLog, Invoice> makeInvoice =
                i => new Invoice { InvoiceNo = i.InvoiceNo, PaymentLogID2 = i.PaymentLogID };

                var invoiceList = from log in selectedBatch.InvoicePaymentLogs
                                  select makeInvoice(log);

                this.invoiceBindingSource.DataSource = invoiceList;
                for (int i = 0; i < this.invoiceBindingSource.List.Count; i++)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvInvoices.Rows[i].Cells[0];
                    cell.Value = 1;
                    ResetRow(i, true);
                }
                this.StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void StatBatch()
        {
            IList paymentLogList = this.invoiceBindingSource.List;
            double totalPayment = 0;
            double totalRefund = 0;
            for (int i = 0; i < paymentLogList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    totalPayment += ((Invoice)paymentLogList[i]).PaymentAmount2.GetValueOrDefault();
                    totalRefund += ((Invoice)paymentLogList[i]).RefundAmount2.GetValueOrDefault();
                }
            }
            this.tbTotalPayment.Text = String.Format("{0:N2}", totalPayment);
            this.tbTotalRefund.Text = String.Format("{0:N2}", totalRefund);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidateBatch()
        {
            foreach (Invoice invoice in this.invoiceBindingSource.List)
            {
                if (TypeUtil.LessZero(invoice.AssignOutstanding))
                {
                    MessageBox.Show("付款金额不能大于转让金额: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (TypeUtil.LessZero(invoice.FinanceOutstanding))
                {
                    MessageBox.Show("还款金额不能大于融资金额: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (TypeUtil.GreaterZero(invoice.RefundAmount2 - invoice.PaymentAmount2))
                {
                    MessageBox.Show("还款金额不能大于付款金额: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        #endregion Methods
    }
}

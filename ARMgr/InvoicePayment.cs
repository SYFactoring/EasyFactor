//-----------------------------------------------------------------------
// <copyright file="InvoicePayment.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar;
    using CMBC.EasyFactor.Controls;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoicePayment : UserControl
    {
        #region Fields (4)

        /// <summary>
        /// 
        /// </summary>
        private Case _case;
        /// <summary>
        /// 
        /// </summary>
        private ARCaseBasic caseBasic;
        private DBDataContext context;
        /// <summary>
        /// 
        /// </summary>
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
            this.ImeMode = ImeMode.OnHalf;
            this.dgvInvoices.ImeMode = ImeMode.OnHalf;

            DataGridViewCheckboxHeaderCell checkBoxCell = new DataGridViewCheckboxHeaderCell();
            checkBoxCell.OnCheckBoxClicked += new DataGridViewCheckboxHeaderEventHander(OnCheckBoxClicked);
            DataGridViewCheckBoxColumn checkBoxCol = this.dgvInvoices.Columns[0] as DataGridViewCheckBoxColumn;
            checkBoxCol.HeaderCell = checkBoxCell;
            checkBoxCol.HeaderCell.Value = string.Empty;

            this.caseBasic = caseBasic;
            this.paymentType = paymentType;
            this.dgvInvoices.AutoGenerateColumns = false;
            this.superValidator.Enabled = false;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);

            foreach (DataGridViewColumn column in this.dgvInvoices.Columns)
            {
                column.ReadOnly = true;
            }
            if (paymentType == OpPaymentType.CREDIT_NOTE_PAYMENT)
            {
                colCreditNoteDate2.Visible = true;
                colCreditNoteNo2.Visible = true;
            }
            else
            {
                colCreditNoteDate2.Visible = false;
                colCreditNoteNo2.Visible = false;
            }

            colCheckBox.ReadOnly = false;

            this.context = new DBDataContext();
        }

        #endregion Constructors

        #region Properties (1)

        /// <summary>
        /// 
        /// </summary>
        public Case Case
        {
            set
            {
                this._case = this.context.Cases.SingleOrDefault(c => c.CaseCode == value.CaseCode);
                this.NewBatch(null, null);
            }
        }

        #endregion Properties

        #region Methods (20)

        // Public Methods (1) 

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
        // Private Methods (19) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoice"></param>
        private void ClickInvoice(Invoice invoice)
        {
            invoice.PaymentAmount2 = invoice.AssignOutstanding;
        }

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
            CaseDetail caseDetail = new CaseDetail(selectedInvoice.InvoiceAssignBatch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
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
            CDADetail cdaDetail = new CDADetail(selectedInvoice.InvoiceAssignBatch.Case.ActiveCDA, CDADetail.OpCDAType.DETAIL_CDA);
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
                    ClickInvoice(invoice);
                    this.ResetRow(e.RowIndex, true);
                }
                else
                {
                    this.ResetRow(e.RowIndex, false);
                }

                this.StatBatch();
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
            if (col == colAssignDate || col == colDueDate || col == colFinanceDate || col == colFinanceDueDate || col == colCreditNoteDate2)
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
            if (col == colCreditNoteDate2)
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
            if (col == colCreditNoteDate2)
            {
                string str = (string)e.FormattedValue;
                DateTime result;
                bool ok = DateTime.TryParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
            else if (col == colPaymentAmount2)
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

            if (this.dgvInvoices.Columns[e.ColumnIndex] == this.colPaymentAmount2)
            {
                this.StatBatch();
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
            if (this._case == null)
            {
                MessageBoxEx.Show("没有选定案件", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            ExportForm exportForm = new ExportForm(ExportForm.ExportType.EXPORT_PAYMENT_BY_BATCH, this.invoiceBindingSource.List);
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportBatch(object sender, EventArgs e)
        {
            if (this._case == null)
            {
                MessageBoxEx.Show("没有选定案件", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.batchBindingSource.DataSource is InvoicePaymentBatch))
            {
                return;
            }

            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_PAYMENT_BY_BATCH, context);
            importForm.ShowDialog(this);
            IList invoiceList = importForm.ImportedList;
            if (invoiceList != null)
            {
                for (int i = 0; i < this.invoiceBindingSource.List.Count; i++)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvInvoices.Rows[i].Cells[0];
                    cell.Value = 0;
                    Invoice oldInvoice = (Invoice)this.invoiceBindingSource.List[i];
                    if (invoiceList.Contains(oldInvoice) && oldInvoice.PaymentAmount2 > 0)
                    {
                        cell.Value = 1;
                    }

                    this.ResetRow(i, 1 == (int)cell.Value ? true : false);
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
            if (this._case == null)
            {
                MessageBoxEx.Show("没有选定案件", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.tbTotalPayment.Text = string.Empty;
            InvoicePaymentBatch batch = new InvoicePaymentBatch();
            switch (paymentType)
            {
                case OpPaymentType.BUYER_PAYMENT:
                    batch.PaymentType = "买方付款";
                    break;
                case OpPaymentType.INDIRECT_PAYMENT:
                    batch.PaymentType = "间接付款";
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

            var queryResult = from invoice in context.Invoices
                              where invoice.InvoiceAssignBatch.CaseCode == this._case.CaseCode && invoice.InvoiceAssignBatch.CheckStatus == "已复核" && (invoice.PaymentAmount.GetValueOrDefault() - invoice.AssignAmount < -0.0001)
                              select invoice;

            this.invoiceBindingSource.DataSource = queryResult;
            this.StatBatch();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCheckBoxClicked(object sender, DataGridViewCheckboxHeaderEventArgs e)
        {
            this.dgvInvoices.EndEdit();
            IList invoiceRefundList = this.invoiceBindingSource.List;
            foreach (DataGridViewRow dgvRow in this.dgvInvoices.Rows)
            {
                Invoice invoice = (Invoice)invoiceRefundList[dgvRow.Index];
                if (e.CheckedState)
                {
                    dgvRow.Cells[0].Value = true;
                    ClickInvoice(invoice);
                    this.ResetRow(dgvRow.Index, true);
                }
                else
                {
                    dgvRow.Cells[0].Value = false;
                    this.ResetRow(dgvRow.Index, false);
                }
            }

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
            this.dgvInvoices.Rows[rowIndex].Cells["colCreditNoteNo2"].ReadOnly = !editable;
            this.dgvInvoices.Rows[rowIndex].Cells["colCreditNoteDate2"].ReadOnly = !editable;
            if (!editable)
            {
                IList invoiceList = this.invoiceBindingSource.List;
                Invoice invoice = (Invoice)invoiceList[rowIndex];
                invoice.PaymentAmount2 = null;
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
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            if (this._case == null)
            {
                MessageBoxEx.Show("没有选定案件", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            List<Invoice> refundList = new List<Invoice>();
            try
            {
                batch.Case = this._case;
                if (batch.PaymentBatchNo == null)
                {
                    batch.PaymentBatchNo = Invoice.GeneratePaymentBatchNo(batch.PaymentDate);
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
                            log = context.InvoicePaymentLogs.SingleOrDefault(paymentlog => paymentlog.PaymentLogID == invoice.PaymentLogID2);
                            if (log == null)
                            {
                                throw new Exception("还款ID错误");
                            }
                        }

                        log.Invoice = invoice;
                        log.PaymentAmount = invoice.PaymentAmount2.GetValueOrDefault();

                        CreditNote creditNote = null;
                        if (invoice.CreditNoteNo2 != null && invoice.CreditNoteNo2 != string.Empty)
                        {
                            creditNote = context.CreditNotes.SingleOrDefault(c => c.CreditNoteNo == invoice.CreditNoteNo2);
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
                        invoice.CaculatePayment();

                        if (invoice.FinanceOutstanding > 0)
                        {
                            refundList.Add(invoice);
                        }
                    }
                }

                if (batch.InvoicePaymentLogs.Count == 0)
                {
                    return;
                }

                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (InvoicePaymentLog log in logList)
                {
                    Invoice invoice = log.Invoice;
                    invoice.InvoicePaymentLogs.Remove(log);
                    invoice.CaculatePayment();
                    log.CreditNote = null;
                    log.InvoicePaymentBatch = null;
                }

                batch.Case = null;
                isSaveOK = false;
                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isSaveOK)
            {
                MessageBoxEx.Show("数据保存成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.caseBasic.CaculateOutstanding(this._case);
                if (refundList.Count > 0)
                {
                    MainWindow mainWindow = App.Current.MainWindow;
                    mainWindow.InvoiceRefund(refundList, batch.PaymentType, batch.PaymentDate);
                }
                else
                {
                    this.NewBatch(null, null);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBatch(object sender, EventArgs e)
        {
            if (this._case == null)
            {
                MessageBoxEx.Show("没有选定案件", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PaymentBatchMgr batchMgr = new PaymentBatchMgr(this._case);
            QueryForm queryUI = new QueryForm(batchMgr, "选择付款批次");
            batchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoicePaymentBatch selectedBatch = batchMgr.Selected;
            if (selectedBatch != null)
            {
                InvoicePaymentBatch batch = context.InvoicePaymentBatches.SingleOrDefault(i => i.PaymentBatchNo == selectedBatch.PaymentBatchNo);
                this.batchBindingSource.DataSource = batch;
                Func<InvoicePaymentLog, Invoice> makeInvoice =
                i => new Invoice { InvoiceNo = i.InvoiceNo, PaymentLogID2 = i.PaymentLogID };

                var invoiceList = (from log in batch.InvoicePaymentLogs
                                   select makeInvoice(log)).ToList();

                foreach (Invoice invoice in invoiceList)
                {
                    Invoice oldInvoice = context.Invoices.SingleOrDefault(i => i.InvoiceNo == invoice.InvoiceNo);
                    invoice.AssignAmount = oldInvoice.AssignAmount;
                    invoice.InvoiceAssignBatch = oldInvoice.InvoiceAssignBatch;
                    invoice.DueDate = oldInvoice.DueDate;
                    invoice.InvoiceFinanceBatch = oldInvoice.InvoiceFinanceBatch;
                    invoice.FinanceAmount = oldInvoice.FinanceAmount;
                    invoice.FinanceDate = oldInvoice.FinanceDate;
                    invoice.FinanceDueDate = oldInvoice.FinanceDueDate;

                    invoice.PaymentAmount = oldInvoice.PaymentAmount;
                }

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
            for (int i = 0; i < paymentLogList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    totalPayment += ((Invoice)paymentLogList[i]).PaymentAmount2.GetValueOrDefault();
                }
            }

            this.tbTotalPayment.Text = String.Format("{0:N2}", totalPayment);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidateBatch()
        {
            InvoicePaymentBatch batch = (InvoicePaymentBatch)this.batchBindingSource.DataSource;
            IList invoiceList = this.invoiceBindingSource.List;

            for (int i = 0; i < invoiceList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    Invoice invoice = (Invoice)invoiceList[i];
                    if (TypeUtil.LessZero(invoice.AssignOutstanding))
                    {
                        MessageBoxEx.Show("付款金额不能大于转让金额: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    if (TypeUtil.GreaterZero(invoice.PaymentAmount2 - invoice.FinanceOutstanding))
                    {
                        if (batch.PaymentType == "贷项通知")
                        {
                            MessageBoxEx.Show("账款调整金额大于融资余额，需要求客户偿还融资款差额后，才可调整: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                        if (batch.PaymentType == "卖方回购")
                        {
                            MessageBoxEx.Show("回购金额大于融资余额，需要求客户偿还融资款差额后，才可调整: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        #endregion Methods
    }
}

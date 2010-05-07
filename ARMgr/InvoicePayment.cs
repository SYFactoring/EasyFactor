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
    using CMBC.EasyFactor.Controls;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar;
    using CMBC.EasyFactor.Utils.ConstStr;

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
        /// <summary>
        /// 
        /// </summary>
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
            this.dgvLogs.ImeMode = ImeMode.OnHalf;

            DataGridViewCheckboxHeaderCell checkBoxCell = new DataGridViewCheckboxHeaderCell();
            checkBoxCell.OnCheckBoxClicked += new DataGridViewCheckboxHeaderEventHander(OnCheckBoxClicked);
            DataGridViewCheckBoxColumn checkBoxCol = this.dgvLogs.Columns[0] as DataGridViewCheckBoxColumn;
            checkBoxCol.HeaderCell = checkBoxCell;
            checkBoxCol.HeaderCell.Value = string.Empty;

            this.caseBasic = caseBasic;
            this.paymentType = paymentType;
            this.dgvLogs.AutoGenerateColumns = false;
            this.superValidator.Enabled = false;
            ControlUtil.SetDoubleBuffered(this.dgvLogs);

            foreach (DataGridViewColumn column in this.dgvLogs.Columns)
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
            get
            {
                return this._case;
            }
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
            this.logsBindingSource.DataSource = typeof(InvoicePaymentLog);
        }
        // Private Methods (19) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        private void ClickLog(InvoicePaymentLog log)
        {
            log.PaymentAmount = log.AssignOutstanding;
            log.CreditNoteDate2 = DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            if (this.dgvLogs.CurrentCell == null)
            {
                return;
            }

            InvoicePaymentLog selectedLog = (InvoicePaymentLog)this.logsBindingSource.List[this.dgvLogs.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedLog.Invoice.InvoiceAssignBatch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCDA(object sender, EventArgs e)
        {
            if (this.dgvLogs.CurrentCell == null)
            {
                return;
            }

            InvoicePaymentLog selectedLog = (InvoicePaymentLog)this.logsBindingSource.List[this.dgvLogs.CurrentCell.RowIndex];
            CDADetail cdaDetail = new CDADetail(selectedLog.Invoice.InvoiceAssignBatch.Case.ActiveCDA, CDADetail.OpCDAType.DETAIL_CDA);
            cdaDetail.ShowDialog(this);
        }

        /// <summary>
        /// Show detail info of selected inovice
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailInvoice(object sender, System.EventArgs e)
        {
            if (this.dgvLogs.CurrentCell == null)
            {
                return;
            }

            InvoicePaymentLog selectedLog = (InvoicePaymentLog)this.logsBindingSource.List[this.dgvLogs.CurrentCell.RowIndex];
            InvoiceDetail invoiceDetail = new InvoiceDetail(selectedLog.Invoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
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

            IList logList = this.logsBindingSource.List;
            InvoicePaymentLog log = (InvoicePaymentLog)logList[e.RowIndex];
            this.dgvLogs.EndEdit();

            if (this.dgvLogs.Columns[e.ColumnIndex] == colCheckBox)
            {

                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)this.dgvLogs.Rows[e.RowIndex].Cells[0];

                if (Boolean.Parse(checkBoxCell.EditedFormattedValue.ToString()))
                {
                    ClickLog(log);
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

            DataGridViewColumn col = this.dgvLogs.Columns[e.ColumnIndex];
            if (col == colAssignDate || col == colDueDate || col == colCreditNoteDate2)
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

            DataGridViewColumn col = this.dgvLogs.Columns[e.ColumnIndex];
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

            DataGridViewColumn col = this.dgvLogs.Columns[e.ColumnIndex];
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
            else if (col == colPaymentAmount)
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

            if (this.dgvLogs.Columns[e.ColumnIndex] == this.colPaymentAmount)
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
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.batchBindingSource.DataSource is InvoicePaymentBatch))
            {
                return;
            }

            if (this.logsBindingSource.List.Count == 0)
            {
                return;
            }

            ExportForm exportForm = new ExportForm(ExportForm.ExportType.EXPORT_PAYMENT_BY_BATCH, this.logsBindingSource.List);
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
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.batchBindingSource.DataSource is InvoicePaymentBatch))
            {
                return;
            }

            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_PAYMENT_BY_BATCH, context);
            importForm.ShowDialog(this);
            List<InvoicePaymentLog> logList = (List<InvoicePaymentLog>)importForm.ImportedList;
            if (logList != null)
            {
                for (int i = 0; i < this.logsBindingSource.List.Count; i++)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvLogs.Rows[i].Cells[0];
                    cell.Value = 0;
                    InvoicePaymentLog oldLog = (InvoicePaymentLog)this.logsBindingSource.List[i];

                    InvoicePaymentLog newLog = logList.SingleOrDefault(log => log.InvoiceNo2 == oldLog.InvoiceNo2);
                    if (newLog != null)
                    {
                        oldLog.PaymentAmount = newLog.PaymentAmount;
                        oldLog.Comment = newLog.Comment;


                        if (TypeUtil.GreaterZero(oldLog.PaymentAmount))
                        {
                            cell.Value = 1;
                        }

                        this.ResetRow(i, 1 == (int)cell.Value ? true : false);
                    }
                }

                this.dgvLogs.Refresh();
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
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.tbTotalPayment.Text = string.Empty;
            InvoicePaymentBatch batch = new InvoicePaymentBatch();
            switch (paymentType)
            {
                case OpPaymentType.BUYER_PAYMENT:
                    batch.PaymentType = "买方直接付款";
                    break;
                case OpPaymentType.INDIRECT_PAYMENT:
                    batch.PaymentType = "买方间接付款";
                    break;
                case OpPaymentType.GUARANTEE_PAYMENT:
                    batch.PaymentType = "担保付款";
                    break;
                case OpPaymentType.SELLER_REASSIGN:
                    batch.PaymentType = "反转让";
                    break;
                case OpPaymentType.CREDIT_NOTE_PAYMENT:
                    batch.PaymentType = "贷项通知";
                    break;
                default:
                    break;
            }

            batch.PaymentDate = DateTime.Now.Date;
            batch.CreateUserName = App.Current.CurUser.Name;
            batch.CheckStatus = BATCH.UNCHECK;
            this.batchBindingSource.DataSource = batch;

            var queryResult = from invoice in context.Invoices
                              where invoice.InvoiceAssignBatch.CaseCode == this._case.CaseCode && invoice.InvoiceAssignBatch.CheckStatus == "已复核" && (invoice.PaymentAmount.GetValueOrDefault() - invoice.AssignAmount < -0.01)
                              select invoice;

            List<InvoicePaymentLog> logs = new List<InvoicePaymentLog>();
            foreach (Invoice invoice in queryResult)
            {
                InvoicePaymentLog log = new InvoicePaymentLog(invoice);
                logs.Add(log);
            }

            this.logsBindingSource.DataSource = logs;
            this.StatBatch();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCheckBoxClicked(object sender, DataGridViewCheckboxHeaderEventArgs e)
        {
            IList logList = this.logsBindingSource.List;
            foreach (DataGridViewRow dgvRow in this.dgvLogs.Rows)
            {
                InvoicePaymentLog log = (InvoicePaymentLog)logList[dgvRow.Index];
                if (e.CheckedState)
                {
                    dgvRow.Cells[0].Value = true;
                    ClickLog(log);
                    this.ResetRow(dgvRow.Index, true);
                }
                else
                {
                    dgvRow.Cells[0].Value = false;
                    this.ResetRow(dgvRow.Index, false);
                }
            }

            this.dgvLogs.Refresh();
            this.StatBatch();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="editable"></param>
        private void ResetRow(int rowIndex, bool editable)
        {
            this.dgvLogs.Rows[rowIndex].Cells["colPaymentAmount"].ReadOnly = !editable;
            this.dgvLogs.Rows[rowIndex].Cells["colCreditNoteNo2"].ReadOnly = !editable;
            this.dgvLogs.Rows[rowIndex].Cells["colCreditNoteDate2"].ReadOnly = !editable;
            if (!editable)
            {
                InvoicePaymentLog log = (InvoicePaymentLog)this.logsBindingSource.List[rowIndex];
                log.PaymentAmount = 0;
                if (log.CreditNote != null)
                {
                    log.CreditNoteDate2 = default(DateTime);
                    log.CreditNoteNo2 = null;
                }
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
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            List<InvoicePaymentLog> logList = new List<InvoicePaymentLog>();
            List<Invoice> invoiceList = new List<Invoice>();

            try
            {
                batch.Case = this._case;
                if (batch.PaymentBatchNo == null)
                {
                    batch.PaymentBatchNo = InvoicePaymentBatch.GeneratePaymentBatchNo(batch.PaymentDate);
                    batch.InputDate = DateTime.Today;
                }

                for (int i = 0; i < this.logsBindingSource.List.Count; i++)
                {
                    if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                    {
                        InvoicePaymentLog log = (InvoicePaymentLog)this.logsBindingSource.List[i];
                        log.Invoice = context.Invoices.SingleOrDefault(invoice => invoice.InvoiceNo == log.InvoiceNo2);
                        logList.Add(log);
                        log.InvoicePaymentBatch = batch;
                        log.Invoice.CaculatePayment();

                        if (log.Invoice.FinanceOutstanding > 0 && !invoiceList.Contains(log.Invoice))
                        {
                            invoiceList.Add(log.Invoice);
                        }

                        if (!String.IsNullOrEmpty(log.CreditNoteNo2))
                        {
                            CreditNote note = new CreditNote();
                            note.CreditNoteNo = log.CreditNoteNo2;
                            note.CreditNoteDate = log.CreditNoteDate2.GetValueOrDefault();
                            log.CreditNote = note;
                        }
                    }
                }

                if (batch.InvoicePaymentLogs.Count == 0)
                {
                    batch.Case = null;
                    batch.PaymentBatchNo = null;
                    return;
                }

                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (InvoicePaymentLog log in logList)
                {
                    Invoice invoice = log.Invoice;
                    log.Invoice = null;
                    log.InvoicePaymentBatch = null;
                    log.CreditNote = null;
                    invoice.CaculatePayment();
                }

                batch.Case = null;
                isSaveOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isSaveOK)
            {
                MessageBoxEx.Show("数据保存成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.caseBasic.CaculateOutstanding(this._case);
                if (invoiceList.Count > 0)
                {
                    MainWindow mainWindow = App.Current.MainWindow;
                    mainWindow.InvoiceRefund(invoiceList, batch);
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
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PaymentBatchMgr batchMgr = new PaymentBatchMgr(this._case, this.context);
            QueryForm queryUI = new QueryForm(batchMgr, "选择付款批次");
            batchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoicePaymentBatch selectedBatch = batchMgr.Selected;
            if (selectedBatch != null)
            {
                this.batchBindingSource.DataSource = selectedBatch;

                this.logsBindingSource.DataSource = selectedBatch.InvoicePaymentLogs;
                for (int i = 0; i < this.logsBindingSource.List.Count; i++)
                {
                    InvoicePaymentLog log = (InvoicePaymentLog)this.logsBindingSource.List[i];
                    log.InvoiceNo2 = log.InvoiceNo;
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvLogs.Rows[i].Cells[0];
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
            IList logList = this.logsBindingSource.List;
            double totalPayment = 0;
            for (int i = 0; i < logList.Count; i++)
            {
                if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    totalPayment += ((InvoicePaymentLog)logList[i]).PaymentAmount.GetValueOrDefault();
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
            IList logList = this.logsBindingSource.List;

            for (int i = 0; i < logList.Count; i++)
            {
                if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    InvoicePaymentLog log = (InvoicePaymentLog)logList[i];
                    if (TypeUtil.LessZero(log.AssignOutstanding))
                    {
                        MessageBoxEx.Show("付款金额不能大于转让金额: " + log.InvoiceNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    //if (TypeUtil.GreaterZero(log.PaymentAmount - log.FinanceOutstanding))
                    //{
                    //    if (batch.PaymentType == "贷项通知")
                    //    {
                    //        MessageBoxEx.Show("账款调整金额大于融资余额，需要求客户偿还融资款差额后，才可调整: " + log.InvoiceNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        return false;
                    //    }
                    //    if (batch.PaymentType == "卖方回购")
                    //    {
                    //        MessageBoxEx.Show("回购金额大于融资余额，需要求客户偿还融资款差额后，才可调整: " + log.InvoiceNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        return false;
                    //    }
                    //}
                }
            }
            return true;
        }

        #endregion Methods
    }
}

//-----------------------------------------------------------------------
// <copyright file="InvoiceFinance.cs" company="Yiming Liu@Fudan">
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
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceFinance : UserControl
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
        private double currentBatchFinanceAmount = 0;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the InvoiceFinance class
        /// </summary>
        /// <param name="caseBasic"></param>
        public InvoiceFinance(ARCaseBasic caseBasic)
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.dgvLogs.ImeMode = ImeMode.OnHalf;

            DataGridViewCheckboxHeaderCell checkBoxCell = new DataGridViewCheckboxHeaderCell();
            checkBoxCell.OnCheckBoxClicked += new DataGridViewCheckboxHeaderEventHander(OnCheckBoxClicked);
            DataGridViewCheckBoxColumn checkBoxCol = this.dgvLogs.Columns[0] as DataGridViewCheckBoxColumn;
            checkBoxCol.HeaderCell = checkBoxCell;
            checkBoxCol.HeaderCell.Value = string.Empty;

            this.caseBasic = caseBasic;
            this.dgvLogs.AutoGenerateColumns = false;
            this.superValidator.Enabled = false;
            ControlUtil.SetDoubleBuffered(this.dgvLogs);

            this.batchCurrencyComboBoxEx.DataSource = Currency.AllCurrencies();
            this.batchCurrencyComboBoxEx.DisplayMember = "CurrencyCode";
            this.batchCurrencyComboBoxEx.ValueMember = "CurrencyCode";

            this.dgvLogs.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvInvoices_CellFormatting);
            this.dgvLogs.CellParsing += new DataGridViewCellParsingEventHandler(dgvInvoices_CellParsing);

            this.financeRateTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.financeRateTextBox.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

            this.costRateTextBoxX.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.costRateTextBoxX.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

            foreach (DataGridViewColumn column in this.dgvLogs.Columns)
            {
                column.ReadOnly = true;
            }

            colCheckBox.ReadOnly = false;

            this.context = new DBDataContext();
        }

        #endregion Constructors

        #region Properties (1)

        /// <summary>
        /// Sets
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

        #region Methods (26)

        // Public Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        public void ResetControlsStatus()
        {
            foreach (Control comp in this.panelFinanceBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }

            this.batchBindingSource.DataSource = typeof(InvoiceFinanceBatch);
            this.logsBindingSource.DataSource = typeof(InvoiceFinanceLog);
        }
        // Private Methods (25) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        private void ClickLog(InvoiceFinanceLog log, DataGridViewCheckBoxCell checkBoxCell)
        {
            double currentFinanceAmount = currentBatchFinanceAmount;

            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;
            double financeAmount = 0;
            if (log.AssignOutstanding * this._case.ActiveCDA.FinanceProportion.Value + currentFinanceAmount > batch.FinanceAmount)
            {
                financeAmount = batch.FinanceAmount - currentFinanceAmount;
            }
            else
            {
                financeAmount = log.AssignOutstanding * this._case.ActiveCDA.FinanceProportion.Value;
            }

            if (TypeUtil.EqualsZero(financeAmount))
            {
                checkBoxCell.Value = 0;
                return;
            }

            log.FinanceAmount = financeAmount;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customValidator1_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;
            IList logList = this.logsBindingSource.List;

            DateTime assignDate = default(DateTime);
            for (int i = 0; i < logList.Count; i++)
            {
                if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    InvoiceFinanceLog log = (InvoiceFinanceLog)logList[i];
                    if (assignDate < log.AssignDate)
                    {
                        assignDate = log.AssignDate;
                    }
                }
            }

            if (assignDate == default(DateTime))
            {
                e.IsValid = true;
                return;
            }

            if (batch.FinancePeriodBegin < assignDate)
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customValidator2_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;
            IList logList = this.logsBindingSource.List;

            DateTime dueDate = default(DateTime);
            for (int i = 0; i < logList.Count; i++)
            {
                if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    InvoiceFinanceLog log = (InvoiceFinanceLog)logList[i];
                    if (log.DueDate.HasValue && dueDate < log.DueDate.Value)
                    {
                        dueDate = log.DueDate.Value;
                    }
                }
            }

            if (dueDate == default(DateTime))
            {
                e.IsValid = true;
                return;
            }

            if (batch.FinancePeriodEnd >= dueDate)
            {
                e.IsValid = true;
            }
            else
            {
                e.IsValid = false;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customValidator3_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;
            if (TypeUtil.LessZero(batch.FinanceRate))
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customValidator4_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;
            if (batch.CostRate.HasValue)
            {
                if (TypeUtil.LessZero(batch.CostRate))
                {
                    e.IsValid = false;
                }
                else
                {
                    e.IsValid = true;
                }
            }
            else
            {
                e.IsValid = true;
            }
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

            InvoiceFinanceLog selectedLog = (InvoiceFinanceLog)this.logsBindingSource.List[this.dgvLogs.CurrentCell.RowIndex];
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

            InvoiceFinanceLog selectedLog = (InvoiceFinanceLog)this.logsBindingSource.List[this.dgvLogs.CurrentCell.RowIndex];
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

            InvoiceFinanceLog selectedLog = (InvoiceFinanceLog)this.logsBindingSource.List[this.dgvLogs.CurrentCell.RowIndex];
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

            if (!this.superValidator.Validate())
            {
                return;
            }

            IList invoiceList = this.logsBindingSource.List;
            InvoiceFinanceLog log = (InvoiceFinanceLog)invoiceList[e.RowIndex];
            this.dgvLogs.EndEdit();

            if (this.dgvLogs.Columns[e.ColumnIndex] == colCheckBox)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)this.dgvLogs.Rows[e.RowIndex].Cells[0];
                if (Boolean.Parse(checkBoxCell.EditedFormattedValue.ToString()))
                {
                    ClickLog(log, checkBoxCell);
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
            if (col == colInvoiceDate || col == colAssignDate || col == colDueDate || col == colCommissionDate)
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
            if (col == colInvoiceDate || col == colAssignDate || col == colDueDate || col == colCommissionDate)
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
            if (col == colInvoiceDate || col == colAssignDate || col == colDueDate || col == colCommissionDate)
            {
                string str = (string)e.FormattedValue;
                DateTime result;
                bool ok = DateTime.TryParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
            else if (col == colFinanceAmount || col == colCommission)
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

                if (e.Cancel == false && col == colFinanceAmount)
                {
                    InvoiceFinanceLog selectedLog = (InvoiceFinanceLog)this.logsBindingSource.List[e.RowIndex];
                    if (result > selectedLog.AssignOutstanding * this._case.ActiveCDA.FinanceProportion)
                    {
                        if (DialogResult.No == MessageBoxEx.Show("您输入的融资金额超出融资比例的范围，确认录入吗？", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                        {
                            e.Cancel = true;
                        }
                    }
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

            if (this.dgvLogs.Columns[e.ColumnIndex] == this.colFinanceAmount)
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
            DetailInvoice(null, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportFinanceBatch(object sender, EventArgs e)
        {
            if (this._case == null)
            {
                MessageBoxEx.Show("没有选定案件", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.batchBindingSource.DataSource is InvoiceFinanceBatch))
            {
                return;
            }

            if (this.logsBindingSource.List.Count == 0)
            {
                return;
            }

            ExportForm exportForm = new ExportForm(ExportForm.ExportType.EXPORT_FINANCE_BY_BATCH, this.logsBindingSource.List);
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFinanceBatch(object sender, EventArgs e)
        {
            if (this._case == null)
            {
                MessageBoxEx.Show("没有选定案件", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.batchBindingSource.DataSource is InvoiceFinanceBatch))
            {
                return;
            }

            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_FINANCE_BY_BATCH, context);
            importForm.ShowDialog(this);
            IList logList = importForm.ImportedList;
            if (logList != null)
            {
                for (int i = 0; i < this.logsBindingSource.List.Count; i++)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvLogs.Rows[i].Cells[0];
                    cell.Value = 0;
                    InvoiceFinanceLog oldLog = (InvoiceFinanceLog)this.logsBindingSource.List[i];
                    if (logList.Contains(oldLog) && TypeUtil.GreaterZero(oldLog.FinanceAmount))
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

            InvoiceFinanceBatch financeBatch = new InvoiceFinanceBatch();
            financeBatch.BatchCurrency = this._case.InvoiceCurrency;
            financeBatch.CreateUserName = App.Current.CurUser.Name;
            financeBatch.CheckStatus = "未复核";
            this.batchBindingSource.DataSource = financeBatch;

            var logsResult = from log in context.InvoiceFinanceLogs
                              let i = log.Invoice
                              where i.InvoiceAssignBatch.CaseCode == this._case.CaseCode && i.IsFlaw == false && i.InvoiceAssignBatch.CheckStatus == "已复核" && (i.AssignAmount - i.PaymentAmount.GetValueOrDefault() > 0.0001) && (i.FinanceAmount.HasValue == false || i.FinanceAmount < 0.0001)
                              select log;

            this.logsBindingSource.DataSource = logsResult;
            this.StatBatch();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCheckBoxClicked(object sender, DataGridViewCheckboxHeaderEventArgs e)
        {
            this.dgvLogs.EndEdit();
            IList logList = this.logsBindingSource.List;
            foreach (DataGridViewRow dgvRow in this.dgvLogs.Rows)
            {
                InvoiceFinanceLog log = (InvoiceFinanceLog)logList[dgvRow.Index];
                if (e.CheckedState)
                {
                    dgvRow.Cells[0].Value = true;
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)this.dgvLogs.Rows[dgvRow.Index].Cells[0];
                    ClickLog(log, checkBoxCell);
                    this.ResetRow(dgvRow.Index, true);
                }
                else
                {
                    dgvRow.Cells[0].Value = false;
                    this.ResetRow(dgvRow.Index, false);
                }

                this.StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="editable"></param>
        private void ResetRow(int rowIndex, bool editable)
        {
            this.dgvLogs.Rows[rowIndex].Cells["colFinanceAmount"].ReadOnly = !editable;
            this.dgvLogs.Rows[rowIndex].Cells["colComment"].ReadOnly = !editable;

            if (this._case.ActiveCDA.CommissionType == "按融资金额")
            {
                this.dgvLogs.Rows[rowIndex].Cells["colCommission"].ReadOnly = !editable;
                this.dgvLogs.Rows[rowIndex].Cells["colCommissionDate"].ReadOnly = !editable;
            }

            if (!editable)
            {
                IList logList = this.logsBindingSource.List;
                InvoiceFinanceLog log = (InvoiceFinanceLog)logList[rowIndex];
                log.FinanceAmount = 0;

                if (this._case.ActiveCDA.CommissionType == "按融资金额")
                {
                    log.Commission = null;
                    log.CommissionDate = null;
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
                MessageBoxEx.Show("没有选定案件", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!this.superValidator.Validate())
            {
                return;
            }

            if (!(this.batchBindingSource.DataSource is InvoiceFinanceBatch))
            {
                return;
            }

            if (!this.ValidateBatch())
            {
                return;
            }

            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;
            List<InvoiceFinanceLog> logList = new List<InvoiceFinanceLog>();

            double totalFinance = 0;
            for (int i = 0; i < this.logsBindingSource.List.Count; i++)
            {
                if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    InvoiceFinanceLog log = (InvoiceFinanceLog)this.logsBindingSource.List[i];
                    totalFinance += log.FinanceAmount;
                }
            }

            if (!TypeUtil.EqualsZero(batch.FinanceAmount - totalFinance))
            {
                MessageBoxEx.Show("融资额未分配结束，不能保存", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool isSaveOK = true;

            batch.Case = this._case;
            if (batch.FinanceBatchNo == null)
            {
                batch.FinanceBatchNo = InvoiceFinanceBatch.GenerateFinanceBatchNo(batch.FinancePeriodBegin);
            }

            for (int i = 0; i < logList.Count; i++)
            {
                if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    InvoiceFinanceLog log = (InvoiceFinanceLog)this.logsBindingSource.List[i];
                    logList.Add(log);
                    log.InvoiceFinanceBatch = batch;
                    log.Invoice.CaculateFinance();
                }
            }

            if (batch.InvoiceFinanceLogs.Count == 0)
            {
                return;
            }

            try
            {
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (InvoiceFinanceLog log in logList)
                {
                    Invoice invoice = log.Invoice;
                    invoice.InvoiceFinanceLogs.Remove(log);
                    invoice.CaculateFinance();
                }

                batch.Case = null;
                isSaveOK = false;
                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isSaveOK)
            {
                MessageBoxEx.Show("数据保存成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.caseBasic.CaculateOutstanding(this._case);
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

            FinanceBatchMgr batchMgr = new FinanceBatchMgr(this._case, this.context);
            QueryForm queryUI = new QueryForm(batchMgr, "选择融资批次");
            batchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoiceFinanceBatch selectedBatch = batchMgr.Selected;
            if (selectedBatch != null)
            {
                //InvoiceFinanceBatch batch = context.InvoiceFinanceBatches.SingleOrDefault(i => i.FinanceBatchNo == selectedBatch.FinanceBatchNo);
                this.batchBindingSource.DataSource = selectedBatch;
                this.logsBindingSource.DataSource = selectedBatch.InvoiceFinanceLogs;

                for (int i = 0; i < this.logsBindingSource.List.Count; i++)
                {
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFactor(object sender, EventArgs e)
        {
            if (this._case == null)
            {
                MessageBoxEx.Show("没有选定案件", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.batchBindingSource.DataSource is InvoiceFinanceBatch))
            {
                return;
            }

            InvoiceFinanceBatch financeBatch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;
            FactorMgr factorMgr = new FactorMgr();
            QueryForm queryForm = new QueryForm(factorMgr, "选择代付行");
            factorMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);

            Factor factor = factorMgr.Selected;
            if (factor != null)
            {
                financeBatch.Factor = this.context.Factors.SingleOrDefault(f => f.FactorCode == factor.FactorCode);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void StatBatch()
        {
            IList logList = this.logsBindingSource.List;
            InvoiceFinanceBatch financeBatch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;

            double totalFinance = 0;
            double totalInterest = 0;
            for (int i = 0; i < logList.Count; i++)
            {
                if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    totalFinance += ((InvoiceFinanceLog)logList[i]).FinanceAmount;
                    totalInterest += ((InvoiceFinanceLog)logList[i]).NetInterest;
                }
            }

            currentBatchFinanceAmount = totalFinance;
            this.tbFinanceLineBalance.Text = String.Format("{0:N2}", financeBatch.FinanceAmount - totalFinance);
            this.tbTotalInterest.Text = String.Format("{0:N2}", totalInterest);
            if (totalFinance > financeBatch.FinanceAmount)
            {
                MessageBoxEx.Show("当前融资额超过限定", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidateBatch()
        {
            IList logList = this.logsBindingSource.List;
            for (int i = 0; i < logList.Count; i++)
            {
                if (Boolean.Parse(this.dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    InvoiceFinanceLog log = (InvoiceFinanceLog)logList[i];
                    if (!TypeUtil.GreaterZero(log.FinanceAmount))
                    {
                        MessageBoxEx.Show("融资金额不能为空: " + log.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    if (log.FinanceAmount > log.AssignOutstanding)
                    {
                        MessageBoxEx.Show("融资金额不能大于转让余额: " + log.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }

            return true;
        }

        #endregion Methods
    }
}

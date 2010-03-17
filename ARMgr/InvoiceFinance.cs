﻿//-----------------------------------------------------------------------
// <copyright file="InvoiceFinance.cs" company="Yiming Liu@Fudan">
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
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.Utils;
    using System.Collections.Generic;
    using DevComponents.DotNetBar;
    using CMBC.EasyFactor.Controls;

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
            this.dgvInvoices.ImeMode = ImeMode.OnHalf;

            DataGridViewCheckboxHeaderCell checkBoxCell = new DataGridViewCheckboxHeaderCell();
            checkBoxCell.OnCheckBoxClicked += new DataGridViewCheckboxHeaderEventHander(OnCheckBoxClicked);
            DataGridViewCheckBoxColumn checkBoxCol = this.dgvInvoices.Columns[0] as DataGridViewCheckBoxColumn;
            checkBoxCol.HeaderCell = checkBoxCell;
            checkBoxCol.HeaderCell.Value = string.Empty;

            this.caseBasic = caseBasic;
            this.dgvInvoices.AutoGenerateColumns = false;
            this.superValidator.Enabled = false;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);

            this.batchCurrencyComboBoxEx.DataSource = Currency.AllCurrencies();
            this.batchCurrencyComboBoxEx.DisplayMember = "CurrencyCode";
            this.batchCurrencyComboBoxEx.ValueMember = "CurrencyCode";

            this.dgvInvoices.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvInvoices_CellFormatting);
            this.dgvInvoices.CellParsing += new DataGridViewCellParsingEventHandler(dgvInvoices_CellParsing);

            this.financeRateTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.financeRateTextBox.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

            this.costRateTextBoxX.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.costRateTextBoxX.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

            foreach (DataGridViewColumn column in this.dgvInvoices.Columns)
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
            this.invoiceBindingSource.DataSource = typeof(Invoice);
        }
        // Private Methods (25) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaculateCommission(Invoice invoice)
        {
            if (invoice.Commission.HasValue == false)
            {
                if (this._case.ActiveCDA.CommissionType == "按融资金额")
                {
                    invoice.Commission = invoice.FinanceAmount * this._case.ActiveCDA.Price.GetValueOrDefault();
                    if (TypeUtil.GreaterZero(invoice.Commission))
                    {
                        invoice.CommissionDate = invoice.FinanceDate;
                    }
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoice"></param>
        private void ClickInvoice(Invoice invoice, DataGridViewCheckBoxCell checkBoxCell)
        {
            double currentFinanceAmount = currentBatchFinanceAmount;

            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;
            double financeAmount = 0;
            if (invoice.AssignOutstanding * this._case.ActiveCDA.FinanceProportion.Value + currentFinanceAmount > batch.FinanceAmount)
            {
                financeAmount = batch.FinanceAmount - currentFinanceAmount;
            }
            else
            {
                financeAmount = invoice.AssignOutstanding * this._case.ActiveCDA.FinanceProportion.Value;
            }

            if (TypeUtil.EqualsZero(financeAmount))
            {
                checkBoxCell.Value = 0;
                return;
            }

            invoice.FinanceAmount2 = financeAmount;
            invoice.FinanceDate = batch.FinancePeriodBegin;
            invoice.FinanceDueDate = batch.FinancePeriodEnd;

            this.CaculateCommission(invoice);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customValidator1_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;
            IList invoiceList = this.invoiceBindingSource.List;

            DateTime assignDate = default(DateTime);
            for (int i = 0; i < invoiceList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    Invoice invoice = (Invoice)invoiceList[i];
                    if (assignDate < invoice.InvoiceAssignBatch.AssignDate)
                    {
                        assignDate = invoice.InvoiceAssignBatch.AssignDate;
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
            IList invoiceList = this.invoiceBindingSource.List;

            DateTime dueDate = default(DateTime);
            for (int i = 0; i < invoiceList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    Invoice invoice = (Invoice)invoiceList[i];
                    if (invoice.DueDate != null && dueDate < invoice.DueDate.Value)
                    {
                        dueDate = invoice.DueDate.Value;
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

            if (!this.superValidator.Validate())
            {
                return;
            }

            IList invoiceList = this.invoiceBindingSource.List;
            Invoice invoice = (Invoice)invoiceList[e.RowIndex];
            this.dgvInvoices.EndEdit();

            if (this.dgvInvoices.Columns[e.ColumnIndex] == colCheckBox)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)this.dgvInvoices.Rows[e.RowIndex].Cells[0];
                if (Boolean.Parse(checkBoxCell.EditedFormattedValue.ToString()))
                {
                    ClickInvoice(invoice, checkBoxCell);
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

            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
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

            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
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
            else if (col == colFinanceAmount2 || col == colCommission)
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
                    Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[e.RowIndex];
                    if (result > selectedInvoice.AssignOutstanding * this._case.ActiveCDA.FinanceProportion)
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

            if (this.dgvInvoices.Columns[e.ColumnIndex] == this.colFinanceAmount2)
            {
                this.StatBatch();
                this.CaculateCommission((Invoice)this.invoiceBindingSource.List[e.RowIndex]);
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

            if (this.invoiceBindingSource.List.Count == 0)
            {
                return;
            }

            ExportForm exportForm = new ExportForm(ExportForm.ExportType.EXPORT_FINANCE_BY_BATCH, this.invoiceBindingSource.List);
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
            IList invoiceList = importForm.ImportedList;
            if (invoiceList != null)
            {
                for (int i = 0; i < this.invoiceBindingSource.List.Count; i++)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)this.dgvInvoices.Rows[i].Cells[0];
                    cell.Value = 0;
                    Invoice oldInvoice = (Invoice)this.invoiceBindingSource.List[i];
                    if (invoiceList.Contains(oldInvoice) && oldInvoice.FinanceAmount2.HasValue)
                    {
                        cell.Value = 1;
                        if (oldInvoice.Commission.HasValue == false)
                        {
                            this.CaculateCommission(oldInvoice);
                        }
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
            this.invoiceBindingSource.DataSource = context.Invoices.Where(i => i.InvoiceAssignBatch.CaseCode == this._case.CaseCode && i.IsFlaw == false && i.InvoiceAssignBatch.CheckStatus == "已复核" && i.AssignAmount - i.PaymentAmount.GetValueOrDefault() > 0.0001 && (i.FinanceAmount.HasValue == false || i.FinanceAmount < 0.0001)).ToList();
            this.StatBatch();
        }

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
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)this.dgvInvoices.Rows[dgvRow.Index].Cells[0];
                    ClickInvoice(invoice, checkBoxCell);
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
            this.dgvInvoices.Rows[rowIndex].Cells["colFinanceAmount2"].ReadOnly = !editable;
            this.dgvInvoices.Rows[rowIndex].Cells["colComment"].ReadOnly = !editable;

            if (this._case.ActiveCDA.CommissionType == "按融资金额")
            {
                this.dgvInvoices.Rows[rowIndex].Cells["colCommission"].ReadOnly = !editable;
                this.dgvInvoices.Rows[rowIndex].Cells["colCommissionDate"].ReadOnly = !editable;
            }

            if (!editable)
            {
                IList invoiceList = this.invoiceBindingSource.List;
                Invoice invoice = (Invoice)invoiceList[rowIndex];
                invoice.FinanceAmount2 = null;

                if (this._case.ActiveCDA.CommissionType == "按融资金额")
                {
                    invoice.Commission = null;
                    invoice.CommissionDate = null;
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
            IList invoiceList = this.invoiceBindingSource.List;
            List<InvoiceFinanceLog> logList = new List<InvoiceFinanceLog>();

            double totalFinance = 0;
            for (int i = 0; i < invoiceList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    Invoice invoice = (Invoice)invoiceList[i];
                    totalFinance += invoice.FinanceAmount.GetValueOrDefault();
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
                batch.FinanceBatchNo = Invoice.GenerateFinanceBatchNo(batch.FinancePeriodBegin);
            }

            for (int i = 0; i < invoiceList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    Invoice invoice = (Invoice)invoiceList[i];
                    InvoiceFinanceLog log;
                    if (invoice.FinanceLogID2 == null)
                    {
                        log = new InvoiceFinanceLog();
                        logList.Add(log);
                    }
                    else
                    {
                        log = context.InvoiceFinanceLogs.SingleOrDefault(financelog => financelog.FinanceLogID == invoice.FinanceLogID2);
                        if (log == null)
                        {
                            throw new Exception("融资ID错误");
                        }
                    }

                    log.Invoice = invoice;
                    log.FinanceAmount = invoice.FinanceAmount.GetValueOrDefault();
                    log.InvoiceFinanceBatch = batch;
                    invoice.CaculateFinance();
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
                    log.InvoiceFinanceBatch = null;
                }

                batch.Case = null;
                isSaveOK = false;
                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isSaveOK)
            {
                MessageBoxEx.Show("数据保存成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (InvoiceFinanceLog log in logList)
                {
                    Invoice invoice = log.Invoice;
                    invoice.FinanceAmount2 = null;
                }

                context.SubmitChanges();
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

                Func<InvoiceFinanceLog, Invoice> makeInvoice =
                i => new Invoice { InvoiceNo = i.InvoiceNo, FinanceLogID2 = i.FinanceLogID };

                var invoiceList = (from log in selectedBatch.InvoiceFinanceLogs
                                   select makeInvoice(log)).ToList();

                foreach (Invoice invoice in invoiceList)
                {
                    Invoice oldInvoice = context.Invoices.SingleOrDefault(i => i.InvoiceNo == invoice.InvoiceNo);
                    invoice.AssignAmount = oldInvoice.AssignAmount;
                    invoice.InvoiceAssignBatch = oldInvoice.InvoiceAssignBatch;
                    invoice.DueDate = oldInvoice.DueDate;
                    invoice.FinanceAmount = oldInvoice.FinanceAmount;
                    invoice.FinanceDate = oldInvoice.FinanceDate;
                    invoice.FinanceDueDate = oldInvoice.FinanceDueDate;
                    invoice.Commission = oldInvoice.Commission;
                    invoice.CommissionDate = oldInvoice.CommissionDate;
                    invoice.Comment = oldInvoice.Comment;
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
            IList invoiceList = this.invoiceBindingSource.List;
            InvoiceFinanceBatch financeBatch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;

            double totalFinance = 0;
            double totalInterest = 0;
            for (int i = 0; i < invoiceList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    totalFinance += ((Invoice)invoiceList[i]).FinanceAmount2.GetValueOrDefault();
                    totalInterest += ((Invoice)invoiceList[i]).NetInterest.GetValueOrDefault();
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
            IList invoiceList = this.invoiceBindingSource.List;
            for (int i = 0; i < invoiceList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    Invoice invoice = (Invoice)invoiceList[i];
                    if (invoice.FinanceAmount2.HasValue == false)
                    {
                        MessageBoxEx.Show("融资金额不能为空: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    if (invoice.FinanceAmount2 > invoice.AssignOutstanding)
                    {
                        MessageBoxEx.Show("融资金额不能大于转让余额: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    if (invoice.FinanceDueDate < invoice.FinanceDate)
                    {
                        MessageBoxEx.Show("融资到期日不能早于融资日: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }

            return true;
        }

        #endregion Methods
    }
}

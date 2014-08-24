//-----------------------------------------------------------------------
// <copyright file="InvoiceFinance.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

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
using DevComponents.DotNetBar.Validator;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceFinance : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ARCaseBasic _caseBasic;

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;

        /// <summary>
        /// 
        /// </summary>
        private Case _case;

        /// <summary>
        /// 
        /// </summary>
        private decimal _currentBatchFinanceAmount;


        /// <summary>
        /// Initializes a new instance of the InvoiceFinance class
        /// </summary>
        /// <param name="caseBasic"></param>
        public InvoiceFinance(ARCaseBasic caseBasic)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            dgvLogs.ImeMode = ImeMode.OnHalf;

            var checkBoxCell = new DataGridViewCheckboxHeaderCell();
            checkBoxCell.OnCheckBoxClicked += OnCheckBoxClicked;
            var checkBoxCol = dgvLogs.Columns[0] as DataGridViewCheckBoxColumn;
            if (checkBoxCol != null)
            {
                checkBoxCol.HeaderCell = checkBoxCell;
                checkBoxCol.HeaderCell.Value = string.Empty;
            }

            _caseBasic = caseBasic;
            dgvLogs.AutoGenerateColumns = false;
            superValidator.Enabled = false;
            ControlUtil.SetDoubleBuffered(dgvLogs);

            batchCurrencyComboBoxEx.DataSource = Currency.AllCurrencies;
            batchCurrencyComboBoxEx.DisplayMember = "CurrencyCode";
            batchCurrencyComboBoxEx.ValueMember = "CurrencyCode";

            cbFinanceRateType1.Items.AddRange(new object[] { "先收息", "后收息" });
            cbFinanceRateType1.Text = "先收息";

            cbFinanceRateType2.Items.AddRange(new object[] { "计头不计尾", "记尾不计头" });
            cbFinanceRateType2.Text = "计头不计尾";

            cbWhoPayInterest.Items.AddRange(new object[] { "卖方付", "买方付" });
            cbWhoPayInterest.Text = "卖方付";

            dgvLogs.CellFormatting += DgvInvoicesCellFormatting;
            dgvLogs.CellParsing += DgvInvoicesCellParsing;

            financeRateTextBox.DataBindings[0].Format += TypeUtil.FormatFloatToPercent;
            financeRateTextBox.DataBindings[0].Parse += TypeUtil.ParsePercentToFloat;

            //costRateTextBoxX.DataBindings[0].Format += TypeUtil.FormatFloatToPercent;
            //costRateTextBoxX.DataBindings[0].Parse += TypeUtil.ParsePercentToFloat;

            foreach (DataGridViewColumn column in dgvLogs.Columns)
            {
                column.ReadOnly = true;
            }

            colCheckBox.ReadOnly = false;

            _context = new DBDataContext();
        }


        /// <summary>
        /// Gets or Sets
        /// </summary>
        public Case Case
        {
            get { return _case; }
            set
            {
                _case = _context.Cases.SingleOrDefault(c => c.CaseCode == value.CaseCode);
                NewBatch(null, null);
            }
        }


        //?Public?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        public void ResetControlsStatus()
        {
            foreach (Control comp in panelFinanceBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }

            batchBindingSource.DataSource = typeof(InvoiceFinanceBatch);
            logsBindingSource.DataSource = typeof(InvoiceFinanceLog);
        }

        //?Private?Methods?(24)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        /// <param name="checkBoxCell"></param>
        private void ClickLog(InvoiceFinanceLog log, DataGridViewCheckBoxCell checkBoxCell)
        {
            decimal currentFinanceAmount = _currentBatchFinanceAmount;

            var batch = (InvoiceFinanceBatch)batchBindingSource.DataSource;
            decimal financeAmount;
            if (log.AssignOutstanding * (decimal)_case.ActiveCDA.FinanceProportion.GetValueOrDefault() + currentFinanceAmount >
                batch.FinanceAmount)
            {
                financeAmount = batch.FinanceAmount - currentFinanceAmount;
            }
            else
            {
                financeAmount = log.AssignOutstanding * (decimal)_case.ActiveCDA.FinanceProportion.GetValueOrDefault();
            }

            if (financeAmount<=0)
            {
                checkBoxCell.Value = 0;
                return;
            }

            log.FinanceAmount = financeAmount;

            CDA cda = _case.ActiveCDA;
            if (cda.CommissionType == "按融资金额")
            {
                log.Commission = log.FinanceAmount * (decimal)cda.Price;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator1ValidateValue(object sender, ValidateValueEventArgs e)
        {
            var batch = (InvoiceFinanceBatch)batchBindingSource.DataSource;
            IList logList = logsBindingSource.List;

            DateTime assignDate = default(DateTime);
            for (int i = 0; i < logList.Count; i++)
            {
                if (Boolean.Parse(dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    var log = (InvoiceFinanceLog)logList[i];
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

            e.IsValid = batch.FinancePeriodBegin >= assignDate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator2ValidateValue(object sender, ValidateValueEventArgs e)
        {
            var batch = (InvoiceFinanceBatch)batchBindingSource.DataSource;
            if (_case.TransactionType == "国内买方保理")
            {
                e.IsValid = true;
            }

            IList logList = logsBindingSource.List;

            DateTime dueDate = default(DateTime);
            for (int i = 0; i < logList.Count; i++)
            {
                if (Boolean.Parse(dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    var log = (InvoiceFinanceLog)logList[i];
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

            e.IsValid = batch.FinancePeriodEnd >= dueDate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator3ValidateValue(object sender, ValidateValueEventArgs e)
        {
            var batch = (InvoiceFinanceBatch)batchBindingSource.DataSource;
            e.IsValid = batch.FinanceRate>=0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator4ValidateValue(object sender, ValidateValueEventArgs e)
        {
            var batch = (InvoiceFinanceBatch)batchBindingSource.DataSource;
            if (batch.CostRate.HasValue)
            {
                e.IsValid = batch.CostRate>=0;
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
            if (dgvLogs.CurrentCell == null)
            {
                return;
            }

            var selectedLog = (InvoiceFinanceLog)logsBindingSource.List[dgvLogs.CurrentCell.RowIndex];
            var caseDetail = new CaseDetail(selectedLog.Invoice.InvoiceAssignBatch.Case,
                                            CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCDA(object sender, EventArgs e)
        {
            if (dgvLogs.CurrentCell == null)
            {
                return;
            }

            var selectedLog = (InvoiceFinanceLog)logsBindingSource.List[dgvLogs.CurrentCell.RowIndex];
            var cdaDetail = new CDADetail(selectedLog.Invoice.InvoiceAssignBatch.Case.ActiveCDA,
                                          CDADetail.OpCDAType.DETAIL_CDA);
            cdaDetail.ShowDialog(this);
        }

        /// <summary>
        /// Show detail info of selected inovice
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailInvoice(object sender, EventArgs e)
        {
            if (dgvLogs.CurrentCell == null)
            {
                return;
            }

            var selectedLog = (InvoiceFinanceLog)logsBindingSource.List[dgvLogs.CurrentCell.RowIndex];
            var invoiceDetail = new InvoiceDetail(selectedLog.Invoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
            invoiceDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (!superValidator.Validate())
            {
                return;
            }

            IList invoiceList = logsBindingSource.List;
            var log = (InvoiceFinanceLog)invoiceList[e.RowIndex];
            dgvLogs.EndEdit();

            if (dgvLogs.Columns[e.ColumnIndex] == colCheckBox)
            {
                var checkBoxCell = (DataGridViewCheckBoxCell)dgvLogs.Rows[e.RowIndex].Cells[0];
                if (Boolean.Parse(checkBoxCell.EditedFormattedValue.ToString()))
                {
                    ClickLog(log, checkBoxCell);
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
        private void DgvInvoicesCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }

            DataGridViewColumn col = dgvLogs.Columns[e.ColumnIndex];
            if (col == colInvoiceDate || col == colAssignDate || col == colDueDate)
            {
                var date = (DateTime)e.Value;
                e.Value = date.ToString("yyyyMMdd");
                e.FormattingApplied = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesCellParsing(object sender, DataGridViewCellParsingEventArgs e)
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

            DataGridViewColumn col = dgvLogs.Columns[e.ColumnIndex];
            if (col == colInvoiceDate || col == colAssignDate || col == colDueDate)
            {
                var str = (string)e.Value;
                e.Value = DateTime.ParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
                e.ParsingApplied = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue == null || e.FormattedValue.Equals(string.Empty))
            {
                return;
            }

            DataGridViewColumn col = dgvLogs.Columns[e.ColumnIndex];
            if (col == colInvoiceDate || col == colAssignDate || col == colDueDate)
            {
                var str = (string)e.FormattedValue;
                DateTime result;
                bool ok = DateTime.TryParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None,
                                                 out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
            else if (col == colFinanceAmount || col == colCommission)
            {
                var str = (string)e.FormattedValue;
                decimal result;
                bool ok = Decimal.TryParse(str, out result);
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
                    var selectedLog = (InvoiceFinanceLog)logsBindingSource.List[e.RowIndex];
                    if (result > selectedLog.AssignOutstanding * (decimal)_case.ActiveCDA.FinanceProportion)
                    {
                        if (DialogResult.No ==
                            MessageBoxEx.Show("您输入的融资金额超出融资比例的范围，确认录入吗？", MESSAGE.TITLE_INFORMATION,
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Information))
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
        private void DgvInvoicesCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (dgvLogs.Columns[e.ColumnIndex] == colFinanceAmount)
            {
                StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesRowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DetailInvoice(sender, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportFinanceBatch(object sender, EventArgs e)
        {
            if (_case == null)
            {
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(batchBindingSource.DataSource is InvoiceFinanceBatch))
            {
                return;
            }

            if (logsBindingSource.List.Count == 0)
            {
                return;
            }

            var exportForm = new ExportForm(ExportForm.ExportType.EXPORT_FINANCE_BY_BATCH, logsBindingSource.List);
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFinanceBatch(object sender, EventArgs e)
        {
            if (_case == null)
            {
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(batchBindingSource.DataSource is InvoiceFinanceBatch))
            {
                return;
            }

            var importForm = new ImportForm(ImportForm.ImportType.IMPORT_FINANCE_BY_BATCH);
            importForm.ShowDialog(this);
            var logList = (List<InvoiceFinanceLog>)importForm.ImportedList;
            if (logList != null)
            {
                for (int i = 0; i < logsBindingSource.List.Count; i++)
                {
                    var cell = (DataGridViewCheckBoxCell)dgvLogs.Rows[i].Cells[0];
                    cell.Value = 0;
                    var oldLog = (InvoiceFinanceLog)logsBindingSource.List[i];

                    InvoiceFinanceLog newLog = logList.SingleOrDefault(log => log.InvoiceNo2 == oldLog.InvoiceNo2);
                    if (newLog != null)
                    {
                        oldLog.FinanceAmount = newLog.FinanceAmount;
                        oldLog.Commission = newLog.Commission;
                        oldLog.Comment = newLog.Comment;

                        if (oldLog.FinanceAmount>0)
                        {
                            cell.Value = 1;
                        }

                        ResetRow(i, 1 == (int)cell.Value ? true : false);
                    }
                }

                dgvLogs.Refresh();
                StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewBatch(object sender, EventArgs e)
        {
            if (_case == null)
            {
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CDA activeCDA = _case.ActiveCDA;
            bool hasGD = _case.GuaranteeDepositClient.GuaranteeDeposits.Count > 0;

            if (activeCDA.HighestFinanceLine.HasValue == false)
            {
                MessageBoxEx.Show("该案件的最高预付款融资额度余额不足，不能融资", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (_case.HighestFinanceLine == null)
            {
                MessageBoxEx.Show("该客户融资额度为空，不能融资", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (_case.HighestFinanceLine.PeriodEnd < DateTime.Today)
            {
                MessageBoxEx.Show("客户融资额度已到期，不能融资", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!hasGD)
            {
                if (activeCDA.FinanceLineOutstanding<0)
                {
                    MessageBoxEx.Show("该案件的预付款融资额度余额不足，不能融资", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    return;
                }

                //double highestFinanceLine = activeCDA.HighestFinanceLine.Value;
                //if(activeCDA.FinanceLineCurr!=_case.InvoiceCurrency)
                //{
                //    double rate = Exchange.GetExchangeRate(activeCDA.FinanceLineCurr, _case.InvoiceCurrency);
                //    highestFinanceLine *= rate;
                //}

                ClientCreditLine highestFinanceLine = _case.HighestFinanceLine;
                decimal highestFinanceLineAmount = highestFinanceLine.CreditLine;
                if (highestFinanceLine.CreditLineCurrency != _case.InvoiceCurrency)
                {
                    decimal rate = Exchange.GetExchangeRate(highestFinanceLine.CreditLineCurrency, _case.InvoiceCurrency);
                    highestFinanceLineAmount *= rate;
                }

                if (highestFinanceLineAmount < _case.TotalFinanceOutstanding)
                {
                    MessageBoxEx.Show("该客户的最高预付款融资额度余额不足，不能融资", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    return;
                }
            }

            if (activeCDA.CommissionType == "按融资金额" || activeCDA.CommissionType == "其他")
            {
                colCommission.Visible = true;
            }
            else
            {
                colCommission.Visible = false;
            }

            var financeBatch = new InvoiceFinanceBatch
                                   {
                                       BatchCurrency = _case.InvoiceCurrency,
                                       CreateUserName = App.Current.CurUser.Name
                                   };
            //financeBatch.CheckStatus = BATCH.UNCHECK;
            batchBindingSource.DataSource = financeBatch;

            double financeProp = _case.ActiveCDA.FinanceProportion.GetValueOrDefault();

            IQueryable<Invoice> queryResult = from invoice in _context.Invoices
                                              where
                                                  invoice.InvoiceAssignBatch.CaseCode == _case.CaseCode
                                                  && invoice.IsFlaw == false
                                                  && invoice.IsDispute.GetValueOrDefault() == false
                                                  && invoice.DueDate > DateTime.Today.AddDays(1)
                                                  && (invoice.AssignAmount > invoice.PaymentAmount.GetValueOrDefault() )
                                                  && ((invoice.AssignAmount - invoice.PaymentAmount.GetValueOrDefault()) * (decimal)financeProp > invoice.FinanceAmount.GetValueOrDefault())
                                                  && invoice.InvoiceAssignBatch.CheckStatus == BATCH.CHECK
                                              orderby invoice.InvoiceAssignBatch.AssignDate
                                              select invoice;

            var logs = new List<InvoiceFinanceLog>();
            foreach (Invoice invoice in queryResult)
            {
                if (invoice.InvoiceAssignBatch.IsRefinance == false && invoice.InvoiceAssignBatch.IsRefinanced)
                {
                    continue;
                }

                var log = new InvoiceFinanceLog(invoice);
                logs.Add(log);
            }

            logsBindingSource.DataSource = logs;
            StatBatch();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCheckBoxClicked(object sender, DataGridViewCheckboxHeaderEventArgs e)
        {
            IList logList = logsBindingSource.List;
            foreach (DataGridViewRow dgvRow in dgvLogs.Rows)
            {
                var log = (InvoiceFinanceLog)logList[dgvRow.Index];
                if (e.CheckedState)
                {
                    dgvRow.Cells[0].Value = true;
                    var checkBoxCell = (DataGridViewCheckBoxCell)dgvLogs.Rows[dgvRow.Index].Cells[0];
                    ClickLog(log, checkBoxCell);
                    ResetRow(dgvRow.Index, true);
                }
                else
                {
                    dgvRow.Cells[0].Value = false;
                    ResetRow(dgvRow.Index, false);
                }

                dgvLogs.Refresh();
                StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="editable"></param>
        private void ResetRow(int rowIndex, bool editable)
        {
            dgvLogs.Rows[rowIndex].Cells["colFinanceAmount"].ReadOnly = !editable;
            dgvLogs.Rows[rowIndex].Cells["colComment"].ReadOnly = !editable;

            if (_case.ActiveCDA.CommissionType == "按融资金额" || _case.ActiveCDA.CommissionType == "其他")
            {
                dgvLogs.Rows[rowIndex].Cells["colCommission"].ReadOnly = !editable;
            }

            if (!editable)
            {
                IList logList = logsBindingSource.List;
                var log = (InvoiceFinanceLog)logList[rowIndex];
                log.FinanceAmount = 0;

                if (_case.ActiveCDA.CommissionType == "按融资金额" || _case.ActiveCDA.CommissionType == "其他")
                {
                    log.Commission = null;
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
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (_case == null)
            {
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!superValidator.Validate())
            {
                return;
            }

            if (!(batchBindingSource.DataSource is InvoiceFinanceBatch))
            {
                return;
            }

            if (!ValidateBatch())
            {
                return;
            }

            var batch = (InvoiceFinanceBatch)batchBindingSource.DataSource;
            var logList = new List<InvoiceFinanceLog>();

            decimal totalFinance =
                logsBindingSource.List.Cast<object>().Where(
                    (t, i) => Boolean.Parse(dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString())).Cast
                    <InvoiceFinanceLog>().Sum(log => log.FinanceAmount.GetValueOrDefault());

            if (batch.FinanceAmount != totalFinance)
            {
                MessageBoxEx.Show("融资额未分配结束，不能保存", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (_case.HighestFinanceLine.PeriodEnd < batch.FinancePeriodBegin)
            {
                throw new Exception(String.Format("客户融资额度已到期，不能融资"));
            }

            GuaranteeDeposit gd = _case.GuaranteeDepositClient.GetGuaranteeDeposit(batch.BatchCurrency);
            decimal guaranteeDeposit = 0;
            CDA activeCDA = _case.ActiveCDA;
            if (gd != null)
            {
                guaranteeDeposit = gd.GuaranteeDepositAmount;
            }
            if (activeCDA.FinanceLineOutstanding < batch.FinanceAmount - guaranteeDeposit)
            {
                throw new Exception(String.Format("该案件的预付款融资额度余额为{0:N2}，欲融资{1:N2}，额度不足，不能融资",
                                                  (activeCDA.FinanceLineOutstanding + guaranteeDeposit),
                                                  batch.FinanceAmount));
            }

            ClientCreditLine highestFinanceLine = _case.HighestFinanceLine;
            decimal highestFinanceLineAmount = highestFinanceLine.CreditLine;
            if (highestFinanceLine.CreditLineCurrency != _case.InvoiceCurrency)
            {
                decimal rate = Exchange.GetExchangeRate(highestFinanceLine.CreditLineCurrency, _case.InvoiceCurrency);
                highestFinanceLineAmount *= rate;
            }

            if (
                highestFinanceLineAmount < _case.TotalFinanceOutstanding + batch.FinanceAmount -
                                  guaranteeDeposit)
            {
                throw new Exception(String.Format("该客户的最高预付款融资额度余额为{0:N2}，欲融资{1:N2}，额度不足，不能融资",
                                                  (highestFinanceLineAmount - _case.TotalFinanceOutstanding +
                                                   guaranteeDeposit), batch.FinanceAmount));
            }

            bool isSaveOK = true;

            batch.Case = _case;
            if (batch.FinanceBatchNo == null)
            {
                batch.FinanceBatchNo = InvoiceFinanceBatch.GenerateFinanceBatchNo(batch.FinancePeriodBegin);
                batch.InputDate = DateTime.Today;
                batch.CheckStatus = BATCH.UNCHECK;
            }

            for (int i = 0; i < logsBindingSource.List.Count; i++)
            {
                var log = (InvoiceFinanceLog)logsBindingSource.List[i];
                if (Boolean.Parse(dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    log.Invoice = _context.Invoices.SingleOrDefault(invoice => invoice.InvoiceID == log.InvoiceID2);
                    logList.Add(log);
                    log.InvoiceFinanceBatch = batch;
                    log.Invoice.CaculateFinance();
                }
            }

            if (batch.InvoiceFinanceLogs.Count == 0)
            {
                batch.Case = null;
                batch.FinanceBatchNo = null;
                return;
            }

            try
            {
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (InvoiceFinanceLog log in logList)
                {
                    Invoice invoice = log.Invoice;
                    log.Invoice = null;
                    log.InvoiceFinanceBatch = null;
                    invoice.CaculateFinance();
                }

                batch.FinanceBatchNo = null;
                batch.Case = null;
                isSaveOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isSaveOK)
            {
                MessageBoxEx.Show("数据保存成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                _caseBasic.CaculateOutstanding(_case);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBatch(object sender, EventArgs e)
        {
            if (_case == null)
            {
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var batchMgr = new FinanceBatchMgr(_case, _context);
            var queryUI = new QueryForm(batchMgr, "选择融资批次");
            batchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoiceFinanceBatch selectedBatch = batchMgr.Selected;
            if (selectedBatch != null)
            {
                batchBindingSource.DataSource = selectedBatch;
                logsBindingSource.DataSource = selectedBatch.InvoiceFinanceLogs;

                for (int i = 0; i < logsBindingSource.List.Count; i++)
                {
                    var log = (InvoiceFinanceLog)logsBindingSource.List[i];
                    log.InvoiceNo2 = log.InvoiceNo2;

                    var cell = (DataGridViewCheckBoxCell)dgvLogs.Rows[i].Cells[0];
                    cell.Value = 1;
                    ResetRow(i, true);
                }

                StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFactor(object sender, EventArgs e)
        {
            if (_case == null)
            {
                MessageBoxEx.Show("没有选定案件", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(batchBindingSource.DataSource is InvoiceFinanceBatch))
            {
                return;
            }

            var financeBatch = (InvoiceFinanceBatch)batchBindingSource.DataSource;
            var factorMgr = new FactorMgr();
            var queryForm = new QueryForm(factorMgr, "选择代付行");
            factorMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);

            Factor factor = factorMgr.Selected;
            if (factor != null)
            {
                financeBatch.Factor = _context.Factors.SingleOrDefault(f => f.FactorCode == factor.FactorCode);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void StatBatch()
        {
            IList logList = logsBindingSource.List;
            var financeBatch = (InvoiceFinanceBatch)batchBindingSource.DataSource;

            decimal totalFinance = 0;
            decimal totalInterest = 0;
            for (int i = 0; i < logList.Count; i++)
            {
                if (Boolean.Parse(dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    totalFinance += ((InvoiceFinanceLog)logList[i]).FinanceAmount.GetValueOrDefault();
                    totalInterest += ((InvoiceFinanceLog)logList[i]).NetInterest;
                }
            }

            _currentBatchFinanceAmount = totalFinance;
            tbFinanceLineBalance.Text = String.Format("{0:N2}", financeBatch.FinanceAmount - totalFinance);
            tbTotalInterest.Text = String.Format("{0:N2}", totalInterest);
            if (totalFinance > financeBatch.FinanceAmount)
            {
                MessageBoxEx.Show("当前融资额超过限定", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidateBatch()
        {
            IList logList = logsBindingSource.List;
            for (int i = 0; i < logList.Count; i++)
            {
                if (Boolean.Parse(dgvLogs.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    var log = (InvoiceFinanceLog)logList[i];
                    if (log.FinanceAmount<=0)
                    {
                        MessageBoxEx.Show("融资金额不能为空: " + log.InvoiceNo2, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);
                        return false;
                    }

                    if (log.FinanceAmount > log.AssignOutstanding)
                    {
                        MessageBoxEx.Show("融资金额不能大于转让余额: " + log.InvoiceNo2, MESSAGE.TITLE_INFORMATION,
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
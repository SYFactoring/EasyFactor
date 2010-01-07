//-----------------------------------------------------------------------
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
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.CaseMgr;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceFinance : UserControl
    {
        #region Fields (2)

        private CDA _CDA;
        private ARCaseBasic caseBasic;

        #endregion Fields

        #region Constructors (1)

        public InvoiceFinance(ARCaseBasic caseBasic)
        {
            InitializeComponent();
            this.caseBasic = caseBasic;
            this.dgvInvoices.AutoGenerateColumns = false;
            this.superValidator.Enabled = false;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);

            this.batchCurrencyComboBoxEx.DataSource = Currency.AllCurrencies();
            this.batchCurrencyComboBoxEx.DisplayMember = "CurrencyCode";
            this.batchCurrencyComboBoxEx.ValueMember = "CurrencyCode";

            this.interestTypeComboBoxEx.Items.AddRange(new string[] { "一次性收取", "月结", "季结", "利随本清", "未知" });

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
                this.NewFinanceBatch(null, null);
            }
        }

        #endregion Properties

        #region Methods (18)

        // Public Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <returns></returns>
        public static string GenerateFinanceBatchNo(DateTime date)
        {
            DateTime begin = new DateTime(date.Year, date.Month, date.Day);
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoiceFinanceBatches.Count(batch => batch.FinancePeriodBegin >= begin && batch.FinancePeriodBegin < end);
            string financeNo = String.Format("FIN{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return financeNo;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ResetControlsStatus()
        {
            foreach (Control comp in this.panelFinanceBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }
            this.invoiceFinanceBatchBindingSource.DataSource = typeof(InvoiceFinanceBatch);
            this.invoiceBindingSource.DataSource = typeof(Invoice);
        }
        // Private Methods (16) 

        private void CaculateCommissionAndInterest(object sender, DataGridViewCellEventArgs e)
        {
            IList invoiceList = this.invoiceBindingSource.List;
            Invoice invoice = (Invoice)invoiceList[e.RowIndex];
            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.invoiceFinanceBatchBindingSource.DataSource;
            if (batch.FinanceRate.HasValue)
            {
                int period = (batch.FinnacePeriodEnd.Value - batch.FinancePeriodBegin.Value).Days;
                switch (batch.InterestType)
                {
                    case "一次性收取":
                        invoice.Interest = invoice.FinanceAmount * (batch.FinanceRate - batch.CostRate) / 360 * period;
                        invoice.InterestDate = invoice.FinanceDate;
                        break;
                    default:
                        break;
                }
            }

            if (this._CDA.CommissionType == "按融资金额")
            {
                invoice.Commission = invoice.FinanceAmount * this._CDA.Price ?? 0;
                if (invoice.Commission.GetValueOrDefault() > 0)
                {
                    invoice.CommissionDate = invoice.FinanceDate;
                }
            }

        }

        private void CaculateCurrentFinance()
        {
            IList invoiceList = this.invoiceBindingSource.List;
            InvoiceFinanceBatch financeBatch = (InvoiceFinanceBatch)this.invoiceFinanceBatchBindingSource.DataSource;

            double totalFinance = 0;
            double totalInterest = 0;
            for (int i = 0; i < invoiceList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    totalFinance += ((Invoice)invoiceList[i]).FinanceAmount.GetValueOrDefault();
                    totalInterest += ((Invoice)invoiceList[i]).Interest.GetValueOrDefault();
                }
            }
            this.tbTotalFinance.Text = String.Format("{0:N2}", totalFinance);
            this.tbFinanceLineBalance.Text = String.Format("{0:N2}", financeBatch.FinanceAmount - totalFinance);
            this.tbTotalInterest.Text = String.Format("{0:N2}", totalInterest);
            if (financeBatch.FinanceAmount.HasValue)
            {
                if (totalFinance > financeBatch.FinanceAmount)
                {
                    MessageBox.Show("当前融资额超过限定", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

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

        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            IList invoiceList = this.invoiceBindingSource.List;
            Invoice invoice = (Invoice)invoiceList[e.RowIndex];
            this.dgvInvoices.EndEdit();
            if (this.dgvInvoices.Columns[e.ColumnIndex] == colCheckBox)
            {

                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)this.dgvInvoices.Rows[e.RowIndex].Cells[0];

                if (Boolean.Parse(checkBoxCell.EditedFormattedValue.ToString()))
                {
                    double currentFinanceAmount;
                    if (!Double.TryParse(this.tbTotalFinance.Text, out currentFinanceAmount))
                        currentFinanceAmount = 0;

                    InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.invoiceFinanceBatchBindingSource.DataSource;
                    double financeAmount = 0;
                    if (batch.FinanceAmount.HasValue && invoice.AssignOutstanding * this._CDA.FinanceProportion.Value + currentFinanceAmount > batch.FinanceAmount.Value)
                    {
                        financeAmount = batch.FinanceAmount.Value - currentFinanceAmount;
                    }
                    else
                    {
                        financeAmount = invoice.AssignOutstanding * this._CDA.FinanceProportion.Value;
                    }

                    invoice.FinanceAmount = financeAmount;

                    invoice.FinanceDate = batch.FinancePeriodBegin ?? DateTime.Now;
                    invoice.FinanceDueDate = batch.FinnacePeriodEnd ?? null;

                    CaculateCommissionAndInterest(sender, e);

                    colFinanceAmount.ReadOnly = false;
                    colFinanceDate.ReadOnly = false;
                    colFinanceDueDate.ReadOnly = false;
                    colComment.ReadOnly = false;
                    colInterest.ReadOnly = false;
                    colInterestDate.ReadOnly = false;
                    colCommission.ReadOnly = false;
                    colCommissionDate.ReadOnly = false;
                }
                else
                {
                    invoice.FinanceAmount = null;
                    invoice.FinanceDate = null;
                    invoice.FinanceDueDate = null;
                    invoice.Interest = null;
                    invoice.InterestDate = null;
                    invoice.Commission = null;
                    invoice.CommissionDate = null;

                    colFinanceAmount.ReadOnly = true;
                    colFinanceDate.ReadOnly = true;
                    colFinanceDueDate.ReadOnly = true;
                    colComment.ReadOnly = true;
                    colInterest.ReadOnly = true;
                    colInterestDate.ReadOnly = true;
                    colCommission.ReadOnly = true;
                    colCommissionDate.ReadOnly = true;
                }
                CaculateCurrentFinance();
            }

        }

        void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;
            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colInvoiceDate || col == colAssignDate || col == colDueDate || col == colFinanceDate || col == colFinanceDueDate || col == colInterestDate || col == colCommissionDate)
            {
                DateTime date = (DateTime)e.Value;
                e.Value = date.ToString("yyyyMMdd");
                e.FormattingApplied = true;
            }
        }

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
            if (col == colInvoiceDate || col == colAssignDate || col == colDueDate || col == colFinanceDate || col == colFinanceDueDate || col == colInterestDate || col == colCommissionDate)
            {
                string str = (string)e.Value;
                e.Value = DateTime.ParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
                e.ParsingApplied = true;
            }
        }

        private void dgvInvoices_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue == null || e.FormattedValue.Equals(string.Empty))
            {
                return;
            }
            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colInvoiceDate || col == colAssignDate || col == colDueDate || col == colFinanceDate || col == colFinanceDueDate || col == colInterestDate || col == colCommissionDate)
            {
                string str = (string)e.FormattedValue;
                DateTime result;
                bool ok = DateTime.TryParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
            else if (col == colFinanceAmount || col == colInterest || col == colCommission)
            {
                string str = (string)e.FormattedValue;
                double result;
                bool ok = Double.TryParse(str, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dgvInvoices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (this.dgvInvoices.Columns[e.ColumnIndex] == colFinanceAmount)
            {
                CaculateCurrentFinance();
                CaculateCommissionAndInterest(sender, e);
            }
        }

        private void dgvInvoices_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DetailInvoice(null, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFinanceBatch(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_FINANCE);
            importForm.ShowDialog(this);
        }

        private void NewFinanceBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.tbTotalFinance.Text = string.Empty;
            InvoiceFinanceBatch financeBatch = new InvoiceFinanceBatch();
            financeBatch.BatchCurrency = this._CDA.Case.InvoiceCurrency;
            financeBatch.CreateUserName = App.Current.CurUser.Name;
            this.invoiceFinanceBatchBindingSource.DataSource = financeBatch;
            this.invoiceBindingSource.DataSource = App.Current.DbContext.Invoices.Where(i => i.InvoiceAssignBatch.CDACode == this._CDA.CDACode && i.FinanceAmount.HasValue == false).ToList();
        }

        private void SaveFinanceBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //if (!this.superValidator.Validate())
            //{
            //    return;
            //}

            if (!(this.invoiceFinanceBatchBindingSource.DataSource is InvoiceFinanceBatch))
            {
                return;
            }
            if (!ValidateFinanceBatch())
            {
                return;
            }

            bool isSaveOK = true;
            InvoiceFinanceBatch financeBatch = (InvoiceFinanceBatch)this.invoiceFinanceBatchBindingSource.DataSource;
            financeBatch.CDA = this._CDA;

            IList invoiceList = this.invoiceBindingSource.List;
            for (int i = 0; i < invoiceList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    ((Invoice)invoiceList[i]).InvoiceFinanceBatch = financeBatch;
                }
            }
            if (financeBatch.Invoices.Count == 0)
            {
                return;
            }
            try
            {
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                isSaveOK = false;
                MessageBox.Show(e1.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (isSaveOK)
            {
                MessageBox.Show("数据保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.caseBasic.CaculateOutstanding(this._CDA);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFactor(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.invoiceFinanceBatchBindingSource.DataSource is InvoiceFinanceBatch))
            {
                return;
            }
            InvoiceFinanceBatch financeBatch = (InvoiceFinanceBatch)this.invoiceFinanceBatchBindingSource.DataSource;
            FactorMgr factorMgr = new FactorMgr(false);
            QueryForm queryForm = new QueryForm(factorMgr, "选择代付行");
            factorMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);

            Factor factor = factorMgr.Selected;
            if (factor != null)
            {
                financeBatch.Factor = factor;
            }
        }

        private bool ValidateFinanceBatch()
        {
            foreach (Invoice invoice in this.invoiceBindingSource.List)
            {
                if (invoice.AssignAmount > invoice.InvoiceAmount)
                {
                    MessageBox.Show("转让金额不能大于票面金额: " + invoice.InvoiceNo, "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (invoice.InvoiceDate > invoice.AssignDate)
                {
                    MessageBox.Show("转让日不能早于发票日: " + invoice.InvoiceNo, "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (invoice.DueDate < invoice.AssignDate)
                {
                    MessageBox.Show("转让日不能晚于发票到期日: " + invoice.InvoiceNo, "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        #endregion Methods
    }
}

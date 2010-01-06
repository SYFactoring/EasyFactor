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

            this.interestTypeComboBoxEx.Items.AddRange(new string[] { "预扣息", "后扣息" });

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

        #region Methods (14)

        // Public Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <returns></returns>
        public static string GenerateFinanceBatchNo(CDA cda, System.Nullable<DateTime> date)
        {
            int batchCount = 0;
            foreach (CDA c in cda.Case.CDAs)
            {
                batchCount += c.InvoiceFinanceBatches.Count;
            }
            if (date == null)
            {
                date = DateTime.Now;
            }
            string financeNo = String.Format("FIN{0:G}{1:yyyyMMdd}-{2:d2}", cda.CaseCode, date, batchCount + 1);
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
        // Private Methods (12) 

        private void CaculateCurrentFinanceAmount()
        {
            IList invoiceList = this.invoiceBindingSource.List;
            double currentFinanceAmount = 0;
            for (int i = 0; i < invoiceList.Count; i++)
            {
                if (Boolean.Parse(this.dgvInvoices.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    currentFinanceAmount += ((Invoice)invoiceList[i]).FinanceAmount.GetValueOrDefault();
                }
            }
            this.tbCurrentFinanceAmount.Text = String.Format("{0:N2}", currentFinanceAmount);
            InvoiceFinanceBatch financeBatch = (InvoiceFinanceBatch)this.invoiceFinanceBatchBindingSource.DataSource;
            if (financeBatch.FinanceAmount.HasValue)
            {
                if (currentFinanceAmount > financeBatch.FinanceAmount)
                {
                    MessageBox.Show("当前融资额超过限定", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
                    invoice.FinanceAmount = invoice.AssignAmount;
                    invoice.FinanceDate = DateTime.Now;

                    colFinanceAmount.ReadOnly = false;
                    colFinanceDate.ReadOnly = false;
                    colFinanceDueDate.ReadOnly = false;
                    colComment.ReadOnly = false;
                }
                else
                {
                    invoice.FinanceAmount = null;
                    invoice.FinanceDate = null;
                    invoice.FinanceDueDate = null;

                    colFinanceAmount.ReadOnly = true;
                    colFinanceDate.ReadOnly = true;
                    colFinanceDueDate.ReadOnly = true;
                    colComment.ReadOnly = true;
                }
                CaculateCurrentFinanceAmount();
            }

        }

        void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;
            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colDueDate || col == colFinanceDate || col == colFinanceDueDate)
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
            if (col == colDueDate || col == colFinanceDate || col == colFinanceDueDate)
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
            if (col == colDueDate || col == colFinanceDate || col == colFinanceDueDate)
            {
                string str = (string)e.FormattedValue;
                DateTime result;
                bool ok = DateTime.TryParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
            else if (col == colFinanceAmount)
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
                CaculateCurrentFinanceAmount();
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

            this.tbCurrentFinanceAmount.Text = string.Empty;
            InvoiceFinanceBatch financeBatch = new InvoiceFinanceBatch();
            financeBatch.BatchCurrency = this._CDA.Case.InvoiceCurrency;
            financeBatch.FinancePeriodBegin = DateTime.Now;
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

            if (!this.superValidator.Validate())
            {
                return;
            }

            if (!(this.invoiceFinanceBatchBindingSource.DataSource is InvoiceFinanceBatch))
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

        #endregion Methods
    }
}

//-----------------------------------------------------------------------
// <copyright file="InvoiceFinance.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections.Generic;
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
        #region Fields (1)

        private CDA _CDA;

        #endregion Fields

        #region Constructors (1)

        public InvoiceFinance()
        {
            InitializeComponent();
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.ReadOnly = true;
            this.superValidator.Enabled = false;

            this.batchCurrencyComboBoxEx.DataSource = Currency.AllCurrencies();
            this.batchCurrencyComboBoxEx.DisplayMember = "CurrencyCode";
            this.batchCurrencyComboBoxEx.ValueMember = "CurrencyCode";

            this.interestTypeComboBoxEx.Items.AddRange(new string[] { "预扣息", "后扣息" });
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
                this.dgvInvoices.ReadOnly = false;
                this.superValidator.Enabled = true;
                this.invoiceFinanceBatchBindingSource.DataSource = new InvoiceFinanceBatch();
                this.invoiceBindingSource.DataSource = App.Current.DbContext.Invoices.Where(i => i.InvoiceAssignBatch.CDACode == this._CDA.CDACode && i.FinanceAmount.HasValue == false).ToList();
            }
        }

        #endregion Properties

        #region Methods (5)

        // Public Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <returns></returns>
        public static string GenerateFinanceBatchNo(CDA cda, System.Nullable<DateTime> date)
        {
            Client seller = cda.Case.SellerClient;
            Client buyer = cda.Case.BuyerClient;
            int batchCount = cda.InvoiceFinanceBatches.Count;
            if (date == null)
            {
                date = DateTime.Now;
            }
            string financeNo = String.Format("FIN{0:G}{1:G}{2:yyyyMMdd}-{3:d2}", seller.ClientEDICode.Substring(0, 5), buyer.ClientEDICode.Substring(3, 2), date, batchCount + 1);
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
        // Private Methods (4) 

        /// <summary>
        /// Show detail info of selected inovice
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailInvoice(object sender, System.EventArgs e)
        {
            if (this.dgvInvoices.SelectedRows.Count == 0)
            {
                return;
            }

            string ino = (string)dgvInvoices["colInvoiceNo", dgvInvoices.SelectedRows[0].Index].Value;
            if (ino != null)
            {
                Invoice selectedInvoice = ((InvoiceAssignBatch)this.invoiceFinanceBatchBindingSource.DataSource).Invoices.SingleOrDefault(i => i.InvoiceNo == ino);
                if (selectedInvoice != null)
                {
                    InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
                    invoiceDetail.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFinanceBatch(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_FINANCE);
            importForm.Show();
        }

        private void SaveFinanceBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                return;
            }

            if (!this.superValidator.Validate())
            {
                return;
            }

            bool isSaveOK = true;
            InvoiceFinanceBatch financeBatch = (InvoiceFinanceBatch)this.invoiceFinanceBatchBindingSource.DataSource;
            financeBatch.CreateUserName = App.Current.CurUser.Name;
            financeBatch.CDA = this._CDA;
            foreach (Invoice invoice in this.invoiceBindingSource.DataSource as List<Invoice>)
            {
                invoice.InvoiceFinanceBatch = financeBatch;
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
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFactor(object sender, EventArgs e)
        {
            InvoiceFinanceBatch invoiceFinanceBatch = this.invoiceFinanceBatchBindingSource.DataSource as InvoiceFinanceBatch;
            if (invoiceFinanceBatch == null)
            {
                return;
            }

            FactorMgr factorMgr = new FactorMgr(false);
            QueryForm queryForm = new QueryForm(factorMgr, "选择代付行");
            factorMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);

            Factor factor = factorMgr.Selected;
            if (factor != null)
            {
                invoiceFinanceBatch.Factor = factor;
            }
        }

        #endregion Methods
    }
}

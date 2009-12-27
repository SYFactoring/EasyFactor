//-----------------------------------------------------------------------
// <copyright file="InvoiceAssign.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceAssign : UserControl
    {
        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        public InvoiceAssign()
        {
            this.InitializeComponent();
            this.dgvInvoices.AutoGenerateColumns = false;

            this.colInvoiceCurrency.DataSource = Currency.AllCurrencies().ToList();
            this.colInvoiceCurrency.DisplayMember = "CurrencyCode";
            this.colInvoiceCurrency.ValueMember = "CurrencyCode";
        }

        #endregion Constructors

        #region Properties (1)

        /// <summary>
        /// 
        /// </summary>
        public CDA CDA
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (6)

        // Public Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        public void ResetControlsStatus()
        {
            foreach (Control comp in this.panelAssignBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }
            this.invoiceBindingSource.DataSource = typeof(Invoice);
            this.invoiceAssignBatchBindingSource.DataSource = typeof(InvoiceAssignBatch);
        }
        // Private Methods (5) 

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
                Invoice selectedInvoice = ((InvoiceAssignBatch)this.invoiceAssignBatchBindingSource.DataSource).Invoices.SingleOrDefault(i => i.InvoiceNo == ino);
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
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Flaw(object sender, System.EventArgs e)
        {
            if (this.dgvInvoices.SelectedRows.Count == 0)
            {
                return;
            }

            string ino = (string)dgvInvoices["colInvoiceNo", dgvInvoices.SelectedRows[0].Index].Value;
            if (ino != null)
            {
                Invoice selectedInvoice = App.Current.DbContext.Invoices.SingleOrDefault(i => i.InvoiceNo == ino);
                if (selectedInvoice != null)
                {
                    InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.FLAW);
                    invoiceDetail.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewAssignBatch(object sender, EventArgs e)
        {
            if (this.CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            InvoiceAssignBatch assignBatch = new InvoiceAssignBatch();
            assignBatch.AssignBatchNo = GenerateAssignBatchNo(this.CDA);
            assignBatch.BatchDate = DateTime.Now;
            assignBatch.CreateUserName = App.Current.CurUser.Name;
            assignBatch.IsCreateMsg = false;
            this.invoiceAssignBatchBindingSource.DataSource = assignBatch;
            this.invoiceBindingSource.DataSource = assignBatch.Invoices;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <returns></returns>
        public static string GenerateAssignBatchNo(CDA cda)
        {
            Client seller = cda.Case.SellerClient;
            Client buyer = cda.Case.BuyerClient;
            string date = String.Format("{0:yyyy}{0:MM}{0:dd}", DateTime.Today);
            int batchCount = cda.InvoiceAssignBatches.Count;
            string assignNo = seller.ClientEDICode.Substring(0, 5) + buyer.ClientEDICode.Substring(3, 2) + date + "-" + String.Format("{0:D2}", batchCount + 1);
            return assignNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAssignBatch(object sender, EventArgs e)
        {
            if (this.assignBatchNoTextBox.Text == string.Empty)
            {
                return;
            }

            bool isSaveOK = true;
            InvoiceAssignBatch assignBatch = (InvoiceAssignBatch)this.invoiceAssignBatchBindingSource.DataSource;
            assignBatch.CDA = this.CDA;
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
        private void SelectAssignBatch(object sender, EventArgs e)
        {
            if (this.CDA == null)
            {
                return;
            }

            AssignBatchMgr assignBatchMgr = new AssignBatchMgr(this.CDA);
            QueryForm queryUI = new QueryForm(assignBatchMgr, "选择转让批次");
            assignBatchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoiceAssignBatch assignBatch = assignBatchMgr.Selected;
            if (assignBatch != null)
            {
                this.invoiceAssignBatchBindingSource.DataSource = assignBatch;
                this.invoiceBindingSource.DataSource = assignBatch.Invoices;
            }
        }

        #endregion Methods

        private void ImportAssignBatch(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_ASSIGN);
            importForm.Show();
        }

        private void dgvInvoices_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DetailInvoice(null, null);
        }

    }
}

//-----------------------------------------------------------------------
// <copyright file="InvoiceAssign.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceAssign : UserControl
    {
        #region Fields (1)

        private CDA _CDA;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        public InvoiceAssign()
        {
            this.InitializeComponent();
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.ReadOnly = true;
            this.superValidator.Enabled = false;

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
            }
        }

        #endregion Properties

        #region Methods (10)

        // Public Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <returns></returns>
        public static string GenerateAssignBatchNo(CDA cda, System.Nullable<DateTime> date)
        {
            Client seller = cda.Case.SellerClient;
            Client buyer = cda.Case.BuyerClient;
            int batchCount = cda.InvoiceAssignBatches.Count;
            if (date == null)
            {
                date = DateTime.Now;
            }
            string assignNo = String.Format("ASS{0:G}{1:G}{2:yyyyMMdd}-{3:d2}", seller.ClientEDICode.Substring(0, 5), buyer.ClientEDICode.Substring(3, 2), date, batchCount + 1);
            return assignNo;
        }

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
        // Private Methods (8) 

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

        private void dgvInvoices_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DetailInvoice(null, null);
        }

        private void dgvInvoices_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (this._CDA != null)
            {
                string currency = this._CDA.Case.InvoiceCurrency;
                if (this.dgvInvoices.Rows[e.RowIndex].Cells[1].Value == null)
                {
                    this.dgvInvoices.Rows[e.RowIndex].Cells[1].Value = currency;
                }
                if (this.dgvInvoices.Rows[e.RowIndex].Cells[5].Value == null)
                {
                    this.dgvInvoices.Rows[e.RowIndex].Cells[5].Value = DateTime.Now;
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

        private void ImportAssignBatch(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_ASSIGN);
            importForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewAssignBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            InvoiceAssignBatch assignBatch = new InvoiceAssignBatch();
            assignBatch.AssignBatchNo = GenerateAssignBatchNo(this._CDA, DateTime.Now);
            assignBatch.BatchDate = DateTime.Now;
            assignBatch.CreateUserName = App.Current.CurUser.Name;
            assignBatch.IsCreateMsg = false;
            this.invoiceAssignBatchBindingSource.DataSource = assignBatch;
            this.invoiceBindingSource.DataSource = assignBatch.Invoices;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAssignBatch(object sender, EventArgs e)
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
            InvoiceAssignBatch assignBatch = (InvoiceAssignBatch)this.invoiceAssignBatchBindingSource.DataSource;
            assignBatch.CDA = this._CDA;
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
            if (this._CDA == null)
            {
                return;
            }

            AssignBatchMgr assignBatchMgr = new AssignBatchMgr(this._CDA);
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
    }
}

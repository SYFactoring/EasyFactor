
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

        /// <summary>
        /// 
        /// </summary>
        private OpAssignType opAssignType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpAssignType
        {
            NEW_ASSIGN,
            UPDATE_ASSIGN
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        public InvoiceAssign()
        {
            this.InitializeComponent();

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

            string ino = (string)dgvInvoices["InvoiceNoColumn", dgvInvoices.SelectedRows[0].Index].Value;
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

            string ino = (string)dgvInvoices["InvoiceNoColumn", dgvInvoices.SelectedRows[0].Index].Value;
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
            Client seller = this.CDA.Case.SellerClient;
            Client buyer = this.CDA.Case.BuyerClient;
            string date = String.Format("{0:yyyy}{0:MM}{0:dd}", DateTime.Today);
            int batchCount = this.CDA.InvoiceAssignBatches.Count;
            string assignNo = seller.ClientEDICode.Substring(0, 5) + buyer.ClientEDICode.Substring(3, 2) + date + "-" + String.Format("{0:D2}", batchCount + 1);
            InvoiceAssignBatch assignBatch = new InvoiceAssignBatch();
            assignBatch.AssignBatchNo = assignNo;
            assignBatch.BatchDate = DateTime.Now;
            assignBatch.CreateUserName = App.Current.CurUser.Name;
            assignBatch.IsCreateMsg = false;
            assignBatch.CDA = this.CDA;
            this.invoiceAssignBatchBindingSource.DataSource = assignBatch;
            this.invoiceBindingSource.DataSource = assignBatch.Invoices;
            this.opAssignType = OpAssignType.NEW_ASSIGN;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAssignBatch(object sender, EventArgs e)
        {
            bool isSaveOK = true;
            InvoiceAssignBatch assignBatch = (InvoiceAssignBatch)this.invoiceAssignBatchBindingSource.DataSource;
            try
            {
                if (opAssignType == OpAssignType.NEW_ASSIGN)
                {
                    App.Current.DbContext.InvoiceAssignBatches.InsertOnSubmit(assignBatch);
                }
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
                opAssignType = OpAssignType.UPDATE_ASSIGN;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAssignBatch(object sender, EventArgs e)
        {
            AssignBatchMgr assignBatchMgr = new AssignBatchMgr(this.CDA);
            QueryForm queryUI = new QueryForm(assignBatchMgr, "选择转让批次");
            assignBatchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoiceAssignBatch assignBatch = assignBatchMgr.Selected;
            if (assignBatch != null)
            {
                this.invoiceAssignBatchBindingSource.DataSource = assignBatch;
                this.invoiceBindingSource.DataSource = assignBatch.Invoices;
                this.opAssignType = OpAssignType.UPDATE_ASSIGN;
            }
        }

        #endregion Methods
    }
}

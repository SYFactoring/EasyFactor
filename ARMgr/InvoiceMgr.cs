
namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using System.Collections;
    using CMBC.EasyFactor.CaseMgr;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceMgr : UserControl
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;
        /// <summary>
        /// 
        /// </summary>
        private OpInvoiceType opInvoiceType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpInvoiceType
        {
            /// <summary>
            /// 
            /// </summary>
            INVOICE_QUERY,

            /// <summary>
            /// 
            /// </summary>
            FLAW_RESOLVE
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opInvoiceType"></param>
        public InvoiceMgr(OpInvoiceType opInvoiceType)
        {
            InitializeComponent();
            this.dgvInvoices.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvInvoices.DataSource = bs;
            this.opInvoiceType = opInvoiceType;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);

            this.dgvInvoices.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvInvoices_CellFormatting);

            if (opInvoiceType == OpInvoiceType.FLAW_RESOLVE)
            {
                this.cbIsFlaw.CheckValue = "Y";
                this.cbIsFlaw.Enabled = false;
                this.colIsFlaw.ReadOnly = false;
                var queryResult = App.Current.DbContext.Invoices.Where(invoice => invoice.IsFlaw == true);
                this.bs.DataSource = queryResult.ToList();
                this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
        }

        #endregion Constructors

        #region Methods (10)

        // Private Methods (10) 

        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailInvoice(sender, e);
        }

        private void DeleteInvoice(object sender, EventArgs e)
        {
            if (this.dgvInvoices.SelectedCells.Count == 0)
            {
                return;
            }
            List<Invoice> selectedInvoices = new List<Invoice>();
            List<int> rowIndexes = new List<int>();
            foreach (DataGridViewCell cell in this.dgvInvoices.SelectedCells)
            {
                Invoice invoice = (Invoice)this.bs.List[cell.RowIndex];
                if (!selectedInvoices.Contains(invoice))
                {
                    rowIndexes.Add(cell.RowIndex);
                    selectedInvoices.Add(invoice);
                }
            }

            if (MessageBox.Show("是否打算删除此" + selectedInvoices.Count + "条发票", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                App.Current.DbContext.Invoices.DeleteAllOnSubmit(selectedInvoices);
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBox.Show("删除失败," + e1.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                rowIndexes.Sort();
                rowIndexes.Reverse();
                foreach (int rowIndex in rowIndexes)
                {
                    dgvInvoices.Rows.RemoveAt(rowIndex);
                }

            }
        }

        private void DetailCase(object sender, EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.bs.List[this.dgvInvoices.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedInvoice.InvoiceAssignBatch.CDA.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        private void DetailCDA(object sender, EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.bs.List[this.dgvInvoices.CurrentCell.RowIndex];
            CDADetail cdaDetail = new CDADetail(selectedInvoice.InvoiceAssignBatch.CDA, CDADetail.OpCDAType.DETAIL_CDA);
            cdaDetail.ShowDialog(this);
        }

        private void DetailInvoice(object sender, EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.bs.List[this.dgvInvoices.CurrentCell.RowIndex];
            InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
            invoiceDetail.ShowDialog(this);
        }

        void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = this.dgvInvoices.Columns[e.ColumnIndex];
            if (column == colIsFlaw)
            {
                Object originalData = e.Value;
                if (originalData != null)
                {
                    bool result = (bool)originalData;
                    if (result)
                    {
                        e.Value = "Y";
                    }
                    else
                    {
                        e.Value = "N";
                    }
                }
            }
        }

        private void ExportAssignFinancePayment(object sender, EventArgs e)
        {
            if (this.bs.DataSource is List<Invoice>)
            {
                ExportUtil exportUtil = new ExportUtil(ExportUtil.ExportType.EXPORT_ASSIGN_FINANCE_PAYMENT);
                exportUtil.StartExport(((List<Invoice>)this.bs.DataSource).ToArray());
            }
        }

        private void InvoiceFlaw(object sender, EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.bs.List[this.dgvInvoices.CurrentCell.RowIndex];
            InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.FLAW);
            invoiceDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoices(object sender, EventArgs e)
        {
            string sellerName = this.tbSeller.Text;
            string buyerName = this.tbBuyer.Text;
            string factorName = this.tbFactor.Text;
            string invoiceNo = this.tbInvoiceNo.Text;
            string isFlaw = this.cbIsFlaw.CheckValue as string;
            string isDispute = this.cbIsDispute.CheckValue as string;

            var queryResult = from invoice in App.Current.DbContext.Invoices
                              let seller = invoice.InvoiceAssignBatch.CDA.Case.SellerClient
                              where seller.ClientNameCN.Contains(sellerName) || seller.ClientNameEN_1.Contains(sellerName) || seller.ClientNameEN_2.Contains(sellerName)
                              let buyer = invoice.InvoiceAssignBatch.CDA.Case.BuyerClient
                              where buyer.ClientNameCN.Contains(buyerName) || buyer.ClientNameEN_1.Contains(buyerName) || buyer.ClientNameEN_2.Contains(buyerName)
                              let sellerFactor = invoice.InvoiceAssignBatch.CDA.Case.SellerFactor
                              where sellerFactor.CompanyNameCN.Contains(factorName) || sellerFactor.CompanyNameEN.Contains(factorName)
                              let buyerFactor = invoice.InvoiceAssignBatch.CDA.Case.BuyerFactor
                              where buyerFactor.CompanyNameCN.Contains(factorName) || buyerFactor.CompanyNameEN.Contains(factorName)
                              where (invoiceNo == string.Empty ? true : invoice.InvoiceNo == invoiceNo)
                                && (isFlaw == "A" ? true : invoice.IsFlaw == (isFlaw == "Y" ? true : false))
                                && (isDispute == "A" ? true : invoice.IsDispute == (isDispute == "Y" ? true : false))
                              select invoice;
            this.bs.DataSource = queryResult.ToList();
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, EventArgs e)
        {
            this.tbBuyer.Text = string.Empty;
            this.tbSeller.Text = string.Empty;
            this.tbFactor.Text = string.Empty;
            this.tbInvoiceNo.Text = string.Empty;
            switch (opInvoiceType)
            {
                case OpInvoiceType.FLAW_RESOLVE:
                    break;
                case OpInvoiceType.INVOICE_QUERY:
                    this.cbIsFlaw.CheckValue = "A";
                    break;
                default:
                    break;
            }
        }

        #endregion Methods
    }
}

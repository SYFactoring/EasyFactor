
namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

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

        #region Methods (3)

        // Private Methods (3) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (opInvoiceType == OpInvoiceType.FLAW_RESOLVE)
            {
                if (e.ColumnIndex == 9)
                {
                    DataGridViewCheckBoxCell cell = this.dgvInvoices.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                    bool isFlaw = Convert.ToBoolean(cell.EditedFormattedValue);

                    List<Invoice> invoiceList = this.bs.DataSource as List<Invoice>;
                    Invoice invoice = invoiceList[e.RowIndex];
                    if (isFlaw)
                    {
                        invoice.IsFlaw = true;
                    }
                    else
                    {
                        invoice.IsFlaw = false;
                        invoice.FlawResolveDate = DateTime.Now;
                        invoice.FlawResolveUserName = App.Current.CurUser.Name;
                    }
                    try
                    {
                        App.Current.DbContext.SubmitChanges();
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message, "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
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

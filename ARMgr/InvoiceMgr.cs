
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
    using System.Drawing;

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
            FLAW_RESOLVE,

            /// <summary>
            /// 
            /// </summary>
            DISPUTE_RESOLVE,

            /// <summary>
            /// 
            /// </summary>
            BATCH_DETAIL,

        }

        #endregion Enums

        #region Constructors (2)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        public InvoiceMgr(List<Invoice> invoiceList)
            : this(OpInvoiceType.BATCH_DETAIL)
        {
            this.bs.DataSource = invoiceList;
            this.lblCount.Text = String.Format("获得{0}条记录", invoiceList.Count());
            this.panelQuery.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opInvoiceType"></param>
        public InvoiceMgr(OpInvoiceType opInvoiceType)
        {
            InitializeComponent();
            this.bs = new BindingSource();
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.DataSource = bs;
            this.opInvoiceType = opInvoiceType;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);

            this.dgvInvoices.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvInvoices_CellFormatting);

            if (opInvoiceType == OpInvoiceType.FLAW_RESOLVE)
            {
                this.cbIsFlaw.CheckValue = "Y";
                var queryResult = App.Current.DbContext.Invoices.Where(invoice => invoice.IsFlaw == true);
                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
            else if (opInvoiceType == OpInvoiceType.DISPUTE_RESOLVE)
            {
                this.cbIsDispute.CheckValue = "Y";
                var queryResult = App.Current.DbContext.Invoices.Where(invoice => invoice.IsDispute == true);
                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
        }

        #endregion Constructors

        #region Properties (2)

        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets selected AssignBatch
        /// </summary>
        public Invoice Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (14)

        // Private Methods (14) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailInvoice(sender, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            if (MessageBox.Show("是否打算删除此" + selectedInvoices.Count + "条发票", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                App.Current.DbContext.Invoices.DeleteAllOnSubmit(selectedInvoices);
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBox.Show("删除失败," + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            Invoice selectedInvoice = (Invoice)this.bs.List[this.dgvInvoices.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedInvoice.InvoiceAssignBatch.CDA.Case, CaseDetail.OpCaseType.DETAIL_CASE);
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

            Invoice selectedInvoice = (Invoice)this.bs.List[this.dgvInvoices.CurrentCell.RowIndex];
            CDADetail cdaDetail = new CDADetail(selectedInvoice.InvoiceAssignBatch.CDA, CDADetail.OpCDAType.DETAIL_CDA);
            cdaDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = this.dgvInvoices.Columns[e.ColumnIndex];
            if (column == colIsFlaw || column == colIsDispute)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.bs.List.Count; i++)
            {
                Invoice invoice = (Invoice)this.bs.List[i];
                if (invoice.AssignOverDueDays >= 0)
                {
                    this.dgvInvoices["colDueDate", i].Style.BackColor = Color.Yellow;
                }
                if (invoice.FinanceOverDueDays >= 0)
                {
                    this.dgvInvoices["colFinanceDueDate", i].Style.BackColor = Color.Red;
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                dgvInvoices.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvInvoices.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvInvoices.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportAllInvoices(object sender, EventArgs e)
        {
            if (this.bs.DataSource is List<Invoice>)
            {
                ExportForm exportForm = new ExportForm(ExportForm.ExportType.EXPORT_INVOICES);
                exportForm.StartExport(this.bs.List);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportSelectedInvoices(object sender, EventArgs e)
        {
            if (this.dgvInvoices.SelectedCells.Count == 0)
            {
                return;
            }
            List<Invoice> selectedInvoices = new List<Invoice>();
            foreach (DataGridViewCell cell in this.dgvInvoices.SelectedCells)
            {
                Invoice invoice = (Invoice)this.bs.List[cell.RowIndex];
                if (!selectedInvoices.Contains(invoice))
                {
                    selectedInvoices.Add(invoice);
                }
            }
            ExportForm exportForm = new ExportForm(ExportForm.ExportType.EXPORT_INVOICES);
            exportForm.StartExport(selectedInvoices);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceDispute(object sender, EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.bs.List[this.dgvInvoices.CurrentCell.RowIndex];
            InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.DISPUTE);
            invoiceDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceFlaw(object sender, EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            List<Invoice> selectedInvoices = new List<Invoice>();
            foreach (DataGridViewCell cell in this.dgvInvoices.SelectedCells)
            {
                Invoice invoice = (Invoice)this.bs.List[cell.RowIndex];
                if (!selectedInvoices.Contains(invoice))
                {
                    selectedInvoices.Add(invoice);
                }
            }
            if (selectedInvoices.Count == 1)
            {
                InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoices[0], InvoiceDetail.OpInvoiceType.FLAW);
                invoiceDetail.ShowDialog(this);
            }
            else if (selectedInvoices.Count > 1)
            {
                InvoiceFlaw invoiceFlaw = new InvoiceFlaw(selectedInvoices);
                invoiceFlaw.ShowDialog(this);
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
            string isDispute = this.cbIsDispute.CheckValue as string;
            string caseMark = this.cbCaseMark.Text;
            string cdaStatus = this.cbCDAStatus.Text;

            int assignOverDueDays = 0;
            DateTime assignOverDueDate = default(DateTime);
            if (Int32.TryParse(this.tbAssignOverDueDays.Text, out assignOverDueDays))
            {
                if (assignOverDueDays != 0)
                {
                    assignOverDueDate = DateTime.Now.Date.AddDays(0 - assignOverDueDays);
                }
            }
            int FinanceOverDueDays = 0;
            DateTime FinanceOverDueDate = default(DateTime);
            if (Int32.TryParse(this.tbFinanceOverDueDays.Text, out FinanceOverDueDays))
            {
                FinanceOverDueDate = DateTime.Now.Date.AddDays(0 - FinanceOverDueDays);
            }

            var queryResult = from invoice in App.Current.DbContext.Invoices
                              let curCase = invoice.InvoiceAssignBatch.CDA.Case
                              where curCase.CaseMark == caseMark
                              let cda = invoice.InvoiceAssignBatch.CDA
                              where cda.CDAStatus == cdaStatus
                              let seller = curCase.SellerClient
                              where seller.ClientNameCN.Contains(sellerName) || seller.ClientNameEN.Contains(sellerName) 
                              let buyer = curCase.BuyerClient
                              where buyer.ClientNameCN.Contains(buyerName) || buyer.ClientNameEN.Contains(buyerName)
                              let sellerFactor = curCase.SellerFactor
                              where sellerFactor.CompanyNameCN.Contains(factorName) || sellerFactor.CompanyNameEN.Contains(factorName)
                              let buyerFactor = curCase.BuyerFactor
                              where buyerFactor.CompanyNameCN.Contains(factorName) || buyerFactor.CompanyNameEN.Contains(factorName)
                              where (invoiceNo == string.Empty ? true : invoice.InvoiceNo == invoiceNo)
                                && (isFlaw == "A" ? true : invoice.IsFlaw == (isFlaw == "Y" ? true : false))
                                && (isDispute == "A" ? true : invoice.IsDispute == (isDispute == "Y" ? true : false))
                                && (assignOverDueDays == 0 ? true : (invoice.PaymentAmount < invoice.AssignAmount && invoice.DueDate <= assignOverDueDate))
                                && (FinanceOverDueDays == 0 ? true : (invoice.RefundAmount < invoice.FinanceAmount.GetValueOrDefault() && invoice.FinanceDueDate <= FinanceOverDueDate))
                              select invoice;
            //if (queryResult.Count() > 2000)
            //{
            //    DialogResult dr = MessageBox.Show("查询结果为" + queryResult.Count() + "，全部显示可能速度较慢，选择YES可以继续显示，选择NO可以重新查询。", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //    if (dr == DialogResult.Yes)
            //    {
            //        this.bs.DataSource = queryResult;
            //        this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            //        return;
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}
            this.bs.DataSource = queryResult;
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
            this.tbAssignOverDueDays.Text = string.Empty;
            this.tbFinanceOverDueDays.Text = string.Empty;

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

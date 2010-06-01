
namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections.Generic;
    using System.Data.Linq;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceMgr : UserControl
    {
        #region?Fields?(2)?

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;
        /// <summary>
        /// 
        /// </summary>
        private OpInvoiceType opInvoiceType;

        #endregion?Fields?

        #region?Enums?(1)?

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

            /// <summary>
            /// 
            /// </summary>
            OVER_DUE,

            /// <summary>
            /// 
            /// </summary>
            ASSIGN_DUE,

            /// <summary>
            /// 
            /// </summary>
            FINANCE_DUE,

            /// <summary>
            /// 
            /// </summary>
            ASSIGN_DUE_BYDAY,

            /// <summary>
            /// 
            /// </summary>
            FINANCE_DUE_BYDAY,
        }

        #endregion?Enums?

        #region?Constructors?(3)?

        public InvoiceMgr(OpInvoiceType opInvoiceType, int days)
            : this(opInvoiceType)
        {
            this.colAssignOverDueDays.Visible = true;
            this.colFinanceOverDueDays.Visible = true;

            if (opInvoiceType == OpInvoiceType.ASSIGN_DUE_BYDAY)
            {
                this.tbAssignOverDueDays.Text = days.ToString();
            }
            else if (opInvoiceType == OpInvoiceType.FINANCE_DUE_BYDAY)
            {
                this.tbFinanceOverDueDays.Text = days.ToString();
            }

            context = new DBDataContext();

            var queryResult = from invoice in context.Invoices
                              where
                                 (tbAssignOverDueDays.Text == string.Empty ? true : (invoice.PaymentAmount.GetValueOrDefault() - invoice.AssignAmount < -TypeUtil.PRECISION && invoice.DueDate <= DateTime.Now.Date.AddDays(0 - days) && invoice.DueDate >= DateTime.Now.Date))
                                && (tbFinanceOverDueDays.Text == string.Empty ? true : (invoice.RefundAmount.GetValueOrDefault() - invoice.FinanceAmount.GetValueOrDefault() < -TypeUtil.PRECISION && invoice.FinanceDueDate <= DateTime.Now.Date.AddDays(0 - days) && invoice.FinanceDueDate >= DateTime.Now.Date))
                              select invoice;

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        public InvoiceMgr(IEnumerable<Invoice> invoiceList, DBDataContext context)
            : this(OpInvoiceType.BATCH_DETAIL)
        {
            this.bs.DataSource = invoiceList;
            this.lblCount.Text = String.Format("获得{0}条记录", invoiceList.Count());
            this.panelQuery.Visible = false;

            this.context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opInvoiceType"></param>
        public InvoiceMgr(OpInvoiceType opInvoiceType)
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.bs = new BindingSource();
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.DataSource = bs;
            this.opInvoiceType = opInvoiceType;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);
            ControlUtil.AddEnterListenersForQuery(this.panelQuery.Controls, this.btnQuery);

            this.cbTransactionType.Items.Insert(0, "全部");
            this.cbTransactionType.Text = "全部";
            this.cbCaseMark.Text = "启动案";

            List<Location> allLocations = DB.dbml.Location.AllLocations;
            allLocations.Insert(0, new Location() { LocationCode = "00", LocationName = "全部" });
            this.cbLocation.DataSource = allLocations;
            this.cbLocation.DisplayMember = "LocationName";
            this.cbLocation.ValueMember = "LocationCode";
            this.cbLocation.SelectedIndex = 0;

            this.UpdateContextMenu();

            if (opInvoiceType == OpInvoiceType.FLAW_RESOLVE)
            {
                this.cbIsFlaw.CheckValue = "Y";
                this.QueryInvoices(null, null);
            }
            else if (opInvoiceType == OpInvoiceType.DISPUTE_RESOLVE)
            {
                this.cbIsDispute.CheckValue = "Y";
                this.QueryInvoices(null, null);
            }
            else if (opInvoiceType == OpInvoiceType.OVER_DUE)
            {
                this.colAssignOverDueDays.Visible = true;
                this.colFinanceOverDueDays.Visible = true;

                this.tbAssignOverDueDays.Text = "1";
                this.tbFinanceOverDueDays.Text = "1";
                //    this.QueryInvoices(null, null);
            }
            else if (opInvoiceType == OpInvoiceType.ASSIGN_DUE)
            {
                this.colAssignOverDueDays.Visible = true;
                this.colFinanceOverDueDays.Visible = true;

                this.tbAssignOverDueDays.Text = "1";
                this.QueryInvoices(null, null);
            }
            else if (opInvoiceType == OpInvoiceType.FINANCE_DUE)
            {
                this.colAssignOverDueDays.Visible = true;
                this.colFinanceOverDueDays.Visible = true;

                this.tbFinanceOverDueDays.Text = "1";
                this.QueryInvoices(null, null);
            }

        }

        #endregion?Constructors?

        #region?Properties?(3)?

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets selected Invoice
        /// </summary>
        public Invoice Selected
        {
            get;
            set;
        }

        #endregion?Properties?

        #region?Methods?(19)?

        //?Private?Methods?(19)?

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
        private void ComputeCommission(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_UPDATE))
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

                foreach (Invoice invoice in selectedInvoices)
                {
                    invoice.CaculateCommission(true);
                }

                try
                {
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteInvoice(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

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

            if (MessageBoxEx.Show("是否打算删除此" + selectedInvoices.Count + "条发票", MESSAGE.TITLE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    foreach (Invoice invoice in selectedInvoices)
                    {
                        if (invoice.InvoiceAssignBatch.CheckStatus == BATCH.CHECK)
                        {
                            MessageBoxEx.Show("转让批次已复核，不能删除，发票号：" + invoice.InvoiceNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        foreach (InvoiceFinanceBatch batch in invoice.InvoiceFinanceBatches)
                        {
                            if (batch.CheckStatus == BATCH.CHECK)
                            {
                                MessageBoxEx.Show("融资批次已复核，不能删除，发票号：" + invoice.InvoiceNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }

                        foreach (InvoicePaymentBatch batch in invoice.InvoicePaymentBatches)
                        {
                            if (batch.CheckStatus == BATCH.CHECK)
                            {
                                MessageBoxEx.Show("付款批次已复核，不能删除，发票号：" + invoice.InvoiceNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }

                        foreach (InvoiceRefundBatch batch in invoice.InvoiceRefundBatches)
                        {
                            if (batch.CheckStatus == BATCH.CHECK)
                            {
                                MessageBoxEx.Show("还款批次已复核，不能删除，发票号：" + invoice.InvoiceNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }

                        foreach (InvoiceFinanceLog financeLog in invoice.InvoiceFinanceLogs)
                        {
                            context.InvoiceRefundLogs.DeleteAllOnSubmit(financeLog.InvoiceRefundLogs);
                        }

                        context.InvoicePaymentLogs.DeleteAllOnSubmit(invoice.InvoicePaymentLogs);
                        context.InvoiceFinanceLogs.DeleteAllOnSubmit(invoice.InvoiceFinanceLogs);
                        context.Invoices.DeleteOnSubmit(invoice);
                    }

                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                rowIndexes.Sort();
                rowIndexes.Reverse();
                foreach (int rowIndex in rowIndexes)
                {
                    this.dgvInvoices.Rows.RemoveAt(rowIndex);
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
            CaseDetail caseDetail = new CaseDetail(selectedInvoice.InvoiceAssignBatch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
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
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvInvoices.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvInvoices.RowHeadersDefaultCellStyle.Font, rectangle, dgvInvoices.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportAllInvoiceOverDue(object sender, EventArgs e)
        {
            if (this.dgvInvoices.Rows.Count == 0)
            {
                return;
            }

            ExportForm exportForm = new ExportForm(ExportForm.ExportType.EXPORT_INVOICES_OVERDUE, this.bs.List);
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportAllInvoicesFull(object sender, EventArgs e)
        {
            if (this.dgvInvoices.Rows.Count == 0)
            {
                return;
            }

            ExportForm exportForm = new ExportForm(ExportForm.ExportType.EXPORT_INVOICES_FULL, this.bs.List);
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportSelectedInvoicesFull(object sender, EventArgs e)
        {
            if (this.dgvInvoices.SelectedCells.Count == 0)
            {
                return;
            }

            ExportForm exportForm = new ExportForm(ExportForm.ExportType.EXPORT_INVOICES_FULL, GetSelectedInvoices());
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportSelectedInvoicesOverDue(object sender, EventArgs e)
        {
            if (this.dgvInvoices.SelectedCells.Count == 0)
            {
                return;
            }

            ExportForm exportForm = new ExportForm(ExportForm.ExportType.EXPORT_INVOICES_OVERDUE, GetSelectedInvoices());
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Invoice> GetSelectedInvoices()
        {
            List<Invoice> selectedInvoices = new List<Invoice>();
            foreach (DataGridViewCell cell in this.dgvInvoices.SelectedCells)
            {
                Invoice invoice = (Invoice)this.bs.List[cell.RowIndex];
                if (!selectedInvoices.Contains(invoice))
                {
                    selectedInvoices.Add(invoice);
                }
            }

            return selectedInvoices;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceDispute(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

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
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

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
            DateTime beginDate = String.IsNullOrEmpty(this.dateFrom.Text) ? this.dateFrom.MinDate : this.dateFrom.Value.Date;
            DateTime endDate = String.IsNullOrEmpty(this.dateTo.Text) ? this.dateTo.MinDate : this.dateTo.Value.Date;
            string clientName = this.tbClientName.Text;
            string factorName = this.tbFactor.Text;
            string invoiceNo = this.tbInvoiceNo.Text;
            string isFlaw = this.cbIsFlaw.CheckValue as string;
            string isDispute = this.cbIsDispute.CheckValue as string;
            string caseMark = this.cbCaseMark.Text;
            string location = (string)this.cbLocation.SelectedValue;
            string transactionType = this.cbTransactionType.Text;
            string caseCode = this.tbCaseCode.Text;
            string assignBatchNo = this.tbAssignBatchNo.Text;

            int assignOverDueDays = 0;
            DateTime assignOverDueDate = DateTime.Now.Date;
            if (Int32.TryParse(this.tbAssignOverDueDays.Text, out assignOverDueDays))
            {
                if (assignOverDueDays != 0)
                {
                    assignOverDueDate = DateTime.Now.Date.AddDays(0 - assignOverDueDays);
                }
            }

            int financeOverDueDays = 0;
            DateTime financeOverDueDate = DateTime.Now.Date;
            if (Int32.TryParse(this.tbFinanceOverDueDays.Text, out financeOverDueDays))
            {
                if (financeOverDueDays != 0)
                {
                    financeOverDueDate = DateTime.Now.Date.AddDays(0 - financeOverDueDays);
                }
            }

            double assignOustanding = 0;
            bool needAssignOutstanding = Double.TryParse(this.tbAssignOutstanding.Text, out assignOustanding);

            double financeOutstanding = 0;
            bool needFinanceOutstanding = Double.TryParse(this.tbFinanceOutstanding.Text, out financeOutstanding);


            context = new DBDataContext();

            var queryResult = from invoice in context.Invoices
                              let assignBatch = invoice.InvoiceAssignBatch
                              where
                                   (beginDate != this.dateFrom.MinDate ? assignBatch.AssignDate >= beginDate : true)
                                && (endDate != this.dateTo.MinDate ? assignBatch.AssignDate <= endDate : true)
                              let curCase = invoice.InvoiceAssignBatch.Case
                              where curCase.CaseMark == caseMark
                                    && (transactionType == "全部" ? true : curCase.TransactionType == transactionType)
                                    && (location == "00" ? true : curCase.OwnerDepartment.LocationCode == location)
                                    && curCase.CaseCode.Contains(caseCode)
                              let seller = curCase.SellerClient
                              let buyer = curCase.BuyerClient
                              where seller.ClientNameCN.Contains(clientName) || seller.ClientNameEN.Contains(clientName) || buyer.ClientNameCN.Contains(clientName) || buyer.ClientNameEN.Contains(clientName)
                              let sellerFactor = curCase.SellerFactor
                              let buyerFactor = curCase.BuyerFactor
                              where sellerFactor.CompanyNameCN.Contains(factorName) || sellerFactor.CompanyNameEN.Contains(factorName) || buyerFactor.CompanyNameCN.Contains(factorName) || buyerFactor.CompanyNameEN.Contains(factorName)
                              where (invoiceNo == string.Empty ? true : invoice.InvoiceNo.Contains(invoiceNo))
                                && (assignBatchNo == string.Empty ? true : invoice.AssignBatchNo.Contains(assignBatchNo))
                                && (isFlaw == "A" ? true : invoice.IsFlaw == (isFlaw == "Y" ? true : false))
                                && (isDispute == "A" ? true : invoice.IsDispute == (isDispute == "Y" ? true : false))
                                && (tbAssignOverDueDays.Text == string.Empty ? true : (invoice.PaymentAmount.GetValueOrDefault() - invoice.AssignAmount < -TypeUtil.PRECISION && invoice.DueDate <= assignOverDueDate))
                                && (tbFinanceOverDueDays.Text == string.Empty ? true : (invoice.RefundAmount.GetValueOrDefault() - invoice.FinanceAmount.GetValueOrDefault() < -TypeUtil.PRECISION && invoice.FinanceDueDate <= financeOverDueDate))
                                && (needAssignOutstanding ? invoice.PaymentAmount.GetValueOrDefault() - invoice.AssignAmount + assignOustanding < -TypeUtil.PRECISION : true)
                                && (needFinanceOutstanding ? invoice.RefundAmount.GetValueOrDefault() - invoice.FinanceAmount.GetValueOrDefault() + financeOutstanding < -TypeUtil.PRECISION : true)
                              orderby invoice.InvoiceAssignBatch.AssignDate
                              select invoice;

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
            this.tbClientName.Text = string.Empty;
            this.tbFactor.Text = string.Empty;
            this.tbInvoiceNo.Text = string.Empty;
            this.tbAssignOverDueDays.Text = string.Empty;
            this.tbFinanceOverDueDays.Text = string.Empty;
            this.tbAssignBatchNo.Text = string.Empty;
            this.tbAssignOutstanding.Text = string.Empty;
            this.tbCaseCode.Text = string.Empty;
            this.tbFinanceOutstanding.Text = string.Empty;

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

        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permissions.INVOICE_UPDATE))
            {
                this.menuItemInvoiceDelete.Enabled = true;
                this.menuItemInvoiceDispute.Enabled = true;
                this.menuItemInvoiceFlaw.Enabled = true;
            }
            else
            {
                this.menuItemInvoiceDelete.Enabled = false;
                this.menuItemInvoiceDispute.Enabled = false;
                this.menuItemInvoiceFlaw.Enabled = false;
            }
        }

        #endregion?Methods?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaculateAmount(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_UPDATE))
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

                foreach (Invoice invoice in selectedInvoices)
                {
                    invoice.CaculatePayment();
                    invoice.CaculateRefund();
                    invoice.CaculateFinance();
                }

                try
                {
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.CaseMgr;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceMgr : UserControl
    {
        #region OpInvoiceType enum

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

            /// <summary>
            /// 
            /// </summary>
            DUPLICATE_INVOICE,
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;

        /// <summary>
        /// 
        /// </summary>
        private readonly OpInvoiceType _opInvoiceType;


        public InvoiceMgr(OpInvoiceType opInvoiceType, int days)
            : this(opInvoiceType)
        {
            colAssignOverDueDays.Visible = true;
            colFinanceOverDueDays.Visible = true;

            if (opInvoiceType == OpInvoiceType.ASSIGN_DUE_BYDAY)
            {
                tbAssignOverDueDays.Text = days.ToString();
            }
            else if (opInvoiceType == OpInvoiceType.FINANCE_DUE_BYDAY)
            {
                tbFinanceOverDueDays.Text = days.ToString();
            }

            Context = new DBDataContext();

            IQueryable<Invoice> queryResult = from invoice in Context.Invoices
                                              where
                                                  (String.IsNullOrEmpty(tbAssignOverDueDays.Text)
                                                       ? true
                                                       : (invoice.PaymentAmount.GetValueOrDefault() -
                                                          invoice.AssignAmount < -TypeUtil.PRECISION &&
                                                          invoice.DueDate <= DateTime.Now.Date.AddDays(0 - days) &&
                                                          invoice.DueDate >= DateTime.Now.Date))
                                                  &&
                                                  (String.IsNullOrEmpty(tbFinanceOverDueDays.Text)
                                                       ? true
                                                       : (invoice.RefundAmount.GetValueOrDefault() -
                                                          invoice.FinanceAmount.GetValueOrDefault() <
                                                          -TypeUtil.PRECISION &&
                                                          invoice.FinanceDueDate <= DateTime.Now.Date.AddDays(0 - days) &&
                                                          invoice.FinanceDueDate >= DateTime.Now.Date))
                                              select invoice;

            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        /// <param name="context"></param>
        public InvoiceMgr(IEnumerable<Invoice> invoiceList, DBDataContext context)
            : this(OpInvoiceType.BATCH_DETAIL)
        {
            _bs.DataSource = invoiceList;
            lblCount.Text = String.Format("获得{0}条记录", invoiceList.Count());
            panelQuery.Visible = false;

            Context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opInvoiceType"></param>
        public InvoiceMgr(OpInvoiceType opInvoiceType)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _bs = new BindingSource();
            dgvInvoices.AutoGenerateColumns = false;
            dgvInvoices.DataSource = _bs;
            _opInvoiceType = opInvoiceType;
            ControlUtil.SetDoubleBuffered(dgvInvoices);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);

            cbTransactionType.Items.Insert(0, "全部");
            cbTransactionType.Text = @"全部";
            cbCaseMark.Text = @"启动案";

            List<Location> allLocations = DB.dbml.Location.AllLocations;
            allLocations.Insert(0, new Location { LocationCode = "00", LocationName = "全部" });
            cbLocation.DataSource = allLocations;
            cbLocation.DisplayMember = "LocationName";
            cbLocation.ValueMember = "LocationCode";
            cbLocation.SelectedIndex = 0;

            UpdateContextMenu();

            if (opInvoiceType == OpInvoiceType.FLAW_RESOLVE)
            {
                cbIsFlaw.CheckValue = "Y";
                QueryInvoices(null, null);
            }
            else if (opInvoiceType == OpInvoiceType.DISPUTE_RESOLVE)
            {
                cbIsDispute.CheckValue = "Y";
                QueryInvoices(null, null);
            }
            else if (opInvoiceType == OpInvoiceType.OVER_DUE)
            {
                colAssignOverDueDays.Visible = true;
                colFinanceOverDueDays.Visible = true;

                tbAssignOverDueDays.Text = @"1";
                tbFinanceOverDueDays.Text = @"1";
                //    this.QueryInvoices(null, null);
            }
            else if (opInvoiceType == OpInvoiceType.ASSIGN_DUE)
            {
                colAssignOverDueDays.Visible = true;
                colFinanceOverDueDays.Visible = true;

                tbAssignOverDueDays.Text = @"1";
                QueryInvoices(null, null);
            }
            else if (opInvoiceType == OpInvoiceType.FINANCE_DUE)
            {
                colAssignOverDueDays.Visible = true;
                colFinanceOverDueDays.Visible = true;

                tbFinanceOverDueDays.Text = @"1";
                QueryInvoices(null, null);
            }
            else if (opInvoiceType == OpInvoiceType.DUPLICATE_INVOICE)
            {
                cbIsDuplicate.CheckValue = "Y";
                QueryInvoices(null, null);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private DBDataContext Context { get; set; }

        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm { get; set; }

        /// <summary>
        /// Gets or sets selected Invoice
        /// </summary>
        public Invoice Selected { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaculateAmount(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_UPDATE))
            {
                if (dgvInvoices.CurrentCell == null)
                {
                    return;
                }

                var selectedInvoices = new List<Invoice>();
                foreach (DataGridViewCell cell in dgvInvoices.SelectedCells)
                {
                    var invoice = (Invoice)_bs.List[cell.RowIndex];
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
                    Context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

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
                if (dgvInvoices.CurrentCell == null)
                {
                    return;
                }

                var selectedInvoices = new List<Invoice>();
                foreach (DataGridViewCell cell in dgvInvoices.SelectedCells)
                {
                    var invoice = (Invoice)_bs.List[cell.RowIndex];
                    if (!selectedInvoices.Contains(invoice))
                    {
                        selectedInvoices.Add(invoice);
                    }
                }

                try
                {
                    foreach (Invoice invoice in selectedInvoices)
                    {
                        invoice.CaculateCommission(true);
                    }

                    Context.SubmitChanges();
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

            if (dgvInvoices.SelectedCells.Count == 0)
            {
                return;
            }

            var selectedInvoices = new List<Invoice>();
            var rowIndexes = new List<int>();
            foreach (DataGridViewCell cell in dgvInvoices.SelectedCells)
            {
                var invoice = (Invoice)_bs.List[cell.RowIndex];
                if (!selectedInvoices.Contains(invoice))
                {
                    rowIndexes.Add(cell.RowIndex);
                    selectedInvoices.Add(invoice);
                }
            }

            if (
                MessageBoxEx.Show("是否打算删除此" + selectedInvoices.Count + "条发票", MESSAGE.TITLE_WARNING,
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    foreach (Invoice invoice in selectedInvoices)
                    {
                        //if (invoice.InvoiceAssignBatch.CheckStatus == BATCH.CHECK)
                        //{
                        //    MessageBoxEx.Show("转让批次已复核，不能删除，发票号：" + invoice.InvoiceNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    return;
                        //}

                        //foreach (InvoiceFinanceBatch batch in invoice.InvoiceFinanceBatches)
                        //{
                        //    if (batch.CheckStatus == BATCH.CHECK)
                        //    {
                        //        MessageBoxEx.Show("融资批次已复核，不能删除，发票号：" + invoice.InvoiceNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //        return;
                        //    }
                        //}

                        //foreach (InvoicePaymentBatch batch in invoice.InvoicePaymentBatches)
                        //{
                        //    if (batch.CheckStatus == BATCH.CHECK)
                        //    {
                        //        MessageBoxEx.Show("付款批次已复核，不能删除，发票号：" + invoice.InvoiceNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //        return;
                        //    }
                        //}

                        //foreach (InvoiceRefundBatch batch in invoice.InvoiceRefundBatches)
                        //{
                        //    if (batch.CheckStatus == BATCH.CHECK)
                        //    {
                        //        MessageBoxEx.Show("还款批次已复核，不能删除，发票号：" + invoice.InvoiceNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //        return;
                        //    }
                        //}

                        foreach (InvoiceFinanceLog financeLog in invoice.InvoiceFinanceLogs)
                        {
                            Context.InvoiceRefundLogs.DeleteAllOnSubmit(financeLog.InvoiceRefundLogs);
                        }

                        Context.InvoicePaymentLogs.DeleteAllOnSubmit(invoice.InvoicePaymentLogs);
                        Context.InvoiceFinanceLogs.DeleteAllOnSubmit(invoice.InvoiceFinanceLogs);
                        Context.Invoices.DeleteOnSubmit(invoice);
                    }

                    Context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
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
            if (dgvInvoices.CurrentCell == null)
            {
                return;
            }

            var selectedInvoice = (Invoice)_bs.List[dgvInvoices.CurrentCell.RowIndex];
            var caseDetail = new CaseDetail(selectedInvoice.InvoiceAssignBatch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailInvoice(object sender, EventArgs e)
        {
            if (dgvInvoices.CurrentCell == null)
            {
                return;
            }

            var selectedInvoice = (Invoice)_bs.List[dgvInvoices.CurrentCell.RowIndex];
            var invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
            invoiceDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = dgvInvoices.Columns[e.ColumnIndex];
            if (column == colIsFlaw || column == colIsDispute || column == colIsSendAssignMsg ||
                column == colIsSendPaymentMsg)
            {
                Object originalData = e.Value;
                if (originalData != null)
                {
                    var result = (bool)originalData;
                    e.Value = result ? "Y" : "N";
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < _bs.List.Count; i++)
            {
                var invoice = (Invoice)_bs.List[i];
                if (invoice.AssignOverDueDays >= 0)
                {
                    dgvInvoices["colDueDate", i].Style.BackColor = Color.Yellow;
                }
                if (invoice.FinanceOverDueDays >= 0)
                {
                    dgvInvoices["colFinanceDueDate", i].Style.BackColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                                          dgvInvoices.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvInvoices.RowHeadersDefaultCellStyle.Font,
                                  rectangle, dgvInvoices.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportAllInvoiceOverDue(object sender, EventArgs e)
        {
            if (dgvInvoices.Rows.Count == 0)
            {
                return;
            }

            var exportForm = new ExportForm(ExportForm.ExportType.EXPORT_INVOICES_OVERDUE, _bs.List);
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportAllInvoicesFull(object sender, EventArgs e)
        {
            if (dgvInvoices.Rows.Count == 0)
            {
                return;
            }

            var exportForm = new ExportForm(ExportForm.ExportType.EXPORT_INVOICES_FULL, _bs.List);
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportSelectedInvoicesFull(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedCells.Count == 0)
            {
                return;
            }

            var exportForm = new ExportForm(ExportForm.ExportType.EXPORT_INVOICES_FULL, GetSelectedInvoices());
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportSelectedInvoicesOverDue(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedCells.Count == 0)
            {
                return;
            }

            var exportForm = new ExportForm(ExportForm.ExportType.EXPORT_INVOICES_OVERDUE, GetSelectedInvoices());
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Invoice> GetSelectedInvoices()
        {
            var selectedInvoices = new List<Invoice>();
            foreach (DataGridViewCell cell in dgvInvoices.SelectedCells)
            {
                var invoice = (Invoice)_bs.List[cell.RowIndex];
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

            if (dgvInvoices.CurrentCell == null)
            {
                return;
            }

            var selectedInvoice = (Invoice)_bs.List[dgvInvoices.CurrentCell.RowIndex];
            var invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.DISPUTE);
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

            if (dgvInvoices.CurrentCell == null)
            {
                return;
            }

            var selectedInvoices = new List<Invoice>();
            foreach (DataGridViewCell cell in dgvInvoices.SelectedCells)
            {
                var invoice = (Invoice)_bs.List[cell.RowIndex];
                if (!selectedInvoices.Contains(invoice))
                {
                    selectedInvoices.Add(invoice);
                }
            }

            if (selectedInvoices.Count == 1)
            {
                var invoiceDetail = new InvoiceDetail(selectedInvoices[0], InvoiceDetail.OpInvoiceType.FLAW);
                invoiceDetail.ShowDialog(this);
            }
            else if (selectedInvoices.Count > 1)
            {
                var invoiceFlaw = new InvoiceFlaw(selectedInvoices);
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
            DateTime beginDate = String.IsNullOrEmpty(dateFrom.Text) ? dateFrom.MinDate : dateFrom.Value.Date;
            DateTime endDate = String.IsNullOrEmpty(dateTo.Text) ? dateTo.MinDate : dateTo.Value.Date;
            string clientName = tbClientName.Text;
            string factorName = tbFactor.Text;
            string invoiceNo = tbInvoiceNo.Text;
            var isFlaw = cbIsFlaw.CheckValue as string;
            var isDispute = cbIsDispute.CheckValue as string;
            var isDuplicate = cbIsDuplicate.CheckValue as string;
            string caseMark = cbCaseMark.Text;
            var location = (string)cbLocation.SelectedValue;
            string transactionType = cbTransactionType.Text;
            string caseCode = tbCaseCode.Text;
            string assignBatchNo = tbAssignBatchNo.Text;

            int assignOverDueDays;
            DateTime assignOverDueDate = DateTime.Now.Date;
            if (Int32.TryParse(tbAssignOverDueDays.Text, out assignOverDueDays))
            {
                if (assignOverDueDays != 0)
                {
                    assignOverDueDate = DateTime.Now.Date.AddDays(0 - assignOverDueDays);
                }
            }

            int financeOverDueDays;
            DateTime financeOverDueDate = DateTime.Now.Date;
            if (Int32.TryParse(tbFinanceOverDueDays.Text, out financeOverDueDays))
            {
                if (financeOverDueDays != 0)
                {
                    financeOverDueDate = DateTime.Now.Date.AddDays(0 - financeOverDueDays);
                }
            }

            double assignOustanding;
            bool needAssignOutstanding = Double.TryParse(tbAssignOutstanding.Text, out assignOustanding);

            double financeOutstanding;
            bool needFinanceOutstanding = Double.TryParse(tbFinanceOutstanding.Text, out financeOutstanding);


            Context = new DBDataContext();
            IQueryable<Invoice> queryResult = from invoice in Context.Invoices
                                              let assignBatch = invoice.InvoiceAssignBatch
                                              where
                                                  (beginDate != dateFrom.MinDate
                                                       ? assignBatch.AssignDate >= beginDate
                                                       : true)
                                                  &&
                                                  (endDate != dateTo.MinDate ? assignBatch.AssignDate <= endDate : true)
                                              let curCase = invoice.InvoiceAssignBatch.Case
                                              where curCase.CaseMark == caseMark
                                                    &&
                                                    (transactionType == "全部"
                                                         ? true
                                                         : curCase.TransactionType == transactionType)
                                                    &&
                                                    (location == "00"
                                                         ? true
                                                         : curCase.OwnerDepartment.LocationCode == location)
                                                    && curCase.CaseCode.Contains(caseCode)
                                              let seller = curCase.SellerClient
                                              let buyer = curCase.BuyerClient
                                              where
                                                  seller.ClientNameCN.Contains(clientName) ||
                                                  seller.ClientNameEN.Contains(clientName) ||
                                                  buyer.ClientNameCN.Contains(clientName) ||
                                                  buyer.ClientNameEN.Contains(clientName)
                                              let sellerFactor = curCase.SellerFactor
                                              let buyerFactor = curCase.BuyerFactor
                                              where
                                                  sellerFactor.CompanyNameCN.Contains(factorName) ||
                                                  sellerFactor.CompanyNameEN.Contains(factorName) ||
                                                  buyerFactor.CompanyNameCN.Contains(factorName) ||
                                                  buyerFactor.CompanyNameEN.Contains(factorName)
                                              where
                                                  (String.IsNullOrEmpty(invoiceNo)
                                                       ? true
                                                       : invoice.InvoiceNo.Contains(invoiceNo))
                                                  &&
                                                  (String.IsNullOrEmpty(assignBatchNo)
                                                       ? true
                                                       : invoice.AssignBatchNo.Contains(assignBatchNo))
                                                  &&
                                                  (isFlaw == "A"
                                                       ? true
                                                       : invoice.IsFlaw == (isFlaw == "Y" ? true : false))
                                                  &&
                                                  (isDispute == "A"
                                                       ? true
                                                       : invoice.IsDispute == (isDispute == "Y" ? true : false))
                                                  &&
                                                  (String.IsNullOrEmpty(tbAssignOverDueDays.Text)
                                                       ? true
                                                       : (invoice.PaymentAmount.GetValueOrDefault() -
                                                          invoice.AssignAmount < -TypeUtil.PRECISION &&
                                                          invoice.DueDate <= assignOverDueDate))
                                                  &&
                                                  (String.IsNullOrEmpty(tbFinanceOverDueDays.Text)
                                                       ? true
                                                       : (invoice.RefundAmount.GetValueOrDefault() -
                                                          invoice.FinanceAmount.GetValueOrDefault() <
                                                          -TypeUtil.PRECISION &&
                                                          invoice.FinanceDueDate <= financeOverDueDate))
                                                  &&
                                                  (needAssignOutstanding
                                                       ? invoice.PaymentAmount.GetValueOrDefault() -
                                                         invoice.AssignAmount + assignOustanding < -TypeUtil.PRECISION
                                                       : true)
                                                  &&
                                                  (needFinanceOutstanding
                                                       ? invoice.RefundAmount.GetValueOrDefault() -
                                                         invoice.FinanceAmount.GetValueOrDefault() + financeOutstanding <
                                                         -TypeUtil.PRECISION
                                                       : true)
                                              orderby invoice.InvoiceAssignBatch.AssignDate
                                              select invoice;

            if (isDuplicate == "Y")
            {
                var groupResult = from i in Context.Invoices group i by i.InvoiceNo into g where g.Count() > 1 select g.Key;
                queryResult = from invoice in queryResult where groupResult.Contains(invoice.InvoiceNo) orderby invoice.InvoiceNo select invoice;
            }

            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, EventArgs e)
        {
            tbClientName.Text = string.Empty;
            tbFactor.Text = string.Empty;
            tbInvoiceNo.Text = string.Empty;
            tbAssignOverDueDays.Text = string.Empty;
            tbFinanceOverDueDays.Text = string.Empty;
            tbAssignBatchNo.Text = string.Empty;
            tbAssignOutstanding.Text = string.Empty;
            tbCaseCode.Text = string.Empty;
            tbFinanceOutstanding.Text = string.Empty;

            switch (_opInvoiceType)
            {
                case OpInvoiceType.FLAW_RESOLVE:
                    break;
                case OpInvoiceType.INVOICE_QUERY:
                    cbIsFlaw.CheckValue = "A";
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permissions.INVOICE_UPDATE))
            {
                menuItemInvoiceDelete.Enabled = true;
                menuItemInvoiceDispute.Enabled = true;
                menuItemInvoiceFlaw.Enabled = true;
                menuItemCaculate.Enabled = true;
                menuItemCommission.Enabled = true;
            }
            else
            {
                menuItemInvoiceDelete.Enabled = false;
                menuItemInvoiceDispute.Enabled = false;
                menuItemInvoiceFlaw.Enabled = false;
                menuItemCaculate.Enabled = false;
                menuItemCommission.Enabled = false;
            }

            if (PermUtil.ValidatePermission(Permissions.INVOICE_REPORT))
            {
                menuItemExportAllInvoices.Enabled = true;
                menuItemExportSelectedInvoices.Enabled = true;
            }
            else
            {
                menuItemExportAllInvoices.Enabled = false;
                menuItemExportSelectedInvoices.Enabled = false;
            }
        }
    }
}
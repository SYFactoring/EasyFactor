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
    public partial class CreditNoteMgr : UserControl
    {
        #region OpCreditNoteType enum

        /// <summary>
        /// 
        /// </summary>
        public enum OpCreditNoteType
        {
            /// <summary>
            /// 
            /// </summary>
            CREDIT_NOTE_QUERY,

            /// <summary>
            /// 
            /// </summary>
            CREDIT_NOTE_DETAIL,
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;

        /// <summary>
        /// 
        /// </summary>
        private OpCreditNoteType _opCreditNoteType;


        public CreditNoteMgr(IEnumerable<CreditNote> creditNoteList, DBDataContext context)
            : this(OpCreditNoteType.CREDIT_NOTE_DETAIL)
        {
            _bs.DataSource = creditNoteList;
            lblCount.Text = String.Format("获得{0}条记录", creditNoteList.Count());
            panelQuery.Visible = false;

            Context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opCreditNoteType"></param>
        public CreditNoteMgr(OpCreditNoteType opCreditNoteType)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _bs = new BindingSource();
            dgvCreditNote.AutoGenerateColumns = false;
            dgvCreditNote.DataSource = _bs;
            _opCreditNoteType = opCreditNoteType;
            ControlUtil.SetDoubleBuffered(dgvCreditNote);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);

            cbTransactionType.Items.Insert(0, "全部");
            cbTransactionType.Text = @"全部";

            List<Location> allLocations = DB.dbml.Location.AllLocations;
            allLocations.Insert(0, new Location {LocationCode = "00", LocationName = "全部"});
            cbLocation.DataSource = allLocations;
            cbLocation.DisplayMember = "LocationName";
            cbLocation.ValueMember = "LocationCode";
            cbLocation.SelectedIndex = 0;

            UpdateContextMenu();
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
        /// Gets or sets selected CreditNote
        /// </summary>
        public CreditNote Selected { get; set; }


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
        private void DeleteCreditNote(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (dgvCreditNote.CurrentCell == null)
            {
                return;
            }

            var creditNote = (CreditNote) _bs.List[dgvCreditNote.CurrentCell.RowIndex];
            if (
                MessageBoxEx.Show("是否打算删除此贷项通知", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            foreach (InvoicePaymentLog log in creditNote.InvoicePaymentLogs)
            {
                //if (log.InvoicePaymentBatch.CheckStatus == BATCH.CHECK)
                //{
                //    MessageBoxEx.Show("付款批次已复核，不能删除，发票号：" + log.PaymentBatchNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                Invoice invoice = log.Invoice;
                log.Invoice = null;
                invoice.CaculatePayment();
                Context.InvoicePaymentLogs.DeleteOnSubmit(log);
                //log.InvoicePaymentBatch.CheckStatus = BATCH.UNCHECK;
            }

            Context.CreditNotes.DeleteOnSubmit(creditNote);

            try
            {
                Context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
            }

            dgvCreditNote.Rows.RemoveAt(dgvCreditNote.CurrentCell.RowIndex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            if (dgvCreditNote.CurrentCell == null)
            {
                return;
            }

            var selectedCreditNote = (CreditNote) _bs.List[dgvCreditNote.CurrentCell.RowIndex];
            var caseDetail = new CaseDetail(selectedCreditNote.InvoiceAssignBatch.Case,
                                            CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailInvoice(object sender, EventArgs e)
        {
            if (dgvCreditNote.CurrentCell == null)
            {
                return;
            }

            var selectedCreditNote = (CreditNote) _bs.List[dgvCreditNote.CurrentCell.RowIndex];
            foreach (InvoicePaymentLog log in selectedCreditNote.InvoicePaymentLogs)
            {
                var invoiceDetail = new InvoiceDetail(log.Invoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
                invoiceDetail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCreditNoteRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                                          dgvCreditNote.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvCreditNote.RowHeadersDefaultCellStyle.Font,
                                  rectangle, dgvCreditNote.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCreditNote(object sender, EventArgs e)
        {
            DateTime beginDate = String.IsNullOrEmpty(dateFrom.Text) ? dateFrom.MinDate : dateFrom.Value.Date;
            DateTime endDate = String.IsNullOrEmpty(dateTo.Text) ? dateTo.MinDate : dateTo.Value.Date;
            string clientName = tbClientName.Text;
            string transactionType = cbTransactionType.Text;
            var location = (string) cbLocation.SelectedValue;
            string caseCode = tbCaseCode.Text;
            string assignBatchNo = tbAssignBatchNo.Text;
            string invoiceNo = tbInvoiceNo.Text;
            string creditNoteNo = tbCreditNoteNo.Text;

            Context = new DBDataContext();

            IQueryable<CreditNote> queryResult = from creditNote in Context.CreditNotes
                                                 where creditNote.AssignBatchNo.Contains(assignBatchNo)
                                                       && creditNote.CreditNoteNo.Contains(creditNoteNo)
                                                       &&
                                                       (beginDate != dateFrom.MinDate
                                                            ? creditNote.CreditNoteDate >= beginDate
                                                            : true)
                                                       &&
                                                       (endDate != dateTo.MinDate
                                                            ? creditNote.CreditNoteDate <= endDate
                                                            : true)
                                                 let curCase = creditNote.InvoiceAssignBatch.Case
                                                 where
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
                                                 let paymentLogs = creditNote.InvoicePaymentLogs
                                                 from paymentLog in paymentLogs
                                                 let invoice = paymentLog.Invoice
                                                 where
                                                     (invoiceNo == string.Empty
                                                          ? true
                                                          : invoice.InvoiceNo.Contains(invoiceNo))
                                                 select creditNote;

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
            tbInvoiceNo.Text = string.Empty;
            tbCreditNoteNo.Text = string.Empty;
            tbCaseCode.Text = string.Empty;
            tbAssignBatchNo.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {
            menuItemCreditNoteDelete.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_UPDATE);
        }
    }
}
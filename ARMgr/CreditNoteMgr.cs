using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using CMBC.EasyFactor.CaseMgr;
using DevComponents.DotNetBar;
using CMBC.EasyFactor.Utils.ConstStr;

namespace CMBC.EasyFactor.ARMgr
{
    public partial class CreditNoteMgr : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;
        /// <summary>
        /// 
        /// </summary>
        private OpCreditNoteType opCreditNoteType;

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

        public CreditNoteMgr(IEnumerable<CreditNote> creditNoteList, DBDataContext context)
            : this(OpCreditNoteType.CREDIT_NOTE_DETAIL)
        {
            this.bs.DataSource = creditNoteList;
            this.lblCount.Text = String.Format("获得{0}条记录", creditNoteList.Count());
            this.panelQuery.Visible = false;

            this.context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opCreditNoteType"></param>
        public CreditNoteMgr(OpCreditNoteType opCreditNoteType)
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.bs = new BindingSource();
            this.dgvCreditNote.AutoGenerateColumns = false;
            this.dgvCreditNote.DataSource = bs;
            this.opCreditNoteType = opCreditNoteType;
            ControlUtil.SetDoubleBuffered(this.dgvCreditNote);
            ControlUtil.AddEnterListenersForQuery(this.panelQuery.Controls, this.btnQuery);

            this.cbTransactionType.Items.Insert(0, "全部");
            this.cbTransactionType.Text = "全部";

            List<Location> allLocations = DB.dbml.Location.AllLocations;
            allLocations.Insert(0, new Location() { LocationCode = "00", LocationName = "全部" });
            this.cbLocation.DataSource = allLocations;
            this.cbLocation.DisplayMember = "LocationName";
            this.cbLocation.ValueMember = "LocationCode";
            this.cbLocation.SelectedIndex = 0;

            this.UpdateContextMenu();
        }

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
        /// Gets or sets selected CreditNote
        /// </summary>
        public CreditNote Selected
        {
            get;
            set;
        }

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
        private void DetailInvoice(object sender, EventArgs e)
        {
            if (this.dgvCreditNote.CurrentCell == null)
            {
                return;
            }

            CreditNote selectedCreditNote = (CreditNote)this.bs.List[this.dgvCreditNote.CurrentCell.RowIndex];
            foreach (InvoicePaymentLog log in selectedCreditNote.InvoicePaymentLogs)
            {
                InvoiceDetail invoiceDetail = new InvoiceDetail(log.Invoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
                invoiceDetail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            if (this.dgvCreditNote.CurrentCell == null)
            {
                return;
            }

            CreditNote selectedCreditNote = (CreditNote)this.bs.List[this.dgvCreditNote.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedCreditNote.InvoiceAssignBatch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCreditNote_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvCreditNote.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvCreditNote.RowHeadersDefaultCellStyle.Font, rectangle, dgvCreditNote.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCreditNote(object sender, EventArgs e)
        {
            DateTime beginDate = String.IsNullOrEmpty(this.dateFrom.Text) ? this.dateFrom.MinDate : this.dateFrom.Value.Date;
            DateTime endDate = String.IsNullOrEmpty(this.dateTo.Text) ? this.dateTo.MinDate : this.dateTo.Value.Date;
            string clientName = this.tbClientName.Text;
            string transactionType = this.cbTransactionType.Text;
            string location = (string)this.cbLocation.SelectedValue;
            string caseCode = this.tbCaseCode.Text;
            string assignBatchNo = this.tbAssignBatchNo.Text;
            string invoiceNo = this.tbInvoiceNo.Text;
            string creditNoteNo = this.tbCreditNoteNo.Text;

            context = new DBDataContext();

            var queryResult = from creditNote in context.CreditNotes
                              where creditNote.AssignBatchNo.Contains(assignBatchNo)
                               && creditNote.CreditNoteNo.Contains(creditNoteNo)
                               && (beginDate != this.dateFrom.MinDate ? creditNote.CreditNoteDate >= beginDate : true)
                               && (endDate != this.dateTo.MinDate ? creditNote.CreditNoteDate <= endDate : true)
                              let curCase = creditNote.InvoiceAssignBatch.Case
                              where (transactionType == "全部" ? true : curCase.TransactionType == transactionType)
                                    && (location == "00" ? true : curCase.OwnerDepartment.LocationCode == location)
                                    && curCase.CaseCode.Contains(caseCode)
                              let seller = curCase.SellerClient
                              let buyer = curCase.BuyerClient
                              where seller.ClientNameCN.Contains(clientName) || seller.ClientNameEN.Contains(clientName) || buyer.ClientNameCN.Contains(clientName) || buyer.ClientNameEN.Contains(clientName)
                              let paymentLogs = creditNote.InvoicePaymentLogs
                              from paymentLog in paymentLogs
                              let invoice = paymentLog.Invoice
                              where (invoiceNo == string.Empty ? true : invoice.InvoiceNo.Contains(invoiceNo))
                              select creditNote;

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
            this.tbInvoiceNo.Text = string.Empty;
            this.tbCreditNoteNo.Text = string.Empty;
            this.tbCaseCode.Text = string.Empty;
            this.tbAssignBatchNo.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCreditNote(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(CMBC.EasyFactor.Utils.Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (this.dgvCreditNote.CurrentCell == null)
            {
                return;
            }

            CreditNote creditNote = (CreditNote)this.bs.List[this.dgvCreditNote.CurrentCell.RowIndex];
            if (MessageBoxEx.Show("是否打算删除此贷项通知", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            foreach (InvoicePaymentLog log in creditNote.InvoicePaymentLogs)
            {
                if (log.InvoicePaymentBatch.CheckStatus == BATCH.CHECK)
                {
                    MessageBoxEx.Show("付款批次已复核，不能删除，发票号：" + log.PaymentBatchNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Invoice invoice = log.Invoice;
                log.Invoice = null;
                invoice.CaculatePayment();
                context.InvoicePaymentLogs.DeleteOnSubmit(log);
                log.InvoicePaymentBatch.CheckStatus = BATCH.UNCHECK;
            }

            context.CreditNotes.DeleteOnSubmit(creditNote);

            try
            {
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.dgvCreditNote.Rows.RemoveAt(this.dgvCreditNote.CurrentCell.RowIndex);
        }
    }
}

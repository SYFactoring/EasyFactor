using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.Utils;
using CMBC.EasyFactor.DB.dbml;

namespace CMBC.EasyFactor.ARMgr
{
    public partial class PaymentBatchDetail : UserControl
    {
        private BindingSource bs;

        public PaymentBatchDetail(List<InvoicePaymentLog> logList)
        {
            InitializeComponent();
            this.bs = new BindingSource();
            this.dgvPaymentLogs.AutoGenerateColumns = false;
            this.dgvPaymentLogs.DataSource = bs;
            ControlUtil.SetDoubleBuffered(this.dgvPaymentLogs);

            bs.DataSource = logList;
            if (logList[0].CreditNote == null)
            {
                colCreditNoteDate.Visible = false;
                colCreditNoteNo.Visible = false;
            }
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
        /// Gets or sets selected AssignBatch
        /// </summary>
        public InvoicePaymentLog Selected
        {
            get;
            set;
        }

        private void DeleteLog(object sender, EventArgs e)
        {
            if (this.dgvPaymentLogs.SelectedRows.Count == 0)
            {
                return;
            }
            InvoicePaymentLog log = (InvoicePaymentLog)this.bs.List[this.dgvPaymentLogs.SelectedRows[0].Index];
            try
            {
                Invoice invoice = log.Invoice;
                invoice.InvoicePaymentLogs.Remove(log);
                invoice.CaculatePayment();
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBox.Show("删除失败," + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvPaymentLogs.Rows.RemoveAt(this.dgvPaymentLogs.SelectedRows[0].Index);
        }
    }
}

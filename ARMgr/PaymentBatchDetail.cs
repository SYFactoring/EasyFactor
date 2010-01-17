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
        #region Fields (1)

        private BindingSource bs;

        #endregion Fields

        #region Constructors (1)

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
        public InvoicePaymentLog Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (2)

        // Private Methods (2) 

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
                log.Invoice = null;
                invoice.CaculatePayment();
                App.Current.DbContext.InvoicePaymentLogs.DeleteOnSubmit(log);
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBox.Show("删除失败," + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvPaymentLogs.Rows.RemoveAt(this.dgvPaymentLogs.SelectedRows[0].Index);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPaymentLogs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                 e.RowBounds.Location.Y,
                     dgvPaymentLogs.RowHeadersWidth - 4,
                     e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvPaymentLogs.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvPaymentLogs.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        #endregion Methods
    }
}

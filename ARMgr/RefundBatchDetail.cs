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
    public partial class RefundBatchDetail : UserControl
    {
        #region Fields (1)

        private BindingSource bs;

        #endregion Fields

        #region Constructors (1)

        public RefundBatchDetail(List<InvoiceRefundLog> logList)
        {
            InitializeComponent();
            this.bs = new BindingSource();
            this.dgvRefundLogs.AutoGenerateColumns = false;
            this.dgvRefundLogs.DataSource = bs;
            ControlUtil.SetDoubleBuffered(this.dgvRefundLogs);

            bs.DataSource = logList;
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
        public InvoiceRefundLog Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (2)

        // Private Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteLog(object sender, EventArgs e)
        {
            if (this.dgvRefundLogs.SelectedRows.Count == 0)
            {
                return;
            }
            InvoiceRefundLog log = (InvoiceRefundLog)this.bs.List[this.dgvRefundLogs.SelectedRows[0].Index];
            try
            {
                Invoice invoice = log.Invoice;
                log.Invoice = null;
                invoice.CaculateRefund();
                App.Current.DbContext.InvoiceRefundLogs.DeleteOnSubmit(log);
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBox.Show("删除失败," + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvRefundLogs.Rows.RemoveAt(this.dgvRefundLogs.SelectedRows[0].Index);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRefundLogs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
            e.RowBounds.Location.Y,
            dgvRefundLogs.RowHeadersWidth - 4,
            e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvRefundLogs.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvRefundLogs.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        #endregion Methods
    }
}

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
        private BindingSource bs;

        public RefundBatchDetail(List<InvoiceRefundLog> logList)
        {
            InitializeComponent();
            this.bs = new BindingSource();
            this.dgvRefundLogs.AutoGenerateColumns = false;
            this.dgvRefundLogs.DataSource = bs;
            ControlUtil.SetDoubleBuffered(this.dgvRefundLogs);

            bs.DataSource = logList;
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
        public InvoiceRefundLog Selected
        {
            get;
            set;
        }

        private void DeleteLog(object sender, EventArgs e)
        {
            if (this.dgvRefundLogs.SelectedRows.Count == 0)
            {
                return;
            }
            InvoiceRefundLog log = (InvoiceRefundLog)this.bs.List[this.dgvRefundLogs.SelectedRows[0].Index];
            try
            {
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
    }
}

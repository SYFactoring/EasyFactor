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
    }
}

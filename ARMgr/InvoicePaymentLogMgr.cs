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
    public partial class InvoicePaymentLogMgr : UserControl
    {
        private BindingSource bs;

        public InvoicePaymentLogMgr(List<InvoicePaymentLog> logList)
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
    }
}

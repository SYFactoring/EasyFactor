using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;

namespace CMBC.EasyFactor.ARMgr
{
    public partial class AssignBatchMgr : UserControl
    {
        private BindingSource bs = new BindingSource();

        private CDA cda;

        public AssignBatchMgr()
        {
            InitializeComponent();
        }

        public AssignBatchMgr(CDA selectedCDA)
        {
            InitializeComponent();
            this.cda = selectedCDA;
            this.panelQuery.Visible = false;
            this.bs.DataSource = cda.InvoiceAssignBatches.Where(i => i.AssignBatchNo.Contains(this.tbAssignBatchNo.Text));
            this.dgvAssignBatch.DataSource = bs;
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
        public InvoiceAssignBatch Selected
        {
            get;
            set;
        }

        private void QueryAssignBatch(object sender, EventArgs e)
        {
            if (cda == null)
            {
                this.bs.DataSource = App.Current.DbContext.InvoiceAssignBatches.Where(i => i.AssignBatchNo.Contains(this.tbAssignBatchNo.Text));
            }
            else
            {
                this.bs.DataSource = cda.InvoiceAssignBatches.Where(i => i.AssignBatchNo.Contains(this.tbAssignBatchNo.Text));
            }
            this.dgvAssignBatch.DataSource = bs;
        }

        private void SelectAssignBatch(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvAssignBatch.SelectedRows.Count == 0)
            {
                return;
            }
            string ino = (string)dgvAssignBatch["AssignBatchNoColumn", dgvAssignBatch.SelectedRows[0].Index].Value;
            if (ino != null)
            {
                InvoiceAssignBatch selectedBatch = App.Current.DbContext.InvoiceAssignBatches.SingleOrDefault(i => i.AssignBatchNo == ino);
                if (selectedBatch != null)
                {
                    this.Selected = selectedBatch;
                    if (this.OwnerForm != null)
                    {
                        this.OwnerForm.DialogResult = DialogResult.Yes;
                        this.OwnerForm.Close();
                    }
                }
            }
        }
    }
}

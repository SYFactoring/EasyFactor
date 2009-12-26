//-----------------------------------------------------------------------
// <copyright file="AssignBatchMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;

    /// <summary>
    /// 
    /// </summary>
    public partial class AssignBatchMgr : UserControl
    {
		#region Fields (2) 

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs = new BindingSource();
        /// <summary>
        /// 
        /// </summary>
        private CDA cda;

		#endregion Fields 

		#region Constructors (2) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedCDA"></param>
        public AssignBatchMgr(CDA selectedCDA)
            : this()
        {
            if (selectedCDA != null)
            {
                this.cda = selectedCDA;
                this.panelQuery.Visible = false;
                this.bs.DataSource = cda.InvoiceAssignBatches.Where(i => i.AssignBatchNo.Contains(this.tbAssignBatchNo.Text));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public AssignBatchMgr()
        {
            InitializeComponent();
            this.dgvAssignBatch.AutoGenerateColumns = false;
            this.dgvAssignBatch.DataSource = bs;
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
        public InvoiceAssignBatch Selected
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAssignBatch(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvAssignBatch.SelectedRows.Count == 0)
            {
                return;
            }
            string ino = (string)dgvAssignBatch["colAssignBatchNo", dgvAssignBatch.SelectedRows[0].Index].Value;
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

		#endregion Methods 
    }
}

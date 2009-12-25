//-----------------------------------------------------------------------
// <copyright file="FinanceBatchMgr.cs" company="Yiming Liu@Fudan">
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
    public partial class FinanceBatchMgr : UserControl
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
        public FinanceBatchMgr(CDA selectedCDA)
            : this()
        {
            if (selectedCDA != null)
            {
                this.cda = selectedCDA;
                this.panelQuery.Visible = false;
                this.bs.DataSource = cda.InvoiceFinanceBatches.Where(i => i.FinanceBatchNo.Contains(this.tbFinanceBatchNo.Text));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public FinanceBatchMgr()
        {
            InitializeComponent();

            this.dgvFinanceBatch.DataSource = bs;
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
        /// Gets or sets selected FinanceBatch
        /// </summary>
        public InvoiceFinanceBatch Selected
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
        private void QueryFinanceBatch(object sender, EventArgs e)
        {
            if (cda == null)
            {
                this.bs.DataSource = App.Current.DbContext.InvoiceFinanceBatches.Where(i => i.FinanceBatchNo.Contains(this.tbFinanceBatchNo.Text));
            }
            else
            {
                this.bs.DataSource = cda.InvoiceFinanceBatches.Where(i => i.FinanceBatchNo.Contains(this.tbFinanceBatchNo.Text));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFinanceBatch(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvFinanceBatch.SelectedRows.Count == 0)
            {
                return;
            }
            string ino = (string)dgvFinanceBatch["FinanceBatchNoColumn", dgvFinanceBatch.SelectedRows[0].Index].Value;
            if (ino != null)
            {
                InvoiceFinanceBatch selectedBatch = App.Current.DbContext.InvoiceFinanceBatches.SingleOrDefault(i => i.FinanceBatchNo == ino);
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

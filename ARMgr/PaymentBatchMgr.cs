//-----------------------------------------------------------------------
// <copyright file="PaymentBatchMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    /// <summary>
    /// 
    /// </summary>
    public partial class PaymentBatchMgr : UserControl
    {
        #region Fields (3)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs = new BindingSource();
        /// <summary>
        /// 
        /// </summary>
        private CDA cda;
        /// <summary>
        /// 
        /// </summary>
        private OpBatchType opBatchType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpBatchType
        {
            /// <summary>
            /// 
            /// </summary>
            CHECK,

            /// <summary>
            /// 
            /// </summary>
            DETAIL,

            /// <summary>
            /// 
            /// </summary>
            QUERY
        }

        #endregion Enums

        #region Constructors (2)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedCDA"></param>
        public PaymentBatchMgr(CDA selectedCDA)
            : this(OpBatchType.DETAIL)
        {
            this.cda = selectedCDA;
            this.panelQuery.Visible = false;
            this.bs.DataSource = cda.InvoicePaymentBatches;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchType"></param>
        public PaymentBatchMgr(OpBatchType batchType)
        {
            InitializeComponent();
            ControlUtil.SetDoubleBuffered(this.dgvBatches);
            this.dgvBatches.AutoGenerateColumns = false;
            this.dgvBatches.DataSource = bs;
            this.opBatchType = batchType;
            if (batchType == OpBatchType.CHECK)
            {
                this.bs.DataSource = App.Current.DbContext.InvoicePaymentBatches.Where(i => i.CheckStatus == "未复核");
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
        /// Gets or sets selected PaymentBatch
        /// </summary>
        public InvoicePaymentBatch Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (6)

        // Private Methods (6) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }
            foreach (DataGridViewRow row in this.dgvBatches.SelectedRows)
            {
                InvoicePaymentBatch batch = (InvoicePaymentBatch)this.bs.List[row.Index];
                batch.CheckStatus = "已复核";
                batch.CheckUserName = App.Current.CurUser.Name;
                batch.CheckDate = DateTime.Now.Date;
            }
            App.Current.DbContext.SubmitChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailBatch(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }
            InvoicePaymentBatch selectedBatch = (InvoicePaymentBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            InvoiceMgr invoiceMgr = new InvoiceMgr(selectedBatch.Invoices.ToList());
            QueryForm queryUI = new QueryForm(invoiceMgr, "批次详情");
            invoiceMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBatches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.OwnerForm == null)
            {
                this.DetailBatch(sender, e);
            }
            else
            {
                this.SelectBatch(sender, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryBatch(object sender, EventArgs e)
        {
            if (opBatchType == OpBatchType.QUERY || opBatchType == OpBatchType.CHECK)
            {
                DateTime beginDate = this.dateFrom.Text != string.Empty ? this.dateFrom.Value : this.dateFrom.MinDate;
                DateTime endDate = this.dateTo.Text != string.Empty ? this.dateTo.Value : this.dateTo.MinDate;
                string status = this.cbCheckStatus.Text;

                this.bs.DataSource = App.Current.DbContext.InvoicePaymentBatches.Where(i =>
                    i.PaymentBatchNo.Contains(this.tbPaymentBatchNo.Text)
                    && (beginDate != this.dateFrom.MinDate ? i.PaymentDate >= beginDate : true)
                    && (endDate != this.dateTo.MinDate ? i.PaymentDate <= endDate : true)
                    && (status != string.Empty ? i.CheckStatus == status : true)
                    );
            }
            else if (opBatchType == OpBatchType.DETAIL)
            {
                this.bs.DataSource = cda.InvoicePaymentBatches.Where(i => i.PaymentBatchNo.Contains(this.tbPaymentBatchNo.Text));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reject(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }
            foreach (DataGridViewRow row in this.dgvBatches.SelectedRows)
            {
                InvoiceAssignBatch batch = (InvoiceAssignBatch)this.bs.List[row.Index];
                batch.CheckStatus = "复核未通过";
                batch.CheckUserName = App.Current.CurUser.Name;
                batch.CheckDate = DateTime.Now.Date;
            }
            App.Current.DbContext.SubmitChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBatch(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }
            InvoicePaymentBatch selectedBatch = (InvoicePaymentBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            this.Selected = selectedBatch;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
            }
        }

        #endregion Methods
    }
}

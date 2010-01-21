//-----------------------------------------------------------------------
// <copyright file="FinanceBatchDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using System;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;

    /// <summary>
    /// 
    /// </summary>
    public partial class FinanceBatchDetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (1)

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
            DETAIL_BATCH,

            /// <summary>
            /// 
            /// </summary>
            UPDATE_BATCH,
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        public FinanceBatchDetail(InvoiceFinanceBatch batch)
        {
            this.InitializeComponent();
            this.batchBindingSource.DataSource = batch;
            this.opBatchType = OpBatchType.DETAIL_BATCH;
            this.ImeMode = ImeMode.OnHalf;

            this.batchCurrencyComboBox.DataSource = Currency.AllCurrencies();
            this.batchCurrencyComboBox.DisplayMember = "CurrencyCode";
            this.batchCurrencyComboBox.ValueMember = "CurrencyCode";

            InvoiceMgr invoiceMgr = new InvoiceMgr(batch.Invoices);
            invoiceMgr.Dock = DockStyle.Fill;
            this.panelInvoices.Controls.Add(invoiceMgr);

            batch.Backup();

            this.UpdateBatchControlStatus();
        }

        #endregion Constructors

        #region Methods (6)

        // Private Methods (6) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BatchDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;
            batch.Restore();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCDA(object sender, EventArgs e)
        {
            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;
            CDADetail detail = new CDADetail(batch.CDA, CDADetail.OpCDAType.DETAIL_CDA);
            detail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBatch(object sender, EventArgs e)
        {
            if (!this.superValidator.Validate())
            {
                return;
            }

            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;

            bool isUpdateOK = true;
            try
            {
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e2)
            {
                isUpdateOK = false;
                MessageBox.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isUpdateOK)
            {
                MessageBox.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                batch.Backup();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFactor(object sender, EventArgs e)
        {
            InvoiceFinanceBatch financeBatch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;
            FactorMgr factorMgr = new FactorMgr(false);
            QueryForm queryForm = new QueryForm(factorMgr, "选择代付行");
            factorMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);

            Factor factor = factorMgr.Selected;
            if (factor != null)
            {
                financeBatch.Factor = factor;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBatch(object sender, EventArgs e)
        {
            this.opBatchType = OpBatchType.UPDATE_BATCH;
            this.UpdateBatchControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateBatchControlStatus()
        {
            if (this.opBatchType == OpBatchType.DETAIL_BATCH)
            {
                foreach (Control comp in this.panelBatch.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                this.btnFactorSelect.Visible = false;
            }
            else if (this.opBatchType == OpBatchType.UPDATE_BATCH)
            {
                foreach (Control comp in this.panelBatch.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                this.btnFactorSelect.Visible = true;
                this.cDACodeTextBox.ReadOnly = true;
                this.financeBatchNoTextBox.ReadOnly = true;
                this.factorCodeTextBox.ReadOnly = true;
                this.factorTextBox.ReadOnly = true;
            }
        }

        #endregion Methods
    }
}

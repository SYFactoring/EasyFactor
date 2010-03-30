//-----------------------------------------------------------------------
// <copyright file="FinanceBatchDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Windows.Forms;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.Utils;
    using System.Data.Linq;
    using System.Linq;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class FinanceBatchDetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (3)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;
        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;
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
        /// Initializes a new instance of the FinanceBatchDetail class
        /// </summary>
        /// <param name="batch"></param>
        public FinanceBatchDetail(InvoiceFinanceBatch batch)
        {
            this.InitializeComponent();
            this.bs = new BindingSource();
            this.dgvFinanceLogs.DataSource = this.bs;
            this.dgvFinanceLogs.AutoGenerateColumns = false;
            this.context = new DBDataContext();
            batch = context.InvoiceFinanceBatches.SingleOrDefault(i => i.FinanceBatchNo == batch.FinanceBatchNo);
            this.bs.DataSource = batch.InvoiceFinanceLogs;
            this.batchBindingSource.DataSource = batch;
            this.opBatchType = OpBatchType.DETAIL_BATCH;
            this.ImeMode = ImeMode.OnHalf;

            this.batchCurrencyComboBox.DataSource = Currency.AllCurrencies();
            this.batchCurrencyComboBox.DisplayMember = "CurrencyCode";
            this.batchCurrencyComboBox.ValueMember = "CurrencyCode";

            this.financeRateTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.financeRateTextBox.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

            this.costRateTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.costRateTextBox.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

            this.UpdateBatchControlStatus();
        }

        #endregion Constructors

        #region Methods (7)

        // Private Methods (7) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteLog(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            if (this.dgvFinanceLogs.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceFinanceLog log = (InvoiceFinanceLog)this.bs.List[this.dgvFinanceLogs.SelectedRows[0].Index];
            if (log.InvoiceRefundLogs.Count > 0)
            {
                DialogResult dr = MessageBoxEx.Show("此笔融资已还款，是否确认删除此笔融资以及关联还款记录", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }

            try
            {
                Invoice invoice = log.Invoice;
                log.Invoice = null;
                foreach (InvoiceRefundLog refundLog in log.InvoiceRefundLogs)
                {
                    refundLog.InvoiceFinanceLog = null;
                }

                context.InvoiceRefundLogs.DeleteAllOnSubmit(log.InvoiceRefundLogs);
                invoice.CaculateRefund();
                invoice.CaculateFinance();
                context.InvoiceFinanceLogs.DeleteOnSubmit(log);
                log.InvoiceFinanceBatch.CheckStatus = "未复核";
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.dgvFinanceLogs.Rows.RemoveAt(this.dgvFinanceLogs.SelectedRows[0].Index);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;
            CaseDetail detail = new CaseDetail(batch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            detail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailInvoice(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvFinanceLogs.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceFinanceLog log = (InvoiceFinanceLog)this.bs.List[this.dgvFinanceLogs.SelectedRows[0].Index];
            InvoiceDetail detail = new InvoiceDetail(log.Invoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
            detail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            if (!this.superValidator.Validate())
            {
                return;
            }

            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;

            bool isUpdateOK = true;
            try
            {
                context.SubmitChanges(ConflictMode.ContinueOnConflict);
            }
            catch (ChangeConflictException)
            {
                foreach (ObjectChangeConflict cc in context.ChangeConflicts)
                {
                    foreach (MemberChangeConflict mc in cc.MemberConflicts)
                    {
                        mc.Resolve(RefreshMode.KeepChanges);
                    }
                }

                context.SubmitChanges();
            }
            catch (Exception e2)
            {
                isUpdateOK = false;
                MessageBoxEx.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isUpdateOK)
            {
                MessageBoxEx.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFactor(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            InvoiceFinanceBatch financeBatch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;
            FactorMgr factorMgr = new FactorMgr();
            QueryForm queryForm = new QueryForm(factorMgr, "选择代付行");
            factorMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);

            Factor factor = factorMgr.Selected;
            if (factor != null)
            {
                financeBatch.Factor = context.Factors.SingleOrDefault(f => f.FactorCode == factor.FactorCode);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

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
                this.caseCodeTextBox.ReadOnly = true;
                this.financeBatchNoTextBox.ReadOnly = true;
                this.factorCodeTextBox.ReadOnly = true;
                this.factorTextBox.ReadOnly = true;
            }

            ControlUtil.SetComponetEditable(this.createUserNameTextBox, false);
        }

        #endregion Methods
    }
}

//-----------------------------------------------------------------------
// <copyright file="FinanceBatchDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.CaseMgr;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.InfoMgr.ClientMgr;
using CMBC.EasyFactor.InfoMgr.FactorMgr;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FinanceBatchDetail : Office2007Form
    {
        #region OpBatchType enum

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

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;

        /// <summary>
        /// 
        /// </summary>
        private OpBatchType _opBatchType;


        /// <summary>
        /// Initializes a new instance of the FinanceBatchDetail class
        /// </summary>
        /// <param name="batch"></param>
        public FinanceBatchDetail(InvoiceFinanceBatch batch)
        {
            InitializeComponent();
            _bs = new BindingSource();
            dgvFinanceLogs.DataSource = _bs;
            dgvFinanceLogs.AutoGenerateColumns = false;
            _context = new DBDataContext();
            batch = _context.InvoiceFinanceBatches.SingleOrDefault(i => i.FinanceBatchNo == batch.FinanceBatchNo);
            _bs.DataSource = batch.InvoiceFinanceLogs;
            batchBindingSource.DataSource = batch;
            _opBatchType = OpBatchType.DETAIL_BATCH;
            ImeMode = ImeMode.OnHalf;

            batchCurrencyComboBox.DataSource = Currency.AllCurrencies;
            batchCurrencyComboBox.DisplayMember = "CurrencyCode";
            batchCurrencyComboBox.ValueMember = "CurrencyCode";

            financeRateTextBox.DataBindings[0].Format += TypeUtil.FormatFloatToPercent;
            financeRateTextBox.DataBindings[0].Parse += TypeUtil.ParsePercentToFloat;

            costRateTextBox.DataBindings[0].Format += TypeUtil.FormatFloatToPercent;
            costRateTextBox.DataBindings[0].Parse += TypeUtil.ParsePercentToFloat;

            UpdateBatchControlStatus();
        }


        //?Private?Methods?(8)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteLog(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (dgvFinanceLogs.SelectedRows.Count == 0)
            {
                return;
            }

            var log = (InvoiceFinanceLog) _bs.List[dgvFinanceLogs.SelectedRows[0].Index];
            if (log.InvoiceRefundLogs.Count > 0)
            {
                DialogResult dr = MessageBoxEx.Show("此笔融资已还款，是否确认删除此笔融资以及关联还款记录", MESSAGE.TITLE_INFORMATION,
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }

            try
            {
                Invoice invoice = log.Invoice;
                log.Invoice = null;
                InvoiceFinanceBatch batch = log.InvoiceFinanceBatch;
                log.InvoiceFinanceBatch = null;

                foreach (InvoiceRefundLog refundLog in log.InvoiceRefundLogs)
                {
                    refundLog.InvoiceFinanceLog = null;
                }

                _context.InvoiceRefundLogs.DeleteAllOnSubmit(log.InvoiceRefundLogs);
                invoice.CaculateRefund();
                invoice.CaculateFinance();
                batch.CaculateFinanceAmount();
                _context.InvoiceFinanceLogs.DeleteOnSubmit(log);
                //batch.CheckStatus = BATCH.UNCHECK;
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
            }

            dgvFinanceLogs.Rows.RemoveAt(dgvFinanceLogs.SelectedRows[0].Index);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            var batch = (InvoiceFinanceBatch) batchBindingSource.DataSource;
            if (batch.Case != null)
            {
                var detail = new CaseDetail(batch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
                detail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailClient(object sender, EventArgs e)
        {
            var batch = (InvoiceFinanceBatch) batchBindingSource.DataSource;
            if (batch.Client != null)
            {
                var detail = new ClientDetail(batch.Client, ClientDetail.OpClientType.DETAIL_CLIENT);
                detail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailInvoice(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFinanceLogs.SelectedRows.Count == 0)
            {
                return;
            }

            var log = (InvoiceFinanceLog) _bs.List[dgvFinanceLogs.SelectedRows[0].Index];
            var detail = new InvoiceDetail(log.Invoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
            detail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (!superValidator.Validate())
            {
                return;
            }

            bool isUpdateOK = true;
            try
            {
                _context.SubmitChanges(ConflictMode.ContinueOnConflict);
            }
            catch (ChangeConflictException)
            {
                foreach (ObjectChangeConflict cc in _context.ChangeConflicts)
                {
                    foreach (MemberChangeConflict mc in cc.MemberConflicts)
                    {
                        mc.Resolve(RefreshMode.KeepChanges);
                    }
                }

                _context.SubmitChanges();
            }
            catch (Exception e2)
            {
                isUpdateOK = false;
                MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isUpdateOK)
            {
                MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFactor(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            var financeBatch = (InvoiceFinanceBatch) batchBindingSource.DataSource;
            var factorMgr = new FactorMgr();
            var queryForm = new QueryForm(factorMgr, "选择代付行");
            factorMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);

            Factor factor = factorMgr.Selected;
            if (factor != null)
            {
                financeBatch.Factor = _context.Factors.SingleOrDefault(f => f.FactorCode == factor.FactorCode);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            _opBatchType = OpBatchType.UPDATE_BATCH;
            UpdateBatchControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateBatchControlStatus()
        {
            if (_opBatchType == OpBatchType.DETAIL_BATCH)
            {
                foreach (Control comp in panelBatch.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                btnFactorSelect.Visible = false;
            }
            else if (_opBatchType == OpBatchType.UPDATE_BATCH)
            {
                foreach (Control comp in panelBatch.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                btnFactorSelect.Visible = true;
                factorCodeTextBox.ReadOnly = true;
                factorTextBox.ReadOnly = true;
            }

            ControlUtil.SetComponetEditable(createUserNameTextBox, false);
            ControlUtil.SetComponetEditable(caseCodeTextBox, false);
            ControlUtil.SetComponetEditable(financeBatchNoTextBox, false);
            ControlUtil.SetComponetEditable(tbClientName, false);
            ControlUtil.SetComponetEditable(diInputDate, false);
        }
    }
}
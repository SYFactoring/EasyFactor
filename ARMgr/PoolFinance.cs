//-----------------------------------------------------------------------
// <copyright file="PoolFinance.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.CaseMgr;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.InfoMgr.FactorMgr;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PoolFinance : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;

        /// <summary>
        /// 
        /// </summary>
        private readonly ARPoolBasic _poolBasic;

        /// <summary>
        /// 
        /// </summary>
        private Client _client;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="poolBasic"></param>
        public PoolFinance(ARPoolBasic poolBasic)
        {
            InitializeComponent();
            dgvCases.AutoGenerateColumns = false;
            superValidator.Enabled = false;
            ControlUtil.SetDoubleBuffered(dgvCases);

            _poolBasic = poolBasic;

            _context = new DBDataContext();

            financeRateTextBox.DataBindings[0].Format += TypeUtil.FormatFloatToPercent;
            financeRateTextBox.DataBindings[0].Parse += TypeUtil.ParsePercentToFloat;

            costRateTextBoxX.DataBindings[0].Format += TypeUtil.FormatFloatToPercent;
            costRateTextBoxX.DataBindings[0].Parse += TypeUtil.ParsePercentToFloat;

            batchCurrencyComboBoxEx.DataSource = Currency.AllCurrencies;
            batchCurrencyComboBoxEx.DisplayMember = "CurrencyCode";
            batchCurrencyComboBoxEx.ValueMember = "CurrencyCode";
        }


        /// <summary>
        /// Sets
        /// </summary>
        public Client Client
        {
            get { return _client; }
            set
            {
                _client = _context.Clients.SingleOrDefault(c => c.ClientEDICode == value.ClientEDICode);
                NewBatch(null, null);
            }
        }


        //?Public?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        public void ResetControlsStatus()
        {
            foreach (Control comp in panelFinanceBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }

            batchBindingSource.DataSource = typeof (InvoiceFinanceBatch);
            dgvCases.DataSource = typeof (Case);
        }

        //?Private?Methods?(6)?
        /// <summary>
        /// Show detail info of selected Case
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Args</param>
        private void DetailCase(object sender, EventArgs e)
        {
            if (dgvCases.CurrentCell == null)
            {
                return;
            }

            var selectedCase = (Case) casesBindingSource.List[dgvCases.CurrentCell.RowIndex];
            var caseDetail = new CaseDetail(selectedCase, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCasesRowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DetailCase(sender, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewBatch(object sender, EventArgs e)
        {
            if (_client == null)
            {
                MessageBoxEx.Show("没有选定客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var financeBatch = new InvoiceFinanceBatch
                                   {
                                       CreateUserName = App.Current.CurUser.Name,
                                       InputDate = DateTime.Today
                                   };
            //financeBatch.CheckStatus = BATCH.UNCHECK;
            batchBindingSource.DataSource = financeBatch;

            IQueryable<Case> caseResult = from c in _context.Cases
                                          where c.SellerCode == _client.ClientEDICode && c.IsPool
                                          select c;

            dgvCases.DataSource = caseResult;
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

            if (_client == null)
            {
                MessageBoxEx.Show("没有选定客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!superValidator.Validate())
            {
                return;
            }

            if (!(batchBindingSource.DataSource is InvoiceFinanceBatch))
            {
                return;
            }

            var batch = (InvoiceFinanceBatch) batchBindingSource.DataSource;

            double financeAmount = batch.FinanceAmount;
            if (batch.BatchCurrency != "CNY")
            {
                double rate = Exchange.GetExchangeRate(batch.BatchCurrency, "CNY");
                financeAmount *= rate;
            }
            if (TypeUtil.GreaterZero(financeAmount - _client.PoolValuedAssignOutstanding))
            {
                MessageBoxEx.Show(
                    String.Format("本次融资币别{0}，额度{1:N2}，大于当前应收账款余额{2:N2}，不能融资。", batch.BatchCurrency, batch.FinanceAmount,
                                  _client.PoolValuedAssignOutstanding), MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            bool isSaveOK = true;
            batch.Client = _client;

            if (batch.FinanceBatchNo == null)
            {
                batch.FinanceBatchNo = InvoiceFinanceBatch.GenerateFinanceBatchNo(batch.FinancePeriodBegin);
            }

            try
            {
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                batch.FinanceBatchNo = null;
                batch.Client = null;
                isSaveOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isSaveOK)
            {
                MessageBoxEx.Show("数据保存成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                _poolBasic.CaculateOutstanding(_client);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBatch(object sender, EventArgs e)
        {
            if (_client == null)
            {
                MessageBoxEx.Show("没有选定客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var batchMgr = new FinanceBatchMgr(_client, _context);
            var queryUI = new QueryForm(batchMgr, "选择融资批次");
            batchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoiceFinanceBatch selectedBatch = batchMgr.Selected;
            if (selectedBatch != null)
            {
                batchBindingSource.DataSource = selectedBatch;

                IQueryable<Case> caseResult = from c in _context.Cases
                                              where c.SellerCode == _client.ClientEDICode && c.IsPool
                                              select c;

                dgvCases.DataSource = caseResult;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFactor(object sender, EventArgs e)
        {
            if (_client == null)
            {
                MessageBoxEx.Show("没有选定客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(batchBindingSource.DataSource is InvoiceFinanceBatch))
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
    }
}
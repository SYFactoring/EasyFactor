using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using DevComponents.DotNetBar;
using CMBC.EasyFactor.Utils;
using CMBC.EasyFactor.InfoMgr.FactorMgr;
using CMBC.EasyFactor.CaseMgr;

namespace CMBC.EasyFactor.ARMgr
{
    public partial class PoolFinance : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private Client _client;
        /// <summary>
        /// 
        /// </summary>
        private ARPoolBasic poolBasic;
        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poolBasic"></param>
        public PoolFinance(ARPoolBasic poolBasic)
        {
            InitializeComponent();
            this.dgvCases.AutoGenerateColumns = false;
            this.superValidator.Enabled = false;
            ControlUtil.SetDoubleBuffered(this.dgvCases);

            this.poolBasic = poolBasic;

            this.context = new DBDataContext();

            this.financeRateTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.financeRateTextBox.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

            this.costRateTextBoxX.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.costRateTextBoxX.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

            this.batchCurrencyComboBoxEx.DataSource = Currency.AllCurrencies;
            this.batchCurrencyComboBoxEx.DisplayMember = "CurrencyCode";
            this.batchCurrencyComboBoxEx.ValueMember = "CurrencyCode";
        }

        /// <summary>
        /// Sets
        /// </summary>
        public Client Client
        {
            set
            {
                this._client = this.context.Clients.SingleOrDefault(c => c.ClientEDICode == value.ClientEDICode);
                this.NewBatch(null, null);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void ResetControlsStatus()
        {
            foreach (Control comp in this.panelFinanceBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }

            this.batchBindingSource.DataSource = typeof(InvoiceFinanceBatch);
            this.dgvCases.DataSource = typeof(Case);
        }

        /// <summary>
        /// Show detail info of selected Case
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailCase(object sender, System.EventArgs e)
        {
            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            Case selectedCase = (Case)this.casesBindingSource.List[this.dgvCases.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedCase, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCases_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DetailCase(null, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewBatch(object sender, EventArgs e)
        {
            if (this._client == null)
            {
                MessageBoxEx.Show("没有选定客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            InvoiceFinanceBatch financeBatch = new InvoiceFinanceBatch();
            financeBatch.CreateUserName = App.Current.CurUser.Name;
            financeBatch.CheckStatus = ConstStr.BATCH.UNCHECK;
            this.batchBindingSource.DataSource = financeBatch;

            var caseResult = from c in context.Cases
                             where c.SellerCode == this._client.ClientEDICode && c.IsPool
                             select c;

            this.dgvCases.DataSource = caseResult;
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

            if (this._client == null)
            {
                MessageBoxEx.Show("没有选定客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!this.superValidator.Validate())
            {
                return;
            }

            if (!(this.batchBindingSource.DataSource is InvoiceFinanceBatch))
            {
                return;
            }

            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.batchBindingSource.DataSource;
            bool isSaveOK = true;
            batch.Client = this._client;

            if (batch.FinanceBatchNo == null)
            {
                batch.FinanceBatchNo = InvoiceFinanceBatch.GenerateFinanceBatchNo(batch.FinancePeriodBegin);
            }

            try
            {
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                batch.FinanceBatchNo = null;
                batch.Client = null;
                isSaveOK = false;
                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isSaveOK)
            {
                MessageBoxEx.Show("数据保存成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.poolBasic.CaculateOutstanding(this._client);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBatch(object sender, EventArgs e)
        {
            if (this._client == null)
            {
                MessageBoxEx.Show("没有选定客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FinanceBatchMgr batchMgr = new FinanceBatchMgr(this._client, this.context);
            QueryForm queryUI = new QueryForm(batchMgr, "选择融资批次");
            batchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoiceFinanceBatch selectedBatch = batchMgr.Selected;
            if (selectedBatch != null)
            {
                this.batchBindingSource.DataSource = selectedBatch;

                var caseResult = from c in context.Cases
                                 where c.SellerCode == this._client.ClientEDICode && c.IsPool
                                 select c;

                this.dgvCases.DataSource = caseResult;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFactor(object sender, EventArgs e)
        {
            if (this._client == null)
            {
                MessageBoxEx.Show("没有选定客户", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.batchBindingSource.DataSource is InvoiceFinanceBatch))
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
                financeBatch.Factor = this.context.Factors.SingleOrDefault(f => f.FactorCode == factor.FactorCode);
            }
        }
    }
}

//-----------------------------------------------------------------------
// <copyright file="PoolRefund.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class PoolRefund : UserControl
    {
        #region?Fields?(4)?

        /// <summary>
        /// 
        /// </summary>
        private Client _client;
        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;
        /// <summary>
        /// 
        /// </summary>
        private ARPoolBasic poolBasic;
        /// <summary>
        /// 
        /// </summary>
        private OpRefundType refundType;

        #endregion?Fields?

        #region?Enums?(1)?

        /// <summary>
        /// 
        /// </summary>
        public enum OpRefundType
        {
            /// <summary>
            /// 
            /// </summary>
            BUYER_PAYMENT,

            /// <summary>
            /// 
            /// </summary>
            SELLER_REFUND,
        }

        #endregion?Enums?

        #region?Constructors?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poolBasic"></param>
        /// <param name="refundType"></param>
        public PoolRefund(ARPoolBasic poolBasic, OpRefundType refundType)
        {
            InitializeComponent();

            this.poolBasic = poolBasic;
            this.refundType = refundType;
            this.dgvLogs.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvLogs);
            this.superValidator.Enabled = false;

            this.batchCurrencyComboBoxEx.DataSource = Currency.AllCurrencies;
            this.batchCurrencyComboBoxEx.DisplayMember = "CurrencyCode";
            this.batchCurrencyComboBoxEx.ValueMember = "CurrencyCode";

            this.context = new DBDataContext();
        }

        #endregion?Constructors?

        #region?Properties?(1)?

        /// <summary>
        /// 
        /// </summary>
        public Client Client
        {
            get
            {
                return this._client;
            }
            set
            {
                this._client = this.context.Clients.SingleOrDefault(c => c.ClientEDICode == value.ClientEDICode);
                this.NewBatch(null, null);
            }
        }

        #endregion?Properties?

        #region?Methods?(2)?

        //?Private?Methods?(2)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewBatch(object sender, EventArgs e)
        {
            if (this._client == null)
            {
                MessageBoxEx.Show("没有选定客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            switch (refundType)
            {
                case OpRefundType.BUYER_PAYMENT:
                    this.cbRefundType.Text = Refund.BUYER_PAYMENT;
                    break;
                case OpRefundType.SELLER_REFUND:
                    this.cbRefundType.Text = Refund.SELLER_REFUND;
                    break;
                default:
                    break;
            }

            List<InvoiceFinanceBatch> financeBatches = new List<InvoiceFinanceBatch>();
            foreach (InvoiceFinanceBatch financeBatch in _client.InvoiceFinanceBatches)
            {
                if (TypeUtil.GreaterZero(financeBatch.PoolFinanceOutstanding))
                {
                    financeBatches.Add(financeBatch);
                }
            }

            this.dgvLogs.DataSource = financeBatches;
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

            if (this._client == null)
            {
                MessageBoxEx.Show("没有选定客户", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!this.superValidator.Validate())
            {
                return;
            }

            string refundType = this.cbRefundType.Text;
            string batchCurrency = this.batchCurrencyComboBoxEx.Text;

            string refundAmountStr = this.refundAmountTextBoxX.Text;
            double refundAmount = 0;
            if (!String.IsNullOrEmpty(refundAmountStr))
            {
                if (!Double.TryParse(refundAmountStr, out refundAmount))
                {
                    MessageBoxEx.Show("冲销融资金额类型异常");
                }
            }

            DateTime refundDate = this.refundDateDateTimePicker.Value;

            string comment = this.commentTextBox.Text;

            List<InvoiceFinanceBatch> financeBatchList = (List<InvoiceFinanceBatch>)this.dgvLogs.DataSource;
            List<InvoiceRefundBatch> refundBatchList = new List<InvoiceRefundBatch>();
            foreach (InvoiceFinanceBatch financeBatch in financeBatchList)
            {
                if (TypeUtil.GreaterZero(refundAmount) && TypeUtil.GreaterZero(financeBatch.PoolFinanceOutstanding))
                {
                    if (financeBatch.BatchCurrency != batchCurrency)
                    {
                        double rate = Exchange.GetExchangeRate(batchCurrency, financeBatch.BatchCurrency);
                        refundAmount *= rate;
                    }

                    InvoiceRefundBatch refundBatch = new InvoiceRefundBatch();
                    refundBatch.InvoiceFinanceBatch = financeBatch;
                    refundBatch.RefundAmount = Math.Min(refundAmount, financeBatch.PoolFinanceOutstanding);
                    refundAmount -= refundBatch.RefundAmount.GetValueOrDefault();
                    //refundBatch.CheckStatus = BATCH.UNCHECK;
                    refundBatch.Comment = comment;
                    refundBatch.InputDate = DateTime.Now;
                    refundBatch.RefundDate = refundDate;
                    refundBatch.RefundType = refundType;
                    refundBatch.CreateUserName = App.Current.CurUser.Name;
                    refundBatch.RefundBatchNo = InvoiceRefundBatch.GenerateRefundBatchNo(refundDate, refundBatchList);
                    refundBatchList.Add(refundBatch);
                }
            }

            if (TypeUtil.GreaterZero(refundAmount))
            {
                MessageBoxEx.Show("冲销融资金额不能大于融资余额");
                foreach (InvoiceRefundBatch batch in refundBatchList)
                {
                    batch.InvoiceFinanceBatch = null;
                }
                return;
            }

            try
            {
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (InvoiceRefundBatch batch in refundBatchList)
                {
                    batch.InvoiceFinanceBatch = null;
                }

                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBoxEx.Show("数据保存成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion?Methods?
    }
}

//-----------------------------------------------------------------------
// <copyright file="PoolRefund.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PoolRefund : UserControl
    {
        #region OpRefundType enum

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

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;

        /// <summary>
        /// 
        /// </summary>
        private readonly OpRefundType _refundType;

        /// <summary>
        /// 
        /// </summary>
        private Client _client;

        /// <summary>
        /// 
        /// </summary>
        private ARPoolBasic _poolBasic;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="poolBasic"></param>
        /// <param name="refundType"></param>
        public PoolRefund(ARPoolBasic poolBasic, OpRefundType refundType)
        {
            InitializeComponent();

            _poolBasic = poolBasic;
            _refundType = refundType;
            dgvLogs.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(dgvLogs);
            superValidator.Enabled = false;

            batchCurrencyComboBoxEx.DataSource = Currency.AllCurrencies;
            batchCurrencyComboBoxEx.DisplayMember = "CurrencyCode";
            batchCurrencyComboBoxEx.ValueMember = "CurrencyCode";

            _context = new DBDataContext();
        }


        /// <summary>
        /// 
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


        //?Private?Methods?(2)?
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

            switch (_refundType)
            {
                case OpRefundType.BUYER_PAYMENT:
                    cbRefundType.Text = REFUND.BUYER_PAYMENT;
                    break;
                case OpRefundType.SELLER_REFUND:
                    cbRefundType.Text = REFUND.SELLER_REFUND;
                    break;
                default:
                    break;
            }

            var financeBatches = _client.InvoiceFinanceBatches.Where(financeBatch => TypeUtil.GreaterZero(financeBatch.PoolFinanceOutstanding)).ToList();

            dgvLogs.DataSource = financeBatches;
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

            string refundType = cbRefundType.Text;
            string batchCurrency = batchCurrencyComboBoxEx.Text;

            string refundAmountStr = refundAmountTextBoxX.Text;
            double refundAmount = 0;
            if (!String.IsNullOrEmpty(refundAmountStr))
            {
                if (!Double.TryParse(refundAmountStr, out refundAmount))
                {
                    MessageBoxEx.Show("冲销融资金额类型异常");
                }
            }

            DateTime refundDate = refundDateDateTimePicker.Value;

            string comment = commentTextBox.Text;

            var financeBatchList = (List<InvoiceFinanceBatch>) dgvLogs.DataSource;
            var refundBatchList = new List<InvoiceRefundBatch>();
            foreach (InvoiceFinanceBatch financeBatch in financeBatchList)
            {
                if (TypeUtil.GreaterZero(refundAmount) && TypeUtil.GreaterZero(financeBatch.PoolFinanceOutstanding))
                {
                    if (financeBatch.BatchCurrency != batchCurrency)
                    {
                        double rate = Exchange.GetExchangeRate(batchCurrency, financeBatch.BatchCurrency);
                        refundAmount *= rate;
                    }

                    var refundBatch = new InvoiceRefundBatch
                                          {
                                              InvoiceFinanceBatch = financeBatch,
                                              RefundAmount = Math.Min(refundAmount, financeBatch.PoolFinanceOutstanding)
                                          };
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
                _context.SubmitChanges();
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
    }
}
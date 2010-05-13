//-----------------------------------------------------------------------
// <copyright file="InvoicePaymentBatch.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data.Linq;
    using CMBC.EasyFactor.Utils.ConstStr;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoicePaymentBatch
    {
        #region?Properties?(5)?

        /// <summary>
        /// Gets
        /// </summary>
        public int BatchCount
        {
            get
            {
                return this.InvoicePaymentLogs.Count;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerName
        {
            get
            {
                return this.Case.BuyerClient.ToString();
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double PaymentAmount
        {
            get
            {
                double result = 0;
                foreach (InvoicePaymentLog paymentLog in this.InvoicePaymentLogs)
                {
                    result += paymentLog.PaymentAmount.GetValueOrDefault();
                }

                return result;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerName
        {
            get
            {
                return this.Case.SellerClient.ToString();
            }
        }

        /// <summary>
        /// Gets Tranasction Type
        /// </summary>
        public string TransactionType
        {
            get
            {
                return this.Case.TransactionType;
            }
        }

        #endregion?Properties?

        #region?Methods?(2)?

        //?Public?Methods?(2)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GeneratePaymentBatchNo(DateTime date)
        {
            string prefix = String.Format("PAY{0:yyyyMMdd}", date);
            int batchCount;

            using (DBDataContext context = new DBDataContext())
            {
                var queryResult = from batch in context.InvoicePaymentBatches
                                  where batch.PaymentBatchNo.StartsWith(prefix)
                                  select batch.PaymentBatchNo;

                if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
                {
                    batchCount = 0;
                }
            }

            string paymentNo = String.Format("{0}-{1:d2}", prefix, batchCount + 1);
            return paymentNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="batchesInMemory"></param>
        /// <returns></returns>
        public static string GeneratePaymentBatchNo(DateTime date, List<InvoicePaymentBatch> batchesInMemory)
        {
            string prefix = String.Format("PAY{0:yyyyMMdd}", date);
            int batchCount;

            using (DBDataContext context = new DBDataContext())
            {
                var queryResult = from batch in context.InvoicePaymentBatches
                                  where batch.PaymentBatchNo.StartsWith(prefix)
                                  select batch.PaymentBatchNo;

                if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
                {
                    batchCount = 0;
                }
            }

            batchCount += batchesInMemory.Count(batch => batch.PaymentBatchNo.Contains(prefix));
            string paymentNo = String.Format("{0}-{1:d2}", prefix, batchCount + 1);
            return paymentNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (this.PaymentType != Payment.BUYER_PAYMENT && this.PaymentType != Payment.CREDIT_NOTE_PAYMENT && this.PaymentType != Payment.GUARANTEE_PAYMENT && this.PaymentType != Payment.INDIRECT_PAYMENT && this.PaymentType != Payment.SELLER_REASSIGN)
                {
                    throw new Exception(String.Format("付款类型：{0}，不符合规范类型，还款批次号{1}", this.PaymentType, this.PaymentBatchNo));
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        partial void OnPaymentDateChanged()
        {
            foreach (InvoicePaymentLog log in this.InvoicePaymentLogs)
            {
                log.Invoice.CaculatePaymentDate();
            }
        }
        #endregion?Methods?
    }
}

//-----------------------------------------------------------------------
// <copyright file="InvoicePaymentBatch.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoicePaymentBatch
    {

        /// <summary>
        /// Gets
        /// </summary>
        public int BatchCount
        {
            get { return InvoicePaymentLogs.Count; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerName
        {
            get { return Case.BuyerClient.ToString(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string FactorName
        {
            get { return Case.Factor.ToString(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool HasCreditNotes
        {
            get
            { return InvoicePaymentLogs.Any(log => log.CreditNote != null); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string InvoiceCurrency
        {
            get { return Case.InvoiceCurrency; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double PaymentAmount
        {
            get
            {
                return InvoicePaymentLogs.Sum(paymentLog => paymentLog.PaymentAmount.GetValueOrDefault());
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerName
        {
            get { return Case.SellerClient.ToString(); }
        }

        /// <summary>
        /// Gets Tranasction Type
        /// </summary>
        public string TransactionType
        {
            get { return Case.TransactionType; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GeneratePaymentBatchNo(DateTime date)
        {
            string prefix = String.Format("PAY{0:yyyyMMdd}", date);
            int batchCount = 0;

            using (var context = new DBDataContext())
            {
                IQueryable<string> queryStr = from batch in context.InvoicePaymentBatches
                                              where batch.PaymentBatchNo.StartsWith(prefix)
                                              select batch.PaymentBatchNo.Substring(12);

                foreach (string value in queryStr)
                {
                    if (batchCount < Convert.ToInt32(value))
                    {
                        batchCount = Convert.ToInt32(value);
                    }
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
            int batchCount = 0;

            using (var context = new DBDataContext())
            {
                IQueryable<string> queryStr = from batch in context.InvoicePaymentBatches
                                              where batch.PaymentBatchNo.StartsWith(prefix)
                                              select batch.PaymentBatchNo.Substring(12);

                foreach (string value in queryStr)
                {
                    if (batchCount < Convert.ToInt32(value))
                    {
                        batchCount = Convert.ToInt32(value);
                    }
                }
            }

            batchCount += batchesInMemory.Count(batch => batch.PaymentBatchNo.Contains(prefix));
            string paymentNo = String.Format("{0}-{1:d2}", prefix, batchCount + 1);
            return paymentNo;
        }

        /// <summary>
        /// 
        /// </summary>
        partial void OnPaymentDateChanged()
        {
            foreach (InvoicePaymentLog log in InvoicePaymentLogs)
            {
                log.Invoice.CaculatePaymentDate();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (PaymentType != PAYMENT.BUYER_PAYMENT && PaymentType != PAYMENT.CREDIT_NOTE_PAYMENT &&
                    PaymentType != PAYMENT.GUARANTEE_PAYMENT && PaymentType != PAYMENT.INDIRECT_PAYMENT &&
                    PaymentType != PAYMENT.SELLER_REASSIGN)
                {
                    throw new Exception(String.Format("付款类型：{0}，不符合规范类型，还款批次号{1}", PaymentType, PaymentBatchNo));
                }
            }
        }
    }
}
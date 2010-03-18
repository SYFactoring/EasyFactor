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

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoicePaymentBatch
    {
        #region Properties (4)

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
                    result += paymentLog.PaymentAmount;
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

        #endregion Properties



        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GeneratePaymentBatchNo(DateTime date)
        {
            DBDataContext context = new DBDataContext();
            //var queryResult = from batch in context.InvoicePaymentBatches
            //                  where batch.PaymentDate.Date == date.Date
            //                  select batch.PaymentBatchNo;

            string dateStr = String.Format("{0:yyyMMdd}", date);
            var queryResult = from batch in context.InvoicePaymentBatches
                              where batch.PaymentBatchNo.Contains(dateStr)
                              select batch.PaymentBatchNo;

            int batchCount;
            if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
            {
                batchCount = 0;
            }
            string paymentNo = String.Format("PAY{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
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
            DBDataContext context = new DBDataContext();
            //var queryResult = from batch in context.InvoicePaymentBatches
            //                  where batch.PaymentDate.Date == date.Date
            //                  select batch.PaymentBatchNo;
            string dateStr = String.Format("{0:yyyMMdd}", date);
            var queryResult = from batch in context.InvoicePaymentBatches
                              where batch.PaymentBatchNo.Contains(dateStr)
                              select batch.PaymentBatchNo;
            int batchCount;
            if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
            {
                batchCount = 0;
            }

            batchCount += batchesInMemory.Count(batch => batch.PaymentBatchNo.Contains(dateStr));
            string paymentNo = String.Format("PAY{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return paymentNo;
        }
    }
}

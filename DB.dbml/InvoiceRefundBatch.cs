//-----------------------------------------------------------------------
// <copyright file="InvoiceRefundBatch.cs" company="Yiming Liu@Fudan">
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
    public partial class InvoiceRefundBatch
    {
        #region Properties (4)

        /// <summary>
        /// Gets
        /// </summary>
        public int BatchCount
        {
            get
            {
                return this.InvoiceRefundLogs.Count;
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
        public string SellerName
        {
            get
            {
                return this.Case.SellerClient.ToString();
            }
        }

        /// <summary>
        /// Gets Transaction Type
        /// </summary>
        public string TransactionType
        {
            get
            {
                return this.Case.TransactionType;
            }
        }

        #endregion Properties

        #region Methods (3)

        // Public Methods (3) 

        /// <summary>
        /// 
        /// </summary>
        public void CaculateRefundAmount()
        {
            this.RefundAmount = this.InvoiceRefundLogs.Sum(log => log.RefundAmount.GetValueOrDefault());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GenerateRefundBatchNo(DateTime date)
        {
            string dateStr = String.Format("{0:yyyMMdd}", date);
            int batchCount;
            using (DBDataContext context = new DBDataContext())
            {

                var queryResult = from batch in context.InvoiceRefundBatches
                                  where batch.RefundBatchNo.Contains(dateStr)
                                  select batch.RefundBatchNo;

                if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
                {
                    batchCount = 0;
                }
            }

            string refundNo = String.Format("RFD{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return refundNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="batchesInMemory"></param>
        /// <returns></returns>
        public static string GenerateRefundBatchNo(DateTime date, List<InvoiceRefundBatch> batchesInMemory)
        {
            string dateStr = String.Format("{0:yyyMMdd}", date);
            int batchCount;
            using (DBDataContext context = new DBDataContext())
            {
                var queryResult = from batch in context.InvoiceRefundBatches
                                  where batch.RefundBatchNo.Contains(dateStr)
                                  select batch.RefundBatchNo;

                if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
                {
                    batchCount = 0;
                }
            }

            batchCount += batchesInMemory.Count(batch => batch.RefundBatchNo.Contains(dateStr));
            string refundNo = String.Format("RFD{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return refundNo;
        }

        #endregion Methods
    }
}

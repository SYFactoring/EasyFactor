//-----------------------------------------------------------------------
// <copyright file="InvoiceRefundBatch.cs" company="Yiming Liu@Fudan">
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
    public partial class InvoiceRefundBatch
    {
        /// <summary>
        /// Gets
        /// </summary>
        public int BatchCount
        {
            get { return InvoiceRefundLogs.Count; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerName
        {
            get { return Case.BuyerClient.ToString(); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerName
        {
            get
            {
                if (Case != null)
                {
                    return Case.SellerClient.ToString();
                }
                return InvoiceFinanceBatch != null ? InvoiceFinanceBatch.SellerName : string.Empty;
            }
        }

        /// <summary>
        /// Gets Transaction Type
        /// </summary>
        public string TransactionType
        {
            get { return Case.TransactionType; }
        }


        //?Public?Methods?(3)?
        /// <summary>
        /// 
        /// </summary>
        public void CaculateRefundAmount()
        {
            RefundAmount = InvoiceRefundLogs.Sum(log => log.RefundAmount.GetValueOrDefault());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GenerateRefundBatchNo(DateTime date)
        {
            string dateStr = String.Format("{0:yyyMMdd}", date);
            int batchCount = 0;
            using (var context = new DBDataContext())
            {
                IQueryable<string> queryStr = from batch in context.InvoiceRefundBatches
                                              where batch.RefundBatchNo.Contains(dateStr)
                                              select batch.RefundBatchNo.Substring(12);

                foreach (string value in queryStr)
                {
                    if (batchCount < Convert.ToInt32(value))
                    {
                        batchCount = Convert.ToInt32(value);
                    }
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
            int batchCount = 0;
            using (var context = new DBDataContext())
            {
                IQueryable<string> queryStr = from batch in context.InvoiceRefundBatches
                                              where batch.RefundBatchNo.Contains(dateStr)
                                              select batch.RefundBatchNo.Substring(12);

                foreach (string value in queryStr)
                {
                    if (batchCount < Convert.ToInt32(value))
                    {
                        batchCount = Convert.ToInt32(value);
                    }
                }
            }

            batchCount += batchesInMemory.Count(batch => batch.RefundBatchNo.Contains(dateStr));
            string refundNo = String.Format("RFD{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return refundNo;
        }

        /// <summary>
        /// 
        /// </summary>
        partial void OnRefundDateChanged()
        {
            foreach (InvoiceRefundLog log in InvoiceRefundLogs)
            {
                log.InvoiceFinanceLog.Invoice.CaculateRefundDate();
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
                if (RefundType != REFUND.SELLER_REFUND && RefundType != REFUND.BUYER_PAYMENT)
                {
                    throw new Exception(String.Format("还款类型：{0}，设置无效，还款批次号{1}", RefundType, RefundBatchNo));
                }
            }
        }

        public decimal? Interest
        {
            get
            {
                return this.InvoiceRefundLogs.Sum(log => log.Interest);
            }
        }
    }
}
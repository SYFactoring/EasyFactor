//-----------------------------------------------------------------------
// <copyright file="Invoice.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class Invoice : BaseObject
    {
        #region Properties (19)

        /// <summary>
        /// Gets
        /// </summary>
        public DateTime AssignDate
        {
            get
            {
                return this.InvoiceAssignBatch.AssignDate;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double AssignOutstanding
        {
            get
            {
                return this.AssignAmount - this.PaymentAmount.GetValueOrDefault() - this.PaymentAmount2.GetValueOrDefault();
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public System.Nullable<int> AssignOverDueDays
        {
            get
            {
                if (TypeUtil.GreaterZero(this.AssignOutstanding))
                {
                    return (DateTime.Now.Date - this.DueDate).Days;
                }

                return null;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerName
        {
            get
            {
                return this.InvoiceAssignBatch.CDA.Case.BuyerClient.ToString();
            }
        }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public DateTime? CreditNoteDate2
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string CreditNoteNo2
        {
            get;
            set;
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string FactorName
        {
            get
            {
                string transactionType = this.InvoiceAssignBatch.CDA.Case.TransactionType;
                switch (transactionType)
                {
                    case "国内卖方保理":
                    case "国内买方保理":
                    case "租赁保理":
                        return string.Empty;
                    case "国内信保保理":
                    case "国际信保保理":
                    case "出口保理":
                        return this.InvoiceAssignBatch.CDA.Case.BuyerFactor.ToString();
                    case "进口保理":
                        return this.InvoiceAssignBatch.CDA.Case.SellerFactor.ToString();
                    default:
                        return string.Empty;
                }
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string FinanceCurrency
        {
            get
            {
                if (this.InvoiceFinanceBatch != null)
                {
                    return this.InvoiceFinanceBatch.BatchCurrency;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public System.Nullable<double> FinanceOutstanding
        {
            get
            {
                if (!this.FinanceAmount.HasValue)
                {
                    return null;
                }

                return this.FinanceAmount.Value - this.RefundAmount.GetValueOrDefault() - this.RefundAmount2.GetValueOrDefault();
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public System.Nullable<int> FinanceOverDueDays
        {
            get
            {
                if (TypeUtil.GreaterZero(this.FinanceOutstanding))
                {
                    TimeSpan duedays = DateTime.Now.Date - this.FinanceDueDate.Value;
                    return duedays.Days;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string InvoiceCurrency
        {
            get
            {
                return this.InvoiceAssignBatch.CDA.Case.InvoiceCurrency;
            }
        }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public double? PaymentAmount2
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public DateTime? PaymentDate2
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public int? PaymentLogID2
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public double? RefundAmount2
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public DateTime? RefundDate2
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public int? RefundLogID2
        {
            get;
            set;
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerName
        {
            get
            {
                return this.InvoiceAssignBatch.CDA.Case.SellerClient.ToString();
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string TransactionType
        {
            get
            {
                return this.InvoiceAssignBatch.CDA.Case.TransactionType;
            }
        }

        #endregion Properties

        #region Methods (12)

        // Public Methods (12) 

        /// <summary>
        /// 
        /// </summary>
        public void CaculatePayment()
        {
            if (InvoicePaymentLogs.Count > 0)
            {
                PaymentAmount = InvoicePaymentLogs.Sum(log => log.PaymentAmount);
                PaymentDate = InvoicePaymentLogs.Max(log => log.InvoicePaymentBatch.PaymentDate);
            }
            else
            {
                PaymentAmount = null;
                PaymentDate = null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void CaculateRefund()
        {
            if (InvoiceRefundLogs.Count > 0)
            {
                RefundAmount = InvoiceRefundLogs.Sum(log => log.RefundAmount);
                RefundDate = InvoiceRefundLogs.Max(log => log.InvoiceRefundBatch.RefundDate);
            }
            else
            {
                RefundAmount = null;
                RefundDate = null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Invoice right = obj as Invoice;
            if (right == null)
            {
                return false;
            }

            return this.GetHashCode() == right.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GenerateAssignBatchNo(DateTime date)
        {
            DateTime begin = date.Date;
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoiceAssignBatches.Count(batch => batch.AssignDate >= begin && batch.AssignDate < end);
            string assignNo = String.Format("ASS{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return assignNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="batchesInMemory"></param>
        /// <returns></returns>
        public static string GenerateAssignBatchNo(DateTime date, List<InvoiceAssignBatch> batchesInMemory)
        {
            DateTime begin = date.Date;
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoiceAssignBatches.Count(batch => batch.AssignDate >= begin && batch.AssignDate < end);
            batchCount += batchesInMemory.Count(batch => batch.AssignDate >= begin && batch.AssignDate < end);
            string assignNo = String.Format("ASS{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return assignNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GenerateFinanceBatchNo(DateTime date)
        {
            DateTime begin = date.Date;
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoiceFinanceBatches.Count(batch => batch.FinancePeriodBegin >= begin && batch.FinancePeriodBegin < end);
            string financeNo = String.Format("FIN{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return financeNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="batchesInMemory"></param>
        /// <returns></returns>
        public static string GenerateFinanceBatchNo(DateTime date, List<InvoiceFinanceBatch> batchesInMemory)
        {
            DateTime begin = date.Date;
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoiceFinanceBatches.Count(batch => batch.FinancePeriodBegin >= begin && batch.FinancePeriodBegin < end);
            batchCount += batchesInMemory.Count(batch => batch.FinancePeriodBegin >= begin && batch.FinancePeriodBegin < end);
            string financeNo = String.Format("FIN{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return financeNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GeneratePaymentBatchNo(DateTime date)
        {
            DateTime begin = date.Date;
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoicePaymentBatches.Count(batch => batch.PaymentDate >= begin && batch.PaymentDate < end);
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
            DateTime begin = date.Date;
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoicePaymentBatches.Count(batch => batch.PaymentDate >= begin && batch.PaymentDate < end);
            batchCount += batchesInMemory.Count(batch => batch.PaymentDate >= begin && batch.PaymentDate < end);
            string paymentNo = String.Format("PAY{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return paymentNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GenerateRefundBatchNo(DateTime date)
        {
            DateTime begin = date.Date;
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoiceRefundBatches.Count(batch => batch.RefundDate >= begin && batch.RefundDate < end);
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
            DateTime begin = date.Date;
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoiceRefundBatches.Count(batch => batch.RefundDate >= begin && batch.RefundDate < end);
            batchCount += batchesInMemory.Count(batch => batch.RefundDate >= begin && batch.RefundDate < end);
            string refundNo = String.Format("RFD{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return refundNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            if (this.InvoiceNo == null)
            {
                return 0;
            }
            else
            {
                return this.InvoiceNo.GetHashCode();
            }
        }

        #endregion Methods
    }
}

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
    using System.Data.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// 
    /// </summary>
    public partial class Invoice
    {
        #region Fields (3)

        private double? _financeAmount2;
        private double? _paymentAmount2;
        private double? _refundAmount2;
        private static Regex InvoiceNoRegex = new Regex("^[a-zA-Z0-9]+[a-zA-Z0-9\\-<>\\.]+$");

        #endregion Fields

        #region Properties (23)

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
                return this.AssignAmount - this.PaymentAmount.GetValueOrDefault();
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public System.Nullable<int> AssignOverDueDays
        {
            get
            {
                if (this.DueDate != null && TypeUtil.GreaterZero(this.AssignOutstanding))
                {
                    return (DateTime.Now.Date - this.DueDate.Value).Days;
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
                return this.InvoiceAssignBatch.Case.BuyerClient.ToString();
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
                return this.InvoiceAssignBatch.Case.Factor.ToString();
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

                return this.FinanceAmount.Value - this.RefundAmount.GetValueOrDefault();
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
        /// 
        /// </summary>
        public double? NetInterest
        {
            get
            {
                if (this.InvoiceFinanceBatch != null)
                {
                    double? result = null;
                    if (this.InvoiceRefundLogs != null)
                    {
                        result = 0;
                        foreach (InvoiceRefundLog log in this.InvoiceRefundLogs)
                        {
                            int period = ((log.RefundDate < InvoiceFinanceBatch.FinancePeriodEnd ? log.RefundDate : InvoiceFinanceBatch.FinancePeriodEnd) - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                            result += log.RefundAmount * (InvoiceFinanceBatch.FinanceRate - InvoiceFinanceBatch.CostRate.GetValueOrDefault()) / 360 * period;
                        }
                    }

                    if (TypeUtil.GreaterZero(this.FinanceOutstanding))
                    {
                        int period = ((DateTime.Today < InvoiceFinanceBatch.FinancePeriodEnd ? DateTime.Today : InvoiceFinanceBatch.FinancePeriodEnd) - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                        result += FinanceAmount * (InvoiceFinanceBatch.FinanceRate - InvoiceFinanceBatch.CostRate.GetValueOrDefault()) / 360 * period;
                    }

                    return result;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? GrossInterest
        {
            get
            {
                if (this.InvoiceFinanceBatch != null)
                {
                    double? result = null;
                    if (this.InvoiceRefundLogs != null)
                    {
                        result = 0;
                        foreach (InvoiceRefundLog log in this.InvoiceRefundLogs)
                        {
                            int period = ((log.RefundDate < InvoiceFinanceBatch.FinancePeriodEnd ? log.RefundDate : InvoiceFinanceBatch.FinancePeriodEnd) - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                            result += log.RefundAmount * (InvoiceFinanceBatch.FinanceRate) / 360 * period;
                        }
                    }

                    if (TypeUtil.GreaterZero(this.FinanceOutstanding))
                    {
                        int period = ((DateTime.Today < InvoiceFinanceBatch.FinancePeriodEnd ? DateTime.Today : InvoiceFinanceBatch.FinancePeriodEnd) - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                        result += FinanceAmount * (InvoiceFinanceBatch.FinanceRate) / 360 * period;
                    }

                    return result;
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
                return this.InvoiceAssignBatch.Case.InvoiceCurrency;
            }
        }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public double? PaymentAmount2
        {
            get
            {
                return _paymentAmount2;
            }
            set
            {
                if (_paymentAmount2 != value)
                {
                    this.SendPropertyChanging();
                    this._paymentAmount2 = value;
                    this.SendPropertyChanged("PaymentAmount2");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string PaymentBatchNos
        {
            get
            {
                List<string> batches = new List<string>();
                foreach (InvoicePaymentLog log in this.InvoicePaymentLogs)
                {
                    if (!batches.Contains(log.PaymentBatchNo))
                    {
                        batches.Add(log.PaymentBatchNo);
                    }
                }
                if (batches.Count > 0)
                {
                    return String.Join(";", batches.ToArray());
                }
                else
                {
                    return string.Empty;
                }
            }
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
        /// 
        /// </summary>
        public double? FinanceAmount2
        {
            get
            {
                return _financeAmount2;
            }
            set
            {
                if (this._financeAmount2 != value)
                {
                    this.SendPropertyChanging();
                    this._financeAmount2 = value;
                    this.SendPropertyChanged("FinanceAmount2");
                }
            }
        }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public double? RefundAmount2
        {
            get
            {
                return _refundAmount2;
            }
            set
            {
                if (this._refundAmount2 != value)
                {
                    this.SendPropertyChanging();
                    this._refundAmount2 = value;
                    this.SendPropertyChanged("RefundAmount2");
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public string FinanceBatchNos
        {
            get
            {
                List<string> batches = new List<string>();
                foreach (InvoiceFinanceLog log in this.InvoiceFinanceLogs)
                {
                    if (!batches.Contains(log.FinanceBatchNo))
                    {
                        batches.Add(log.FinanceBatchNo);
                    }
                }
                if (batches.Count > 0)
                {
                    return String.Join(";", batches.ToArray());
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string RefundBatchNos
        {
            get
            {
                List<string> batches = new List<string>();
                foreach (InvoiceRefundLog log in this.InvoiceRefundLogs)
                {
                    if (!batches.Contains(log.RefundBatchNo))
                    {
                        batches.Add(log.RefundBatchNo);
                    }
                }
                if (batches.Count > 0)
                {
                    return String.Join(";", batches.ToArray());
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDate2
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
        /// 
        /// </summary>
        public int? FinanceLogID2
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
                return this.InvoiceAssignBatch.Case.SellerClient.ToString();
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string TransactionType
        {
            get
            {
                return this.InvoiceAssignBatch.Case.TransactionType;
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
        public void CaculateFinance()
        {
            if (InvoiceFinanceLogs.Count > 0)
            {
                FinanceAmount = InvoiceFinanceLogs.Sum(log => log.FinanceAmount);
                FinanceDate = InvoiceFinanceLogs.Min(log => log.InvoiceFinanceBatch.FinancePeriodBegin);
                FinanceDueDate = InvoiceFinanceLogs.Min(log => log.InvoiceFinanceBatch.FinancePeriodEnd);
            }
            else
            {
                FinanceAmount = null;
                FinanceDate = null;
                FinanceDueDate = null;
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
            DBDataContext context = new DBDataContext();
            //var queryResult = from batch in context.InvoiceAssignBatches
            //                  where batch.AssignDate.Date == date.Date
            //                  select batch.AssignBatchNo;
            string dateStr = String.Format("{0:yyyMMdd}", date);
            var queryResult = from batch in context.InvoiceAssignBatches
                              where batch.AssignBatchNo.Contains(dateStr)
                              select batch.AssignBatchNo;

            int batchCount;
            if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
            {
                batchCount = 0;
            }

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
            DBDataContext context = new DBDataContext();
            //var queryResult = from batch in context.InvoiceAssignBatches
            //                  where batch.AssignDate.Date == date.Date
            //                  select batch.AssignBatchNo;
            string dateStr = String.Format("{0:yyyMMdd}", date);
            var queryResult = from batch in context.InvoiceAssignBatches
                              where batch.AssignBatchNo.Contains(dateStr)
                              select batch.AssignBatchNo;

            int batchCount;
            if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
            {
                batchCount = 0;
            }

            batchCount += batchesInMemory.Count(batch => batch.AssignBatchNo.Contains(dateStr));
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
            DBDataContext context = new DBDataContext();
            //var queryResult = from batch in context.InvoiceFinanceBatches
            //                  where batch.FinancePeriodBegin.Date == date.Date
            //                  select batch.FinanceBatchNo;
            string dateStr = String.Format("{0:yyyMMdd}", date);
            var queryResult = from batch in context.InvoiceFinanceBatches
                              where batch.FinanceBatchNo.Contains(dateStr)
                              select batch.FinanceBatchNo;

            int batchCount;
            if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
            {
                batchCount = 0;
            }

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
            DBDataContext context = new DBDataContext();
            //var queryResult = from batch in context.InvoiceFinanceBatches
            //                  where batch.FinancePeriodBegin.Date == date.Date
            //                  select batch.FinanceBatchNo;
            string dateStr = String.Format("{0:yyyMMdd}", date);
            var queryResult = from batch in context.InvoiceFinanceBatches
                              where batch.FinanceBatchNo.Contains(dateStr)
                              select batch.FinanceBatchNo;

            int batchCount;
            if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
            {
                batchCount = 0;
            }

            batchCount += batchesInMemory.Count(batch => batch.FinanceBatchNo.Contains(dateStr));
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GenerateRefundBatchNo(DateTime date)
        {
            DBDataContext context = new DBDataContext();
            //var queryResult = from batch in context.InvoiceRefundBatches
            //                  where batch.RefundDate.Date == date.Date
            //                  select batch.RefundBatchNo;
            string dateStr = String.Format("{0:yyyMMdd}", date);
            var queryResult = from batch in context.InvoiceRefundBatches
                              where batch.RefundBatchNo.Contains(dateStr)
                              select batch.RefundBatchNo;

            int batchCount;
            if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
            {
                batchCount = 0;
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
            DBDataContext context = new DBDataContext();
            //var queryResult = from batch in context.InvoiceRefundBatches
            //                  where batch.RefundDate.Date == date.Date
            //                  select batch.RefundBatchNo;
            string dateStr = String.Format("{0:yyyMMdd}", date);
            var queryResult = from batch in context.InvoiceRefundBatches
                              where batch.RefundBatchNo.Contains(dateStr)
                              select batch.RefundBatchNo;

            int batchCount;
            if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
            {
                batchCount = 0;
            }

            batchCount += batchesInMemory.Count(batch => batch.RefundBatchNo.Contains(dateStr));
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(System.Data.Linq.ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {
                if (!InvoiceNoRegex.IsMatch(this.InvoiceNo))
                {
                    throw new Exception("不符合发票编码规则: " + this.InvoiceNo);
                }
            }
            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (this.FinanceAmount.HasValue)
                {
                    if (this.InvoiceFinanceBatch.BatchCurrency != this.InvoiceAssignBatch.BatchCurrency)
                    {
                        double rate = Exchange.GetExchangeRate(this.InvoiceFinanceBatch.BatchCurrency, this.InvoiceAssignBatch.BatchCurrency);
                        double financeAmount = rate * this.FinanceAmount.Value;
                        if (TypeUtil.GreaterZero(financeAmount - this.AssignAmount))
                        {
                            throw new Exception("融资金额不能大于转让金额: " + this.InvoiceNo);
                        }
                    }
                }

                if (TypeUtil.GreaterZero(this.PaymentAmount.GetValueOrDefault() - this.AssignAmount))
                {
                    throw new Exception("付款金额不能大于转让金额: " + this.InvoiceNo);
                }

                if (TypeUtil.GreaterZero(this.RefundAmount.GetValueOrDefault() - this.FinanceAmount.GetValueOrDefault()))
                {
                    throw new Exception("还款金额不能大于融资金额: " + this.InvoiceNo);
                }

                if (this.DueDate < this.InvoiceDate)
                {
                    throw new Exception("发票到期日不能早于发票日: " + this.InvoiceNo);
                }

                if (this.FinanceDueDate.GetValueOrDefault() < this.FinanceDate.GetValueOrDefault())
                {
                    throw new Exception("融资到期日不能早于融资日: " + this.InvoiceNo);
                }
            }
        }
    }
}

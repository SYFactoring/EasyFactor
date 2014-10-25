//-----------------------------------------------------------------------
// <copyright file="InvoiceRefundLog.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceRefundLog
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="financeLog"></param>
        public InvoiceRefundLog(InvoiceFinanceLog financeLog)
            : this()
        {
            AssignBatchNo2 = financeLog.Invoice.AssignBatchNo;
            InvoiceNo2 = financeLog.Invoice.InvoiceNo;
            FinanceLogID2 = financeLog.FinanceLogID;
            FinanceAmount2 = financeLog.FinanceAmount;
            FinanceOutstanding2 = financeLog.FinanceOutstanding;
            FinanceDate2 = financeLog.FinanceDate;
            InvoiceRefundAmount2 = financeLog.RefundAmount;
            InvoicePaymentAmount2 = financeLog.Invoice.PaymentAmount;
            RefundCurrency2 = financeLog.InvoiceFinanceBatch.BatchCurrency;
            FinanceRateType1 = financeLog.InvoiceFinanceBatch.FinanceRateType1;
            FinanceRateType2 = financeLog.InvoiceFinanceBatch.FinanceRateType2;
            FinanceRate = financeLog.InvoiceFinanceBatch.FinanceRate;
            FinancePeriodBegin = financeLog.InvoiceFinanceBatch.FinancePeriodBegin;
            ReassignDate = financeLog.ReassignDate;
            DirectPaymentOutstanding = financeLog.Invoice.DirectPaymentOutstanding;
            FinanceBatchNo = financeLog.FinanceBatchNo;
            PenaltyRate = financeLog.Invoice.InvoiceAssignBatch.Case.ActiveCDA.PenaltyInterestRate.GetValueOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? FinanceAmount
        {
            get
            {
                if (InvoiceFinanceLog != null)
                {
                    return InvoiceFinanceLog.FinanceAmount;
                }
                return FinanceAmount2;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? FinanceAmount2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDate
        {
            get
            {
                if (InvoiceFinanceLog != null)
                {
                    return InvoiceFinanceLog.FinanceDate;
                }
                return FinanceDate2;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDate2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int FinanceLogID2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? FinanceOutstanding
        {
            get { return InvoiceFinanceLog != null ? InvoiceFinanceLog.FinanceOutstanding : FinanceOutstanding2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? FinanceOutstanding2 { get; set; }

        public DateTime? ReassignDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string InvoiceNo
        {
            get { return InvoiceFinanceLog.Invoice.InvoiceNo; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string AssignBatchNo2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string InvoiceNo2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? InvoicePaymentAmount
        {
            get
            {
                if (InvoiceFinanceLog != null)
                {
                    return InvoiceFinanceLog.Invoice.PaymentAmount;
                }
                return InvoicePaymentAmount2;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? InvoicePaymentAmount2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? InvoiceRefundAmount
        {
            get
            {
                if (InvoiceFinanceLog != null)
                {
                    return InvoiceFinanceLog.RefundAmount;
                }
                return InvoiceRefundAmount2;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? InvoiceRefundAmount2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RefundCurrency
        {
            get
            {
                if (InvoiceFinanceLog != null)
                {
                    return InvoiceFinanceLog.InvoiceFinanceBatch.BatchCurrency;
                }
                return RefundCurrency2;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string RefundCurrency2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime RefundDate
        {
            get { return InvoiceRefundBatch.RefundDate; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (RefundAmount<0)
                {
                    throw new Exception(String.Format("还款金额{0:N2}不能为负: {1}", RefundAmount,
                                 RefundLogID));
                }
            }
        }

        public string FinanceRateType1 { get; set; }

        public string FinanceRateType2 { get; set; }

        public double FinanceRate { get; set; }

        public double PenaltyRate { get; set; }

        public DateTime FinancePeriodBegin { get; set; }

        public string FinanceBatchNo { get; set; }

        public decimal? DirectPaymentOutstanding
        {
            get;
            set;
        }

        public decimal CaculatePenaltyInterest()
        {
            decimal penaltyInterest = 0;
            DateTime? penaltyDate = null;
            if (DateTime.Today > ReassignDate.GetValueOrDefault())
            {
                penaltyDate = DateTime.Today;
            }
            if (penaltyDate.HasValue)
            {
                if (FinanceRateType2 == "计头不计尾")
                {
                    penaltyInterest = (decimal)(FinanceRate + PenaltyRate) * RefundAmount.GetValueOrDefault() * (penaltyDate.GetValueOrDefault() - ReassignDate.GetValueOrDefault()).Days / 360;
                }
                else if (FinanceRateType2 == "计头又计尾")
                {
                    penaltyInterest = (decimal)(FinanceRate + PenaltyRate) * RefundAmount.GetValueOrDefault() * ((penaltyDate.GetValueOrDefault() - ReassignDate.GetValueOrDefault()).Days + 1) / 360;
                }
            }

            if (RefundCurrency != "CNY")
            {
                decimal rate = Exchange.GetExchangeRate(RefundCurrency, "CNY");
                penaltyInterest *= rate;
            }
            return penaltyInterest;
        }

        public decimal? CaculateInterest()
        {
            decimal normalInterest = 0;

            DateTime normalDate;
            if (DateTime.Today <= ReassignDate.GetValueOrDefault())
            {
                normalDate = DateTime.Today;
            }
            else
            {
                normalDate = ReassignDate.GetValueOrDefault();
            }
            if (FinanceRateType2 == "计头不计尾")
            {
                normalInterest = (decimal)FinanceRate * RefundAmount.GetValueOrDefault() * (normalDate - FinancePeriodBegin.Date).Days / 360;
            }
            else if (FinanceRateType2 == "计头又计尾")
            {
                normalInterest = (decimal)FinanceRate * RefundAmount.GetValueOrDefault() * ((normalDate - FinancePeriodBegin.Date).Days + 1) / 360;
            }
            if (RefundCurrency != "CNY")
            {
                decimal rate = Exchange.GetExchangeRate(RefundCurrency, "CNY");
                normalInterest *= rate;
            }
            return normalInterest;
        }
    }
}
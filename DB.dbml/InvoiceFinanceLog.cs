//-----------------------------------------------------------------------
// <copyright file="InvoiceFinanceLog.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using System.Linq;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceFinanceLog
    {
        public InvoiceFinanceLog(Invoice invoice)
            : this()
        {
            AssignBatchNo2 = invoice.AssignBatchNo;
            InvoiceID2 = invoice.InvoiceID;
            InvoiceNo2 = invoice.InvoiceNo;
            InvoiceAmount2 = invoice.InvoiceAmount;
            AssignAmount2 = invoice.AssignAmount;
            AssignOutstanding2 = invoice.AssignOutstanding;
            InvoiceDate2 = invoice.InvoiceDate;
            DueDate2 = invoice.DueDate;
            AssignDate2 = invoice.AssignDate;
            InvoiceFinanceAmount2 = invoice.FinanceAmount;
            InvoiceFinanceOutstanding2 = invoice.FinanceOutstanding;
            ReassignDate = invoice.DueDate.AddDays(invoice.InvoiceAssignBatch.Case.ActiveCDA.ReassignGracePeriod.GetValueOrDefault());
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal AssignAmount
        {
            get { return Invoice != null ? Invoice.AssignAmount : AssignAmount2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal AssignAmount2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AssignBatchNo2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime AssignDate
        {
            get { return Invoice != null ? Invoice.AssignDate : AssignDate2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime AssignDate2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal AssignOutstanding
        {
            get { return Invoice != null ? Invoice.AssignOutstanding : AssignOutstanding2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal AssignOutstanding2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DueDate2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FinanceCurrency
        {
            get { return InvoiceFinanceBatch.BatchCurrency; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDate
        {
            get { return InvoiceFinanceBatch != null ? (DateTime?)InvoiceFinanceBatch.FinancePeriodBegin : null; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal FinanceOutstanding
        {
            get { return FinanceAmount.GetValueOrDefault() - RefundAmount.GetValueOrDefault(); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public int? FinanceOverDueDays
        {
            get
            {
                if (FinanceOutstanding>0)
                {
                    if (ReassignDate != null)
                    {
                        TimeSpan? duedays = DateTime.Today - ReassignDate;
                        return duedays.Value.Days;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? InvoiceDate
        {
            get { return Invoice != null ? Invoice.InvoiceDate : InvoiceDate2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? InvoiceDate2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? InvoiceFinanceAmount
        {
            get { return Invoice != null ? Invoice.FinanceAmount : InvoiceFinanceAmount2; }
        }

        public decimal? InvoiceFinanceAmount2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? InvoiceFinanceOutstanding
        {
            get { return Invoice != null ? Invoice.FinanceOutstanding : InvoiceFinanceOutstanding2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? InvoiceFinanceOutstanding2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int InvoiceID2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string InvoiceNo
        {
            get { return Invoice != null ? Invoice.InvoiceNo : InvoiceNo2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string InvoiceNo2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? RefundAmount
        {
            get { return InvoiceRefundLogs != null ? InvoiceRefundLogs.Sum(log => log.RefundAmount) : null; }
        }

        public decimal? DirectRefundAmount
        {
            get
            {
                return InvoiceRefundLogs.Where(log => log.InvoiceRefundBatch.RefundType == "买方直接付款").Sum(log => log.RefundAmount).GetValueOrDefault();
            }
        }

        //?Public?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        public void CaculateCommissionForFirstTime()
        {
            InvoiceAssignBatch assingBatch = Invoice.InvoiceAssignBatch;
            CDA cda = assingBatch.Case.ActiveCDA;

            if (assingBatch == null)
            {
                return;
            }

            if (assingBatch.CommissionType == "按融资金额")
            {
                if(assingBatch.CommissionPrePost=="先收")
                {
                    PaidCommission = Decimal.Round(FinanceAmount.GetValueOrDefault() * (decimal)cda.Price.GetValueOrDefault(), 2);
                }else if(assingBatch.CommissionPrePost=="后收")
                {
                    UnpaidCommission = Decimal.Round(FinanceAmount.GetValueOrDefault() * (decimal)cda.Price.GetValueOrDefault(), 2);
                }
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
                if (FinanceAmount<0)
                {
                    throw new Exception(String.Format("融资金额{0:N2}不能为负: {1}", FinanceAmount,
                                 FinanceLogID));
                }
            }
        }

        public decimal InvoiceAmount2 { get; set; }

        public decimal InvoiceAmount
        {
            get
            {
                if (Invoice != null)
                {
                    return Invoice.InvoiceAmount;
                }
                else
                {
                    return InvoiceAmount2;
                }
            }
        }

        public decimal? CurCommissionValue
        {
            set;
            get;
        }

        public decimal? CaculatePenaltyInterest()
        {
            decimal penaltyInterest = 0;
            DateTime? penaltyDate = null;
            if (DateTime.Today > ReassignDate.GetValueOrDefault())
            {
                penaltyDate = DateTime.Today;
            }
            if (penaltyDate.HasValue)
            {
                double PenaltyRate = Invoice.InvoiceAssignBatch.Case.ActiveCDA.PenaltyInterestRate.GetValueOrDefault();
                if (InvoiceFinanceBatch.FinanceRateType2 == "计头不计尾")
                {
                    penaltyInterest = (decimal)(InvoiceFinanceBatch.FinanceRate + PenaltyRate) * FinanceOutstanding * (penaltyDate.GetValueOrDefault() - ReassignDate.GetValueOrDefault()).Days / 360;
                }
                else if (InvoiceFinanceBatch.FinanceRateType2 == "计头又计尾")
                {
                    penaltyInterest = (decimal)(InvoiceFinanceBatch.FinanceRate + PenaltyRate) * FinanceOutstanding * ((penaltyDate.GetValueOrDefault() - ReassignDate.GetValueOrDefault()).Days + 1) / 360;
                }
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
            if (InvoiceFinanceBatch.FinanceRateType2 == "计头不计尾")
            {
                normalInterest = (decimal)InvoiceFinanceBatch.FinanceRate * FinanceOutstanding * (normalDate - InvoiceFinanceBatch.FinancePeriodBegin.Date).Days / 360;
            }
            else if (InvoiceFinanceBatch.FinanceRateType2 == "计头又计尾")
            {
                normalInterest = (decimal)InvoiceFinanceBatch.FinanceRate * FinanceOutstanding * ((normalDate - InvoiceFinanceBatch.FinancePeriodBegin.Date).Days + 1) / 360;
            }
            return normalInterest;
        }
    }
}
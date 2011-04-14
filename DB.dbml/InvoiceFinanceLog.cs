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
            AssignAmount2 = invoice.AssignAmount;
            AssignOutstanding2 = invoice.AssignOutstanding;
            InvoiceDate2 = invoice.InvoiceDate;
            DueDate2 = invoice.DueDate;
            AssignDate2 = invoice.AssignDate;
            InvoiceFinanceAmount2 = invoice.FinanceAmount;
            InvoiceFinanceOutstanding2 = invoice.FinanceOutstanding;
        }


        /// <summary>
        /// 
        /// </summary>
        public double AssignAmount
        {
            get { return Invoice != null ? Invoice.AssignAmount : AssignAmount2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double AssignAmount2 { get; set; }

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
        public double AssignOutstanding
        {
            get { return Invoice != null ? Invoice.AssignOutstanding : AssignOutstanding2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double AssignOutstanding2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DueDate
        {
            get { return Invoice != null ? Invoice.DueDate : DueDate2; }
        }

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
        public DateTime? FinanceDueDate
        {
            get { return InvoiceFinanceBatch != null ? (DateTime?)InvoiceFinanceBatch.FinancePeriodEnd : null; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double FinanceOutstanding
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
                if (TypeUtil.GreaterZero(FinanceOutstanding))
                {
                    if (FinanceDueDate != null)
                    {
                        TimeSpan duedays = DateTime.Now.Date - FinanceDueDate.Value;
                        return duedays.Days;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double GrossInterest
        {
            get
            {
                double interest = 0;

                if (InvoiceFinanceBatch != null)
                {
                    if (InvoiceFinanceBatch.FinanceType == "卖方代付" || InvoiceFinanceBatch.FinanceType == "买方代付")
                    {
                        int period =
                            (InvoiceFinanceBatch.FinancePeriodEnd - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                        interest = FinanceAmount.GetValueOrDefault() * InvoiceFinanceBatch.FinanceRate / 360 * period;
                    }
                    else
                    {
                        interest += (from refundLog in InvoiceRefundLogs
                                     let period = (refundLog.InvoiceRefundBatch.RefundDate - InvoiceFinanceBatch.FinancePeriodBegin).Days
                                     let overduePeriod = refundLog.InvoiceRefundBatch.RefundDate > InvoiceFinanceBatch.FinancePeriodEnd ? (refundLog.InvoiceRefundBatch.RefundDate - InvoiceFinanceBatch.FinancePeriodEnd).Days : 0
                                     select refundLog.RefundAmount.GetValueOrDefault() * InvoiceFinanceBatch.FinanceRate / 360 * (period + overduePeriod)).Sum();

                        if (TypeUtil.GreaterZero(FinanceOutstanding) &&
                            DateTime.Today > InvoiceFinanceBatch.FinancePeriodBegin)
                        {
                            int period = (DateTime.Today.Date - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                            int overduePeriod = DateTime.Today.Date > InvoiceFinanceBatch.FinancePeriodEnd
                                                    ? (DateTime.Today.Date - InvoiceFinanceBatch.FinancePeriodEnd).Days
                                                    : 0;
                            interest += FinanceAmount.GetValueOrDefault() * InvoiceFinanceBatch.FinanceRate / 360 *
                                        (period + overduePeriod);
                        }
                    }

                    if (InvoiceFinanceBatch.BatchCurrency != "CNY")
                    {
                        double rate = Exchange.GetExchangeRate(InvoiceFinanceBatch.BatchCurrency, "CNY");
                        interest *= rate;
                    }
                }

                return interest;
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
        public double? InvoiceFinanceAmount
        {
            get { return Invoice != null ? Invoice.FinanceAmount : InvoiceFinanceAmount2; }
        }

        public double? InvoiceFinanceAmount2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? InvoiceFinanceOutstanding
        {
            get { return Invoice != null ? Invoice.FinanceOutstanding : InvoiceFinanceOutstanding2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? InvoiceFinanceOutstanding2 { get; set; }

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
        public double NetInterest
        {
            get
            {
                double interest = 0;
                if (InvoiceFinanceBatch != null)
                {
                    if (InvoiceFinanceBatch.FinanceType == "卖方代付" || InvoiceFinanceBatch.FinanceType == "买方代付")
                    {
                        int period =
                            (InvoiceFinanceBatch.FinancePeriodEnd - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                        interest = FinanceAmount.GetValueOrDefault() *
                                   (InvoiceFinanceBatch.FinanceRate - InvoiceFinanceBatch.CostRate.GetValueOrDefault()) /
                                   360 * period;
                    }
                    else
                    {
                        interest += (from refundLog in InvoiceRefundLogs
                                     let period = (refundLog.InvoiceRefundBatch.RefundDate - InvoiceFinanceBatch.FinancePeriodBegin).Days
                                     let overduePeriod = refundLog.InvoiceRefundBatch.RefundDate > InvoiceFinanceBatch.FinancePeriodEnd ? (refundLog.InvoiceRefundBatch.RefundDate - InvoiceFinanceBatch.FinancePeriodEnd).Days : 0
                                     select refundLog.RefundAmount.GetValueOrDefault() * (InvoiceFinanceBatch.FinanceRate - InvoiceFinanceBatch.CostRate.GetValueOrDefault()) / 360 * (period + overduePeriod)).Sum();

                        if (TypeUtil.GreaterZero(FinanceOutstanding) &&
                            DateTime.Today > InvoiceFinanceBatch.FinancePeriodBegin)
                        {
                            int period = (DateTime.Today.Date - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                            int overduePeriod = DateTime.Today.Date > InvoiceFinanceBatch.FinancePeriodEnd
                                                    ? (DateTime.Today.Date - InvoiceFinanceBatch.FinancePeriodEnd).Days
                                                    : 0;
                            interest += FinanceAmount.GetValueOrDefault() *
                                        (InvoiceFinanceBatch.FinanceRate -
                                         InvoiceFinanceBatch.CostRate.GetValueOrDefault()) / 360 * (period + overduePeriod);
                        }
                    }

                    if (InvoiceFinanceBatch.BatchCurrency != "CNY")
                    {
                        double rate = Exchange.GetExchangeRate(InvoiceFinanceBatch.BatchCurrency, "CNY");
                        interest *= rate;
                    }
                }

                return interest;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? RefundAmount
        {
            get { return InvoiceRefundLogs != null ? InvoiceRefundLogs.Sum(log => log.RefundAmount) : null; }
        }

        //?Public?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        public void CaculateCommission()
        {
            CDA cda = Invoice.InvoiceAssignBatch.Case.ActiveCDA;

            if (cda == null)
            {
                return;
            }

            if (cda.CommissionType == "按融资金额")
            {
                Commission = TypeUtil.C1Round(FinanceAmount.GetValueOrDefault() * cda.Price.GetValueOrDefault(),2);
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
                if (TypeUtil.LessZero(FinanceAmount))
                {
                    throw new Exception(String.Format("融资金额{0:N2}不能为负: {1}", FinanceAmount,
                                 FinanceLogID));
                }
            }
        }
    }
}
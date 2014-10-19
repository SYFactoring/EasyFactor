//-----------------------------------------------------------------------
// <copyright file="Invoice.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text.RegularExpressions;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Invoice
    {
        public static readonly Regex INVOICE_NO_REGEX = new Regex("^[a-zA-Z0-9]+[a-zA-Z0-9\\-<>\\.\\(\\)/]+$");


        /// <summary>
        /// Gets
        /// </summary>
        public DateTime AssignDate
        {
            get { return InvoiceAssignBatch.AssignDate; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public decimal AssignOutstanding
        {
            get { return AssignAmount - PaymentAmount.GetValueOrDefault(); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public int? AssignOverDueDays
        {
            get
            {
                if (AssignOutstanding > 0)
                {
                    return (DateTime.Now.Date - DueDate).Days;
                }

                return null;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerName
        {
            get { return InvoiceAssignBatch.Case.BuyerClient.ToString(); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string FactorName
        {
            get { return InvoiceAssignBatch.Case.Factor.ToString(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string FinanceBatchNos
        {
            get
            {
                if (InvoiceFinanceLogs.Count > 0)
                {
                    var batches = new List<string>();
                    foreach (InvoiceFinanceLog log in InvoiceFinanceLogs)
                    {
                        if (!batches.Contains(log.FinanceBatchNo))
                        {
                            batches.Add(log.FinanceBatchNo);
                        }
                    }

                    return String.Join(";", batches.ToArray());
                }
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public decimal? FinanceOutstanding
        {
            get
            {
                if (!FinanceAmount.HasValue)
                {
                    return null;
                }

                return FinanceAmount.Value - RefundAmount.GetValueOrDefault();
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public int? FinanceOverDueDays
        {
            get
            {
                if (FinanceOutstanding > 0)
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
        //public decimal GrossInterest
        //{
        //    get
        //    {
        //        return InvoiceFinanceLogs.Sum(financeLog => financeLog.GrossInterest);
        //    }
        //}

        /// <summary>
        /// Gets
        /// </summary>
        public string InvoiceCurrency
        {
            get { return InvoiceAssignBatch.Case.InvoiceCurrency; }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<InvoiceFinanceBatch> InvoiceFinanceBatches
        {
            get
            {
                var result = new List<InvoiceFinanceBatch>();
                foreach (InvoiceFinanceLog log in InvoiceFinanceLogs)
                {
                    if (!result.Contains(log.InvoiceFinanceBatch))
                    {
                        result.Add(log.InvoiceFinanceBatch);
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<InvoicePaymentBatch> InvoicePaymentBatches
        {
            get
            {
                var result = new List<InvoicePaymentBatch>();
                foreach (InvoicePaymentLog log in InvoicePaymentLogs)
                {
                    if (!result.Contains(log.InvoicePaymentBatch))
                    {
                        result.Add(log.InvoicePaymentBatch);
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<InvoiceRefundBatch> InvoiceRefundBatches
        {
            get
            {
                var result = new List<InvoiceRefundBatch>();
                foreach (InvoiceFinanceLog flog in InvoiceFinanceLogs)
                {
                    foreach (InvoiceRefundLog rlog in flog.InvoiceRefundLogs)
                    {
                        if (!result.Contains(rlog.InvoiceRefundBatch))
                        {
                            result.Add(rlog.InvoiceRefundBatch);
                        }
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// 是否结清
        /// </summary>
        public bool IsClear
        {
            get { return AssignOutstanding == 0 && (FinanceOutstanding.HasValue == false || FinanceOutstanding == 0); }
        }

        /// <summary>
        /// 是否已发转让报文
        /// </summary>
        public bool? IsSendAssignMsg
        {
            get { return InvoiceAssignBatch.IsSendMsg; }
        }

        /// <summary>
        /// 是否已发付款报文
        /// </summary>
        public bool? IsSendPaymentMsg
        {
            get
            {
                bool? result = null;
                foreach (InvoicePaymentBatch batch in InvoicePaymentBatches)
                {
                    if (batch.IsSendMsg.HasValue)
                    {
                        result = batch.IsSendMsg;
                        if (result.Value)
                        {
                            return true;
                        }
                    }
                }

                return result;
            }
        }

        public decimal? CurCommissionValue
        {
            get;
            set;
        }

        public decimal Interest
        {
            get
            {
                decimal financeInterest = InvoiceFinanceLogs.Sum(financeLog => financeLog.Interest.GetValueOrDefault());
                decimal refundInterest = InvoiceFinanceLogs.Sum(financeLog => financeLog.InvoiceRefundLogs.Sum(refundLog => refundLog.Interest.GetValueOrDefault()));
                return financeInterest + refundInterest;
            }
        }

        public decimal UnpaidInterest
        {
            get
            {
                var financeLogs =  InvoiceFinanceLogs.Where(log => log.InvoiceFinanceBatch.FinanceRateType1 == "后收息" && log.FinanceOutstanding>0);
                decimal unpaidInterest=0;
                foreach(InvoiceFinanceLog log in financeLogs){
                    if (log.InvoiceFinanceBatch.FinanceRateType2 == "计头不计尾")
                    {
                        unpaidInterest += log.FinanceOutstanding * (decimal)log.InvoiceFinanceBatch.FinanceRate * (DateTime.Today - log.InvoiceFinanceBatch.FinancePeriodBegin).Days / 360;
                    }
                    else if (log.InvoiceFinanceBatch.FinanceRateType2 == "计头又计尾")
                    {
                        unpaidInterest += log.FinanceOutstanding * (decimal)log.InvoiceFinanceBatch.FinanceRate * ((DateTime.Today - log.InvoiceFinanceBatch.FinancePeriodBegin).Days+1) / 360;
                    }
                        
                }

                return unpaidInterest;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string PaymentBatchNos
        {
            get
            {
                var batches = new List<string>();
                foreach (InvoicePaymentLog log in InvoicePaymentLogs)
                {
                    if (!batches.Contains(log.PaymentBatchNo))
                    {
                        batches.Add(log.PaymentBatchNo);
                    }
                }

                return batches.Count > 0 ? String.Join(";", batches.ToArray()) : string.Empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string RefundBatchNos
        {
            get
            {
                var batches = new List<string>();
                foreach (InvoiceFinanceLog financeLog in InvoiceFinanceLogs)
                {
                    foreach (InvoiceRefundLog log in financeLog.InvoiceRefundLogs)
                    {
                        if (!batches.Contains(log.RefundBatchNo))
                        {
                            batches.Add(log.RefundBatchNo);
                        }
                    }
                }

                return batches.Count > 0 ? String.Join(";", batches.ToArray()) : string.Empty;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerName
        {
            get { return InvoiceAssignBatch.Case.SellerClient.ToString(); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string TransactionType
        {
            get { return InvoiceAssignBatch.Case.TransactionType; }
        }

        public DateTime ReassignDate
        {
            get
            {
                if (this.InvoiceAssignBatch.Case.ActiveCDA != null)
                {
                    return DueDate.AddDays(this.InvoiceAssignBatch.Case.ActiveCDA.ReassignGracePeriod.GetValueOrDefault());
                }
                else
                {
                    return DueDate;
                }
            }
        }

        //?Public?Methods?(6)?
        /// <summary>
        /// 
        /// </summary>
        public void CaculateCommissionForFirstTime()
        {
            if (InvoiceAssignBatch != null)
            {
                CDA cda = InvoiceAssignBatch.Case.ActiveCDA;

                if (cda == null)
                {
                    throw new Exception("发票:" + this.InvoiceNo + "没有有效的额度通知书");
                }

                if (cda.CommissionType == "按融资金额")
                {
                    foreach (InvoiceFinanceLog log in InvoiceFinanceLogs)
                    {
                        log.CaculateCommissionForFirstTime();
                    }

                    PaidCommission = Decimal.Round(InvoiceFinanceLogs.Sum(log => log.PaidCommission).GetValueOrDefault(), 2);
                    UnpaidCommission = Decimal.Round(InvoiceFinanceLogs.Sum(log => log.UnpaidCommission).GetValueOrDefault(), 2);
                }
                else if (cda.CommissionType == "按转让金额")
                {
                    if (InvoiceAssignBatch.CommissionPrePost == "先收")
                    {
                        PaidCommission = Decimal.Round(AssignAmount * (decimal)cda.Price.GetValueOrDefault(), 2);
                    }
                    else if (InvoiceAssignBatch.CommissionPrePost == "后收")
                    {
                        UnpaidCommission = Decimal.Round(AssignAmount * (decimal)cda.Price.GetValueOrDefault(), 2);
                    }
                    if (TransactionType == "出口保理")
                    {
                        FactorCommission = Decimal.Round(AssignAmount * (decimal)cda.IFPrice.GetValueOrDefault(), 2);
                    }
                    else if (TransactionType == "进口保理")
                    {
                        FactorCommission = Decimal.Round(AssignAmount * (decimal)cda.EFPrice.GetValueOrDefault(), 2);
                    }
                }
            }
        }

        //?Public?Methods?(6)?
        /// <summary>
        /// 
        /// </summary>
        public void CaculateCommission()
        {
            if (InvoiceAssignBatch != null)
            {
                CDA cda = InvoiceAssignBatch.Case.ActiveCDA;

                if (cda == null)
                {
                    throw new Exception("发票:" + this.InvoiceNo + "没有有效的额度通知书");
                }

                if (cda.CommissionType == "按融资金额")
                {
                    PaidCommission = Decimal.Round(InvoiceFinanceLogs.Sum(log => log.PaidCommission).GetValueOrDefault(), 2);
                    UnpaidCommission = Decimal.Round(InvoiceFinanceLogs.Sum(log => log.UnpaidCommission).GetValueOrDefault(), 2);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void CaculateFinance()
        {
            if (InvoiceFinanceLogs.Count > 0)
            {
                FinanceAmount = 0;

                foreach (InvoiceFinanceLog log in InvoiceFinanceLogs)
                {
                    decimal finance = log.FinanceAmount.GetValueOrDefault();
                    if (log.InvoiceFinanceBatch.BatchCurrency != InvoiceCurrency)
                    {
                        decimal rate = Exchange.GetExchangeRate(log.InvoiceFinanceBatch.BatchCurrency, InvoiceCurrency);
                        finance *= rate;
                    }

                    FinanceAmount += finance;
                }
            }
            else
            {
                FinanceAmount = null;
                FinanceDate = null;
                FinanceDueDate = null;
                PaidCommission = null;
            }

            CaculateCommission();

            CaculateFinanceDate();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CaculateFinanceDate()
        {
            if (InvoiceFinanceLogs.Count > 0)
            {
                var financeDates = from log in InvoiceFinanceLogs
                                   where log.FinanceOutstanding > 0
                                   select log.InvoiceFinanceBatch.FinancePeriodBegin;
                if (financeDates.Count() > 0)
                {
                    FinanceDate = financeDates.Min();
                }

                var financeDueDates = from log in InvoiceFinanceLogs
                                      where log.FinanceOutstanding > 0
                                      select log.FinanceDueDate;
                if (financeDueDates.Count() > 0)
                {
                    FinanceDueDate = financeDueDates.Min();
                }
            }
            else
            {
                FinanceDate = null;
                FinanceDueDate = null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void CaculatePayment()
        {
            PaymentAmount = InvoicePaymentLogs.Count > 0 ? InvoicePaymentLogs.Sum(log => log.PaymentAmount) : null;

            CaculatePaymentDate();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CaculatePaymentDate()
        {
            if (InvoicePaymentLogs.Count > 0)
            {
                PaymentDate = InvoicePaymentLogs.Max(log => log.InvoicePaymentBatch.PaymentDate);
            }
            else
            {
                PaymentDate = null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void CaculateRefund()
        {
            if (InvoiceFinanceLogs.Count > 0)
            {
                decimal refundAmount = 0;
                foreach (InvoiceFinanceLog financeLog in InvoiceFinanceLogs)
                {
                    decimal refund = financeLog.InvoiceRefundLogs.Sum(refundLog => refundLog.RefundAmount.GetValueOrDefault());

                    if (financeLog.InvoiceFinanceBatch.BatchCurrency != InvoiceCurrency)
                    {
                        decimal rate = Exchange.GetExchangeRate(financeLog.InvoiceFinanceBatch.BatchCurrency,
                                                               InvoiceCurrency);
                        refund *= rate;
                    }

                    refundAmount += refund;
                }

                if (refundAmount > 0)
                {
                    RefundAmount = refundAmount;
                }
                else
                {
                    RefundAmount = null;
                }
            }
            else
            {
                RefundAmount = null;
            }

            CaculateRefundDate();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CaculateRefundDate()
        {
            if (InvoiceFinanceLogs.Count > 0)
            {
                DateTime maxDate = default(DateTime);
                foreach (InvoiceFinanceLog financeLog in InvoiceFinanceLogs)
                {
                    if (financeLog.InvoiceRefundLogs.Count > 0)
                    {
                        DateTime maxDate2 = financeLog.InvoiceRefundLogs.Max(log => log.InvoiceRefundBatch.RefundDate);
                        if (maxDate2 > maxDate)
                        {
                            maxDate = maxDate2;
                        }
                    }
                }

                if (maxDate != default(DateTime))
                {
                    RefundDate = maxDate;
                }
                else
                {
                    RefundDate = null;
                }
            }
            else
            {
                RefundDate = null;
            }

            CaculateFinanceDate();
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

            var right = obj as Invoice;
            if (right == null)
            {
                return false;
            }

            return GetHashCode() == right.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return InvoiceNo != null ? InvoiceNo.GetHashCode() : -1;
        }

        //?Private?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {
                if (!INVOICE_NO_REGEX.IsMatch(InvoiceNo))
                {
                    throw new Exception("不符合发票编码规则: " + InvoiceNo);
                }
            }
            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (InvoiceAmount < 0)
                {
                    throw new Exception(String.Format("票面金额{0:N2}不能为负: {1}", InvoiceAmount,
                                                      InvoiceNo));
                }

                if (AssignAmount < 0)
                {
                    throw new Exception(String.Format("转让金额{0:N2}不能为负: {1}", AssignAmount,
                                                      InvoiceNo));
                }

                if (FinanceAmount < 0)
                {
                    throw new Exception(String.Format("融资金额{0:N2}不能为负: {1}", FinanceAmount,
                                                     InvoiceNo));
                }

                if (PaymentAmount < 0)
                {
                    throw new Exception(String.Format("付款金额{0:N2}不能为负: {1}", PaymentAmount,
                                                     InvoiceNo));
                }

                if (RefundAmount < 0)
                {
                    throw new Exception(String.Format("还款金额{0:N2}不能为负: {1}", RefundAmount,
                                                     InvoiceNo));
                }

                if (PaidCommission < 0)
                {
                    throw new Exception(String.Format("手续费金额{0:N2}不能为负: {1}", PaidCommission,
                                                     InvoiceNo));
                }

                if (FactorCommission < 0)
                {
                    throw new Exception(String.Format("保理商手续费金额{0:N2}不能为负: {1}", FactorCommission,
                                                     InvoiceNo));
                }

                if (TypeUtil.GreaterThan(AssignAmount,InvoiceAmount))
                {
                    throw new Exception(String.Format("转让金额{0:N2}不能大于票面金额{1:N2}: {2}", AssignAmount, InvoiceAmount,
                                                      InvoiceNo));
                }

                if (FinanceAmount.HasValue)
                {
                    if (TypeUtil.GreaterThan(FinanceAmount , AssignAmount))
                    {
                        throw new Exception(String.Format("融资金额{0:N2}不能大于转让金额{1:N2}: {2}", FinanceAmount, AssignAmount,
                                                          InvoiceNo));
                    }
                }

                if (TypeUtil.GreaterThan(PaymentAmount, AssignAmount))
                {
                    throw new Exception(String.Format("付款金额{0:N2}不能大于转让金额{1:N2}: {2}", PaymentAmount, AssignAmount,
                                                      InvoiceNo));
                }

                if (TypeUtil.GreaterThan(RefundAmount, FinanceAmount))
                {
                    throw new Exception(String.Format("还款金额{0:N2}不能大于融资金额{1:N2}: {2}", RefundAmount, FinanceAmount,
                                                      InvoiceNo));
                }

                if (InvoiceDate != null && DueDate < InvoiceDate)
                {
                    throw new Exception(String.Format("发票到期日{0:d}不能早于发票日{1:d}: {2}", DueDate, InvoiceDate, InvoiceNo));
                }

                if (FinanceDueDate.GetValueOrDefault() < FinanceDate.GetValueOrDefault())
                {
                    throw new Exception(String.Format("融资到期日{0:d}不能早于融资日{1:d}: {2}", FinanceDueDate, FinanceDate,
                                                      InvoiceNo));
                }

                if (InvoiceAssignBatch.Case.NetPaymentTerm.HasValue)
                {
                    if (InvoiceDate != null &&
                        InvoiceAssignBatch.AssignDate >
                        InvoiceDate.Value.AddDays(InvoiceAssignBatch.Case.NetPaymentTerm.Value))
                    {
                        throw new Exception(String.Format("转让日{0:d}不能晚于发票日{1:d}+付款期限{2}: {3}",
                                                          InvoiceAssignBatch.AssignDate, InvoiceDate,
                                                          InvoiceAssignBatch.Case.NetPaymentTerm, InvoiceNo));
                    }
                }
            }
        }
    }
}
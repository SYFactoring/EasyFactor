//-----------------------------------------------------------------------
// <copyright file="Invoice.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Data.Linq;
    using System.Linq;
    using System.Text.RegularExpressions;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class Invoice
    {
        #region?Fields?(1)?

        public static readonly Regex InvoiceNoRegex = new Regex("^[a-zA-Z0-9]+[a-zA-Z0-9\\-<>\\.\\(\\)/]+$");

        #endregion?Fields?

        #region?Properties?(18)?

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
        public int? AssignOverDueDays
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
                return this.InvoiceAssignBatch.Case.BuyerClient.ToString();
            }
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
        /// 
        /// </summary>
        public string FinanceBatchNos
        {
            get
            {
                if (this.InvoiceFinanceLogs.Count > 0)
                {
                    List<string> batches = new List<string>();
                    foreach (InvoiceFinanceLog log in this.InvoiceFinanceLogs)
                    {
                        if (!batches.Contains(log.FinanceBatchNo))
                        {
                            batches.Add(log.FinanceBatchNo);
                        }
                    }

                    return String.Join(";", batches.ToArray());

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
        public double GrossInterest
        {
            get
            {
                double result = 0;
                foreach (InvoiceFinanceLog financeLog in this.InvoiceFinanceLogs)
                {
                    result += financeLog.GrossInterest;
                }

                return result;
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
        /// 
        /// </summary>
        public List<InvoiceFinanceBatch> InvoiceFinanceBatches
        {
            get
            {
                List<InvoiceFinanceBatch> result = new List<InvoiceFinanceBatch>();
                foreach (InvoiceFinanceLog log in this.InvoiceFinanceLogs)
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
                List<InvoicePaymentBatch> result = new List<InvoicePaymentBatch>();
                foreach (InvoicePaymentLog log in this.InvoicePaymentLogs)
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
                List<InvoiceRefundBatch> result = new List<InvoiceRefundBatch>();
                foreach (InvoiceFinanceLog flog in this.InvoiceFinanceLogs)
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
        /// 
        /// </summary>
        public double NetInterest
        {
            get
            {
                double result = 0;
                foreach (InvoiceFinanceLog financeLog in this.InvoiceFinanceLogs)
                {
                    result += financeLog.NetInterest;
                }

                return result;
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
        /// 
        /// </summary>
        public string RefundBatchNos
        {
            get
            {
                List<string> batches = new List<string>();
                foreach (InvoiceFinanceLog financeLog in this.InvoiceFinanceLogs)
                {
                    foreach (InvoiceRefundLog log in financeLog.InvoiceRefundLogs)
                    {
                        if (!batches.Contains(log.RefundBatchNo))
                        {
                            batches.Add(log.RefundBatchNo);
                        }
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

        #endregion?Properties?

        #region?Methods?(7)?

        //?Public?Methods?(6)?

        /// <summary>
        /// 
        /// </summary>
        public void CaculateCommission(bool isOverwrite)
        {
            if (this.InvoiceAssignBatch != null)
            {
                CDA cda = this.InvoiceAssignBatch.Case.ActiveCDA;

                if (cda == null)
                {
                    return;
                }

                if (cda.CommissionType == "�����ʽ��")
                {
                    if (isOverwrite)
                    {
                        foreach (InvoiceFinanceLog log in this.InvoiceFinanceLogs)
                        {
                            log.CaculateCommission();
                        }
                    }

                    Commission = this.InvoiceFinanceLogs.Sum(log => log.Commission);
                }
                else if (cda.CommissionType == "��ת�ý��")
                {
                    if (!TypeUtil.GreaterZero(this.Commission) || isOverwrite)
                    {
                        Commission = AssignAmount * cda.Price.GetValueOrDefault();
                    }
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

                foreach (InvoiceFinanceLog log in this.InvoiceFinanceLogs)
                {
                    double finance = log.FinanceAmount.GetValueOrDefault();
                    if (log.InvoiceFinanceBatch.BatchCurrency != this.InvoiceCurrency)
                    {
                        double rate = Exchange.GetExchangeRate(log.InvoiceFinanceBatch.BatchCurrency, this.InvoiceCurrency);
                        finance *= rate;
                    }

                    FinanceAmount += finance;
                }

                FinanceDate = InvoiceFinanceLogs.Min(log => log.InvoiceFinanceBatch.FinancePeriodBegin);
                FinanceDueDate = InvoiceFinanceLogs.Min(log => log.InvoiceFinanceBatch.FinancePeriodEnd);
            }
            else
            {
                FinanceAmount = null;
                FinanceDate = null;
                FinanceDueDate = null;
                Commission = null;
            }

            CaculateCommission(false);

            this.CaculateFinanceDate();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CaculateFinanceDate()
        {
            if (InvoiceFinanceLogs.Count > 0)
            {
                FinanceDate = InvoiceFinanceLogs.Min(log => log.InvoiceFinanceBatch.FinancePeriodBegin);
                FinanceDueDate = InvoiceFinanceLogs.Min(log => log.InvoiceFinanceBatch.FinancePeriodEnd);
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
            if (InvoicePaymentLogs.Count > 0)
            {
                PaymentAmount = InvoicePaymentLogs.Sum(log => log.PaymentAmount);
            }
            else
            {
                PaymentAmount = null;
            }

            this.CaculatePaymentDate();
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
                double refundAmount = 0;
                foreach (InvoiceFinanceLog financeLog in this.InvoiceFinanceLogs)
                {
                    double refund = 0;
                    foreach (InvoiceRefundLog refundLog in financeLog.InvoiceRefundLogs)
                    {
                        refund += refundLog.RefundAmount.GetValueOrDefault();
                    }

                    if (financeLog.InvoiceFinanceBatch.BatchCurrency != this.InvoiceCurrency)
                    {
                        double rate = Exchange.GetExchangeRate(financeLog.InvoiceFinanceBatch.BatchCurrency, this.InvoiceCurrency);
                        refund *= rate;
                    }

                    refundAmount += refund;
                }

                if (TypeUtil.GreaterZero(refundAmount))
                {
                    this.RefundAmount = refundAmount;
                }
                else
                {
                    this.RefundAmount = null;
                }
            }
            else
            {
                RefundAmount = null;
            }

            this.CaculateRefundDate();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CaculateRefundDate()
        {
            if (InvoiceFinanceLogs.Count > 0)
            {
                DateTime maxDate = default(DateTime);
                foreach (InvoiceFinanceLog financeLog in this.InvoiceFinanceLogs)
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
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.InvoiceNo.GetHashCode();
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
                if (!InvoiceNoRegex.IsMatch(this.InvoiceNo))
                {
                    throw new Exception("�����Ϸ�Ʊ�������: " + this.InvoiceNo);
                }
            }
            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (this.AssignAmount > this.InvoiceAmount)
                {
                    throw new Exception(String.Format("ת�ý��{0:N2}���ܴ���Ʊ����{1:N2}: {2}", this.AssignAmount, this.InvoiceAmount, this.InvoiceNo));
                }

                if (this.FinanceAmount.HasValue)
                {
                    if (TypeUtil.GreaterZero(this.FinanceAmount - this.AssignAmount))
                    {
                        throw new Exception(String.Format("���ʽ��{0:N2}���ܴ���ת�ý��{1:N2}: {2}", this.FinanceAmount, this.AssignAmount, this.InvoiceNo));
                    }
                }

                if (TypeUtil.GreaterZero(this.PaymentAmount.GetValueOrDefault() - this.AssignAmount))
                {
                    throw new Exception(String.Format("������{0:N2}���ܴ���ת�ý��{1:N2}: {2}", this.PaymentAmount, this.AssignAmount, this.InvoiceNo));
                }

                if (TypeUtil.GreaterZero(this.RefundAmount.GetValueOrDefault() - this.FinanceAmount.GetValueOrDefault()))
                {
                    throw new Exception(String.Format("������{0:N2}���ܴ������ʽ��{1:N2}: {2}", this.RefundAmount, this.FinanceAmount, this.InvoiceNo));
                }

                if (this.InvoiceDate != null && this.DueDate < this.InvoiceDate)
                {
                    throw new Exception(String.Format("��Ʊ������{0:d}�������ڷ�Ʊ��{1:d}: {2}", this.DueDate, this.InvoiceDate, this.InvoiceNo));
                }

                if (this.FinanceDueDate.GetValueOrDefault() < this.FinanceDate.GetValueOrDefault())
                {
                    throw new Exception(String.Format("���ʵ�����{0:d}��������������{1:d}: {2}", this.FinanceDueDate, this.FinanceDate, this.InvoiceNo));
                }

                if (this.InvoiceAssignBatch.Case.NetPaymentTerm.HasValue)
                {
                    if (InvoiceDate != null && this.InvoiceAssignBatch.AssignDate > InvoiceDate.Value.AddDays(this.InvoiceAssignBatch.Case.NetPaymentTerm.Value))
                    {
                        throw new Exception(String.Format("ת����{0:d}�������ڷ�Ʊ��{1:d}+��������{2}: {3}", this.InvoiceAssignBatch.AssignDate, this.InvoiceDate, this.InvoiceAssignBatch.Case.NetPaymentTerm, this.InvoiceNo));
                    }
                }
            }
        }

        #endregion?Methods?
    }
}

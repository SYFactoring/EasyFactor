﻿//-----------------------------------------------------------------------
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
        #region Fields (1)

        private static Regex InvoiceNoRegex = new Regex("^[a-zA-Z0-9]+[a-zA-Z0-9\\-<>\\.]+$");

        #endregion Fields

        #region Properties (15)

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

        #endregion Properties

        #region Methods (5)

        // Public Methods (5) 

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
                CommissionDate = null;
            }

            CaculateCommission();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CaculateCommission()
        {
            if (!TypeUtil.GreaterZero(this.Commission))
            {
                if (this.InvoiceAssignBatch.Case.ActiveCDA.CommissionType == "按融资金额")
                {
                    Commission = FinanceAmount * this.InvoiceAssignBatch.Case.ActiveCDA.Price.GetValueOrDefault();
                    if (TypeUtil.GreaterZero(Commission))
                    {
                        CommissionDate = FinanceDate;
                    }
                    else
                    {
                        CommissionDate = null;
                    }
                }
                else if (this.InvoiceAssignBatch.Case.ActiveCDA.CommissionType == "按转让金额")
                {
                    Commission = AssignAmount * this.InvoiceAssignBatch.Case.ActiveCDA.Price.GetValueOrDefault();
                    if (TypeUtil.GreaterZero(Commission))
                    {
                        CommissionDate = AssignDate;
                    }
                    else
                    {
                        CommissionDate = null;
                    }
                }
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
            if (InvoiceFinanceLogs.Count > 0)
            {
                RefundAmount = 0;
                DateTime maxDate = default(DateTime);
                foreach (InvoiceFinanceLog financeLog in this.InvoiceFinanceLogs)
                {
                    double refund = 0;
                    foreach (InvoiceRefundLog refundLog in financeLog.InvoiceRefundLogs)
                    {
                        refund += refundLog.RefundAmount;
                    }

                    if (financeLog.InvoiceFinanceBatch.BatchCurrency != this.InvoiceCurrency)
                    {
                        double rate = Exchange.GetExchangeRate(financeLog.InvoiceFinanceBatch.BatchCurrency, this.InvoiceCurrency);
                        refund *= rate;
                    }

                    RefundAmount += refund;
                    DateTime maxDate2 = financeLog.InvoiceRefundLogs.Max(log => log.InvoiceRefundBatch.RefundDate);
                    if (maxDate2 > maxDate)
                    {
                        maxDate = maxDate2;
                    }
                }

                RefundDate = maxDate;
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
                    if (TypeUtil.GreaterZero(this.FinanceAmount - this.AssignAmount))
                    {
                        throw new Exception("融资金额不能大于转让金额: " + this.InvoiceNo);
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

//-----------------------------------------------------------------------
// <copyright file="InvoiceFinanceBatch.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Data.Linq;
    using System.Linq;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceFinanceBatch
    {
        #region?Fields?(6)?

        private double? _assignAmount;
        private double? _commissionAmount;
        private double? _grossInterestIncome;
        private double? _handfeeAmount;
        private double? _marginIncome;
        private double? _netInterestIncome;

        #endregion?Fields?

        #region?Properties?(14)?

        /// <summary>
        /// Gets
        /// </summary>
        public double AssignAmount
        {
            get
            {
                if (_assignAmount.HasValue == false)
                {
                    double result = 0;
                    foreach (InvoiceFinanceLog log in this.InvoiceFinanceLogs)
                    {
                        result += log.Invoice.AssignAmount;
                    }

                    _assignAmount = result;
                }

                return _assignAmount.Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int AssignCount
        {
            get
            {
                return GetInvoices().Count;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public DateTime AssignDate
        {
            get
            {
                if (this.InvoiceFinanceLogs.Count > 0)
                {
                    return this.InvoiceFinanceLogs[0].Invoice.AssignDate;
                }
                else
                {
                    return default(DateTime);
                }
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public int BatchCount
        {
            get
            {
                return this.InvoiceFinanceLogs.Count;
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
        public double? CommissionAmount
        {
            get
            {
                if (_commissionAmount.HasValue == false)
                {
                    double? result = null;
                    foreach (InvoiceFinanceLog log in this.InvoiceFinanceLogs)
                    {
                        if (log.Commission.HasValue)
                        {
                            if (result.HasValue == false)
                            {
                                result = 0;
                            }

                            result += log.Commission;
                        }
                    }

                    if (this.BatchCurrency != this.Case.InvoiceCurrency)
                    {
                        double rate = Exchange.GetExchangeRate(this.BatchCurrency, this.Case.InvoiceCurrency);
                        result *= rate;
                    }

                    _commissionAmount = result;
                }

                return _commissionAmount;
            }
        }

        /// <summary>
        /// 毛利息收入
        /// </summary>
        public double GrossInterestIncome
        {
            get
            {
                if (_grossInterestIncome.HasValue == false)
                {
                    double result = 0;
                    foreach (InvoiceFinanceLog log in this.InvoiceFinanceLogs)
                    {
                        double value = log.GrossInterest;
                        result += value;
                    }

                    _grossInterestIncome = result;
                }

                return _grossInterestIncome.Value;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double? HandfeeAmount
        {
            get
            {
                if (_handfeeAmount.HasValue == false)
                {
                    double? result = AssignCount * this.Case.ActiveCDA.HandFee;
                    if (this.Case.ActiveCDA.HandFeeCurr != this.Case.InvoiceCurrency)
                    {
                        double rate = Exchange.GetExchangeRate(this.Case.ActiveCDA.HandFeeCurr, this.Case.InvoiceCurrency);
                        result *= rate;
                    }

                    _handfeeAmount = result;
                }

                return _handfeeAmount;
            }
        }

        /// <summary>
        /// 代付利差收入
        /// </summary>
        public double? MarginIncome
        {
            get
            {
                if (_marginIncome.HasValue == false)
                {
                    _marginIncome = this.FinanceAmount * (this.FinanceRate - this.CostRate) / 360 * ((this.FinancePeriodEnd - this.FinancePeriodBegin).Days);
                }

                return _marginIncome;
            }
        }

        /// <summary>
        /// 净利息收入
        /// </summary>
        public double NetInterestIncome
        {
            get
            {
                if (_netInterestIncome.HasValue == false)
                {
                    double result = 0;
                    foreach (InvoiceFinanceLog log in this.InvoiceFinanceLogs)
                    {
                        double value = log.NetInterest;
                        result += value;
                    }

                    _netInterestIncome = result;
                }

                return _netInterestIncome.Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double PoolFinanceOutstanding
        {
            get
            {
                return this.FinanceAmount - PoolRefundAmount.GetValueOrDefault();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? PoolRefundAmount
        {
            get
            {
                if (this.InvoiceRefundBatches != null)
                {
                    return this.InvoiceRefundBatches.Sum(batch => batch.RefundAmount);
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
        public string SellerName
        {
            get
            {
                if (this.Case != null && this.Case.SellerClient != null)
                {
                    return this.Case.SellerClient.ToString();
                }
                else if (this.Client != null)
                {
                    return this.Client.ToString();
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
        public string TransactionType
        {
            get
            {
                return this.Case.TransactionType;
            }
        }

        #endregion?Properties?

        #region?Methods?(4)?

        //?Public?Methods?(3)?

        /// <summary>
        /// 
        /// </summary>
        public void CaculateFinanceAmount()
        {
            this.FinanceAmount = this.InvoiceFinanceLogs.Sum(log => log.FinanceAmount.GetValueOrDefault());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GenerateFinanceBatchNo(DateTime date)
        {
            string dateStr = String.Format("{0:yyyMMdd}", date);
            int batchCount;
            using (DBDataContext context = new DBDataContext())
            {
                var queryResult = from batch in context.InvoiceFinanceBatches
                                  where batch.FinanceBatchNo.Contains(dateStr)
                                  select batch.FinanceBatchNo;

                if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
                {
                    batchCount = 0;
                }
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
            string dateStr = String.Format("{0:yyyMMdd}", date);
            int batchCount;

            using (DBDataContext context = new DBDataContext())
            {
                var queryResult = from batch in context.InvoiceFinanceBatches
                                  where batch.FinanceBatchNo.Contains(dateStr)
                                  select batch.FinanceBatchNo;

                if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
                {
                    batchCount = 0;
                }
            }

            batchCount += batchesInMemory.Count(batch => batch.FinanceBatchNo.Contains(dateStr));
            string financeNo = String.Format("FIN{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return financeNo;
        }
        //?Private?Methods?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Invoice> GetInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();
            foreach (InvoiceFinanceLog log in this.InvoiceFinanceLogs)
            {
                if (!invoices.Contains(log.Invoice))
                {
                    invoices.Add(log.Invoice);
                }
            }

            return invoices;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (this.Case != null)
                {
                    List<Invoice> invoiceList = this.GetInvoices();
                    DateTime assignDate = invoiceList.OrderByDescending(i => i.AssignDate).First().AssignDate;
                    if (FinancePeriodBegin < assignDate)
                    {
                        throw new Exception("融资日不能早于转让日: " + this.FinanceBatchNo);
                    }

                    if (FinancePeriodBegin > FinancePeriodEnd)
                    {
                        throw new Exception("终止日期应该大于起始日期: " + this.FinanceBatchNo);
                    }

                    DateTime dueDate = invoiceList.OrderByDescending(i => i.DueDate).First().DueDate;
                    if (FinancePeriodEnd < dueDate)
                    {
                        throw new Exception("融资到期日不能早于发票到期日: " + this.FinanceBatchNo);
                    }

                    if (TypeUtil.LessZero(FinanceRate))
                    {
                        throw new Exception("融资利率不能小于零: " + this.FinanceBatchNo);
                    }

                    if (this.CostRate.HasValue && TypeUtil.LessZero(CostRate))
                    {
                        throw new Exception("成本利率不能小于零: " + this.FinanceBatchNo);
                    }
                }
            }
        }
        #endregion?Methods?
    }
}

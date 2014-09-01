//-----------------------------------------------------------------------
// <copyright file="InvoiceFinanceBatch.cs" company="Yiming Liu@Fudan">
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
    public partial class InvoiceFinanceBatch
    {

        private decimal? _assignAmount;
        private decimal? _commissionAmount;
        //private decimal? _grossInterestIncome;
        private decimal? _handfeeAmount;
        private decimal? _interestAmount;
        //private decimal? _marginIncome;
        //private decimal? _netInterestIncome;



        /// <summary>
        /// Gets
        /// </summary>
        public decimal AssignAmount
        {
            get
            {
                if (_assignAmount.HasValue == false)
                {
                    decimal result = InvoiceFinanceLogs.Sum(log => log.Invoice.AssignAmount);

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
            get { return GetInvoices().Count; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public DateTime AssignDate
        {
            get { return InvoiceFinanceLogs.Count > 0 ? InvoiceFinanceLogs[0].Invoice.AssignDate : default(DateTime); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public int BatchCount
        {
            get { return InvoiceFinanceLogs.Count; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerName
        {
            get { return Case.BuyerClient.ToString(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string CommissionType
        {
            get
            {
                if (Case != null)
                {
                    CDA cda = Case.ActiveCDA;
                    if (cda != null)
                    {
                        return cda.CommissionType;
                    }
                }

                return string.Empty;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public decimal? CommissionAmount
        {
            get
            {
                if (_commissionAmount.HasValue == false)
                {
                    decimal? result = null;
                    foreach (InvoiceFinanceLog log in InvoiceFinanceLogs)
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

                    if (BatchCurrency != Case.InvoiceCurrency)
                    {
                        decimal rate = Exchange.GetExchangeRate(BatchCurrency, Case.InvoiceCurrency);
                        result *= rate;
                    }

                    _commissionAmount = result;
                }

                return _commissionAmount;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal FinanceOutstanding
        {
            get
            {
                return InvoiceFinanceLogs.Sum(log => log.FinanceOutstanding);
            }
        }

        /// <summary>
        /// 毛利息收入
        /// </summary>
        //public decimal GrossInterestIncome
        //{
        //    get
        //    {
        //        if (_grossInterestIncome.HasValue == false)
        //        {
        //            decimal result = InvoiceFinanceLogs.Sum(log => log.GrossInterest);

        //            _grossInterestIncome = result;
        //        }

        //        return _grossInterestIncome.Value;
        //    }
        //}

        /// <summary>
        /// Gets
        /// </summary>
        public decimal? HandfeeAmount
        {
            get
            {
                if (_handfeeAmount.HasValue == false)
                {
                    decimal? result = AssignCount * Case.ActiveCDA.HandFee;
                    if (Case.ActiveCDA.HandFeeCurr != Case.InvoiceCurrency)
                    {
                        decimal rate = Exchange.GetExchangeRate(Case.ActiveCDA.HandFeeCurr, Case.InvoiceCurrency);
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
        //public decimal? MarginIncome
        //{
        //    get
        //    {
        //        if (_marginIncome.HasValue == false)
        //        {
        //            _marginIncome = FinanceAmount * (decimal)(FinanceRate - CostRate) / 360 *
        //                            ((FinancePeriodEnd - FinancePeriodBegin).Days);
        //        }

        //        return _marginIncome;
        //    }
        //}

        /// <summary>
        /// 净利息收入
        /// </summary>
        //public decimal NetInterestIncome
        //{
        //    get
        //    {
        //        if (_netInterestIncome.HasValue == false)
        //        {
        //            decimal result = InvoiceFinanceLogs.Sum(log => log.NetInterest);

        //            _netInterestIncome = result;
        //        }

        //        return _netInterestIncome.Value;
        //    }
        //}

        public decimal Interest
        {
            get
            {
                if (_interestAmount.HasValue == false)
                {
                    decimal result = InvoiceFinanceLogs.Sum(log => log.Interest.GetValueOrDefault());
                    _interestAmount = result;
                }

                return _interestAmount.Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal PoolFinanceOutstanding
        {
            get { return FinanceAmount - PoolRefundAmount.GetValueOrDefault(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? PoolRefundAmount
        {
            get { return InvoiceRefundBatches != null ? InvoiceRefundBatches.Sum(batch => batch.RefundAmount) : null; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerName
        {
            get
            {
                return Case != null && Case.SellerClient != null
                           ? Case.SellerClient.ToString()
                           : (Client != null ? Client.ToString() : string.Empty);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TransactionType
        {
            get { return Case.TransactionType; }
        }




        //?Public?Methods?(3)?
        /// <summary>
        /// 
        /// </summary>
        public void CaculateFinanceAmount()
        {
            FinanceAmount = InvoiceFinanceLogs.Sum(log => log.FinanceAmount.GetValueOrDefault());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GenerateFinanceBatchNo(DateTime date)
        {
            string prefix = String.Format("FIN{0:yyyMMdd}", date);
            int batchCount = 0;
            using (var context = new DBDataContext())
            {
                IQueryable<string> queryStr = from batch in context.InvoiceFinanceBatches
                                              where batch.FinanceBatchNo.StartsWith(prefix)
                                              select batch.FinanceBatchNo.Substring(12);

                foreach (string value in queryStr)
                {
                    if (batchCount < Convert.ToInt32(value))
                    {
                        batchCount = Convert.ToInt32(value);
                    }
                }
            }

            string financeNo = String.Format("{0}-{1:d2}", prefix, batchCount + 1);
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
            string prefix = String.Format("FIN{0:yyyMMdd}", date);
            int batchCount = 0;

            using (var context = new DBDataContext())
            {
                IQueryable<string> queryStr = from batch in context.InvoiceFinanceBatches
                                              where batch.FinanceBatchNo.StartsWith(prefix)
                                              select batch.FinanceBatchNo.Substring(12);

                foreach (string value in queryStr)
                {
                    if (batchCount < Convert.ToInt32(value))
                    {
                        batchCount = Convert.ToInt32(value);
                    }
                }
            }

            batchCount += batchesInMemory.Count(batch => batch.FinanceBatchNo.StartsWith(prefix));
            string financeNo = String.Format("{0}-{1:d2}", prefix, batchCount + 1);
            return financeNo;
        }

        //?Private?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Invoice> GetInvoices()
        {
            var invoices = new List<Invoice>();
            foreach (InvoiceFinanceLog log in InvoiceFinanceLogs)
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
        partial void OnFinancePeriodBeginChanged()
        {
            foreach (InvoiceFinanceLog log in InvoiceFinanceLogs)
            {
                log.Invoice.CaculateFinanceDate();
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
                if (Case != null)
                {
                    List<Invoice> invoiceList = GetInvoices();
                    if (invoiceList.Count > 0)
                    {
                        DateTime assignDate = invoiceList.OrderByDescending(i => i.AssignDate).First().AssignDate;
                        if (FinancePeriodBegin < assignDate)
                        {
                            throw new Exception(String.Format("融资日{0:yyyyMMdd}不能早于转让日{1:yyyyMMdd}，融资批号：{2} ",
                                                              FinancePeriodBegin, assignDate, FinanceBatchNo));
                        }

                        //if (FinancePeriodBegin > FinancePeriodEnd)
                        //{
                        //    throw new Exception(String.Format("融资到期日{0:yyyyMMdd}应该大于融资日{1:yyyyMMdd}，融资批号：{2} ",
                        //                                      FinancePeriodBegin, FinancePeriodEnd, FinanceBatchNo));
                        //}

                        //if (Case.TransactionType != "国内买方保理")
                        //{
                        //    DateTime dueDate = invoiceList.OrderByDescending(i => i.DueDate).First().DueDate;
                        //    if (FinancePeriodEnd < dueDate)
                        //    {
                        //        throw new Exception(String.Format("融资到期日{0:yyyyMMdd}不能早于发票到期日{1:yyyyMMdd}，融资批号：{2} ",
                        //                                          FinancePeriodEnd, dueDate, FinanceBatchNo));
                        //    }
                        //}
                    }

                    if(FinanceAmount<0)
                    {
                        throw new Exception(String.Format("融资金额{0:N2}，不能小于零，融资批号：{1} ", FinanceAmount, FinanceBatchNo));
                    }

                    if (FinanceRate<0)
                    {
                        throw new Exception(String.Format("融资利率{0:N2}，不能小于零，融资批号：{1} ", FinanceRate, FinanceBatchNo));
                    }

                    if (CostRate.HasValue && CostRate<0)
                    {
                        throw new Exception(String.Format("成本利率{0:N2}，不能小于零，融资批号: {1}", CostRate, FinanceBatchNo));
                    }

                    switch (FinanceType)
                    {
                        case FINANCE.FINANCE_TYPE1:
                            break;
                        case FINANCE.FINANCE_TYPE2:
                            break;
                        case FINANCE.FINANCE_TYPE3:
                            break;
                        case FINANCE.FINANCE_TYPE4:
                            break;
                        case FINANCE.FINANCE_TYPE5:
                            break;
                        case FINANCE.FINANCE_TYPE6:
                            break;
                        case FINANCE.FINANCE_TYPE7:
                            break;
                        case FINANCE.FINANCE_TYPE8:
                            break;
                        case FINANCE.FINANCE_TYPE9:
                            break;
                        default:
                            throw new Exception(String.Format("融资类型：{0}，不符合规范", FinanceType));
                    }
                }
            }
        }
    }
}
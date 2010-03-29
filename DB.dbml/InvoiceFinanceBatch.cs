//-----------------------------------------------------------------------
// <copyright file="InvoiceFinanceBatch.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceFinanceBatch
    {
        #region Properties (11)

        private double? _assignAmount;

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

        private double? _commissionAmount;

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

        private double? _grossInterestIncome;

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

        private double? _handfeeAmount;

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

        private double? _marginIncome;

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

        private double? _netInterestIncome;

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

                    _netInterestIncome =  result;
                }

                return _netInterestIncome.Value;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerName
        {
            get
            {
                return this.Case.SellerClient.ToString();
            }
        }

        #endregion Properties

        #region Methods (3)

        // Public Methods (2) 

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
        // Private Methods (1) 

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

        #endregion Methods
    }
}

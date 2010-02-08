﻿//-----------------------------------------------------------------------
// <copyright file="Case.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class Case
    {
        #region Properties (12)

        /// <summary>
        /// Gets 
        /// </summary>
        public CDA ActiveCDA
        {
            get
            {
                return this.CDAs.SingleOrDefault(c => c.CDAStatus == ConstStr.CDA.SIGNED);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double AssignAmount
        {
            get
            {
                double result = 0;
                foreach (InvoiceAssignBatch batch in this.InvoiceAssignBatches)
                {
                    result += batch.AssignAmount;
                }

                return result;
            }
        }

        /// <summary>
        /// Gets 转让余额
        /// </summary>
        public double AssignOutstanding
        {
            get
            {
                double total = 0;
                foreach (InvoiceAssignBatch assignBatch in this.InvoiceAssignBatches)
                {
                    foreach (Invoice invoice in assignBatch.Invoices)
                    {
                        total += invoice.AssignOutstanding;
                    }
                }
                return total;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<ClientReview> ClientReviews
        {
            get
            {
                switch (TransactionType)
                {
                    case "国内卖方保理":
                    case "出口保理":
                    case "国内信保保理":
                    case "国际信保保理":
                    case "租赁保理":
                        return SellerClient.ClientReviews.Where(review => review.ReviewStatus == "已生效").ToList();
                    case "国内买方保理":
                    case "进口保理":
                        return BuyerClient.ClientReviews.Where(review => review.ReviewStatus == "已生效").ToList();
                    default:
                        return null;
                }

            }
        }

        /// <summary>
        /// 手续费
        /// </summary>
        public double CommissionIncome
        {
            get
            {
                double result = 0;
                int count = 0;
                foreach (InvoiceAssignBatch batch in this.InvoiceAssignBatches)
                {
                    count += batch.BatchCount;
                    foreach (Invoice invoice in batch.Invoices)
                    {
                        result += invoice.Commission.GetValueOrDefault();
                    }
                }

                CDA cda = this.ActiveCDA;
                double handFreeIncome = 0;
                if (cda != null)
                {
                    handFreeIncome = count * cda.HandFee.GetValueOrDefault();
                }

                return result + handFreeIncome;
            }
        }

        /// <summary>
        /// Gets Factor
        /// </summary>
        public Factor Factor
        {
            get
            {
                if ("国内卖方保理".Equals(this.TransactionType) || "出口保理".Equals(this.TransactionType) || "国际信保保理".Equals(this.TransactionType) || "国内信保保理".Equals(this.TransactionType) || "租赁保理".Equals(this.TransactionType))
                {
                    return this.BuyerFactor;
                }
                else
                {
                    return this.SellerFactor;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double FinanceAmount
        {
            get
            {
                double result = 0;
                foreach (InvoiceFinanceBatch batch in this.InvoiceFinanceBatches)
                {
                    double finance = batch.FinanceAmount;
                    if (batch.BatchCurrency != this.InvoiceCurrency)
                    {
                        double rate = Exchange.GetExchangeRate(batch.BatchCurrency, this.InvoiceCurrency);
                        finance *= rate;
                    }
                    result += finance;
                }

                return result;
            }
        }

        /// <summary>
        /// Gets 融资余额
        /// </summary>
        public double? FinanceOutstanding
        {
            get
            {
                double? total = null;
                foreach (InvoiceAssignBatch assignBatch in this.InvoiceAssignBatches)
                {
                    foreach (Invoice invoice in assignBatch.Invoices)
                    {
                        if (invoice.FinanceOutstanding.HasValue)
                        {
                            if (total == null)
                            {
                                total = 0;
                            }

                            double financeOutstanding = invoice.FinanceOutstanding.Value;
                            if (invoice.InvoiceFinanceBatch.BatchCurrency != this.InvoiceCurrency)
                            {
                                double exchange = Exchange.GetExchangeRate(invoice.InvoiceFinanceBatch.BatchCurrency, this.InvoiceCurrency);
                                financeOutstanding *= exchange;
                            }

                            total += financeOutstanding;
                        }
                    }
                }

                return total;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? MarginIncome
        {
            get
            {
                double? result = null;
                foreach (InvoiceFinanceBatch batch in this.InvoiceFinanceBatches)
                {
                    if (batch.FinanceType == "卖方代付" || batch.FinanceType == "买方代付")
                    {
                        if (result == null)
                        {
                            result = 0;
                        }

                        result += batch.NetInterestIncome;
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? NetInterestIncome
        {
            get
            {
                double? result = null;
                foreach (InvoiceFinanceBatch batch in this.InvoiceFinanceBatches)
                {
                    if (batch.FinanceType != "卖方代付" && batch.FinanceType != "买方代付")
                    {
                        if (result == null)
                        {
                            result = 0;
                        }

                        result += batch.NetInterestIncome;
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double PaymentAmount
        {
            get
            {
                double result = 0;
                foreach (InvoicePaymentBatch batch in this.InvoicePaymentBatches)
                {
                    result += batch.PaymentAmount;
                }

                return result;
            }
        }

        /// <summary>
        /// 总收入
        /// </summary>
        public double? TotalIncome
        {
            get
            {
                return this.CommissionIncome + this.NetInterestIncome.GetValueOrDefault() + this.MarginIncome.GetValueOrDefault();
            }
        }

        #endregion Properties

        #region Methods (1)

        // Public Methods (1) 

        /// <summary>
        /// Generate Case code
        /// </summary>
        /// <returns></returns>
        public string GenerateCaseCode()
        {
            string caseCode = null;
            string yearMonth = String.Format("{0:yyyy}{0:MM}", this.CaseAppDate);
            string prefix = null;
            int count = 0;
            IEnumerable<string> queryResult;
            DBDataContext context = new DBDataContext();

            switch (TransactionType)
            {
                case "国内卖方保理":

                case "国内买方保理":
                    prefix = "LF" + yearMonth;
                    queryResult = from c in context.Cases
                                  where c.CaseCode.StartsWith(prefix)
                                  select c.CaseCode;
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(8)), out count))
                    {
                        count = 0;
                    }

                    caseCode = String.Format("{0}-{1:D3}", prefix, count + 1);
                    break;
                case "出口保理":
                    prefix = "EF" + yearMonth;
                    queryResult = from c in context.Cases
                                  where c.CaseCode.StartsWith(prefix)
                                  select c.CaseCode;
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(8)), out count))
                    {
                        count = 0;
                    }

                    caseCode = String.Format("{0}-{1:D3}", prefix, count + 1);
                    break;
                case "进口保理":
                    prefix = "IF" + yearMonth;
                    queryResult = from c in context.Cases
                                  where c.CaseCode.StartsWith(prefix)
                                  select c.CaseCode;
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(8)), out count))
                    {
                        count = 0;
                    }

                    caseCode = String.Format("{0}-{1:D3}", prefix, count + 1);
                    break;
                case "国际信保保理":

                case "国内信保保理":
                    prefix = "SF" + yearMonth;
                    queryResult = from c in context.Cases
                                  where c.CaseCode.StartsWith(prefix)
                                  select c.CaseCode;
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(8)), out count))
                    {
                        count = 0;
                    }

                    caseCode = String.Format("{0}-{1:D3}", prefix, count + 1);
                    break;
                case "租赁保理":
                    prefix = "LF" + yearMonth;
                    queryResult = from c in context.Cases
                                  where c.CaseCode.StartsWith(prefix)
                                  select c.CaseCode;
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(8)), out count))
                    {
                        count = 0;
                    }

                    caseCode = String.Format("{0}-{1:D3}", prefix, count + 1);
                    break;
                default:
                    caseCode = string.Empty;
                    break;
            }

            return caseCode;
        }

        #endregion Methods
    }
}

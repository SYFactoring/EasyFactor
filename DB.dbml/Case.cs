//-----------------------------------------------------------------------
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
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class Case
    {
        #region Properties (16)

        private CDA _activeCDA;

        /// <summary>
        /// Gets 
        /// </summary>
        public CDA ActiveCDA
        {
            get
            {
                if (_activeCDA == null)
                {
                    IList<CDA> cdaList = this.CDAs.Where(c => c.CDAStatus == ConstStr.CDA.CHECKED).ToList();
                    if (cdaList.Count > 1)
                    {
                        MessageBoxEx.Show("包含多个有效的CDA，案件编号: " + this.CaseCode, ConstStr.MESSAGE.TITLE_WARNING);
                        return null;
                    }
                    else if (cdaList.Count == 1)
                    {
                        _activeCDA = cdaList[0];
                    }
                    else
                    {
                        return null;
                    }
                }

                return _activeCDA;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime QueryDateFrom
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime QueryDateTo
        {
            get;
            set;
        }

        private double? _assignAmountByDate;

        /// <summary>
        /// 
        /// </summary>
        public double AssignAmountByDate
        {
            get
            {
                if (_assignAmountByDate.HasValue == false)
                {
                    double result = 0;
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoiceAssignBatch> batches = this.InvoiceAssignBatches.Where(i => i.AssignDate >= fromDate && i.AssignDate <= toDate);
                    foreach (InvoiceAssignBatch batch in batches)
                    {
                        result += batch.AssignAmount;
                    }

                    _assignAmountByDate = result;
                }

                return _assignAmountByDate.Value;
            }
        }

        ///// <summary>
        ///// 
        ///// </summary>
        //public double AssignAmount
        //{
        //    get
        //    {
        //        double result = 0;
        //        foreach (InvoiceAssignBatch batch in this.InvoiceAssignBatches)
        //        {
        //            result += batch.AssignAmount;
        //        }

        //        return result;
        //    }
        //}

        private double? _assginOutstanding;

        /// <summary>
        /// Gets 转让余额
        /// </summary>
        public double AssignOutstanding
        {
            get
            {
                if (_assignAmountByDate.HasValue == false)
                {
                    double total = 0;
                    foreach (InvoiceAssignBatch assignBatch in this.InvoiceAssignBatches)
                    {
                        foreach (Invoice invoice in assignBatch.Invoices)
                        {
                            total += invoice.AssignOutstanding;
                        }
                    }

                    _assginOutstanding = total;
                }

                return _assginOutstanding.Value;
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
        /// 
        /// </summary>
        public Client TargetClient
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
                        return this.BuyerClient;
                    case "国内买方保理":
                    case "进口保理":
                        return this.SellerClient;
                    default:
                        return null;
                }
            }
        }

        private double? _commissionIncomeByDate;

        /// <summary>
        /// 
        /// </summary>
        public double CommissionIncomeByDate
        {
            get
            {
                if (_commissionIncomeByDate.HasValue == false)
                {
                    double result = 0;
                    int count = 0;
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoiceAssignBatch> batches = this.InvoiceAssignBatches.Where(i => i.AssignDate >= fromDate && i.AssignDate <= toDate);

                    foreach (InvoiceAssignBatch batch in batches)
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

                    _commissionIncomeByDate = result + handFreeIncome;
                }

                return _commissionIncomeByDate.Value;
            }
        }

        /// <summary>
        /// 手续费
        /// </summary>
        //public double CommissionIncome
        //{
        //    get
        //    {
        //        double result = 0;
        //        int count = 0;
        //        foreach (InvoiceAssignBatch batch in this.InvoiceAssignBatches)
        //        {
        //            count += batch.BatchCount;
        //            foreach (Invoice invoice in batch.Invoices)
        //            {
        //                result += invoice.Commission.GetValueOrDefault();
        //            }
        //        }

        //        CDA cda = this.ActiveCDA;
        //        double handFreeIncome = 0;
        //        if (cda != null)
        //        {
        //            handFreeIncome = count * cda.HandFee.GetValueOrDefault();
        //        }

        //        return result + handFreeIncome;
        //    }
        //}

        /// <summary>
        /// 
        /// </summary>
        public double? CreditCoverOutstanding
        {
            get
            {
                CDA cda = this.ActiveCDA;
                if (cda != null)
                {
                    return cda.CreditCoverOutstanding;
                }
                else
                {
                    return null;
                }
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

        private double? _financeAmountByDate;

        /// <summary>
        /// 
        /// </summary>
        public double FinanceAmountByDate
        {
            get
            {
                if (_financeAmountByDate.HasValue == false)
                {
                    double result = 0;
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoiceFinanceBatch> batches = this.InvoiceFinanceBatches.Where(i => i.FinancePeriodBegin >= fromDate && i.FinancePeriodBegin <= toDate);
                    foreach (InvoiceFinanceBatch batch in batches)
                    {
                        double finance = batch.FinanceAmount;
                        if (batch.BatchCurrency != this.InvoiceCurrency)
                        {
                            double rate = Exchange.GetExchangeRate(batch.BatchCurrency, this.InvoiceCurrency);
                            finance *= rate;
                        }
                        result += finance;
                    }

                    _financeAmountByDate = result;
                }

                return _financeAmountByDate.Value;
            }
        }

        ///// <summary>
        ///// 
        ///// </summary>
        //public double FinanceAmount
        //{
        //    get
        //    {
        //        double result = 0;
        //        foreach (InvoiceFinanceBatch batch in this.InvoiceFinanceBatches)
        //        {
        //            double finance = batch.FinanceAmount;
        //            if (batch.BatchCurrency != this.InvoiceCurrency)
        //            {
        //                double rate = Exchange.GetExchangeRate(batch.BatchCurrency, this.InvoiceCurrency);
        //                finance *= rate;
        //            }
        //            result += finance;
        //        }

        //        return result;
        //    }
        //}

        /// <summary>
        /// 
        /// </summary>
        public double? FinanceLineOutstanding
        {
            get
            {
                CDA cda = this.ActiveCDA;
                if (cda != null)
                {
                    return cda.FinanceLineOutstanding;
                }
                else
                {
                    return null;
                }
            }
        }

        private double? _financeOutstanding;

        /// <summary>
        /// Gets 融资余额
        /// </summary>
        public double? FinanceOutstanding
        {
            get
            {
                if (_financeOutstanding.HasValue == false)
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
                                total += financeOutstanding;
                            }
                        }
                    }

                    _financeOutstanding = total;
                }

                return _financeOutstanding;
            }
        }

        private double? _marginIncomeByDate;

        /// <summary>
        /// 
        /// </summary>
        public double? MarginIncomeByDate
        {
            get
            {
                if (_marginIncomeByDate.HasValue == false)
                {
                    double? result = null;
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoiceFinanceBatch> batches = this.InvoiceFinanceBatches.Where(i => i.FinancePeriodBegin >= fromDate && i.FinancePeriodBegin <= toDate);
                    foreach (InvoiceFinanceBatch batch in batches)
                    {
                        if (batch.FinanceType == "卖方代付" || batch.FinanceType == "买方代付")
                        {
                            if (result == null)
                            {
                                result = 0;
                            }

                            result += batch.MarginIncome;
                        }
                    }

                    _marginIncomeByDate = result;
                }

                return _marginIncomeByDate;
            }
        }

        ///// <summary>
        ///// 
        ///// </summary>
        //public double? MarginIncome
        //{
        //    get
        //    {
        //        double? result = null;
        //        foreach (InvoiceFinanceBatch batch in this.InvoiceFinanceBatches)
        //        {
        //            if (batch.FinanceType == "卖方代付" || batch.FinanceType == "买方代付")
        //            {
        //                if (result == null)
        //                {
        //                    result = 0;
        //                }

        //                result += batch.MarginIncome;
        //            }
        //        }

        //        return result;
        //    }
        //}

        private double? _netInterestIncomeByDate;

        public double? NetInterestIncomeByDate
        {
            get
            {
                if (_netInterestIncomeByDate.HasValue == false)
                {
                    double? result = null;
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoiceFinanceBatch> batches = this.InvoiceFinanceBatches.Where(i => i.FinancePeriodBegin >= fromDate && i.FinancePeriodBegin <= toDate);
                    foreach (InvoiceFinanceBatch batch in batches)
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

                    _netInterestIncomeByDate = result;
                }

                return _netInterestIncomeByDate;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        //public double? NetInterestIncome
        //{
        //    get
        //    {
        //        double? result = null;
        //        foreach (InvoiceFinanceBatch batch in this.InvoiceFinanceBatches)
        //        {
        //            if (batch.FinanceType != "卖方代付" && batch.FinanceType != "买方代付")
        //            {
        //                if (result == null)
        //                {
        //                    result = 0;
        //                }

        //                result += batch.NetInterestIncome;
        //            }
        //        }

        //        return result;
        //    }
        //}

        private double? _paymentAmountByDate;

        /// <summary>
        /// 
        /// </summary>
        public double PaymentAmountByDate
        {
            get
            {
                if (_paymentAmountByDate.HasValue == false)
                {
                    double result = 0;
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoicePaymentBatch> batches = this.InvoicePaymentBatches.Where(i => i.PaymentDate >= fromDate && i.PaymentDate <= toDate);
                    foreach (InvoicePaymentBatch batch in batches)
                    {
                        result += batch.PaymentAmount;
                    }

                    _paymentAmountByDate = result;
                }

                return _paymentAmountByDate.Value;
            }
        }

        ///// <summary>
        ///// 
        ///// </summary>
        //public double PaymentAmount
        //{
        //    get
        //    {
        //        double result = 0;
        //        foreach (InvoicePaymentBatch batch in this.InvoicePaymentBatches)
        //        {
        //            result += batch.PaymentAmount;
        //        }

        //        return result;
        //    }
        //}

        private double? _totalAssignOutstanding;

        /// <summary>
        /// 
        /// </summary>
        public double TotalAssignOutstanding
        {
            get
            {
                if (_totalAssignOutstanding.HasValue == false)
                {
                    double result = 0;
                    var caseList = this.SellerClient.SellerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE && c.TransactionType == this.TransactionType);
                    foreach (Case c in caseList)
                    {
                        result += c.AssignOutstanding;
                    }

                    _totalAssignOutstanding = result;
                }

                return _totalAssignOutstanding.Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double TotalFinanceOutstanding
        {
            get
            {
                switch (this.TransactionType)
                {
                    case "国内卖方保理":
                    case "出口保理":
                    case "国内信保保理":
                    case "国际信保保理":
                    case "租赁保理":
                        return this.SellerClient.GetFinanceOutstanding(this.InvoiceCurrency).GetValueOrDefault();
                    case "国内买方保理":
                    case "进口保理":
                        return this.BuyerClient.GetFinanceOutstanding(this.InvoiceCurrency).GetValueOrDefault();
                    default:
                        return 0;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? TotalIncomeByDate
        {
            get
            {
                return this.CommissionIncomeByDate + this.NetInterestIncomeByDate.GetValueOrDefault() + this.MarginIncomeByDate.GetValueOrDefault();
            }
        }

        /// <summary>
        /// 总收入
        /// </summary>
        //public double? TotalIncome
        //{
        //    get
        //    {
        //        return this.CommissionIncome + this.NetInterestIncome.GetValueOrDefault() + this.MarginIncome.GetValueOrDefault();
        //    }
        //}

        #endregion Properties

        #region Methods (2)

        // Public Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="appDate"></param>
        /// <returns></returns>
        public static string GenerateCaseCode(string transactionType, DateTime appDate)
        {
            string caseCode = null;
            string yearMonth = String.Format("{0:yyyy}{0:MM}", appDate);
            string prefix = null;
            int count = 0;
            IEnumerable<string> queryResult;
            DBDataContext context = new DBDataContext();

            switch (transactionType)
            {
                case "国内卖方保理":

                case "国内买方保理":
                    prefix = "LF" + yearMonth;
                    queryResult = from c in context.Cases
                                  where c.CaseCode.StartsWith(prefix)
                                  select c.CaseCode;
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(9)), out count))
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
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(9)), out count))
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
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(9)), out count))
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
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(9)), out count))
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
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(9)), out count))
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="appDate"></param>
        /// <param name="casesInMemory"></param>
        /// <returns></returns>
        public static string GenerateCaseCode(string transactionType, DateTime appDate, List<Case> casesInMemory)
        {
            string caseCode = null;
            string yearMonth = String.Format("{0:yyyy}{0:MM}", appDate);
            string prefix = null;
            int count = 0;
            IEnumerable<string> queryResult;
            DBDataContext context = new DBDataContext();

            switch (transactionType)
            {
                case "国内卖方保理":

                case "国内买方保理":
                    prefix = "LF" + yearMonth;
                    queryResult = from c in context.Cases
                                  where c.CaseCode.StartsWith(prefix)
                                  select c.CaseCode;
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(9)), out count))
                    {
                        count = 0;
                    }

                    count += casesInMemory.Count(c => c.CaseCode.StartsWith(prefix));
                    caseCode = String.Format("{0}-{1:D3}", prefix, count + 1);
                    break;
                case "出口保理":
                    prefix = "EF" + yearMonth;
                    queryResult = from c in context.Cases
                                  where c.CaseCode.StartsWith(prefix)
                                  select c.CaseCode;
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(9)), out count))
                    {
                        count = 0;
                    }

                    count += casesInMemory.Count(c => c.CaseCode.StartsWith(prefix));
                    caseCode = String.Format("{0}-{1:D3}", prefix, count + 1);
                    break;
                case "进口保理":
                    prefix = "IF" + yearMonth;
                    queryResult = from c in context.Cases
                                  where c.CaseCode.StartsWith(prefix)
                                  select c.CaseCode;
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(9)), out count))
                    {
                        count = 0;
                    }

                    count += casesInMemory.Count(c => c.CaseCode.StartsWith(prefix));
                    caseCode = String.Format("{0}-{1:D3}", prefix, count + 1);
                    break;
                case "国际信保保理":

                case "国内信保保理":
                    prefix = "SF" + yearMonth;
                    queryResult = from c in context.Cases
                                  where c.CaseCode.StartsWith(prefix)
                                  select c.CaseCode;
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(9)), out count))
                    {
                        count = 0;
                    }

                    count += casesInMemory.Count(c => c.CaseCode.StartsWith(prefix));
                    caseCode = String.Format("{0}-{1:D3}", prefix, count + 1);
                    break;
                case "租赁保理":
                    prefix = "LF" + yearMonth;
                    queryResult = from c in context.Cases
                                  where c.CaseCode.StartsWith(prefix)
                                  select c.CaseCode;
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(9)), out count))
                    {
                        count = 0;
                    }

                    count += casesInMemory.Count(c => c.CaseCode.StartsWith(prefix));
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

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
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class Case
    {
		#region?Fields?(11)?

        private CDA _activeCDA;
        private double? _assginOutstanding;
        private double? _assignAmountByDate;
        private double? _commissionIncomeByDate;
        private double? _financeAmountByDate;
        private double? _financeOutstanding;
        private double? _marginIncomeByDate;
        private double? _netInterestIncomeByDate;
        private double? _paymentAmountByDate;
        private double? _totalAssignOutstanding;
        private double? _valuedAssignOutstanding;

		#endregion?Fields?

		#region?Properties?(22)?

        /// <summary>
        /// Gets 
        /// </summary>
        public CDA ActiveCDA
        {
            get
            {
                if (_activeCDA == null)
                {
                    IList<CDA> cdaList = this.CDAs.Where(c => c.CDAStatus == CDAStr.CHECKED).ToList();
                    if (cdaList.Count > 1)
                    {
                        MessageBoxEx.Show("包含多个有效的CDA，案件编号: " + this.CaseCode, MESSAGE.TITLE_WARNING);
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
        public double AssignAmountByDate
        {
            get
            {
                if (_assignAmountByDate.HasValue == false)
                {
                    double result = 0;
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoiceAssignBatch> batches = this.InvoiceAssignBatches.Where(i => i.AssignDate >= fromDate && i.AssignDate <= toDate && i.CheckStatus == BATCH.CHECK);
                    foreach (InvoiceAssignBatch batch in batches)
                    {
                        result += batch.AssignAmount;
                    }

                    _assignAmountByDate = result;
                }

                return _assignAmountByDate.Value;
            }
        }

        /// <summary>
        /// Gets 转让余额
        /// </summary>
        public double AssignOutstanding
        {
            get
            {
                if (_assginOutstanding.HasValue == false)
                {
                    double total = 0;
                    foreach (InvoiceAssignBatch assignBatch in this.InvoiceAssignBatches)
                    {
                        if (assignBatch.CheckStatus == BATCH.CHECK)
                        {
                            foreach (Invoice invoice in assignBatch.Invoices)
                            {
                                total += invoice.AssignOutstanding;
                            }
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
        public double CanBeFinanceAmount
        {
            get
            {
                CDA activeCDA = this.ActiveCDA;
                if (activeCDA == null)
                {
                    return this.ValuedAssignOutstanding * 0.8;
                }
                else
                {
                    return Math.Min(activeCDA.FinanceLineOutstanding.GetValueOrDefault(), this.ValuedAssignOutstanding * activeCDA.FinanceProportion ?? 0.8);
                }
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
                    IEnumerable<InvoiceAssignBatch> batches = this.InvoiceAssignBatches.Where(i => i.AssignDate >= fromDate && i.AssignDate <= toDate && i.CheckStatus == BATCH.CHECK);

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
                if ("国内卖方保理".Equals(this.TransactionType) || "出口保理".Equals(this.TransactionType))
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
        public double FinanceAmountByDate
        {
            get
            {
                if (_financeAmountByDate.HasValue == false)
                {
                    double result = 0;
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoiceFinanceBatch> batches = this.InvoiceFinanceBatches.Where(i => i.FinancePeriodBegin >= fromDate && i.FinancePeriodBegin <= toDate && i.CheckStatus == BATCH.CHECK);
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
                        if (assignBatch.CheckStatus == BATCH.CHECK)
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
                    }

                    _financeOutstanding = total;
                }

                return _financeOutstanding;
            }
        }

        public double? FinanceProportion
        {
            get
            {
                CDA cda = this.ActiveCDA;
                if (cda != null)
                {
                    return cda.FinanceProportion;
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
        public double? MarginIncomeByDate
        {
            get
            {
                if (_marginIncomeByDate.HasValue == false)
                {
                    double? result = null;
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoiceFinanceBatch> batches = this.InvoiceFinanceBatches.Where(i => i.FinancePeriodBegin >= fromDate && i.FinancePeriodBegin <= toDate && i.CheckStatus == BATCH.CHECK);
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

        public double? NetInterestIncomeByDate
        {
            get
            {
                if (_netInterestIncomeByDate.HasValue == false)
                {
                    double? result = null;
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoiceFinanceBatch> batches = this.InvoiceFinanceBatches.Where(i => i.FinancePeriodBegin >= fromDate && i.FinancePeriodBegin <= toDate && i.CheckStatus == BATCH.CHECK);
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
        public double PaymentAmountByDate
        {
            get
            {
                if (_paymentAmountByDate.HasValue == false)
                {
                    double result = 0;
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoicePaymentBatch> batches = this.InvoicePaymentBatches.Where(i => i.PaymentDate >= fromDate && i.PaymentDate <= toDate && i.CheckStatus == BATCH.CHECK);
                    foreach (InvoicePaymentBatch batch in batches)
                    {
                        result += batch.PaymentAmount;
                    }

                    _paymentAmountByDate = result;
                }

                return _paymentAmountByDate.Value;
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
                        return this.BuyerClient;
                    case "国内买方保理":
                    case "进口保理":
                        return this.SellerClient;
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Client GuaranteeDepositClient
        {
            get
            {
                switch (TransactionType)
                {
                    case "国内卖方保理":
                    case "出口保理":
                        return this.SellerClient;
                    case "国内买方保理":
                    case "进口保理":
                        return this.BuyerClient;
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double TotalAssignOutstanding
        {
            get
            {
                if (_totalAssignOutstanding.HasValue == false)
                {
                    _totalAssignOutstanding = this.SellerClient.GetAssignOutstandingAsSeller(this.TransactionType, this.InvoiceCurrency);
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
        /// 用于池融资，有效的转让余额
        /// </summary>
        public double ValuedAssignOutstanding
        {
            get
            {
                if (_valuedAssignOutstanding.HasValue == false)
                {
                    double total = 0;
                    foreach (InvoiceAssignBatch assignBatch in this.InvoiceAssignBatches)
                    {
                        if (assignBatch.CheckStatus == BATCH.CHECK)
                        {
                            foreach (Invoice invoice in assignBatch.Invoices)
                            {
                                if (invoice.IsDispute.GetValueOrDefault() || invoice.IsFlaw || DateTime.Today > invoice.DueDate)
                                {
                                    continue;
                                }

                                total += invoice.AssignOutstanding;
                            }
                        }
                    }

                    _valuedAssignOutstanding = total;
                }

                return _valuedAssignOutstanding.Value;
            }
        }

		#endregion?Properties?

		#region?Methods?(2)?

		//?Public?Methods?(2)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="appDate"></param>
        /// <returns></returns>
        public static string GenerateCaseCode(string transactionType, string locationCode, DateTime appDate)
        {
            DBDataContext context = new DBDataContext();
            string year = String.Format("{0:yy}", appDate);
            string typeCode = null;
            switch (transactionType)
            {
                case "出口保理": typeCode = "EX"; break;
                case "进口保理": typeCode = "IM"; break;
                case "国内卖方保理": typeCode = "SE"; break;
                case "国内买方保理": typeCode = "BY"; break;
                default:
                    typeCode = "  ";
                    break;
            }

            string prefix = String.Format("69{0}{1}{2}", locationCode, typeCode, year);
            int count = 0;
            IEnumerable<string> queryResult = from c in context.Cases
                                              where c.CaseCode.StartsWith(prefix)
                                              select c.CaseCode;
            if (!Int32.TryParse(queryResult.Max(no => no.Substring(8)), out count))
            {
                count = 0;
            }
            string caseCode = String.Format("{0}{1:D4}", prefix, count + 1);
            return caseCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="appDate"></param>
        /// <param name="casesInMemory"></param>
        /// <returns></returns>
        public static string GenerateCaseCode(string transactionType, string locationCode, DateTime appDate, List<Case> casesInMemory)
        {
            DBDataContext context = new DBDataContext();
            string year = String.Format("{0:yy}", appDate);
            string typeCode = null;
            switch (transactionType)
            {
                case "出口保理": typeCode = "EX"; break;
                case "进口保理": typeCode = "IM"; break;
                case "国内卖方保理": typeCode = "SE"; break;
                case "国内买方保理": typeCode = "BY"; break;
                default:
                    typeCode = "  ";
                    break;
            }

            string prefix = String.Format("69{0}{1}{2}", locationCode, typeCode, year);
            int count = 0;
            IEnumerable<string> queryResult = from c in context.Cases
                                              where c.CaseCode.StartsWith(prefix)
                                              select c.CaseCode;
            if (!Int32.TryParse(queryResult.Max(no => no.Substring(8)), out count))
            {
                count = 0;
            }

            count += casesInMemory.Count(c => c.CaseCode.StartsWith(prefix));
            string caseCode = String.Format("{0}{1:D4}", prefix, count + 1);
            return caseCode;
        }

		#endregion?Methods?
    }
}

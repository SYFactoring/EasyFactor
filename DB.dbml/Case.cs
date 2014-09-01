//-----------------------------------------------------------------------
// <copyright file="Case.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;
using System.Data.Linq;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Case
    {
        private CDA _activeCDA;
        private decimal? _assginOutstanding;
        private decimal? _assignAmountByDate;
        private decimal? _commissionIncomeByDate;
        private decimal? _financeAmountByDate;
        private decimal? _financeOutstanding;
        //private decimal? _marginIncomeByDate;
        private decimal? _interestIncomeByDate;
        private decimal? _paymentAmountByDate;
        private decimal? _refundAmountByDate;
        private decimal? _totalAssignOutstanding;
        private decimal? _sellerValuedAssignOutstanding;
        private decimal? _buyerValuedAssignOutstanding;
        private decimal? _poolValuedAssignOutstanding;


        /// <summary>
        /// Gets 
        /// </summary>
        public CDA ActiveCDA
        {
            get
            {
                if (_activeCDA == null)
                {
                    IList<CDA> cdaList = CDAs.Where(c => c.CDAStatus == CDAStr.CHECKED).ToList();
                    if (cdaList.Count > 1)
                    {
                        MessageBoxEx.Show("���������Ч��CDA���������: " + CaseCode, MESSAGE.TITLE_WARNING);
                        return null;
                    }
                    if (cdaList.Count == 1)
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
        public decimal AssignAmountByDate
        {
            get
            {
                if (_assignAmountByDate.HasValue == false)
                {
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoiceAssignBatch> batches =
                        InvoiceAssignBatches.Where(i => i.AssignDate >= fromDate && i.AssignDate <= toDate);
                    decimal result = batches.Sum(batch => batch.AssignAmount);

                    _assignAmountByDate = result;
                }

                return _assignAmountByDate.Value;
            }
        }

        /// <summary>
        /// Gets ת�����
        /// </summary>
        public decimal AssignOutstanding
        {
            get
            {
                if (_assginOutstanding.HasValue == false)
                {
                    decimal total =
                        InvoiceAssignBatches.SelectMany(assignBatch => assignBatch.Invoices).Sum(
                            invoice => invoice.AssignOutstanding);

                    _assginOutstanding = total;
                }

                return _assginOutstanding.Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal CanBeFinanceAmount
        {
            get
            {
                CDA activeCDA = ActiveCDA;
                if (activeCDA == null)
                {
                    return 0;
                }

                if (IsPool)
                {
                    return Math.Min(activeCDA.FinanceLineOutstanding.GetValueOrDefault(),
                                PoolValuedAssignOutstanding * (decimal)activeCDA.FinanceProportion.GetValueOrDefault());
                }
                else
                {
                    if (TransactionType == "������������" || TransactionType == "���ڱ���")
                        return Math.Min(activeCDA.FinanceLineOutstanding.GetValueOrDefault(), SellerValuedAssignOutstanding * (decimal)activeCDA.FinanceProportion.GetValueOrDefault());
                    else if (TransactionType == "�����򷽱���")
                        return Math.Min(activeCDA.FinanceLineOutstanding.GetValueOrDefault(), BuyerValuedAssignOutstanding * (decimal)activeCDA.FinanceProportion.GetValueOrDefault());
                    else
                        return 0;
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
                    case "������������":
                    case "���ڱ���":
                        return SellerClient.ClientReviews.Where(review => review.ReviewStatus == "����Ч").ToList();
                    case "�����򷽱���":
                    case "���ڱ���":
                        return BuyerClient.ClientReviews.Where(review => review.ReviewStatus == "����Ч").ToList();
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal CommissionIncomeByDate
        {
            get
            {
                if (_commissionIncomeByDate.HasValue == false)
                {
                    decimal result = 0;
                    int count = 0;
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoiceAssignBatch> batches =
                        InvoiceAssignBatches.Where(i => i.AssignDate >= fromDate && i.AssignDate <= toDate);

                    foreach (InvoiceAssignBatch batch in batches)
                    {
                        count += batch.BatchCount;
                        result = batch.Invoices.Sum(invoice => invoice.Commission.GetValueOrDefault());
                    }

                    CDA cda = ActiveCDA;
                    decimal handFreeIncome = 0;
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
        public decimal? CreditCoverOutstanding
        {
            get
            {
                CDA cda = ActiveCDA;
                return cda != null ? cda.CreditCoverOutstanding : null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<CreditNote> CreditNotes
        {
            get
            {
                var result = new List<CreditNote>();
                foreach (InvoiceAssignBatch batch in InvoiceAssignBatches)
                {
                    result.AddRange(batch.CreditNotes);
                }

                return result;
            }
        }

        /// <summary>
        /// Gets Factor
        /// </summary>
        public Factor Factor
        {
            get { return "������������".Equals(TransactionType) || "���ڱ���".Equals(TransactionType) ? BuyerFactor : SellerFactor; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal FinanceAmountByDate
        {
            get
            {
                if (_financeAmountByDate.HasValue == false)
                {
                    decimal result = 0;
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoiceFinanceBatch> batches =
                        InvoiceFinanceBatches.Where(
                            i => i.FinancePeriodBegin >= fromDate && i.FinancePeriodBegin <= toDate);
                    foreach (InvoiceFinanceBatch batch in batches)
                    {
                        decimal finance = batch.FinanceAmount;
                        if (batch.BatchCurrency != InvoiceCurrency)
                        {
                            decimal rate = Exchange.GetExchangeRate(batch.BatchCurrency, InvoiceCurrency);
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
        public decimal? FinanceLineOutstanding
        {
            get
            {
                CDA cda = ActiveCDA;
                return cda != null ? cda.FinanceLineOutstanding : null;
            }
        }

        /// <summary>
        /// Gets �������
        /// </summary>
        public decimal? FinanceOutstanding
        {
            get
            {
                if (_financeOutstanding.HasValue == false)
                {
                    decimal? total = null;
                    foreach (InvoiceAssignBatch assignBatch in InvoiceAssignBatches)
                    {
                        //if (assignBatch.CheckStatus == BATCH.CHECK)
                        //{
                        foreach (Invoice invoice in assignBatch.Invoices)
                        {
                            if (invoice.FinanceOutstanding.HasValue)
                            {
                                if (total == null)
                                {
                                    total = 0;
                                }

                                decimal financeOutstanding = invoice.FinanceOutstanding.Value;
                                total += financeOutstanding;
                            }
                        }
                        //}
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
                CDA cda = ActiveCDA;
                return cda != null ? cda.FinanceProportion : null;
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
                    case "������������":
                    case "���ڱ���":
                        return SellerClient;
                    case "�����򷽱���":
                    case "���ڱ���":
                        return BuyerClient;
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ClientCreditLine HighestFinanceLine
        {
            get
            {
                if (IsPool)
                {
                    return SellerClient.PoolFinanceCreditLine;
                }
                if (TransactionType == "�����򷽱���" || TransactionType == "���ڱ���")
                {
                    return BuyerClient.FinanceCreditLine;
                }
                return SellerClient.FinanceCreditLine;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? HighestFinanceLineAmount
        {
            get
            {
                if (HighestFinanceLine != null)
                {
                    return HighestFinanceLine.CreditLine;
                }

                return null;
            }
        }

        //?Public?Methods?(2)?
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Invoice> Invoices
        {
            get
            {
                var result = new List<Invoice>();
                foreach (InvoiceAssignBatch batch in InvoiceAssignBatches)
                {
                    result.AddRange(batch.Invoices);
                }

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        //public decimal? MarginIncomeByDate
        //{
        //    get
        //    {
        //        if (_marginIncomeByDate.HasValue == false)
        //        {
        //            decimal? result = null;
        //            DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
        //            DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
        //            IEnumerable<InvoiceFinanceBatch> batches =
        //                InvoiceFinanceBatches.Where(
        //                    i => i.FinancePeriodBegin >= fromDate && i.FinancePeriodBegin <= toDate);
        //            foreach (InvoiceFinanceBatch batch in batches)
        //            {
        //                if (batch.FinanceType == "��������" || batch.FinanceType == "�򷽴���")
        //                {
        //                    if (result == null)
        //                    {
        //                        result = 0;
        //                    }

        //                    result += batch.MarginIncome;
        //                }
        //            }

        //            _marginIncomeByDate = result;
        //        }

        //        return _marginIncomeByDate;
        //    }
        //}

        public decimal? InterestIncomeByDate
        {
            get
            {
                if (_interestIncomeByDate.HasValue == false)
                {
                    decimal? result = null;
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoiceFinanceBatch> batches =
                        InvoiceFinanceBatches.Where(
                            i => i.FinancePeriodBegin >= fromDate && i.FinancePeriodBegin <= toDate);
                    foreach (InvoiceFinanceBatch batch in batches)
                    {
                        if (batch.FinanceType != "��������" && batch.FinanceType != "�򷽴���")
                        {
                            if (result == null)
                            {
                                result = 0;
                            }

                            result += batch.Interest;
                        }
                    }

                    _interestIncomeByDate = result;
                }

                return _interestIncomeByDate;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal PaymentAmountByDate
        {
            get
            {
                if (_paymentAmountByDate.HasValue == false)
                {
                    DateTime fromDate = QueryDateFrom < TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo < TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                    IEnumerable<InvoicePaymentBatch> batches =
                        InvoicePaymentBatches.Where(i => i.PaymentDate >= fromDate && i.PaymentDate <= toDate);
                    decimal result = batches.Sum(batch => batch.PaymentAmount);

                    _paymentAmountByDate = result;
                }

                return _paymentAmountByDate.Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal RefundAmountByDate
        {
            get
            {
                if (_refundAmountByDate.HasValue == false)
                {
                    DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                    DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;

                    IEnumerable<InvoiceRefundBatch> batches = InvoiceRefundBatches.Where(i => i.RefundDate >= fromDate && i.RefundDate <= toDate);
                    decimal result = batches.Sum(batch => batch.RefundAmount.GetValueOrDefault());

                    _refundAmountByDate = result;
                }

                return _refundAmountByDate.Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime QueryDateFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime QueryDateTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Client TargetClient
        {
            get
            {
                switch (TransactionType)
                {
                    case "������������":
                    case "���ڱ���":
                        return BuyerClient;
                    case "�����򷽱���":
                    case "���ڱ���":
                        return SellerClient;
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal TotalAssignOutstanding
        {
            get
            {
                if (_totalAssignOutstanding.HasValue == false)
                {
                    _totalAssignOutstanding = SellerClient.GetAssignOutstandingAsSeller(TransactionType, InvoiceCurrency);
                }

                return _totalAssignOutstanding.Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal TotalFinanceOutstanding
        {
            get
            {
                switch (TransactionType)
                {
                    case "������������":
                    case "���ڱ���":
                        return SellerClient.GetFinanceOutstanding(InvoiceCurrency).GetValueOrDefault();
                    case "�����򷽱���":
                    case "���ڱ���":
                        return BuyerClient.GetFinanceOutstanding(InvoiceCurrency).GetValueOrDefault();
                    default:
                        return 0;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? TotalIncomeByDate
        {
            get
            {
                return CommissionIncomeByDate;
                //+NetInterestIncomeByDate.GetValueOrDefault();
                //+
                //       MarginIncomeByDate.GetValueOrDefault();
            }
        }

        public decimal PoolValuedAssignOutstanding
        {
            get
            {
                if (_poolValuedAssignOutstanding.HasValue == false)
                {
                    double financeProp = ActiveCDA.FinanceProportion.GetValueOrDefault();
                    decimal total = 0;
                    foreach (InvoiceAssignBatch batch in InvoiceAssignBatches)
                    {
                        total += batch.Invoices.Where(invoice => !invoice.IsDispute.GetValueOrDefault()
                                                                     && !invoice.IsFlaw && DateTime.Today.AddDays(0 - ActiveCDA.PoolInvoiceGraceDays.GetValueOrDefault()) < invoice.DueDate
                                                                         ).Sum(invoice => invoice.AssignOutstanding);
                    }
                    _poolValuedAssignOutstanding = total;
                }

                return _poolValuedAssignOutstanding.Value;
            }
        }

        /// <summary>
        /// ���������������ڱ�����Ч��ת�����
        /// </summary>
        public decimal SellerValuedAssignOutstanding
        {
            get
            {
                if (_sellerValuedAssignOutstanding.HasValue == false)
                {
                    double financeProp = ActiveCDA.FinanceProportion.GetValueOrDefault();
                    decimal total = 0;
                    foreach (InvoiceAssignBatch batch in InvoiceAssignBatches)
                    {
                        if (batch.IsRefinance)
                        {
                            total += batch.Invoices.Where(invoice => !invoice.IsDispute.GetValueOrDefault()
                                                                  && !invoice.IsFlaw && DateTime.Today < invoice.DueDate
                                                                  && (invoice.FinanceAmount.HasValue == false
                                                                      || invoice.FinanceAmount.GetValueOrDefault() < invoice.AssignAmount * (decimal)financeProp)
                                                                      ).Sum(invoice => invoice.AssignOutstanding);
                        }
                        else
                        {
                            if (!batch.IsRefinanced)
                            {
                                total += batch.Invoices.Where(invoice => !invoice.IsDispute.GetValueOrDefault() && !invoice.IsFlaw && DateTime.Today < invoice.DueDate).Sum(invoice => invoice.AssignOutstanding);
                            }
                        }
                    }

                    _sellerValuedAssignOutstanding = total;
                }

                return _sellerValuedAssignOutstanding.Value;
            }
        }

        /// <summary>
        /// ���ڹ����򷽱���
        /// </summary>
        public decimal BuyerValuedAssignOutstanding
        {
            get
            {
                if (_buyerValuedAssignOutstanding.HasValue == false)
                {
                    double financeProp = ActiveCDA.FinanceProportion.GetValueOrDefault();
                    decimal total = 0;
                    foreach (InvoiceAssignBatch batch in InvoiceAssignBatches)
                    {
                        if (batch.IsRefinance)
                        {
                            total += batch.Invoices.Where(invoice => !invoice.IsDispute.GetValueOrDefault() && !invoice.IsFlaw && (invoice.FinanceAmount.HasValue == false || invoice.FinanceAmount.GetValueOrDefault() - invoice.AssignAmount * (decimal)financeProp < 0)).Sum(invoice => invoice.AssignOutstanding);
                        }
                        else
                        {
                            if (!batch.IsRefinanced)
                            {
                                total += batch.Invoices.Where(invoice => !invoice.IsDispute.GetValueOrDefault() && !invoice.IsFlaw).Sum(invoice => invoice.AssignOutstanding);
                            }
                        }
                    }

                    _buyerValuedAssignOutstanding = total;
                }

                return _buyerValuedAssignOutstanding.Value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="locationCode"></param>
        /// <param name="appDate"></param>
        /// <returns></returns>
        public static string GenerateCaseCode(string transactionType, string locationCode, DateTime appDate)
        {
            var context = new DBDataContext();
            string year = String.Format("{0:yyyy}", appDate);
            string typeCode;
            switch (transactionType)
            {
                case "���ڱ���":
                    typeCode = "EX";
                    break;
                case "���ڱ���":
                    typeCode = "IM";
                    break;
                case "������������":
                    typeCode = "SE";
                    break;
                case "�����򷽱���":
                    typeCode = "BY";
                    break;
                default:
                    typeCode = "  ";
                    break;
            }

            string prefix = null;
            if (locationCode != null)
            {
                prefix = String.Format("69{0}{1}{2}", locationCode, typeCode, year);
            }
            else
            {
                prefix = String.Format("{0}{1}", typeCode, year);
            }
            int caseCount = 0;
            IEnumerable<string> queryStr = from c in context.Cases
                                           where c.CaseCode.StartsWith(prefix)
                                           select c.CaseCode.Substring(8);
            foreach (string value in queryStr)
            {
                if (caseCount < Convert.ToInt32(value))
                {
                    caseCount = Convert.ToInt32(value);
                }
            }
            string caseCode = String.Format("{0}{1:D4}", prefix, caseCount + 1);
            return caseCode;
        }


        /// <summary>
        /// 
        /// </summary>
        public bool IsClear
        {
            get { return !InvoiceAssignBatches.Any(i => i.IsClear == false); }
        }

        public string SellerClientName
        {
            get { return String.IsNullOrEmpty(SellerClient.ClientNameCN) ? SellerClient.ClientNameEN : SellerClient.ClientNameCN; }
        }

        public string SellerFactorName
        {
            get { return String.IsNullOrEmpty(SellerFactor.CompanyNameCN) ? SellerFactor.CompanyNameEN : SellerFactor.CompanyNameCN; }
        }

        public string BuyerClientName
        {
            get { return String.IsNullOrEmpty(BuyerClient.ClientNameCN) ? BuyerClient.ClientNameEN : BuyerClient.ClientNameCN; }
        }

        public string BuyerFactorName
        {
            get { return String.IsNullOrEmpty(BuyerFactor.CompanyNameCN) ? BuyerFactor.CompanyNameEN : BuyerFactor.CompanyNameCN; }
        }

        public string OwnerDepartmentName
        {
            get { return OwnerDepartment.DepartmentName; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="locationCode"></param>
        /// <param name="appDate"></param>
        /// <param name="casesInMemory"></param>
        /// <returns></returns>
        public static string GenerateCaseCode(string transactionType, string locationCode, DateTime appDate,
                                              List<Case> casesInMemory)
        {
            var context = new DBDataContext();
            string year = String.Format("{0:yy}", appDate);
            string typeCode;
            switch (transactionType)
            {
                case "���ڱ���":
                    typeCode = "EX";
                    break;
                case "���ڱ���":
                    typeCode = "IM";
                    break;
                case "������������":
                    typeCode = "SE";
                    break;
                case "�����򷽱���":
                    typeCode = "BY";
                    break;
                default:
                    typeCode = "  ";
                    break;
            }

            string prefix = String.Format("69{0}{1}{2}", locationCode, typeCode, year);
            int caseCount = 0;
            IEnumerable<string> queryStr = from c in context.Cases
                                           where c.CaseCode.StartsWith(prefix)
                                           select c.CaseCode.Substring(8);

            foreach (string value in queryStr)
            {
                if (caseCount < Convert.ToInt32(value))
                {
                    caseCount = Convert.ToInt32(value);
                }
            }

            caseCount += casesInMemory.Count(c => c.CaseCode.StartsWith(prefix));
            string caseCode = String.Format("{0}{1:D4}", prefix, caseCount + 1);
            return caseCode;
        }
    }
}
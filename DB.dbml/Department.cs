//-----------------------------------------------------------------------
// <copyright file="Department.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Department
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<String> AllDomains
        {
            get
            {
                var allDomains = new List<string>
                                     {
                                         "贸易金融事业部",
                                         "分行营业部",
                                         "地产金融事业部",
                                         "交通金融事业部",
                                         "金融市场事业部",
                                         "能源金融事业部",
                                         "冶金金融事业部",
                                         "中小企业金融事业部"
                                     };
                return allDomains;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double AssignAmountByDate
        {
            get
            {
                double result = 0;
                DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                foreach (Case selectedCase in OwnerCases.Where(c => c.CaseMark == CASE.ENABLE))
                {
                    IEnumerable<InvoiceAssignBatch> batches =
                        selectedCase.InvoiceAssignBatches.Where(i => i.AssignDate >= fromDate && i.AssignDate <= toDate);
                    foreach (InvoiceAssignBatch batch in batches)
                    {
                        double assign = batch.AssignAmount;
                        if (selectedCase.InvoiceCurrency != "CNY")
                        {
                            double rate = Exchange.GetExchangeRate(batch.BatchCurrency, "CNY");
                            assign *= rate;
                        }
                        result += assign;
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Assistant
        {
            get { return Location.Assistant; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double CommissionIncomeByDate
        {
            get
            {
                double result = 0;
                DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                foreach (Case selectedCase in OwnerCases.Where(c => c.CaseMark == CASE.ENABLE))
                {
                    selectedCase.QueryDateFrom = fromDate;
                    selectedCase.QueryDateTo = toDate;
                    double commission = selectedCase.CommissionIncomeByDate;
                    if (selectedCase.InvoiceCurrency != "CNY" && TypeUtil.GreaterZero(commission))
                    {
                        double rate = Exchange.GetExchangeRate(selectedCase.InvoiceCurrency, "CNY");
                        commission *= rate;
                    }

                    result += commission;
                }

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double FinanceAmountByDate
        {
            get
            {
                double result = 0;
                DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                foreach (Case selectedCase in OwnerCases.Where(c => c.CaseMark == CASE.ENABLE))
                {
                    IEnumerable<InvoiceFinanceBatch> batches =
                        selectedCase.InvoiceFinanceBatches.Where(
                            i => i.FinancePeriodBegin >= fromDate && i.FinancePeriodBegin <= toDate);
                    foreach (InvoiceFinanceBatch batch in batches)
                    {
                        double finance = batch.FinanceAmount;
                        if (batch.BatchCurrency != "CNY")
                        {
                            double rate = Exchange.GetExchangeRate(batch.BatchCurrency, "CNY");
                            finance *= rate;
                        }

                        result += finance;
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LocationName
        {
            get { return Location.LocationName; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? MarginIncomeByDate
        {
            get
            {
                double? result = null;
                DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                foreach (Case selectedCase in OwnerCases.Where(c => c.CaseMark == CASE.ENABLE))
                {
                    selectedCase.QueryDateFrom = fromDate;
                    selectedCase.QueryDateTo = toDate;
                    double? marginIncome = selectedCase.MarginIncomeByDate;
                    if (selectedCase.InvoiceCurrency != "CNY" && TypeUtil.GreaterZero(marginIncome))
                    {
                        double rate = Exchange.GetExchangeRate(selectedCase.InvoiceCurrency, "CNY");
                        marginIncome *= rate;
                    }

                    if (marginIncome.HasValue && result == null)
                    {
                        result = 0;
                    }

                    result += marginIncome.GetValueOrDefault();
                }

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? NetInterestIncomeByDate
        {
            get
            {
                double? result = null;
                DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                foreach (Case selectedCase in OwnerCases.Where(c => c.CaseMark == CASE.ENABLE))
                {
                    selectedCase.QueryDateFrom = fromDate;
                    selectedCase.QueryDateTo = toDate;
                    double? netInterest = selectedCase.NetInterestIncomeByDate;
                    if (selectedCase.InvoiceCurrency != "CNY" && TypeUtil.GreaterZero(netInterest))
                    {
                        double rate = Exchange.GetExchangeRate(selectedCase.InvoiceCurrency, "CNY");
                        netInterest *= rate;
                    }

                    if (netInterest.HasValue && result == null)
                    {
                        result = 0;
                    }

                    result += netInterest.GetValueOrDefault();
                }

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double PaymentAmountByDate
        {
            get
            {
                double result = 0;
                DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;

                foreach (Case selectedCase in OwnerCases.Where(c => c.CaseMark == CASE.ENABLE))
                {
                    IEnumerable<InvoicePaymentBatch> batches =
                        selectedCase.InvoicePaymentBatches.Where(
                            i => i.PaymentDate >= fromDate && i.PaymentDate <= toDate);
                    foreach (InvoicePaymentBatch batch in batches)
                    {
                        double payment = batch.PaymentAmount;
                        if (selectedCase.InvoiceCurrency != "CNY")
                        {
                            double rate = Exchange.GetExchangeRate(selectedCase.InvoiceCurrency, "CNY");
                            payment *= rate;
                        }

                        result += payment;
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string PManager
        {
            get { return Location.PManager; }
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
        public double TotalIncomeByDate
        {
            get
            {
                return CommissionIncomeByDate + NetInterestIncomeByDate.GetValueOrDefault() +
                       MarginIncomeByDate.GetValueOrDefault();
            }
        }


        //?Public?Methods?(3)?
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Department> AllDepartments(DBDataContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            var allDepartment = new List<Department>();
            allDepartment.AddRange(context.Departments.Where(d => d.Domain == "贸易金融事业部"));
            allDepartment.AddRange(context.Departments.Where(d => d.Domain == "分行营业部"));
            allDepartment.AddRange(context.Departments.Where(d => d.Domain != "贸易金融事业部" && d.Domain != "分行事业部"));

            return allDepartment;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="domainName"></param>
        /// <returns></returns>
        public static List<Department> AllDepartments(DBDataContext context, string domainName)
        {
            List<Department> allDepartment = AllDepartments(context);
            return allDepartment.Where(d => d._Domain == domainName).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _DepartmentName;
        }
    }
}
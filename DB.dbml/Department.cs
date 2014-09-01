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
        public decimal AssignAmountByDate
        {
            get
            {
                decimal result = 0;
                DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                foreach (Case selectedCase in OwnerCases.Where(c => c.CaseMark == CASE.ENABLE))
                {
                    IEnumerable<InvoiceAssignBatch> batches =
                        selectedCase.InvoiceAssignBatches.Where(i => i.AssignDate >= fromDate && i.AssignDate <= toDate);
                    foreach (InvoiceAssignBatch batch in batches)
                    {
                        decimal assign = batch.AssignAmount;
                        if (selectedCase.InvoiceCurrency != "CNY")
                        {
                            decimal rate = Exchange.GetExchangeRate(batch.BatchCurrency, "CNY");
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
        public decimal CommissionIncomeByDate
        {
            get
            {
                decimal result = 0;
                DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                foreach (Case selectedCase in OwnerCases.Where(c => c.CaseMark == CASE.ENABLE))
                {
                    selectedCase.QueryDateFrom = fromDate;
                    selectedCase.QueryDateTo = toDate;
                    decimal commission = selectedCase.CommissionIncomeByDate;
                    if (selectedCase.InvoiceCurrency != "CNY" && commission>0)
                    {
                        decimal rate = Exchange.GetExchangeRate(selectedCase.InvoiceCurrency, "CNY");
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
        public decimal FinanceAmountByDate
        {
            get
            {
                decimal result = 0;
                DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                foreach (Case selectedCase in OwnerCases.Where(c => c.CaseMark == CASE.ENABLE))
                {
                    IEnumerable<InvoiceFinanceBatch> batches =
                        selectedCase.InvoiceFinanceBatches.Where(
                            i => i.FinancePeriodBegin >= fromDate && i.FinancePeriodBegin <= toDate);
                    foreach (InvoiceFinanceBatch batch in batches)
                    {
                        decimal finance = batch.FinanceAmount;
                        if (batch.BatchCurrency != "CNY")
                        {
                            decimal rate = Exchange.GetExchangeRate(batch.BatchCurrency, "CNY");
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
        //public decimal? MarginIncomeByDate
        //{
        //    get
        //    {
        //        decimal? result = null;
        //        DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
        //        DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
        //        foreach (Case selectedCase in OwnerCases.Where(c => c.CaseMark == CASE.ENABLE))
        //        {
        //            selectedCase.QueryDateFrom = fromDate;
        //            selectedCase.QueryDateTo = toDate;
        //            decimal? marginIncome = selectedCase.MarginIncomeByDate;
        //            if (selectedCase.InvoiceCurrency != "CNY" && marginIncome>0)
        //            {
        //                decimal rate = Exchange.GetExchangeRate(selectedCase.InvoiceCurrency, "CNY");
        //                marginIncome *= rate;
        //            }

        //            if (marginIncome.HasValue && result == null)
        //            {
        //                result = 0;
        //            }

        //            result += marginIncome.GetValueOrDefault();
        //        }

        //        return result;
        //    }
        //}

        /// <summary>
        /// 
        /// </summary>
        //public decimal? NetInterestIncomeByDate
        //{
        //    get
        //    {
        //        decimal? result = null;
        //        DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
        //        DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
        //        foreach (Case selectedCase in OwnerCases.Where(c => c.CaseMark == CASE.ENABLE))
        //        {
        //            selectedCase.QueryDateFrom = fromDate;
        //            selectedCase.QueryDateTo = toDate;
        //            decimal? netInterest = selectedCase.NetInterestIncomeByDate;
        //            if (selectedCase.InvoiceCurrency != "CNY" && netInterest>0)
        //            {
        //                decimal rate = Exchange.GetExchangeRate(selectedCase.InvoiceCurrency, "CNY");
        //                netInterest *= rate;
        //            }

        //            if (netInterest.HasValue && result == null)
        //            {
        //                result = 0;
        //            }

        //            result += netInterest.GetValueOrDefault();
        //        }

        //        return result;
        //    }
        //}

        /// <summary>
        /// 
        /// </summary>
        public decimal PaymentAmountByDate
        {
            get
            {
                decimal result = 0;
                DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;

                foreach (Case selectedCase in OwnerCases.Where(c => c.CaseMark == CASE.ENABLE))
                {
                    IEnumerable<InvoicePaymentBatch> batches =
                        selectedCase.InvoicePaymentBatches.Where(
                            i => i.PaymentDate >= fromDate && i.PaymentDate <= toDate);
                    foreach (InvoicePaymentBatch batch in batches)
                    {
                        decimal payment = batch.PaymentAmount;
                        if (selectedCase.InvoiceCurrency != "CNY")
                        {
                            decimal rate = Exchange.GetExchangeRate(selectedCase.InvoiceCurrency, "CNY");
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
        public decimal TotalIncomeByDate
        {
            get
            {
                return CommissionIncomeByDate;
                //+NetInterestIncomeByDate.GetValueOrDefault();
                //+
                  //     MarginIncomeByDate.GetValueOrDefault();
            }
        }

        private static readonly List<Department> _allDepartments = InitializeDepartments();

        /// <summary>
        /// 
        /// </summary>
        public static List<Department> AllDepartments
        {
            get
            {
                return _allDepartments.ToList();
            }
        }

        public static List<Department> GetAllDepartments(DBDataContext context)
        {
            var allDepartment = new List<Department>();
            allDepartment.AddRange(context.Departments.Where(d => d.Domain == "贸易金融事业部"));
            allDepartment.AddRange(context.Departments.Where(d => d.Domain == "分行营业部"));
            allDepartment.AddRange(context.Departments.Where(d => d.Domain != "贸易金融事业部" && d.Domain != "分行营业部"));

            return allDepartment;
        }

        //?Public?Methods?(3)?
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static List<Department> InitializeDepartments()
        {
            var context = new DBDataContext { ObjectTrackingEnabled = false };
            var allDepartment = new List<Department>();
            allDepartment.AddRange(context.Departments.Where(d => d.Domain == "贸易金融事业部"));
            allDepartment.AddRange(context.Departments.Where(d => d.Domain == "分行营业部"));
            allDepartment.AddRange(context.Departments.Where(d => d.Domain != "贸易金融事业部" && d.Domain != "分行营业部"));

            return allDepartment;
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
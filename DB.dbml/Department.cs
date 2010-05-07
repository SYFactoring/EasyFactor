//-----------------------------------------------------------------------
// <copyright file="Department.cs" company="Yiming Liu@Fudan">
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

    /// <summary>
    /// 
    /// </summary>
    public partial class Department
    {
		#region?Properties?(16)?

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<String> AllDomains
        {
            get
            {
                List<String> allDomains = new List<string>();
                allDomains.Add("ó�׽�����ҵ��");
                allDomains.Add("����Ӫҵ��");
                allDomains.Add("�ز�������ҵ��");
                allDomains.Add("��ͨ������ҵ��");
                allDomains.Add("�����г���ҵ��");
                allDomains.Add("��Դ������ҵ��");
                allDomains.Add("ұ�������ҵ��");
                allDomains.Add("��С��ҵ������ҵ��");
                return allDomains;
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
                foreach (Case selectedCase in this.OwnerCases.Where(c => c.CaseMark == CASEStr.ENABLE))
                {
                    foreach (InvoiceAssignBatch batch in selectedCase.InvoiceAssignBatches)
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
        public double AssignAmountByDate
        {
            get
            {
                double result = 0;
                DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                foreach (Case selectedCase in this.OwnerCases.Where(c => c.CaseMark == CASEStr.ENABLE))
                {
                    IEnumerable<InvoiceAssignBatch> batches = selectedCase.InvoiceAssignBatches.Where(i => i.AssignDate >= fromDate && i.AssignDate <= toDate);
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
            get
            {
                return this.Location.Assistant;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string City
        {
            get
            {
                return this.Location.LocationName;
            }
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
                foreach (Case selectedCase in this.OwnerCases.Where(c => c.CaseMark == CASEStr.ENABLE))
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
        public double FinanceAmount
        {
            get
            {
                double result = 0;
                foreach (Case selectedCase in this.OwnerCases.Where(c => c.CaseMark == CASEStr.ENABLE))
                {
                    foreach (InvoiceFinanceBatch batch in selectedCase.InvoiceFinanceBatches)
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
        public double FinanceAmountByDate
        {
            get
            {
                double result = 0;
                DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                foreach (Case selectedCase in this.OwnerCases.Where(c => c.CaseMark == CASEStr.ENABLE))
                {
                    IEnumerable<InvoiceFinanceBatch> batches = selectedCase.InvoiceFinanceBatches.Where(i => i.FinancePeriodBegin >= fromDate && i.FinancePeriodBegin <= toDate);
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
        public double? MarginIncomeByDate
        {
            get
            {
                double? result = null;
                DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;
                foreach (Case selectedCase in this.OwnerCases.Where(c => c.CaseMark == CASEStr.ENABLE))
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
                foreach (Case selectedCase in this.OwnerCases.Where(c => c.CaseMark == CASEStr.ENABLE))
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
        public double PaymentAmount
        {
            get
            {
                double result = 0;
                foreach (Case selectedCase in this.OwnerCases.Where(c => c.CaseMark == CASEStr.ENABLE))
                {
                    foreach (InvoicePaymentBatch batch in selectedCase.InvoicePaymentBatches)
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
        public double PaymentAmountByDate
        {
            get
            {
                double result = 0;
                DateTime fromDate = QueryDateFrom == TypeUtil.MIN_DATE ? TypeUtil.MIN_DATE : QueryDateFrom;
                DateTime toDate = QueryDateTo == TypeUtil.MIN_DATE ? DateTime.MaxValue : QueryDateTo;

                foreach (Case selectedCase in this.OwnerCases.Where(c => c.CaseMark == CASEStr.ENABLE))
                {
                    IEnumerable<InvoicePaymentBatch> batches = selectedCase.InvoicePaymentBatches.Where(i => i.PaymentDate >= fromDate && i.PaymentDate <= toDate);
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
            get
            {
                return this.Location.PManager;
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
        public double TotalIncomeByDate
        {
            get
            {
                return this.CommissionIncomeByDate + this.NetInterestIncomeByDate.GetValueOrDefault() + this.MarginIncomeByDate.GetValueOrDefault();
            }
        }

		#endregion?Properties?

		#region?Methods?(3)?

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

            List<Department> _allDepartment = new List<Department>();
            _allDepartment.AddRange(context.Departments.Where(d => d.Domain == "ó�׽�����ҵ��"));
            _allDepartment.AddRange(context.Departments.Where(d => d.Domain == "����Ӫҵ��"));
            _allDepartment.AddRange(context.Departments.Where(d => d.Domain != "ó�׽�����ҵ��" && d.Domain != "������ҵ��"));

            return _allDepartment;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="domainName"></param>
        /// <returns></returns>
        public static List<Department> AllDepartments(DBDataContext context, string domainName)
        {
            List<Department> _allDepartment = AllDepartments(context);
            return _allDepartment.Where(d => d._Domain == domainName).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this._DepartmentName;
        }

		#endregion?Methods?
    }

    /// <summary>
    /// 
    /// </summary>
    public class City
    {
		#region?Constructors?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loc"></param>
        /// <param name="depts"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public City(string loc, List<Department> depts, DateTime from, DateTime to)
        {
            Location = loc;

            foreach (Department dept in depts)
            {
                dept.QueryDateFrom = from;
                dept.QueryDateTo = to;
                AssignAmountByDate += dept.AssignAmountByDate;
                FinanceAmountByDate += dept.FinanceAmountByDate;
                PaymentAmountByDate += dept.PaymentAmountByDate;
                CommissionIncomeByDate += dept.CommissionIncomeByDate;
                NetInterestIncomeByDate += dept.NetInterestIncomeByDate;
                MarginIncomeByDate += dept.MarginIncomeByDate;
                TotalIncomeByDate += dept.TotalIncomeByDate;
            }
        }

		#endregion?Constructors?

		#region?Properties?(8)?

        /// <summary>
        /// 
        /// </summary>
        public double AssignAmountByDate
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double CommissionIncomeByDate
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double FinanceAmountByDate
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Location
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double? MarginIncomeByDate
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double? NetInterestIncomeByDate
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PaymentAmountByDate
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double TotalIncomeByDate
        {
            get;
            set;
        }

		#endregion?Properties?
    }
}

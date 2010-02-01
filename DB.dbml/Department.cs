//-----------------------------------------------------------------------
// <copyright file="Department.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System.Collections.Generic;
    using System.Linq;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class Department
    {
        #region Properties (6)

        /// <summary>
        /// 
        /// </summary>
        public double AssignAmount
        {
            get
            {
                double result = 0;
                foreach (Case selectedCase in this.OwnerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE))
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
        public double CommissionAmount
        {
            get
            {
                double result = 0;
                foreach (Case selectedCase in this.OwnerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE))
                {
                    foreach (InvoiceAssignBatch batch in selectedCase.InvoiceAssignBatches)
                    {
                        foreach (Invoice invoice in batch.Invoices)
                        {
                            double commission = invoice.Commission.GetValueOrDefault();
                            if (selectedCase.InvoiceCurrency != "CNY")
                            {
                                double rate = Exchange.GetExchangeRate(batch.BatchCurrency, "CNY");
                                commission *= rate;
                            }

                            result += commission;
                        }
                    }
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
                foreach (Case selectedCase in this.OwnerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE))
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
        public double HandFeeAmount
        {
            get
            {
                double result = 0;
                foreach (Case selectedCase in this.OwnerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE))
                {
                    int count = 0;
                    foreach (InvoiceAssignBatch batch in selectedCase.InvoiceAssignBatches)
                    {
                        count += batch.BatchCount;
                    }

                    CDA cda = selectedCase.ActiveCDA;
                    if (cda != null)
                    {
                        double handfee = count * cda.HandFee.GetValueOrDefault();
                        if (cda.HandFeeCurr != "CNY")
                        {
                            double rate = Exchange.GetExchangeRate(cda.HandFeeCurr, "CNY");
                            handfee *= rate;
                        }

                        result += handfee;
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double IncomeAmount
        {
            get
            {
                return CommissionAmount + HandFeeAmount;
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
                foreach (Case selectedCase in this.OwnerCases.Where(c => c.CaseMark == ConstStr.CASE.ENABLE))
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

        #endregion Properties

        #region Methods (3)

        // Public Methods (3) 

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Department> AllDepartments(DBDataContext context)
        {
            List<Department> _allDepartment = new List<Department>();
            _allDepartment.AddRange(context.Departments.Where(d => d.Domain == "贸易金融事业部"));
            _allDepartment.AddRange(context.Departments.Where(d => d.Domain == "分行营业部"));
            _allDepartment.AddRange(context.Departments.Where(d => d.Domain != "贸易金融事业部" && d.Domain != "分行事业部"));

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

        #endregion Methods
    }

    /// <summary>
    /// 
    /// </summary>
    public class City
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loc"></param>
        /// <param name="depts"></param>
        public City(string loc, List<Department> depts)
        {
            Location = loc;

            foreach (Department dept in depts)
            {
                AssignAmount += dept.AssignAmount;
                FinanceAmount += dept.FinanceAmount;
                PaymentAmount += dept.PaymentAmount;
                IncomeAmount += dept.IncomeAmount;
            }
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
        public double AssignAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double FinanceAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PaymentAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double IncomeAmount
        {
            get;
            set;
        }
    }
}

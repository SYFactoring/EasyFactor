//-----------------------------------------------------------------------
// <copyright file="Location.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public partial class Location
    {
        /// <summary>
        /// 
        /// </summary>
        private static readonly List<Location> LocationList = InitializeLocation();
        /// <summary>
        /// 
        /// </summary>
        public static List<Location> AllLocations
        {
            get
            {
                return LocationList.ToList();
            }
        }

        public static List<Location> GetAllLocations(DBDataContext context)
        {
            return context.Locations.ToList();
        }

		//?Private?Methods?(1)?
        /// <summary>
        /// Initializes static members of the Country class
        /// </summary>
        static List<Location> InitializeLocation()
        {
            var context = new DBDataContext {ObjectTrackingEnabled = false};
            return context.Locations.ToList();
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
        public decimal AssignAmountByDate
        {
            get
            {
                decimal result = 0;
                foreach (Department dept in Departments)
                {
                    dept.QueryDateFrom = QueryDateFrom;
                    dept.QueryDateTo = QueryDateTo;
                    result += dept.AssignAmountByDate;
                }

                return result;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal CommissionIncomeByDate
        {
            get
            {
                decimal result = 0;
                foreach (Department dept in Departments)
                {
                    dept.QueryDateFrom = QueryDateFrom;
                    dept.QueryDateTo = QueryDateTo;
                    result += dept.CommissionIncomeByDate;
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
                foreach (Department dept in Departments)
                {
                    dept.QueryDateFrom = QueryDateFrom;
                    dept.QueryDateTo = QueryDateTo;
                    result += dept.FinanceAmountByDate;
                }

                return result;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        //public decimal MarginIncomeByDate
        //{
        //    get
        //    {
        //        decimal result = 0;
        //        foreach (Department dept in Departments)
        //        {
        //            dept.QueryDateFrom = QueryDateFrom;
        //            dept.QueryDateTo = QueryDateTo;
        //            result += dept.MarginIncomeByDate.GetValueOrDefault();
        //        }

        //        return result;
        //    }
        //}
        /// <summary>
        /// 
        /// </summary>
        //public decimal NetInterestIncomeByDate
        //{
        //    get
        //    {
        //        decimal result = 0;
        //        foreach (Department dept in Departments)
        //        {
        //            dept.QueryDateFrom = QueryDateFrom;
        //            dept.QueryDateTo = QueryDateTo;
        //            result += dept.NetInterestIncomeByDate.GetValueOrDefault();
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
                foreach (Department dept in Departments)
                {
                    dept.QueryDateFrom = QueryDateFrom;
                    dept.QueryDateTo = QueryDateTo;
                    result += dept.PaymentAmountByDate;
                }

                return result;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal TotalIncomeByDate
        {
            get
            {
                decimal result = 0;
                foreach (Department dept in Departments)
                {
                    dept.QueryDateFrom = QueryDateFrom;
                    dept.QueryDateTo = QueryDateTo;
                    result += dept.TotalIncomeByDate;
                }

                return result;
            }
        }
    }
}

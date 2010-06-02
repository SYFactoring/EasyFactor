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
        public double AssignAmountByDate
        {
            get
            {
                double result = 0;
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
        public double CommissionIncomeByDate
        {
            get
            {
                double result = 0;
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
        public double FinanceAmountByDate
        {
            get
            {
                double result = 0;
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
        public double MarginIncomeByDate
        {
            get
            {
                double result = 0;
                foreach (Department dept in Departments)
                {
                    dept.QueryDateFrom = QueryDateFrom;
                    dept.QueryDateTo = QueryDateTo;
                    result += dept.MarginIncomeByDate.GetValueOrDefault();
                }

                return result;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public double NetInterestIncomeByDate
        {
            get
            {
                double result = 0;
                foreach (Department dept in Departments)
                {
                    dept.QueryDateFrom = QueryDateFrom;
                    dept.QueryDateTo = QueryDateTo;
                    result += dept.NetInterestIncomeByDate.GetValueOrDefault();
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
        public double TotalIncomeByDate
        {
            get
            {
                double result = 0;
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

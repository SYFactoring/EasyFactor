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
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public partial class Department
    {
		#region Fields (1) 

        /// <summary>
        /// 
        /// </summary>
        private static readonly List<Department> _allDepartment;

		#endregion Fields 

		#region Constructors (1) 

        /// <summary>
        /// Initializes static members of the Department class
        /// </summary>
        static Department()
        {
            _allDepartment = new List<Department>();
            _allDepartment.AddRange(App.Current.DbContext.Departments.Where(d => d.Domain == "贸易金融事业部"));
            _allDepartment.AddRange(App.Current.DbContext.Departments.Where(d => d.Domain == "分行营业部"));
            _allDepartment.AddRange(App.Current.DbContext.Departments.Where(d => d.Domain != "贸易金融事业部" && d.Domain != "分行事业部"));
        }

		#endregion Constructors 

		#region Methods (3) 

		// Public Methods (3) 

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Department> AllDepartments()
        {
            return _allDepartment;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="domainName"></param>
        /// <returns></returns>
        public static List<Department> AllDepartments(string domainName)
        {
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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
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
        /// 
        /// </summary>
        static Department()
        {
            _allDepartment = new List<Department>();
            _allDepartment.AddRange(App.Current.DbContext.Departments.Where(d => d.Domain == "贸易金融事业部"));
            _allDepartment.AddRange(App.Current.DbContext.Departments.Where(d => d.Domain == "分行营业部"));
            _allDepartment.AddRange(App.Current.DbContext.Departments.Where(d => d.Domain != "贸易金融事业部" && d.Domain != "分行事业部"));
        }

        #endregion Constructors

        #region Methods (2)

        // Public Methods (2) 

        public static List<Department> AllDepartments()
        {
            return _allDepartment;
        }

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

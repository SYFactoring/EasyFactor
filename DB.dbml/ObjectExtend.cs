//-----------------------------------------------------------------------
// <copyright file="ObjectExtend.cs" company="Yiming Liu@Fudan" >
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System.Linq;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public partial class Department
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private static List<Department> _allDepartment;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        static Department()
        {
            _allDepartment = App.Current.DbContext.Departments.ToList();
            _allDepartment.Insert(0, new Department() { DepartmentCode = "CN01300", DepartmentName = "全部" });
        }

        #endregion Constructors

        #region Methods (2)

        // Public Methods (2) 

        public static List<Department> AllDepartments()
        {
            return _allDepartment;
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
    public partial class Client
    {
        #region Properties (1)

        /// <summary>
        /// 
        /// </summary>
        public string CountryNameCN
        {
            get
            {
                if (_CountryCode != null && !_CountryCode.Trim().Equals(string.Empty))
                {
                    return App.Current.DbContext.Countries.Where(c => c.CountryCode == _CountryCode).SingleOrDefault().CountryNameCN;
                }
                return string.Empty;
            }
        }

        #endregion Properties

        #region Methods (1)

        // Public Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (_ClientNameCN != null && !_ClientNameCN.Equals(string.Empty))
            {
                return _ClientNameCN;
            }
            else
            {
                return _ClientNameEN_1;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class Currency
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private static List<Currency> _currencyList;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        static Currency()
        {
            _currencyList = App.Current.DbContext.Currencies.ToList();
            _currencyList.Insert(0, new Currency() { CurrencyCode = "AAA", CurrencyName = "All" });
        }

        #endregion Constructors

        #region Properties (1)

        /// <summary>
        /// 
        /// </summary>
        public string CurrencyFormat
        {
            get
            {
                if ("AAA".Equals(_CurrencyCode))
                {
                    return "All";
                }
                else
                {
                    return _CurrencyCode + " " + _CurrencyName;
                }
            }
        }

        #endregion Properties

        #region Methods (1)

        // Public Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Currency> AllCurrencies()
        {
            return _currencyList.ToList();
        }

        #endregion Methods
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class Country
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private static List<Country> _countryList;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        static Country()
        {
            _countryList = App.Current.DbContext.Countries.ToList();
            _countryList.Insert(0, new Country() { CountryCode = "AA", CountryNameCN = "全部", CountryNameEN = "All" });
        }

        #endregion Constructors

        #region Properties (2)

        /// <summary>
        /// 
        /// </summary>
        public string CountryFormatCN
        {
            get
            {
                if ("AA".Equals(_CountryCode))
                {
                    return "全部";
                }
                else
                {
                    return _CountryCode + " " + _CountryNameCN;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string CountryFormatEN
        {
            get
            {
                if ("AA".Equals(_CountryCode))
                {
                    return "All";
                }
                else
                {
                    return _CountryCode + " " + _CountryNameEN;
                }
            }
        }

        #endregion Properties

        #region Methods (1)

        // Public Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Country> AllCountries()
        {
            return _countryList;
        }

        #endregion Methods
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class Factor
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        public static readonly string CMBC_CODE = "CN01300";

        #endregion Fields

        #region Properties (2)

        /// <summary>
        /// 
        /// </summary>
        public string GroupNameCN
        {
            get
            {
                if (_GroupNo != null && !_GroupNo.Trim().Equals(string.Empty))
                {
                    return FactorGroup.GroupNameCN;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string GroupNameEN
        {
            get
            {
                if (_GroupNo != null && !_GroupNo.Trim().Equals(string.Empty))
                {
                    return FactorGroup.GroupNameEN;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        #endregion Properties

        #region Methods (2)

        // Public Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static Factor FindFactorByCode(string code)
        {
            return App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == code);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (_CompanyNameCN != null && !_CompanyNameCN.Equals(string.Empty))
            {
                return _CompanyNameCN;
            }
            else
            {
                return _CompanyNameEN;
            }
        }

        #endregion Methods
    }
}

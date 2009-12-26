using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Country
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private static readonly List<Country> _countryList;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        static Country()
        {
            _countryList = App.Current.DbContext.Countries.ToList();
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
                return _CountryCode + " " + _CountryNameCN;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string CountryFormatEN
        {
            get
            {
                return _CountryCode + " " + _CountryNameEN;
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
}

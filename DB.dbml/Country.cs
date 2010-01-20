//-----------------------------------------------------------------------
// <copyright file="Country.cs" company="Yiming Liu@Fudan">
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
        /// Initializes static members of the Country class
        /// </summary>
        static Country()
        {
            _countryList = App.Current.DbContext.Countries.ToList();
        }

		#endregion Constructors 

		#region Properties (2) 

        /// <summary>
        /// Gets
        /// </summary>
        public string CountryFormatCN
        {
            get
            {
                return this._CountryCode + " " + this._CountryNameCN;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string CountryFormatEN
        {
            get
            {
                return this._CountryCode + " " + this._CountryNameEN;
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

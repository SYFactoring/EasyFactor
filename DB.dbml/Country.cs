//-----------------------------------------------------------------------
// <copyright file="Country.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Country
    {
        /// <summary>
        /// 
        /// </summary>
        private static readonly List<Country> CountryList = InitializeCountry();


        /// <summary>
        /// Gets
        /// </summary>
        public string CountryFormatCN
        {
            get { return _CountryCode + " " + _CountryNameCN; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string CountryFormatEN
        {
            get { return _CountryCode + " " + _CountryNameEN; }
        }


        //?Public?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Country> AllCountries()
        {
            return CountryList.ToList();
        }

        //?Private?Methods?(1)?
        /// <summary>
        /// Initializes static members of the Country class
        /// </summary>
        private static List<Country> InitializeCountry()
        {
            var context = new DBDataContext { ObjectTrackingEnabled = false };
            List<Country> countryList = context.Countries.ToList();
            Country CN = countryList.SingleOrDefault(c => c.CountryCode == "CN");
            Country US = countryList.SingleOrDefault(c => c.CountryCode == "US");
            countryList.Insert(0, CN);
            countryList.Insert(1, US);
            return countryList;
        }
    }
}
//-----------------------------------------------------------------------
// <copyright file="Currency.cs" company="Yiming Liu@Fudan">
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
    public partial class Currency
    {
        /// <summary>
        /// 
        /// </summary>
        private static readonly List<Currency> CurrencyList = InitializeCurrency();


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Currency> AllCurrencies
        {
            get { return CurrencyList.ToList(); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string CurrencyFormat
        {
            get { return _CurrencyCode + " " + _CurrencyName; }
        }


        //?Private?Methods?(1)?
        /// <summary>
        /// Initializes static members of the Currency class
        /// </summary>
        private static List<Currency> InitializeCurrency()
        {
            var context = new DBDataContext {ObjectTrackingEnabled = false};
            List<Currency> currencyList = context.Currencies.ToList();
            Currency CNY = currencyList.SingleOrDefault(c => c.CurrencyCode == "CNY");
            Currency USD = currencyList.SingleOrDefault(c => c.CurrencyCode == "USD");
            currencyList.Insert(0, CNY);
            currencyList.Insert(1, USD);
            return currencyList;
        }
    }
}
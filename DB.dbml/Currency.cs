//-----------------------------------------------------------------------
// <copyright file="Currency.cs" company="Yiming Liu@Fudan">
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
    public partial class Currency
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private static readonly List<Currency> _currencyList;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Initializes static members of the Currency class
        /// </summary>
        static Currency()
        {
            DBDataContext context = new DBDataContext();
            context.ObjectTrackingEnabled = false;
            _currencyList = context.Currencies.ToList();
            Currency CNY = _currencyList.SingleOrDefault(c => c.CurrencyCode == "CNY");
            Currency USD = _currencyList.SingleOrDefault(c => c.CurrencyCode == "USD");
            _currencyList.Insert(0, CNY);
            _currencyList.Insert(1, USD);
        }

        #endregion Constructors

        #region Properties (2)

        /// <summary>
        /// Gets
        /// </summary>
        public string CurrencyFormat
        {
            get
            {
                return _CurrencyCode + " " + _CurrencyName;
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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
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

        public static Currency CNY
        {
            get;
            private set;
        }
        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        static Currency()
        {
            _currencyList = App.Current.DbContext.Currencies.ToList();
            CNY = _currencyList.SingleOrDefault(c => c.CurrencyCode == "CNY");
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
            return _currencyList;
        }

        #endregion Methods
    }

}

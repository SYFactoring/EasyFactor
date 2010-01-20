//-----------------------------------------------------------------------
// <copyright file="Exchange.cs" company="Yiming Liu@Fudan">
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
    public partial class Exchange
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private static List<Exchange> _exchangeList;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Initializes static members of the Exchange class
        /// </summary>
        static Exchange()
        {
            _exchangeList = App.Current.DbContext.Exchanges.ToList();
        }

        #endregion Constructors

        #region Methods (1)

        // Public Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static double GetExchangeRate(string from, string to)
        {
            Exchange exchange = _exchangeList.SingleOrDefault(e => e.FromCurr == from && e.ToCurr == to);
            if (exchange != null)
            {
                return exchange.ExchangeRate;
            }
            else
            {
                return 1;
            }
        }

        #endregion Methods
    }
}

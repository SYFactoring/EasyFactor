//-----------------------------------------------------------------------
// <copyright file="Exchange.cs" company="Yiming Liu@Fudan">
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
    public partial class Exchange
    {
        /// <summary>
        /// 
        /// </summary>
        private static readonly List<Exchange> ExchangeList = InitializeExchange();


        //?Public?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static double GetExchangeRate(string from, string to)
        {
            Exchange exchange = ExchangeList.SingleOrDefault(e => e.FromCurr == from && e.ToCurr == to);
            return exchange != null ? exchange.ExchangeRate : 1;
        }

        //?Private?Methods?(1)?
        /// <summary>
        /// Initializes static members of the Exchange class
        /// </summary>
        private static List<Exchange> InitializeExchange()
        {
            var context = new DBDataContext();
            return context.Exchanges.ToList();
        }
    }
}
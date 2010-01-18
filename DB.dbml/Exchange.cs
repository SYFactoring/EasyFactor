using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class Exchange
    {
        private static List<Exchange> _exchangeList;

        static Exchange()
        {
            _exchangeList = App.Current.DbContext.Exchanges.ToList();
        }

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
    }
}

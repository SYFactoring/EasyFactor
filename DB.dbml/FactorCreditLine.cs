using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class FactorCreditLine
    {
        public double CreditLineOutstanding
        {
            get
            {
                return this.CreditLine-this.Factor.AssignOutstanding;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class FactorCreditLine
    {
        public string FactorName
        {
            get
            {
                return this.Factor.ToString();
            }
        }

        public string FactorType
        {
            get
            {
                return this.Factor.FactorType;
            }
        }

        public double CreditLineOutstanding
        {
            get
            {
                return this.CreditLine-this.Factor.AssignOutstanding;
            }
        }
    }
}

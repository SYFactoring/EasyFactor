using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class ClientCreditLine
    {
        public string ClientNameCN
        {
            get
            {
                if (Client != null)
                {
                    return this.Client.ClientNameCN;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string ClientNameEN_1
        {
            get
            {
                if (Client != null)
                {
                    return this.Client.ClientNameEN_1;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double AssignCreditLineOutstanding
        {
            get
            {
                double result =  this.CreditLine - this.Client.GetAssignOutstanding(this.CreditLineCurrency);
                if (this.ClientCreditLines.Count > 0)
                {
                    foreach (ClientCreditLine creditLine in this.ClientCreditLines)
                    {
                        result -= creditLine.Client.GetAssignOutstanding(this.CreditLineCurrency);
                    }
                }
                return result;
            }
        }
    }
}

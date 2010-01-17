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
    }
}

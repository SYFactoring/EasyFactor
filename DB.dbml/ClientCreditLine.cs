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
                return this.Client.ClientNameCN;
            }
        }

        public string ClientNameEN_1
        {
            get
            {
                return this.Client.ClientNameEN_1;
            }
        }
    }
}

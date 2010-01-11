using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class InvoiceAssignBatch
    {
        public double AssignAmount
        {
            get
            {
                double result = 0;
                foreach (Invoice invoice in this.Invoices)
                {
                    result += invoice.AssignAmount;
                }
                return result;
            }
        }

        public int BatchCount
        {
            get
            {
                return this.Invoices.Count;
            }
        }

        public string SellerName
        {
            get
            {
                return this.CDA.Case.SellerClient.ToString();
            }
        }

        public string BuyerName
        {
            get
            {
                return this.CDA.Case.BuyerClient.ToString();
            }
        }
    }
}

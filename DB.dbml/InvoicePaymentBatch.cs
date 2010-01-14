using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class InvoicePaymentBatch
    {
        public double PaymentAmount
        {
            get
            {
                double result = 0;
                foreach (InvoicePaymentLog paymentLog in this.InvoicePaymentLogs)
                {
                    if (paymentLog.PaymentAmount.HasValue)
                    {
                        result += paymentLog.PaymentAmount.Value;
                    }
                }
                return result;
            }
        }

        public int BatchCount
        {
            get
            {
                return this.InvoicePaymentLogs.Count;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class InvoiceRefundBatch
    {
        public double RefundAmount
        {
            get
            {
                double result = 0;
                foreach (InvoiceRefundLog refundLog in this.InvoiceRefundLogs)
                {
                    result += refundLog.RefundAmount;
                }
                return result;
            }
        }
        public int BatchCount
        {
            get
            {
                return this.InvoiceRefundLogs.Count;
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

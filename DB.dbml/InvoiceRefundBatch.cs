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
    }
}

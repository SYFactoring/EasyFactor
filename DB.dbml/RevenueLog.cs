using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    partial class RevenueLog
    {
        public string ClientName
        {
            get 
            { 
                if(Invoice.InvoiceAssignBatch.WhoPayCommission=="买方付") 
                    return this.Invoice.BuyerName; 
                else return this.Invoice.SellerName;
            }
        }

        public string BatchID
        {
            get
            {
                if (this.RevenueBatch.AssignBatchNo != null)
                {
                    return this.RevenueBatch.AssignBatchNo;
                }
                else
                {
                    return this.RevenueBatchID.ToString();
                }
            }
        }

        public string InvoiceNo
        {
            get { return Invoice.InvoiceNo; }
        }

        public double? CommissionPrice
        {
            get { return Invoice.InvoiceAssignBatch.CommissionPrice; }
        }

        public decimal AssignAmount
        {
            get
            {
                return Invoice.AssignAmount;
            }
        }

        public DateTime AssignDate { get { return Invoice.AssignDate; } }
    
    }
}

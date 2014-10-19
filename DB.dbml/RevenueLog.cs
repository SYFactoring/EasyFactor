using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    partial class RevenueLog
    {
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

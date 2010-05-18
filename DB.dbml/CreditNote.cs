using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CreditNote
    {
        /// <summary>
        /// 
        /// </summary>
        public string SellerName
        {
            get
            {
                return this.InvoiceAssignBatch.Case.SellerClient.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string BuyerName
        {
            get
            {
                return this.InvoiceAssignBatch.Case.BuyerClient.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string FactorName
        {
            get
            {
                return this.InvoiceAssignBatch.Case.Factor.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TransactionType
        {
            get
            {
                return this.InvoiceAssignBatch.Case.TransactionType;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string InvoiceNos
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (InvoicePaymentLog log in this.InvoicePaymentLogs)
                {
                    sb.Append(log.InvoiceNo).Append(';');
                }

                return sb.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? PaymentAmount
        {
            get
            {
                return this.InvoicePaymentLogs.Sum(log => log.PaymentAmount);
            }
        }
    }
}

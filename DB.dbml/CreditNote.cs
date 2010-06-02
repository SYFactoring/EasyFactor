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
        public string BuyerName
        {
            get { return InvoiceAssignBatch.Case.BuyerClient.ToString(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string FactorName
        {
            get { return InvoiceAssignBatch.Case.Factor.ToString(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string InvoiceNos
        {
            get
            {
                var sb = new StringBuilder();
                foreach (InvoicePaymentLog log in InvoicePaymentLogs)
                {
                    sb.Append(log.InvoiceNo).Append(';');
                }

                sb.Remove(sb.Length - 1, 1);
                return sb.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? PaymentAmount
        {
            get { return InvoicePaymentLogs.Sum(log => log.PaymentAmount); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SellerName
        {
            get { return InvoiceAssignBatch.Case.SellerClient.ToString(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TransactionType
        {
            get { return InvoiceAssignBatch.Case.TransactionType; }
        }
    }
}
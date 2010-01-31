
namespace CMBC.EasyFactor.DB.dbml
{
    using System.Collections.Generic;
    /// <summary>
    /// 
    /// </summary>
    public class DisputeReason
    {
        private string index;

        private string reason;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="reason"></param>
        public DisputeReason(string index, string reason)
        {
            this.index = index;
            this.reason = reason;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Index
        {
            get
            {
                return this.index;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Reason
        {
            get
            {
                return this.reason;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<DisputeReason> GetAllDisputeReasons()
        {
            List<DisputeReason> reasonList = new List<DisputeReason>();
            reasonList.Add(new DisputeReason("01", "01-Settlement agreed with seller"));
            reasonList.Add(new DisputeReason("02", "02-Direct payment to Export Factor"));
            reasonList.Add(new DisputeReason("03", "03-Direct payment to seller"));
            reasonList.Add(new DisputeReason("04", "04-Direct payment to seller’s agent"));
            reasonList.Add(new DisputeReason("05", "05-Invoice not received"));
            reasonList.Add(new DisputeReason("06", "06-Duplicate invoice"));
            reasonList.Add(new DisputeReason("07", "07-Wrong invoice details"));
            reasonList.Add(new DisputeReason("08", "08-Credit note to buyer, not to us"));
            reasonList.Add(new DisputeReason("09", "09-Debit note to seller"));
            reasonList.Add(new DisputeReason("10", "10-Offset against credit balances or other invoices"));
            reasonList.Add(new DisputeReason("11", "11-Discount beyond terms"));
            reasonList.Add(new DisputeReason("12", "12-Trade discount deducted"));
            reasonList.Add(new DisputeReason("13", "13-Counter claim"));
            reasonList.Add(new DisputeReason("14", "14-Deduction for other costs"));
            reasonList.Add(new DisputeReason("15", "15-Wrong delivery"));
            reasonList.Add(new DisputeReason("16", "16-Proof of delivery required"));
            reasonList.Add(new DisputeReason("17", "17-Wrong goods"));
            reasonList.Add(new DisputeReason("18", "18-Damaged goods"));
            reasonList.Add(new DisputeReason("19", "19-Goods on consignment"));
            reasonList.Add(new DisputeReason("20", "20-Goods returned to seller"));
            reasonList.Add(new DisputeReason("21", "21-Goods returned to agent"));
            reasonList.Add(new DisputeReason("22", "22-Buyer refuses delivery"));
            reasonList.Add(new DisputeReason("23", "23-Other reasons, see message text"));
            return reasonList;
        }
    }
}

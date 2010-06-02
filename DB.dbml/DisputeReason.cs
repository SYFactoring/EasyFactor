//-----------------------------------------------------------------------
// <copyright file="DisputeReason.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public class DisputeReason
    {
        private readonly string _index;
        private readonly string _reason;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="reason"></param>
        public DisputeReason(string index, string reason)
        {
            _index = index;
            _reason = reason;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<DisputeReason> AllDisputeReasons
        {
            get
            {
                var reasonList = new List<DisputeReason>
                                     {
                                         new DisputeReason("01", "01-Settlement agreed with seller"),
                                         new DisputeReason("02", "02-Direct payment to Export Factor"),
                                         new DisputeReason("03", "03-Direct payment to seller"),
                                         new DisputeReason("04", "04-Direct payment to seller¡¯s agent"),
                                         new DisputeReason("05", "05-Invoice not received"),
                                         new DisputeReason("06", "06-Duplicate invoice"),
                                         new DisputeReason("07", "07-Wrong invoice details"),
                                         new DisputeReason("08", "08-Credit note to buyer, not to us"),
                                         new DisputeReason("09", "09-Debit note to seller"),
                                         new DisputeReason("10", "10-Offset against credit balances or other invoices"),
                                         new DisputeReason("11", "11-Discount beyond terms"),
                                         new DisputeReason("12", "12-Trade discount deducted"),
                                         new DisputeReason("13", "13-Counter claim"),
                                         new DisputeReason("14", "14-Deduction for other costs"),
                                         new DisputeReason("15", "15-Wrong delivery"),
                                         new DisputeReason("16", "16-Proof of delivery required"),
                                         new DisputeReason("17", "17-Wrong goods"),
                                         new DisputeReason("18", "18-Damaged goods"),
                                         new DisputeReason("19", "19-Goods on consignment"),
                                         new DisputeReason("20", "20-Goods returned to seller"),
                                         new DisputeReason("21", "21-Goods returned to agent"),
                                         new DisputeReason("22", "22-Buyer refuses delivery"),
                                         new DisputeReason("23", "23-Other reasons, see message text")
                                     };
                return reasonList;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Index
        {
            get { return _index; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Reason
        {
            get { return _reason; }
        }
    }
}
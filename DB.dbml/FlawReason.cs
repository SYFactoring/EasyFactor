//-----------------------------------------------------------------------
// <copyright file="FlawReason.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public class FlawReason
    {
        private readonly string _index;
        private readonly string _reason;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="reason"></param>
        public FlawReason(string index, string reason)
        {
            _index = index;
            _reason = reason;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<FlawReason> AllFlawReasons
        {
            get
            {
                var reasonList = new List<FlawReason>
                                     {
                                         new FlawReason("01", "01-卖方/买方基本资料不符"),
                                         new FlawReason("02", "02-发票为存根联或副联复印件"),
                                         new FlawReason("03", "03-发票无转让字据记载或贴错"),
                                         new FlawReason("04", "04-账款到期日不符"),
                                         new FlawReason("05", "05-单据内容不符"),
                                         new FlawReason("06", "06-额度通知书过期或未签回"),
                                         new FlawReason("07", "07-保理合同过期或未签回"),
                                         new FlawReason("08", "08-交货凭证内容不完整"),
                                         new FlawReason("09", "09-逾期转让"),
                                         new FlawReason("10", "10-其他")
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
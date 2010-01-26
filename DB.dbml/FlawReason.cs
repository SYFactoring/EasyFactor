using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public class FlawReason
    {
        private string index;

        private string reason;

        public FlawReason(string index, string reason)
        {
            this.index = index;
            this.reason = reason;
        }

        public string Index
        {
            get
            {
                return this.index;
            }
        }

        public string Reason
        {
            get
            {
                return this.reason;
            }
        }

        public static List<FlawReason> GetAllFlawReasons()
        {
            List<FlawReason> reasonList = new List<FlawReason>();
            reasonList.Add(new FlawReason("01", "01-卖方/买方基本资料不符"));
            reasonList.Add(new FlawReason("02", "02-发票为存根联或副联复印件"));
            reasonList.Add(new FlawReason("03", "03-发票无转让字据记载或贴错"));
            reasonList.Add(new FlawReason("04", "04-账款到期日不符"));
            reasonList.Add(new FlawReason("05", "05-单据内容不符"));
            reasonList.Add(new FlawReason("06", "06-额度通知书过期或未签回"));
            reasonList.Add(new FlawReason("07", "07-保理合同过期或未签回"));
            reasonList.Add(new FlawReason("08", "08-交货凭证内容不完整"));
            reasonList.Add(new FlawReason("09", "09-逾期转让"));
            reasonList.Add(new FlawReason("10", "10-其他"));
            return reasonList;
        }
    }
}

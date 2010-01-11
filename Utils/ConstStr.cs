using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.Utils
{
    class ConstStr
    {
        public class MESSAGE
        {
            public static string TITLE_WARNING = "警告";
            public static string TITLE_INFORMATION = "提示";
            public static string DATA_UPDATE_SUCCESS = "数据更新成功";
        }

        public class CLIENT_CREDIT_LINE
        {
            public static string AVAILABILITY = "已生效";
            public static string EXPIRY = "已过期";
            public static string FREEZE = "已冻结";
        }

        public class CONTRACT
        {
            public static string AVAILABILITY = "已生效";
            public static string EXPIRY = "已过期";
        }

        public class FACTOR_CREDIT_LINE
        {
            public static string AVAILABILITY = "已生效";
            public static string EXPIRY = "已过期";
            public static string FREEZE = "已冻结";
        }

        public class CASE
        {
            public static string APPLICATION = "申请案";
            public static string ENABLE = "启动案";
            public static string CLOSED = "已结案";
        }

        public class CDA
        {
            public static string NO_CHECK = "未审核";
            public static string CHECK_NO_DELIVER = "已审核未下发";
            public static string DELIVER_NO_SIGN = "已下发未签回";
            public static string SIGNED = "已签回";
            public static string INVALID = "已失效";
        }
    }
}

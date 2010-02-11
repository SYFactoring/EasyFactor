//-----------------------------------------------------------------------
// <copyright file="ConstStr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public class ConstStr
    {
        /// <summary>
        /// 
        /// </summary>
        public class MESSAGE
        {
            /// <summary>
            /// 警告
            /// </summary>
            public static string TITLE_WARNING = "警告";

            /// <summary>
            /// 提示
            /// </summary>
            public static string TITLE_INFORMATION = "提示";

            /// <summary>
            /// 数据更新成功
            /// </summary>
            public static string DATA_UPDATE_SUCCESS = "数据更新成功";
        }

        /// <summary>
        /// 
        /// </summary>
        public class CLIENT_CREDIT_LINE
        {
            /// <summary>
            /// 已生效
            /// </summary>
            public static string AVAILABILITY = "已生效";

            /// <summary>
            /// 已过期
            /// </summary>
            public static string EXPIRY = "已过期";

            /// <summary>
            /// 已冻结
            /// </summary>
            public static string FREEZE = "已冻结";
        }

        /// <summary>
        /// 
        /// </summary>
        public class CONTRACT
        {
            /// <summary>
            /// 已生效
            /// </summary>
            public static string AVAILABILITY = "已生效";

            /// <summary>
            /// 已过期
            /// </summary>
            public static string EXPIRY = "已过期";
        }

        /// <summary>
        /// 
        /// </summary>
        public class FACTOR_CREDIT_LINE
        {
            /// <summary>
            /// 已生效
            /// </summary>
            public static string AVAILABILITY = "已生效";

            /// <summary>
            /// 已过期
            /// </summary>
            public static string EXPIRY = "已过期";

            /// <summary>
            /// 已冻结
            /// </summary>
            public static string FREEZE = "已冻结";
        }

        /// <summary>
        /// 
        /// </summary>
        public class CASE
        {
            /// <summary>
            /// 申请案
            /// </summary>
            public static string APPLICATION = "申请案";

            /// <summary>
            /// 启动案
            /// </summary>
            public static string ENABLE = "启动案";

            /// <summary>
            /// 已结案
            /// </summary>
            public static string CLOSED = "已结案";
        }

        /// <summary>
        /// 
        /// </summary>
        public class CDA
        {
            /// <summary>
            /// 未审核
            /// </summary>
            public static string UNCHECK = "未审核";

            /// <summary>
            /// 已复核
            /// </summary>
            public static string CHECKED = "已审核";

            /// <summary>
            /// 复核未通过
            /// </summary>
            public static string REJECT = "审核未通过";

            /// <summary>
            /// 已失效
            /// </summary>
            public static string INVALID = "已失效";
        }

        /// <summary>
        /// 
        /// </summary>
        public class BATCH
        {
            /// <summary>
            /// 未复核
            /// </summary>
            public static string UNCHECK = "未复核";

            /// <summary>
            /// 已复核
            /// </summary>
            public static string CHECK = "已复核";

            /// <summary>
            /// 复核未通过
            /// </summary>
            public static string REJECT = "复核未通过";
        }
    }
}

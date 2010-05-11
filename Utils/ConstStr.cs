//-----------------------------------------------------------------------
// <copyright file="ConstStr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Utils.ConstStr
{

    /// <summary>
    /// 
    /// </summary>
    public sealed class MESSAGE
    {
        #region?Fields?(4)?

        /// <summary>
        /// 数据更新成功
        /// </summary>
        public static readonly const string DATA_UPDATE_SUCCESS = "数据更新成功";

        /// <summary>
        /// 
        /// </summary>
        public static readonly const string MAIN_DEFAULT = "欢迎使用中国民生银行保理运营系统";
        /// <summary>
        /// 提示
        /// </summary>
        public static readonly const string TITLE_INFORMATION = "提示";
        /// <summary>
        /// 警告
        /// </summary>
        public static readonly const string TITLE_WARNING = "警告";

        #endregion?Fields?

        #region?Constructors?(1)?

        private MESSAGE()
        {
        }

        #endregion?Constructors?
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class CLIENT_CREDIT_LINE
    {
        #region?Fields?(3)?

        /// <summary>
        /// 已生效
        /// </summary>
        public static readonly const string AVAILABILITY = "已生效";
        /// <summary>
        /// 已过期
        /// </summary>
        public static readonly const string EXPIRY = "已过期";
        /// <summary>
        /// 已冻结
        /// </summary>
        public static readonly const string FREEZE = "已冻结";

        #endregion?Fields?

        #region?Constructors?(1)?

        private CLIENT_CREDIT_LINE()
        {
        }

        #endregion?Constructors?
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class CONTRACT
    {
        #region?Fields?(2)?

        /// <summary>
        /// 已生效
        /// </summary>
        public static readonly const string AVAILABILITY = "已生效";
        /// <summary>
        /// 已过期
        /// </summary>
        public static readonly const string EXPIRY = "已过期";

        #endregion?Fields?

        #region?Constructors?(1)?

        private CONTRACT()
        {
        }

        #endregion?Constructors?
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class FACTOR_CREDIT_LINE
    {
        #region?Fields?(3)?

        /// <summary>
        /// 已生效
        /// </summary>
        public static readonly const string AVAILABILITY = "已生效";
        /// <summary>
        /// 已过期
        /// </summary>
        public static readonly const string EXPIRY = "已过期";
        /// <summary>
        /// 已冻结
        /// </summary>
        public static readonly const string FREEZE = "已冻结";

        #endregion?Fields?

        #region?Constructors?(1)?

        private FACTOR_CREDIT_LINE()
        {
        }

        #endregion?Constructors?
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class CASEStr
    {
        #region?Fields?(3)?

        /// <summary>
        /// 申请案
        /// </summary>
        public static readonly const string APPLICATION = "申请案";
        /// <summary>
        /// 已结案
        /// </summary>
        public static readonly const string CLOSED = "已结案";
        /// <summary>
        /// 启动案
        /// </summary>
        public static readonly const string ENABLE = "启动案";

        #endregion?Fields?

        #region?Constructors?(1)?

        private CASEStr()
        {
        }

        #endregion?Constructors?
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class CDAStr
    {
        #region?Fields?(4)?

        /// <summary>
        /// 已复核
        /// </summary>
        public static readonly const string CHECKED = "已审核";
        /// <summary>
        /// 已失效
        /// </summary>
        public static readonly const string INVALID = "已失效";
        /// <summary>
        /// 复核未通过
        /// </summary>
        public static readonly const string REJECT = "审核未通过";
        /// <summary>
        /// 未审核
        /// </summary>
        public static readonly const string UNCHECK = "未审核";

        #endregion?Fields?

        #region?Constructors?(1)?

        private CDAStr()
        {
        }

        #endregion?Constructors?
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class BATCH
    {
        #region?Fields?(3)?

        /// <summary>
        /// 已复核
        /// </summary>
        public static readonly const string CHECK = "已复核";
        /// <summary>
        /// 复核未通过
        /// </summary>
        public static readonly const string REJECT = "复核未通过";
        /// <summary>
        /// 未复核
        /// </summary>
        public static readonly const string UNCHECK = "未复核";

        #endregion?Fields?

        #region?Constructors?(1)?

        private BATCH()
        {
        }

        #endregion?Constructors?
    }

    /// <summary>
    /// 
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// 买方直接付款
        /// </summary>
        public static readonly const string BUYER_PAYMENT = "买方直接付款";
        
        /// <summary>
        /// 买方间接付款
        /// </summary>
        public static readonly const string INDIRECT_PAYMENT = "买方间接付款";

        /// <summary>
        /// 担保付款
        /// </summary>
        public static readonly const string GUARANTEE_PAYMENT = "担保付款";

        /// <summary>
        /// 反转让
        /// </summary>
        public static readonly const string SELLER_REASSIGN = "反转让";

        /// <summary>
        /// 贷项通知
        /// </summary>
        public static readonly const string CREDIT_NOTE_PAYMENT = "贷项通知";

        private Payment()
        {
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Refund
    {
        private Refund()
        {
        }

        /// <summary>
        /// 买方直接付款
        /// </summary>
        public static readonly const string BUYER_PAYMENT = "买方直接付款";

        /// <summary>
        /// 卖方还款
        /// </summary>
        public static readonly const string SELLER_REFUND = "卖方还款";
    }

    /// <summary>
    /// 
    /// </summary>
    public class Finance
    {
        private Finance()
        {
        }

        /// <summary>
        /// 保理预付款(表内)
        /// </summary>
        public static readonly const string FINANCE_TYPE1 = "保理预付款(表内)";

        /// <summary>
        /// 卖方代付
        /// </summary>
        public static readonly const string FINANCE_TYPE2 = "卖方代付";

        /// <summary>
        /// 买方代付
        /// </summary>
        public static readonly const string FINANCE_TYPE3 = "买方代付";
        
        /// <summary>
        /// 银行承兑汇票
        /// </summary>
        public static readonly const string FINANCE_TYPE4 = "银行承兑汇票";

        /// <summary>
        /// 商业承兑汇票
        /// </summary>
        public static readonly const string FINANCE_TYPE5 = "商业承兑汇票";

        /// <summary>
        /// 国内信用证
        /// </summary>
        public static readonly const string FINANCE_TYPE6 = "国内信用证";

        /// <summary>
        /// 国际信用证
        /// </summary>
        public static readonly const string FINANCE_TYPE7 = "国际信用证";

        /// <summary>
        /// 其他
        /// </summary>
        public static readonly const string FINANCE_TYPE8 = "其他";

        /// <summary>
        /// 未知
        /// </summary>
        public static readonly const string FINANCE_TYPE9 = "未知";
    }
}

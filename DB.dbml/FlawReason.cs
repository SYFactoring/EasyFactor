//-----------------------------------------------------------------------
// <copyright file="FlawReason.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class FlawReason
    {
		#region?Fields?(2)?

        private string index;
        private string reason;

		#endregion?Fields?

		#region?Constructors?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="reason"></param>
        public FlawReason(string index, string reason)
        {
            this.index = index;
            this.reason = reason;
        }

		#endregion?Constructors?

		#region?Properties?(3)?

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<FlawReason> AllFlawReasons
        {
            get
            {
                List<FlawReason> reasonList = new List<FlawReason>();
                reasonList.Add(new FlawReason("01", "01-����/�򷽻������ϲ���"));
                reasonList.Add(new FlawReason("02", "02-��ƱΪ�����������ӡ��"));
                reasonList.Add(new FlawReason("03", "03-��Ʊ��ת���־ݼ��ػ�����"));
                reasonList.Add(new FlawReason("04", "04-�˿���ղ���"));
                reasonList.Add(new FlawReason("05", "05-�������ݲ���"));
                reasonList.Add(new FlawReason("06", "06-���֪ͨ����ڻ�δǩ��"));
                reasonList.Add(new FlawReason("07", "07-�����ͬ���ڻ�δǩ��"));
                reasonList.Add(new FlawReason("08", "08-����ƾ֤���ݲ�����"));
                reasonList.Add(new FlawReason("09", "09-����ת��"));
                reasonList.Add(new FlawReason("10", "10-����"));
                return reasonList;
            }
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

		#endregion?Properties?
    }
}

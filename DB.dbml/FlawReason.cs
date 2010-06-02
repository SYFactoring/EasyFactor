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
                                         new FlawReason("01", "01-����/�򷽻������ϲ���"),
                                         new FlawReason("02", "02-��ƱΪ�����������ӡ��"),
                                         new FlawReason("03", "03-��Ʊ��ת���־ݼ��ػ�����"),
                                         new FlawReason("04", "04-�˿���ղ���"),
                                         new FlawReason("05", "05-�������ݲ���"),
                                         new FlawReason("06", "06-���֪ͨ����ڻ�δǩ��"),
                                         new FlawReason("07", "07-�����ͬ���ڻ�δǩ��"),
                                         new FlawReason("08", "08-����ƾ֤���ݲ�����"),
                                         new FlawReason("09", "09-����ת��"),
                                         new FlawReason("10", "10-����")
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
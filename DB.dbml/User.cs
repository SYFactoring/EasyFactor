//-----------------------------------------------------------------------
// <copyright file="User.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class User
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<PermissionItem> AllPermissions
        {
            get
            {
                var reasonList = new List<PermissionItem>
                                     {
                                         new PermissionItem(Permissions.SYSTEM_QUERY, "��ѯȨ��"),
                                         new PermissionItem(Permissions.BASICINFO_UPDATE, "�ͻ�/���������༭Ȩ��"),
                                         new PermissionItem(Permissions.CASE_UPDATE, "������Ϣ�༭Ȩ��"),
                                         new PermissionItem(Permissions.CDA_UPDATE, "���֪ͨ��༭Ȩ��"),
                                         new PermissionItem(Permissions.CDA_APPROVE, "���֪ͨ�����Ȩ��"),
                                         new PermissionItem(Permissions.INVOICE_CHECK, "��Ʊ����Ȩ��"),
                                         new PermissionItem(Permissions.INVOICE_APPROVE, "��Ʊ���Ȩ��"),
                                         new PermissionItem(Permissions.INVOICE_UPDATE, "��Ʊ�༭Ȩ��"),
                                         new PermissionItem(Permissions.INVOICE_REPORT, "����ҵ�񱨱�Ȩ��"),
                                         new PermissionItem(Permissions.SYSTEM_IMPORT, "ϵͳ���ݵ���Ȩ��"),
                                         new PermissionItem(Permissions.SYSTEM_UPDATE, "ϵͳ���ݱ༭Ȩ��"),
                                         new PermissionItem(Permissions.INVOICE_STAT, "����ͳ��Ȩ��")
                                     };

                return reasonList;
            }
        }


        //?Public?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static string GetEDIAccount(string userName)
        {
            var context = new DBDataContext();
            User user = context.Users.SingleOrDefault(u => u.Name == userName);
            return user != null ? user.EDIAccount : string.Empty;
        }
    }


    public class PermissionItem
    {
        private readonly string _name;
        private readonly Permissions _perm;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="perm"></param>
        /// <param name="name"></param>
        public PermissionItem(Permissions perm, string name)
        {
            _perm = perm;
            _name = name;
        }


        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Permissions Permission
        {
            get { return _perm; }
        }
    }
}
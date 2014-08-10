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
                                         new PermissionItem(Permissions.SYSTEM_QUERY, "查询权限"),
                                         new PermissionItem(Permissions.BASICINFO_UPDATE, "客户/合作机构编辑权限"),
                                         new PermissionItem(Permissions.CASE_UPDATE, "案件信息编辑权限"),
                                         new PermissionItem(Permissions.CDA_UPDATE, "额度通知书编辑权限"),
                                         new PermissionItem(Permissions.CDA_APPROVE, "额度通知书审核权限"),
                                         new PermissionItem(Permissions.INVOICE_CHECK, "发票复核权限"),
                                         new PermissionItem(Permissions.INVOICE_APPROVE, "发票审核权限"),
                                         new PermissionItem(Permissions.INVOICE_UPDATE, "发票编辑权限"),
                                         new PermissionItem(Permissions.INVOICE_REPORT, "生成业务报表权限"),
                                         new PermissionItem(Permissions.SYSTEM_IMPORT, "系统数据导入权限"),
                                         new PermissionItem(Permissions.SYSTEM_UPDATE, "系统数据编辑权限"),
                                         new PermissionItem(Permissions.INVOICE_STAT, "数据统计权限")
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
//-----------------------------------------------------------------------
// <copyright file="User.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System.Collections.Generic;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class User : BaseObject
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<PermissionItem> GetAllPermissions()
        {
            List<PermissionItem> reasonList = new List<PermissionItem>();
            reasonList.Add(new PermissionItem(Utils.Permission.SYSTEM_QUERY, "查询权限"));
            reasonList.Add(new PermissionItem(Utils.Permission.BASICINFO_UPDATE, "客户/合作机构更新权限"));
            reasonList.Add(new PermissionItem(Utils.Permission.CASE_UPDATE, "案件信息更新权限"));
            reasonList.Add(new PermissionItem(Utils.Permission.CDA_UPDATE, "额度通知书更新权限"));
            reasonList.Add(new PermissionItem(Utils.Permission.CDA_APPROVE, "额度通知书审核权限"));
            reasonList.Add(new PermissionItem(Utils.Permission.INVOICE_UPDATE, "发票更新权限"));
            reasonList.Add(new PermissionItem(Utils.Permission.INVOICE_CHECK, "发票复核权限"));
            reasonList.Add(new PermissionItem(Utils.Permission.INVOICE_APPROVE, "发票审核权限"));
            reasonList.Add(new PermissionItem(Utils.Permission.SYSTEM_IMPORT, "系统数据导入权限"));
            reasonList.Add(new PermissionItem(Utils.Permission.SYSTEM_UPDATE, "系统数据更新权限"));
            return reasonList;
        }
    }


    public class PermissionItem
    {
        private Permission perm;

        private string name;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="perm"></param>
        /// <param name="name"></param>
        public PermissionItem(Permission perm, string name)
        {
            this.perm = perm;
            this.name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        public Permission Permission
        {
            get
            {
                return this.perm;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
        }
    }
}

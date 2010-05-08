//-----------------------------------------------------------------------
// <copyright file="User.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System.Collections.Generic;
    using System.Linq;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class User
    {
		#region?Properties?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<PermissionItem> AllPermissions
        {
            get
            {
                List<PermissionItem> reasonList = new List<PermissionItem>();
                reasonList.Add(new PermissionItem(Utils.Permissions.SYSTEM_QUERY, "��ѯȨ��"));
                reasonList.Add(new PermissionItem(Utils.Permissions.BASICINFO_UPDATE, "�ͻ�/������������Ȩ��"));
                reasonList.Add(new PermissionItem(Utils.Permissions.CASE_UPDATE, "������Ϣ����Ȩ��"));
                reasonList.Add(new PermissionItem(Utils.Permissions.CDA_UPDATE, "���֪ͨ�����Ȩ��"));
                reasonList.Add(new PermissionItem(Utils.Permissions.CDA_APPROVE, "���֪ͨ�����Ȩ��"));
                reasonList.Add(new PermissionItem(Utils.Permissions.INVOICE_UPDATE, "��Ʊ����Ȩ��"));
                reasonList.Add(new PermissionItem(Utils.Permissions.INVOICE_CHECK, "��Ʊ����Ȩ��"));
                reasonList.Add(new PermissionItem(Utils.Permissions.INVOICE_APPROVE, "��Ʊ���Ȩ��"));
                reasonList.Add(new PermissionItem(Utils.Permissions.SYSTEM_IMPORT, "ϵͳ���ݵ���Ȩ��"));
                reasonList.Add(new PermissionItem(Utils.Permissions.SYSTEM_UPDATE, "ϵͳ���ݸ���Ȩ��"));

                return reasonList;
            }
        }

		#endregion?Properties?

		#region?Methods?(1)?

		//?Public?Methods?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static string GetEDIAccount(string userName)
        {
            DBDataContext context = new DBDataContext();
            User user = context.Users.SingleOrDefault(u => u.Name == userName);
            if (user != null)
            {
                return user.EDIAccount;
            }
            else
            {
                return string.Empty;
            }
        }

		#endregion?Methods?
    }


    public class PermissionItem
    {
		#region?Fields?(2)?

        private string name;
        private Permissions perm;

		#endregion?Fields?

		#region?Constructors?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="perm"></param>
        /// <param name="name"></param>
        public PermissionItem(Permissions perm, string name)
        {
            this.perm = perm;
            this.name = name;
        }

		#endregion?Constructors?

		#region?Properties?(2)?

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

        /// <summary>
        /// 
        /// </summary>
        public Permissions Permission
        {
            get
            {
                return this.perm;
            }
        }

		#endregion?Properties?
    }
}

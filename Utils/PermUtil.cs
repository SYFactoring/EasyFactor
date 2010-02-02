
namespace CMBC.EasyFactor.Utils
{
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;

    /// <summary>
    /// 
    /// </summary>
    public enum Permission
    {
        /// <summary>
        /// 
        /// </summary>
        BASICINFO_UPDATE = 0x00000001,

        /// <summary>
        /// 
        /// </summary>
        CASE_UPDATE = 0x00000010,

        /// <summary>
        /// 
        /// </summary>
        CDA_UPDATE = 0x00000100,

        /// <summary>
        /// 
        /// </summary>
        CDA_APPROVE = 0x00000200,

        /// <summary>
        /// 
        /// </summary>
        INVOICE_UPDATE = 0x00001000,

        /// <summary>
        /// 
        /// </summary>
        INVOICE_CHECK = 0x00002000,

        /// <summary>
        /// 
        /// </summary>
        INVOICE_APPROVE = 0x00004000,

        /// <summary>
        /// 
        /// </summary>
        SYSTEM_QUERY = 0x00010000,

        /// <summary>
        /// 
        /// </summary>
        SYSTEM_UPDATE = 0x00020000,

        /// <summary>
        /// 
        /// </summary>
        SYSTEM_IMPORT = 0x00040000,

    }

    /// <summary>
    /// 
    /// </summary>
    public class PermUtil
    {
        #region Methods (3)

        // Public Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="perm"></param>
        /// <returns></returns>
        public static bool CheckPermission(Permission perm)
        {
            if (ValidatePermission(perm))
            {
                return true;
            }
            else
            {
                MessageBox.Show("对不起，您没有执行该操作的权限。", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="perm"></param>
        /// <returns></returns>
        public static bool ValidatePermission(Permission perm)
        {
            return ValidatePermission(App.Current.CurUser, perm);
        }
        // Internal Methods (1) 

        internal static bool ValidatePermission(User user, Permission perm)
        {
            if ((user.Permission & (int)perm) == (int)perm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion Methods
    }
}

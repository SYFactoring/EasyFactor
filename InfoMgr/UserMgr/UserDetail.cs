//-----------------------------------------------------------------------
// <copyright file="UserDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.InfoMgr.UserMgr
{
    /// <summary>
    /// User Detail User Interface
    /// </summary>
    public partial class UserDetail : Office2007Form
    {

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;
        /// <summary>
        /// 
        /// </summary>
        private OpUserType _opUserType;


        /// <summary>
        /// Initializes a new instance of the UserDetailUI class
        /// </summary>
        /// <param name="user">selected user</param>
        /// <param name="opType"></param>
        public UserDetail(User user, OpUserType opType)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _opUserType = opType;
            _context = new DBDataContext();

            cbPermission.DataSource = User.AllPermissions;
            cbPermission.ValueMember = "Permission";
            cbPermission.DisplayMember = "Name";

            user = opType == OpUserType.NEW_USER ? new User() : _context.Users.SingleOrDefault(u => u.UserID == user.UserID);

            password2TextBox.Text = user.Password;
            userBindingSource.DataSource = user;

            for (int i = 0; i < cbPermission.Items.Count; i++)
            {
                Permissions item = ((PermissionItem) cbPermission.Items[i]).Permission;
                if (PermUtil.ValidatePermission(user, item))
                {
                    cbPermission.SetItemChecked(i, true);
                }
            }

            tabControl.SelectedTab = tabItemUser;
            UpdateUserControlStatus();
        }




        //?Private?Methods?(5)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavePermission(object sender, EventArgs e)
        {
            var user = (User) userBindingSource.DataSource;
            if (user != App.Current.CurUser && !PermUtil.ValidatePermission(Permissions.SYSTEM_UPDATE))
            {
                MessageBoxEx.Show("对不起，您没有执行该操作的权限。", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (DialogResult.No ==
                MessageBoxEx.Show("是否保存权限设定", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question))
            {
                return;
            }

            int permissionResult = cbPermission.CheckedItems.Cast<PermissionItem>().Aggregate(0, (current, item) => (current ^ (int) item.Permission));

            user.Permission = permissionResult;

            bool isUpdateOK = true;
            try
            {
                _context.SubmitChanges();
            }
            catch (Exception e2)
            {
                isUpdateOK = false;
                MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isUpdateOK)
            {
                MessageBoxEx.Show("更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Save current user
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SaveUser(object sender, EventArgs e)
        {
            var user = (User) userBindingSource.DataSource;
            if (user != App.Current.CurUser && !PermUtil.ValidatePermission(Permissions.SYSTEM_UPDATE))
            {
                MessageBoxEx.Show("对不起，您没有执行该操作的权限。", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!userValidator.Validate())
            {
                return;
            }

            int permissionResult = cbPermission.CheckedItems.Cast<PermissionItem>().Aggregate(0, (current, item) => (current ^ (int) item.Permission));

            user.Permission = permissionResult;

            if (_opUserType == OpUserType.NEW_USER)
            {
                bool isAddOK = true;
                try
                {
                    _context.Users.InsertOnSubmit(user);
                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    _opUserType = OpUserType.UPDATE_USER;
                }
            }
            else
            {
                bool isUpdateOK = true;
                try
                {
                    _context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdatePermission(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permissions.SYSTEM_UPDATE))
            {
                cbPermission.Enabled = true;
                btnSavePermission.Enabled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateUser(object sender, EventArgs e)
        {
            var user = (User) userBindingSource.DataSource;
            if (user != App.Current.CurUser && !PermUtil.ValidatePermission(Permissions.SYSTEM_UPDATE))
            {
                MessageBoxEx.Show("对不起，您没有执行该操作的权限。", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            _opUserType = OpUserType.UPDATE_USER;
            UpdateUserControlStatus();
        }

        /// <summary>
        /// Update Editable Status
        /// </summary>
        private void UpdateUserControlStatus()
        {
            if (_opUserType == OpUserType.DETAIL_USER)
            {
                foreach (Control comp in groupPanelUser.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (_opUserType == OpUserType.NEW_USER)
            {
                foreach (Control comp in groupPanelUser.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (_opUserType == OpUserType.UPDATE_USER)
            {
                foreach (Control comp in groupPanelUser.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                userIDTextBox.ReadOnly = true;
                roleComboBox.Enabled = PermUtil.ValidatePermission(Permissions.SYSTEM_UPDATE);
            }

            loginDate.ReadOnly = true;
        }




        #region OpUserType enum

        /// <summary>
        /// Operation Type
        /// </summary>
        public enum OpUserType
        {
            /// <summary>
            /// New User
            /// </summary>
            NEW_USER,

            /// <summary>
            /// Update User
            /// </summary>
            UPDATE_USER,

            /// <summary>
            /// Detail User
            /// </summary>
            DETAIL_USER
        }

        #endregion
    }
}
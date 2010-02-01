//-----------------------------------------------------------------------
// <copyright file="UserDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.UserMgr
{
    using System;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// User Detail User Interface
    /// </summary>
    public partial class UserDetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private OpUserType opUserType;

        #endregion Fields

        #region Enums (1)

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

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the UserDetailUI class
        /// </summary>
        /// <param name="user">selected user</param>
        /// <param name="OpUserType">operation type</param>
        public UserDetail(User user, OpUserType opType)
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.opUserType = opType;

            this.cbPermission.DataSource = User.GetAllPermissions();
            this.cbPermission.ValueMember = "Permission";
            this.cbPermission.DisplayMember = "Name";

            if (opType == OpUserType.NEW_USER)
            {
                userBindingSource.DataSource = new User();
            }
            else
            {
                password2TextBox.Text = user.Password;
                userBindingSource.DataSource = user;
                user.Backup();

                for (int i = 0; i < this.cbPermission.Items.Count; i++)
                {
                    Permission item = ((PermissionItem)this.cbPermission.Items[i]).Permission;
                    if (PermUtil.ValidatePermission(user,item))
                    {
                        this.cbPermission.SetItemChecked(i, true);
                    }
                }
            }

            this.tabControl.SelectedTab = this.tabItemUser;
            this.UpdateUserControlStatus();
        }

        #endregion Constructors

        #region Methods (5)

        // Private Methods (5) 

        /// <summary>
        /// Cancel current editing and close the form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ResetUser(object sender, EventArgs e)
        {
            if (opUserType == OpUserType.UPDATE_USER)
            {
                User user = this.userBindingSource.DataSource as User;
                user.Restore();
            }
            else if (opUserType == OpUserType.NEW_USER)
            {
                this.userBindingSource.DataSource = new User();
            }
        }

        /// <summary>
        /// Save current user
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SaveUser(object sender, EventArgs e)
        {
            if (!this.userValidator.Validate())
            {
                return;
            }

            User user = (User)userBindingSource.DataSource;

            int permissionResult = 0;
            foreach (PermissionItem item in this.cbPermission.CheckedItems)
            {
                permissionResult = (permissionResult ^ (int)item.Permission);
            }

            user.Permission = permissionResult;

            if (opUserType == OpUserType.NEW_USER)
            {
                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.Users.InsertOnSubmit(user);
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user.Backup();
                    opUserType = OpUserType.UPDATE_USER;
                }
            }
            else
            {
                bool isUpdateOK = true;
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBox.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user.Backup();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateUser(object sender, EventArgs e)
        {
            opUserType = OpUserType.UPDATE_USER;
            UpdateUserControlStatus();

        }

        /// <summary>
        /// Update Editable Status
        /// </summary>
        private void UpdateUserControlStatus()
        {
            if (opUserType == OpUserType.DETAIL_USER)
            {
                foreach (Control comp in this.groupPanelUser.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (opUserType == OpUserType.NEW_USER)
            {
                foreach (Control comp in this.groupPanelUser.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (opUserType == OpUserType.UPDATE_USER)
            {
                foreach (Control comp in this.groupPanelUser.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                userIDTextBox.ReadOnly = true;
                if (PermUtil.ValidatePermission(Permission.SYSTEM_UPDATE))
                {
                    roleComboBox.Enabled = true;
                }
                else
                {
                    roleComboBox.Enabled = false;
                }
            }

            this.loginDate.ReadOnly = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            User user = (User)this.userBindingSource.DataSource;
            if (opUserType == OpUserType.UPDATE_USER)
            {
                user.Restore();
            }
        }

        #endregion Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdatePermission(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.SYSTEM_UPDATE))
            {
                this.cbPermission.Enabled = true;
            }
        }
    }
}

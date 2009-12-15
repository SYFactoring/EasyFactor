//-----------------------------------------------------------------------
// <copyright file="UserDetailUI.cs" company="CISL@Fudan">
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

        /// <summary>
        /// 
        /// </summary>
        private OpUserType opUserType;

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

        /// <summary>
        /// Initializes a new instance of the UserDetailUI class
        /// </summary>
        /// <param name="user">selected user</param>
        /// <param name="OpUserType">operation type</param>
        public UserDetail(User user, OpUserType opType)
        {
            this.InitializeComponent();
            this.opUserType = opType;
            if (opType == OpUserType.NEW_USER)
            {
                userBindingSource.DataSource = new User();
            }
            else
            {
                userBindingSource.DataSource = user;
                user.Backup();
            }
            this.UpdateUserControlStatus();
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
                    ControlUtil.setComponetEditable(comp, false);
                }
            }
            else if (opUserType == OpUserType.NEW_USER)
            {
                foreach (Control comp in this.groupPanelUser.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }
            }
            else if (opUserType == OpUserType.UPDATE_USER)
            {
                foreach (Control comp in this.groupPanelUser.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }
                 userIDTextBox.ReadOnly = true;
            }
            this.loginDate.ReadOnly = true;
        }

        /// <summary>
        /// Save current user
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void UserSave(object sender, EventArgs e)
        {
            userBindingSource.EndEdit();
            User user = (User)userBindingSource.DataSource;
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
                    MessageBox.Show(e1.Message);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show(e2.Message);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user.Backup();
                }
            }
        }

        /// <summary>
        /// Cancel current editing and close the form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void UserClose(object sender, EventArgs e)
        {
            User user = (User)this.userBindingSource.DataSource;
            if (opUserType == OpUserType.NEW_USER || opUserType == OpUserType.UPDATE_USER)
            {
                user.Restore();
            }
            Close();
        }

        private void UserUpdate(object sender, EventArgs e)
        {
            opUserType = OpUserType.UPDATE_USER;
            UpdateUserControlStatus();
        }

        private void UserDetail_Leave(object sender, EventArgs e)
        {
            this.UserClose(sender, e);
        }
    }
}

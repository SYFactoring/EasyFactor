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
    
    /// <summary>
    /// User Detail User Interface
    /// </summary>
    public partial class UserDetail : DevComponents.DotNetBar.Office2007Form
    {
        /// <summary>
        /// flag indicates if add
        /// </summary>
        private readonly bool isAdd;

        /// <summary>
        /// original user
        /// </summary>
        private readonly User originalUser;

        /// <summary>
        /// Initializes a new instance of the UserDetailUI class
        /// </summary>
        /// <param name="user">selected user</param>
        /// <param name="isEditable">true if editable</param>
        public UserDetail(User user, bool isEditable)
        {
            this.InitializeComponent();
            User updateUser = new User();
            if (user == null)
            {
                this.isAdd = true;
            }
            else
            {
                this.originalUser = user;
                updateUser.Copy(user);
            }

            userBindingSource.DataSource = updateUser;
            this.UpdateEditableStatus(isEditable);
        }

        /// <summary>
        /// Update Editable Status
        /// </summary>
        /// <param name="isEditable">true is editable</param>
        private void UpdateEditableStatus(bool isEditable)
        {
            if (this.isAdd)
            {
                userIDTextBox.Enabled = true;
            }
            else
            {
                userIDTextBox.ReadOnly = true;
            }

            if (!isEditable)
            {
                emailTextBox.ReadOnly = true;
                msnTextBox.ReadOnly = true;
                passwordTextBox.ReadOnly = true;
                phoneTextBox.ReadOnly = true;
                telphoneTextBox.ReadOnly = true;
                userNameTextBox.ReadOnly = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        /// <summary>
        /// Save current user
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Save(object sender, EventArgs e)
        {
            userBindingSource.EndEdit();
            User updateUser = (User)userBindingSource.DataSource;
            if (this.isAdd)
            {
                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.Users.InsertOnSubmit(updateUser);
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
                    Close();
                }
            }
            else
            {
                bool isUpdateOK = true;
                User tempUser = new User();
                tempUser.Copy(this.originalUser);
                this.originalUser.Copy(updateUser);
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    this.originalUser.Copy(tempUser);
                    MessageBox.Show(e2.Message);
                } 

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        /// <summary>
        /// Cancel current editing and close the form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}

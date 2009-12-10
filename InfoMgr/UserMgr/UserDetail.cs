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

        public enum OpType { NEW_USER, UPDATE_USER, DETAIL_USER };

        private readonly OpType opType;

        /// <summary>
        /// Initializes a new instance of the UserDetailUI class
        /// </summary>
        /// <param name="user">selected user</param>
        /// <param name="opType">operation type</param>
        public UserDetail(User user, OpType opType)
        {
            this.InitializeComponent();
            this.opType = opType;
            if (opType == OpType.NEW_USER)
            {
                userBindingSource.DataSource = new User();
            }
            else
            {
                userBindingSource.DataSource = user;
            }
            this.UpdateEditableStatus();
        }

        /// <summary>
        /// Update Editable Status
        /// </summary>
        private void UpdateEditableStatus()
        {
            if (opType == OpType.DETAIL_USER)
            {
                foreach (Control comp in this.groupPanelUser.Controls)
                {
                    ControlUtil.setComponetEditable(comp, false);
                }
                ControlUtil.setComponetEditable(this.btnSave, false);
                ControlUtil.setComponetEditable(this.btnCancel, false);
            }
            else if (opType == OpType.NEW_USER)
            {
                foreach (Control comp in this.groupPanelUser.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }
                ControlUtil.setComponetEditable(this.btnSave, true);
                ControlUtil.setComponetEditable(this.btnCancel, true);
            }
            else if (opType == OpType.UPDATE_USER)
            {
                foreach (Control comp in this.groupPanelUser.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }
                ControlUtil.setComponetEditable(this.btnSave, true);
                ControlUtil.setComponetEditable(this.btnCancel, true);
                userIDTextBox.ReadOnly = true;
            }

            this.loginDate.ReadOnly = true;
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
            if (opType == OpType.NEW_USER)
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

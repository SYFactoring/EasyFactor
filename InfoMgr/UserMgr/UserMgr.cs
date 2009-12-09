//-----------------------------------------------------------------------
// <copyright file="UserMgrUI.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.UserMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;

    /// <summary>
    /// User Management User Interface
    /// </summary>
    public partial class UserMgr : UserControl
    {
        /// <summary>
        /// flag indicates if editable
        /// </summary>
        private readonly bool isEditable;

        /// <summary>
        /// Form owner
        /// </summary>
        private readonly Form owner;

        /// <summary>
        /// Initializes a new instance of the UserMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        public UserMgr(bool isEditable)
        {
            InitializeComponent();
            this.isEditable = isEditable;
            this.UpdateEditableStatus();
        }

        /// <summary>
        /// Initializes a new instance of the UserMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        /// <param name="owner">form owner</param>
        public UserMgr(bool isEditable, Form owner)
            : this(isEditable)
        {
            this.owner = owner;
        }

        /// <summary>
        /// Gets or sets selected user
        /// </summary>
        public User Selected
        {
            get;
            set;
        }

        /// <summary>
        /// Update editable status
        /// </summary>
        private void UpdateEditableStatus()
        {
            if (this.isEditable)
            {
                return;
            }

            toolStripSeparator.Visible = false;
            menuItemEdit.Visible = false;
        }

        /// <summary>
        /// Query user table according to keyword
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Query(object sender, System.EventArgs e)
        {
            string keyword = tbKeyword.Text.Trim();

            var queryResult =
            App.Current.DbContext.Users.Where(
                u => u.UserName.Contains(keyword)
                  || u.UserID.Contains(keyword)
                  || u.EDIAccount.Contains(keyword)
                  || u.MSN.Contains(keyword)
                  || u.Phone.Contains(keyword)
                  || u.Telphone.Contains(keyword)
                  || u.Email.Contains(keyword));
            userMgrBindingSource.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// Popup UserDetailUI Form and Create a new User
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemNew(object sender, System.EventArgs e)
        {
            new UserDetail(null, UserDetail.OpType.NEW_USER).ShowDialog(this);
        }

        /// <summary>
        /// Popup UserDetailUI Form and Update current selected User
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemUpdate(object sender, System.EventArgs e)
        {
            if (dgvUser.SelectedRows.Count == 0 || userMgrBindingSource == null)
            {
                return;
            }

            string uid = (string)dgvUser["userIdColumn", dgvUser.SelectedRows[0].Index].Value;
            if (uid != null)
            {
                User selectedUser = App.Current.DbContext.Users.FirstOrDefault(u => u.UserID == uid);
                if (selectedUser != null)
                {
                    new UserDetail(selectedUser, UserDetail.OpType.UPDATE_USER).ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Delete current selected User
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemDelete(object sender, System.EventArgs e)
        {
            if (dgvUser.SelectedRows.Count == 0 || userMgrBindingSource.DataSource == null)
            {
                return;
            }

            string uid = (string)dgvUser["userIdColumn", dgvUser.SelectedRows[0].Index].Value;
            if (uid != null)
            {
                User selectedUser = App.Current.DbContext.Users.FirstOrDefault(u => u.UserID == uid);
                if (selectedUser != null)
                {
                    if (MessageBox.Show("是否确定删除帐号: " + selectedUser.UserID, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        userMgrBindingSource.Remove(selectedUser);
                        App.Current.DbContext.Users.DeleteOnSubmit(selectedUser);
                        App.Current.DbContext.SubmitChanges();
                    }
                }
            }
        }

        /// <summary>
        /// Select current User and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemSelect(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count == 0 || userMgrBindingSource == null)
            {
                return;
            }

            string uid = (string)dgvUser["userIdColumn", dgvUser.SelectedRows[0].Index].Value;
            if (uid != null)
            {
                User selectedUser = App.Current.DbContext.Users.FirstOrDefault(u => u.UserID == uid);
                if (selectedUser != null)
                {
                    this.Selected = selectedUser;
                    if (this.owner != null)
                    {
                        this.owner.DialogResult = DialogResult.Yes;
                        this.owner.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Popup a new form and display a user detailly
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemDetail(object sender, System.EventArgs e)
        {
            if (dgvUser.SelectedRows.Count == 0 || userMgrBindingSource == null)
            {
                return;
            }

            string uid = (string)dgvUser["userIdColumn", dgvUser.SelectedRows[0].Index].Value;
            if (uid != null)
            {
                User selectedUser = App.Current.DbContext.Users.FirstOrDefault(u => u.UserID == uid);
                if (selectedUser != null)
                {
                    new UserDetail(selectedUser, UserDetail.OpType.DETAIL_USER).ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ItemDetail(sender, e);
        }
    }
}

//-----------------------------------------------------------------------
// <copyright file="UserMgrUI.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.UserMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// User Management User Interface
    /// </summary>
    public partial class UserMgr : UserControl
    {
        #region Fields (2)

        private BindingSource bs = new BindingSource();
        /// <summary>
        /// flag indicates if editable
        /// </summary>
        private readonly bool isEditable;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the UserMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        public UserMgr(bool isEditable)
        {
            this.InitializeComponent();
            ControlUtil.SetDoubleBuffered(this.dgvUsers);
            this.isEditable = isEditable;
            this.UpdateEditableStatus();
        }

        #endregion Constructors

        #region Properties (2)

        public Form OwnerForm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets selected user
        /// </summary>
        public User Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (9)

        // Private Methods (9) 

        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.OwnerForm == null)
            {
                this.DetailUser(sender, e);
            }
            else
            {
                this.SelectUser(sender, e);
            }
        }

        /// <summary>
        /// Delete current selected User
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteUser(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                return;
            }

            string uid = (string)dgvUsers["userIdColumn", dgvUsers.SelectedRows[0].Index].Value;
            if (uid != null)
            {
                User selectedUser = App.Current.DbContext.Users.SingleOrDefault(u => u.UserID == uid);
                if (selectedUser != null)
                {
                    if (MessageBox.Show("是否确定删除帐号: " + selectedUser.UserID, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        dgvUsers.Rows.RemoveAt(dgvUsers.SelectedRows[0].Index);
                        App.Current.DbContext.Users.DeleteOnSubmit(selectedUser);
                        App.Current.DbContext.SubmitChanges();
                    }
                }
            }
        }

        /// <summary>
        /// Popup a new form and display a user detailly
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailUser(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                return;
            }

            string uid = (string)dgvUsers["userIdColumn", dgvUsers.SelectedRows[0].Index].Value;
            if (uid != null)
            {
                User selectedUser = App.Current.DbContext.Users.SingleOrDefault(u => u.UserID == uid);
                if (selectedUser != null)
                {
                    new UserDetail(selectedUser, UserDetail.OpUserType.DETAIL_USER).ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportUsers(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_USERS);
            importForm.Show();
        }

        /// <summary>
        /// Popup UserDetailUI Form and Create a new User
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewUser(object sender, EventArgs e)
        {
            new UserDetail(null, UserDetail.OpUserType.NEW_USER).ShowDialog(this);
        }

        /// <summary>
        /// Query user table according to keyword
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void QueryUsers(object sender, System.EventArgs e)
        {
            var queryResult = App.Current.DbContext.Users.Where(u => u.UserID.Contains(tbUserID.Text));
            bs.DataSource = queryResult;
            dgvUsers.DataSource = bs;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// Select current User and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectUser(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                return;
            }

            string uid = (string)dgvUsers["userIdColumn", dgvUsers.SelectedRows[0].Index].Value;
            if (uid != null)
            {
                User selectedUser = App.Current.DbContext.Users.SingleOrDefault(u => u.UserID == uid);
                if (selectedUser != null)
                {
                    this.Selected = selectedUser;
                    if (this.OwnerForm != null)
                    {
                        this.OwnerForm.DialogResult = DialogResult.Yes;
                        this.OwnerForm.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Update editable status
        /// </summary>
        private void UpdateEditableStatus()
        {
            this.menuItemSelectUser.Enabled = true;
            this.menuItemDetailUser.Enabled = true;
            if (this.isEditable)
            {
                this.menuItemDeleteUser.Enabled = true;
                this.menuItemNewUser.Enabled = true;
                this.menuItemUpdateUser.Enabled = true;
            }
            else
            {
                this.menuItemDeleteUser.Enabled = false;
                this.menuItemNewUser.Enabled = false;
                this.menuItemUpdateUser.Enabled = false;
            }
        }

        /// <summary>
        /// Popup UserDetailUI Form and Update current selected User
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void UpdateUser(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                return;
            }

            string uid = (string)dgvUsers["userIdColumn", dgvUsers.SelectedRows[0].Index].Value;
            if (uid != null)
            {
                User selectedUser = App.Current.DbContext.Users.SingleOrDefault(u => u.UserID == uid);
                if (selectedUser != null)
                {
                    new UserDetail(selectedUser, UserDetail.OpUserType.UPDATE_USER).ShowDialog(this);
                }
            }
        }

        #endregion Methods
    }
}

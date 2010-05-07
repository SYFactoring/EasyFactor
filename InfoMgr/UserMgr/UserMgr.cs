//-----------------------------------------------------------------------
// <copyright file="UserMgrUI.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.UserMgr
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;

    /// <summary>
    /// User Management User Interface
    /// </summary>
    public partial class UserMgr : UserControl
    {
		#region?Fields?(1)?

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;

		#endregion?Fields?

		#region?Constructors?(1)?

        /// <summary>
        /// Initializes a new instance of the UserMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        public UserMgr()
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.bs = new BindingSource();
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.DataSource = this.bs;
            ControlUtil.SetDoubleBuffered(this.dgvUsers);
            ControlUtil.AddEnterListenersForQuery(this.panelQuery.Controls, this.btnQuery);

            this.UpdateContextMenu();
        }

		#endregion?Constructors?

		#region?Properties?(3)?

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context
        {
            get;
            set;
        }

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

		#endregion?Properties?

		#region?Methods?(8)?

		//?Private?Methods?(8)?

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
            if (!PermUtil.CheckPermission(Permission.SYSTEM_UPDATE))
            {
                return;
            }

            if (this.dgvUsers.SelectedRows.Count == 0)
            {
                return;
            }

            User selectedUser = (User)this.bs.List[this.dgvUsers.SelectedRows[0].Index];
            if (MessageBoxEx.Show("是否确定删除帐号: " + selectedUser.UserID, MESSAGE.TITLE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                context.Users.DeleteOnSubmit(selectedUser);
                bool isDeleteOK = true;
                try
                {
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isDeleteOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (isDeleteOK)
                {
                    this.dgvUsers.Rows.RemoveAt(this.dgvUsers.SelectedRows[0].Index);
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

            User selectedUser = (User)this.bs.List[this.dgvUsers.SelectedRows[0].Index];
            UserDetail detail = new UserDetail(selectedUser, UserDetail.OpUserType.DETAIL_USER);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUsers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvUsers.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), this.dgvUsers.RowHeadersDefaultCellStyle.Font, rectangle, this.dgvUsers.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// Popup UserDetailUI Form and Create a new User
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewUser(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.SYSTEM_UPDATE))
            {
                return;
            }

            UserDetail detail = new UserDetail(null, UserDetail.OpUserType.NEW_USER);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// Query user table according to keyword
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void QueryUsers(object sender, System.EventArgs e)
        {
            context = new DBDataContext();
            if (!PermUtil.ValidatePermission(Permission.SYSTEM_UPDATE))
            {
                context.ObjectTrackingEnabled = false;
            }

            var queryResult = context.Users.Where(u => u.UserID.Contains(tbUserID.Text));
            bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// Select current User and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectUser(object sender, EventArgs e)
        {
            if (this.dgvUsers.SelectedRows.Count == 0)
            {
                return;
            }

            User selectedUser = (User)this.bs.List[this.dgvUsers.SelectedRows[0].Index];
            this.Selected = selectedUser;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
            }
        }

        /// <summary>
        /// Update editable status
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permission.SYSTEM_UPDATE))
            {
                this.menuItemDeleteUser.Enabled = true;
                this.menuItemNewUser.Enabled = true;
            }
            else
            {
                this.menuItemDeleteUser.Enabled = false;
                this.menuItemNewUser.Enabled = false;
            }
        }

		#endregion?Methods?
    }
}

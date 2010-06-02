//-----------------------------------------------------------------------
// <copyright file="UserMgrUI.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.InfoMgr.UserMgr
{
    /// <summary>
    /// User Management User Interface
    /// </summary>
    public partial class UserMgr : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;


        /// <summary>
        /// Initializes a new instance of the UserMgrUI class
        /// </summary>
        public UserMgr()
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _bs = new BindingSource();
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = _bs;
            ControlUtil.SetDoubleBuffered(dgvUsers);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);

            UpdateContextMenu();
        }


        /// <summary>
        /// 
        /// </summary>
        private DBDataContext Context { get; set; }

        public Form OwnerForm { get; set; }

        /// <summary>
        /// Gets or sets selected user
        /// </summary>
        public User Selected { get; set; }


        //?Private?Methods?(8)?
        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OwnerForm == null)
            {
                DetailUser(sender, e);
            }
            else
            {
                SelectUser(sender, e);
            }
        }

        /// <summary>
        /// Delete current selected User
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteUser(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.SYSTEM_UPDATE))
            {
                return;
            }

            if (dgvUsers.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedUser = (User) _bs.List[dgvUsers.SelectedRows[0].Index];
            if (
                MessageBoxEx.Show("是否确定删除帐号: " + selectedUser.UserID, MESSAGE.TITLE_WARNING, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Context.Users.DeleteOnSubmit(selectedUser);
                try
                {
                    Context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    return;
                }
                dgvUsers.Rows.RemoveAt(dgvUsers.SelectedRows[0].Index);
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

            var selectedUser = (User) _bs.List[dgvUsers.SelectedRows[0].Index];
            var detail = new UserDetail(selectedUser, UserDetail.OpUserType.DETAIL_USER);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvUsersRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvUsers.RowHeadersWidth - 4,
                                          e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvUsers.RowHeadersDefaultCellStyle.Font,
                                  rectangle, dgvUsers.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// Popup UserDetailUI Form and Create a new User
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewUser(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.SYSTEM_UPDATE))
            {
                return;
            }

            var detail = new UserDetail(null, UserDetail.OpUserType.NEW_USER);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// Query user table according to keyword
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void QueryUsers(object sender, EventArgs e)
        {
            Context = new DBDataContext();
            if (!PermUtil.ValidatePermission(Permissions.SYSTEM_UPDATE))
            {
                Context.ObjectTrackingEnabled = false;
            }

            IQueryable<User> queryResult = Context.Users.Where(u => u.UserID.Contains(tbUserID.Text));
            _bs.DataSource = queryResult;
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

            var selectedUser = (User) _bs.List[dgvUsers.SelectedRows[0].Index];
            Selected = selectedUser;
            if (OwnerForm != null)
            {
                OwnerForm.DialogResult = DialogResult.Yes;
                OwnerForm.Close();
            }
        }

        /// <summary>
        /// Update editable status
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permissions.SYSTEM_UPDATE))
            {
                menuItemDeleteUser.Enabled = true;
                menuItemNewUser.Enabled = true;
            }
            else
            {
                menuItemDeleteUser.Enabled = false;
                menuItemNewUser.Enabled = false;
            }
        }
    }
}
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
    using System.Threading;
    using Microsoft.Office.Interop.Excel;
    using System.Reflection;

    /// <summary>
    /// User Management User Interface
    /// </summary>
    public partial class UserMgr : UserControl
    {
        /// <summary>
        /// flag indicates if editable
        /// </summary>
        private readonly bool isEditable;

        private BindingSource bs = new BindingSource();

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
        /// Gets or sets selected user
        /// </summary>
        public User Selected
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
        /// Query user table according to keyword
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void QueryUsers(object sender, System.EventArgs e)
        {
            string keyword = tbKeyword.Text.Trim();

            var queryResult =
            App.Current.DbContext.Users.Where(
                u => u.Name.Contains(keyword)
                  || u.UserID.Contains(keyword)
                  || u.EDIAccount.Contains(keyword)
                  || u.MSN.Contains(keyword)
                  || u.Phone.Contains(keyword)
                  || u.Telphone.Contains(keyword)
                  || u.Email.Contains(keyword));
            bs.DataSource = queryResult.ToList();
            dgvUsers.DataSource = bs;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// Popup UserDetailUI Form and Create a new User
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewUser(object sender, System.EventArgs e)
        {
            new UserDetail(null, UserDetail.OpUserType.NEW_USER).ShowDialog(this);
        }

        /// <summary>
        /// Popup UserDetailUI Form and Update current selected User
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void UpdateUser(object sender, System.EventArgs e)
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

        /// <summary>
        /// Delete current selected User
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteUser(object sender, System.EventArgs e)
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
        /// Popup a new form and display a user detailly
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailUser(object sender, System.EventArgs e)
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

        private void ImportUsers(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                Thread t = new Thread(ImportUsersImpl);
                t.Start(fileName);
            }
        }

        private static void ImportUsersImpl(object obj)
        {
            string fileName = obj as string;
            ApplicationClass app = new ApplicationClass { Visible = false };
            WorkbookClass w = (WorkbookClass)app.Workbooks.Open(
               @fileName,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value);

            Sheets sheets = w.Worksheets;
            Worksheet datasheet = null;

            foreach (Worksheet sheet in sheets)
            {
                if (datasheet == null)
                {
                    datasheet = sheet;
                    break;
                }
            }

            if (datasheet == null)
            {
                MessageBox.Show("未找到指定的Sheet！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                app.Quit();
                return;
            }

            Range range = datasheet.get_Range("A2", "AJ1000");
            Array values = (Array)range.Formula;
            if (values != null)
            {
                int length = values.GetLength(0);

                for (int row = 1; row <= length; row++)
                {
                    if (!values.GetValue(row, 1).Equals(string.Empty))
                    {
                        User user = null;
                        try
                        {
                            int column = 1;
                            string userId = values.GetValue(row, 1).ToString().Trim();
                            bool isNew = false;
                            user = App.Current.DbContext.Users.SingleOrDefault(c => c.UserID == userId);
                            if (user == null)
                            {
                                isNew = true;
                                user = new User();
                            }
                            user.UserID = values.GetValue(row, column++).ToString().Trim();
                            user.EDIAccount = values.GetValue(row, column++).ToString().Trim();
                            user.Password = values.GetValue(row, column++).ToString().Trim();
                            user.Role = values.GetValue(row, column++).ToString().Trim();
                            user.Name = values.GetValue(row, column++).ToString().Trim();
                            user.Phone = values.GetValue(row, column++).ToString().Trim();
                            user.Telphone = values.GetValue(row, column++).ToString().Trim();
                            user.Email = values.GetValue(row, column++).ToString().Trim();
                            user.MSN = values.GetValue(row, column++).ToString().Trim();

                            if (isNew)
                            {
                                App.Current.DbContext.Users.InsertOnSubmit(user);
                            }

                            App.Current.DbContext.SubmitChanges();
                        }
                        catch (Exception e)
                        {
                            DialogResult dr = MessageBox.Show("导入失败: " + e.Message + "\t" + user.Name + "\n" + "是否继续导入？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.No)
                            {
                                break;
                            }
                        }
                    }
                }
                MessageBox.Show("导入结束", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            app.Quit();
        }

    }
}

//-----------------------------------------------------------------------
// <copyright file="LoginWindow.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;


    /// <summary>
    /// Login Window
    /// </summary>
    public partial class LoginWindow : DevComponents.DotNetBar.Office2007Form
    {     
        /// <summary>
        /// Initializes a new instance of the LoginWindow class
        /// </summary>
        public LoginWindow()
        {
            this.InitializeComponent();
        }
        
        /// <summary>
        /// Auto login system. Only used in develop period.
        /// </summary>
        public void AutoLogin()
        {
            User curUser = new User { UserName = "系统管理员", UserID = "admin", Role = "管理员", LoginDate = DateTime.Now };
            App.Current.CurUser = curUser;
        }

        public bool PreLogin()
        {
            DBDataContext context = App.Current.DbContext;
            try
            {
                if (context.DatabaseExists())
                {
                    return true;
                }
                MessageBox.Show("数据库连接失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show("数据库连接失败: "+e.ToString(), "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }

        /// <summary>
        /// Event handler when login button clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Login(object sender, EventArgs e)
        {
            string uid = tbUserId.Text.Trim();
            string pass = tbPassword.Text.Trim();
            if (uid == string.Empty || pass == string.Empty)
            {
                labelMessage.Text = "用户名或密码不能为空";
            }
            else
            {
                User curUser = App.Current.DbContext.Users.SingleOrDefault(u => u.UserID == uid && u.Password == pass);

                if (curUser != null)
                {
                    curUser.LoginDate = DateTime.Now;
                    App.Current.DbContext.SubmitChanges();
                    App.Current.CurUser = curUser;
                    Close();
                }
                else
                {
                    labelMessage.Text = "用户名或密码不对";
                }
            }
        }
        
        /// <summary>
        /// Event handler when LoginWindow loaded.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Login_Load(object sender, EventArgs e)
        {
            tbUserId.Focus();
        }
        
        /// <summary>
        /// Event handler when cancel button clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}

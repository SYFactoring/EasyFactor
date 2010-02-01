﻿//-----------------------------------------------------------------------
// <copyright file="LoginWindow.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// Login Window
    /// </summary>
    public partial class LoginWindow : DevComponents.DotNetBar.Office2007Form
    {
        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the LoginWindow class
        /// </summary>
        public LoginWindow()
        {
            this.InitializeComponent();
        }

        #endregion Constructors

        #region Methods (4)

        // Public Methods (2) 

        /// <summary>
        /// Auto login system. Only used in develop period.
        /// </summary>
        public void AutoLogin()
        {
            User curUser = new User { Name = "系统管理员", UserID = "admin", Role = "管理员", LoginDate = DateTime.Now };
            App.Current.CurUser = curUser;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool PreLogin()
        {
            DBDataContext context = new DBDataContext();
            try
            {
                if (context.DatabaseExists())
                {
                    return true;
                }

                MessageBox.Show("数据库连接失败", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception e)
            {
                MessageBox.Show("数据库连接失败: " + e.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return false;
        }
        // Private Methods (2) 

        /// <summary>
        /// Event handler when cancel button clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Cancel(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Event handler when login button clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Login(object sender, EventArgs e)
        {
            if (!this.superValidator.Validate())
            {
                return;
            }

            string uid = this.tbUserId.Text.Trim();
            string pass = this.tbPassword.Text.Trim();
            DBDataContext context = new DBDataContext();
            User curUser = context.Users.SingleOrDefault(u => u.UserID == uid);

            if (curUser != null)
            {
                if (!curUser.Password.Equals(pass))
                {
                    this.errorProvider.SetError(this.tbPassword, "密码不正确");
                    return;
                }

                curUser.LoginDate = DateTime.Now;
                context.SubmitChanges();
                App.Current.CurUser = curUser;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.errorProvider.SetError(this.tbUserId, "用户名不存在");
            }
        }

        #endregion Methods
    }
}

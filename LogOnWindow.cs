//-----------------------------------------------------------------------
// <copyright file="LogOnWindow.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor
{
    /// <summary>
    /// Login Window
    /// </summary>
    public partial class LogOnWindow : Office2007Form
    {
        #region?Constructors?(1)?

        /// <summary>
        /// Initializes a new instance of the LoginWindow class
        /// </summary>
        public LogOnWindow()
        {
            InitializeComponent();
        }

        #endregion?Constructors?

        #region?Methods?(3)?

        //?Public?Methods?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool PreLogOn()
        {
            var context = new DBDataContext();
            try
            {
                if (context.DatabaseExists())
                {
                    return true;
                }

                MessageBoxEx.Show("数据库连接失败", MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception e)
            {
                MessageBoxEx.Show("数据库连接失败: " + e.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return false;
            }

            return false;
        }

        //?Private?Methods?(2)?

        /// <summary>
        /// Event handler when cancel button clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Cancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Event handler when login button clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void LogOn(object sender, EventArgs e)
        {
            if (!superValidator.Validate())
            {
                return;
            }

            string uid = tbUserId.Text.Trim();
            string pass = tbPassword.Text.Trim();
            var context = new DBDataContext();
            User curUser = context.Users.SingleOrDefault(u => u.UserID == uid);

            if (curUser != null)
            {
                if (!curUser.Password.Equals(pass))
                {
                    errorProvider.SetError(tbPassword, "密码不正确");
                    return;
                }

                curUser.LoginDate = DateTime.Now;
                context.SubmitChanges();
                App.Current.CurUser = curUser;
                DialogResult = DialogResult.OK;
            }
            else
            {
                errorProvider.SetError(tbUserId, "用户名不存在");
            }
        }

        #endregion?Methods?
    }
}
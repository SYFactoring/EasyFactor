//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace CMBC.EasyFactor
{
    /// <summary>
    /// Applicatoin entry class
    /// </summary>
    public static class Program
    {
        #region?Methods?(1)?

        //?Public?Methods?(1)?

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var loginWindow = new LogOnWindow();
            if (!LogOnWindow.PreLogOn())
            {
                return;
            }

            loginWindow.ShowDialog();
            //loginWindow.AutoLogin();

            if (App.Current.CurUser != null)
            {
                var mainWindow = new MainWindow();
                App.Current.MainWindow = mainWindow;
                Application.Run(mainWindow);
            }
        }

        #endregion?Methods?
    }
}
//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor
{
    using System;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;

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
            LogOnWindow loginWindow = new LogOnWindow();
            if (!loginWindow.PreLogOn())
            {
                return;
            }

            loginWindow.ShowDialog();
            //loginWindow.AutoLogin();

            if (App.Current.CurUser != null)
            {
                MainWindow mainWindow = new MainWindow();
                App.Current.MainWindow = mainWindow;
                Application.Run(mainWindow);
            }
        }

        #endregion?Methods?
    }
}

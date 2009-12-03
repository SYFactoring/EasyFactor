//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Applicatoin entry class
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginWindow loginWindow = new LoginWindow();
            //loginWindow.ShowDialog();
            if (!loginWindow.PreLogin())
            {
                return;
            }
            loginWindow.AutoLogin();

            if (App.Current.CurUser != null)
            {
                MainWindow mainWindow = new MainWindow();
                App.Current.MainWindow = mainWindow;
                Application.Run(new MainWindow());
            }
        }
    }
}

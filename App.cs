//-----------------------------------------------------------------------
// <copyright file="App.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor
{
    using DB.dbml;

    /// <summary>
    /// Globle variable
    /// </summary>
    public class App
    {
        /// <summary>
        /// private static class variable
        /// </summary>
        private static App _current;
        /// <summary>
        /// Prevents a default instance of the App class from being created
        /// </summary>
        private App()
        {
        }
        /// <summary>
        /// Gets current class variable
        /// </summary>
        public static App Current
        {
            get { return _current ?? (_current = new App()); }
        }
        /// <summary>
        /// Gets or sets Current User
        /// </summary>
        public User CurUser { get; set; }
        /// <summary>
        /// Gets or Sets Main Window
        /// </summary>
        public MainWindow MainWindow
        {
            get;
            set;
        }
    }
}
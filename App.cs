//-----------------------------------------------------------------------
// <copyright file="App.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor
{
    using CMBC.EasyFactor.DB.dbml;

    /// <summary>
    /// Globle variable
    /// </summary>
    public class App
    {
        /// <summary>
        /// private static class variable
        /// </summary>
        private static App current;

        /// <summary>
        /// Prevents a default instance of the App class from being created
        /// </summary>
        private App()
        {
            this.DbContext = new DBDataContext();
        }

        /// <summary>
        /// Gets current class variable
        /// </summary>
        public static App Current
        {
            get { return current ?? (current = new App()); }
        }

        /// <summary>
        /// Gets or sets Current User
        /// </summary>
        public User CurUser { get; set; }

        /// <summary>
        /// Gets DbContext
        /// </summary>
        public DBDataContext DbContext { get; private set; }
    }
}
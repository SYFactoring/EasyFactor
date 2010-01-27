﻿//-----------------------------------------------------------------------
// <copyright file="App.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor
{
    using CMBC.EasyFactor.DB.dbml;
    using System.IO;
    using System;

    /// <summary>
    /// Globle variable
    /// </summary>
    public class App
    {
        #region Fields (1)

        /// <summary>
        /// private static class variable
        /// </summary>
        private static App current;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Prevents a default instance of the App class from being created
        /// </summary>
        private App()
        {
            this.DbContext = new DBDataContext();
            //this.DbContext.Log = File.CreateText(Path.Combine(Environment.CurrentDirectory, String.Format("{0:yyyy-MM-dd-HH-mm}.txt", DateTime.Now)));
        }

        #endregion Constructors

        #region Properties (4)

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

        /// <summary>
        /// Gets or Sets Main Window
        /// </summary>
        public MainWindow MainWindow
        {
            get;
            set;
        }

        #endregion Properties
    }
}
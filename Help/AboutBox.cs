//-----------------------------------------------------------------------
// <copyright file="AboutBox.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.IO;
using System.Reflection;
using DevComponents.DotNetBar;
using System.Diagnostics;

namespace CMBC.EasyFactor.Help
{
    /// <summary>
    /// About Box Dialog
    /// </summary>
    public partial class AboutBox : Office2007Form
    {
        /// <summary>
        /// Initializes a new instance of the AboutBox class
        /// </summary>
        public AboutBox()
        {
            InitializeComponent();
            Text = String.Format("关于 {0}", AssemblyTitle);
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = String.Format("版本 {0}", AssemblyVersion);
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyCompany;
            textBoxDescription.Text = AssemblyDescription;
        }


        /// <summary>
        /// Gets assembly company
        /// </summary>
        public static string AssemblyCompany
        {
            get
            {
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }

                return ((AssemblyCompanyAttribute) attributes[0]).Company;
            }
        }

        /// <summary>
        /// Gets assembly copyright
        /// </summary>
        public static string AssemblyCopyright
        {
            get
            {
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }

                return ((AssemblyCopyrightAttribute) attributes[0]).Copyright;
            }
        }

        /// <summary>
        /// Gets assembly description
        /// </summary>
        public static string AssemblyDescription
        {
            get
            {
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }

                return ((AssemblyDescriptionAttribute) attributes[0]).Description;
            }
        }

        /// <summary>
        /// Gets assembly product
        /// </summary>
        public static string AssemblyProduct
        {
            get
            {
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }

                return ((AssemblyProductAttribute) attributes[0]).Product;
            }
        }

        /// <summary>
        /// Gets assembly title
        /// </summary>
        public static string AssemblyTitle
        {
            get
            {
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    var titleAttribute = (AssemblyTitleAttribute) attributes[0];
                    if (!String.IsNullOrEmpty(titleAttribute.Title))
                    {
                        return titleAttribute.Title;
                    }
                }

                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        /// <summary>
        /// Gets assembly version
        /// </summary>
        public static string AssemblyVersion
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }


        //?Private?Methods?(1)?
        /// <summary>
        /// Close the dialog
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickLogo(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://homepage.fudan.edu.cn/~yimingliu/EasyFactoring/index.html");
            }
            catch (Exception)
            {
                MessageBoxEx.Show("打开浏览器失败");
            }
        }
    }
}
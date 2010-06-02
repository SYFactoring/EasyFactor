//-----------------------------------------------------------------------
// <copyright file="QueryForm.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryForm : Office2007Form
    {
        /// <summary>
        /// Initializes a new instance of the QueryForm class.
        /// </summary>
        /// <param name="userControl"></param>
        /// <param name="title"></param>
        public QueryForm(UserControl userControl, string title)
        {
            if (userControl == null)
            {
                return;
            }

            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            Text = title;
            userControl.Dock = DockStyle.Fill;
            panelRoot.Controls.Clear();
            panelRoot.Controls.Add(userControl);
        }
    }
}
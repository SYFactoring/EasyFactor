//-----------------------------------------------------------------------
// <copyright file="QueryForm.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Utils
{
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public partial class QueryForm : DevComponents.DotNetBar.Office2007Form
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

            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.Text = title;
            userControl.Dock = DockStyle.Fill;
            this.panelRoot.Controls.Clear();
            this.panelRoot.Controls.Add(userControl);
        }
    }
}

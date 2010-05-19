using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace CMBC.EasyFactor.Help
{
    public partial class SystemSetting : DevComponents.DotNetBar.Office2007Form
    {
        public SystemSetting()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectReportPath(object sender, EventArgs e)
        {
            FolderBrowserDialog fileDialog = new FolderBrowserDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbReportPath.Text = fileDialog.SelectedPath;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectLegerPath(object sender, EventArgs e)
        {
            FolderBrowserDialog fileDialog = new FolderBrowserDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbLegerPath.Text = fileDialog.SelectedPath;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveSetting(object sender, EventArgs e)
        {
            ConfigurationSettings.AppSettings["ReportPath"] = this.tbReportPath.Text;
            ConfigurationSettings.AppSettings["LegerPath"] = this.tbLegerPath.Text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelSetting(object sender, EventArgs e)
        {

        }
    }
}

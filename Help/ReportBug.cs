//-----------------------------------------------------------------------
// <copyright file="ReportBug.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Help
{
    using System;
    using System.Reflection;
    using System.Windows.Forms;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class ReportBug : DevComponents.DotNetBar.Office2007Form
    {
        /// <summary>
        /// 
        /// </summary>
        private SendMail mail;

        /// <summary>
        /// 
        /// </summary>
        public ReportBug()
        {
            InitializeComponent();
            this.tbSubmitPerson.Text = App.Current.CurUser.Name;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitBug(object sender, EventArgs e)
        {
            string title = this.tbTitle.Text;
            string who = this.tbSubmitPerson.Text;
            string type = this.cbBugType.Text;
            string path = this.tbAttachment.Text;
            string mailTitle = String.Format("{0}_{1}_{2}_{3:yyyy/MM/dd HH:mm:ss}", type, who, title, DateTime.Now);
            string bug = this.tbBug.Text + "\n----------------------------------------------\n" + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            mail = new SendMail("liuyiming.vip@gmail.com", App.Current.CurUser.Email, mailTitle, bug, path);
            this.btnSubmit.Enabled = false;
            this.backgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFile(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbAttachment.Text = fileDialog.FileName;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            mail.Send();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBoxEx.Show("问题反馈失败，原因： " + e.Error.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBoxEx.Show("感谢您的反馈，我会立即处理您的意见，并将处理结果及时通知您。", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.btnSubmit.Enabled = true;
        }
    }
}

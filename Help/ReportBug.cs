//-----------------------------------------------------------------------
// <copyright file="ReportBug.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.Help
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReportBug : Office2007Form
    {
        /// <summary>
        /// 
        /// </summary>
        private SendMail _mail;


        /// <summary>
        /// 
        /// </summary>
        public ReportBug()
        {
            InitializeComponent();
            tbSubmitPerson.Text = App.Current.CurUser.Name;
        }


        //?Private?Methods?(4)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            if (!String.IsNullOrEmpty(tbAttachment.Text))
            {
                _mail.AddAttachment(tbAttachment.Text);
            }

            if (_mail != null)
            {
                _mail.Send();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBoxEx.Show("问题反馈失败，原因： " + e.Error.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
            }
            else
            {
                MessageBoxEx.Show("感谢您的反馈，我会立即处理您的意见，并将处理结果及时通知您。", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
            }

            btnSubmit.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFile(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbAttachment.Text = fileDialog.FileName;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitBug(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;

            string title = tbTitle.Text;
            string who = tbSubmitPerson.Text;
            string type = cbBugType.Text;
            string mailTitle = String.Format("{0}_{1}_{2}_{3:yyyy/MM/dd HH:mm:ss}", type, who, title, DateTime.Now);
            string bug = tbBug.Text + "\n----------------------------------------------\n" +
                         Assembly.GetExecutingAssembly().GetName().Version;

            _mail = new SendMail("liuyiming.vip@gmail.com", "xiaolan.pub@gmail.com", App.Current.CurUser.Email, mailTitle,
                                bug);

            backgroundWorker.RunWorkerAsync();
        }
    }
}
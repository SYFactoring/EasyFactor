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
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class ReportBug : DevComponents.DotNetBar.Office2007Form
    {
		#region?Fields?(1)?

        /// <summary>
        /// 
        /// </summary>
        private SendMail mail;

		#endregion?Fields?

		#region?Constructors?(1)?

        /// <summary>
        /// 
        /// </summary>
        public ReportBug()
        {
            InitializeComponent();
            this.tbSubmitPerson.Text = App.Current.CurUser.Name;
        }

		#endregion?Constructors?

		#region?Methods?(4)?

		//?Private?Methods?(4)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tbAttachment.Text))
            {
                mail.AddAttachment(this.tbAttachment.Text);
            }

            if (mail != null)
            {
                mail.Send();
            }
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
                MessageBoxEx.Show("���ⷴ��ʧ�ܣ�ԭ�� " + e.Error.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBoxEx.Show("��л���ķ������һ������������������������������ʱ֪ͨ����", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.btnSubmit.Enabled = true;
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
        private void SubmitBug(object sender, EventArgs e)
        {
            this.btnSubmit.Enabled = false;

            string title = this.tbTitle.Text;
            string who = this.tbSubmitPerson.Text;
            string type = this.cbBugType.Text;
            string mailTitle = String.Format("{0}_{1}_{2}_{3:yyyy/MM/dd HH:mm:ss}", type, who, title, DateTime.Now);
            string bug = this.tbBug.Text + "\n----------------------------------------------\n" + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            mail = new SendMail("liuyiming.vip@gmail.com","xiaolan.pub@gmail.com", App.Current.CurUser.Email, mailTitle, bug);
            
            this.backgroundWorker.RunWorkerAsync();
        }

		#endregion?Methods?
    }
}

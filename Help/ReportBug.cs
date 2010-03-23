using System;
using System.Reflection;
using System.Windows.Forms;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.Help
{
    public partial class ReportBug : DevComponents.DotNetBar.Office2007Form
    {
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

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            mail.Send();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBoxEx.Show("发送反馈失败: " + e.Error.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBoxEx.Show("意见已经提交", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.btnSubmit.Enabled = true;
        }
    }
}

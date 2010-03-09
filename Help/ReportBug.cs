using System;
using System.Windows.Forms;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.Help
{
    public partial class ReportBug : DevComponents.DotNetBar.Office2007Form
    {
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
            string bug = this.tbBug.Text;
            string who = this.tbSubmitPerson.Text;
            string type = this.cbBugType.Text;
            string path = this.tbAttachment.Text;

            string systemInfo = SystemUtil.GetSystemInformation();

            bug = bug + "\n----------------------------------------------\n" + systemInfo;

            bool isOK = true;
            try
            {
                MailUtil.SendMail("liuyiming.vip@gmail.com", App.Current.CurUser.Email, type + "_" + who + "_" + DateTime.Today.ToShortDateString(), bug, path);
            }
            catch (Exception e1)
            {
                isOK = false;
                MessageBoxEx.Show("发送反馈失败: " + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isOK)
            {
                MessageBoxEx.Show("意见已经提交", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
    }
}

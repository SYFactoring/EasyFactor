using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
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

            string systemInfo = GetSystemInformation();

            bug = bug + "\n----------------------------------------------\n" + systemInfo;

            bool isOK = true;
            try
            {
                SendMail mail = new SendMail("liuyiming.vip@gmail.com", App.Current.CurUser.Email, type + "_" + who + "_" + DateTime.Today.ToShortDateString(), bug);
                if (path != string.Empty)
                {
                    mail.AddAttachment(path);
                }
                mail.Send();
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static string GetSystemInformation()
        {
            StringBuilder sb = new StringBuilder();

            //获取操作系统设置
            sb.AppendLine("获取操作系统设置");
            sb.AppendLine("计算机名 : " + SystemInformation.ComputerName);
            sb.AppendLine("是否已连接网络 : " + SystemInformation.Network);
            sb.AppendLine("用户域 : " + SystemInformation.UserDomainName);
            sb.AppendLine("当前线程用户名   : " + SystemInformation.UserName);
            sb.AppendLine("启动方式 : " + SystemInformation.BootMode);
            sb.AppendLine("菜单的字体 : " + SystemInformation.MenuFont);
            sb.AppendLine("显示器的数目 : " + SystemInformation.MonitorCount);
            sb.AppendLine("鼠标已安装 : " + SystemInformation.MousePresent);
            sb.AppendLine("鼠标按钮数    : " + SystemInformation.MouseButtons);
            sb.AppendLine("是否交互模式    : " + SystemInformation.UserInteractive);
            sb.AppendLine("屏幕界限: " + SystemInformation.VirtualScreen);
            sb.AppendLine();

            //获取程序运行的相关信息.
            sb.AppendLine("获取程序运行的相关信息");
            sb.AppendLine("命令行:" + Environment.CommandLine);
            sb.AppendLine("命令行参数:" + String.Join(", ", Environment.GetCommandLineArgs()));
            sb.AppendLine("当前目录:" + Environment.CurrentDirectory);
            sb.AppendLine("操作系统版本:" + Environment.OSVersion);
            sb.AppendLine("系统目录:" + Environment.SystemDirectory);
            sb.AppendLine("用户域:" + Environment.UserDomainName);
            sb.AppendLine("CLR版本:" + Environment.Version);
            sb.AppendLine("系统启动后经过的毫秒:" + Environment.TickCount);
            sb.AppendLine("进程上下文的物理内存量:" + Environment.WorkingSet);

            String[] drives = Environment.GetLogicalDrives();
            sb.AppendLine("本机磁盘驱动器: " + String.Join(", ", drives));

            // 获取本机所有环境变量
            sb.AppendLine();
            sb.AppendLine("获取本机所有环境变量");
            IDictionary environmentVariables = Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry de in environmentVariables)
            {
                sb.AppendLine(de.Key + "=" + de.Value);
            }

            return sb.ToString();
        }
    }

    class SendMail
    {
        private MailMessage mailMessage;

        /// <summary>  
        /// 
        /// </summary>  
        /// <param name="To">收件人地址</param>  
        /// <param name="From">发件人地址</param>  
        /// <param name="Body">邮件正文</param>  
        /// <param name="Title">邮件的主题</param>  
        public SendMail(string To, string From, string Title, string Body)
        {
            mailMessage = new MailMessage();
            mailMessage.To.Add(To);
            if (From == null)
            {
                From = "yimingliu@fudan.edu.cn";
            }

            mailMessage.From = new MailAddress(From);
            mailMessage.Subject = Title;
            mailMessage.SubjectEncoding = Encoding.UTF8;
            mailMessage.Body = Body;
            mailMessage.BodyEncoding = Encoding.UTF8;
            mailMessage.IsBodyHtml = false;
            mailMessage.Priority = MailPriority.Normal;
        }

        /// <summary>  
        /// 添加附件  
        /// </summary>  
        public void AddAttachment(string path)
        {
            Attachment data = new Attachment(path, MediaTypeNames.Application.Octet);//实例化附件  
            ContentDisposition disposition = data.ContentDisposition;
            disposition.CreationDate = File.GetCreationTime(path);//获取附件的创建日期  
            disposition.ModificationDate = File.GetLastWriteTime(path);//获取附件的修改日期  
            disposition.ReadDate = File.GetLastAccessTime(path);//获取附件的读取日期  
            mailMessage.Attachments.Add(data);//添加到附件中  
        }

        /// <summary>  
        /// 发送邮件  
        /// </summary>  
        public void Send()
        {
            if (mailMessage != null)
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "mail.fudan.edu.cn";
                smtpClient.Credentials = new NetworkCredential("yimingliu", "p0o9i8u7y6");//设置发件人身份的票据  
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Send(mailMessage);
            }
        }
    }
}

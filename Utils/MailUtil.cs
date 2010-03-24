using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace CMBC.EasyFactor.Utils
{
    /// <summary>
    /// 
    /// </summary>
    class SendMail
    {
        private MailMessage mailMessage;

        private string path;

        /// <summary>  
        /// 
        /// </summary>  
        /// <param name="To">收件人地址</param>  
        /// <param name="From">发件人地址</param>  
        /// <param name="Body">邮件正文</param>  
        /// <param name="Title">邮件的主题</param>  
        public SendMail(string To, string From, string Title, string Body, string Path)
        {
            string[] toAddresses = To.Split(new char[] { ';' });
            mailMessage = new MailMessage();
            mailMessage.To.Add(toAddresses[0]);
            if (toAddresses.Length > 1)
            {
                for (int i = 1; i < toAddresses.Length; i++)
                {
                    mailMessage.CC.Add(toAddresses[i]);
                }
            }

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
            this.path = Path;
        }

        /// <summary>  
        /// 添加附件  
        /// </summary>  
        private void AddAttachment(string path)
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
                if (!String.IsNullOrEmpty(this.path))
                {
                    AddAttachment(path);
                }

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "mail.fudan.edu.cn";
                smtpClient.Credentials = new NetworkCredential("yimingliu", "p0o9i8u7y6");//设置发件人身份的票据  
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Send(mailMessage);
            }
        }
    }
}

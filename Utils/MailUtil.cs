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
    class SendMail : IDisposable
    {
		#region?Fields?(2)?

        private MailMessage mailMessage;
        private string path;

		#endregion?Fields?

		#region?Constructors?(1)?

        /// <summary>  
        /// 
        /// </summary>  
        /// <param name="To">�ռ��˵�ַ</param>  
        /// <param name="From">�����˵�ַ</param>  
        /// <param name="Body">�ʼ�����</param>  
        /// <param name="Title">�ʼ�������</param>  
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

		#endregion?Constructors?

		#region?Methods?(2)?

		//?Public?Methods?(1)?

        /// <summary>  
        /// �����ʼ�  
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
                smtpClient.Credentials = new NetworkCredential("yimingliu", "p0o9i8u7y6");//���÷�������ݵ�Ʊ��  
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Send(mailMessage);
            }
        }
		//?Private?Methods?(1)?

        /// <summary>  
        /// ��Ӹ���  
        /// </summary>  
        private void AddAttachment(string attachmentPath)
        {
            Attachment data = new Attachment(attachmentPath, MediaTypeNames.Application.Octet);//ʵ��������  
            ContentDisposition disposition = data.ContentDisposition;
            disposition.CreationDate = File.GetCreationTime(attachmentPath);//��ȡ�����Ĵ�������  
            disposition.ModificationDate = File.GetLastWriteTime(attachmentPath);//��ȡ�������޸�����  
            disposition.ReadDate = File.GetLastAccessTime(attachmentPath);//��ȡ�����Ķ�ȡ����  
            mailMessage.Attachments.Add(data);//��ӵ�������  
        }

		#endregion?Methods?



        #region IDisposable Members

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            if (this.mailMessage != null)
            {
                this.mailMessage.Dispose();
            }
        }

        #endregion
    }
}

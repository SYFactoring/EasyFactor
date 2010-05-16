//-----------------------------------------------------------------------
// <copyright file="Utils.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Utils
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Mail;
    using System.Net.Mime;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    class SendMail : IDisposable
    {
        #region?Fields?(2)?

        private MailMessage mailMessage;

        #endregion?Fields?

        #region?Constructors?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="To"></param>
        /// <param name="Cc"></param>
        /// <param name="From"></param>
        /// <param name="Title"></param>
        /// <param name="Body"></param>
        public SendMail(string To, string Cc, string From, string Title, string Body)
        {
            mailMessage = new MailMessage();
            if (!String.IsNullOrEmpty(To))
            {
                foreach (string to in To.Split(new char[] { ';' }))
                {
                    mailMessage.To.Add(to);
                }
            }

            if (!String.IsNullOrEmpty(Cc))
            {
                foreach (string cc in Cc.Split(new char[] { ';' }))
                {
                    mailMessage.CC.Add(cc);
                }
            }

            if (String.IsNullOrEmpty(From))
            {
                From = "factoring@cmbc.com.cn";
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
        /// 
        /// </summary>  
        /// <param name="To">�ռ��˵�ַ</param>  
        /// <param name="From">�����˵�ַ</param>  
        /// <param name="Body">�ʼ�����</param>  
        /// <param name="Title">�ʼ�������</param>  
        public SendMail(string To, string From, string Title, string Body)
            : this(To, null, From, Title, Body)
        {

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
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new NetworkCredential("xiaolan.pub@gmail.com", "lan830215");//���÷�������ݵ�Ʊ��  
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Send(mailMessage);
            }
        }
        //?Private?Methods?(1)?

        /// <summary>  
        /// ��Ӹ���  
        /// </summary>  
        public void AddAttachment(string attachmentPath)
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

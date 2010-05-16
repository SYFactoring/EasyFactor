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
        /// <param name="To">收件人地址</param>  
        /// <param name="From">发件人地址</param>  
        /// <param name="Body">邮件正文</param>  
        /// <param name="Title">邮件的主题</param>  
        public SendMail(string To, string From, string Title, string Body)
            : this(To, null, From, Title, Body)
        {

        }

        #endregion?Constructors?

        #region?Methods?(2)?

        //?Public?Methods?(1)?

        /// <summary>  
        /// 发送邮件  
        /// </summary>  
        public void Send()
        {
            if (mailMessage != null)
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new NetworkCredential("xiaolan.pub@gmail.com", "lan830215");//设置发件人身份的票据  
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Send(mailMessage);
            }
        }
        //?Private?Methods?(1)?

        /// <summary>  
        /// 添加附件  
        /// </summary>  
        public void AddAttachment(string attachmentPath)
        {
            Attachment data = new Attachment(attachmentPath, MediaTypeNames.Application.Octet);//实例化附件  
            ContentDisposition disposition = data.ContentDisposition;
            disposition.CreationDate = File.GetCreationTime(attachmentPath);//获取附件的创建日期  
            disposition.ModificationDate = File.GetLastWriteTime(attachmentPath);//获取附件的修改日期  
            disposition.ReadDate = File.GetLastAccessTime(attachmentPath);//获取附件的读取日期  
            mailMessage.Attachments.Add(data);//添加到附件中  
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

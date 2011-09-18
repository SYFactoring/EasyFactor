//-----------------------------------------------------------------------
// <copyright file="Utils.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

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
    internal class SendMail : IDisposable
    {

        private readonly MailMessage _mailMessage;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="to"></param>
        /// <param name="cc"></param>
        /// <param name="from"></param>
        /// <param name="title"></param>
        /// <param name="body"></param>
        public SendMail(string to, string cc, string from, string title, string body)
        {
            _mailMessage = new MailMessage();
            if (!String.IsNullOrEmpty(to))
            {
                foreach (string t in to.Split(new[] { ';' }))
                {
                    _mailMessage.To.Add(t);
                }
            }

            if (!String.IsNullOrEmpty(cc))
            {
                foreach (string c in cc.Split(new[] { ';' }))
                {
                    _mailMessage.CC.Add(c);
                }
            }

            if (String.IsNullOrEmpty(from))
            {
                from = "factoring@cmbc.com.cn";
            }

            _mailMessage.From = new MailAddress(from);
            _mailMessage.ReplyTo = new MailAddress(from);
            _mailMessage.Subject = title;
            _mailMessage.SubjectEncoding = Encoding.UTF8;
            _mailMessage.Body = body;
            _mailMessage.BodyEncoding = Encoding.UTF8;
            _mailMessage.IsBodyHtml = false;
            _mailMessage.Priority = MailPriority.Normal;
        }

        //?Private?Methods?(1)?
        /// <summary>  
        /// ��Ӹ���  
        /// </summary>  
        public void AddAttachment(string attachmentPath)
        {
            var data = new Attachment(attachmentPath, MediaTypeNames.Application.Octet); //ʵ��������  
            ContentDisposition disposition = data.ContentDisposition;
            disposition.CreationDate = File.GetCreationTime(attachmentPath); //��ȡ�����Ĵ�������  
            disposition.ModificationDate = File.GetLastWriteTime(attachmentPath); //��ȡ�������޸�����  
            disposition.ReadDate = File.GetLastAccessTime(attachmentPath); //��ȡ�����Ķ�ȡ����  
            _mailMessage.Attachments.Add(data); //��ӵ�������  
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            if (_mailMessage != null)
            {
                _mailMessage.Dispose();
            }
        }

        //?Public?Methods?(1)?
        /// <summary>  
        /// �����ʼ�  
        /// </summary>  
        public void Send()
        {
            if (_mailMessage != null)
            {
                var smtpClient = new SmtpClient("smtp.cmbc.com.cn", 25)
                                     {
                                         Credentials = new NetworkCredential("factoring", "factor2011"),
                                         //EnableSsl = true,
                                         DeliveryMethod = SmtpDeliveryMethod.Network
                                     };
                smtpClient.Send(_mailMessage);
            }
        }
    }
}
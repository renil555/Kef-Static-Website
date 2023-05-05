using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace SMTPMail.KEF.Models
{
    public class Request
    {

        public string ToEmail { get; set; }
        public List<string> CcEmail { get; set; }
        public List<string> BccEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<string> Attachments { get; set; }
    }
    public class Response
    {
        public bool IsSuccess { get; set; }
        public string Exception { get; set; }
    }
    public class Setting
    {
        public string FromMailAddress { get; set; }
        public string FromMailDisplayName { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public SecureSocketOptions SecureSocketOptions { get; set; } = SecureSocketOptions.StartTls;
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Class1
    {
        public void ConfigMail(string toEmail, string title,string subject, string body)
        {
            var _from = ConfigurationManager.AppSettings["_from"].ToString();
            var _password = ConfigurationManager.AppSettings["_password"].ToString();
            var SMTPHost = ConfigurationManager.AppSettings["SMTPHost"].ToString();
            var SMTPPort = ConfigurationManager.AppSettings["SMTPPort"].ToString();
            bool EnabledSSL = bool.Parse(ConfigurationManager.AppSettings["EnabledSSL".ToString()]);

            var _body = body;
            MailMessage mailMessage = new MailMessage(new MailAddress(_from, title), new MailAddress(toEmail));
            mailMessage.Subject = subject;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = body;
            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential(_from, _password);
            client.Host = SMTPHost;
            client.EnableSsl = EnabledSSL;
            client.Port = Convert.ToInt32(SMTPPort);
            client.Send(mailMessage);
        }
    }
}

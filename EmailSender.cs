using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Utility
{
    public class EmailSender : IEmailSender
    {
        // Implement the SendEmailAsync method from IEmailSender interface
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //logic to send email
            return Task.CompletedTask;
        }

        /*public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient("HostClient URL", 587) // 587 smtp port number - default
            {
                Credentials = new System.Net.NetworkCredential("SMTP EMAIL HERE", "SMTP PASSWORD HERE"),
                EnableSsl = true
            };
            var mailMessage = new MailMessage
            {
                From = new MailAddress("SMTP EMAIL HERE"),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };
            mailMessage.To.Add(email);
            return client.SendMailAsync(mailMessage);
        }*/
    }
}

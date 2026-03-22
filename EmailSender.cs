using Microsoft.AspNetCore.Identity.UI.Services;
using System.IO;
using System.Net.Mail;

namespace asprule1020.Utility
{
    public class EmailSender : IEmailSender
    {
        //public Task SendEmailAsync(string email, string subject, string htmlMessage)
        //{
        //    //logic to send email
        //    return Task.CompletedTask;
        //}

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient("smtp.hostinger.com", 587) // 587 smtp port number - default
            {
                Credentials = new System.Net.NetworkCredential("noreply@rule1020.dole4a.com", "itDOLE4@rule1020"),
                EnableSsl = true
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("noreply@rule1020.dole4a.com"),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            mailMessage.To.Add(email);
            return client.SendMailAsync(mailMessage);
        }

        public async Task SendEmailAsync(
            string email,
            string subject,
            string htmlMessage,
            byte[] attachmentBytes,
            string attachmentFileName,
            string contentType = "application/octet-stream")
        {
            using var client = new SmtpClient("smtp.hostinger.com", 587)
            {
                Credentials = new System.Net.NetworkCredential("noreply@rule1020.dole4a.com", "itDOLE4@rule1020"),
                EnableSsl = true
            };

            using var mailMessage = new MailMessage
            {
                From = new MailAddress("noreply@rule1020.dole4a.com"),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            mailMessage.To.Add(email);

            using var stream = new MemoryStream(attachmentBytes);
            var attachment = new Attachment(stream, attachmentFileName, contentType);
            mailMessage.Attachments.Add(attachment);

            await client.SendMailAsync(mailMessage);
        }
    }
}

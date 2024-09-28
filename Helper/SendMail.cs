using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace app2game.Helper
{
    public class SendMail
    {
        private readonly string smtpServer = "smtp.gmail.com";
        private readonly int smtpPort = 587;
        private readonly bool enableSsl = true;
        private readonly string emailFrom = "losduartedeperu@gmail.com";
        private readonly string emailPassword = "tuContraseña"; 

        public async Task EnviarCorreoAsync(string emailTo, string subject, string body,string contraseña)
        {
            try
            {
                using (var client = new SmtpClient(smtpServer, smtpPort))
                {
                    client.EnableSsl = enableSsl;
                    client.Credentials = new NetworkCredential(emailFrom, contraseña);

                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(emailFrom),
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = true,  // Si quieres enviar el cuerpo del correo en formato HTML.
                    };

                    mailMessage.To.Add(emailTo);

                    await client.SendMailAsync(mailMessage);
                }

                Console.WriteLine("Correo enviado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error enviando correo: {ex.Message}");
            }
        }

    }
}
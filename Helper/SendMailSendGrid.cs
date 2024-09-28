using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace app2game.Helper
{
    public class SendMailSendGrid
    {
         private readonly string apiKey = "TU_API_KEY_AQUI"; // Reemplaza con tu API Key

        public async Task EnviarCorreoAsync(string emailTo, string subject, string body, string _apiKey)
        {
            var client = new SendGridClient(_apiKey);
            var from = new EmailAddress("fduartej@usmp.pe", "App");
            var to = new EmailAddress(emailTo);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, body, body);
            
            var response = await client.SendEmailAsync(msg);
            Console.WriteLine($"Correo enviado con estado: {response.StatusCode}");
        }
    }
}
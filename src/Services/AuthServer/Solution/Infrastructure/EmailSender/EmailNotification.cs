using System.Threading.Tasks;
using AuthIdentityServer.Models.SendGrid;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace AuthIdentityServer.Infrastructure.EmailSender
{
    public class EmailNotifaction<T> : IEmailNotification<T>
    {
        private readonly IOptions<EmailCredientials> Credientials;
        public EmailNotifaction(IOptions<EmailCredientials> _credientials)
        {
            Credientials = _credientials;
        }
        public async Task Send(T obj, string To,string Subject,string Template)
        {
            var client = new SendGridClient(Credientials.Value.ApiKey);
            string templateId = Credientials.Value.Templates[Template];

            var message = new SendGridMessage()
            {
                From = new EmailAddress(Credientials.Value.SendFrom, Credientials.Value.UserName),
                Subject=Subject
            };
            message.AddTo(new EmailAddress(To));
            message.SetSubject(Subject);
            message.SetTemplateId(templateId);
            message.SetTemplateData(obj);

            await client.SendEmailAsync(message).ConfigureAwait(false);
        }
    }
}

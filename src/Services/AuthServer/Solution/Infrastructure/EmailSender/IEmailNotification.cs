using System.Threading.Tasks;

namespace AuthIdentityServer.Infrastructure.EmailSender
{
    public interface IEmailNotification<in T>
    {
        Task Send(T obj, string To, string Subject, string Template);
    }
}
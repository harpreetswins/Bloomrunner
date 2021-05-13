using System.Threading.Tasks;

namespace CRM.API.Infrastructure.EmailSender
{
    public interface IEmailNotification<in T>
    {
        Task Send(T obj, string To, string Subject, string Template);
    }
}
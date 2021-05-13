using System.Threading.Tasks;
using BuildingBlocks.Messages;
using BuildingBlocks.RabbitMq;

namespace BuildingBlocks.MessageHandlers
{
    public interface IEventHandler<in TEvent> where TEvent : IEvent
    {
        Task HandleAsync(TEvent _event, ICorrelationContext context);
    }
}
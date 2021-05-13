using System.Threading.Tasks;
using BuildingBlocks.Messages;
using BuildingBlocks.RabbitMq;

namespace BuildingBlocks.MessageHandlers
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        Task HandleAsync(TCommand command, ICorrelationContext context);
    }
}
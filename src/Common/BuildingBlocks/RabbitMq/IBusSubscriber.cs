using System;
using BuildingBlocks.Messages;

namespace BuildingBlocks.RabbitMq
{
    public interface IBusSubscriber
    {
        IBusSubscriber SubscribeCommand<TCommand>(string _namespace = null)
            where TCommand : ICommand;

        IBusSubscriber SubscribeEvent<TEvent>(string _namespace = null)
            where TEvent : IEvent;
    }
}

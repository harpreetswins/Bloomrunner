using System;

namespace BuildingBlocks.RabbitMq
{
    public interface ICorrelationContext
    {
        Guid CorrelationId { get; }
        Guid CustomerId { get; }
    }
}
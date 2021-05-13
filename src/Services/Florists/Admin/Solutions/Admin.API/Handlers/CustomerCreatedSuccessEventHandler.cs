using Admin.API.Commands;
using Admin.API.Events;
using Admin.API.Infrastructure.CustomMapper;
using Admin.Application.Interfaces;
using Admin.Domain.Models.Admin;
using BuildingBlocks.MessageHandlers;
using BuildingBlocks.RabbitMq;
using RawRabbit.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.API.Handlers
{
    public class CustomerCreatedSuccessEventHandler : IEventHandler<Events.CustomerCreatedSuccessEvent>
    {
        IStaffService _staffService;
        public CustomerCreatedSuccessEventHandler(IStaffService staffService)
        {
            _staffService = staffService;
        }
        public async Task HandleAsync(Events.CustomerCreatedSuccessEvent _event, ICorrelationContext context)
        {
            await _staffService.SetStaffId(_event._Id, _event._StaffId);
        }
    }
}

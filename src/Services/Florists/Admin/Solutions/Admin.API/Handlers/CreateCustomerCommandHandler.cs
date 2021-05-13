using Admin.API.Commands;
using Admin.API.Events;
using Admin.API.Infrastructure.CustomMapper;
using Admin.Application.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
using BuildingBlocks.MessageHandlers;
using BuildingBlocks.RabbitMq;
using System.Threading.Tasks;

namespace Admin.API.Handlers
{
    public class CreateCustomerCommandHandler : ICommandHandler<CreateCustomerCommand>
    {
        public IBusPublisher _busPublisher;
        public IStaffService _staffService;

        public CreateCustomerCommandHandler(IBusPublisher busPublisher, IStaffService staffService)
        {
            _busPublisher = busPublisher;
            _staffService = staffService;
        }
        public async Task HandleAsync(CreateCustomerCommand command, ICorrelationContext context)
        {
            StaffModel model = new DTOMapper<CreateCustomerCommand, StaffModel>().Serialize(command);
            CommonResponse result = await _staffService.AddUser(model);
            if (result.KeyId>0)
            {
                await _busPublisher.PublishAsync(
               new CustomerCreatedAuthEvent(result.KeyId, command.FirstName, command.LastName, command.UserName, command.ProfileImage, command.Email, command.Password, command.Country, command.State,
               command.City, command.ZipCode, command.Street, command.Mobile, command.Dob)
               , context);
            }
        }
    }
}

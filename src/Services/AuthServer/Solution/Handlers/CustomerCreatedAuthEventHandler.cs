using Authentication.Events;
using AuthIdentityServer.Models;
using BuildingBlocks.MessageHandlers;
using BuildingBlocks.Messages;
using BuildingBlocks.RabbitMq;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace Authentication.Handlers
{
    [MessageNamespace("authqueue")]
    public class CustomerCreatedAuthEventHandler : IEventHandler<CustomerCreatedAuthEvent>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IBusPublisher _busPublisher;
        public CustomerCreatedAuthEventHandler(UserManager<ApplicationUser> userManager, IBusPublisher busPublisher)
        {
            _userManager = userManager;
            _busPublisher = busPublisher;
        }
        public async Task HandleAsync(CustomerCreatedAuthEvent _event, ICorrelationContext context)
        {
            var user = new ApplicationUser
            {
                FirstName = _event.FirstName,
                LastName = _event.LastName,
                UserName = _event.FirstName,
                Email = _event.Email,
                Country = _event.Country,
                State = _event.State,
                City = _event.City,
                ZipCode = _event.ZipCode,
                Street = _event.Street,
                ProfileImage = _event.ProfileImage
            };
            var result = await _userManager.CreateAsync(user, _event.Password);
            await _busPublisher.PublishAsync(new Events.CustomerCreatedSuccessEvent(new Guid(user.Id), _event.StaffId), context);
        }
    }
}

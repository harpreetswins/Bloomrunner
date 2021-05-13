using System;
using BuildingBlocks.RabbitMq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace Admin.API.Controllers
{
    public class BaseController : ControllerBase
    {
        private readonly IBusPublisher _busPublisher;
        private readonly UserManager<IdentityUser> _userManager;
        public BaseController(IBusPublisher busPublisher)
        {
            _busPublisher = busPublisher;
        }
        protected ICorrelationContext GetContext()
        {
            return GetContext(Guid.NewGuid());
        }
        //This method is only for AllowAnonymus CustomerController
        protected ICorrelationContext GetContext(Guid customerId)
        {
            return CorrelationContext.Create(Guid.NewGuid(), customerId);
        }
    }
}

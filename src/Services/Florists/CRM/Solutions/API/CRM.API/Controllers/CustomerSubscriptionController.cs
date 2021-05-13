using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Models;
using Microsoft.AspNetCore.Mvc;
namespace CRM.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]

    public class CustomerSubscriptionController : ControllerBase
    {
        private readonly ICustomerSubscriptionService _customerSubscriptionService;
        public CustomerSubscriptionController(ICustomerSubscriptionService customerSubscriptionService)
        {
            _customerSubscriptionService = customerSubscriptionService;
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] SearchCustomerSubscription searchCustomerSubscription)
        {
            var listCustomerSubscription = await _customerSubscriptionService.GetCustomerSubscription(searchCustomerSubscription);
            return Ok(listCustomerSubscription);
        }
    }
}
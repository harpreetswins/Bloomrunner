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
    public class UpcomingOrderController : ControllerBase
    {
        private readonly IUpcomingOrderService _upcomingOrderService;

        public UpcomingOrderController(IUpcomingOrderService upcomingOrderService)
        {
            _upcomingOrderService = upcomingOrderService;
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] SearchCustomerSummary searchCustomerSummary)
        {
            var listUpcomingOrders = await _upcomingOrderService.GetUpcomingOrders(searchCustomerSummary);
            return Ok(listUpcomingOrders);
        }
    }
}
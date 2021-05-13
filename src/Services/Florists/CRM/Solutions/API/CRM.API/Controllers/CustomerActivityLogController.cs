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
    public class CustomerActivityLogController : ControllerBase
    {
        private readonly ICustomerActivityLogService _customerActivityLogService;

        public CustomerActivityLogController(ICustomerActivityLogService customerActivityLogService)
        {
            _customerActivityLogService = customerActivityLogService;
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] SearchCustomerActivityLog searchCustomerActivityLog)
        {
            var listCustomerActivityLog = await _customerActivityLogService.GetCustomerActivityLog(searchCustomerActivityLog);
            return Ok(listCustomerActivityLog);
        }
    }
}
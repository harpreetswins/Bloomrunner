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
    public class CustomerSummaryController : ControllerBase
    {
        private readonly ICustomerSummaryService _customerSummaryService;
        public CustomerSummaryController(ICustomerSummaryService customerSummaryService)
        {
            _customerSummaryService = customerSummaryService;
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] SearchCustomerSummary searchCustomerSummary)
        {
            var listCustActivity = await _customerSummaryService.GetCustActivity(searchCustomerSummary);
            return Ok(listCustActivity);
        }
        [HttpGet("GetCustomerActivity")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> GetCustomerActivityCount([FromQuery] SearchCustomerActivityCountModel searchCustomerActivityCountModel)
        {
            var listCustActivity = await _customerSummaryService.GetCustomerActivityCount(searchCustomerActivityCountModel);
            return Ok(listCustActivity);
        }
        [HttpGet("GetCustomerAverageSpending")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> GetCustomerAverageSpending([FromQuery] SearchCustomerLTV searchCustomerLTV)
        {
            var listCustAverageSpending = await _customerSummaryService.GetCustomerAverageSpending(searchCustomerLTV);
            return Ok(listCustAverageSpending);
        }
    }
}
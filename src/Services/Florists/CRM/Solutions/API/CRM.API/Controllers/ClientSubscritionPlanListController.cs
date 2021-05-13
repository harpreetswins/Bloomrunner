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
    public class ClientSubscritionPlanListController : ControllerBase
    {
        private readonly ICRMSubscriptionPlanListService _iCRMSubscriptionPlanListService;

        public ClientSubscritionPlanListController(ICRMSubscriptionPlanListService iCRMSubscriptionPlanListService)
        {
            _iCRMSubscriptionPlanListService = iCRMSubscriptionPlanListService;
        }

        [HttpGet("GetCRMClientSubscritionPlanList")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] SearchSubscriptionPlanList searchSubscriptionPlanList)
        {
            var listClientSubscriptionPlan = await _iCRMSubscriptionPlanListService.GetSubscriptionPlanList(searchSubscriptionPlanList);
            return Ok(listClientSubscriptionPlan);
        }
    }
}
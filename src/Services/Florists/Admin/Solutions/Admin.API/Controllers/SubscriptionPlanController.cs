using System;
using System.Net;
using System.Threading.Tasks;
using Admin.Application.Interfaces;
using Admin.Domain.Models.Admin;
using Microsoft.AspNetCore.Mvc;

namespace Admin.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class SubscriptionPlanController : ControllerBase
    {
        private readonly ISubscriptionPanService _subscriptionPlanService;
        public SubscriptionPlanController(ISubscriptionPanService subscriptionPlanService)
        {
            this._subscriptionPlanService = subscriptionPlanService;
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get()
        {
            var list = await _subscriptionPlanService.GetSubscriptionPlanList();
            return Ok(list);
        }

        
    }
}
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
    public class FloristDashboardController : ControllerBase
    {
        private readonly IFloristDashboardService _iFloristDashboardService;
        public FloristDashboardController(IFloristDashboardService iFloristDashboardService)
        {
            _iFloristDashboardService = iFloristDashboardService;
        }

        [HttpGet("GetFloristRevenue")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] FloristDashboardSearchModel floristDashboardSearchModel)
        {
            var listloristDashboard = await _iFloristDashboardService.GetFloristRevenue(floristDashboardSearchModel);
            return Ok(listloristDashboard);
        }
        [HttpGet("GetFloristMonthlyStats")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] FloristMonthlyStatsSearchModel floristMonthlyStatsSearchModel)
        {
            var listFloristMonthlyStats = await _iFloristDashboardService.GetFloristMonthlyStats(floristMonthlyStatsSearchModel);
            return Ok(listFloristMonthlyStats);
        }
        [HttpGet("GetFloristCustomers")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] FloristCustomersSearchModel floristCustomersSearchModel)
        {
            var listFloristCustomers = await _iFloristDashboardService.GetFloristCustomers(floristCustomersSearchModel);
            return Ok(listFloristCustomers);
        }
    }
}
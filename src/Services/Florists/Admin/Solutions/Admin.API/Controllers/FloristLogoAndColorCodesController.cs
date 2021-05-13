using System.Net;
using System.Threading.Tasks;
using Admin.API.Infrastructure.CustomMapper;
using Admin.Application.DTO.Request;
using Admin.Application.Interfaces;
using Admin.Domain.Models.Admin;
using Microsoft.AspNetCore.Mvc;
namespace Admin.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class FloristLogoAndColorCodesController : ControllerBase
    {
        private readonly IFloristLogoAndColorCodesService _iFloristLogoAndColorCodesService;
        public FloristLogoAndColorCodesController(IFloristLogoAndColorCodesService iFloristLogoAndColorCodesService)
        {
            _iFloristLogoAndColorCodesService = iFloristLogoAndColorCodesService;

        }
        [HttpGet("Get")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> GetFloristLogoAndColorCodes([FromQuery] FloristLogoandColorSendModel floristLogoandColorSendModel)
        {
            var listColorCodes = await _iFloristLogoAndColorCodesService.FloristLogoAndColorCodes(floristLogoandColorSendModel);
            return Ok(listColorCodes);
        }      
    }
}

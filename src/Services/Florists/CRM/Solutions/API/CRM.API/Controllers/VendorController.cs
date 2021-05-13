using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRM.Application.Interfaces;
using CRM.Domain.Models;

namespace CRM.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendorService _vendorService;
        public VendorController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }

        [HttpGet("GetVendors")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] SearchVendor searchVendor)
        {
            var vendors = await _vendorService.GetVendors(searchVendor);
            return Ok(vendors);
        }
    }
}
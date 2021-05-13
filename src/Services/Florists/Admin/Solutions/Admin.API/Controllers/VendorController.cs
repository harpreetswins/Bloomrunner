using System.Net;
using System.Threading.Tasks;
using Admin.API.Infrastructure.CustomMapper;
using Admin.Application.DTO.Request;
using Admin.Domain.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Admin.Application.Services.Product;
using Admin.Application.Interfaces.Product;
namespace Admin.API.Controllers
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
        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] FloVendorId floVendorId)
        {
            var list = await _vendorService.GetVendorById(floVendorId);
            return Ok(list);
        }
        [HttpGet("GetVendordropdownlists")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] VendordropdownModel vendordropdownModel)
        {
            var list = await _vendorService.GetVendordropdownlist(vendordropdownModel);
            return Ok(list);
        }
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post([FromBody] VendorDTO model)
        {
            VendorModel vendor = new DTOMapper<VendorDTO, VendorModel>().Serialize(model);
            var response = await _vendorService.AddVendor(vendor);
            return Ok(response);
        }
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Put([FromBody] VendorUpdateDTO model)
        {
            VendorUpdateModel updatevendor = new DTOMapper<VendorUpdateDTO, VendorUpdateModel>().Serialize(model);
            var response = await _vendorService.UpdateVendor(updatevendor);
            return Ok(response);
        }
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Delete([FromQuery] VendorDeleteModel vendorDeleteModel)
        {
            var response = await _vendorService.DeleteVendor(vendorDeleteModel);
            return Ok(response);
        }
        [HttpPut("UpdateVendorStatus")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Put([FromBody] UpdateVendorStatus updateVendorStatus)
        {
            var response = await _vendorService.UpdateVendorStatus(updateVendorStatus);
            return Ok(response);
        }
    }
}
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
    // [Authorize]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;
        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;

        }
        [HttpGet("GetFlorists")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] GetFloristModel getFloristModel)
        {
            var list = await _adminService.GetFlorists(getFloristModel);
            return Ok(list);
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get()
        {
            var list = await _adminService.GetFlorists();
            return Ok(list);
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post([FromBody] AdminDTO model)
        {
            //var floristByMapper = _mapper.Map<FloristModel>(model);
            AdminModel florist = new DTOMapper<AdminDTO, AdminModel>().Serialize(model);
            //FloristOrderDTO floristDeserialize = new DTOMapper<FloristModel, FloristOrderDTO>().Deserialize(florist);
            int Id = await _adminService.AddFlorist(florist);
            return Ok(Id);
        }

        [HttpPut]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Put([FromBody] AdminUpdateDTO model)
        {
            AdminUpdateModel florist = new DTOMapper<AdminUpdateDTO, AdminUpdateModel>().Serialize(model);
            var response = await _adminService.UpdateFlorist(florist);
            return Ok(response);
        }
        [HttpGet("GetLocations")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] SearchLocation searchLocation)
        {
            var list = await _adminService.GetLocations(searchLocation);
            return Ok(list);            
        }
        [HttpGet("GetStates")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> GetStates()
        {
            var list = await _adminService.AsyncGetStateList();
            return Ok(list);
        }
        [HttpGet("GetTimeSlots")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> GetTimeSlots()
        {
            var list = await _adminService.GetTimingSlots();
            return Ok(list);            
        }

        [HttpGet("GetFloristTexRates")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery]GetFloristTexRateModel getFloristTexRateModel)
        {
            var GetFloristTexRatelist = await _adminService.GetFloristTexRate(getFloristTexRateModel);
            return Ok(GetFloristTexRatelist);
        }
    }
}

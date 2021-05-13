using System.Net;
using System.Threading.Tasks;
using Admin.API.Infrastructure.CustomMapper;
using Admin.Application.DTO.Request;
using Admin.Application.Interfaces;
using Admin.Domain.Models.Admin;
using Microsoft.AspNetCore.Mvc;
using Admin.API.Commands;
using BuildingBlocks.RabbitMq;
using System.Security.Claims;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

namespace Admin.API.Controllers
{
    [Authorize]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class StaffController : BaseController
    {
        public readonly IBusPublisher _busPublisher;
        private readonly IStaffService _staffService;
        private readonly IConfiguration _configuration;

        public StaffController(IStaffService staffService, IBusPublisher busPublisher, IConfiguration configuration) : base(busPublisher)
        {
            _staffService = staffService;
            _busPublisher = busPublisher;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] SearchGrid searchGrid)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var ids = identity.Claims.FirstOrDefault(d => d.Type.Contains("nameidentifier"))?.Value;
            var list = await _staffService.GetUsersAll(searchGrid);
            return Ok(list);
        }

        [HttpGet("GetPermissions")]
        public async Task<ActionResult> GetPermissions()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var AuthId = identity.Claims.FirstOrDefault(d => d.Type.Contains("nameidentifier"))?.Value;
            var list = await _staffService.GetPermissions(AuthId);
            return Ok(list);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete([FromQuery] StaffDeleteModel staffDeleteModel)
        {
            var StaffDelete = await _staffService.DeleteUser(staffDeleteModel);
            return Ok(StaffDelete);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] StaffUpdateDTO staffUpdateDTO)
        {
            StaffUpdateModel StaffUpdate = new DTOMapper<StaffUpdateDTO, StaffUpdateModel>().Serialize(staffUpdateDTO);
            int UpdateId = await _staffService.UpdateUser(StaffUpdate);
            return Ok();
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<IActionResult> Post(CreateCustomerCommand command)
        {
            var context = GetContext();
            await _busPublisher.SendAsync(command, context);
            return Accepted();
        }

        [HttpPatch]
        public async Task<ActionResult> Put(int StaffId,StaffUpdateStatusModel StaffUpdateStatusModel)
        {
            var StaffUpdateStatus = await _staffService.UpdateStaffUpdateStatus(StaffUpdateStatusModel);
            return Ok(StaffUpdateStatus);
        }

        [HttpGet("GetStaffs")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get(int StaffId, int AttributeType)
        {
            var list = await _staffService.GetUsers(StaffId,AttributeType);
            return Ok(list);
        }
    }
}
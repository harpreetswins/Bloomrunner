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
    public class RolesController : ControllerBase
    {
        private readonly IRolesService _rolesService;
        public RolesController(IRolesService rolesService)
        {
            this._rolesService = rolesService;
        }
        
        [HttpGet("{Floristid}")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get(int Floristid)
        {
            var list = await _rolesService.GetRolesList(Floristid);
            return Ok(list);
        }
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post([FromBody] RolesDTO model)
        {
            AddRolesModel role = new DTOMapper<RolesDTO, AddRolesModel>().Serialize(model);
            var roleid = await _rolesService.AddRoles(role);
            return Ok(roleid);
        }
    }
}
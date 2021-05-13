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
    public class RoleAndPermissionController : ControllerBase
    {
        private readonly IRoleAndPermissionService _roleAndPermissionService;
        public RoleAndPermissionController(IRoleAndPermissionService roleAndPermissionService)
        {
            _roleAndPermissionService = roleAndPermissionService;
        }
        [HttpGet()]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery]GetRoleAndPermission getRoleAndPermission)
        {
            var list = await _roleAndPermissionService.GetRoleAndPermissionList(getRoleAndPermission);
            return Ok(list);
        }
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post([FromBody] RoleAndPermissionDTO model)
        {
            AddRoleAndPermissionModel role = new DTOMapper<RoleAndPermissionDTO, AddRoleAndPermissionModel>().Serialize(model);
            var roleid = await _roleAndPermissionService.AddRoleAndPermission(role);
            return Ok(roleid);
        }
        [HttpPost("CloneRolesAndPermissions")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CloneRolesAndPermissions([FromBody] CloneRoleAndPermission model)
        {
            CloneRoleAndPermissionModel clonerole = new DTOMapper<CloneRoleAndPermission, CloneRoleAndPermissionModel>().Serialize(model);
            var clone = await _roleAndPermissionService.CloneRoleAndPermission(clonerole);
            return Ok(clone);
        }
        [HttpGet("GetScreenActions")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> GetScreenActions([FromQuery]SearchScreenActionModel searchScreenActionModel)
        {
            var list = await _roleAndPermissionService.GetScreenAction(searchScreenActionModel);
            return Ok(list);
        }
    }
}
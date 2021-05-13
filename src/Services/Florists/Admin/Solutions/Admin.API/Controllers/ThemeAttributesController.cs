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
    public class ThemeAttributesController : ControllerBase
    {
        private readonly IThemeAttributesService _iThemeAttributesService;
        public ThemeAttributesController(IThemeAttributesService iThemeAttributesService)
        {
            _iThemeAttributesService = iThemeAttributesService;

        }
        [HttpGet("Get")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] ThemeAttributesModel themeAttributesModel)
        {
            var listThemeAttributes = await _iThemeAttributesService.GetThemeAttributes(themeAttributesModel);
            return Ok(listThemeAttributes);
        }   
        [HttpPost("Post")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post([FromBody] ThemeAttributesDTO themeAttributesDTO)
        {
            ThemeAttributesSaveModel  SaveThemeAttributes = new DTOMapper<ThemeAttributesDTO, ThemeAttributesSaveModel>().Serialize(themeAttributesDTO);
            var ThemeAttributesId = await _iThemeAttributesService.AddFloristThemeAttributes(SaveThemeAttributes);
            return Ok(ThemeAttributesId);
        }  
        [HttpGet("GetTheme")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get()
        {
            var list = await _iThemeAttributesService.GetThemes();
            return Ok(list);
        }
        [HttpPost("FloristThemeAttributes")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post([FromBody] PostThemeAttributeDTO postThemeAttributeDTO)
        {
            PostThemeAttributeModel  FloristThemeAttributes = new DTOMapper<PostThemeAttributeDTO, PostThemeAttributeModel>().Serialize(postThemeAttributeDTO);
            var FloristThemeAttributesId = await _iThemeAttributesService.AddThemeAttributes(FloristThemeAttributes);
            return Ok(FloristThemeAttributesId);
        }  




        [HttpPost("ApplyFloristThemeAttributes")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post([FromBody] ApplyFloristThemeAttributeDTO applyFloristThemeAttributeDTO)
        {
            ApplyFloristThemeAttributeModel  ApplyFloristThemeAttributes = new DTOMapper<ApplyFloristThemeAttributeDTO, ApplyFloristThemeAttributeModel>().Serialize(applyFloristThemeAttributeDTO);
            var AppFloristThemeAttributesId = await _iThemeAttributesService.ApplyFloristThemeAttributes(ApplyFloristThemeAttributes);
            return Ok(AppFloristThemeAttributesId);
        }  

        
    }
}

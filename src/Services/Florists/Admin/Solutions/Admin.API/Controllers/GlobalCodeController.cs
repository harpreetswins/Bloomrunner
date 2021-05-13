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
    public class GlobalCodeController : ControllerBase
    {
        private readonly IGlobalCodeService _iGlobalCodeService;
        public GlobalCodeController(IGlobalCodeService iGlobalCodeService)
        {
            _iGlobalCodeService = iGlobalCodeService;

        }
        [HttpGet("GetGlobalCodeCategory")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> GetGlobalCategory()
        {
            var listGobalCodeCategories = await _iGlobalCodeService.GetGlobalCodeCategories();
            return Ok(listGobalCodeCategories);
        }
        [HttpGet("GetGlobalCode")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] GlobelSearchModel globelSearchModel)
        {
            var listGobalCode = await _iGlobalCodeService.GetGlobalCode(globelSearchModel);
            return Ok(listGobalCode);
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get()
        {
            var listGobalCodeAll = await _iGlobalCodeService.GetGlobalCode();
            return Ok(listGobalCodeAll);
        }
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post([FromBody] GlobalCodeDTO model)
        {
            GlobalCodeModel GlobalCodeScreen = new DTOMapper<GlobalCodeDTO, GlobalCodeModel>().Serialize(model);
            int HomeScreenId = await _iGlobalCodeService.AddGlobalCode(GlobalCodeScreen);
            return Ok(HomeScreenId);
        }
        [HttpDelete("Delete")]
        public async Task<ActionResult> Delete([FromQuery] GlobalCodeDeleteModel globalCodeDeleteModel)
        {
            var globalDelete = await _iGlobalCodeService.DeleteGlobalCode(globalCodeDeleteModel);
            return Ok(globalDelete);
        }
        [HttpGet("GetGlobalLists")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] GlobelcodeSearchListModel globelcodeSearchListModel)
        {
            var listGobalList = await _iGlobalCodeService.GetGlobalLists(globelcodeSearchListModel);
            return Ok(listGobalList);
        }       
        [HttpPut("UpdateGlobalCode")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)] 
        public async Task<IActionResult> Put([FromBody]GlobelcodeUpdateDTO globelcodeUpdateDTO)
        {
           GlobelcodeUpdateModel UpdateGlobalcode = new DTOMapper<GlobelcodeUpdateDTO, GlobelcodeUpdateModel>().Serialize(globelcodeUpdateDTO);         
           var GlobalcodeUpdate = await _iGlobalCodeService.UpdateGlobalCode(UpdateGlobalcode);
           return Ok(GlobalcodeUpdate);           
        }
        [HttpPut("SubcriptionUpdateStatus")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult> Put([FromBody] GlobelcodeUpdateStatusModel globelcodeUpdateStatusModel)
        {
            var SubcriptionOrderslist1 = await _iGlobalCodeService.GlobelcodeUpdateStatus(globelcodeUpdateStatusModel);
            return Ok(SubcriptionOrderslist1);
        }
    }
}
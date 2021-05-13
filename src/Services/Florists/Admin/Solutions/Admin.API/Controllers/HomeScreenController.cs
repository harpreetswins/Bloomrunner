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
    public class HomeScreenController : ControllerBase
    {
        private readonly IHomeScreenService _homeScreenService;
        public HomeScreenController(IHomeScreenService homeScreenService)
        {
            _homeScreenService = homeScreenService;
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get()
        {
            var listNote = await _homeScreenService.GetHomeScreen();
            return Ok(listNote);
        }
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post([FromBody] HomeScreenDTO model)
        {
            HomeScreenModel homeScreen = new DTOMapper<HomeScreenDTO, HomeScreenModel>().Serialize(model);
            int HomeScreenId = await _homeScreenService.AddHomeScreen(homeScreen);
            return Ok(HomeScreenId);
        }
        [HttpDelete("Delete")]
        public async Task<ActionResult> Delete([FromQuery] HomeScreenDeleteModel homeScreenDeleteModel)
        {
            var listDelete = await _homeScreenService.DeleteHomeScreen(homeScreenDeleteModel);
            return Ok(listDelete);
        }
    }
}
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
    public class TagController : ControllerBase
    {
        private readonly ITagService _tagService;
        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post([FromBody] TagDTO model)
        {
            TagModel tag = new DTOMapper<TagDTO, TagModel>().Serialize(model);
            var response = await _tagService.AddTags(tag);
            return Ok(response);
        }
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateTags([FromBody] TagUpdateDTO model)
        {
            TagUpdateModel Updatetag = new DTOMapper<TagUpdateDTO, TagUpdateModel>().Serialize(model);
            var response = await _tagService.UpdateTags(Updatetag);
            return Ok(response);
        }
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeleteTags([FromQuery] TagDeleteModel tagDeleteModel)
        {
            var response = await _tagService.DeleteTags(tagDeleteModel);
            return Ok(response);
        }
        [HttpPut("UpdateTagsStatus")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Put([FromBody] TagUpdateStatusModel tagUpdateStatusModel)
        {
            var response = await _tagService.UpdateStatusTags(tagUpdateStatusModel);
            return Ok(response);
        }
    }
}
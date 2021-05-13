using System;
using System.Threading.Tasks;
using Admin.Application.Interfaces;
using Admin.Domain.Models.Admin;
using Microsoft.AspNetCore.Mvc;

namespace Admin.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class TagCollectionController : ControllerBase
    {
        private readonly ITagCollectionService _tagCollectionService;
        public TagCollectionController(ITagCollectionService tagCollectionService)
        {
            _tagCollectionService = tagCollectionService;
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get()
        {
            var list = await _tagCollectionService.GetTagCollectionList();
            return Ok(list);
        }
        [HttpGet("{TagCollectionName}")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get(string TagCollectionName)
        {
            var list = await _tagCollectionService.GetTagCollectionList(TagCollectionName);
            return Ok(list);
        }
        [HttpGet("TagGridLists")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] TagGridListModel tagGridListModel)
        {
            var TagGridList = await _tagCollectionService.GetTagGridLists(tagGridListModel);
            return Ok(TagGridList);
        }
        [HttpGet("TagCollectionGridLists")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] TagCollectionGridModel tagCollectionGridModel)
        {
            var TagCollectionGridList = await _tagCollectionService.GetTagCollectionGridLists(tagCollectionGridModel);
            return Ok(TagCollectionGridList);
        }
    }
}
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Models;
using Microsoft.AspNetCore.Mvc;
namespace CRM.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class SearchProductsByTagsController : ControllerBase
    {
        private readonly ISearchProductsByTagService _iSearchProductsByTagsService;
        public SearchProductsByTagsController(ISearchProductsByTagService iSearchProductsByTagsService)
        {
            _iSearchProductsByTagsService = iSearchProductsByTagsService;
        }

        [HttpGet("GetlistSearchProductsByTags")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] SearchProductsByTagsSearchModel searchProductsByTagsSearchModel)
        {
            var listSearchProductsByTags = await _iSearchProductsByTagsService.GetSearchProductsByTags(searchProductsByTagsSearchModel);
            return Ok(listSearchProductsByTags);
        }
        [HttpGet]         
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] ProductCatalogModel productCatalogModel)
        {
            var listCatalogProducts = await _iSearchProductsByTagsService.GetCatalogProducts(productCatalogModel);
            return Ok(listCatalogProducts);
        }
    }
}
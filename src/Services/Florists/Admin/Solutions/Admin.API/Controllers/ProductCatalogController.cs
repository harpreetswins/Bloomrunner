using System;
using System.Net;
using System.Threading.Tasks;
using Admin.API.Infrastructure.CustomMapper;
using Admin.Application.DTO.Request;
using Admin.Application.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Product;
using Admin.Application.Interfaces.Product;
using Admin.Domain.Interfaces.Product;
using Admin.Domain.Models.Admin;
using Microsoft.AspNetCore.Mvc;
namespace Admin.API.Controllers
{
    [Route("api/v{version:apiVersion}/[Controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class ProductCatalogController : ControllerBase
    {
        private readonly IProductCatalogService _iProductCatalogService;

        public ProductCatalogController(IProductCatalogService iProductCatalogService)
        {
            _iProductCatalogService = iProductCatalogService;
        }

        [HttpGet("GetProductCatalog")]
        [MapToApiVersion("1.1")]

        public async Task<ActionResult> Get([FromQuery] SearchProductCatalogList searchProductCatalogList)
        {
            var listProductCatalogList = await _iProductCatalogService.GetProductCatalog(searchProductCatalogList);
            return Ok(listProductCatalogList);
        }

        [HttpPost("AddCatalogInfo")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post(AddProductCatalogDTO model)
        {
            AddProductCatalog productCatalog = new DTOMapper<AddProductCatalogDTO, AddProductCatalog>().Serialize(model);
            var Response = await _iProductCatalogService.AddProductCatalog(productCatalog);
            return Ok(Response);
        }

        [HttpDelete("DeleteCatalogInfo")]
        public async Task<ActionResult> Delete([FromQuery] DeleteProductCatalog deleteProductCatalog)
        {
            var CatalogDelete = await _iProductCatalogService.DeleteProductCatalog(deleteProductCatalog);
            return Ok(CatalogDelete);
        }

        [HttpPut("UpdateCatalogInfo")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Put([FromBody] UpdateProductCatalogDTO updateProductCatalogDTO)
        {
            UpdateProductCatalog productCatalogUpdate = new DTOMapper<UpdateProductCatalogDTO, UpdateProductCatalog>().Serialize(updateProductCatalogDTO);
            var updateCatalog = await _iProductCatalogService.UpdateProductCatalog(productCatalogUpdate);
            return Ok(updateCatalog);
        }
    }
}
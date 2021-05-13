using System.Net;
using System.Threading.Tasks;
using Admin.API.Infrastructure.CustomMapper;
using Admin.Application.DTO.Request;
using Admin.Domain.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Admin.Application.Services.Product;
using Admin.Application.Interfaces.Product;
using Admin.API.Infrastructure.Mappers.Admin;
using Admin.Application.DTO.Response;
using Newtonsoft.Json;

namespace Admin.API.Controllers
{

    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] FloProductId floProduct)
        {
            var list = await _productService.GetProducts(floProduct);
            return Ok(list);
        }
        [HttpGet("GetAddOnsProductlists")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] ProdcutSearch prodcutSearch)
        {
            var list = await _productService.GetProductAddOnslists(prodcutSearch);
            return Ok(list);
        }
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post([FromBody] ProductDTO model)
        {
            ProductModel product = new DTOMapper<ProductDTO, ProductModel>().Serialize(model);
            var Response = await _productService.AddProduct(product);
            return Ok(Response);
        }
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateProductStatus([FromBody] UpdateProduct updateProduct)
        {
            int Id = await _productService.UpdateProductStatus(updateProduct);
            return Ok(Id);
        }
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Delete([FromQuery] DeleteProduct deleteProduct)
        {
            int Id = await _productService.DeleteProduct(deleteProduct);
            return Ok(Id);
        }
        [HttpGet("ProductGridlists")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] SearchProductGrid searchProductGrid)
        {
            var list = await _productService.GetProductGridlists(searchProductGrid);
            return Ok(list);
        }
        [HttpGet("ProductNameExists")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] CheckProductNameModel checkProductNameModel)
        {
            var list = await _productService.CheckProductExist(checkProductNameModel);
            return Ok(list);
        }
    }
}
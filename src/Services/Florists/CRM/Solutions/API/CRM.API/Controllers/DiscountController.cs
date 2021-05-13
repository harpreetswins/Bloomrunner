using System.Net;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using CRM.Application.DTO.Request;
using CRM.API.Infrastructure.CustomMapper;
namespace CRM.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] SearchDiscountModel searchDiscountModel)
        {
            var listDiscount = await _discountService.GetDiscounts(searchDiscountModel);
            return Ok(listDiscount);
        }
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post(DiscountDTO model)
        {
            DiscountModel discount = new DTOMapper<DiscountDTO, DiscountModel>().Serialize(model);
            var Response = await _discountService.AddDiscounts(discount);
            return Ok(Response);
        }
        [HttpGet("DiscountGridList")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] DiscountGridModel discountGridModel)
        {
            var listDiscountGrid = await _discountService.GetDiscountGridLists(discountGridModel);
            return Ok(listDiscountGrid);
        }
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Delete(DiscountDeleteModel model)
        {
            var Response = await _discountService.DeleteDiscounts(model);
            return Ok(Response);
        }
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Put(DiscountUpdateDTO model)
        {
            DiscountUpdateModel updatediscount = new DTOMapper<DiscountUpdateDTO, DiscountUpdateModel>().Serialize(model);
            var Response = await _discountService.UpdateDiscounts(updatediscount);
            return Ok(Response);
        }
        [HttpPut("UpdateDiscountStatus")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Put(DiscountUpdateStatusModel model)
        {
            var Response = await _discountService.UpdateDiscountStatus(model);
            return Ok(Response);
        }
    }
}
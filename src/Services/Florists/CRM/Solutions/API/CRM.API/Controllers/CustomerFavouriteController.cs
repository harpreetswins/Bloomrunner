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
    public class CustomerFavouriteController : ControllerBase
    {
        private readonly ICustomerFavouriteService _customerFavouriteService;
        public CustomerFavouriteController(ICustomerFavouriteService customerFavouriteService)
        {
            _customerFavouriteService = customerFavouriteService;
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] SearchCustomerSummary searchCustomerSummary)
        {
            var listCustomerFavourite = await _customerFavouriteService.GetCustomerFavourites(searchCustomerSummary);
            return Ok(listCustomerFavourite);
        }
    }
}
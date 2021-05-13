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
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _iCustomerService;
        public CustomerController(ICustomerService iCustomerService)
        {
            _iCustomerService = iCustomerService;
        }

        [HttpGet("GetCustomer")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] CustomerSearchModel customerSearchModel)
        {
            var listCustomer = await _iCustomerService.GetCustomers(customerSearchModel);
            return Ok(listCustomer);
        }
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post(CustomerDTO model)
        {
            CustomerModel CustomerScreen = new DTOMapper<CustomerDTO, CustomerModel>().Serialize(model);
            var Response = await _iCustomerService.AddCustomers(CustomerScreen);
            return Ok(Response);
        }
        [HttpDelete("Delete")]
        public async Task<ActionResult> Delete([FromQuery] CustomerDeleteModel customerDeleteModel)
        {
            var CustomerDelete = await _iCustomerService.DeleteCustomers(customerDeleteModel);
            return Ok(CustomerDelete);
        }
        [HttpPut]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Put([FromBody] CustomerUpdateDTO customerUpdateDTO)
        {
            CustomerUpdateModel StaffUpdate = new DTOMapper<CustomerUpdateDTO, CustomerUpdateModel>().Serialize(customerUpdateDTO);
            int UpdateId = await _iCustomerService.UpdateCustomers(StaffUpdate);
            return Ok(UpdateId);
        }
        [HttpPut("CustomerUpdateStatus")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Put([FromBody] CustomerUpdateStatusDTO customerUpdateStatusDTO)
        {
            CustomerUpdateStatusModel CustomerUpdateStatus = new DTOMapper<CustomerUpdateStatusDTO, CustomerUpdateStatusModel>().Serialize(customerUpdateStatusDTO);
            int CustomerUpdateStatusId = await _iCustomerService.CustomersUpdateStatus(CustomerUpdateStatus);
            return Ok(CustomerUpdateStatusId);
        }
    }
}
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
    public class CustomerSubscriptionPlanController : ControllerBase
    {
        private readonly ICustomerSubscriptionPlanService _customerSubscriptionPlanService;
        public CustomerSubscriptionPlanController(ICustomerSubscriptionPlanService customerSubscriptionPlanService)
        {
            _customerSubscriptionPlanService = customerSubscriptionPlanService;
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] SearchCustomerSubscriptionPlan searchCustomerSubscriptionPlan)
        {
            var listCustomerSubscriptionPlan = await _customerSubscriptionPlanService.GetCustomerSubscriptionPlan(searchCustomerSubscriptionPlan);
            return Ok(listCustomerSubscriptionPlan);
        }
        [HttpPost("Save")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post(CustomerSubscriptionPlanDTO customerSubscriptionPlanDTO)
        {
            AddCustomerSubscriptionPlanModel SubscriptionPlan = new DTOMapper<CustomerSubscriptionPlanDTO, AddCustomerSubscriptionPlanModel>().Serialize(customerSubscriptionPlanDTO);
            var Response = await _customerSubscriptionPlanService.AddSubscriptionPlans(SubscriptionPlan);
            return Ok(Response);
        }
        [HttpPut("Update")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Put([FromBody] UpdateCustomerSubscriptionPlanDTO updateCustomerSubscriptionPlanDTO)
        {
            UpdateCustomerSubcriptionPlanModel UpdateCustomerSubcriptionPlan = new DTOMapper<UpdateCustomerSubscriptionPlanDTO, UpdateCustomerSubcriptionPlanModel>().Serialize(updateCustomerSubscriptionPlanDTO);
            var UpdateCustomerId = await _customerSubscriptionPlanService.UpdateSubscriptionPlans(UpdateCustomerSubcriptionPlan);
            return Ok(UpdateCustomerId);
        }
        [HttpDelete("Delete")]
        public async Task<ActionResult> Delete([FromQuery] DeleteCustomerSubcriptionPlanModel deleteCustomerSubcriptionPlanModel)
        {
            var DeleteSubscriptionPlans = await _customerSubscriptionPlanService.DeleteSubscriptionPlans(deleteCustomerSubcriptionPlanModel);
            return Ok(DeleteSubscriptionPlans);
        }
        [HttpGet("CustomerSubscriptionPlanLists")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] CustomerSubscriptionPlanListModel customerSubscriptionPlanListModel)
        {
            var listCustomerSubscriptionPlanList = await _customerSubscriptionPlanService.GetCustomerSubscriptionPlanLists(customerSubscriptionPlanListModel);
            return Ok(listCustomerSubscriptionPlanList);
        }
        [HttpPut("SubscriptionPlansUpdateStatus")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Put([FromBody] CustomerSubscriptionPlansUpdateStatusDTO customerSubscriptionPlansUpdateStatusDTO)
        {
            CustomerSubscriptionPlansUpdateStatusModel subscriptionPlansUpdateStatus = new DTOMapper<CustomerSubscriptionPlansUpdateStatusDTO, CustomerSubscriptionPlansUpdateStatusModel>().Serialize(customerSubscriptionPlansUpdateStatusDTO);
            int PlansUpdateStatusId = await _customerSubscriptionPlanService.SubscriptionPlansUpdateStatus(subscriptionPlansUpdateStatus);
            return Ok(PlansUpdateStatusId);
        }
        [HttpGet("CustomerSubscriptionPlanSearchId")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] CustomerSubscriptionPlansByIdModel customerSubscriptionPlansByIdModel)
        {
            var listCustomerSubscriptionPlanbyId = await _customerSubscriptionPlanService.GetCustomerSubscriptionPlanbyId(customerSubscriptionPlansByIdModel);
            return Ok(listCustomerSubscriptionPlanbyId);
        }
    }
}
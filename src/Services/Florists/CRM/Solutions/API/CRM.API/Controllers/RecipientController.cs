using System.Net;
using System.Threading.Tasks;
using CRM.API.Infrastructure.CustomMapper;
using CRM.Application.DTO.Request;
using CRM.Application.Interfaces;
using CRM.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class RecipientController : ControllerBase
    {
        private readonly IRecipientService _recipientService;
        public RecipientController(IRecipientService recipientService)
        {
            _recipientService = recipientService;
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] SearchRecipient searchRecipient)
        {
            var list = await _recipientService.GetRecipients(searchRecipient);
            return Ok(list);
        }
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post(RecipientDTO model)
        {
            RecipientModel recipient = new DTOMapper<RecipientDTO, RecipientModel>().Serialize(model);
            var Response = await _recipientService.AddRecipients(recipient);
            return Ok(Response);
        }
        [HttpDelete("Delete")]
        public async Task<ActionResult> Delete([FromQuery] RecipientDeleteModel recipientDeleteModel)
        {
            var RecipientDelete = await _recipientService.DeleteRecipients(recipientDeleteModel);
            return Ok(RecipientDelete);
        }
        [HttpPut]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Put([FromBody] RecipientUpdateDTO recipientUpdateDTO)
        {
            RecipientUpdateModel RecipientUpdate = new DTOMapper<RecipientUpdateDTO, RecipientUpdateModel>().Serialize(recipientUpdateDTO);
            int UpdateId = await _recipientService.UpdateRecipients(RecipientUpdate);
            return Ok();
        }
        [HttpGet("RecipientsOrder")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] RecipientOrderSerchModel recipientOrderSerchModel)
        {
            var list = await _recipientService.GetRecipientsOrder(recipientOrderSerchModel);
            return Ok(list);
        }
        [HttpPut("RecipientUpdateStatus")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Put([FromBody] RecipientUpdateStatusDTO recipientUpdateStatusDTO)
        {
            RecipientUpdateStatusModel RecipientUpdateStatus = new DTOMapper<RecipientUpdateStatusDTO, RecipientUpdateStatusModel>().Serialize(recipientUpdateStatusDTO);
            int RecipientUpdateStatusId = await _recipientService.RecipientsUpdateStatus(RecipientUpdateStatus);
            return Ok(RecipientUpdateStatusId);
        }
        [HttpGet("RecipientUpcommingOrderslists")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] RecipientUpcommingOrderModel recipientUpcommingOrderModel)
        {
            var RecipientUpcommingOrderslist = await _recipientService.GetRecipientUpcommingOrders(recipientUpcommingOrderModel);
            return Ok(RecipientUpcommingOrderslist);
        }
    }
}
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
    public class CRMRecipientController : ControllerBase
    {
        private readonly ICRMRecipientService _iCRMRecipientService;
        public CRMRecipientController(ICRMRecipientService iCRMRecipientService)
        {
            _iCRMRecipientService = iCRMRecipientService;
        }

        [HttpGet("GetCRMRecipient")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] CRMRecipientSearchModel cRMRecipientSearchModel)
        {
            var listCRMRecipient = await _iCRMRecipientService.GetCRMRecipient(cRMRecipientSearchModel);
            return Ok(listCRMRecipient);
        }
        [HttpGet("GetCRMRecipientList")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] CRMRecipientListSearchModel cRMRecipientListSearchModel)
        {
            var listCRMRecipient = await _iCRMRecipientService.GetCRMRecipientList(cRMRecipientListSearchModel);
            return Ok(listCRMRecipient);
        }
    }
}
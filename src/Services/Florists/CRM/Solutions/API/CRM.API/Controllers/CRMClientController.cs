using System;
using System.Net;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Application.Services;
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
    public class CRMClientController : ControllerBase
    {
        private readonly ICRMClientService _iCRMClientService;
        public CRMClientController(ICRMClientService iCRMClientService)
        {
            _iCRMClientService = iCRMClientService;
        }

        [HttpGet("GetCRMClient")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] CRMClientSearchModel cRMClientSearchModel)
        {
            var listCRMClient = await _iCRMClientService.GetCRMClient(cRMClientSearchModel);
            return Ok(listCRMClient);
        }
        [HttpGet("GetCRMClientList")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] CRMClientListSearchModel cRMClientListSearchModel)
        {
            var listCRMClient = await _iCRMClientService.GetCRMClientList(cRMClientListSearchModel);
            return Ok(listCRMClient);
        }
    }
}
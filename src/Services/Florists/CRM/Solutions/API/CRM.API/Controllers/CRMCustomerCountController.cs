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
    public class CRMCustomerCountController : ControllerBase
    {
        private readonly ICRMCustomerCountService _iCRMCustomerCountService;
        public CRMCustomerCountController(ICRMCustomerCountService iCRMCustomerCountService)
        {
            _iCRMCustomerCountService = iCRMCustomerCountService;
        }

        [HttpGet("GetCRMCustomerCount")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] CRMCustomerCountSearchModel cRMCustomerCountSearchModel)
        {
            var listCRMCustomerCount = await _iCRMCustomerCountService.GetCRMCustomerCount(cRMCustomerCountSearchModel);
            return Ok(listCRMCustomerCount);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bloomrunner.Orders.Application.Interfaces;
using Bloomrunner.Orders.Domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Orders.Api.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        public async Task<IEnumerable<Order>> Get()
        {
            return await _orderService.GetOrders();
        }

    }
}

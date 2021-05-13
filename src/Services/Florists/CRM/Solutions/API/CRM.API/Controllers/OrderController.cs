using System.Net;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using CRM.Application.DTO.Request;
using CRM.API.Infrastructure.CustomMapper;
using Microsoft.Extensions.Options;
using CRM.Domain.Models.SendGrid;
using CRM.API.Infrastructure.EmailSender;

namespace CRM.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IOptions<EmailCredientials> Credientials;
        public OrderController(IOrderService orderService, IOptions<EmailCredientials> _credientials)
        {
            _orderService = orderService;
            Credientials = _credientials;
        }

        [HttpGet("GetOrders")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] OrderCountSearch orderCountSearch)
        {
            var list = await _orderService.GetOrders(orderCountSearch);
            return Ok(list);
        }
        [HttpGet("{Days}")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get(int Days)
        {
            var list = await _orderService.GetOrderCount(Days);
            return Ok(list);
        }
        [HttpGet("GetScheduledOrders")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] SearchScheduledOrder searchScheduledOrder)
        {
            var list = await _orderService.GetScheduledOrderCount(searchScheduledOrder);
            return Ok(list);
        }
        [HttpGet("GetOrderSummeries")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> Get([FromQuery] SearchOrderSummery searchOrderSummery)
        {
            var list = await _orderService.GetOrderSummeries(searchOrderSummery);
            return Ok(list);
        }
        [HttpGet("GetOrdersList")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> GetCustomerRecipientOrdersList([FromQuery] SearchCustomerRecipientOrderList searchCustomerRecipientOrderList)
        {
            var list = await _orderService.GetCustomerRecipientOrdersList(searchCustomerRecipientOrderList);
            return Ok(list);
        }
        [HttpPost("AddOrder")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post(OrderDTO model)
        {
            CreateOrderModel NewCreateOrder = new DTOMapper<OrderDTO, CreateOrderModel>().Serialize(model);
            var OrderResponse = await _orderService.AddOrders(NewCreateOrder);

            IEmailNotification<OrderPlaced> emailNotification = new EmailNotifaction<OrderPlaced>(Credientials);

            await emailNotification.Send(
                new OrderPlaced() { tutorname = OrderResponse.Name, ordernumber = OrderResponse.KeyId },
                OrderResponse.Email,
                "OrderPlaced",
                "OrderPlaced");
            return Ok(OrderResponse);
        }
        [HttpPut("ChangeOrderStatus")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Put([FromBody] ChangeOrderstatusDTO changeOrderstatusDTO)
        {
            ChangeOrderstatusModel ChangeOrder = new DTOMapper<ChangeOrderstatusDTO, ChangeOrderstatusModel>().Serialize(changeOrderstatusDTO);
            var ChangeOrderId = await _orderService.ChangeOrderStatus(ChangeOrder);

            IEmailNotification<OrderStatus> emailNotification = new EmailNotifaction<OrderStatus>(Credientials);

            await emailNotification.Send(
                new OrderStatus() { tutorname = ChangeOrderId.Name, ordernumber = ChangeOrderId.KeyId, orderstatus = ChangeOrderId.OrderStatus, color = "green" },
                ChangeOrderId.Email,
                "OrderStatus",
                "OrderStatus");
            return Ok(ChangeOrderId);
        }
        [HttpGet("GetDiscountOnOrderTotal")]
        [MapToApiVersion("1.1")]
        public async Task<ActionResult> GetDiscountOnOrderTotal([FromQuery] DiscountOrderTotalModel discountOrderTotalModel)
        {
            var DiscountOrderTotalResponse = await _orderService.GetDiscountOnOrderTotal(discountOrderTotalModel);
            return Ok(DiscountOrderTotalResponse);
        }
        [HttpPut("UpdateOrder")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Put([FromBody] UpdateOrderDTO updateOrderDTO)
        {
            UpdateOrderModel UpdateCreateOrder = new DTOMapper<UpdateOrderDTO, UpdateOrderModel>().Serialize(updateOrderDTO);
            var OrderUpdateResponse = await _orderService.UpdateOrders(UpdateCreateOrder);
            return Ok(OrderUpdateResponse);
        }
    }
}
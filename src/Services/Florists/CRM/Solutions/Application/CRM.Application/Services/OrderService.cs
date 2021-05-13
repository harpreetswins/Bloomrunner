using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }
        public async Task<IEnumerable<OrderCountModels>> GetOrders(OrderCountSearch orderCountSearch)
        {
            return await _orderRepository.GetOrders(orderCountSearch);
        }
        public async Task<IEnumerable<OrderModels>> GetOrderCount(int Days)
        {
            return await _orderRepository.GetOrderCount(Days);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchScheduledOrder"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ScheduledOrderCount>> GetScheduledOrderCount(SearchScheduledOrder searchScheduledOrder)
        {
            return await _orderRepository.GetScheduledOrderCount(searchScheduledOrder);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchOrderSummery"></param>
        /// <returns></returns>
        public async Task<IEnumerable<OrderSummeryModel>> GetOrderSummeries(SearchOrderSummery searchOrderSummery)
        {
            return await _orderRepository.GetOrderSummeries(searchOrderSummery);
        }
        public async Task<IEnumerable<CustomerRecipientOrderListModel>> GetCustomerRecipientOrdersList(SearchCustomerRecipientOrderList searchCustomerRecipientOrderList)
        {
            return await _orderRepository.GetCustomerRecipientOrdersList(searchCustomerRecipientOrderList);
        }
        public async Task<IEnumerable<SearchOrderListModel>> GetSearchOrdersList(SearchOrderList searchOrderList)
        {
            return await _orderRepository.GetSearchOrdersList(searchOrderList);
        }
        public async Task<CommonResponseOrder> AddOrders(CreateOrderModel createOrderModel)
        {
            return await _orderRepository.AddOrders(createOrderModel);
        }
        public async Task<CommonResponseOrder> ChangeOrderStatus(ChangeOrderstatusModel changeOrderstatusModel)
        {
            return await _orderRepository.ChangeOrderStatus(changeOrderstatusModel);
        }
        public async Task<DiscountOrderResponse> GetDiscountOnOrderTotal(DiscountOrderTotalModel discountOrderTotalModel)
        {
            return await _orderRepository.GetDiscountOnOrderTotal(discountOrderTotalModel);
        }
        public async Task<CommonResponseOrder> UpdateOrders(UpdateOrderModel updateOrderModel)
        {
            return await _orderRepository.UpdateOrders(updateOrderModel);
        }
    }
}
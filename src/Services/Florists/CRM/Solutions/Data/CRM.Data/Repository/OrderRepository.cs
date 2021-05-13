using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class OrderRepository : GenericRepository, IOrderRepository
    {
        public OrderRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<OrderCountModels>> GetOrders(OrderCountSearch OrderCountSearch)
        {
            return await Query<OrderCountModels>("Crm.GetOrders", OrderCountSearch);
        }
        public async Task<IEnumerable<OrderModels>> GetOrderCount(int DaysId)
        {
            return await Query<OrderModels>("Crm.GetOrderCountInOrderStatus", new { Days = DaysId });
        }
        public async Task<IEnumerable<ScheduledOrderCount>> GetScheduledOrderCount(SearchScheduledOrder searchScheduledOrder)
        {
            return await Query<ScheduledOrderCount>("Crm.GetOrderCountInTimeSlots", searchScheduledOrder);
        }
        public async Task<IEnumerable<OrderSummeryModel>> GetOrderSummeries(SearchOrderSummery searchOrderSummery)
        {
            return await Query<OrderSummeryModel>("Crm.GetOrderSummary", searchOrderSummery);
        }
        public async Task<IEnumerable<CustomerRecipientOrderListModel>> GetCustomerRecipientOrdersList(SearchCustomerRecipientOrderList searchCustomerRecipientOrderList)
        {
            return await Query<CustomerRecipientOrderListModel>("Crm.GetOrdersList", searchCustomerRecipientOrderList);
        }
        public async Task<IEnumerable<SearchOrderListModel>> GetSearchOrdersList(SearchOrderList searchOrderList)
        {
            return await Query<SearchOrderListModel>("Crm.GetOrdersListSearching", searchOrderList);
        }
        public async Task<CommonResponseOrder> AddOrders(CreateOrderModel createOrderModel)
        {
            return await ExecuteAll<CommonResponseOrder>("Crm.CreateOrders", createOrderModel);
        }
        public async Task<CommonResponseOrder> ChangeOrderStatus(ChangeOrderstatusModel changeOrderstatusModel)
        {
            return await ExecuteAll<CommonResponseOrder>("Crm.OrderStatusChange", changeOrderstatusModel);
        }
        public async Task<DiscountOrderResponse> GetDiscountOnOrderTotal(DiscountOrderTotalModel discountOrderTotalModel)
        {
            return await ExecuteAll<DiscountOrderResponse>("Crm.GetDiscountOnOrderTotal", discountOrderTotalModel);
        }
        public async Task<CommonResponseOrder> UpdateOrders(UpdateOrderModel updateOrderModel)
        {
            return await ExecuteAll<CommonResponseOrder>("Crm.UpdateOrders", updateOrderModel);
        }
    }
}
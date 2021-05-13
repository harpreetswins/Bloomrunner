using CRM.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM.Application.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderCountModels>> GetOrders(OrderCountSearch orderCountSearch);
        Task<IEnumerable<OrderModels>> GetOrderCount(int Days);
        Task<IEnumerable<ScheduledOrderCount>> GetScheduledOrderCount(SearchScheduledOrder searchScheduledOrder);
        Task<IEnumerable<OrderSummeryModel>> GetOrderSummeries(SearchOrderSummery searchOrderSummery);
        Task<IEnumerable<CustomerRecipientOrderListModel>> GetCustomerRecipientOrdersList(SearchCustomerRecipientOrderList searchCustomerRecipientOrderList);
        Task<CommonResponseOrder> AddOrders(CreateOrderModel createOrderModel);
        Task<CommonResponseOrder> ChangeOrderStatus(ChangeOrderstatusModel changeOrderstatusModel);
        Task<DiscountOrderResponse> GetDiscountOnOrderTotal(DiscountOrderTotalModel discountOrderTotalModel);
        Task<IEnumerable<SearchOrderListModel>> GetSearchOrdersList(SearchOrderList searchOrderList);
        Task<CommonResponseOrder> UpdateOrders(UpdateOrderModel updateOrderModel);
    }
}
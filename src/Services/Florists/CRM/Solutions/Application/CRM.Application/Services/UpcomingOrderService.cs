using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class UpcomingOrderService : IUpcomingOrderService
    {
        private readonly IUpcomingOrderRepository _upcomingOrderRepository;
        public UpcomingOrderService(IUpcomingOrderRepository upcomingOrderRepository)
        {
            _upcomingOrderRepository = upcomingOrderRepository;
        }
        public async Task<IEnumerable<UpcomingOrderModel>> GetUpcomingOrders(SearchCustomerSummary searchCustomerSummary)
        {
            return await _upcomingOrderRepository.GetUpcomingOrders(searchCustomerSummary);
        }
    }
}
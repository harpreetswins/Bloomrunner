using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class UpcomingOrderRepository : GenericRepository, IUpcomingOrderRepository
    {
        public UpcomingOrderRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<UpcomingOrderModel>> GetUpcomingOrders(SearchCustomerSummary searchCustomerSummary)
        {
            return await Query<UpcomingOrderModel>("Crm.GetUpcomingOrders", searchCustomerSummary);
        }
    }
}
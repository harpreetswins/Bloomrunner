using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;

namespace CRM.Domain.Interfaces
{
    public interface IUpcomingOrderRepository
    {
         Task<IEnumerable<UpcomingOrderModel>> GetUpcomingOrders(SearchCustomerSummary searchCustomerSummary);
    }
}
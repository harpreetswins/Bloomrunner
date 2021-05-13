using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;

namespace CRM.Application.Interfaces
{
    public interface IUpcomingOrderService
    {
        Task<IEnumerable<UpcomingOrderModel>> GetUpcomingOrders(SearchCustomerSummary searchCustomerSummary);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;

namespace CRM.Domain.Interfaces
{
    public interface ICustomerActivityLogRepository
    {
        Task<IEnumerable<CustomerActivityLogDerivedModel>> GetCustomerActivityLog(SearchCustomerActivityLog searchCustomerActivityLog);     
    }
}
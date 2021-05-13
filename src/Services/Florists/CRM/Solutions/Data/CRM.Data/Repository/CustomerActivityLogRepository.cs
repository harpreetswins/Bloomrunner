using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class CustomerActivityLogRepository : GenericRepository, ICustomerActivityLogRepository
    {
        public CustomerActivityLogRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<CustomerActivityLogDerivedModel>> GetCustomerActivityLog(SearchCustomerActivityLog searchCustomerActivityLog)
        {
            return await Query<CustomerActivityLogDerivedModel>("Crm.GetCustomerActivityLog", searchCustomerActivityLog);
        }
    }
}
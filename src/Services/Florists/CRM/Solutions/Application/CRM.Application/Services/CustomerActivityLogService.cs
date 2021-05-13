using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class CustomerActivityLogService : ICustomerActivityLogService
    {
        private readonly ICustomerActivityLogRepository _customerActivityLogRepository;
        public CustomerActivityLogService(ICustomerActivityLogRepository customerActivityLogRepository)
        {
            _customerActivityLogRepository = customerActivityLogRepository;
        }

        public async Task<IEnumerable<CustomerActivityLogDerivedModel>> GetCustomerActivityLog(SearchCustomerActivityLog searchCustomerActivityLog)
        {
            return await _customerActivityLogRepository.GetCustomerActivityLog(searchCustomerActivityLog);
        }
    }
}
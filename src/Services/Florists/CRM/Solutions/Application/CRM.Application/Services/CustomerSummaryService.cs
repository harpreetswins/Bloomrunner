using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class CustomerSummaryService : ICustomerSummaryService
    {
        private readonly ICustomerSummaryRepository _customerSummaryRepository;
        public CustomerSummaryService(ICustomerSummaryRepository customerSummaryRepository)
        {
            _customerSummaryRepository = customerSummaryRepository;
        }
        public async Task<IEnumerable<CustomerSummaryResponse>> GetCustActivity(SearchCustomerSummary searchCustomerSummary)
        {
            return await _customerSummaryRepository.GetCustActivity(searchCustomerSummary);
        }
        public async Task<IEnumerable<CustomerActivityCountModel>> GetCustomerActivityCount(SearchCustomerActivityCountModel searchCustomerActivityCountModel)
        {
            return await _customerSummaryRepository.GetCustomerActivityCount(searchCustomerActivityCountModel);
        }
        public async Task<IEnumerable<CustomerLifeTimeModel>> GetCustomerAverageSpending(SearchCustomerLTV searchCustomerLTV)
        {
            return await _customerSummaryRepository.GetCustomerAverageSpending(searchCustomerLTV);
        }
    }
}
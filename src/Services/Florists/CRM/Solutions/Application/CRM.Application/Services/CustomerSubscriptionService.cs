using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class CustomerSubscriptionService : ICustomerSubscriptionService
    {
        private readonly ICustomerSubscriptionRepository _customerSubscriptionRepository;
        public CustomerSubscriptionService(ICustomerSubscriptionRepository customerSubscriptionRepository)
        {
            _customerSubscriptionRepository = customerSubscriptionRepository;
        }
        public async Task<IEnumerable<CustomerSubscriptionDerivedModel>> GetCustomerSubscription(SearchCustomerSubscription searchCustomerSubscription)
        {
            return await _customerSubscriptionRepository.GetCustomerSubscription(searchCustomerSubscription);
        }
    }
}
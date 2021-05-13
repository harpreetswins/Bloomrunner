using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class CustomerSubscriptionRepository : GenericRepository, ICustomerSubscriptionRepository
    {
        public CustomerSubscriptionRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<CustomerSubscriptionDerivedModel>> GetCustomerSubscription(SearchCustomerSubscription searchCustomerSubscription)
        {
            return await Query<CustomerSubscriptionDerivedModel>("Crm.GetCustomerSubscriptions", searchCustomerSubscription);
        }
    }
}
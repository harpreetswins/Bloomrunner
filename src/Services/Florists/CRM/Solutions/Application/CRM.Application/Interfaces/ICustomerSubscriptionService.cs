using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;

namespace CRM.Application.Interfaces
{
    public interface ICustomerSubscriptionService
    {
        Task<IEnumerable<CustomerSubscriptionDerivedModel>> GetCustomerSubscription(SearchCustomerSubscription searchCustomerSubscription);
    }
}
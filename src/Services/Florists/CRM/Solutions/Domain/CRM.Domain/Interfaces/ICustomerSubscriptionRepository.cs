using System;
using CRM.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CRM.Domain.Interfaces
{
    public interface ICustomerSubscriptionRepository
    {
          Task<IEnumerable<CustomerSubscriptionDerivedModel>> GetCustomerSubscription(SearchCustomerSubscription searchCustomerSubscription); 
    }
}
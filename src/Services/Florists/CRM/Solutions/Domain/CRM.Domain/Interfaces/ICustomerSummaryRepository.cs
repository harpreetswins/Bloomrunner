using System;
using CRM.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM.Domain.Interfaces
{
    public interface ICustomerSummaryRepository
    {
        Task<IEnumerable<CustomerSummaryResponse>> GetCustActivity(SearchCustomerSummary searchCustomerSummary);
        Task<IEnumerable<CustomerActivityCountModel>> GetCustomerActivityCount(SearchCustomerActivityCountModel searchCustomerActivityCountModel);
        Task<IEnumerable<CustomerLifeTimeModel>> GetCustomerAverageSpending(SearchCustomerLTV searchCustomerLTV);

    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;

namespace CRM.Application.Interfaces
{
    public interface ICustomerSummaryService
    {
        Task<IEnumerable<CustomerSummaryResponse>> GetCustActivity(SearchCustomerSummary searchCustomerSummary);
        Task<IEnumerable<CustomerActivityCountModel>> GetCustomerActivityCount(SearchCustomerActivityCountModel searchCustomerActivityCountModel);
        Task<IEnumerable<CustomerLifeTimeModel>> GetCustomerAverageSpending(SearchCustomerLTV searchCustomerLTV);
    }
}
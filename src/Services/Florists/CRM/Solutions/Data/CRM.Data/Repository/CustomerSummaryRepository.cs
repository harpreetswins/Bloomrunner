using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class CustomerSummaryRepository : GenericRepository, ICustomerSummaryRepository
    {
        public CustomerSummaryRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<CustomerSummaryResponse>> GetCustActivity(SearchCustomerSummary searchCustomerSummary)
        {
            return await Query<CustomerSummaryResponse>("Crm.GetCustSummary", searchCustomerSummary);
        }
        public async Task<IEnumerable<CustomerActivityCountModel>> GetCustomerActivityCount(SearchCustomerActivityCountModel searchCustomerActivityCountModel)
        {
            return await Query<CustomerActivityCountModel>("Crm.GetCustomerActivityCount", searchCustomerActivityCountModel);
        }
        public async Task<IEnumerable<CustomerLifeTimeModel>> GetCustomerAverageSpending(SearchCustomerLTV searchCustomerLTV)
        {
            return await Query<CustomerLifeTimeModel>("Crm.GetAverageSpendingPerCustomer", searchCustomerLTV);
        }
    }
}
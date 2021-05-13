using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class ClientSubscriptionPlanListRepository : GenericRepository, ICRMClientSubscriptionPlanRepository
    {
        public ClientSubscriptionPlanListRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<SubscriptionPlanListModel>> GetSubscriptionPlanList(SearchSubscriptionPlanList searchSubscriptionPlanList)
        {
            return await Query<SubscriptionPlanListModel>("Crm.ClientSubscriptionPlanList", searchSubscriptionPlanList);
        }
    }
}
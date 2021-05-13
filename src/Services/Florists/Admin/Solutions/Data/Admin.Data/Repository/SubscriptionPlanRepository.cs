using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Interfaces;
using Admin.Domain.Models.Admin;
using Microsoft.Extensions.Configuration;

namespace Admin.Data.GenericRepository
{
    public class SubscriptionPlanRepository : GenericRepository, ISubscriptionPlanRepository
    {
        public SubscriptionPlanRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<SubscriptionPlanModel>> GetSubscriptionPlanList()
        {
            return await Query<SubscriptionPlanModel>("Flo.GetSubscriptionPlanList");
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;

using Admin.Domain.Interfaces;
using Admin.Domain.Models.Admin;
using Admin.Application.Interfaces;

namespace Admin.Application.Services
{
    public class SubscriptionPlanService : ISubscriptionPanService
    {
        private readonly ISubscriptionPlanRepository _subscriptionPlanRepository;
        public SubscriptionPlanService(ISubscriptionPlanRepository subscriptionPlanRepository)
        {
            this._subscriptionPlanRepository = subscriptionPlanRepository;
        }
        public async Task<IEnumerable<SubscriptionPlanModel>> GetSubscriptionPlanList()
        {
           return await _subscriptionPlanRepository.GetSubscriptionPlanList();
        }
    }
}
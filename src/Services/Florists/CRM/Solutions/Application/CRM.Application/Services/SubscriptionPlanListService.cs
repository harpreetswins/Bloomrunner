using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class SubscriptionPlanListService : ICRMSubscriptionPlanListService
    {
        private readonly ICRMClientSubscriptionPlanRepository _cRMClientSubscriptionPlanRepository;
        public SubscriptionPlanListService(ICRMClientSubscriptionPlanRepository cRMClientSubscriptionPlanRepository)
        {
            _cRMClientSubscriptionPlanRepository = cRMClientSubscriptionPlanRepository;
        }
        public async Task<IEnumerable<SubscriptionPlanListModel>> GetSubscriptionPlanList(SearchSubscriptionPlanList searchSubscriptionPlanList)
        {
            return await _cRMClientSubscriptionPlanRepository.GetSubscriptionPlanList(searchSubscriptionPlanList);
        }
    }
}
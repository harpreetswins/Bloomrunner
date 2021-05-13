using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;

namespace CRM.Application.Interfaces
{
    public interface ICRMSubscriptionPlanListService
    {
        Task<IEnumerable<SubscriptionPlanListModel>> GetSubscriptionPlanList(SearchSubscriptionPlanList searchSubscriptionPlanList);

    }
}
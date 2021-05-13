using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models.Admin;

namespace Admin.Domain.Interfaces
{
    public interface ISubscriptionPlanRepository
    {
        Task<IEnumerable<SubscriptionPlanModel>> GetSubscriptionPlanList();
    }
}
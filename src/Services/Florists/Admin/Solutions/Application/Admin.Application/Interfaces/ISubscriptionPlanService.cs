using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models.Admin;

namespace Admin.Application.Interfaces
{
    public interface ISubscriptionPanService
    {
        Task<IEnumerable<SubscriptionPlanModel>> GetSubscriptionPlanList();
    }    
}
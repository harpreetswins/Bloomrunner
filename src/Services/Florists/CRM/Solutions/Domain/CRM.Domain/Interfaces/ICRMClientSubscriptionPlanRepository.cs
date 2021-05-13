using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;

namespace CRM.Domain.Interfaces
{
    public interface ICRMClientSubscriptionPlanRepository
    {
        Task<IEnumerable<SubscriptionPlanListModel>> GetSubscriptionPlanList(SearchSubscriptionPlanList  searchSubscriptionPlanList);
         
    }
}
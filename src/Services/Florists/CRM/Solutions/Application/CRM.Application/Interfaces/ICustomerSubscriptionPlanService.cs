using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;

namespace CRM.Application.Interfaces
{
    public interface ICustomerSubscriptionPlanService
    {
        Task<IEnumerable<CustomerSubscriptionPlanDerivedModel>> GetCustomerSubscriptionPlan(SearchCustomerSubscriptionPlan searchCustomerSubscriptionPlan);
        Task<CommonResponse> AddSubscriptionPlans(AddCustomerSubscriptionPlanModel addCustomerSubscriptionPlanModel);
        Task<int> DeleteSubscriptionPlans(DeleteCustomerSubcriptionPlanModel deleteCustomerSubcriptionPlanModel);
        Task<CommonResponse> UpdateSubscriptionPlans(UpdateCustomerSubcriptionPlanModel updateCustomerSubcriptionPlanModel);
        Task<IEnumerable<CustomerSubscriptionPlanListDrivedModel>> GetCustomerSubscriptionPlanLists(CustomerSubscriptionPlanListModel customerSubscriptionPlanListModel);
        Task<int> SubscriptionPlansUpdateStatus(CustomerSubscriptionPlansUpdateStatusModel customerSubscriptionPlansUpdateStatusModel);
        Task<IEnumerable<CustomerSubscriptionPlanbyIdDrivedModel>> GetCustomerSubscriptionPlanbyId(CustomerSubscriptionPlansByIdModel customerSubscriptionPlansByIdModel);
    }
}
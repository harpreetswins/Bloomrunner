using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class CustomerSubscriptionPlanRepository : GenericRepository, ICustomerSubscriptionPlanRepository
    {
        public CustomerSubscriptionPlanRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<CustomerSubscriptionPlanDerivedModel>> GetCustomerSubscriptionPlan(SearchCustomerSubscriptionPlan searchCustomerSubscriptionPlan)
        {
            return await Query<CustomerSubscriptionPlanDerivedModel>("Crm.GetCustomerSubscriptionPlan", searchCustomerSubscriptionPlan);
        }
        public async Task<CommonResponse> AddSubscriptionPlans(AddCustomerSubscriptionPlanModel addCustomerSubscriptionPlanModel)
        {
            return await ExecuteAll<CommonResponse>("Crm.AddCustomerSubscriptionPlans", addCustomerSubscriptionPlanModel);
        }
        public async Task<CommonResponse> UpdateSubscriptionPlans(UpdateCustomerSubcriptionPlanModel updateCustomerSubcriptionPlanModel)
        {
            return await ExecuteAll<CommonResponse>("Crm.UpdateCustomerSubscriptionPlans", updateCustomerSubcriptionPlanModel);
        }
        public async Task<int> DeleteSubscriptionPlans(DeleteCustomerSubcriptionPlanModel deleteCustomerSubcriptionPlanModel)
        {
            return await Command<DeleteCustomerSubcriptionPlanModel>("Crm.DeleteCustomerSubscriptionPlans", deleteCustomerSubcriptionPlanModel);
        }
        public async Task<IEnumerable<CustomerSubscriptionPlanListDrivedModel>> GetCustomerSubscriptionPlanLists(CustomerSubscriptionPlanListModel customerSubscriptionPlanListModel)
        {
            return await Query<CustomerSubscriptionPlanListDrivedModel>("Glo.GetCustomerSubscriptionPlanList", customerSubscriptionPlanListModel);
        }
        public async Task<int> SubscriptionPlansUpdateStatus(CustomerSubscriptionPlansUpdateStatusModel customerSubscriptionPlansUpdateStatusModel)
        {
            return await Command<CustomerSubscriptionPlansUpdateStatusModel>("Crm.CustomerSubscriptionPlansUpdateStatus", customerSubscriptionPlansUpdateStatusModel);
        }
        public async Task<IEnumerable<CustomerSubscriptionPlanbyIdDrivedModel>> GetCustomerSubscriptionPlanbyId(CustomerSubscriptionPlansByIdModel customerSubscriptionPlansByIdModel)
        {
            return await Query<CustomerSubscriptionPlanbyIdDrivedModel>("Crm.GetCustomerSubscriptionPlanById", customerSubscriptionPlansByIdModel);
        }
    }
}
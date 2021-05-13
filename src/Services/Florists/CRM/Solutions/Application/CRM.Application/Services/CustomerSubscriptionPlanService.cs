using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class CustomerSubscriptionPlanService : ICustomerSubscriptionPlanService
    {
        private readonly ICustomerSubscriptionPlanRepository _customerSubscriptionPlanRepository;
        public CustomerSubscriptionPlanService(ICustomerSubscriptionPlanRepository customerSubscriptionPlanRepository)
        {
            _customerSubscriptionPlanRepository = customerSubscriptionPlanRepository;
        }
        public async Task<IEnumerable<CustomerSubscriptionPlanDerivedModel>> GetCustomerSubscriptionPlan(SearchCustomerSubscriptionPlan searchCustomerSubscriptionPlan)
        {
            return await _customerSubscriptionPlanRepository.GetCustomerSubscriptionPlan(searchCustomerSubscriptionPlan);
        }
        public async Task<CommonResponse> AddSubscriptionPlans(AddCustomerSubscriptionPlanModel addCustomerSubscriptionPlanModel)
        {
            return await _customerSubscriptionPlanRepository.AddSubscriptionPlans(addCustomerSubscriptionPlanModel);
        }
        public async Task<CommonResponse> UpdateSubscriptionPlans(UpdateCustomerSubcriptionPlanModel updateCustomerSubcriptionPlanModel)
        {
            return await _customerSubscriptionPlanRepository.UpdateSubscriptionPlans(updateCustomerSubcriptionPlanModel);
        }
        public async Task<int> DeleteSubscriptionPlans(DeleteCustomerSubcriptionPlanModel deleteCustomerSubcriptionPlanModel)
        {
            return await _customerSubscriptionPlanRepository.DeleteSubscriptionPlans(deleteCustomerSubcriptionPlanModel);
        }
        public async Task<IEnumerable<CustomerSubscriptionPlanListDrivedModel>> GetCustomerSubscriptionPlanLists(CustomerSubscriptionPlanListModel customerSubscriptionPlanListModel)
        {
            return await _customerSubscriptionPlanRepository.GetCustomerSubscriptionPlanLists(customerSubscriptionPlanListModel);
        }
        public async Task<int> SubscriptionPlansUpdateStatus(CustomerSubscriptionPlansUpdateStatusModel customerSubscriptionPlansUpdateStatusModel)
        {
            return await _customerSubscriptionPlanRepository.SubscriptionPlansUpdateStatus(customerSubscriptionPlansUpdateStatusModel);
        }
        public async Task<IEnumerable<CustomerSubscriptionPlanbyIdDrivedModel>> GetCustomerSubscriptionPlanbyId(CustomerSubscriptionPlansByIdModel customerSubscriptionPlansByIdModel)
        {
            return await _customerSubscriptionPlanRepository.GetCustomerSubscriptionPlanbyId(customerSubscriptionPlansByIdModel);
        }
    }
}
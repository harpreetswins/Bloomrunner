using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<IEnumerable<CustomerModellDerived>> GetCustomers(CustomerSearchModel customerSearchModel)
        {
            return await _customerRepository.GetCustomers(customerSearchModel);
        }
        public async Task<int> DeleteCustomers(CustomerDeleteModel customerDeleteModel)
        {
            return await _customerRepository.DeleteCustomers(customerDeleteModel);
        }
        //Update data
        public async Task<int> UpdateCustomers(CustomerUpdateModel customerUpdateModel)
        {
            return await _customerRepository.UpdateCustomers(customerUpdateModel);
        }
        public async Task<CommonResponse> AddCustomers(CustomerModel customerModel)
        {
            return await _customerRepository.AddCustomers(customerModel);
        }
        public async Task<int> CustomersUpdateStatus(CustomerUpdateStatusModel customerUpdateStatusModel)
        {
            return await _customerRepository.CustomersUpdateStatus(customerUpdateStatusModel);
        }
    }
}
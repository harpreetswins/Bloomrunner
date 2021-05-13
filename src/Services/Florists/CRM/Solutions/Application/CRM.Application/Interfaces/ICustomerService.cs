using CRM.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM.Application.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerModellDerived>> GetCustomers(CustomerSearchModel customerSearchModel);
        Task<CommonResponse> AddCustomers(CustomerModel customerModel);
        Task<int> DeleteCustomers(CustomerDeleteModel customerDeleteModel);
        Task<int> UpdateCustomers(CustomerUpdateModel CustomerUpdateModel);
        Task<int> CustomersUpdateStatus(CustomerUpdateStatusModel customerUpdateStatusModel);
    }
}
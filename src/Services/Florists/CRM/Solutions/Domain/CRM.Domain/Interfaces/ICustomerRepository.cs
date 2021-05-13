using System;
using CRM.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM.Domain.Interfaces
{
    public interface ICustomerRepository
    {
    //Task<IEnumerable<CustomerModellDerived>> GetCustomers();
    Task<IEnumerable<CustomerModellDerived>> GetCustomers(CustomerSearchModel customerSearchModel);
   // Task<int> AddCustomers(CustomerModel customerModel);  
    Task<CommonResponse> AddCustomers(CustomerModel customerModel);
    Task<int> DeleteCustomers (CustomerDeleteModel customerDeleteModel); 
     Task<int> UpdateCustomers (CustomerUpdateModel customerUpdateModel);
    Task<int> CustomersUpdateStatus (CustomerUpdateStatusModel customerUpdateStatusModel);        
    }
}
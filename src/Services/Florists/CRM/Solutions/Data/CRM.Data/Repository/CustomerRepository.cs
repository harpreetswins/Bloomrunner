using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class CustomerRepository : GenericRepository, ICustomerRepository
    {
        public CustomerRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<CustomerModellDerived>> GetCustomers(CustomerSearchModel customerSearchModel)
        {
            return await Query<CustomerModellDerived>("Crm.SearchCustomers", customerSearchModel);
        }
        public async Task<int> DeleteCustomers(CustomerDeleteModel customerDeleteModel)
        {
            return await Command<CustomerDeleteModel>("Crm.DeleteCustomers", customerDeleteModel);
        }
        public async Task<int> UpdateCustomers(CustomerUpdateModel CustomerUpdateModel)
        {
            return await Command<CustomerUpdateModel>("Crm.UpdateCustomers", CustomerUpdateModel);
        }
        public async Task<CommonResponse> AddCustomers(CustomerModel sid)
        {
            return await ExecuteAll<CommonResponse>("Crm.AddCustomers", sid);
        }
        public async Task<int> CustomersUpdateStatus(CustomerUpdateStatusModel customerUpdateStatusModel)
        {
            return await Command<CustomerUpdateStatusModel>("Crm.CustomerUpdateStatus", customerUpdateStatusModel);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class CustomerFavouriteRepository : GenericRepository, ICustomerFavouriteRepository
    {
        public CustomerFavouriteRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<CustomerFavouriteModel>> GetCustomerFavourites(SearchCustomerSummary searchCustomerSummary)
        {
            return await Query<CustomerFavouriteModel>("Crm.GetCustomerFavourites", searchCustomerSummary);
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class CustomerFavouriteService : ICustomerFavouriteService
    {
        private readonly ICustomerFavouriteRepository _customerFavouriteRepository;
        public CustomerFavouriteService(ICustomerFavouriteRepository customerFavouriteRepository)
        {
            _customerFavouriteRepository = customerFavouriteRepository;
        }
        public async Task<IEnumerable<CustomerFavouriteModel>> GetCustomerFavourites(SearchCustomerSummary searchCustomerSummary)
        {
            return await _customerFavouriteRepository.GetCustomerFavourites(searchCustomerSummary);
        }
    }
}
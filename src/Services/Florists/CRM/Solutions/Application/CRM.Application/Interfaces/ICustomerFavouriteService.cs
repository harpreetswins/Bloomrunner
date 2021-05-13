using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;

namespace CRM.Application.Interfaces
{
    public interface ICustomerFavouriteService
    {
        Task<IEnumerable<CustomerFavouriteModel>> GetCustomerFavourites(SearchCustomerSummary searchCustomerSummary);
    }
}
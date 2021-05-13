using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;

namespace CRM.Domain.Interfaces
{
    public interface ICustomerFavouriteRepository
    {
         Task<IEnumerable<CustomerFavouriteModel>> GetCustomerFavourites(SearchCustomerSummary searchCustomerSummary);

    }
}
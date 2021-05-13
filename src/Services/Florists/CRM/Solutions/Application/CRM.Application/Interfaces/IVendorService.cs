using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;

namespace CRM.Application.Interfaces
{
    public interface IVendorService
    {
        Task<IEnumerable<VendorModel>> GetVendors(SearchVendor searchVendor);
    }
}
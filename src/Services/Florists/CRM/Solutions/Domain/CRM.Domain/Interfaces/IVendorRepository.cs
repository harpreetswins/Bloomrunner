using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Domain.Interfaces
{
    public interface IVendorRepository
    {
           Task<IEnumerable<VendorModel>> GetVendors(SearchVendor searchVendor);
    }
}
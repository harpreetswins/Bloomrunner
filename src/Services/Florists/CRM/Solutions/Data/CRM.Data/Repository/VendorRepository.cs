using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Data.GenericRepository
{
    public class VendorRepository : GenericRepository, IVendorRepository
    {
        public VendorRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<VendorModel>> GetVendors(SearchVendor searchVendor)
        {

            return await Query<VendorModel>("Pdt.GetVendorList", searchVendor);
        }
    }
}
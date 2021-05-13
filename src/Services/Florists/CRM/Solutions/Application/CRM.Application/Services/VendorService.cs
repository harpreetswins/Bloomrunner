using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class VendorService : IVendorService
    {
        private readonly IVendorRepository _vendorRepository;
        public VendorService(IVendorRepository vendorRepository)
        {
            this._vendorRepository = vendorRepository;
        }

        public async Task<IEnumerable<VendorModel>> GetVendors(SearchVendor searchVendor)
        {
            return await _vendorRepository.GetVendors(searchVendor);
        }
    }
}
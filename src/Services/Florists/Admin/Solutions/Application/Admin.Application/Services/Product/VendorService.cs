using Admin.Application.Interfaces.Product;
using Admin.Domain.Interfaces.Product;
using Admin.Domain.Models;
using Admin.Domain.Models.Product;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Admin.Application.Services.Product
{
    public class VendorService : IVendorService
    {
        private readonly IVendorRepository _vendorRepository;
        public VendorService(IVendorRepository vendorRepository)
        {
          this._vendorRepository=vendorRepository;
        }
        public Task<IEnumerable<VendorModelDerived>> GetVendorById(FloVendorId floVendorId)
        {
          return _vendorRepository.GetVendorById(floVendorId);
        }
        public Task<IEnumerable<VendordropdownResponse>> GetVendordropdownlist(VendordropdownModel vendordropdownModel)
        {
          return _vendorRepository.GetVendordropdownlist(vendordropdownModel);
        }
        public async Task<CommonResponse> AddVendor(VendorModel vendorModel)
        {
            return await _vendorRepository.AddVendor(vendorModel);
        }
        public async Task<CommonResponse> UpdateVendor(VendorUpdateModel vendorUpdateModel)
        {
            return await _vendorRepository.UpdateVendor(vendorUpdateModel);
        }
        public async Task<CommonResponse> DeleteVendor(VendorDeleteModel vendorDeleteModel)
        {
             return await _vendorRepository.DeleteVendor(vendorDeleteModel);
        }
        public async Task<CommonResponse> UpdateVendorStatus(UpdateVendorStatus updateVendorStatus)
        {
            return await _vendorRepository.UpdateVendorStatus(updateVendorStatus);
        }
    }
}
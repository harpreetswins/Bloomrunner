using Admin.Domain.Models;
using Admin.Domain.Models.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Domain.Interfaces.Product
{
    public interface IVendorRepository
    {
        Task<IEnumerable<VendordropdownResponse>> GetVendordropdownlist(VendordropdownModel vendordropdownModel);
        Task<IEnumerable<VendorModelDerived>> GetVendorById(FloVendorId floVendorId);
        Task<CommonResponse> AddVendor(VendorModel vendorModel);
        Task<CommonResponse> UpdateVendor(VendorUpdateModel vendorUpdateModel);
        Task<CommonResponse> DeleteVendor(VendorDeleteModel vendorDeleteModel);
        Task<CommonResponse> UpdateVendorStatus(UpdateVendorStatus updateVendorStatus);
    }
}
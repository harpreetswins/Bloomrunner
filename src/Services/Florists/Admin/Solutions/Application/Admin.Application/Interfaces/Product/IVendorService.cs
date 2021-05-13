using Admin.Domain.Models;
using Admin.Domain.Models.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Application.Interfaces.Product
{
    public interface IVendorService
    {
        Task<IEnumerable<VendorModelDerived>> GetVendorById(FloVendorId floVendorId);
        Task<IEnumerable<VendordropdownResponse>> GetVendordropdownlist(VendordropdownModel vendordropdownModel);
        Task<CommonResponse> AddVendor(VendorModel vendorModel);
        Task<CommonResponse> UpdateVendor(VendorUpdateModel vendorUpdateModel);
        Task<CommonResponse> DeleteVendor(VendorDeleteModel vendorDeleteModel);
        Task<CommonResponse> UpdateVendorStatus(UpdateVendorStatus updateVendorStatus);
    }
}
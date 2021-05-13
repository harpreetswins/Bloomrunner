using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models.Product;
using Microsoft.Extensions.Configuration;
using Admin.Domain.Interfaces.Product;
using Admin.Domain.Models;

namespace Admin.Data.GenericRepository
{
    public class VendorRepository : GenericRepository, IVendorRepository
    {
        public VendorRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<CommonResponse> AddVendor (VendorModel vendorModel)
        {
            return await ExecuteAll<CommonResponse>("Pdt.AddVendors", vendorModel);
        }
        public async Task<CommonResponse> DeleteVendor (VendorDeleteModel vendorDeleteModel)
        {
            return await ExecuteAll<CommonResponse>("Pdt.DeleteVendors", vendorDeleteModel);
        }
        public async Task<CommonResponse> UpdateVendor (VendorUpdateModel vendorUpdateModel)
        {
            return await ExecuteAll<CommonResponse>("Pdt.UpdateVendors", vendorUpdateModel);
        }
        public async Task<CommonResponse> UpdateVendorStatus (UpdateVendorStatus updateVendorStatus)
        {
            return await ExecuteAll<CommonResponse>("Pdt.UpdateVendorStatus", updateVendorStatus);
        }
        public async Task<IEnumerable<VendorModelDerived>> GetVendorById (FloVendorId floVendorId)
        {
            return await Query<VendorModelDerived>("Pdt.GetVendorById", floVendorId);
        }
        public async Task<IEnumerable<VendordropdownResponse>> GetVendordropdownlist(VendordropdownModel vendordropdownModel)
        {
            return await Query<VendordropdownResponse>("Pdt.VendorDropDownList", vendordropdownModel);
        }
    }
}
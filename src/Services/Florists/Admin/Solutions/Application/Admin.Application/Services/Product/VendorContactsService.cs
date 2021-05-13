using System.Threading.Tasks;
using Admin.Domain.Interfaces.Product;
using Admin.Domain.Models.Product;

namespace Admin.Application.Services.Product
{
    public class VendorContactsService :IVendorContactsRepository
    {
         private readonly IVendorContactsRepository _vendorContactsRepository;

        public VendorContactsService(IVendorContactsRepository vendorContactsRepository)
        {
          this._vendorContactsRepository=vendorContactsRepository;
        }
        public async Task<int> AddVendorContacts(VendorContactsModel vendorContacts)
        {
            return await _vendorContactsRepository.AddVendorContacts(vendorContacts);
        }
    }
}
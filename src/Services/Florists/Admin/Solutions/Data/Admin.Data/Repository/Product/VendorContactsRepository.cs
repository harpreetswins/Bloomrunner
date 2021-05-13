using System.Threading.Tasks;
using Admin.Domain.Models.Product;
using Microsoft.Extensions.Configuration;
using Admin.Domain.Interfaces.Product;

namespace Admin.Data.GenericRepository
{
    public class VendorContactsRepository : GenericRepository, IVendorContactsRepository
    {
        public VendorContactsRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<int> AddVendorContacts(VendorContactsModel vendorContacts)
        {
            return await Command<VendorContactsModel>("Pdt.AddVendorContacts", vendorContacts);
        }
    }
}
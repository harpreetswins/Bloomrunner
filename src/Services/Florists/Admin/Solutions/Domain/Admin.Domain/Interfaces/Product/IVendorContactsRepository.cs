using Admin.Domain.Models.Product;
using System.Threading.Tasks;
namespace Admin.Domain.Interfaces.Product
{
    public interface IVendorContactsRepository
    {
        Task<int> AddVendorContacts(VendorContactsModel vendorContacts);
    }
}
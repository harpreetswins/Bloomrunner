using System.Threading.Tasks;
using Admin.Domain.Models.Product;

namespace Admin.Domain.Interfaces.Product
{
    public interface IImageRepository
    {
      public Task<string> UploadFileBlobAsync(ImageModel imageModel);         
    }
}
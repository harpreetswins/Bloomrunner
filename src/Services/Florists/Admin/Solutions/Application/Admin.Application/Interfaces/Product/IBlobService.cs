using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models.Product;
using Azure.Storage.Blobs.Models;

namespace Admin.Application.Interfaces.Product
{
    public interface IBlobService
    {
       Task<string> UploadFileBlobAsync(ImageModel imageModel);         
    }
}
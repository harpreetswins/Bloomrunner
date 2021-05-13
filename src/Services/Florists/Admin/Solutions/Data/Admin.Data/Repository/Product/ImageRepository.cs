using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Interfaces.Product;
using Admin.Domain.Models.Product;
using Microsoft.Extensions.Configuration;

namespace Admin.Data.GenericRepository
{
    public class ImageRepository : GenericRepository, IImageRepository
    {
        public ImageRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<string> UploadFileBlobAsync(ImageModel imageModel)
        {
            //throw new System.NotImplementedException();
             var abc= await Query<ImageKeyModel>("Pdt.AddProducts",imageModel);
             return "";
        }
    }
}
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.API.Infrastructure.BlobStorage.Models
{
    public class ImageData
    {
        public IFormFile Image { get; set; }
        public IFormFile Thumbnail { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.API.Infrastructure.BlobStorage.Models
{
    public class BlobConfig
    {
        public string StorageConnection { get; set; }
        public string Container { get; set; }
    }
}

using System.Threading.Tasks;

namespace Admin.API.Infrastructure.BlobStorage.Service
{
    public interface IBlobStorage
    {
        Task<string> UploadAsync(string file, byte[] data, string mime);
        byte[] Download(string id);
        Task<bool> Delete(string url);
    }
}

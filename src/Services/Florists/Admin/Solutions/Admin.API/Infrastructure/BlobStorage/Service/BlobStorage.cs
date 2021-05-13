using Admin.API.Infrastructure.BlobStorage.Models;
using Admin.API.Infrastructure.BlobStorage.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Admin.API.Infrastructure.BlobStorage.Service
{
    public class BlobStorage : IBlobStorage
    {
        private readonly IOptions<BlobConfig> _options;
        public BlobStorage(IOptions<BlobConfig> options)
        {
            this._options = options;
        }
        /// <summary>
        /// Delete file from azure blob storage
        /// </summary>
        /// <param name="id">Accepting image id</param>
        public async Task<bool> Delete(string url)
        {
            try
            {
                if (CloudStorageAccount.TryParse(this._options.Value.StorageConnection, out CloudStorageAccount storageAccount))
                {
                    CloudBlobClient BlobClient = storageAccount.CreateCloudBlobClient();
                    CloudBlobContainer container = BlobClient.GetContainerReference(this._options.Value.Container);

                    if (await container.ExistsAsync())
                    {
                        CloudBlob file = container.GetBlobReference(url);

                        if (await file.ExistsAsync())
                        {
                            await file.DeleteAsync();
                        }
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Delete file from azure blob storage
        /// </summary>
        /// <param name="id">Accepting image id</param>
        /// <returns></returns>
        public byte[] Download(string id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Upload file to azure blob storage
        /// </summary>
        /// <param name="file">image file name</param>
        /// <param name="data">image in byte format</param>
        /// <param name="mime">image extension</param>
        /// <returns></returns>
        public string Upload(string name, byte[] data, string mime)
        {
            try
            {

                var _task = Task.Run(() => this.UploadAsync(name, data, mime));
                _task.Wait();
                string fileUrl = _task.Result;
                return fileUrl;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
       
        public async Task<string> UploadAsync(string file, byte[] data, string mime)
        {
            try
            {
                CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(this._options.Value.StorageConnection);
                CloudBlobClient cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();
                CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(this._options.Value.Container);

                string uniqueFileName = BlobMethods.GetUniqueFileName(file);

                if (await cloudBlobContainer.CreateIfNotExistsAsync())
                {
                    await cloudBlobContainer.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });
                }
                if (uniqueFileName != null && data != null)
                {
                    CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(uniqueFileName);
                    cloudBlockBlob.Properties.ContentType = mime;
                    await cloudBlockBlob.UploadFromByteArrayAsync(data, 0, data.Length);
                    return uniqueFileName;
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}

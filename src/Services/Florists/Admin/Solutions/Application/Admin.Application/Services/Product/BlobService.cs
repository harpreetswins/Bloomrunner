using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Admin.Application.Interfaces.Product;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.WindowsAzure.Storage;  
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.Extensions.Configuration;
using System;
using Admin.Domain.Interfaces.Product;
using Admin.Domain.Models.Product;

namespace Admin.Application.Services.Product
{
    public class BlobService : IBlobService
    {
        private readonly IConfiguration _configuration;
        private readonly IImageRepository _blobService;
        public BlobService(IImageRepository blobService, IConfiguration configuration)
        {
            _blobService=blobService;
            _configuration = configuration;
        }
        public string UploadFileToBlob(ImageModel imageModel)  
        {   
                var _task = Task.Run(() => this.UploadFileBlobAsync(imageModel));  
                _task.Wait();  
                string fileUrl = _task.Result;  
                return fileUrl;           
        }
        private string GenerateFileName(string fileName)  
        {  
            string strFileName = string.Empty;  
            string[] strName = fileName.Split('.');  
            strFileName =Guid.NewGuid().ToString();  
            return strFileName;  
        }  
        public async Task<string> UploadFileBlobAsync(ImageModel imageModel)  
        { 
           // string accessKey="DefaultEndpointsProtocol=https;AccountName=bloomrunnerstorage;AccountKey=RcQZ+Ys12x+rDKVYFG1W/Pgp4+KgwYU6DJYRqfOql1dQAKeKZMfpTlGtNeLxA+Djezc0vkA3DGPIA2WeM7pkUw==;EndpointSuffix=core.windows.net"; 
            string accessKey = _configuration["AzureBlobStroageConnectionString"];
            CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(accessKey);  
            CloudBlobClient cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();  
            string strContainerName = "productcontainer";  
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(strContainerName);  
            string fileName = this.GenerateFileName(imageModel.strFileName); 

            if (await cloudBlobContainer.CreateIfNotExistsAsync())  
            {  
                await cloudBlobContainer.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });  
            }  
  
            if (fileName != null && imageModel.fileData != null)  
            {  
                CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(fileName);  
                cloudBlockBlob.Properties.ContentType = imageModel.fileMimeType;  
                await cloudBlockBlob.UploadFromByteArrayAsync(imageModel.fileData, 0, imageModel.fileData.Length);  
                return cloudBlockBlob.Uri.AbsoluteUri;  
            }  
            return "";  
        }

       
    }
}
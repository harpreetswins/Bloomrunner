using Admin.API.Infrastructure.BlobStorage.Models;
using Admin.API.Infrastructure.BlobStorage.Service;
using Admin.API.Infrastructure.BlobStorage.Utilities;
using Admin.Application.Interfaces.Product;
using Admin.Domain.Models.Product;
using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Admin.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiController]
    public class BlobController : ControllerBase
    {
        private readonly IBlobStorage _storage;
        public BlobController(IBlobStorage storage)
        {
            this._storage = storage;
        }

        [HttpPost]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> UploadAsync(IFormFile file)
        {
            if (!BlobMethods.IsImage(file))
            {
                return BadRequest();
            }
            string fileName = await _storage.UploadAsync(file.FileName, await file.GetBytes(), file.ContentType);
            return Ok(new { File = fileName });
        }
        [HttpDelete]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> DeleteAsync(string url)
        {
            await _storage.Delete(url);
            return Ok();
        }
    }
}
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Admin.API.Infrastructure.BlobStorage.Utilities
{
    public static class BlobMethods
    {
        public static bool IsImage(this IFormFile file)
        {
            string mime = file.ContentType.ToLower();
            string extension = Path.GetExtension(file.FileName).ToLower();
            const int ImageMinimumBytes = 512;
            //-------------------------------------------
            //  Check the image mime types
            //-------------------------------------------
            if (mime != "image/jpeg" && mime!="image/jpg" && mime != "image/png")
            {
                return false;
            }

            //-------------------------------------------
            //  Check the image extension
            //-------------------------------------------
            if (extension!=".jpg" && extension!=".jpeg" && extension != ".png")
            {
                return false;
            }
            //-------------------------------------------
            //  Attempt to read the file and check the first bytes
            //-------------------------------------------

            try
            {
                if (!file.OpenReadStream().CanRead)
                {
                    return false;
                }
                //------------------------------------------
                //check whether the image size exceeding the limit or not
                //------------------------------------------ 
                if (file.Length < ImageMinimumBytes)
                {
                    return false;
                }

                byte[] buffer = new byte[ImageMinimumBytes];
                file.OpenReadStream().Read(buffer, 0, ImageMinimumBytes);
                string content = System.Text.Encoding.UTF8.GetString(buffer);
                if (Regex.IsMatch(content, @"<script|<html|<head|<title|<body|<pre|<table|<a\s+href|<img|<plaintext|<cross\-domain\-policy", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Multiline))
                {
                    return false;
                }

                //-------------------------------------------
                //  Try to instantiate new Bitmap, if .NET will throw exception
                //  we can assume that it's not a valid image
                //-------------------------------------------

                try
                {
                    using (var bitmap = new Bitmap(file.OpenReadStream()))
                    {
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    file.OpenReadStream().Position = 0;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString()
                      + Path.GetExtension(fileName);
        }
    }
}

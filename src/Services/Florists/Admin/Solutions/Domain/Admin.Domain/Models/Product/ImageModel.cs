namespace Admin.Domain.Models.Product
{
    public class ImageModel
    {
        public string strFileName { get; set; }
        public byte[] fileData { get; set; }
        public string fileMimeType{ get; set; }
    }

    public class ImageKeyModel
    {
        public string ImageKeyValue { get; set; }
    }
}
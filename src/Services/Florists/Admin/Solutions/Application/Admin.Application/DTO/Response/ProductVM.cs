using System.Collections.Generic;
using Newtonsoft.Json;

namespace Admin.Application.DTO.Response
{
    public class ProductVM
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
    }
    public class ProductVMDTO
    {
        public int ProductId { get; set; }
        public int TotalSold { get; set; }
        public UpdatePriceOptions ShowPrice { get; set; } 
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public stud Tags;
        public bool IsActive { get; set; }
        public bool AddOns { get; set; }
        public Colort Colors { get; set; }   
        public Pricet Prices { get; set; }
        public int StockQuantity { get; set; }
        public string StockAvailability { get; set; }
        public Vendort Vendors { get; set; }
        public AddOnsProdcutt AddOnsProducts { get; set; }
        public bool MobileApp { get; set; }
        public bool Bloomrunner { get; set; }
        public bool WalkIn { get; set; }
        public bool Facebook { get; set; }
        public bool Instagram { get; set; }
        public string MetaDescription { get; set; }
        public MetaKeywordt MetaKeywords { get; set; }
        public Attributet Attributes { get; set; }
        public string CreatedBy { get; set; }
        public BlobImaget Images { get; set; }  
     }
    public class stud
    {
        [JsonProperty("tagName")]
        public string TagName;
    }
    public class Tagt                       // Product Tags
    {
        [JsonProperty("tagName")]
        public string TagName { get; set; }
    }
    public class Colort
    {
        public string ColorCode { get; set; }
        public string ColorValue { get; set; }
    }
    public class MetaKeywordt                // Meta Tags
    {
        [JsonProperty("tagName")]
        public string TagName { get; set; }
    }
    public class Pricet
    {
        [JsonProperty("sizeOptionId")]
        public int SizeOptionId { get; set; }
        public decimal CostPrice { get; set; }
    
        public decimal RegularPrice { get; set; }
        public decimal SalePrice { get; set; }
        public string Small { get; set; }
        public int SizeId { get; set; }
        public bool NotTaxable { get; set; }
    } 
    public class Attributet
    {
        public int AttributeId { get; set; }
        public string AttributesName { get; set; }
        public string AttributesValue { get; set; }
        public bool Tag { get; set; }
    }
    public class Vendort
    {
        public int VendorId { get; set; }
    }
    public class AddOnsProdcutt
    {
        public int AddOnId { get; set; }
        public int ProductId { get; set; }
        public int AddOnsProductId { get; set; }
        public decimal AddOnsPrice { get; set; }
    }
    public class BlobImaget
    {
        public int ImageId { get; set; }
        public int ImageType { get; set; }
        public string ImageTypeName { get; set; }
        public int SourceId { get; set; }
        public string ImageName { get; set; }
        public string AltText { get; set; }
        public bool IsCoverImage { get; set; }
        public ImgTagt ImageTags { get; set; }
    }
    public class ImgTagt
    {
        public string TagName { get; set; }
    }
    public class BlobUpdateImage
    {
        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public bool IsCoverImage { get; set; }
        public string AltText { get; set; }
        public ImgTagt ImageTags { get; set; }
    }
    public class UpdatePriceOptions
    {
        public decimal CostPrice { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal SalePrice { get; set; }
        public string Size { get; set; }
        public int SizeId { get; set; }
        public bool NotTaxable { get; set; }
    }

}
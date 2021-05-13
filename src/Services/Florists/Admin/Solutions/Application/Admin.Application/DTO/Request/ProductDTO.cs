using System.Collections.Generic;
namespace Admin.Application.DTO.Request
{
    public class ProductDTO
    {
        public int FloristId { get; set; }
        public int LocationId { get; set; }       
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; } 
        public List<Tag> Tags { get; set; } 
        public bool IsActive { get; set; }  
        public bool AddOns { get; set; }
        public List<BlobImage> Images{ get; set; }
        public List<Color> Colors { get; set; }
        public List<Price> Prices {get;set;}
        public int StockQuantity { get; set; }
        public string StockAvailability { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<AddOnsProdcut> AddOnsProducts { get; set; } 
        public bool MobileApp { get; set; }
        public bool Bloomrunner { get; set; }
        public bool WalkIn { get; set; }
        public bool Facebook { get; set; }
        public bool Instagram { get; set; }   
        public string MetaDescription { get; set; }
        public List<MetaKeyword> MetaKeywords{ get; set; }
        public List<Attribute> Attributes { get; set; } 
        public string CreatedBy { get; set; }  
     }
    public class Tag                       // Product Tags
    {
        public string TagName { get; set; }
    }
    public class ProductUpdateDTO
    {
        public int ProductId { get; set; }
        public int FloristId { get; set; }
        public int LocationId { get; set; }       
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; } 
        public List<Tag> Tags { get; set; } 
        public bool IsActive { get; set; }  
        public bool AddOns { get; set; }
        public List<BlobUpdateImage> Images{ get; set; }
        public List<Color> Colors { get; set; }           
        public List<UpdatePriceOptions> Prices {get;set;}
        public int StockQuantity { get; set; }
        public string StockAvailability { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<AddOnsProdcut> AddOnsProducts { get; set; } 
        public bool MobileApp { get; set; }
        public bool Bloomrunner { get; set; }
        public bool WalkIn { get; set; }
        public bool Facebook { get; set; }
        public bool Instagram { get; set; }   
        public string MetaDescription { get; set; }
        public List<MetaKeyword> MetaKeywords{ get; set; }
        public List<Attribute> Attributes { get; set; } 
        public string CreatedBy { get; set; }  
     }

    public class Color
    {
        public string ColorCode { get; set; }
        public string ColorValue { get; set; }
    }
    public class MetaKeyword                // Meta Tags
    {
        public string TagName { get; set; }
    }
    public class Price
    {
        public int SizeOptionId { get; set; }
        public decimal CostPrice { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal SalePrice { get; set; }
        public bool NotTaxable { get; set; }
    } 
    public class Attribute
    {
        public string AttributesName { get; set; }
        public string AttributesValue { get; set; }
        public bool Tag { get; set; }
    }
    public class Vendor
    {
        public int VendorId { get; set; }
    }
    public class AddOnsProdcut
    {
        public int AddOnsProductId { get; set; }
        public decimal AddOnsPrice { get; set; }
    }
    public class BlobImage
    {
        public string ImageName { get; set; }
        public bool IsCoverImage { get; set; }
        public string AltText { get; set; }
        public List<ImgTag> ImageTags { get; set; }
    }
    public class ImgTag
    {
        public string TagName { get; set; }
    }
    public class BlobUpdateImage
    {
        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public bool IsCoverImage { get; set; }
        public string AltText { get; set; }
        public List<ImgTag> ImageTags { get; set; }
    }
    public class UpdatePriceOptions
    {
         public int ProductPriceOptionId { get; set; }
        public int SizeOptionId { get; set; }
        public decimal CostPrice { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal SalePrice { get; set; }
        public bool NotTaxable { get; set; }
    }
}
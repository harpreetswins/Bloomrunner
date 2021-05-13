using System.ComponentModel.DataAnnotations;

namespace CRM.Domain.Models
{
    public class SearchProductsByTagsModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ShowPrice { get; set; }
        public string Prices { get; set; }
    }
    public class SearchProductsByTagsSearchModel
    {
        public int FId { get; set; }
        public string JsonTags { get; set; }        
    }
    public class ProductCatalogModel
    {
        [Required]
        public int FloristId { get; set; }
        public string JsonTags { get; set; }   
    }
    public class ProductCatalogResponse
    {
        public int ProductId { get; set; }
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public bool IsActive { get; set; }
        public bool AddOns { get; set; }
        public string Colors { get; set; }
         public string ShowPrice { get; set; } 
        public string Prices { get; set; }
        public int StockQuantity { get; set; }
        public string StockAvailability { get; set; }
        public string Vendors { get; set; }
        public string AddOnsProducts { get; set; }
        public bool MobileApp { get; set; }
        public bool Bloomrunner { get; set; }
        public bool WalkIn { get; set; }
        public bool Facebook { get; set; }
        public bool Instagram { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string Attributes { get; set; }
        public string GlobalNotes { get; set; } 
        public string CreatedBy { get; set; }
        public string Images { get; set; } 
        public int TotalSold { get; set; }   
    }
}
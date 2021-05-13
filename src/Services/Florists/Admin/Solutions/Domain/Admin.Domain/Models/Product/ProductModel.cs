using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Admin.Domain.Models.Product
{
    public class ProductModel
    {
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public bool IsActive { get; set; }
        public bool AddOns { get; set; }
        public string Colors { get; set; }   
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
        public string CreatedBy { get; set; }
        public string Images { get; set; }  
    }
    public class ProductModelDerived : ProductModel
    {
        public int ProductId { get; set; }
        public int TotalSold { get; set; }
        public string ShowPrice { get; set; }     
    }
    public class FloProductId
    {
        [Required]
        public int FId { get; set; }
        public int PId { get; set; }
    }
    public class ProdcutSearch
    {
        [Required]
        public int FId { get; set; }
        [Required]
        public int LocationId { get; set; }
        public string ProductName { get; set; }
    }
    public class ProdcutSearchModel
    {
        [Required]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ShowPrice { get; set; }
        public string Prices { get; set; }  
    }
    public class UpdateProduct
    {
        [Required]
        public int ProductId { get; set; }
        public bool Status { get; set; }
        public string ModifiedBy { get; set; }
    }
     public class DeleteProduct
    {
        [Required]
        public int ProductId { get; set; }
        public string DeletedBy { get; set; } 
    }
    public class ProductGridModel
    {
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal CostPrice { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal TotalSold { get; set; }
        public bool IsActive { get; set; }
        public string TotalRows { get; set; }
    }
    public class SearchProductGrid
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int LocationId { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string SearchValue { get; set; }    
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }
    public class CheckProductNameModel
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class ProductUpdateModel
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
        public string CreatedBy { get; set; }
        public string Images { get; set; }  
    }
}

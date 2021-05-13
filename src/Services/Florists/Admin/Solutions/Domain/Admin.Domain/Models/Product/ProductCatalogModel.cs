using System;
namespace Admin.Domain.Models.Product
{
    public class AddProductCatalog
    {
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public int CategoryType { get; set; }
        public string CatalogName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool MobileApp { get; set; }
        public bool BloomRunner { get; set; }
        public bool WalkIn { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string Tags { get; set; }
        public string CreatedBy { get; set; }

    }
    public class ProductCatalogModel : AddProductCatalog
    {
        public int CatalogId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryTypeName { get; set; }
        public int TotalRows { get; set; }
    }

    public class SearchProductCatalogList
    {
        public int FloristId { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string SearchValue { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }

    public class DeleteProductCatalog
    {
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public int CatalogId { get; set; }
        public String DeletedBy { get; set; }
    }

    public class UpdateProductCatalog
    {
        public int CatalogId { get; set; }
        public string ModifiedBy { get; set; }
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public int CategoryType { get; set; }
        public string CatalogName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool MobileApp { get; set; }
        public bool BloomRunner { get; set; }
        public bool WalkIn { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string Tags { get; set; }
    }
}
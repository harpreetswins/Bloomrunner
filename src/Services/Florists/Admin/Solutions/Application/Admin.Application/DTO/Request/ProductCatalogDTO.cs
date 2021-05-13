using System;
using System.Collections.Generic;
namespace Admin.Application.DTO.Request
{
    public class AddProductCatalogDTO
    {
        public int FloristId { get; set; }
        public int CategoryType { get; set; }
        public string CatalogName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool MobileApp { get; set; }
        public bool BloomRunner { get; set; }
        public bool WalkIn { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive  { get; set; }
        public int LocationId { get; set; }
        public List<Tags> Tags { get; set; }
    }
    public class Tags
    {
        public string TagName { get; set; }
    }

    public class UpdateProductCatalogDTO
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
        public List<Tags> Tags { get; set; }
     
    }
}
using System.Collections.Generic;

namespace Admin.Application.DTO.Request
{
    public class VendorDTO
    {
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string ZipCode { get; set; }
        public int State { get; set; }
        public string City { get; set; }
        public  string Address { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string WebSite { get; set; }                
        public List<VendorTags> Tags { get; set; } 
        public List<VendorProduct> Products { get; set; }
        public string CreatedBy { get; set; } 
    }
    public class VendorTags
    {
        public string TagName { get; set; }
    }
    public class VendorUpdateDTO
    {
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public int VendorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string ZipCode { get; set; }
        public int State { get; set; }
        public string City { get; set; }
        public  string Address { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string WebSite { get; set; }                
        public List<VendorTags> Tags { get; set; }
        public List<VendorProduct> Products { get; set; }
        public bool IsActive { get; set; }
        public string ModifiedBy { get; set; } 
    }
    public class VendorProduct
    {
        public int ProductId { get; set; }
    }
}
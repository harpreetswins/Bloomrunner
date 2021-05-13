using System;
using System.ComponentModel.DataAnnotations;

namespace Admin.Domain.Models.Product
{
    public class VendorModel
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public int State { get; set; }
        public string City { get; set; }
        public  string Address { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string WebSite { get; set; }                
        public string Tags { get; set; } 
        public string Products { get; set; }
        [Required]
        public string CreatedBy { get; set; } 
    }
    public class VendorModelDerived : VendorModel
    {
        public int VendorId { get; set; }
        public string StateName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class VendorUpdateModel
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public int VendorId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public int State { get; set; }
        public string City { get; set; }
        public  string Address { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string WebSite { get; set; }                
        public string Tags { get; set; }
        public string Products { get; set; } 
        public bool IsActive { get; set; }
        [Required]
        public string ModifiedBy { get; set; } 
    }
    public class UpdateVendorStatus
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public int VendorId { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
    }
    public class VendorDeleteModel
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public int VendorId { get; set; }
        [Required]
        public string DeletedBy { get; set; }
    }
    public class FloVendorId
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public int VendorId { get; set; }
    }
    public class VendordropdownModel
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int LocationId { get; set; }
    }
    public class VendordropdownResponse
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
    }
}
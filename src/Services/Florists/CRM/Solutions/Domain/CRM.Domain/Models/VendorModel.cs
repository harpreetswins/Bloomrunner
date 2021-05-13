using System;

namespace CRM.Domain.Models
{
    public class VendorModel
    {
        public int VendorId { get; set; }

        public string VendorName { get; set; }

        public string Email { get; set; }

        public string PhoneNo { get; set; }

        public int ZipCode { get; set; }

        public Decimal PurchaseOrderTotal { get; set; }

        public DateTime LastPurchaseDate { get; set; }
        public string TopProducts { get; set; }
        public bool IsActive { get; set; }
        public string TotalRows { get; set; }
    }

     public class SearchVendor
     {
         public int FloristId { get; set; }

         public int PageNo { get; set; }

         public int PageSize { get; set; }

         public string SearchValue { get; set; }

         public string SortColumn { get; set; }

         public string SortOrder { get; set; }
     }

     public class VendorDeleteModel
     {
         public int VendorId { get; set; }

         public string DeletedBy { get; set; } 
     }

     public class VendorUpdateModel
     {

     }

     public class VendorStatusModel
     {
        public int VendorId { get; set; }
        public bool IsArtist { get; set; } 
        public string ModifiedBy { get; set; }
     }
}
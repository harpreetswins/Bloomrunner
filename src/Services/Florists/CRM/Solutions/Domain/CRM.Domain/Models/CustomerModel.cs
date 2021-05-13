using System.ComponentModel.DataAnnotations;
namespace CRM.Domain.Models
{
    public class CustomerModel
    {        
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public int Gender { get; set; } 
        public string CustomerEmail { get; set; }
        public string CustomerMobileNo { get; set; }
        public int CustomerState { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerAddress { get; set; }
        public string BillingAddress { get; set; }
        public bool IsAccountClosed { get; set; }
        //public datetime AccountClosingDate { get; set; }
        public string CreatedBy { get; set; }
    }

    public class CustomerDeleteModel
    {    
      public int CustomerId { get; set; }       
      public int FloristId { get; set; }             
      public string DeletedBy { get; set; }        
    }
    public class CustomerUpdateModel
    {    
      public int CustomerId { get; set; }         
      public int FloristId { get; set; }  
      public string CustomerFirstName { get; set; } 
      public string CustomerLastName { get; set; } 
      public int Gender { get; set; } 
      public string CustomerMobileNo { get; set; } 
      public int CustomerState { get; set; } 
      public string CustomerCity { get; set; } 
      public string CustomerZipCode { get; set; } 
      public string CustomerAddress { get; set; } 
      public string BillingAddress { get; set; } 
     public string ModifiedBy { get; set; }        
    }
    public class CustomerSearchModel
    {   
     [Required]
      //public int ci { get; set; } 
      public string value { get; set; }      
      public int FloristId { get; set; }          
         
    }

    public class CustomerModellDerived : CustomerModel
    {
    //public int ci { get; set; } 
     //public int ck { get; set; } 
    public string CustomerId { get; set; }    
    public string CreatedDate { get; set; }   
    public string ModifiedBy { get; set; }  
    public string ModifiedDate { get; set; }  
    public string IsDeleted { get; set; }  
    public string DeletedBy { get; set; } 
    public string DeletedDate { get; set; } 
    }
    public class CustomerUpdateStatusModel
    {
        public int CustomerId { get; set; }
        public bool IsActive { get; set; }
        public string ModifiedBy { get; set; } 
    }
}
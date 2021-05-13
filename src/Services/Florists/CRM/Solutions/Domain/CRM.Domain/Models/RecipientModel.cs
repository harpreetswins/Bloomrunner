using System.ComponentModel.DataAnnotations;
using System;
namespace CRM.Domain.Models
{
    public class RecipientModel
    {
        public int FloristId { get; set; }
        public int CustomerId { get; set; }
        public string RecipientName { get; set; }
        public string RecipientEmail { get; set; }   
        public string RecipientMobileNo { get; set; }
        public int RecipientState { get; set; }
        public string RecipientCity { get; set; }   
        public string RecipientZipCode { get; set; }
        public int Relationship { get; set; }
        public string  RecipientAddress { get; set; }
        public string CreatedBy { get; set; }
    }

    public class RecipientDerivedModel : RecipientModel
    {
        public int RecipientId { get; set; }
        public string RelationshipName { get; set; }
    }

    public class SearchRecipient
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public int RecipientId { get; set; }
    }
    public class RecipientDeleteModel
    {
        public int RecipientId { get; set; }
        public int FloristId { get; set; }
        public int CustomerId { get; set; } 
        public string DeletedBy { get; set; } 
    }  
    public class RecipientUpdateModel
    {  
      public int RecipientId { get; set; }  
      public int CustomerId { get; set; }         
      public int FloristId { get; set; }  
      public string RecipientName { get; set; } 
      public string RecipientEmail { get; set; } 
      public string RecipientMobileNo { get; set; } 
      public int RecipientState { get; set; } 
      public string RecipientCity { get; set; } 
      public string RecipientZipCode { get; set; } 
      public int Relationship { get; set; }
      public string RecipientAddress { get; set; }
      public string ModifiedBy { get; set; }      
    }

    public class RecipientOrderModel
    {
      public int OrderId { get; set; } 
      public int OcassionId { get; set; } 
      public string Ocassion { get; set; }
      public string Subcription { get; set; }
      public int ArragementTypeId { get; set; }
      public string ArrangementType { get; set; }
      public int StyleOfArrangementId { get; set; }
      public string StyleOfArrangement { get; set; }
      public int MoodOfArrangementId { get; set; }
      public string MoodOfArrangement { get; set; }
      public string OrderDate { get; set; }
      public string OrderTotal { get; set; }      
    }
    public class RecipientOrderSerchModel
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]        
        public int RecipientId { get; set; }
    }

    public class RecipientUpdateStatusModel
    {
        public int RecipientId { get; set; }
        public bool IsActive { get; set; }
        public string ModifiedBy { get; set; } 
    }
    public class RecipientUpcommingOrderModel
    {
        public int FloristId { get; set; }
        public int CustomerId { get; set; }
        public int RecipientId { get; set; }
    }
    public class RecipientUpcommingOrderDrivedModel
    {
        public int OrderId { get; set; }
        public int FloristId { get; set; }
        public int CustomerId { get; set; }
        public int RecipientId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string RecipientName { get; set; }
        public int RelationId { get; set; }
        public string Relation { get; set; }
        public decimal OrderTotal { get; set; }
        public int Ocassion { get; set; }
        public string OcassionName { get; set; }
    }
}
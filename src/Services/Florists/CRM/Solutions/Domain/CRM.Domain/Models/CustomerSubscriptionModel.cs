using System;
using System.ComponentModel.DataAnnotations;

namespace CRM.Domain.Models
{
    public class CustomerSubscriptionModel
    {
        public int CustomerSubscriptionPlanId { get; set; }
        public int CustomerId { get; set; }
        public int RecipientId { get; set; }
        public string BillingType { get; set; }
        public string DeliveryType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Amount { get; set; }
        public string CreatedBy { get; set; }   
    }
      public class CustomerSubscriptionDerivedModel :CustomerSubscriptionModel
    {
        public int CustomerSubscriptionId { get; set; }     
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; } 
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; } 
        public DateTime DeletedDate { get; set; }
    }
    public class SearchCustomerSubscription
    {
        [Required]
        public int CustomerId { get; set; }

    }
     public class CustomerSubscriptionResponse
    {
        public string CustomerSubscriptionPlanName { get; set; }
        public int CustomerId { get; set; }
        public string BillingType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Amount { get; set; }
        public string CreatedBy { get; set; }   
    }
}
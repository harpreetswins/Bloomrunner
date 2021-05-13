using System;
using System.ComponentModel.DataAnnotations;
namespace CRM.Domain.Models
{
    public class CustomerSubscriptionPlanModel
    {
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public string PlanName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string BillingType { get; set; }
         public string BillingName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }  
        public int UpgradeToSizeId1 { get; set; }
        public string UpgradeToSizeIdName1 { get; set; }
        public decimal UpgradeToSizePrice1 { get; set; }
        public int UpgradeToSizeId2 { get; set; }
        public string UpgradeToSizeIdName2 { get; set; }
        public decimal UpgradeToSizePrice2 { get; set; }
        public int UpgradeToSizeId3 { get; set; }
        public string UpgradeToSizeIdName3 { get; set; }
         public decimal UpgradeToSizePrice3 { get; set; }
        public int UpgradeToSizeId4 { get; set; }
        public string UpgradeToSizeIdName4 { get; set; }
        public decimal UpgradeToSizePrice4 { get; set; }
        public int DeliveryOptionId { get; set; }
        public string DeliveryOptionIdName { get; set; }
        public int CustomDeliveries { get; set; }
        public decimal MonthlySaving { get; set; }
        public decimal AnnualSaving { get; set; }       
        public string CreatedBy { get; set; }     
    }
    public class CustomerSubscriptionPlanDerivedModel :CustomerSubscriptionPlanModel
    {
        public int CustomerSubscriptionPlanId { get; set; }
        public int Subscriber { get; set; }       
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; } 
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; } 
        public DateTime DeletedDate { get; set; }
    }
    public class SearchCustomerSubscriptionPlan
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int LocationId { get; set; }
        public int DeliveryOption { get; set; }
    }

    public class AddCustomerSubscriptionPlanModel
    {
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public string PlanName { get; set; }       
        public string Description { get; set; }        
        public int BillingType { get; set; }        
        public DateTime StartDate { get; set; }        
        public DateTime EndDate { get; set; }  
        public int UpgradeToSizeId1 { get; set; }
        public decimal UpgradeToSizePrice1 { get; set; }
        public int UpgradeToSizeId2 { get; set; }
        public decimal UpgradeToSizePrice2 { get; set; }
        public int UpgradeToSizeId3 { get; set; }
        public decimal UpgradeToSizePrice3 { get; set; }
        public int UpgradeToSizeId4 { get; set; }
        public decimal UpgradeToSizePrice4 { get; set; }
        public string CustomerSubscriptionPlanOption { get; set; }       
        public string CreatedBy { get; set; }
    }
    public class UpdateCustomerSubcriptionPlanModel
    {
        public int CustomerSubscriptionPlanId { get; set; }
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public string PlanName { get; set; }         
        public string Description { get; set; }        
        public int BillingType { get; set; }       
        public DateTime StartDate { get; set; }        
        public DateTime EndDate { get; set; }
        public int UpgradeToSizeId1 { get; set; }
        public decimal UpgradeToSizePrice1 { get; set; }
        public int UpgradeToSizeId2 { get; set; }
        public decimal UpgradeToSizePrice2 { get; set; }
        public int UpgradeToSizeId3 { get; set; }
        public decimal UpgradeToSizePrice3 { get; set; }
        public int UpgradeToSizeId4 { get; set; }
        public decimal UpgradeToSizePrice4 { get; set; }
        public bool IsActive { get; set; }
        public string ModifiedBy { get; set; }         
        public string CustomerSubscriptionOption { get; set; }    

    }

    public class DeleteCustomerSubcriptionPlanModel
    {
        public int CustomerSubscriptionPlanId { get; set; }
        public int FloristId { get; set; }
        public int LocationId { get; set; }        
       public string DeletedBy { get; set; }
    }

    public class CustomerSubscriptionPlanListModel
    {
        public int FloristId { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string SearchValue { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }
    public class CustomerSubscriptionPlanListDrivedModel
    {
        public int CustomerSubscriptionPlanId { get; set; }       
        public string PlanName { get; set; }
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public string Description { get; set; }
         public int BillingType { get; set; }
        public string billingName { get; set; }       
        public int Subscriber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UpgradeToSizeId1 { get; set; }
        public string UpgradeToSizeIdName1 { get; set; }
        public decimal UpgradeToSizePrice1 { get; set; }
        public int UpgradeToSizeId2 { get; set; }
        public string UpgradeToSizeIdName2 { get; set; }
        public decimal UpgradeToSizePrice2 { get; set; }
        public int UpgradeToSizeId3 { get; set; }
        public string UpgradeToSizeIdName3 { get; set; }
         public decimal UpgradeToSizePrice3 { get; set; }
        public int UpgradeToSizeId4 { get; set; }
        public string UpgradeToSizeIdName4 { get; set; }
        public decimal UpgradeToSizePrice4 { get; set; }
        public int DeliveryOptionId { get; set; }
        public string DeliveryOptionIdName { get; set; }
        public int CustomDeliveries { get; set; }
        public decimal MonthlySaving { get; set; }
        public decimal AnnualSaving { get; set; }
        public int TotalRows { get; set; }
        public bool IsActive { get; set; }  
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; } 
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; } 
        public DateTime DeletedDate { get; set; }      
    }

    public class CustomerSubscriptionPlansUpdateStatusModel
    {
        public int CustomerSubscriptionPlanId { get; set; }
        public bool IsActive { get; set; }
        public string ModifiedBy { get; set; }
    }

    public class CustomerSubscriptionPlansByIdModel
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int CustomerSubscriptionPlanId { get; set; }      
    }
    public class CustomerSubscriptionPlanbyIdDrivedModel
    {
        public int CustomerSubscriptionPlanId { get; set; }       
        public string PlanName { get; set; }
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public string Description { get; set; }
         public int BillingType { get; set; }
        public string billingName { get; set; }       
        public int Subscriber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UpgradeToSizeId1 { get; set; }
        public string UpgradeToSizeIdName1 { get; set; }
        public decimal UpgradeToSizePrice1 { get; set; }
        public int UpgradeToSizeId2 { get; set; }
        public string UpgradeToSizeIdName2 { get; set; }
        public decimal UpgradeToSizePrice2 { get; set; }
        public int UpgradeToSizeId3 { get; set; }
        public string UpgradeToSizeIdName3 { get; set; }
         public decimal UpgradeToSizePrice3 { get; set; }
        public int UpgradeToSizeId4 { get; set; }
        public string UpgradeToSizeIdName4 { get; set; }
        public decimal UpgradeToSizePrice4 { get; set; }
       // public int DeliveryOptionId { get; set; }
        //public string DeliveryOptionIdName { get; set; }
       // public int CustomDeliveries { get; set; }
        //public decimal MonthlySaving { get; set; }
       // public decimal AnnualSaving { get; set; }
        //public int TotalRows { get; set; }
        public string CustomerSubscriptionPlanOption { get; set; }
        public bool IsActive { get; set; }  
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; } 
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; } 
        public DateTime DeletedDate { get; set; }      
    }    
    
}
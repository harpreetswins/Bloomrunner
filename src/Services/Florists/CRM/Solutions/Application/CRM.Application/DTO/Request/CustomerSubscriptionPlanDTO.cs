using System;
using System.Collections.Generic;

namespace CRM.Application.DTO.Request
{
    public class CustomerSubscriptionPlanDTO
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
        public List<CustomerSubscriptionPlanOptionDTO> CustomerSubscriptionPlanOption { get; set; }
        public string CreatedBy { get; set; }
    }
    public class UpdateCustomerSubscriptionPlanDTO
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
        public List<CustomerSubscriptionOptionDTO> CustomerSubscriptionOption { get; set; }
    }
    public class DeleteCustomerSubscriptionPlanDTO
    {
        public int CustomerSubscriptionPlanId { get; set; }
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public string DeletedBy { get; set; }
    }
    public class CustomerSubscriptionPlansUpdateStatusDTO
    {
        public int CustomerSubscriptionPlanId { get; set; }
        public bool IsActive { get; set; }
        public string ModifiedBy { get; set; }
    }
    public class CustomerSubscriptionPlanOptionDTO
    {
        public int DeliveryOptionId { get; set; }
        public string CustomDeliveries { get; set; }
        public decimal MonthlySaving { get; set; }
        public decimal AnnualSaving { get; set; }
    }
    public class CustomerSubscriptionOptionDTO
    {
        public int CustomerSubscriptionPlanOptionId { get; set; }
        public int DeliveryOptionId { get; set; }
        public int CustomDeliveries { get; set; }
        public decimal MonthlySaving { get; set; }
        public decimal AnnualSaving { get; set; }
    }
}
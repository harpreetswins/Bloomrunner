using System;

namespace CRM.Domain.Models
{
    public class SubscriptionPlanListModel
    {
        public int CustomerId { get; set; }
        public int FloristId { get; set; }
        public string CustomerName { get; set; }
        public string RecipientName { get; set; }
        public int CustomerSubscriptionPlanId { get; set; }
        public string PlanName { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Amount { get; set; }
        public string BillingType { get; set; }
        public string DeliveryType { get; set; }
        public string TotalOrders { get; set; }
        public string  HistoricalOrder { get; set; }
        public bool IsActive { get; set; }
        public int TotalRows { get; set; }
    }

    public class SearchSubscriptionPlanList
    {
        public int FloristId { get; set; }

        public int PageNo { get; set; }

        public int PageSize { get; set; }

        public string SearchValue { get; set; }

        public string SortColumn { get; set; }

        public string SortOrder { get; set; }
    }
    
}


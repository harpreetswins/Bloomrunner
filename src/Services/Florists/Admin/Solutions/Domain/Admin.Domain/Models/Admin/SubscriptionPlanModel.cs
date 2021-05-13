namespace Admin.Domain.Models.Admin
{
    public class SubscriptionPlanModel
    {
        public int SubscriptionPlanId { get; set; }
        public string SubscriptionPlanName { get; set; }
        public bool DeliveryApp { get; set; }
        public bool Website { get; set; }
        public bool SalesWidgets { get; set; }
        public bool EmailPackage { get; set; }
        public bool SMSPackage { get; set; }
        public bool MarketingCampaign { get; set; }
    }
    
}
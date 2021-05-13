namespace Admin.Domain.Models.Admin
{
    public class AdminModel
    {
        public string FloristName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public int FloristStateId { get; set; }
        public string StateName { get; set; }
        public string FloristCity { get; set; }
        public string FloristZipCode { get; set; }
        public int NoOfLocations { get; set; }
        public string FloristAddress { get; set; }
        public string OwnerName { get; set; }
        public string FloristDescription { get; set; }
        public string OwnerPosition { get; set; }
        public string DeliveryPolicy { get; set; }
        public string SubstitutionPolicy { get; set; }
        public string DeliveryInformation { get; set; }
        public string FacebookUrl { get; set; }
        public string FacebookPublicKey { get; set; }
        public string FacebookSecretKey { get; set; }
        public string InstagramUrl { get; set; }
        public string InstagramPublicKey { get; set; }
        public string InstagramSecretKey { get; set; }
        public int BillingMethod { get; set; }
        public string AccountName { get; set; }
        public string AccountEmailId { get; set; }
        public string BillingCity { get; set; }
        public string BillingZipCode { get; set; }
        public string BillingAddress { get; set; }
        public decimal TaxRate { get; set; }
        public int SubscriptionPlanId { get; set; }
        public string SubscriptionPlanName { get; set; }
        public bool IsArtist { get; set; }
        public string CreatedBy { get; set; }
        public string MetaDescription { get; set; }

        /******************* Collections ******************/
        public string FloristMetaKeywords { get; set; }
        public string Locations { get; set; }
        public string FloristLocation { get; set; }
        public string DeliveryTimings { get; set; }
        public string Artists { get; set; }
        public string ShopTimings { get; set; }
        public string HolidaysShopTimings { get; set; }
        public string FloristSettings { get; set; }
    }

    /******************* This Class is Used to Get the Florist ******************/

    public class AdminModelDerived : AdminModel
    {
        public int FloristId { get; set; }
        public bool DeliveryApp { get; set; }
        public bool Website { get; set; }
        public bool SalesWidgets { get; set; }
        public bool SMSPackage { get; set; }
        public bool EmailPackage { get; set; }
        public bool MarketingCampaign { get; set; }
        public string MetaKeywords { get; set; }
    }
    public class GetFloristTexRateModel
    {
        public int FloristId { get; set; }
    }
    public class GetFloristTexRateDrivedModel
    {
        public decimal TaxRate { get; set; }
    }
    public class GetFloristModel
    {
        public int FloristId { get; set; }
        public int LocationId { get; set; }
    }
}

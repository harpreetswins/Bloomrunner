using System;
using System.Collections.Generic;
using System.Text;

namespace Admin.Application.DTO.Request
{
    public class AdminUpdateDTO 
    {
        public int FloristId { get; set; } 
        public int LocationId { get; set; }
        public int DeliverySetupId { get; set; }
        public int ShopTimingId { get; set; }
        public int ArtistId { get; set; }
        public int FloristSettingId { get; set; }
        public string FloristName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public int FloristStateId { get; set; }
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
        public bool IsArtist { get; set; }
        public string ModifiedBy { get; set; }

        // navigation properties
        public string MetaDescription { get; set; }
        public List<FloristMetaKeyword> FloristMetaKeywords { get; set; }
        public List<Locations> Locations { get; set; }     
        public List<DeliveryTimings> DeliveryTimings { get; set; }  
        public List<Artists> Artists { get; set; }        
        public List<ShopTimings> ShopTimings { get; set; } 
        public List<HolidaysShopTimings> HolidaysShopTimings { get; set; } 
        public List<FloristSettings> FloristSettings { get; set; }

    }

    public class FloristMetaKeyword : FloristMetaKeywordDTO
    {
    }

    public class FloristSettings : FloristSettingsDTO
    {
        
    }

    public class Locations : LocationsDTO
    {
        
    }

    public class DeliveryTimings : DeliveryTimingsDTO
    {
              
    }

    public class Artists : ArtistsDTO
    {
                
    }
    public class ShopTimings : ShopTimingsDTO
    {
       
    }

    public class Timings : TimingsDTO
    {

    }
    public class HolidaysShopTimings : HolidaysShopTimingsDTO
    {

    }
}
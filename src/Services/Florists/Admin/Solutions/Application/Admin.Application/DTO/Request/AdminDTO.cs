using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Admin.Application.DTO.Request
{
    public class AdminDTO
    {
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
        public string CreatedBy { get; set; }

        // navigation properties
        public string MetaDescription { get; set; }
        public List<FloristMetaKeywordDTO> FloristMetaKeywords { get; set; }
        public List<LocationsDTO> Locations { get; set; }
        public List<DeliveryTimingsDTO> DeliveryTimings { get; set; }
        public List<ArtistsDTO> Artists { get; set; }
        public List<ShopTimingsDTO> ShopTimings { get; set; }
        public List<HolidaysShopTimingsDTO> HolidaysShopTimings { get; set; }
        public List<FloristSettingsDTO> FloristSettings { get; set; }
    }

    public class FloristSettingsDTO
    {
        public bool EmailSetting { get; set; }
        public bool SMSSetting { get; set; }
        public bool FacebookSetting { get; set; }
        public bool InstagramSetting { get; set; }
    }

    public class FloristMetaKeywordDTO
    {
        [JsonProperty("tagName")]
        public string TagName { get; set; }
    }
    public class LocationsDTO
    {
        public string ShopName { get; set; }
        public string ShopEmail { get; set; }
        public string ShopContactNo { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string StreetAddress { get; set; }
        public string ShopDescription { get; set; }
        public string AboutShop { get; set; }
    }

    public class DeliveryTimingsDTO
    {
        public string ZoneName { get; set; }
        public List<ZipCodes> ZipCodes { get; set; }
        public string MaxTimeSlotDeliveries { get; set; }
        public decimal Cost { get; set; }
    }

    public class ZipCodes
    {
        [JsonProperty("postalCodes")]
        public string PostalCodes { get; set; }
    }

    public class ArtistsDTO
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string YearsOfExperience { get; set; }
        public List<FavouriteStylesDTO> Styles { get; set; }
        public string About { get; set; }
    }

    public class ShopTimingsDTO
    {
        public string DaysName { get; set; }
        public bool IsClosed { get; set; }
        public List<TimingsDTO> Timings { get; set; }
    }

    public class TimingsDTO
    {
        public List<DeliveryTypeDTO> DeliveryType { get; set; }
        [JsonProperty("timingsId")]
        public int TimingsId { get; set; }
        [JsonProperty("slots")]
        public string Slots { get; set; }
    }

    public class DeliveryTypeDTO
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class HolidaysShopTimingsDTO : ShopTimingsDTO
    {
        public DateTime HolidayDate { get; set; }
        public string HolidayName { get; set; }

    }
}
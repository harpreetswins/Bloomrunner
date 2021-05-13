using System;
using System.Collections.Generic;
using System.Text;

namespace Admin.Application.DTO.Response
{
    public class AdminVM
    {
        public int FloristId { get; set; }
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
        public string FloristPosition { get; set; }
        public string DeliveryPolicy { get; set; }
        public string SubstitutionPolicy { get; set; }
        public string DeliveryInformation { get; set; }
        public string FacebookUrl { get; set; }
        public string FacebookPublicKey { get; set; }
        public string FacebookSecretKey { get; set; }
        public string InstagramUrl { get; set; }
        public string InstagramPublicKey { get; set; } 
        public string InstagramSecretKey { get; set; } 
        public string CardHolderName { get; set; }
        public string CardNo { get; set; }
        public int CardExpMonth { get; set; } 
        public int CardExpYear { get; set; }
        public string CVVNo { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public int SubscriptionPlanId { get; set; }        
        public string SubscriptionType { get; set; }
        public string Billing { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public bool IsArtist { get; set; }
        public bool IsHoliday { get; set; }
        public string FloristMetaKeywords { get; set; }
        public string FloristTags { get; set; }

        public IEnumerable<FloristLocationResponse> FloristLocation {get;set;}
        public IEnumerable<LocationsResponse> Locations {get;set;}
        public IEnumerable<DeliveryTimingsResponse> DeliveryTimings {get;set;}
    }

    public class DeliveryTimingsResponse
    {
        public string ZoneSetting { get; set; }
    }

    public class LocationsResponse
    {
        public string ShopName { get; set; }
        public string ZipCode { get; set; }
        public string StreetAddress { get; set; }
        public int StateId { get; set;}
        public string City { get; set; }
    }

    public class FloristLocationResponse
    {
        public int LocationId { get; set; }
        public int FloristId { get; set; }
        public string ShopName { get; set; }
        public string ServiceArea { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string StreetAddress { get; set; }
        public string About { get; set; }
        public int ArtistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearsOfExperience { get; set; }
        public string FavouriteStyles { get; set; }
        public string ZoneName { get; set; }
        public string ZipCodes { get; set; }
        public int MaxTimeSlotDeliveries { get; set; }
        public decimal Cost { get; set; }
        public int SubscriptionPlanId { get; set; }
        public string SubscriptionPlanName { get; set; }
        public string StateName { get; set; }
    }
}
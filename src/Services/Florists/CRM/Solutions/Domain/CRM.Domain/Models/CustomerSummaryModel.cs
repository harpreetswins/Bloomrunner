using System;
using System.ComponentModel.DataAnnotations;

namespace CRM.Domain.Models
{
    public class CustomerSummaryModel
    {
        public string CustomerId { get; set; } 
        public string CustomerFirstName { get; set; }
        public string CustomerEmail { get; set; }
        public int Gender { get; set; }
        public int MaritalStatus { get; set; }
        public string CustomerMobileNo { get; set; }
       
        public string CustomerZipCode { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime? LastConnectDate { get; set; }
        public DateTime? LastPurchaseDate { get; set; }
        public string CreatedDate { get; set; }     
    }

    public class SearchCustomerSummary
    {
        public string CustomerId { get; set; } 
    }

    public class CustomerLifeTimeModel
    {
       public string SpendingYear { get; set; }
       public string SpendingMonth { get; set; }
       public string AverageSpending { get; set; }
       public decimal OrderAmount { get; set; }
       public decimal CustomerOrderAmount { get; set; }
    }

    public class SearchCustomerLTV
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public DateTime? InputDate { get; set; }
    }

     public class CustomerSummaryResponse
    {
        public string CustomerId { get; set; } 
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public int GenderId { get; set; }
        public int MaritalStatusId { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }   
        public string CustomerMobileNo { get; set; }  
        public int CustomerStateId { get; set; }
        public string CustomerState { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime? LastConnectDate { get; set; }
        public DateTime? LastPurchaseDate { get; set; }
        public string CreatedDate { get; set; }     
    }



}
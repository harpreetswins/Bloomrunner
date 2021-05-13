using System;
using System.ComponentModel.DataAnnotations;

namespace CRM.Domain.Models
{
    public class DiscountModel
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public string DiscountCode { get; set; }
        [Required]
        public int DiscountType { get; set; }
        [Required]
        public decimal DiscountAmount { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public int Priorty { get; set; }
        public bool DiscountCombined { get; set; }
        public bool ShowOnHomePage { get; set; }
        [Required]
        public int MaximumNumberPerCustomer { get; set; }
        [Required]
        public int MaximumNumberOverAll { get; set; }
        public string DiscountRange { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public string CreatedBy { get; set; }
    }
    public class DiscountDerivedModel:DiscountModel
    {
        [Required]
        public int DiscountId { get; set; }
    }
     public class DiscountResponseModel
    {
        public int DiscountId { get; set; }
        public int FloristId { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountTypeId { get; set; }
        public string DiscountType { get; set; }
        public decimal DiscountAmount { get; set; }
        public string DiscountRange { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Priorty { get; set; }
        public bool DiscountCombined { get; set; }
        public bool ShowOnHomePage { get; set; }
        public int MaximumNumberPerCustomer { get; set; }
        public int MaximumNumberOverAll { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class SearchDiscountModel
    {
        [Required]
        public int FloristId { get; set; }
        public int DiscountId { get; set; }
    }
    public class DiscountGridModel
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int PageNo { get; set; }
        [Required]
        public int PageSize { get; set; }
        public string SearchValue { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }
    public class DiscountGridResponse
    {
        public int DiscountId { get; set; }
        public int FloristId { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountTypeId { get; set; }
        public string DiscountType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal DiscountAmount { get; set; }
        public int Availed { get; set; }
        public bool IsActive { get; set; }
        public int TotalRows { get; set; }
    }
    public class DiscountUpdateModel
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int DiscountId { get; set; }
        [Required]
        public string DiscountCode { get; set; }
        [Required]
        public int DiscountType { get; set; }
        [Required]
        public decimal DiscountAmount { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public int Priorty { get; set; }
        public bool DiscountCombined { get; set; }
        public bool ShowOnHomePage { get; set; }
        [Required]
        public int MaximumNumberPerCustomer { get; set; }
        [Required]
        public int MaximumNumberOverAll { get; set; }
        public string DiscountRange { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
    }
    public class DiscountDeleteModel
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int DiscountId { get; set; }
        [Required]
        public string DeletedBy { get; set; }
    }
    public class DiscountUpdateStatusModel
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int DiscountId { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
    }
}
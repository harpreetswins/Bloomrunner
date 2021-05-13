using System;
using System.Collections.Generic;

namespace CRM.Application.DTO.Request
{
    public class DiscountDTO
    {
        public int FloristId { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountType { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Priorty { get; set; }
        public bool DiscountCombined { get; set; }
        public bool ShowOnHomePage { get; set; }
        public int MaximumNumberPerCustomer { get; set; }
        public int MaximumNumberOverAll { get; set; }
        public List<DiscountRanges> DiscountRange { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
    }
    public class DiscountRanges
    {
        public int MinimumQuantity { get; set; }
        public int MaximumQuantity { get; set; }
        public decimal DiscountAmount { get; set; }
    }
    public class DiscountUpdateDTO
    {
        public int FloristId { get; set; }
        public int DiscountId { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountType { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Priorty { get; set; }
        public bool DiscountCombined { get; set; }
        public bool ShowOnHomePage { get; set; }
        public int MaximumNumberPerCustomer { get; set; }
        public int MaximumNumberOverAll { get; set; }
        public List<DiscountUpdateRanges> DiscountRange { get; set; }
        public bool IsActive { get; set; }
        public string ModifiedBy { get; set; }
    }
    public class DiscountUpdateRanges
    {
        public int DiscountRangeId { get; set; }
        public int MinimumQuantity { get; set; }
        public int MaximumQuantity { get; set; }
        public decimal DiscountAmount { get; set; }
    }
}
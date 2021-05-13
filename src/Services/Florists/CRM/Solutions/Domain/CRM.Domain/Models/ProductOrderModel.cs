using System;
using System.ComponentModel.DataAnnotations;

namespace CRM.Domain.Models
{
    public class ProductOrderModel
    {
        public int FloristId { get; set; }
        public int LocationId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public decimal OrderTotal { get; set; }
    }
    public class SearchProductOrders
    {
        [Required]
        public int FloristId { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public int ProductId { get; set; }
    }
}
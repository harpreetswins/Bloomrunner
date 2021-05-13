using System;

namespace CRM.Domain.Models
{
    public class UpcomingOrderModel
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int RecipientId { get; set; }
        public string Occassion { get; set; }
        public string Relation { get; set; }
        public decimal Price { get; set; }
        public DateTime? OrderDate { get; set; }
        public string RecipientName { get; set; }

    }
}
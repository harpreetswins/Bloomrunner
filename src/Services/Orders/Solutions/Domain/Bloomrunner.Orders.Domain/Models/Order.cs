using System;
using System.Collections.Generic;
using System.Text;

namespace Bloomrunner.Orders.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string FlowerType { get; set; }
        public DateTime OrderDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Bloomrunner.Orders.Application.DTO.Response
{
    public interface OrderVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string FlowerType { get; set; }
        public DateTime OrderDate { get; set; }
    }
}

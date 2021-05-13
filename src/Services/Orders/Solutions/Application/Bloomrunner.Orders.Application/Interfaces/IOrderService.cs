using Bloomrunner.Orders.Application.DTO.Response;
using Bloomrunner.Orders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bloomrunner.Orders.Application.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetOrders();
    }
}

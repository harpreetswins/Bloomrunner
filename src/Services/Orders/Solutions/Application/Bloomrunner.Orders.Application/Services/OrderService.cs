using Bloomrunner.Orders.Application.DTO.Response;
using Bloomrunner.Orders.Application.Interfaces;
using Bloomrunner.Orders.Domain.Interfaces;
using Bloomrunner.Orders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bloomrunner.Orders.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<IEnumerable<Order>> GetOrders()
        {
            return await this._orderRepository.GetOrders();
        }
    }
}

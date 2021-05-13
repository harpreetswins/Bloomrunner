using Bloomrunner.Orders.Domain.Interfaces;
using Bloomrunner.Orders.Domain.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Data.Repository
{
    public class OrderRepository : GenericRepository.GenericRepository, IOrderRepository
    {
        public OrderRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public async void Add(Order order)
        {
            await Command<Order>("AddOrder", order);
        }

        public async Task<IEnumerable<Order>> GetOrders()
        {
            return await Query<Order>("GetFlorists");
        }
    }
}

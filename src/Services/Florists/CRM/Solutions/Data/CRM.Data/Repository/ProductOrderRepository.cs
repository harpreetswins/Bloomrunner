using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class ProductOrderRepository : GenericRepository, IProductOrderRepository
    {
        public ProductOrderRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task<IEnumerable<ProductOrderModel>> GetProductOrders(SearchProductOrders searchProductOrders)
        {
            return await Query<ProductOrderModel>("Crm.GetOrderDetailsForProduct", searchProductOrders);
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class ProductOrderService : IProductOrderService
    {
        private readonly IProductOrderRepository _productOrderRepository;

        public ProductOrderService(IProductOrderRepository productOrderRepository)
        {
            _productOrderRepository = productOrderRepository;
        }

        public async Task<IEnumerable<ProductOrderModel>> GetProductOrders(SearchProductOrders searchProductOrders)
        {
            return await _productOrderRepository.GetProductOrders(searchProductOrders);
        }
    }
}
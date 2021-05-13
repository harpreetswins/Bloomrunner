using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;

namespace CRM.Application.Interfaces
{
    public interface IProductOrderService
    {
        Task<IEnumerable<ProductOrderModel>> GetProductOrders(SearchProductOrders searchProductOrders);
    }
}
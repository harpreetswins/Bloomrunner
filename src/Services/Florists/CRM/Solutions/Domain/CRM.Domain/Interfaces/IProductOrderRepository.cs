using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;

namespace CRM.Domain.Interfaces
{
    public interface IProductOrderRepository
    {
         Task<IEnumerable<ProductOrderModel>> GetProductOrders(SearchProductOrders searchProductOrders);
    }
}
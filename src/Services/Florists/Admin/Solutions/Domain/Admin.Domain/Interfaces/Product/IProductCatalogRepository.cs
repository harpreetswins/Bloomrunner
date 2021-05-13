using System;
using Admin.Domain.Models;
using Admin.Domain.Models.Product;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Admin.Domain.Interfaces.Product
{
    public interface IProductCatalogRepository
    {
        Task<IEnumerable<ProductCatalogModel>> GetProductCatalog(SearchProductCatalogList searchProductCatalogList);
        Task<CommonResponse> AddProductCatalog(AddProductCatalog addProductCatalog);
        Task<CommonResponse> DeleteProductCatalog(DeleteProductCatalog deleteProductCatalog);
        Task<CommonResponse> UpdateProductCatalog(UpdateProductCatalog  updateProductCatalog );
    }
}
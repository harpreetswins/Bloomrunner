using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models;
using Admin.Application.DTO.Request;
using Admin.Domain.Models.Product;
using System;
using System.Text;
namespace Admin.Application.Interfaces.Product
{
    public interface IProductCatalogService
    {
        Task<IEnumerable<ProductCatalogModel>> GetProductCatalog(SearchProductCatalogList searchProductCatalogList);
        Task<CommonResponse> AddProductCatalog(AddProductCatalog addProductCatalog);
        Task<CommonResponse> DeleteProductCatalog(DeleteProductCatalog deleteProductCatalog);
        Task<CommonResponse> UpdateProductCatalog(UpdateProductCatalog  updateProductCatalog);
    }
}
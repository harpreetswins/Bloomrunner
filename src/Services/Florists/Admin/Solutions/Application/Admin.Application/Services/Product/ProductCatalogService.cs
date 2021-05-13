using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Application.Interfaces;
using Admin.Application.Interfaces.Product;
using Admin.Domain.Interfaces;
using Admin.Domain.Interfaces.Product;
using Admin.Domain.Models;
using Admin.Domain.Models.Product;

namespace Admin.Application.Services.Product
{
    public class ProductCatalogService : IProductCatalogService
    {
        private readonly IProductCatalogRepository _productCatalogRepository;

        public ProductCatalogService(IProductCatalogRepository productCatalogRepository)
        {
            _productCatalogRepository = productCatalogRepository;
        }
        public async Task<CommonResponse> AddProductCatalog(AddProductCatalog addProductCatalog)
        {
            return await _productCatalogRepository.AddProductCatalog(addProductCatalog);
        }
        public async Task<CommonResponse> DeleteProductCatalog(DeleteProductCatalog deleteProductCatalog)
        {
            return await _productCatalogRepository.DeleteProductCatalog(deleteProductCatalog);
        }
        public async Task<CommonResponse> UpdateProductCatalog(UpdateProductCatalog updateProductCatalog)
        {
            return await _productCatalogRepository.UpdateProductCatalog(updateProductCatalog);
        }
        public async Task<IEnumerable<ProductCatalogModel>> GetProductCatalog(SearchProductCatalogList searchProductCatalogList)
        {
            return await _productCatalogRepository.GetProductCatalog(searchProductCatalogList);
        }
    }
}
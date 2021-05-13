using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Admin.Domain.Models.Product;
using Admin.Domain.Interfaces.Product;
using Admin.Domain.Models;


namespace Admin.Data.GenericRepository
{
    public class ProductCatalogRepository: GenericRepository, IProductCatalogRepository
    {
        public ProductCatalogRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<ProductCatalogModel>> GetProductCatalog(SearchProductCatalogList searchProductCatalogList)
        {
            return await Query<ProductCatalogModel>("Pdt.GetProductCatalogList", searchProductCatalogList);
        }
        public async Task<CommonResponse> DeleteProductCatalog(DeleteProductCatalog globalCodeDeleteModel)
        {
            return await ExecuteAll<CommonResponse>("Pdt.DeleteProductCatalog", globalCodeDeleteModel);
        }
        public async Task<CommonResponse> AddProductCatalog(AddProductCatalog addProductCatalog)
        {
            return await ExecuteAll<CommonResponse>("Pdt.AddProductCatalog", addProductCatalog);
        }
        public async Task<CommonResponse> UpdateProductCatalog(UpdateProductCatalog updateProductCatalog)
        {
            return await ExecuteAll<CommonResponse>("Pdt.UpdateProductCatalog", updateProductCatalog);
        }
    }
}
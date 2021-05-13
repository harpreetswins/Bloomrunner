using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models.Product;
using Microsoft.Extensions.Configuration;
using Admin.Domain.Interfaces.Product;
using Admin.Domain.Models;

namespace Admin.Data.GenericRepository
{
    public class ProductRepository : GenericRepository, IProductRepository
    {
        public ProductRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<ProductModelDerived>> GetProducts(FloProductId floProduct)
        {
            return await Query<ProductModelDerived>("Pdt.GetProducts", floProduct);
        }
        public async Task<CommonResponse> AddProduct(ProductModel product)
        {
            return await ExecuteAll<CommonResponse>("Pdt.AddProducts", product);
        }
        public async Task<int> UpdateProductStatus(UpdateProduct updateProduct)
        {
            return await Command<UpdateProduct>("Pdt.UpdateProductStatus", updateProduct);
        }
        public async Task<int> DeleteProduct(DeleteProduct deleteProduct)
        {
            return await Command<DeleteProduct>("Pdt.DeleteProduct", deleteProduct);
        }
        public async Task<IEnumerable<ProdcutSearchModel>> GetProductAddOnslists(ProdcutSearch prodcutSearch)
        {
            return await Query<ProdcutSearchModel>("Pdt.SearchProducts", prodcutSearch);
        }
        public async Task<IEnumerable<ProductGridModel>> GetProductGridlists(SearchProductGrid searchProductGrid)
        {
            return await Query<ProductGridModel>("Pdt.GetProductList", searchProductGrid);
        }
        public async Task<CommonResponse> CheckProductExist(CheckProductNameModel checkProductNameModel)
        {
            return await ExecuteAll<CommonResponse>("Pdt.CheckProductsExist", checkProductNameModel);
        }
    }
}
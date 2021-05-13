using Admin.Domain.Models;
using Admin.Domain.Models.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Domain.Interfaces.Product
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductModelDerived>> GetProducts(FloProductId floProduct);
        //Task<int> AddProduct(ProductModel product);
        Task<CommonResponse> AddProduct(ProductModel product);
        Task<int> UpdateProductStatus(UpdateProduct updateProduct);
        Task<int> DeleteProduct(DeleteProduct deleteProduct);
        Task<IEnumerable<ProdcutSearchModel>> GetProductAddOnslists(ProdcutSearch prodcutSearch);                      // Product AddOns
        Task<IEnumerable<ProductGridModel>> GetProductGridlists(SearchProductGrid searchProductGrid);                  // ProductGrid -Sorting
        Task<CommonResponse> CheckProductExist(CheckProductNameModel checkProductNameModel);                                         // Product Name Exists or Not Exists

    }
}
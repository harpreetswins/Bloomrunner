using Admin.Application.DTO.Request;
using Admin.Domain.Models;
using Admin.Domain.Models.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Application.Interfaces.Product
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModelDerived>> GetProducts(FloProductId floProduct);
        Task<CommonResponse> AddProduct(ProductModel product);
        Task<int> UpdateProductStatus(UpdateProduct updateProduct);
        Task<int> DeleteProduct(DeleteProduct deleteProduct);
        Task<IEnumerable<ProdcutSearchModel>> GetProductAddOnslists(ProdcutSearch prodcutSearch);
        Task<IEnumerable<ProductGridModel>> GetProductGridlists(SearchProductGrid searchProductGrid);
        Task<CommonResponse> CheckProductExist(CheckProductNameModel checkProductNameModel);
    }
}
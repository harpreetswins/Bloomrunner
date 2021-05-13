using Admin.Application.DTO.Request;
using Admin.Application.Interfaces.Product;
using Admin.Domain.Interfaces;
using Admin.Domain.Interfaces.Product;
using Admin.Domain.Models;
using Admin.Domain.Models.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Admin.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
          this._productRepository=productRepository;
        }
        public async Task<CommonResponse> AddProduct(ProductModel product)
        {
            return await _productRepository.AddProduct(product);
        }
        public async Task<IEnumerable<ProductModelDerived>> GetProducts(FloProductId floProduct)
        {
           return await _productRepository.GetProducts(floProduct);
        }
        public async Task<int> UpdateProductStatus(UpdateProduct updateProduct)
        {
            return await _productRepository.UpdateProductStatus(updateProduct);
        }
        public async Task<int> DeleteProduct(DeleteProduct deleteProduct)
        {
            return await _productRepository.DeleteProduct(deleteProduct);
        }
        public async Task<IEnumerable<ProdcutSearchModel>> GetProductAddOnslists(ProdcutSearch prodcutSearch)
        {
            return await _productRepository.GetProductAddOnslists(prodcutSearch);
        }
        public async Task<IEnumerable<ProductGridModel>> GetProductGridlists(SearchProductGrid searchProductGrid)
        {
            return await _productRepository.GetProductGridlists(searchProductGrid);
        }
        public async Task<CommonResponse> CheckProductExist(CheckProductNameModel checkProductNameModel)
        {
            return await _productRepository.CheckProductExist(checkProductNameModel);
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class SearchProductsByTagsService : ISearchProductsByTagService
    {
        private readonly ISearchProductsByTagsRepository _iSearchProductsByTagsRepository;
        public SearchProductsByTagsService(ISearchProductsByTagsRepository iSearchProductsByTagsRepository)
        {
            _iSearchProductsByTagsRepository = iSearchProductsByTagsRepository;
        }

        public async Task<IEnumerable<ProductCatalogResponse>> GetCatalogProducts(ProductCatalogModel productCatalogModel)
        {
            return await _iSearchProductsByTagsRepository.GetCatalogProducts(productCatalogModel);
        }

        public async Task<IEnumerable<SearchProductsByTagsModel>> GetSearchProductsByTags(SearchProductsByTagsSearchModel searchProductsByTagsSearchModel)
        {
            return await _iSearchProductsByTagsRepository.GetSearchProductsByTags(searchProductsByTagsSearchModel);
        }
    }
}
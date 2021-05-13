using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class SearchProductsByTagsRepository : GenericRepository, ISearchProductsByTagsRepository
    {
        public SearchProductsByTagsRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task<IEnumerable<ProductCatalogResponse>> GetCatalogProducts(ProductCatalogModel productCatalogModel)
        {
            return await Query<ProductCatalogResponse>("Crm.GetCatalogProducts",productCatalogModel);
        }

        public async Task<IEnumerable<SearchProductsByTagsModel>> GetSearchProductsByTags(SearchProductsByTagsSearchModel searchProductsByTagsSearchModel)
        {
            return await Query<SearchProductsByTagsModel>("Pdt.SearchProductsByTags", searchProductsByTagsSearchModel);
        }
    }
}
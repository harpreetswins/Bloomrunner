using CRM.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM.Application.Interfaces
{
    public interface ISearchProductsByTagService
    {
          Task<IEnumerable<SearchProductsByTagsModel>> GetSearchProductsByTags (SearchProductsByTagsSearchModel searchProductsByTagsSearchModel);
          Task<IEnumerable<ProductCatalogResponse>> GetCatalogProducts (ProductCatalogModel productCatalogModel);
    }
}
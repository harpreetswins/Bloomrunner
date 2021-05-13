using System;
using CRM.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CRM.Domain.Interfaces
{
    public interface ISearchProductsByTagsRepository
    {
          Task<IEnumerable<SearchProductsByTagsModel>> GetSearchProductsByTags (SearchProductsByTagsSearchModel searchProductsByTagsSearchModel);
          Task<IEnumerable<ProductCatalogResponse>> GetCatalogProducts (ProductCatalogModel productCatalogModel);
    }
}
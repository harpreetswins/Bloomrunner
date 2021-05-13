using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models.Admin;

namespace Admin.Domain.Interfaces
{
    public interface ITagCollectionRepository
    {
        Task<IEnumerable<TagCollectionModel>> GetTagCollectionList();
        Task<IEnumerable<TagCollectionModel>> GetTagCollectionList(string TagCollectionName);
        Task<IEnumerable<TagGridListDrivedModel>> GetTagGridLists(TagGridListModel tagGridListModel);
        Task<IEnumerable<TagCollectionGridResponse>> GetTagCollectionGridLists(TagCollectionGridModel tagCollectionGridModel);
    }
}
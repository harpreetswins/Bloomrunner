using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Interfaces;
using Admin.Domain.Models.Admin;
using Microsoft.Extensions.Configuration;

namespace Admin.Data.GenericRepository
{
    public class TagCollectionRepository : GenericRepository, ITagCollectionRepository
    {
        public TagCollectionRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<TagCollectionGridResponse>> GetTagCollectionGridLists(TagCollectionGridModel tagCollectionGridModel)
        {
            return await Query<TagCollectionGridResponse>("Glo.GetTagCollectionGridList", tagCollectionGridModel);
        }
        public async Task<IEnumerable<TagCollectionModel>> GetTagCollectionList()
        {
            return await Query<TagCollectionModel>("Flo.GetTagNameList");
        }
        public async Task<IEnumerable<TagCollectionModel>> GetTagCollectionList(string tn)
        {
            return await Query<TagCollectionModel>("Flo.GetTagNameList", new { TagCollectionName = tn });
        }
        public async Task<IEnumerable<TagGridListDrivedModel>> GetTagGridLists(TagGridListModel tagGridListModel)
        {
            return await Query<TagGridListDrivedModel>("Glo.GetTagsList", tagGridListModel);
        }
    }
}
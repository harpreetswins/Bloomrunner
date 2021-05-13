using System.Threading.Tasks;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
using Microsoft.Extensions.Configuration;

namespace Admin.Data.GenericRepository
{
    public class TagRepository : GenericRepository, ITagRepository
    {
        public TagRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<CommonResponse> AddTags(TagModel tagModel)
        {
            return await ExecuteAll<CommonResponse>("Glo.AddTagsInCollection", tagModel);
        }
        public async Task<CommonResponse> DeleteTags(TagDeleteModel tagDeleteModel)
        {
            return await ExecuteAll<CommonResponse>("Glo.DeleteTagsInCollection", tagDeleteModel);
        }
        public async Task<CommonResponse> UpdateStatusTags(TagUpdateStatusModel tagUpdateStatusModel)
        {
            return await ExecuteAll<CommonResponse>("Glo.UpdateTagsStatusInCollection", tagUpdateStatusModel);
        }
        public async Task<CommonResponse> UpdateTags(TagUpdateModel tagUpdateModel)
        {
            return await ExecuteAll<CommonResponse>("Glo.UpdateTagsInCollection", tagUpdateModel);
        }
    }
}
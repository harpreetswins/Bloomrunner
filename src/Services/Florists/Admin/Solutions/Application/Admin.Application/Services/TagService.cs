using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Application.Interfaces;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;

namespace Admin.Application.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagrepository;

        public TagService(ITagRepository tagrepository)
        {
            _tagrepository = tagrepository;
        }
        public async Task<CommonResponse> AddTags(TagModel tagModel)
        {
            return await _tagrepository.AddTags(tagModel);
        }
        public async Task<CommonResponse> DeleteTags(TagDeleteModel tagDeleteModel)
        {
            return await _tagrepository.DeleteTags(tagDeleteModel);
        }
        public async Task<CommonResponse> UpdateStatusTags(TagUpdateStatusModel tagUpdateStatusModel)
        {
            return await _tagrepository.UpdateStatusTags(tagUpdateStatusModel);
        }
        public async Task<CommonResponse> UpdateTags(TagUpdateModel tagUpdateModel)
        {
            return await _tagrepository.UpdateTags(tagUpdateModel);
        }
    }
}
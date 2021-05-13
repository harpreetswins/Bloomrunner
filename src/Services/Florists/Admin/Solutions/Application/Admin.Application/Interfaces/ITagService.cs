using System.Threading.Tasks;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;

namespace Admin.Application.Interfaces
{
    public interface ITagService
    {
        Task<CommonResponse> AddTags(TagModel tagModel);
        Task<CommonResponse> DeleteTags(TagDeleteModel tagDeleteModel);
        Task<CommonResponse> UpdateTags(TagUpdateModel tagUpdateModel);
        Task<CommonResponse> UpdateStatusTags(TagUpdateStatusModel tagUpdateStatusModel);
    }
}
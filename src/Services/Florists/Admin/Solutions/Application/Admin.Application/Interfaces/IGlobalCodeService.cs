using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Application.DTO.Request;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
namespace Admin.Application.Interfaces
{
    public interface IGlobalCodeService
    {
        Task<IEnumerable<GlobalCodeCategoriesModel>> GetGlobalCodeCategories();
        Task<IEnumerable<GlobalCodeModelDerived>> GetGlobalCode();
        Task<IEnumerable<GlobalCodeModelDerived>> GetGlobalCode(GlobelSearchModel globelSearchModel);
        Task<int> AddGlobalCode(GlobalCodeModel globalCodeModel);
        Task<int> DeleteGlobalCode(GlobalCodeDeleteModel globalCodeDeleteModel);
        Task<IEnumerable<GlobelcodeSearchListDerivedModel>> GetGlobalLists(GlobelcodeSearchListModel globelcodeSearchListModel);
        Task<CommonResponse> UpdateGlobalCode(GlobelcodeUpdateModel globelcodeUpdateModel);
        Task<int> GlobelcodeUpdateStatus(GlobelcodeUpdateStatusModel globelcodeUpdateStatusModel);
    }
}
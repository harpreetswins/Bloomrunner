using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
namespace Admin.Domain.Interfaces
{
    public interface IGlobalCodeRepository
    {
        Task<IEnumerable<GlobalCodeCategoriesModel>> GetGlobalCodeCategories();
        Task<IEnumerable<GlobalCodeModelDerived>> GetGlobalCode();
        Task<IEnumerable<GlobalCodeModelDerived>> GetGlobalCode(GlobelSearchModel globelSearchModel);
        Task<int> AddGlobalCode(GlobalCodeModel globalCodeModel);   
        Task<int> DeleteGlobalCode (GlobalCodeDeleteModel globalCodeDeleteModel);   
        Task<IEnumerable<GlobelcodeSearchListDerivedModel>> GetGlobalLists(GlobelcodeSearchListModel GlobelcodeSearchListModel);
        Task<CommonResponse> UpdateGlobalCode (GlobelcodeUpdateModel globelcodeUpdateModel);
        Task<int> GlobelcodeUpdateStatus (GlobelcodeUpdateStatusModel globelcodeUpdateStatusModel);
    }
}
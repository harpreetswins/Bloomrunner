using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
using Microsoft.Extensions.Configuration;
namespace Admin.Data.GenericRepository
{
    public class GlobalCodeReposiory : GenericRepository, IGlobalCodeRepository
    {
        public GlobalCodeReposiory(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<GlobalCodeCategoriesModel>> GetGlobalCodeCategories()
        {
            return await Query<GlobalCodeCategoriesModel>("Glo.GetGlobalCodeCategories");
        }
        public async Task<IEnumerable<GlobalCodeModelDerived>> GetGlobalCode()
        {
            return await Query<GlobalCodeModelDerived>("Glo.GetGlobalCode");
        }
        public async Task<IEnumerable<GlobalCodeModelDerived>> GetGlobalCode(GlobelSearchModel globelSearchModel)
        {
            return await Query<GlobalCodeModelDerived>("Glo.GetGlobalCode", globelSearchModel);
        }
        public async Task<int> AddGlobalCode(GlobalCodeModel sid)
        {
            return await Command<GlobalCodeModel>("Glo.AddGlobalCode", sid);
        }
        public async Task<int> DeleteGlobalCode(GlobalCodeDeleteModel globalCodeDeleteModel)
        {
            return await Command<GlobalCodeDeleteModel>("Glo.DeleteGlobalCode", globalCodeDeleteModel);
        }

        public async Task<IEnumerable<GlobelcodeSearchListDerivedModel>> GetGlobalLists(GlobelcodeSearchListModel globelcodeSearchListModel)
        {
            return await Query<GlobelcodeSearchListDerivedModel>("Glo.GetGlobalcodeList", globelcodeSearchListModel);
        }
        public async Task<CommonResponse> UpdateGlobalCode(GlobelcodeUpdateModel globelcodeUpdateModel)
        {
            return await ExecuteAll<GlobelcodeUpdateModel>("Glo.UpdateGlobalCodes", globelcodeUpdateModel);
        }
        public async Task<int> GlobelcodeUpdateStatus(GlobelcodeUpdateStatusModel globelcodeUpdateStatusModel)
        {
            return await Command<GlobelcodeUpdateStatusModel>("Glo.GlobalCodeUpdateStatus", globelcodeUpdateStatusModel);
        }       
    }    
}
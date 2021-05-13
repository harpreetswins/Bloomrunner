using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Application.DTO.Request;
using Admin.Application.Interfaces;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
namespace Admin.Application.Services
{
    public class GlobalCodeService : IGlobalCodeService
    {
        private readonly IGlobalCodeRepository _globalCodeRepository;
        public GlobalCodeService(IGlobalCodeRepository globalCodeRepository)
        {
            _globalCodeRepository = globalCodeRepository;
        }
        public async Task<IEnumerable<GlobalCodeCategoriesModel>> GetGlobalCodeCategories()
        {
            return await _globalCodeRepository.GetGlobalCodeCategories();
        }
        public async Task<IEnumerable<GlobalCodeModelDerived>> GetGlobalCode()
        {
            return await _globalCodeRepository.GetGlobalCode();
        }
        public async Task<IEnumerable<GlobalCodeModelDerived>> GetGlobalCode(GlobelSearchModel globelSearchModel)
        {
            return await _globalCodeRepository.GetGlobalCode(globelSearchModel);
        }
        public async Task<int> AddGlobalCode(GlobalCodeModel globalCodeModel)
        {
            return await _globalCodeRepository.AddGlobalCode(globalCodeModel);
        }
        public async Task<int> DeleteGlobalCode(GlobalCodeDeleteModel globalCodeDeleteModel)
        {
            return await _globalCodeRepository.DeleteGlobalCode(globalCodeDeleteModel);
        }
        public async Task<IEnumerable<GlobelcodeSearchListDerivedModel>> GetGlobalLists(GlobelcodeSearchListModel globelcodeSearchListModel)
        {
            return await _globalCodeRepository.GetGlobalLists(globelcodeSearchListModel);
        }
        public async Task<CommonResponse> UpdateGlobalCode(GlobelcodeUpdateModel globelcodeUpdateModel)
        {
            return await _globalCodeRepository.UpdateGlobalCode(globelcodeUpdateModel);
        }    
        public async Task<int> GlobelcodeUpdateStatus(GlobelcodeUpdateStatusModel globelcodeUpdateStatusModel)
        {
            return await _globalCodeRepository.GlobelcodeUpdateStatus(globelcodeUpdateStatusModel);
        }       
    }
}
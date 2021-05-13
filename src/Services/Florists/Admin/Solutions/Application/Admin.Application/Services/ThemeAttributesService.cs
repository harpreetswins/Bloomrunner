using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Application.DTO.Request;
using Admin.Application.Interfaces;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
namespace Admin.Application.Services
{
    public class ThemeAttributesService : IThemeAttributesService
    {
         private readonly IThemeAttributesRepository _iThemeAttributesRepository;
        public ThemeAttributesService(IThemeAttributesRepository iThemeAttributesRepository)
        {
            _iThemeAttributesRepository = iThemeAttributesRepository;
        }
        public async Task<IEnumerable<ThemeAttributesDrivedModel>> GetThemeAttributes(ThemeAttributesModel themeAttributesModel)
        {
            return await _iThemeAttributesRepository.GetThemeAttributes(themeAttributesModel);
        }     
        public async Task<CommonResponse> AddFloristThemeAttributes(ThemeAttributesSaveModel themeAttributesSaveModel)
        {
            return await _iThemeAttributesRepository.AddFloristThemeAttributes(themeAttributesSaveModel);
        }   
         public async Task<IEnumerable<GetThemeModel>> GetThemes()
        {
            return await _iThemeAttributesRepository.GetThemes();
        }
        public async Task<CommonResponse> AddThemeAttributes(PostThemeAttributeModel postThemeAttributeModel)
        {
            return await _iThemeAttributesRepository.AddThemeAttributes(postThemeAttributeModel);
        }

         public async Task<CommonResponse> ApplyFloristThemeAttributes(ApplyFloristThemeAttributeModel applyFloristThemeAttributeModel)
        {
            return await _iThemeAttributesRepository.ApplyFloristThemeAttributes(applyFloristThemeAttributeModel);
        }
    }
}
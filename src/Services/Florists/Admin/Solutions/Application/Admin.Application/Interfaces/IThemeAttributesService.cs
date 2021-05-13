using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;

namespace Admin.Application.Interfaces
{
    public interface IThemeAttributesService
    {
        Task<IEnumerable<ThemeAttributesDrivedModel>> GetThemeAttributes(ThemeAttributesModel ThemeAttributesModel); 
        Task<CommonResponse> AddFloristThemeAttributes(ThemeAttributesSaveModel themeAttributesSaveModel);     
         Task<IEnumerable<GetThemeModel>> GetThemes();
         Task<CommonResponse> AddThemeAttributes(PostThemeAttributeModel postThemeAttributeModel);
         Task<CommonResponse> ApplyFloristThemeAttributes(ApplyFloristThemeAttributeModel applyFloristThemeAttributeModel); 
  
    }
}
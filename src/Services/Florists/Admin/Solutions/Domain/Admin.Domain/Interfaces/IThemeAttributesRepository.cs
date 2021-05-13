using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;

namespace Admin.Domain.Interfaces
{
    public interface IThemeAttributesRepository
    {
        Task<IEnumerable<ThemeAttributesDrivedModel>> GetThemeAttributes (ThemeAttributesModel themeAttributesModel);     
        Task<CommonResponse> AddFloristThemeAttributes (ThemeAttributesSaveModel themeAttributesSaveModel);  
        Task<IEnumerable<GetThemeModel>> GetThemes();
        Task<CommonResponse> AddThemeAttributes (PostThemeAttributeModel postThemeAttributeModel);

        Task<CommonResponse> ApplyFloristThemeAttributes (ApplyFloristThemeAttributeModel applyFloristThemeAttributeModel);
    }
}
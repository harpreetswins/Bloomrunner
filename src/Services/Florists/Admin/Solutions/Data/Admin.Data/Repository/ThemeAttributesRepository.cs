using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
using Microsoft.Extensions.Configuration;
namespace Admin.Data.GenericRepository
{
    public class ThemeAttributesRepository : GenericRepository, IThemeAttributesRepository
    {
        public ThemeAttributesRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<ThemeAttributesDrivedModel>> GetThemeAttributes(ThemeAttributesModel themeAttributesModel)
        {
            return await Query<ThemeAttributesDrivedModel>("Flo.GetFloristThemeAttributes", themeAttributesModel);
        }
        public async Task<CommonResponse> AddFloristThemeAttributes(ThemeAttributesSaveModel themeAttributesSaveModel)
        {
            return await ExecuteAll<ThemeAttributesSaveModel>("Flo.AddFloristThemeAttributes", themeAttributesSaveModel);
        }
        public async Task<IEnumerable<GetThemeModel>> GetThemes()
        {
            return await Query<GetThemeModel>("Flo.GetThemes");
        }
        public async Task<CommonResponse> AddThemeAttributes(PostThemeAttributeModel postThemeAttributeModel)
        {
            return await ExecuteAll<ThemeAttributesSaveModel>("Flo.AddThemeAttributes", postThemeAttributeModel);
        }
         public async Task<CommonResponse> ApplyFloristThemeAttributes(ApplyFloristThemeAttributeModel applyFloristThemeAttributeModel)
        {
            return await ExecuteAll<ThemeAttributesSaveModel>("Flo.ApplyFloristThemeAttribute", applyFloristThemeAttributeModel);
        }
    }
}
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Solution.Data.Interfaces;
using Solution.Models;

namespace Solution.Data.GenericRepository
{
    public class FloristThemeIdRepository : GenericRepository, IFloristThemeIdRepository
    {
        public FloristThemeIdRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<CommonResponse> GetFloristThemeIds(int floristThemeIdModel)
        {
            return await ExecuteAll<CommonResponse>("dbo.GetFloristThemeID", floristThemeIdModel);
        }
    }
}
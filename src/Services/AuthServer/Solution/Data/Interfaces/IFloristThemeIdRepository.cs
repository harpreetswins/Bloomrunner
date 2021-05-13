using System.Threading.Tasks;
using Solution.Models;

namespace Solution.Data.Interfaces
{
    public interface IFloristThemeIdRepository
    {
        Task<CommonResponse> GetFloristThemeIds(int floristThemeIdModel);
    }
}
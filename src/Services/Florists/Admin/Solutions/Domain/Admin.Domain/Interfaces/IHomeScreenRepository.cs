using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models.Admin;
namespace Admin.Domain.Interfaces
{
    public interface IHomeScreenRepository
    {
        Task<IEnumerable<HomeScreenModelDerived>> GetHomeScreen();
        Task<int> AddHomeScreen(HomeScreenModel homeScreenModel);
        Task<int> DeleteHomeScreen(HomeScreenDeleteModel homeScreenDeleteModel);
    }
}
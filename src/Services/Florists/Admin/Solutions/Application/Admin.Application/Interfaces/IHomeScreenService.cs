using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Application.DTO.Request;
using Admin.Domain.Models.Admin;

namespace Admin.Application.Interfaces
{
    public interface IHomeScreenService
    {
        Task<IEnumerable<HomeScreenModelDerived>> GetHomeScreen();
        Task<int> AddHomeScreen(HomeScreenModel homeScreenModel);   
        Task<int> DeleteHomeScreen(HomeScreenDeleteModel homeScreenDeleteModel);
    }
}
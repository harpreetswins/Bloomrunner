using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Application.DTO.Request;
using Admin.Application.Interfaces;
using Admin.Domain.Interfaces;
using Admin.Domain.Models.Admin;
namespace Admin.Application.Services
{
    public class HomeScreenService : IHomeScreenService
    {
        private readonly IHomeScreenRepository _homeScreenRepository;
        public HomeScreenService(IHomeScreenRepository homeScreenRepository)
        {
            _homeScreenRepository = homeScreenRepository;
        }
        public async Task<IEnumerable<HomeScreenModelDerived>> GetHomeScreen()
        {
            return await _homeScreenRepository.GetHomeScreen();
        }
        public async Task<int> AddHomeScreen(HomeScreenModel Note)
        {
            return await _homeScreenRepository.AddHomeScreen(Note);
        }
        public async Task<int> DeleteHomeScreen(HomeScreenDeleteModel homeScreenDeleteModel)
        {
            return await _homeScreenRepository.DeleteHomeScreen(homeScreenDeleteModel);
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Interfaces;
using Admin.Domain.Models.Admin;
using Microsoft.Extensions.Configuration;

namespace Admin.Data.GenericRepository
{
    public class HomeScreenReposiory : GenericRepository, IHomeScreenRepository
    {
        public HomeScreenReposiory(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<HomeScreenModelDerived>> GetHomeScreen()
        {
            return await Query<HomeScreenModelDerived>("Stf.GetHomeScreens");
        }
        public async Task<int> AddHomeScreen(HomeScreenModel sid)
        {
            return await Command<HomeScreenModel>("Stf.AddHomeScreen", sid);
        }
        public async Task<int> DeleteHomeScreen(HomeScreenDeleteModel homeScreenDeleteModel)
        {
            return await Command<HomeScreenModel>("Stf.DeleteHomeScreens", homeScreenDeleteModel);
        }
    }
}
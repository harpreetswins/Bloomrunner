using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class FloristDashboardRepository : GenericRepository, IFloristDashboardRepository
    {
        public FloristDashboardRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<FloristDashboardModel>> GetFloristRevenue(FloristDashboardSearchModel floristDashboardSearchModel)
        {
            return await Query<FloristDashboardModel>("Flo.GetFloristRevenue", floristDashboardSearchModel);
        }
        public async Task<IEnumerable<FloristMonthlyStatsModel>> GetFloristMonthlyStats(FloristMonthlyStatsSearchModel floristMonthlyStatsSearchModel)
        {
            return await Query<FloristMonthlyStatsModel>("Flo.GetFloristMonthlyStats", floristMonthlyStatsSearchModel);
        }
        public async Task<IEnumerable<FloristCustomersModel>> GetFloristCustomers(FloristCustomersSearchModel floristCustomersSearchModel)
        {
            return await Query<FloristCustomersModel>("Flo.GetFloristCustomers", floristCustomersSearchModel);
        }
    }
}
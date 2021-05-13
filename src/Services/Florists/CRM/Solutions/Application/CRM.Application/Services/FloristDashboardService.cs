using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class FloristDashboardService : IFloristDashboardService
    {
        private readonly IFloristDashboardRepository _iFloristDashboardRepository;
        public FloristDashboardService(IFloristDashboardRepository iFloristDashboardRepository)
        {
            _iFloristDashboardRepository = iFloristDashboardRepository;
        }
        public async Task<IEnumerable<FloristDashboardModel>> GetFloristRevenue(FloristDashboardSearchModel floristDashboardSearchModel)
        {
            return await _iFloristDashboardRepository.GetFloristRevenue(floristDashboardSearchModel);
        }
        public async Task<IEnumerable<FloristMonthlyStatsModel>> GetFloristMonthlyStats(FloristMonthlyStatsSearchModel floristMonthlyStatsSearchModel)
        {
            return await _iFloristDashboardRepository.GetFloristMonthlyStats(floristMonthlyStatsSearchModel);
        }
        public async Task<IEnumerable<FloristCustomersModel>> GetFloristCustomers(FloristCustomersSearchModel floristCustomersSearchModel)
        {
            return await _iFloristDashboardRepository.GetFloristCustomers(floristCustomersSearchModel);
        }
    }
}
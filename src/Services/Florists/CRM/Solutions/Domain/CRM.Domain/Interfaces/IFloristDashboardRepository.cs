using System;
using CRM.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CRM.Domain.Interfaces
{
    public interface IFloristDashboardRepository
    {
         Task<IEnumerable<FloristDashboardModel>> GetFloristRevenue(FloristDashboardSearchModel floristDashboardSearchModel);
         Task<IEnumerable<FloristMonthlyStatsModel>> GetFloristMonthlyStats(FloristMonthlyStatsSearchModel floristMonthlyStatsSearchModel);
         Task<IEnumerable<FloristCustomersModel>> GetFloristCustomers(FloristCustomersSearchModel floristCustomersSearchModel);


    }
}
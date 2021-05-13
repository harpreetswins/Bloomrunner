using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Admin.Data.GenericRepository
{
    public class AdminRepository : GenericRepository, IAdminRepository
    {
        public AdminRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<int> AddFlorist(AdminModel adminModel)
        {
            return await Command<AdminModel>("Flo.AddFlorists", adminModel);
        }
        public async Task<IEnumerable<AdminModelDerived>> GetFlorists(GetFloristModel getFloristModel)
        {
            return await Query<AdminModelDerived>("Flo.GetFlorists", getFloristModel);
        }
        public async Task<IEnumerable<AdminModelDerived>> GetFlorists()
        {
            return await Query<AdminModelDerived>("Flo.GetFlorists");
        }
        public async Task<CommonResponse> UpdateFlorist(AdminUpdateModel adminUpdateModel)
        {
            return await ExecuteAll<CommonResponse>("Flo.UpdateFlorists", adminUpdateModel);
        }
        public async Task<IEnumerable<Location>> GetLocations(SearchLocation searchLocation)
        {
            return await Query<Location>("Flo.GetLocations", searchLocation);
        }
        public Task<int> DeleteFlorist(int Id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<StateModel>> AsyncGetStateList()
        {
            return await Query<StateModel>("Flo.GetState");
        }
        public async Task<IEnumerable<TimeSlotModel>> GetTimingSlots()
        {
            return await Query<TimeSlotModel>("Flo.GetTimingSlotList");
        }
        public async Task<IEnumerable<GetFloristTexRateDrivedModel>> GetFloristTexRate(GetFloristTexRateModel getFloristTexRateModel)
        {
            return await Query<GetFloristTexRateDrivedModel>("Flo.GetFloristTexRate", getFloristTexRateModel);
        }
    }
}

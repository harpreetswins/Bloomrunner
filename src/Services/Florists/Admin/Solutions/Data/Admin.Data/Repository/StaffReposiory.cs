using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
using Microsoft.Extensions.Configuration;
namespace Admin.Data.GenericRepository
{
    public class StaffReposiory : GenericRepository, IStaffRepository
    {
        public StaffReposiory(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<CustomizeGrid>> GetUsersAll(SearchGrid searchGrid)
        {
            return await Query<CustomizeGrid>("Stf.GetStaffList", searchGrid);
        }
        public async Task<IEnumerable<PermissionModel>> GetPermissions(string AuthId)
        {
            return await Query<PermissionModel>("Stf.GetStaffPermissions", new { AuthId = AuthId });
        }
        public async Task<IEnumerable<StaffModelDerived>> GetUsers(int StaffId, int AttributeType)
        {
            return await Query<StaffModelDerived>("Stf.GetStaff", new { StaffId = StaffId, AttributeType = AttributeType });
        }
        public async Task<CommonResponse> AddUser(StaffModel staff)
        {
            return await ExecuteAll<CommonResponse>("stf.AddStaff", staff);
        }
        public async Task<int> DeleteUser(StaffDeleteModel staffDeleteModel)
        {
            return await Command<StaffDeleteModel>("stf.DeleteStaff", staffDeleteModel);
        }
        public async Task<int> UpdateUser(StaffUpdateModel staffUpdateModel)
        {
            return await Command<StaffUpdateModel>("Stf.UpdateStaffs", staffUpdateModel);
        }
        public async Task<int> UpdateStaffUpdateStatus(StaffUpdateStatusModel staffUpdateStatusModel)
        {
            return await Command<StaffUpdateStatusModel>("Stf.StaffUpdateStatus", staffUpdateStatusModel);
        }

        public async Task<int> SetStaffId(Guid Idd, int StaffIdd)
        {
            return await Command<int>("Stf.UpdateStaffAuthId", new { Id = Idd, StaffId = StaffIdd });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
namespace Admin.Application.Interfaces
{
    public interface IStaffService
    {
        Task<IEnumerable<CustomizeGrid>> GetUsersAll(SearchGrid searchGrid);
        Task<IEnumerable<PermissionModel>> GetPermissions(string AuthId);
        Task<IEnumerable<StaffModelDerived>> GetUsers(int StaffId, int AttributeType );
        Task<CommonResponse> AddUser(StaffModel User);
        Task<int> SetStaffId(Guid Id,int StaffId);
        Task<int> DeleteUser(StaffDeleteModel staffDeleteModel);
        Task<int> UpdateUser(StaffUpdateModel staffUpdateModel);
        Task<int> UpdateStaffUpdateStatus(StaffUpdateStatusModel staffUpdateStatusModel);       

    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
using Microsoft.Extensions.Configuration;

namespace Admin.Data.GenericRepository
{
    public class RoleAndPermissionRepository : GenericRepository, IRoleAndPermissionRepository
    {
        public RoleAndPermissionRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<CommonResponse> AddRoleAndPermission(AddRoleAndPermissionModel addRoleAndPermissionModel)
        {
            return await ExecuteAll<CommonResponse>("Flo.AddRoleAndPermission", addRoleAndPermissionModel);
        }
        public async Task<CommonResponse> CloneRoleAndPermission(CloneRoleAndPermissionModel cloneRoleAndPermissionModel)
        {
            return await ExecuteAll<CommonResponse>("Flo.CloneRolesAndPermission", cloneRoleAndPermissionModel);
        }
        public async Task<IEnumerable<RoleAndPermissionModel>> GetRoleAndPermissionList(GetRoleAndPermission getRoleAndPermission)
        {
            return await Query<RoleAndPermissionModel>("Flo.GetRoleAndPermissionList", getRoleAndPermission);
        }
        public async Task<IEnumerable<ScreenActionModel>> GetScreenAction(SearchScreenActionModel searchScreenActionModel)
        {
            return await Query<ScreenActionModel>("Stf.GetStaffActionPermissions", searchScreenActionModel);
        }
    }
}
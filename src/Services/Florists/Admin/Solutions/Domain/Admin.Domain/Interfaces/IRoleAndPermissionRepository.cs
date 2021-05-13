using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;

namespace Admin.Domain.Interfaces
{
    public interface IRoleAndPermissionRepository
    {
        Task<IEnumerable<RoleAndPermissionModel>> GetRoleAndPermissionList(GetRoleAndPermission getRoleAndPermission);
        Task<CommonResponse> AddRoleAndPermission(AddRoleAndPermissionModel addRoleAndPermissionModel);
        Task<CommonResponse> CloneRoleAndPermission(CloneRoleAndPermissionModel cloneRoleAndPermissionModel);
        Task<IEnumerable<ScreenActionModel>> GetScreenAction(SearchScreenActionModel searchScreenActionModel);
    } 
}
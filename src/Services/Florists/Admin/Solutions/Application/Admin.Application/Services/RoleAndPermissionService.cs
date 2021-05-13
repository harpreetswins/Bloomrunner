using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Application.Interfaces;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;

namespace Admin.Application.Services
{
    public class RoleAndPermissionService : IRoleAndPermissionService
    {
        private readonly IRoleAndPermissionRepository _roleAndPermissionRepository; 
        public RoleAndPermissionService(IRoleAndPermissionRepository roleAndPermissionRepository)
        {
            _roleAndPermissionRepository = roleAndPermissionRepository;
        }

        public async Task<CommonResponse> AddRoleAndPermission(AddRoleAndPermissionModel addRoleAndPermissionModel)
        {
            return await _roleAndPermissionRepository.AddRoleAndPermission(addRoleAndPermissionModel);
        }
        public async Task<CommonResponse> CloneRoleAndPermission(CloneRoleAndPermissionModel cloneRoleAndPermissionModel)
        {
            return await _roleAndPermissionRepository.CloneRoleAndPermission(cloneRoleAndPermissionModel);
        }
        public async Task<IEnumerable<RoleAndPermissionModel>> GetRoleAndPermissionList(GetRoleAndPermission getRoleAndPermission)
        {
            return await _roleAndPermissionRepository.GetRoleAndPermissionList(getRoleAndPermission);
        }

        public async Task<IEnumerable<ScreenActionModel>> GetScreenAction(SearchScreenActionModel searchScreenActionModel)
        {
            return await _roleAndPermissionRepository.GetScreenAction(searchScreenActionModel);
        }
    }
}
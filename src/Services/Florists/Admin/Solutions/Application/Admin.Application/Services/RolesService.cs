using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Application.Interfaces;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;

namespace Admin.Application.Services
{
    public class RolesService : IRolesService
    {
        private readonly IRolesRepository _rolesRepository;
        public RolesService(IRolesRepository rolesRepository)
        {
            this._rolesRepository = rolesRepository;
        }

        public async Task<CommonResponse> AddRoles(AddRolesModel addRolesModel)
        {
            return await _rolesRepository.AddRoles(addRolesModel);
        }
        public async Task<IEnumerable<RolesModel>> GetRolesList(int FloristId)
        {
            return await _rolesRepository.GetRolesList(FloristId);
        }
    }
}
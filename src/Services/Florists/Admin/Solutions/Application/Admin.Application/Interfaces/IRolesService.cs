using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;

namespace Admin.Application.Interfaces
{
    public interface IRolesService
    {
        Task<IEnumerable<RolesModel>> GetRolesList(int id);
        Task<CommonResponse> AddRoles(AddRolesModel addRolesModel);
    }
}
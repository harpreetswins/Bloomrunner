using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;

namespace Admin.Domain.Interfaces
{
    public interface IRolesRepository
    {
        Task<IEnumerable<RolesModel>> GetRolesList(int id);
        Task<CommonResponse> AddRoles(AddRolesModel addRolesModel);
    }
}
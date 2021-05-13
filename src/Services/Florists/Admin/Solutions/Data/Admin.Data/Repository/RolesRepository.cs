using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
using Microsoft.Extensions.Configuration;

namespace Admin.Data.GenericRepository
{
    public class RolesRepository : GenericRepository, IRolesRepository
    {
        public RolesRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<CommonResponse> AddRoles(AddRolesModel addRolesModel)
        {
            return await ExecuteAll<CommonResponse>("Flo.AddRoles", addRolesModel);
        }
        public async Task<IEnumerable<RolesModel>> GetRolesList(int id)
        {
            return await Query<RolesModel>("Flo.GetRolesList", new { Floristid = id });
        }
    }
}
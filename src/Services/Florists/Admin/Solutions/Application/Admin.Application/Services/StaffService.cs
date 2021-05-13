using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Application.Interfaces;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
namespace Admin.Application.Services
{ 
    public class StaffService : IStaffService
    {
        private readonly IStaffRepository _userRepository;
        public StaffService(IStaffRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IEnumerable<CustomizeGrid>> GetUsersAll(SearchGrid searchGrid)
        {
            return await _userRepository.GetUsersAll(searchGrid);
        }
        public async Task<IEnumerable<PermissionModel>> GetPermissions(string AuthId)
        {
            return await _userRepository.GetPermissions(AuthId);
        }
        public async Task<IEnumerable<StaffModelDerived>> GetUsers(int StaffId, int AttributeType )
        {
            return await _userRepository.GetUsers(StaffId, AttributeType );
        }
        public async Task<CommonResponse> AddUser(StaffModel Staff)
        {
            return await _userRepository.AddUser(Staff);
        }
        public async Task<int> DeleteUser(StaffDeleteModel staffDeleteModel)
        {
            return await _userRepository.DeleteUser(staffDeleteModel);
        }
        public async Task<int> UpdateUser(StaffUpdateModel staffUpdateModel)
        {
            return await _userRepository.UpdateUser(staffUpdateModel);
        }
         public async Task<int> UpdateStaffUpdateStatus(StaffUpdateStatusModel staffUpdateStatusModel)
        {
            return await _userRepository.UpdateStaffUpdateStatus(staffUpdateStatusModel);
        }

        public async Task<int> SetStaffId(Guid Id, int StaffId)
        {
            try
            {
                return await _userRepository.SetStaffId(Id, StaffId);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }    
}
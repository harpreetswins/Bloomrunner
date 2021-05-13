using Admin.Application.Interfaces;
using Admin.Domain.Interfaces;
using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Application.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        public AdminService(IAdminRepository adminRepository)
        {
            this._adminRepository = adminRepository;
        }
        /// <summary>
        /// This method will used to Add the Florist
        /// </summary>
        public async Task<int> AddFlorist(AdminModel adminModel)
        {
            return await _adminRepository.AddFlorist(adminModel);
        }
        public async Task<int> DeleteFlorist(int Id)
        {
            return await _adminRepository.DeleteFlorist(Id);
        }
        public async Task<IEnumerable<AdminModelDerived>> GetFlorists(GetFloristModel getFloristModel)
        {
            return await _adminRepository.GetFlorists(getFloristModel);
        }
        public async Task<IEnumerable<AdminModelDerived>> GetFlorists()
        {
            return await _adminRepository.GetFlorists();
        }
        public async Task<CommonResponse> UpdateFlorist(AdminUpdateModel adminUpdateModel)
        {
            return await _adminRepository.UpdateFlorist(adminUpdateModel);
        }
        /// <summary>
        /// This method will used to Get the List of Locations of the Florist
        /// </summary>
        public async Task<IEnumerable<Location>> GetLocations(SearchLocation searchLocation)
        {
           return await _adminRepository.GetLocations(searchLocation);
        }
        /// <summary>
        /// This method will used to Get the List of States
        /// </summary>
        public async Task<IEnumerable<StateModel>> AsyncGetStateList()
        {
            return await _adminRepository.AsyncGetStateList();
        }
        /// <summary>
        /// This method will used to Get the List of Time Slots
        /// </summary>
        public async Task<IEnumerable<TimeSlotModel>> GetTimingSlots()
        {
            return await _adminRepository.GetTimingSlots();
        }
        public async Task<IEnumerable<GetFloristTexRateDrivedModel>> GetFloristTexRate(GetFloristTexRateModel getFloristTexRateModel)
        {
            return await _adminRepository.GetFloristTexRate(getFloristTexRateModel);
        }        
    }
}

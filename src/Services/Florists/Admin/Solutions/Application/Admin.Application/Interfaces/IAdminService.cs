using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Application.Interfaces
{
    public interface IAdminService
    {
        Task<IEnumerable<AdminModelDerived>> GetFlorists(GetFloristModel getFloristModel);
        Task<IEnumerable<AdminModelDerived>> GetFlorists();
        Task<int> AddFlorist(AdminModel adminModel);
        Task<int> DeleteFlorist(int Id);
        Task<CommonResponse> UpdateFlorist(AdminUpdateModel adminUpdateModel);
        Task<IEnumerable<Location>> GetLocations(SearchLocation searchLocation);
        Task<IEnumerable<StateModel>> AsyncGetStateList();
        Task<IEnumerable<TimeSlotModel>> GetTimingSlots();
         Task<IEnumerable<GetFloristTexRateDrivedModel>> GetFloristTexRate(GetFloristTexRateModel getFloristTexRateModel);
    }
}

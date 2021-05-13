using Admin.Domain.Models;
using Admin.Domain.Models.Admin;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Admin.Domain.Interfaces
{
    public interface IAdminRepository
    {
        Task<IEnumerable<AdminModelDerived>> GetFlorists(GetFloristModel getFloristModel);
        Task<IEnumerable<AdminModelDerived>> GetFlorists();
        Task<int> AddFlorist(AdminModel adminModel);
        Task<CommonResponse> UpdateFlorist(AdminUpdateModel adminUpdateModel);
        Task<int> DeleteFlorist(int Id);
        Task<IEnumerable<Location>> GetLocations(SearchLocation searchLocation);
        Task<IEnumerable<StateModel>> AsyncGetStateList();
        Task<IEnumerable<TimeSlotModel>> GetTimingSlots();
        Task<IEnumerable<GetFloristTexRateDrivedModel>> GetFloristTexRate(GetFloristTexRateModel getFloristTexRateModel);
    }
}

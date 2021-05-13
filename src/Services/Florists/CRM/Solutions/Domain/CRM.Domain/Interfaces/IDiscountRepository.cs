using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;

namespace CRM.Domain.Interfaces
{
    public interface IDiscountRepository
    {
        Task<IEnumerable<DiscountResponseModel>> GetDiscounts(SearchDiscountModel searchDiscountModel);
        Task<CommonResponse> AddDiscounts(DiscountModel discountModel);
        Task<IEnumerable<DiscountGridResponse>> GetDiscountGridLists(DiscountGridModel discountGridModel);
        Task<CommonResponse> UpdateDiscounts(DiscountUpdateModel discountUpdateModel);
        Task<CommonResponse> DeleteDiscounts(DiscountDeleteModel discountDeleteModel);
        Task<CommonResponse> UpdateDiscountStatus(DiscountUpdateStatusModel discountUpdateStatusModel);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly IDiscountRepository _discountRepository;
        public DiscountService(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }

        public async Task<CommonResponse> AddDiscounts(DiscountModel discountModel)
        {
            return await _discountRepository.AddDiscounts(discountModel);
        }
        public async Task<CommonResponse> DeleteDiscounts(DiscountDeleteModel discountDeleteModel)
        {
            return await _discountRepository.DeleteDiscounts(discountDeleteModel);
        }
        public async Task<IEnumerable<DiscountGridResponse>> GetDiscountGridLists(DiscountGridModel discountGridModel)
        {
            return await _discountRepository.GetDiscountGridLists(discountGridModel);
        }
        public async Task<IEnumerable<DiscountResponseModel>> GetDiscounts(SearchDiscountModel searchDiscountModel)
        {
            return await _discountRepository.GetDiscounts(searchDiscountModel);
        }
        public async Task<CommonResponse> UpdateDiscounts(DiscountUpdateModel discountUpdateModel)
        {
            return await _discountRepository.UpdateDiscounts(discountUpdateModel);
        }
        public async Task<CommonResponse> UpdateDiscountStatus(DiscountUpdateStatusModel discountUpdateStatusModel)
        {
            return await _discountRepository.UpdateDiscountStatus(discountUpdateStatusModel);
        }
    }
}
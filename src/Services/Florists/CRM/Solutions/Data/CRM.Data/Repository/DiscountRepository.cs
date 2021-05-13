using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class DiscountRepository : GenericRepository, IDiscountRepository
    {
        public DiscountRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<CommonResponse> AddDiscounts(DiscountModel discountModel)
        {
            return await ExecuteAll<CommonResponse>("Crm.AddDiscounts", discountModel);
        }
        public async Task<CommonResponse> DeleteDiscounts(DiscountDeleteModel discountDeleteModel)
        {
            return await ExecuteAll<CommonResponse>("Crm.DeleteDiscounts", discountDeleteModel);
        }
        public async Task<IEnumerable<DiscountGridResponse>> GetDiscountGridLists(DiscountGridModel discountGridModel)
        {
            return await Query<DiscountGridResponse>("Crm.GetDiscountGridList", discountGridModel);
        }
        public async Task<IEnumerable<DiscountResponseModel>> GetDiscounts(SearchDiscountModel searchDiscountModel)
        {
            return await Query<DiscountResponseModel>("Crm.GetDiscounts", searchDiscountModel);
        }
        public async Task<CommonResponse> UpdateDiscounts(DiscountUpdateModel discountUpdateModel)
        {
            return await ExecuteAll<CommonResponse>("Crm.UpdateDiscounts", discountUpdateModel);
        }
        public async Task<CommonResponse> UpdateDiscountStatus(DiscountUpdateStatusModel discountUpdateStatusModel)
        {
            return await ExecuteAll<CommonResponse>("Crm.UpdateDiscountStatus", discountUpdateStatusModel);
        }
    }
}
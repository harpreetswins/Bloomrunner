using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class RecipientRepository : GenericRepository, IRecipientRepository
    {
        public RecipientRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<RecipientDerivedModel>> GetRecipients(SearchRecipient searchRecipient)
        {
            return await Query<RecipientDerivedModel>("Crm.GetRecipients", searchRecipient);
        }
        public async Task<int> DeleteRecipients(RecipientDeleteModel globalCodeDeleteModel)
        {
            return await Command<RecipientDeleteModel>("Crm.DeleteRecipient", globalCodeDeleteModel);
        }
        public async Task<int> UpdateRecipients(RecipientUpdateModel recipientUpdateModel)
        {
            return await Command<RecipientUpdateModel>("Crm.UpdateRecipients", recipientUpdateModel);
        }
        public async Task<IEnumerable<RecipientOrderModel>> GetRecipientsOrder(RecipientOrderSerchModel recipientOrderSerchModel)
        {
            return await Query<RecipientOrderModel>("Crm.GetRecipientsOrder", recipientOrderSerchModel);
        }
        public async Task<CommonResponse> AddRecipients(RecipientModel recipient)
        {
            return await ExecuteAll<CommonResponse>("Crm.AddRecipients", recipient);
        }
        public async Task<int> RecipientsUpdateStatus(RecipientUpdateStatusModel recipientUpdateStatusModel)
        {
            return await Command<RecipientUpdateStatusModel>("Crm.RecipientsUpdateStatus", recipientUpdateStatusModel);
        }
        public async Task<IEnumerable<RecipientUpcommingOrderDrivedModel>> GetRecipientUpcommingOrders(RecipientUpcommingOrderModel recipientUpcommingOrderModel)
        {
            return await Query<RecipientUpcommingOrderDrivedModel>("Crm.GetCRMRecipientsUpcommingOrder", recipientUpcommingOrderModel);
        }
    }
}
using CRM.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM.Application.Interfaces
{
    public interface IRecipientService
    {
        Task<IEnumerable<RecipientDerivedModel>> GetRecipients(SearchRecipient searchRecipient);
        Task<CommonResponse> AddRecipients(RecipientModel recipient);
        Task<int> DeleteRecipients(RecipientDeleteModel recipientDeleteModel);
        Task<int> UpdateRecipients(RecipientUpdateModel recipientUpdateModel);
        Task<IEnumerable<RecipientOrderModel>> GetRecipientsOrder(RecipientOrderSerchModel recipientOrderSerchModel);
        Task<int> RecipientsUpdateStatus (RecipientUpdateStatusModel recipientUpdateStatusModel);
        Task<IEnumerable<RecipientUpcommingOrderDrivedModel>> GetRecipientUpcommingOrders(RecipientUpcommingOrderModel recipientUpcommingOrderModel);
    }
}
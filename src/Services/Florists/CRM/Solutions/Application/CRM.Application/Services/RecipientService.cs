using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class RecipientService : IRecipientService
    {
        private readonly IRecipientRepository _recipientRepository;
        public RecipientService(IRecipientRepository recipientRepository)
        {
            _recipientRepository = recipientRepository;
        }
        public async Task<CommonResponse> AddRecipients(RecipientModel recipient)
        {
            return await _recipientRepository.AddRecipients(recipient);
        }
        public async Task<IEnumerable<RecipientDerivedModel>> GetRecipients(SearchRecipient searchRecipient)
        {
            return await _recipientRepository.GetRecipients(searchRecipient);
        }
        public async Task<int> DeleteRecipients(RecipientDeleteModel recipientDeleteModel)
        {
            return await _recipientRepository.DeleteRecipients(recipientDeleteModel);
        }
        public async Task<int> UpdateRecipients(RecipientUpdateModel recipientUpdateModel)
        {
            return await _recipientRepository.UpdateRecipients(recipientUpdateModel);
        }
        public async Task<IEnumerable<RecipientOrderModel>> GetRecipientsOrder(RecipientOrderSerchModel recipientOrderSerchModel)
        {
            return await _recipientRepository.GetRecipientsOrder(recipientOrderSerchModel);
        }
        public async Task<int> RecipientsUpdateStatus(RecipientUpdateStatusModel recipientUpdateStatusModel)
        {
            return await _recipientRepository.RecipientsUpdateStatus(recipientUpdateStatusModel);
        }
        public async Task<IEnumerable<RecipientUpcommingOrderDrivedModel>> GetRecipientUpcommingOrders(RecipientUpcommingOrderModel recipientUpcommingOrderModel)
        {
            return await _recipientRepository.GetRecipientUpcommingOrders(recipientUpcommingOrderModel);
        }
    }
}
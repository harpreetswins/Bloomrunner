using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class CRMRecipientService : ICRMRecipientService
    {
        private readonly ICRMRecipientRepository _iCRMRecipientRepository;
        public CRMRecipientService(ICRMRecipientRepository iCRMRecipientRepository)
        {
            _iCRMRecipientRepository = iCRMRecipientRepository;
        }
        public async Task<IEnumerable<CRMRecipientModel>> GetCRMRecipient(CRMRecipientSearchModel cRMRecipientSearchModel)
        {
            return await _iCRMRecipientRepository.GetCRMRecipient(cRMRecipientSearchModel);
        }
        public async Task<IEnumerable<CRMRecipientModel>> GetCRMRecipientList(CRMRecipientListSearchModel cRMRecipientListSearchModel)
        {
            return await _iCRMRecipientRepository.GetCRMRecipientList(cRMRecipientListSearchModel);
        }
    }
}
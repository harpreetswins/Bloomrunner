using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class CRMClientService : ICRMClientService
    {
        private readonly ICRMClientRepository _iCRMClientRepository;
        public CRMClientService(ICRMClientRepository iCRMClientRepository)
        {
            _iCRMClientRepository = iCRMClientRepository;
        }
        public async Task<IEnumerable<CRMClientModel>> GetCRMClient(CRMClientSearchModel cRMClientSearchModel)
        {
            return await _iCRMClientRepository.GetCRMClient(cRMClientSearchModel);
        }
        public async Task<IEnumerable<CRMClientModel>> GetCRMClientList(CRMClientListSearchModel cRMClientListSearchModel)
        {
            return await _iCRMClientRepository.GetCRMClientList(cRMClientListSearchModel);
        }
    }
}
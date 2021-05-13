using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Application.Interfaces;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;

namespace CRM.Application.Services
{
    public class CRMCustomerCountService : ICRMCustomerCountService
    {
        private readonly ICRMCustomerCountRepository _iCRMCustomerCountRepository;
        public CRMCustomerCountService(ICRMCustomerCountRepository iCRMCustomerCountRepository)
        {
            _iCRMCustomerCountRepository = iCRMCustomerCountRepository;
        }
        public async Task<IEnumerable<CRMCustomerCountModel>> GetCRMCustomerCount(CRMCustomerCountSearchModel cRMCustomerCountSearchModel)
        {
            return await _iCRMCustomerCountRepository.GetCRMCustomerCount(cRMCustomerCountSearchModel);
        }
    }
}
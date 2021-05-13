using CRM.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM.Application.Interfaces
{
    public interface ICRMClientService
    {
        Task<IEnumerable<CRMClientModel>> GetCRMClient(CRMClientSearchModel cRMClientSearchModel);
        Task<IEnumerable<CRMClientModel>> GetCRMClientList(CRMClientListSearchModel cRMClientListSearchModel);
    }
}
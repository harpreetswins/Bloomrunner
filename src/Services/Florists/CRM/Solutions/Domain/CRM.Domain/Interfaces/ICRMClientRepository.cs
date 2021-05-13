using System;
using CRM.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CRM.Domain.Interfaces
{
    public interface ICRMClientRepository
    {
         Task<IEnumerable<CRMClientModel>> GetCRMClient (CRMClientSearchModel cRMClientSearchModel);
        Task<IEnumerable<CRMClientModel>> GetCRMClientList (CRMClientListSearchModel cRMClientListSearchModel);
    }
}
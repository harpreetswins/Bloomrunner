using CRM.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM.Application.Interfaces
{
    public interface ICRMRecipientService
    {
        Task<IEnumerable<CRMRecipientModel>> GetCRMRecipient(CRMRecipientSearchModel cRMRecipientSearchModel);
        Task<IEnumerable<CRMRecipientModel>> GetCRMRecipientList(CRMRecipientListSearchModel cRMRecipientListSearchModel);
    }
}
using System;
using CRM.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CRM.Domain.Interfaces
{
    public interface ICRMRecipientRepository
    {
         Task<IEnumerable<CRMRecipientModel>> GetCRMRecipient (CRMRecipientSearchModel cRMRecipientSearchModel);
         Task<IEnumerable<CRMRecipientModel>> GetCRMRecipientList (CRMRecipientListSearchModel cRMRecipientListSearchModel);
    }
}
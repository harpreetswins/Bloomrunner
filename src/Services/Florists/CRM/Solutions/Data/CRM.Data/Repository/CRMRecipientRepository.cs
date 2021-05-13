using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class CRMRecipientRepository : GenericRepository, ICRMRecipientRepository
    {
        public CRMRecipientRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<CRMRecipientModel>> GetCRMRecipient(CRMRecipientSearchModel cRMRecipientSearchModel)
        {
            return await Query<CRMRecipientModel>("Crm.GetCRMRecipients", cRMRecipientSearchModel);
        }
        public async Task<IEnumerable<CRMRecipientModel>> GetCRMRecipientList(CRMRecipientListSearchModel cRMRecipientListSearchModel)
        {
            return await Query<CRMRecipientModel>("Crm.GetCRMRecipientsList", cRMRecipientListSearchModel);
        }
    }
}
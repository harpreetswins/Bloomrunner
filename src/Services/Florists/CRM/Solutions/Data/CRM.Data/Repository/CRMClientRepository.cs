using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class CRMClientRepository : GenericRepository, ICRMClientRepository
    {
        public CRMClientRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<CRMClientModel>> GetCRMClient(CRMClientSearchModel cRMClientSearchModel)
        {
            return await Query<CRMClientModel>("Crm.GetCRMCustomers", cRMClientSearchModel);
        }
        public async Task<IEnumerable<CRMClientModel>> GetCRMClientList(CRMClientListSearchModel cRMClientListSearchModel)
        {
            return await Query<CRMClientModel>("Crm.GetCRMCustomersList", cRMClientListSearchModel);
        }
    }
}
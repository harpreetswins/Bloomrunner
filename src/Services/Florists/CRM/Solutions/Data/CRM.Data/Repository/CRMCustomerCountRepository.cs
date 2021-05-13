using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace CRM.Data.GenericRepository
{
    public class CRMCustomerCountRepository : GenericRepository, ICRMCustomerCountRepository
    {
        public CRMCustomerCountRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<IEnumerable<CRMCustomerCountModel>> GetCRMCustomerCount(CRMCustomerCountSearchModel cRMCustomerCountSearchModel)
        {
            return await Query<CRMCustomerCountModel>("Crm.GetCustomerCountInClientStatus", cRMCustomerCountSearchModel);
        }
    }
}
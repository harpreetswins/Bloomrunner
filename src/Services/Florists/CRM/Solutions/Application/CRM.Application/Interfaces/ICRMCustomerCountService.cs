using CRM.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM.Application.Interfaces
{
    public interface ICRMCustomerCountService
    {
        Task<IEnumerable<CRMCustomerCountModel>> GetCRMCustomerCount(CRMCustomerCountSearchModel cRMCustomerCountSearchModel);
    }
}
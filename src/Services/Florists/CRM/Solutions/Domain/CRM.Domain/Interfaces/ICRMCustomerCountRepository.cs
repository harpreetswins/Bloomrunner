using System;
using CRM.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CRM.Domain.Interfaces
{
    public interface ICRMCustomerCountRepository
    {
          Task<IEnumerable<CRMCustomerCountModel>> GetCRMCustomerCount (CRMCustomerCountSearchModel cRMCustomerCountSearchModel);
    }
}
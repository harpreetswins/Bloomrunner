using CRM.Application.DTO.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CRM.API.Infrastructure.Validators.CRM
{
    public class CustomerDToValidators : AbstractValidator<CustomerDTO>
    {
        public CustomerDToValidators()
        {
            //RuleFor(x => x.FloristName).NotEmpty();
            //RuleFor(x => x.Email).NotEmpty().EmailAddress();
           // RuleFor(x => x.NoOfLocations).NotEmpty();
        }
    }
}
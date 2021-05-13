using AuthIdentityServer.Models.AccountViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Infrastructure.Validators.Register
{
    public class REgisterDTOValidation : AbstractValidator<RegisterDTO>
    {
        public REgisterDTOValidation()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.ProfileImage).NotEmpty();
            RuleFor(x => x.Country).NotEmpty();
            RuleFor(x => x.State).NotEmpty();
            RuleFor(x => x.City).NotEmpty();
            RuleFor(x => x.ZipCode).NotEmpty();
            RuleFor(x => x.Street).NotEmpty();
        }
    }
}

using Admin.Application.DTO.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.API.Infrastructure.Validators.Admin
{
    public class AdminDTOValidators : AbstractValidator<AdminDTO>
    {
        public AdminDTOValidators()
        {
            RuleFor(x => x.FloristName).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.NoOfLocations).NotEmpty();
        }
    }
}

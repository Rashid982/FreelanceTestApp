using FluentValidation;
using FreelanceTestApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceTestApp.Validation
{
    public class OptionsValidator : AbstractValidator<IOptions>
    {
        public OptionsValidator()
        {
            RuleFor(x => x.ApiToken).NotEmpty().WithMessage("Api token musn't be empty !");
            RuleFor(x => x.BaseAdress).NotEmpty().WithMessage("Base adress musn't be empty !");
        }
    }
}

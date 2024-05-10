using FluentValidation;
using FreelanceTestApp.Interfaces;

namespace FreelanceTestApp.Validation
{
    public class RequestValidator : AbstractValidator<IRequest>
    {
        public RequestValidator() 
        {
            RuleFor(x => x.SenderMail).NotEmpty().WithMessage("Sender mail must not be empty !");
            RuleFor(x => x.SenderName).NotEmpty().WithMessage("Sender name must not be empty !");
            RuleFor(x => x.RecipientMail).NotEmpty().WithMessage("Recipient mail must not be empty !");
            RuleFor(x => x.RecipientName).NotEmpty().WithMessage("Recipient name must not be empty !");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Subject must not be empty !");            
        }

    }
}

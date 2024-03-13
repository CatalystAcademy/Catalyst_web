using Catalyst_web.Models;
using FluentValidation;

namespace Catalyst_web.validator
{
    public class VisitValidator : AbstractValidator<Visit>
    {
        public VisitValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("The email field is required.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("The name field is required.");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("The phone number field is required.");
            RuleFor(x => x.AppointmentDate).NotEmpty().WithMessage("The appointment date field is required.");
            RuleFor(x => x.AppointmentTime).NotEmpty().WithMessage("The appointment time field is required.");
        }
    }
}

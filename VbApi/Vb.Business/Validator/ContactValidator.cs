using FluentValidation;
using Vb.Schema;

namespace Vb.Business.Validator;

public class CreateContactValidator : AbstractValidator<ContactRequest>
{
    public CreateContactValidator()
    {
        RuleFor(x => x.Information)
            .NotEmpty().WithMessage("Information is required.")
            .MaximumLength(100).WithMessage("Information must be at most 100 characters.");

        RuleFor(x => x.IsDefault)
            .NotNull().WithMessage("IsDefault is required.");
    }
}

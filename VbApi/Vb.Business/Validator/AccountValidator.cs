using FluentValidation;
using Vb.Schema;

namespace Vb.Business.Validator;

public class CreateAccountValidator : AbstractValidator<AccountRequest>
{
    public CreateAccountValidator()
    {
        RuleFor(x => x.IBAN).NotEmpty().WithName("Iban is required");
        RuleFor(x => x.Balance).NotEmpty().GreaterThan(0).WithName("Balance must be greater than zero");
    }
}
using FluentValidation;
using Vb.Schema;

namespace Vb.Business.Validator;

public class CreateAccountTransactionValidator : AbstractValidator<AccountTransactionRequest>
{
    public CreateAccountTransactionValidator()
    {
        RuleFor(x => x.Amount).NotEmpty().GreaterThan(0).WithName("Amount");
        RuleFor(x => x.Description).NotEmpty().MinimumLength(3).MaximumLength(100).WithName("Description");
    }
}
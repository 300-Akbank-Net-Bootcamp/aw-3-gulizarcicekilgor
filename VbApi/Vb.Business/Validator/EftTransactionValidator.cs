using FluentValidation;
using Vb.Schema;

namespace Vb.Business.Validator;

public class CreateEftTransactionValidator : AbstractValidator<EftTransactionRequest>
{
    public CreateEftTransactionValidator()
    {
        RuleFor(x => x.Description)
           .NotEmpty().WithMessage("Description is required.")
           .MaximumLength(100).WithMessage("Description must be at most 100 characters.");

        RuleFor(x => x.SenderAccount)
            .NotEmpty().WithMessage("Sender Account is required.")
            .MaximumLength(50).WithMessage("Sender Account must be at most 50 characters.");

        RuleFor(x => x.SenderIban)
            .NotEmpty().WithMessage("Sender IBAN is required.")
            .Length(22).WithMessage("Sender IBAN must be 22 characters.");
        RuleFor(x => x.SenderName)
        .NotEmpty().WithMessage("Sender Name is required.")
        .MaximumLength(100).WithMessage("Sender Name must be at most 100 characters.");
    }
}

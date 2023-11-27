using BankAccount.Domain.Entities;
using FluentValidation;

namespace BankAccount.WebApi.Models.Validators
{
    public class BankAccountValidator : AbstractValidator<BankAccounts>
    {

        public BankAccountValidator() {

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithErrorCode("Firstname is not empty!")
                .NotNull()
                .WithErrorCode("Firstname is not null!")
                .MinimumLength(3)
                .MaximumLength(20)
                .WithErrorCode("Firstname must be between 3 and 20 characters.!");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithErrorCode("Lastname is not empty!")
                .NotNull()
                .WithErrorCode("Lastname is not null!")
                .MinimumLength(3)
                .MaximumLength(20)
                .WithErrorCode("Lastname must be between 3 and 20 characters.!");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .WithErrorCode("Phone number is not null and empty!")
                .Matches(@"^(\d{11})$").WithErrorCode("Phone number must be 11 digits!");

        }
    }
}

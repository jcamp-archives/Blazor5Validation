using Blazor5Validation.Shared;
using FluentValidation;

namespace Blazor5Validation.Server
{

    // this essentially allows expanding on existing validators with code that can only run server side.
    // a db context or any other needed service could be injected here to lookup things as needed.

    public class PersonServerValidator : AbstractValidator<Person>
    {
        public PersonServerValidator()
        {
            Include(new PersonValidator());

            // this rule could clearly run client side, just used here for simplicity to test server side validation
            RuleFor(p => p.EmailAddress).Must(value => !value.Contains("nonymous.com")).WithMessage("We don't accept emails from this domain.");
        }

    }
}

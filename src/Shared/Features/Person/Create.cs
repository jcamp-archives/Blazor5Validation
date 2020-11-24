using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Blazor5Validation.Shared;

namespace Features.Person
{
    public class Create
    {
        public class Command : IRequest<Result>
        {
            public Blazor5Validation.Shared.Person Person { get; set; }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
            }
        }

        public class Result
        {
            public bool Successful { get; set; }
            public string Message { get; set; }
        }

        //this is here for easy navigation with goto implementation
        public interface ICommandHandler : IRequestHandler<Command, Result> { }

    }
}

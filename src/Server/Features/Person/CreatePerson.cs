using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Blazor5Validation.Server.Extensions;

namespace Features.Person
{
    //this allows us to avoid Create. in front of results, commands, etc
    public class CreatePerson_ : CreatePerson
    {
        public class CommandHandler : ICommandHandler
        {
            public Task<Result> Handle(Command request, CancellationToken cancellationToken)
            {
                var result = new Result().Success("Looks good to the server (mediatr).");
                return Task.FromResult(result);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Features.Person
{
    //this allows us to avoid Create. in front of results, commands, etc
    public class Create_ : Create
    {
        public class CommandHandler : ICommandHandler
        {
            public Task<Result> Handle(Command request, CancellationToken cancellationToken)
            {
                var result = new Result()
                {
                    Successful = true,
                    Message = "Looks good to the server (mediatr)."
                };
                return Task.FromResult(result);
            }
        }
    }
}

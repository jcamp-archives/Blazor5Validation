using System.Threading;
using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using Blazor5Validation.Server.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Features.Person
{

    public class List : BaseEndpoint
    .WithRequest<CreatePersonCommand>
    .WithResponse<BaseResult>
    {
        [HttpPost(CreatePersonCommand.Route)]
        public override ActionResult<BaseResult> Handle(CreatePersonCommand request)
        {
            var result = new BaseResult().Success("Looks good to the server (endpoint).");
            return result.ToActionResult();
        }
    }
}

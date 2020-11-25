using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Features.Person
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PersonMediatrController : ControllerBase
    {

        private readonly ISender _sender;
        public PersonMediatrController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost]
        public async Task<IActionResult> Index(Create.Command model)
        {
            var result = await _sender.Send(model);
            return Ok(result);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor5Validation.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Features.Person
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonMediatrController : ControllerBase
    {

        private ISender _sender;
        public PersonMediatrController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost]
        public async Task<IActionResult> Index(Features.Person.Create.Command model)
        {
            var result = await _sender.Send(model);
            return Ok(result);
        }
    }


}

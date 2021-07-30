using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Features.Person
{
    public class CreatePersonCommand
    {
        public const string Route = "/api/person/create";
        public Blazor5Validation.Shared.Person Person { get; set; }
    }
}

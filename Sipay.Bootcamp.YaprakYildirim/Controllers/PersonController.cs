using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Sipay.Bootcamp.YaprakYildirim.Models;

namespace Sipay.Bootcamp.YaprakYildirim.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IValidator<Person> _validator;

        public PersonController(IValidator<Person> validator)
        {
            _validator = validator;
        }

        //Person nesnesini HTTP POST isteği ile kabul edip doğrulama yapılır
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            var validationResult = _validator.Validate(person);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            return Ok(person);
        }

    }
}

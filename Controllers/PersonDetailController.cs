using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneBookWebApi.Models;

namespace PhoneBookWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonDetailController : ControllerBase
    {
        private readonly PersonDetailContext _context;

        public PersonDetailController(PersonDetailContext context)
        {
            _context = context;
        }

        // GET: api/PersonDetail/GetPeople
        [HttpGet]
        [Route("GetPeople")]
        public IEnumerable<PersonDetail> GetPersonDetails()
        {
            return _context.PersonDetails;
        }

        // POST: api/PersonDetail/SetPerson
        [HttpPost]
        [Route("SetPerson")]
        public async Task<IActionResult> PostPersonDetail([FromBody] PersonDetail personDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PersonDetails.Add(personDetail);
            await _context.SaveChangesAsync();

            return Ok(personDetail);
        }
    }
}
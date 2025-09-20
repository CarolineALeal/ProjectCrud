using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCrud.Data;
using ProjectCrud.Models;

namespace ProjectCrud.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public PersonController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _appDbContext.ProjectCrud.Add(person);
            await _appDbContext.SaveChangesAsync();
            return Created("Registro criado com sucesso!",person);
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Person>>> List()
        {
            var Persons = await _appDbContext.ProjectCrud.ToListAsync();

            return Ok(Persons);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Person>> Get(int id)
        {
            var Person = await _appDbContext.ProjectCrud.FindAsync(id);

            if (Person == null)
            {
                return NotFound("Registro não encontrado!");
            }

            return Ok(Person);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<Person>> Update(int id, [FromBody] Person personUpdated)
        {
            var CurrentPerson = await _appDbContext.ProjectCrud.FindAsync(id);

            if (CurrentPerson == null)
            {
                return NotFound("Registro não encontrado!");
            }

            _appDbContext.Entry(CurrentPerson).CurrentValues.SetValues(personUpdated);
            await _appDbContext.SaveChangesAsync();

            return StatusCode(201, CurrentPerson);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<Person>> Delete(int id)
        {
            var Person = await _appDbContext.ProjectCrud.FindAsync(id);

            if (Person == null)
            {
                return NotFound("Registro não encontrado!");
            }

            _appDbContext.ProjectCrud.Remove(Person);
            await _appDbContext.SaveChangesAsync();

            return Ok("Registro deletado com sucesso!");
        }

        
    }

}
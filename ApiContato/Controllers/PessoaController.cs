using ApiContato.Contexto;
using ApiContato.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApiContato.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PessoaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pessoa>> GetPeople()
        {
            var pessoas = _context?.People?.Include(c => c.Contatos).ToList();

            //pessoas?.ForEach(pe =>
            //{
            //    pe.Contatos = _context?.Contacts?.Where(f => f.PessoaId == pe.Id)?.ToList() ?? new List<Contato>();
            //});

            return pessoas;
        }

        [HttpPost]
        public ActionResult<Pessoa> CreatePerson(Pessoa person)
        {
            _context.People.Add(person);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetPerson), new { id = person.Id }, person);
        }

        [HttpGet("{id}")]
        public ActionResult<Pessoa> GetPerson(int id)
        {
            var person = _context.People.Include(c => c.Contatos).FirstOrDefault(p => p.Id == id);
            //var contatosFromPessoa = _context.Contacts.Where(x => x.PessoaId == id).ToList();
            //person.Contatos = contatosFromPessoa;

            if (person == null)
            {
                return NotFound();
            }
           
            return person;
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePerson(int id, Pessoa person)
        {
            if (id != person.Id)
            {
                return BadRequest();
            }

            _context.Entry(person).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePerson(int id)
        {
            var person = _context.People.Find(id);
            if (person == null)
            {
                return NotFound();
            }

            _context.People.Remove(person);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
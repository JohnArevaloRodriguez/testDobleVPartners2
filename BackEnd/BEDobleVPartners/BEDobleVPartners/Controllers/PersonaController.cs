using BEDobleVPartners.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BEDobleVPartners.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public PersonaController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Getpersona()
        {
            try
            {
                var listPersonas = await _context.Persona.ToListAsync();
                return Ok(listPersonas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]

        public async Task<IActionResult> PostPersona(Persona persona)
        {
            try
            {
                _context.Add(persona);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetPersona", new { id = persona.IdPersona }, persona);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

using BEDobleVPartners.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BEDobleVPartners.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentificacionController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public IdentificacionController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetIdentificacion()
        {
            try
            {
                var listIdentificacion = await _context.identificacions.ToListAsync();
                return Ok(listIdentificacion);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

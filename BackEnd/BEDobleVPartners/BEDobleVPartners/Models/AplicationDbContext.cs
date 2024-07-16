using Microsoft.EntityFrameworkCore;

namespace BEDobleVPartners.Models
{
    public class AplicationDbContext :DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Persona> Persona { get; set; }
        public DbSet<Identificacion> identificacions { get; set; }
        public DbSet<Credencial> credencials { get; set; }
    }
}

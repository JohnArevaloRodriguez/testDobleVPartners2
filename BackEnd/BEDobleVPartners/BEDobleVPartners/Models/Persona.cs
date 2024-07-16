using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEDobleVPartners.Models
{
    [Table("Personas")]
    public class Persona
    {
        [Key]
        public int IdPersona { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombres { get; set; }
        [Required]
        [MaxLength(100)]
        public String Apellidos { get; set; }
        [Required]
        [MaxLength(50)]
        public string NumeroIdentificacion { get; set; }
        [Required]
        public string email { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string NombreCompleto { get; set; }
        [Required]
        public DateTime? FechaCreacion { get; set; }
        [Required]
        [ForeignKey("idIdentificacion")]
        public virtual Identificacion Identificacion { get; set; }
        [Required]
        [ForeignKey("idCredencial")]
        public virtual Credencial Credencial { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEDobleVPartners.Models
{
    [Table("Credenciales")]
    public class Credencial
    {
        [Key]
        public int idCredencial { get; set; }
        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Pass { get; set; }
        [Required]
        public DateTime? FechaCreacion { get; set; }
    }
}

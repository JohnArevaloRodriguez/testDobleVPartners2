using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEDobleVPartners.Models
{
    [Table("Identificacion")]
    public class Identificacion
    {
        [Key]
        public int idIdentificacion { get; set; }
        [Required]
        public string TipoIdentificacion { get; set; }
    }
}

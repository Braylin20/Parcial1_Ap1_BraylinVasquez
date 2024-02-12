using System.ComponentModel.DataAnnotations;

namespace Parcial1_Ap1_BraylinVasquez.Models
{
    public class Metas
    {
        [Key]
        public int MetaId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime? Fecha { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe ser mayor a 0")]
        public double? Monto { get; set; }
    }
}

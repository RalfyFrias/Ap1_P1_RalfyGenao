using System.ComponentModel.DataAnnotations;

namespace Ap1_P1_RalfyGenao.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }

        public DateTime Fecha { get; set; } 

        [Required(ErrorMessage = "La Descripcion es Incorecta")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "El Monto es  Incorecto")]
        public int Monto { get; set; }
        [Required(ErrorMessage = "El Precio es  Incorecto")]
        public int Precio { get; set; }
        [Required(ErrorMessage = "La Ganacia  es  Incorecto")]
        public int Ganacia { get; set;}

    }

}

// ArticuloID,Descripcion,Costo,Ganancia,Precio 
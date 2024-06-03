using System.ComponentModel.DataAnnotations;

namespace Ap1_P1_RalfyGenao.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }

        [Required]
        public string Descripcion { get; set; }
        [Required]
        
        public int Monto { get; set; }
        [Required]

        public int Precio { get; set; }
        [Required]

        public int Ganancia { get; set; }
      

    }

}

// ArticuloID,Descripcion,Costo,Ganancia,Precio 
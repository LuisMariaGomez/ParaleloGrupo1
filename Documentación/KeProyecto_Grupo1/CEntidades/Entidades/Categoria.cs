using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Categoria : EntityBase
    {
        public int Id { get; set; }

        public const int LengthNombre = 60;

        [MaxLength(
            LengthNombre,
            ErrorMessage = "El campo {0} no puede tener más de {1} caracteres."
        )]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        
        public string? Nombre {  get; set; }

        // EF

        public ICollection<Producto>? Productos { get; } = new List<Producto>();  // 1:n con Producto
    }
}

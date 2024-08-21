using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Proveedor : EntityBase
    {
        public int Id { get; set; }
        public const int LengthNombre = 60;

        [MaxLength(
            LengthNombre,
            ErrorMessage = "El campo {0} no puede tener más de {1} caracteres."
        )]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono {  get; set; }
        public string? Email { get; set; }

        // EF

        public ICollection<Producto> Productos { get; } = new List<Producto>(); // 1:n con Producto
        public int IdCiudad { get; set; }
        public Ciudad Ciudad { get; set; } = null!; // 1:n con Ciudad
    }
}

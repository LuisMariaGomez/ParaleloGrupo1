using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Distribuidor : EntityBase
    {
        public int Id { get; set; }

        public const int LengthNombre = 60;

        [MaxLength(
            LengthNombre,
            ErrorMessage = "El campo {0} no puede tener más de {1} caracteres."
        )]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public const int LengthTelefono = 60;

        [MaxLength(
            LengthTelefono,
            ErrorMessage = "El campo {1} no puede tener más de {1} caracteres."
        )]
        [Required(ErrorMessage = "El campo {1} es obligatorio")]

        public const int LengthEmail = 60;

        [MaxLength(
            LengthEmail,
            ErrorMessage = "El campo {2} no puede tener más de {1} caracteres."
        )]
        [Required(ErrorMessage = "El campo {2} es obligatorio")]

        public string? Nombre {  get; set; }
        public int Telefono {  get; set; }
        public string? Email {  get; set; }

        // EF

        public ICollection<OrdenDeVenta>? OrdenesDeVenta { get; } = new List<OrdenDeVenta>();  // 1:n con OrdenDeVenta
        public int IdCiudad {  get; set; }
        public Ciudad Ciudad { get; set; } = null!; // 1:n con Ciudad


    }
}

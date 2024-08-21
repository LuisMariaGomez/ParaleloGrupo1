using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Ciudad : EntityBase
    {
        public int Id { get; set; }

        public const int LengthNombre = 60;

        [MaxLength(
            LengthNombre,
            ErrorMessage = "El campo {0} no puede tener más de {1} caracteres."
        )]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public const int LengthCp = 5;

        [MaxLength(
            LengthCp,
            ErrorMessage = "El campo {1} no puede tener más de {1} caracteres."
        )]
        [Required(ErrorMessage = "El campo {1} es obligatorio")]

        public const int LengthAcp = 2;

        [MaxLength(
            LengthNombre,
            ErrorMessage = "El campo {2} no puede tener más de {1} caracteres."
        )]
        [Required(ErrorMessage = "El campo {2} es obligatorio")]

        public string? Nombre { get; set; }
        public string? Cp { get; set; }
        public string? Acp {  get; set; }

        // EF
        public int ProvinciaId { get; set; } 
        public Provincia? Provincia { get; set; }           // 1:n con Provincia (Es la hija de Provincia)                            

        public ICollection<Persona> Personas { get; } = new List<Persona>(); // 1:n con Personas (Es padre de Persona)
        public ICollection<Proveedor> Proveedores { get; } = new List<Proveedor>(); // 1:n con Personas (Es padre de Proveedor)
        public ICollection<Distribuidor> Distribuidores { get; } = new List<Distribuidor>(); // 1:n con Personas (Es padre de Distribuidor)

    }
}

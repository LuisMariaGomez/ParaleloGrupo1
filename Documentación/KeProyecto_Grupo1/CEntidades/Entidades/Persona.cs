using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Persona : EntityBase
    {
        public int Id { get; set; }
        public const int LengthNombre = 20;
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Tipo_Doc { get; set; } //Lista 
        public string? Nro_Doc { get; set; }
        public int  IdCiudad { get; set; }
        public string? Email { get; set; }
        public string? Estado { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }

        // EF

        public Cliente? Cliente { get; set; } // 1:1 con Persona
        public Empleado? Empleado { get; set; }  // 1:1 con Persona
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; } = null!; // 1:n con Ciudad (Esla hija)

    }
}

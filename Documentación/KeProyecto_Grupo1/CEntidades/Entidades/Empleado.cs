using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Empleado 
    {
        //Ver como implementar el ID (no el que hereda de persona)
        public int Id { get; set; }
        public bool Foto { get; set; } //Ver tema foto 
                                       //string ubicación de foto, ruta

        // EF
        public int PersonaId { get; set; }
        public Persona Persona { get; set; } = null!;   
        public int SectorId { get; set; }
        public Sector Sector { get; set; } = null!; // 1:n con Sector

        public ICollection<OrdenDeVenta>? OrdenesDeVenta { get; } = new List<OrdenDeVenta>(); // 1:n con OrdenDeVenta
        public ICollection<OrdenDeCompra>? OrdenesDeCompra { get;} = new List<OrdenDeCompra>(); // 1:n con OrdenDeCompra

    }
}

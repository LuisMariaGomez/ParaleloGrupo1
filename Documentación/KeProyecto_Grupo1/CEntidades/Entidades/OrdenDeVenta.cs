using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class OrdenDeVenta : EntityBase
    {
        public int Id { get; set; }
        public DateTime Fecha {  get; set; }

        // EF
        public Factura? Factura { get; set; }    // 1:1 Con Factura
        public int FacturaId { get; set; }
        public Empleado? Empleado { get; set; }
        public int EmpleadoId { get; set; } // 1:n con OrdenDeVenta
        public Estado? Estado { get; set; }
        public int EstadoId { get; set; }   // 1:n con Estado
        public Cliente? Cliente { get; set; }
        public int ClienteId { get; set; }   // 1:n con Cliente
        public Distribuidor? Distribuidor { get; set; }
        public int DistribuidorId { get; set; }   // 1:n con Distribuidor
        public ICollection<OrdenDeVenta_Producto>? OrdenDeVenta_Productos { get; set; } // n:n con Producto



    }
}

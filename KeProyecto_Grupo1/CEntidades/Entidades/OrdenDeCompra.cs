using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class OrdenDeCompra : EntityBase
    {
        public int Id { get; set; }
        public int IdEmpleado {  get; set; }
        public DateTime FechaOrden {  get; set; }


        //EF
        public Factura? Factura { get; set; }    // 1:1 Con Factura
        public int FacturaId { get; set; }
        public Empleado? Empleado { get; set; }
        public int EmpleadoId { get; set; } // 1:n con Empleado
        public List<Producto> Productos { get; } = []; // n:n con Producto
    }
}

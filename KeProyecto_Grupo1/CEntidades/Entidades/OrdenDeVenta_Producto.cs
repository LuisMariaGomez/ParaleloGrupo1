using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class OrdenDeVenta_Producto : EntityBase
    {
        public int Id { get; set; }
        public int CantidadProducto { get; set; }

        // EF
        public int IdProducto { get; set; }
        public int IdOrdenDeVenta { get; set; }

        public Producto? Producto { get; set; }
        public OrdenDeVenta? OrdenDeVenta { get; set; }
        // EF

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Factura : EntityBase
    {
        public int Id { get; set; }
        // EF
        public OrdenDeVenta? OrdenDeVenta { get; set; }
        public OrdenDeCompra? OrdenDeCompra { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class OrdenDeCompra_Producto : EntityBase
    {
        public int Id {  get; set; }
        //  EF
        public int IdProducto { get; set; }
        public int IdOrdenDeCompra { get; set; }
        //  EF

        public int CantidadProducto {  get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Estado
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }

        // EF
        public ICollection<OrdenDeVenta>? OrdenesDeVentas { get; } = new List<OrdenDeVenta>();  // 1:n con OrdenesDeVenta
    }
}

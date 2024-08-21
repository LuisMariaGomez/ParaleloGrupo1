using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }

        //Ver como implementar el ID (no el que hereda de persona)

        // EF
        public int PersonaId { get; set; }  
        public Persona Persona { get; set; } = null!;
        public ICollection<OrdenDeVenta>? OrdenesDeVenta { get; } = new List<OrdenDeVenta>(); // 1:n con OrdenDeVenta

    }
}

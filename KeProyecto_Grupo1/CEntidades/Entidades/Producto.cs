using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Producto : EntityBase
    {
        public int Id { get; set; }

        public const int LengthNombre = 30;

        [MaxLength(
            LengthNombre,
            ErrorMessage = "El campo {0} no puede tener más de {1} caracteres."
        )]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        
        public string? Nombre {  get; set; }
        public int IdProveedor {  get; set; }
        public int IdCategoria {  get; set; }
        public int UnidadesProducto {  get; set; }
        public int PrecioProducto {  get; set; }
        public int Stock { get; set; }

        // EF
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; } = null!; // 1:n con Proveedor 


        public Categoria? Categoria { get; set; }
        public int CategoriaId { get; set; }    // 1:n con Categoria 

        public List<OrdenDeCompra> OrdenesDeCompra { get; } = []; // n:n con OrdenDeCompra
        public ICollection<OrdenDeVenta_Producto>? OrdenDeVenta_Productos { get; set; } // n:n con OrdenDeVenta

    }
}

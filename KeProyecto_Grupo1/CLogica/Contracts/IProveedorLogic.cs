using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IProveedorLogic
    {
        Task<List<Proveedor>> Get();
        void AltaProveedor(Proveedor proveedorNuevo);

        void ActualizarProveedor(string nombre, Proveedor proveedorActualizar);

        void EliminarProveedor(string nombre);
    }
}

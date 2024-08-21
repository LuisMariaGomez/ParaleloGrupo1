using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface ICategoriaLogic
    {
        void AltaCategoria(Categoria categoriaNueva);

        void ActualizarCategoria(string nombre, Categoria categoriaActualizar);

        void EliminarCategoria(string nombre);

        Task<List<Categoria>> Get();
    }
}

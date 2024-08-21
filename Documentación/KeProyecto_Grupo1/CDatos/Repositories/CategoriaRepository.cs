using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(KeProyectoContext context) : base(context) { }

        public async Task<List<Categoria>> GetAll()
        {
            try
            {
                return await _context.Categoria.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

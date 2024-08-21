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
    public class ProveedorRepository : Repository<Proveedor>, IProveedorRepository
    {
        public ProveedorRepository(KeProyectoContext context) : base(context) { }

        public async Task<List<Proveedor>> GetAll()
        {
            try
            {
                return await _context.Proveedor.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

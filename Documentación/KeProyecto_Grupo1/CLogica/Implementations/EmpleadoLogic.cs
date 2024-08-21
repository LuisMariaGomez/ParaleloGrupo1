using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class EmpleadoLogic : AltaEntidades
    {
        public EmpleadoLogic(IPersonaRepository personaRepository) : base(personaRepository)
        {
        }

        protected override void UpdateEntidad()
        {
            throw new NotImplementedException();
        }

        protected override void validarDatosEspecificosDeLaClase(AltaEntidades entidad)
        {
            if (entidad.Sector == null)
            {
                throw new ArgumentException("Debe seleccionar un sector");
            }
        }
    }
}

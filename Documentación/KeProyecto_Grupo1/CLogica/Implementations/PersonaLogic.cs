using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;

namespace CLogica.Implementations
{
    public class PersonaLogic
    {
        private readonly IPersonaRepository _personaRepository;
        public PersonaLogic(PersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public void validarInexistencia(Persona persona)
        {
            var personas = _personaRepository.FindByCondition(p => p.Nro_Doc == persona.Nro_Doc);
            if (personas.Count() > 0)
            {
                throw new ArgumentException("Persona ya existente");
            } // Verifica si hay alguna persona con el documento especificado
        }
        public void validarDatos(Persona persona)
        {
            throw new NotImplementedException();
        }
        public void UpdateEntidad(Persona persona)
        {

        }
    }
}

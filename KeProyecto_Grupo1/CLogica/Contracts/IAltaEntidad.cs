using CDatos.Repositories.Contracts;
using CDatos.Repositories;
using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public abstract class AltaEntidadesClienteEmpleado
    {
        Persona? persona;
        private readonly IPersonaRepository? _personaRepository;
        public AltaEntidadesClienteEmpleado(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public void AltaEntidad(AltaEntidadesClienteEmpleado entidad)
        {
            validarInexistencia(entidad);
            validarDatosPersona(entidad);
            validarDatosEspecificosDeLaClase(entidad);
            UpdateEntidad();
        }

        void validarInexistencia(AltaEntidadesClienteEmpleado entidad)
        {
            var personas = _personaRepository.FindByCondition(p => p.Nro_Doc == entidad.persona.Nro_Doc);
            if (personas.Count() > 0)
            {
                throw new ArgumentException("Persona ya existente");
            } // Verifica si hay alguna persona con el documento especificado
        }
        void validarDatosPersona(AltaEntidadesClienteEmpleado entidad)
        {
            if (string.IsNullOrEmpty(entidad.persona.Nombre) || !IsValidStrinng_withLessThanXLetters(entidad.persona.Nombre, 15))
                throw new ArgumentException("Nombre inválido");

            if (string.IsNullOrEmpty(entidad.persona.Apellido) || !IsValidStrinng_withLessThanXLetters(entidad.persona.Apellido, 15))
                throw new ArgumentException("Apellido inválido");

            if (string.IsNullOrEmpty(entidad.persona.Nro_Doc) || !IsValidDocumento(entidad.persona.Nro_Doc))
                throw new ArgumentException("Documento inválido");

            if (string.IsNullOrEmpty(entidad.persona.Telefono) || !IsValidTelefono(entidad.persona.Telefono))
                throw new ArgumentException("Teléfono inválido");

            if (string.IsNullOrEmpty(entidad.persona.Email) || !IsValidEmail(entidad.persona.Email))
                throw new ArgumentException("Email inválido");
        }
        protected abstract void validarDatosEspecificosDeLaClase(AltaEntidadesClienteEmpleado entidad);
        protected abstract void UpdateEntidad();












        private bool IsValidStrinng_withLessThanXLetters(string word, int num_letters)
        {
            return ContieneCaracter(word) && word.Length < num_letters;
        }
        private bool ContieneCaracter(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '&', '/', '(', ')', '=', '.', ',', };
            return caracteres.Any(p => text.Contains(p));
        }
        private bool IsValidDocumento(string documento)
        {
            return documento.Length != 8 && ContieneCaracter(documento);
        }

        private bool IsValidTelefono(string telefono)
        {
            return telefono.Length != 10 && ContieneCaracter(telefono);
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains('@') && ContieneCaracter(email);
        }
    }
}

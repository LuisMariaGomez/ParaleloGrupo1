using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class ProveedorLogic : IProveedorLogic
    {
        IProveedorRepository _proveedorRepository;

        public ProveedorLogic(IProveedorRepository proveedorRepository)
        {
            _proveedorRepository = proveedorRepository;
        }

        public void AltaProveedor(Proveedor proveedorNuevo)
        {
            List<string> camposErroneos = new List<string>();
            if (string.IsNullOrEmpty(proveedorNuevo.Nombre) || !IsValidName(proveedorNuevo.Nombre))
                camposErroneos.Add("Nombre");

            if (string.IsNullOrEmpty(proveedorNuevo.Direccion) || !IsValidName(proveedorNuevo.Direccion))
                camposErroneos.Add("Dirección");

            if (string.IsNullOrEmpty(proveedorNuevo.Email) || !IsValidName(proveedorNuevo.Email))
                camposErroneos.Add("Email");

            if (string.IsNullOrEmpty(proveedorNuevo.Telefono) || !IsValidName(proveedorNuevo.Telefono))
                camposErroneos.Add("Telefono");

            if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

            Proveedor proveedor = new Proveedor();
            proveedor.Nombre = proveedorNuevo.Nombre;
            proveedor.Direccion = proveedorNuevo.Direccion;
            proveedor.Email = proveedorNuevo.Email;
            proveedor.Telefono = proveedorNuevo.Telefono;

            _proveedorRepository.Create(proveedor);
            _proveedorRepository.Save();
        }

        public void ActualizarProveedor(string nombre, Proveedor proveedorActualizar)
        {
            List<string> camposErroneos = new List<string>();
            if (string.IsNullOrEmpty(proveedorActualizar.Nombre) || !IsValidName(proveedorActualizar.Nombre))
                camposErroneos.Add("Nombre");

            if (string.IsNullOrEmpty(proveedorActualizar.Direccion) || !IsValidName(proveedorActualizar.Direccion))
                camposErroneos.Add("Dirección");

            if (string.IsNullOrEmpty(proveedorActualizar.Email) || !IsValidName(proveedorActualizar.Email))
                camposErroneos.Add("Email");

            if (string.IsNullOrEmpty(proveedorActualizar.Telefono) || !IsValidName(proveedorActualizar.Telefono))
                camposErroneos.Add("Telefono");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
            }

            if (string.IsNullOrEmpty(nombre) || !IsValidName(nombre))
                throw new ArgumentException("El nombre ingresado es inválido.");

            Proveedor? proveedor = _proveedorRepository.FindByCondition(p => p.Nombre == nombre).FirstOrDefault();

            if (proveedor == null)
            {
                throw new ArgumentNullException("No se ha encontrado un proveedor con ese nombre");
            }

            proveedor.Nombre = proveedorActualizar.Nombre;
            proveedor.Direccion = proveedorActualizar.Direccion;
            proveedor.Email = proveedorActualizar.Email;
            proveedor.Telefono = proveedorActualizar.Telefono;

            _proveedorRepository.Update(proveedor);
            _proveedorRepository.Save();
        }

        public void EliminarProveedor(string nombre)
        {
            if (string.IsNullOrEmpty(nombre) || !IsValidName(nombre))
                throw new ArgumentException("El nombre ingresado es inválido.");

            Proveedor? proveedor = _proveedorRepository.FindByCondition(p => p.Nombre == nombre).FirstOrDefault();

            if (proveedor == null)
            {
                throw new ArgumentNullException("No se ha encontrado un proveedor con ese nombre");
            }
            _proveedorRepository.Delete(proveedor);
            _proveedorRepository.Save();
        }

        public Task<List<Proveedor>> Get()
        {
            throw new NotImplementedException();
        }

        #region validaciones
        private bool ContainsInvalidCharacter(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '/', '(', ')', '=', '.', ',' };
            return caracteres.Any(c => text.Contains(c));
        }
        private bool IsValidName(string nombre)
        {
            return nombre.Length < 15 && !ContainsInvalidCharacter(nombre);
        }
        private bool IsValidDireccion(string direccion)
        {
            return direccion.Length < 17 && direccion.All(c => Char.IsNumber(c));
        }
        public bool IsValidEmail(string email)
        {
            return email.Contains('@') && !ContainsInvalidCharacter(email);
        }
        public bool IsValidTelefono(string telefono)
        {
            return telefono.Length == 10 && telefono.All(c => Char.IsNumber(c));
        }

        #endregion validaciones 

    }
}

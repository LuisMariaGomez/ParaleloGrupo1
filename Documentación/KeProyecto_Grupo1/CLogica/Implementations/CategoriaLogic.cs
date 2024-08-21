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
    public class CategoriaLogic : ICategoriaLogic
    {
            ICategoriaRepository _categoriaRepository;

            public CategoriaLogic(ICategoriaRepository categoriaRepository)
            {
            _categoriaRepository = categoriaRepository;
            }

            public void AltaCategoria(Categoria categoriaNueva)
            {
                List<string> camposErroneos = new List<string>();
                if (string.IsNullOrEmpty(categoriaNueva.Nombre) || !IsValidName(categoriaNueva.Nombre))
                    camposErroneos.Add("Nombre");

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

                Categoria categoria = new Categoria();
                categoria.Nombre = categoriaNueva.Nombre;

                _categoriaRepository.Create(categoria);
                _categoriaRepository.Save();
            }

            public void ActualizarCategoria(string nombre, Categoria categoriaActualizar)
            {
                List<string> camposErroneos = new List<string>();
                if (string.IsNullOrEmpty(categoriaActualizar.Nombre) || !IsValidName(categoriaActualizar.Nombre))
                    camposErroneos.Add("Nombre");

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

                if (string.IsNullOrEmpty(nombre) || !IsValidName(nombre))
                    throw new ArgumentException("El nombre ingresado es inválido.");

                Categoria? categoria = _categoriaRepository.FindByCondition(p => p.Nombre == nombre).FirstOrDefault();

                if (categoria == null)
                {
                    throw new ArgumentNullException("No se ha encontrado una categoria con ese nombre");
                }

                categoria.Nombre = categoriaActualizar.Nombre;

                _categoriaRepository.Update(categoria);
                _categoriaRepository.Save();
            }

            public void EliminarCategoria(string nombre)
            {
                if (string.IsNullOrEmpty(nombre) || !IsValidName(nombre))
                    throw new ArgumentException("El nombre ingresado es inválido.");

                Categoria? categoria = _categoriaRepository.FindByCondition(p => p.Nombre == nombre).FirstOrDefault();

                if (categoria == null)
                {
                    throw new ArgumentNullException("No se ha encontrado una categoria con ese nombre");
                }
                   _categoriaRepository.Delete(categoria);
                   _categoriaRepository.Save();
            }

            public Task<List<Categoria>> Get()
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
            #endregion validaciones 

        }
    }

using Datos.Repositorios;
using Entidades.Entidades;
using Negocio.Herramientas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Modelos
{
    public class ProvinciasModel
    {
        #region Atributos

        private int id;
        private string provincia;
        private bool fav;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private ProvinciasRepositorio repositorio;

        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public bool Fav { get => fav; set => fav = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }

        #endregion

        public ProvinciasModel()
        {
            repositorio = new ProvinciasRepositorio();
        }

        #region CRUD
        public provincias FindById(int id)
        {
            provincias unTipo = repositorio.FindProvinciaById(id);
            return unTipo;
        }
        public List<provincias> GetAll()
        {
            List<provincias> lista = repositorio.GetAllProvincias();
            return lista;
        }
        public Resultado Insertar(provincias provincia)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(provincia);

            if (validador.Validar())
            {
                if (repositorio.InsertarProvincia(provincia))
                {
                    resultado.isOk = true;
                    return resultado;
                }
                else
                {
                    resultado.isOk = false;
                    resultado.error = "Error en el ingreso.";
                    return resultado;
                }
            }
            else
            {
                resultado.isOk = false;
                resultado.error = validador.MensajeError();
                return resultado;
            }
        }
        public Resultado Editar(provincias provincia)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(provincia);

            if (validador.Validar())
            {
                if (repositorio.EditarProvincia(provincia))
                {
                    resultado.isOk = true;
                    return resultado;
                }
                else
                {
                    resultado.isOk = false;
                    resultado.error = "Error al editar.";
                    return resultado;
                }
            }
            else
            {
                resultado.isOk = false;
                resultado.error = validador.MensajeError();
                return resultado;
            }
        }
        public Resultado Eliminar(provincias provincia)
        {
            Resultado resultado = new Resultado();

            if (repositorio.EliminarProvincia(provincia))
            {
                resultado.isOk = true;
                return resultado;
            }
            else
            {
                resultado.isOk = false;
                resultado.error = "Error al eliminar.";
                return resultado;
            }
        }

        #endregion


        #region Auxiliares

        public ProvinciasModel ConvertirModelo(provincias provincia)
        {
            ProvinciasModel modelo = new ProvinciasModel();
            modelo.id = provincia.id;
            modelo.provincia = provincia.provincia;
            modelo.fav = provincia.fav;
            modelo.created_at = provincia.created_at;
            modelo.updated_at = provincia.updated_at;

            return modelo;
        }

        #endregion
    }
}

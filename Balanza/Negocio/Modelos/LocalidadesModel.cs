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
    public class LocalidadesModel
    {
        #region Atributos

        private int id;
        private string localidad;
        private int provincia_id;
        private string lat;
        private string lon;
        private bool fav;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private LocalidadesRepositorio repositorio;

        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public int Provincia_id { get => provincia_id; set => provincia_id = value; }
        public string Lat { get => lat; set => lat = value; }
        public string Lon { get => lon; set => lon = value; }
        public bool Fav { get => fav; set => fav = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }

        #endregion

        public LocalidadesModel()
        {
            repositorio = new LocalidadesRepositorio();
        }

        #region CRUD
        public localidades FindById(int id)
        {
            localidades unTipo = repositorio.FindLocalidadById(id);
            return unTipo;
        }
        public List<localidades> GetAll()
        {
            List<localidades> lista = repositorio.GetAllLocalidades();
            return lista;
        }
        public Resultado Insertar(localidades localidad)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(localidad);

            if (validador.Validar())
            {
                if (repositorio.InsertarLocalidad(localidad))
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
        public Resultado Editar(localidades localidad)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(localidad);

            if (validador.Validar())
            {
                if (repositorio.EditarLocalidad(localidad))
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
        public Resultado Eliminar(localidades localidad)
        {
            Resultado resultado = new Resultado();

            if (repositorio.EliminarLocalidad(localidad))
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

        public List<localidades> GetByProvincia(int id)
        {
            List<localidades> lista = repositorio.GetLocalidadesByProvincia(id);
            return lista;
        }

        #region Auxiliares

        public LocalidadesModel ConvertirModelo(localidades localidad)
        {
            LocalidadesModel modelo = new LocalidadesModel();
            modelo.id = localidad.id;
            modelo.localidad = localidad.localidad;
            modelo.provincia_id = localidad.provincia_id;
            modelo.lat = localidad.lat;
            modelo.lon = localidad.lon;
            modelo.fav = localidad.fav;
            modelo.created_at = localidad.created_at;
            modelo.updated_at = localidad.updated_at;

            return modelo;
        }

        #endregion
    }
}

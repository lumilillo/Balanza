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
    public class TipoCamionesModel
    {
        #region Atributos

        private int id;
        private string codigo;
        private string descripcion;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private TipoCamionesRepositorio repositorio;

        #endregion

        #region Propiedades

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }

        #endregion

        public TipoCamionesModel()
        {
            repositorio = new TipoCamionesRepositorio();
        }

        #region CRUD
        public tipo_camiones FindById(int id )
        {
            tipo_camiones unTipo = repositorio.FindTipoCamionById(id);
            return unTipo;
        }
        public List<tipo_camiones> GetAll()
        {
            List<tipo_camiones> lista = repositorio.GetAllTipoCamiones();
            return lista;
        }
        public Resultado Insertar(tipo_camiones tipoCamion)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(tipoCamion);

            if (validador.Validar())
            {
                if (repositorio.InsertarTipoCamion(tipoCamion))
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
        public Resultado Editar(tipo_camiones tipoCamion)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(tipoCamion);

            if (validador.Validar())
            {
                if (repositorio.EditarTipoCamion(tipoCamion))
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
        public Resultado Eliminar(tipo_camiones tipoCamion)
        {
            Resultado resultado = new Resultado();

            if (repositorio.EliminarTipoCamion(tipoCamion))
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

        public TipoCamionesModel ConvertirModelo(tipo_camiones unidad)
        {
            TipoCamionesModel modelo = new TipoCamionesModel();
            modelo.id = unidad.id;
            modelo.codigo = unidad.codigo;
            modelo.descripcion = unidad.descripcion;
            modelo.created_at = unidad.created_at;
            modelo.updated_at = unidad.updated_at;

            return modelo;
        }

        #endregion

    }
}

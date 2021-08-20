using Datos.Repositorios;
using Entidades.Entidades;
using Negocio.Herramientas;
using System;
using System.Collections.Generic;

namespace Negocio.Modelos
{
    public class ParametrosGeneralesModel
    {
        #region Atributos

        private int id;
        private string codigo;
        private string descripcion;
        private string valor;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private ParametrosGeneralesRepositorio repositorio;

        #endregion

        #region Propiedades

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Valor { get => valor; set => valor = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }

        #endregion

        public ParametrosGeneralesModel()
        {
            repositorio = new ParametrosGeneralesRepositorio();
        }

        #region CRUD
        public parametros_generales FindById(int id)
        {
            parametros_generales parametro = repositorio.FindParametroById(id);
            return parametro;
        }
        public List<parametros_generales> GetAll()
        {
            List<parametros_generales> parametro = repositorio.GetAllUnidadMedida();
            return parametro;
        }
        public Resultado Insertar(parametros_generales unidad)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(unidad);

            if (validador.Validar())
            {
                if (repositorio.InsertarParametro(unidad))
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
        public Resultado Editar(parametros_generales unidad)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(unidad);

            if (validador.Validar())
            {
                if (repositorio.EditarUnidadMedida(unidad))
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
        public Resultado Eliminar(parametros_generales unidad)
        {
            Resultado resultado = new Resultado();

            if (repositorio.EliminarUnidadMedida(unidad))
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

        #region METODOS PROPIOS

        public parametros_generales FindByCodigo(string codigo)
        {
            parametros_generales parametro = repositorio.FindParametroByCodigo(codigo);
            return parametro;
        }

        #endregion

        #region Auxiliares

        public ParametrosGeneralesModel ConvertirModelo(parametros_generales unidad)
        {
            ParametrosGeneralesModel modelo = new ParametrosGeneralesModel();
            modelo.id = unidad.id;
            modelo.codigo = unidad.codigo;
            modelo.descripcion = unidad.descripcion;
            modelo.valor = unidad.valor;
            modelo.created_at = unidad.created_at;
            modelo.updated_at = unidad.updated_at;

            return modelo;
        }

        #endregion
    }
}

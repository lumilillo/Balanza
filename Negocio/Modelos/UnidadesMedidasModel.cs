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
    public class UnidadesMedidasModel
    {
        #region Atributos

        private int id;
        private string codigo;
        private string descripcion;
        private bool medir_por_peso;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private UnidadesMedidasRepositorio repositorio;

        #endregion

        #region Propiedades

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Medir_por_peso { get => medir_por_peso; set => medir_por_peso = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }

        #endregion

        public UnidadesMedidasModel()
        {
            repositorio = new UnidadesMedidasRepositorio();
        }

        #region CRUD
        public unidades_medidas FindById(int id)
        {
            unidades_medidas unTipo = repositorio.FindUnidadMedidaById(id);
            return unTipo;
        }
        public List<unidades_medidas> GetAll()
        {
            List<unidades_medidas> lista = repositorio.GetAllUnidadMedida();
            return lista;
        }
        public Resultado Insertar(unidades_medidas unidad)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(unidad);

            if (validador.Validar())
            {
                if (repositorio.InsertarUnidadMedida(unidad))
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
        public Resultado Editar(unidades_medidas unidad)
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
        public Resultado Eliminar(unidades_medidas unidad)
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

        #region Auxiliares

        public UnidadesMedidasModel ConvertirModelo(unidades_medidas unidad)
        {
            UnidadesMedidasModel modelo = new UnidadesMedidasModel();
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

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
    public class EstadosModel
    {
        #region Atributos

        private int id;
        private string codigo;
        private string descripcion;
        private string color;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private EstadosRepositorio repositorio;

        #endregion

        #region Propiedades

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Color { get => color; set => color = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }

        #endregion

        public EstadosModel()
        {
            repositorio = new EstadosRepositorio();
        }

        #region CRUD
        public estados FindById(int id)
        {
            estados unTipo = repositorio.FindTipoCamionById(id);
            return unTipo;
        }
        public List<estados> GetAll()
        {
            List<estados> lista = repositorio.GetAllTipoCamiones();
            return lista;
        }
        public Resultado Insertar(estados estado)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(estado);

            if (validador.Validar())
            {
                if (repositorio.InsertarTipoCamion(estado))
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
        public Resultado Editar(estados estado)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(estado);

            if (validador.Validar())
            {
                if (repositorio.EditarTipoCamion(estado))
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
        public Resultado Eliminar(estados estado)
        {
            Resultado resultado = new Resultado();

            if (repositorio.EliminarTipoCamion(estado))
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

        public estados FindByCodigo(string codigo)
        {
            estados unTipo = repositorio.FindTipoCamionByCodigo(codigo);
            return unTipo;
        }

        #region Auxiliares

        public EstadosModel ConvertirModelo(estados estado)
        {
            EstadosModel modelo = new EstadosModel();
            modelo.id = estado.id;
            modelo.codigo = estado.codigo;
            modelo.descripcion = estado.descripcion;
            modelo.color = estado.color;
            modelo.created_at = estado.created_at;
            modelo.updated_at = estado.updated_at;

            return modelo;
        }

        #endregion
    }
}

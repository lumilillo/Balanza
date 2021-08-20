using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Entidades;
using Datos.Repositorios;
using Negocio.Herramientas;

namespace Negocio.Modelos
{
    public class MateriasPrimasModel
    {
        #region Atributos

        private int id;
        private string codigo;
        private string descripcion;
        private int unidades_medida_id;
        private bool materia_prima_sn;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private MateriasPrimasRepositorio repositorio;

        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int UnidadesMedidaId { get => unidades_medida_id; set => unidades_medida_id = value; }
        public bool Materia_prima_sn { get => materia_prima_sn; set => materia_prima_sn = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }

        #endregion

        public MateriasPrimasModel()
        {
            repositorio = new MateriasPrimasRepositorio();
        }

        #region CRUD
        public materias_primas FindById(int id)
        {
            materias_primas unTipo = repositorio.FindMateriaPrimaById(id);
            return unTipo;
        }
        public List<materias_primas> GetAll()
        {
            List<materias_primas> lista = repositorio.GetAllMaterias();
            return lista;
        }
        public Resultado Insertar(materias_primas materia)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(materia);

            if (validador.Validar())
            {
                if (repositorio.InsertarMateria(materia))
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
        public Resultado Editar(materias_primas materia)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(materia);

            if (validador.Validar())
            {
                if (repositorio.EditarMateria(materia))
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
        public Resultado Eliminar(materias_primas materia)
        {
            Resultado resultado = new Resultado();
            int codigo = 0;

            codigo = repositorio.EliminarMateria(materia);

            if (codigo == 1)
            {
                resultado.isOk = true;
                return resultado;
            }
            else
            {
                resultado.isOk = false;
                resultado.error = MensajeError(codigo);
                return resultado;
            }
        }

        #endregion

        public List<materias_primas> GetMateriasPrimas()
        {
            List<materias_primas> lista = repositorio.GetMateriasPrimas();
            return lista;
        }
        public List<materias_primas> GetMateriasVenta()
        {
            List<materias_primas> lista = repositorio.GetMateriasVenta();
            return lista;
        }

        public List<materias_primas> GetMateriasConUnidad()
        {
            List<materias_primas> lista = repositorio.GetMateriasConUnidad();
            return lista;
        }

        public List<materias_primas> GetMaterialesNuevos(DateTime lastUpdate)
        {
            List<materias_primas> lista = repositorio.GetMaterialesNuevos(lastUpdate);
            return lista;
        }

        #region Auxiliares

        string MensajeError(int codigo)
        {
            switch (codigo)
            {
                case 1451:
                    return "El material se encuentra en uso.";
                default:
                    return "No se pudo eliminar el material";
            }

        }

        public MateriasPrimasModel ConvertirModelo(materias_primas materia)
        {
            MateriasPrimasModel modelo = new MateriasPrimasModel();
            modelo.id = materia.id;
            modelo.codigo = materia.codigo;
            modelo.descripcion = materia.descripcion;
            modelo.unidades_medida_id = materia.unidades_medida_id;
            modelo.materia_prima_sn = materia.materia_prima_sn;
            modelo.created_at = materia.created_at;
            modelo.updated_at = materia.updated_at;

            return modelo;
        }

        #endregion

    }
}

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
    public class RolesModel
    {
        #region Atributos

        private int id;
        private string name;
        private string guard_name;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private RolesRepositorio repositorio;

        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Guard_name { get => guard_name; set => guard_name = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }


        #endregion

        public RolesModel()
        {
            repositorio = new RolesRepositorio();
        }

        #region CRUD
        public roles FindById(int id)
        {
            roles unTipo = repositorio.FindRolById(id);
            return unTipo;
        }
        public List<roles> GetAll()
        {
            List<roles> lista = repositorio.GetAllRoles();
            return lista;
        }
        public Resultado Insertar(roles rol)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(rol);

            if (validador.Validar())
            {
                if (repositorio.InsertarRol(rol))
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

        public Resultado Editar(roles rol)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(rol);

            if (validador.Validar())
            {
                if (repositorio.EditarRol(rol))
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

        public Resultado Eliminar(roles rol)
        {
            Resultado resultado = new Resultado();

            if (repositorio.EliminarRol(rol))
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

        public RolesModel ConvertirModelo(roles rol)
        {
            RolesModel modelo = new RolesModel();
            modelo.id = rol.id;
            modelo.name = rol.name;
            modelo.guard_name = rol.guard_name;
            modelo.created_at = rol.created_at;
            modelo.updated_at = rol.updated_at;

            return modelo;
        }

        #endregion
    }
}

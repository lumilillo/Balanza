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
    public class PermisosModelo
    {
        #region Atributos

        private int id;
        private string name;
        private string guard_name;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private PermisosRepositorio repositorio;

        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Guard_name { get => guard_name; set => guard_name = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }


        #endregion

        public PermisosModelo()
        {
            repositorio = new PermisosRepositorio();
        }

        #region CRUD
        public permissions FindById(int id)
        {
            permissions unTipo = repositorio.FindPermisoById(id);
            return unTipo;
        }
        public List<permissions> GetAll()
        {
            List<permissions> lista = repositorio.GetAllPermisos();
            return lista;
        }
        public Resultado Insertar(permissions permiso)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(permiso);

            if (validador.Validar())
            {
                if (repositorio.InsertarPermiso(permiso))
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

        public Resultado Editar(permissions permiso)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(permiso);

            if (validador.Validar())
            {
                if (repositorio.EditarPermiso(permiso))
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

        public Resultado Eliminar(permissions permiso)
        {
            Resultado resultado = new Resultado();

            if (repositorio.EliminarPermiso(permiso))
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

        public List<permissions> GetPermisosByUsuario(int userId)
        {
            List<permissions> lista = repositorio.GetPermisosByUsuario(userId);
            return lista;
        }

        #region Auxiliares

        public PermisosModelo ConvertirModelo(permissions permiso)
        {
            PermisosModelo modelo = new PermisosModelo();
            modelo.id = permiso.id;
            modelo.name = permiso.name;
            modelo.guard_name = permiso.guard_name;
            modelo.created_at = permiso.created_at;
            modelo.updated_at = permiso.updated_at;

            return modelo;
        }

        #endregion
    }
}

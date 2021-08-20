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
    public class UsersModel
    {
        #region Atributos

        private int id;
        private string name;
        private int dni;
        private int? legajo;
        private string email;
        private Nullable<DateTime> email_verified_at;
        private string password;
        private string api_token;
        private string remember_token;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private UsersRepositorio repositorio;

        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Dni { get => dni; set => dni = value; }
        public int? Legajo { get => legajo; set => legajo = value; }
        public string Email { get => email; set => email = value; }
        public Nullable<DateTime> Email_verified_at { get => email_verified_at; set => email_verified_at = value; }
        public string Password { get => password; set => password = value; }
        public string Api_token { get => api_token; set => api_token = value; }
        public string Remember_token { get => remember_token; set => remember_token = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }


        #endregion

        public UsersModel()
        {
            repositorio = new UsersRepositorio();
        }

        #region CRUD
        public users FindById(int id)
        {
            users unTipo = repositorio.FindByUserId(id);
            return unTipo;
        }
        public List<users> GetAll()
        {
            List<users> lista = repositorio.GetAllUsers();
            return lista;
        }
        public Resultado Insertar(users user)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(user);

            if (validador.Validar())
            {
                if (repositorio.InsertarUser(user))
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
        public Resultado Editar(users user)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(user);

            if (validador.Validar())
            {
                if (repositorio.EditarUser(user))
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
        public Resultado Eliminar(users user)
        {
            Resultado resultado = new Resultado();

            if (repositorio.EliminarUser(user))
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

        public users FindByDni(int dni)
        {
            users unTipo = repositorio.FindByDni(dni);
            return unTipo;
        }

        #region Auxiliares

        public UsersModel ConvertirModelo(users user)
        {
            UsersModel modelo = new UsersModel();
            modelo.id = user.id;
            modelo.name = user.name;
            modelo.dni = user.dni;
            modelo.legajo = user.legajo;
            modelo.email = user.email;
            modelo.email_verified_at = user.email_verified_at;
            modelo.password = user.password;
            modelo.api_token = user.api_token;
            modelo.remember_token = user.remember_token;
            modelo.created_at = user.created_at;
            modelo.updated_at = user.updated_at;

            return modelo;
        }

        #endregion
    }
}


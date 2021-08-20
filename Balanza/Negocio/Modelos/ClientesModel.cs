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
    public class ClientesModel
    {
        #region Atributos

        private int id;
        private string razon_social;
        private string domicilio;
        private string cp;
        private int? localidad_id;
        private string cuit;
        private int? user_id;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private ClientesReposotorio repositorio;

        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Razon_social { get => razon_social; set => razon_social = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Cp { get => cp; set => cp = value; }
        public int? Localidades_id { get => localidad_id; set => localidad_id = value; }
        public string Cuit { get => cuit; set => cuit = value; }
        public int? Users_id { get => user_id; set => user_id = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }

        #endregion

        public ClientesModel()
        {
            repositorio = new ClientesReposotorio();
        }

        #region CRUD
        public clientes FindById(int id)
        {
            clientes unTipo = repositorio.FindClienteById(id);
            return unTipo;
        }
        public List<clientes> GetAll()
        {
            List<clientes> lista = repositorio.GetAllClientes();
            return lista;
        }
        public Resultado Insertar(clientes cliente)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(cliente);

            if (validador.Validar())
            {
                if (repositorio.InsertarCliente(cliente))
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
        public Resultado Editar(clientes cliente)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(cliente);

            if (validador.Validar())
            {
                if (repositorio.EditarCliente(cliente))
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
        public Resultado Eliminar(clientes cliente)
        {
            Resultado resultado = new Resultado();
            int codigo = 0;

            codigo = repositorio.EliminarCliente(cliente);

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

        public List<clientes> GetAllConLocalidad()
        {
            List<clientes> lista = repositorio.GetClientesConLocalidad();
            return lista;
        }

        #region Auxiliares

        public ClientesModel ConvertirModelo(clientes cliente)
        {
            ClientesModel modelo = new ClientesModel();
            modelo.id = cliente.id;
            modelo.razon_social = cliente.razon_social;
            modelo.domicilio = cliente.domicilio;
            modelo.cp = cliente.cp;
            modelo.localidad_id = cliente.localidad_id;
            modelo.cuit = cliente.cuit;
            modelo.user_id = cliente.user_id;
            modelo.created_at = cliente.created_at;
            modelo.updated_at = cliente.updated_at;

            return modelo;
        }

        public string MensajeError(int codigo)
        {
            switch(codigo)
            {
                case 1451:
                    return "Cliente en uso.";
                    break;

                default:
                    return "No se pudo eliminar el cliente.";
                    break;
            }
        }

        #endregion
    }
}

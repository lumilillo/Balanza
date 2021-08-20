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
    public class ProveedorModel
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
        private ProveedoresRepositorio repositorio;

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

        public ProveedorModel()
        {
            repositorio = new ProveedoresRepositorio();
        }

        #region CRUD
        public proveedores FindById(int id)
        {
            proveedores unTipo = repositorio.FindProveedorById(id);
            return unTipo;
        }
        public List<proveedores> GetAll()
        {
            List<proveedores> lista = repositorio.GetAllProveedores();
            return lista;
        }
        public Resultado Insertar(proveedores proveedor)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(proveedor);

            if (validador.Validar())
            {
                if (repositorio.InsertarProveedor(proveedor))
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
        public Resultado Editar(proveedores proveedor)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(proveedor);

            if (validador.Validar())
            {
                if (repositorio.EditarProveedor(proveedor))
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
        public Resultado Eliminar(proveedores proveedor)
        {
            Resultado resultado = new Resultado();
            int codigo = 0;

            codigo = repositorio.EliminarProveedor(proveedor);

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

        public List<proveedores> GetAllConLocalidad()
        {
            List<proveedores> lista = repositorio.GetProveedoresConLocalidad();
            return lista;
        }

        #region Auxiliares

        public ProveedorModel ConvertirModelo(proveedores proveedor)
        {
            ProveedorModel modelo = new ProveedorModel();
            modelo.id = proveedor.id;
            modelo.razon_social = proveedor.razon_social;
            modelo.domicilio = proveedor.domicilio;
            modelo.cp = proveedor.cp;
            modelo.localidad_id = proveedor.localidad_id;
            modelo.cuit = proveedor.cuit;
            modelo.user_id = proveedor.user_id;
            modelo.created_at = proveedor.created_at;
            modelo.updated_at = proveedor.updated_at;

            return modelo;
        }

        public string MensajeError(int codigo)
        {
            switch(codigo)
            {
                case 1451:
                    return "Proveedor en uso.";
                    break;

                default:
                    return "No se pudo eliminar el proveedor.";
                    break;
            }
        }

        #endregion
    }
}

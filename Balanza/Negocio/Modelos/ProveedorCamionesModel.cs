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
    public class ProveedorCamionesModel
    {
        #region Atributos

        private int id;
        private int tipo_camion_id;
        private int proveedor_id;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private ProveedorCamionesRepositorio repositorio;

        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public int Tipo_camion_id { get => tipo_camion_id; set => tipo_camion_id = value; }
        public int Proveedor_id { get => proveedor_id; set => proveedor_id = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }

        #endregion

        public ProveedorCamionesModel()
        {
            repositorio = new ProveedorCamionesRepositorio();
        }

        #region CRUD
        public proveedor_camiones FindById(int id)
        {
            proveedor_camiones unTipo = repositorio.FindProveedorCamionById(id);
            return unTipo;
        }
        public proveedor_camiones FindByCamionId(int id)
        {
            proveedor_camiones unTipo = repositorio.FindByCamionId(id);
            return unTipo;
        }

        public proveedor_camiones FindByCamionYProveedor(int idCamion, int idProveedor)
        {
            proveedor_camiones unTipo = repositorio.FindByProveedorYCamion(idCamion, idProveedor);
            return unTipo;
        }

        public List<proveedor_camiones> GetAll()
        {
            List<proveedor_camiones> lista = repositorio.GetAllCamionesProveedores();
            return lista;
        }
        public Resultado Insertar(proveedor_camiones Camion)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(Camion);

            if (validador.Validar())
            {
                if (repositorio.InsertarCamionProveedor(Camion))
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
        public Resultado Editar(proveedor_camiones camion)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(camion);

            if (validador.Validar())
            {
                if (repositorio.EditarCamionProveedor(camion))
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
        public Resultado Eliminar(proveedor_camiones camion)
        {
            Resultado resultado = new Resultado();
            int codigo = 0;

            codigo = repositorio.EliminarCamionProveedor(camion);

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

        #region Auxiliares

        string MensajeError(int codigo)
        {
            switch(codigo)
            {
                case 1451:
                    return "Camión del proveedor en uso.";
                default:
                    return "No se pudo eliminar el camión del proveedor";
            }
        }
        public ProveedorCamionesModel ConvertirModelo(proveedor_camiones camion)
        {
            ProveedorCamionesModel modelo = new ProveedorCamionesModel();
            modelo.id = camion.id;
            modelo.tipo_camion_id = camion.camion_id;
            modelo.proveedor_id = camion.proveedor_id;
            modelo.created_at = camion.created_at;
            modelo.updated_at = camion.updated_at;

            return modelo;
        }

        #endregion
    }
}

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
    public class ClienteCamionesModel
    {
        #region Atributos

        private int id;
        private int tipo_camion_id;
        private int cliente_id;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private ClienteCamionesRepositorio repositorio;

        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public int Tipo_camion_id { get => tipo_camion_id; set => tipo_camion_id = value; }
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }

        #endregion

        public ClienteCamionesModel()
        {
            repositorio = new ClienteCamionesRepositorio();
        }

        #region CRUD
        public cliente_camiones FindById(int id)
        {
            cliente_camiones unTipo = repositorio.FindClienteCamionById(id);
            return unTipo;
        }
        public List<cliente_camiones> GetAll()
        {
            List<cliente_camiones> lista = repositorio.GetAllCamionesCliente();
            return lista;
        }
        public Resultado Insertar(cliente_camiones Camion)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(Camion);

            if (validador.Validar())
            {
                if (repositorio.InsertarCamionCliente(Camion))
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
        public Resultado Editar(cliente_camiones camion)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(camion);

            if (validador.Validar())
            {
                if (repositorio.EditarCamionCliente(camion))
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
        public Resultado Eliminar(cliente_camiones camion)
        {
            Resultado resultado = new Resultado();
            int codigo = 0;

            codigo = repositorio.EliminarCamionCliente(camion);

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
        public cliente_camiones FindByCamionId(int id)
        {
            cliente_camiones unTipo = repositorio.FindByCamionId(id);
            return unTipo;
        }

        public cliente_camiones FindByCamionYCliente(int idCamion, int idCliente)
        {
            cliente_camiones unTipo = repositorio.FindByClienteYCamion(idCamion, idCliente);
            return unTipo;
        }

        #endregion

        #region Auxiliares

        public string MensajeError(int codigo)
        {
            switch(codigo)
            {
                case 1451:
                    return "Camión de cliente en uso.";
                default:
                    return "No se pudo eliminar el Camión de cliente";
            }
        }

        public ClienteCamionesModel ConvertirModelo(cliente_camiones camion)
        {
            ClienteCamionesModel modelo = new ClienteCamionesModel();
            modelo.id = camion.id;
            modelo.tipo_camion_id = camion.camion_id;
            modelo.cliente_id = camion.cliente_id;
            modelo.created_at = camion.created_at;
            modelo.updated_at = camion.updated_at;

            return modelo;
        }

        #endregion
    }
}

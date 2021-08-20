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
    public class CamionesModel
    {
        #region Atributos

        private int id;
        private string patente_chasis;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private CamionesRepositorio repositorio;

        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Patente_chasis { get => patente_chasis; set => patente_chasis = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }

        #endregion

        public CamionesModel()
        {
            repositorio = new CamionesRepositorio();
        }

        #region CRUD
        public camiones FindById(int id)
        {
            camiones unTipo = repositorio.FindByCamionId(id);
            return unTipo;
        }

        public List<camiones> GetAll()
        {
            List<camiones> lista = repositorio.GetAllCamiones();
            return lista;
        }

        public List<camiones> GetCamionesByProveedor(int id)
        {
            List<camiones> lista = repositorio.GetCamionesByProveedor(id);
            return lista;
        }

        public List<camiones> GetCamionesByCliente(int id)
        {
            List<camiones> lista = repositorio.GetCamionesByCliente(id);
            return lista;
        }

        public List<camiones> GetCamionesConTipo()
        {
            List<camiones> lista = repositorio.GetCamionesConTipo();
            return lista;
        }

        public List<camiones> GetCamionesProveedorConTipo(int id)
        {
            List<camiones> lista = repositorio.GetCamionesProveedorConTipo(id);
            return lista;
        }

        public List<camiones> GetCamionesClienteConTipo(int id)
        {
            List<camiones> lista = repositorio.GetCamionesClienteConTipo(id);
            return lista;
        }

        public Resultado Insertar(camiones camion)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(camion);

            if (validador.Validar())
            {
                if (repositorio.InsertarCamion(camion))
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
        public Resultado Editar(camiones camion)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(camion);

            if (validador.Validar())
            {
                if (repositorio.EditarCamion(camion))
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
        public Resultado Eliminar(camiones camion)
        {
            Resultado resultado = new Resultado();
            int codigo = repositorio.EliminarCamion(camion);

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

        public camiones FindByPatente(string patente)
        {
            camiones unTipo = repositorio.FindByPatente(patente);
            return unTipo;
        }

        public int FindLastId()
        {
            int id = repositorio.FindLastId();
            return id;
        }

        #endregion

        #region Auxiliares

        public string MensajeError(int codigo)
        {
            switch(codigo)
            {
                case 1451:
                    return "Camión en uso";


                default:
                    return "Error al eliminar.";

            }
        }

        public CamionesModel ConvertirModelo(camiones camion)
        {
            CamionesModel modelo = new CamionesModel();
            modelo.id = camion.id;
            modelo.patente_chasis = camion.patente_chasis;
            modelo.created_at = camion.created_at;
            modelo.updated_at = camion.updated_at;

            return modelo;
        }

        #endregion
    }
}

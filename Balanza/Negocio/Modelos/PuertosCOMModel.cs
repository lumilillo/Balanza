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
    public class PuertosCOMModel
    {
        #region Atributos

        private int id;
        private string ubicacion;
        private string port_name;
        private int data_bits;
        private int baud_rate;
        private string parity;
        private string stop_bits;
        private bool discard_null;
        private int? threshold;
        private PuertosCOMRepositorio repositorio;

        #endregion

        #region Propiedades

        public int Id { get => id; set => id = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Port_name { get => port_name; set => port_name = value; }
        public int Data_bits { get => data_bits; set => data_bits = value; }
        public int Baud_rate { get => baud_rate; set => baud_rate = value; }
        public string Parity { get => parity; set => parity = value; }
        public string Stop_bits { get => stop_bits; set => stop_bits = value; }
        public bool Discard_null { get => discard_null; set => discard_null = value; }
        public int? Threshold { get => threshold; set => threshold = value; }

        #endregion

        public PuertosCOMModel()
        {
            repositorio = new PuertosCOMRepositorio();
        }

        #region CRUD
        public puerto_com FindById(int id)
        {
            puerto_com unTipo = repositorio.FindPuertoById(id);
            return unTipo;
        }
        public List<puerto_com> GetAll()
        {
            List<puerto_com> lista = repositorio.GetAllPuertos();
            return lista;
        }
        public Resultado Insertar(puerto_com puerto)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(puerto);

            if (validador.Validar())
            {
                if (repositorio.InsertarPuerto(puerto))
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
        public Resultado Editar(puerto_com puerto)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(puerto);

            if (validador.Validar())
            {
                if (repositorio.EditarPuerto(puerto))
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
        public Resultado Eliminar(puerto_com puerto)
        {
            Resultado resultado = new Resultado();

            if (repositorio.EliminarPuerto(puerto))
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

        #region METODOS PROPIOS

        public puerto_com FindByUbicacion(string ubicacion)
        {
            puerto_com port = repositorio.FindPuertoByUbicacion(ubicacion);
            return port;
        }


        #endregion

        #region Auxiliares

        public PuertosCOMModel ConvertirModelo(puerto_com unidad)
        {
            PuertosCOMModel modelo = new PuertosCOMModel();
            modelo.id = unidad.id;
            modelo.ubicacion = unidad.ubicacion;
            modelo.port_name = unidad.port_name;
            modelo.data_bits = unidad.data_bits;
            modelo.baud_rate = unidad.baud_rate;
            modelo.parity = unidad.parity;
            modelo.stop_bits = unidad.stop_bits;
            modelo.discard_null = unidad.discard_null;
            modelo.threshold = unidad.threshold;

            return modelo;
        }

        #endregion
    }
}

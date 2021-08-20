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
    public class MovimientosCamionesModel
    {
        #region Atributos

        private int id;
        private int registros_tarjeta_id;
        private bool balanza_entrada_sn;
        private bool? balanza_salida_sn;
        private DateTime fecha_entrada;
        private Nullable<DateTime> fecha_salida;
        private int peso_entrada;
        private int? peso_salida;
        private string observaciones;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private MovimientosCamionesRepositorio repositorio;

        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public int Registros_tarjeta_id { get => registros_tarjeta_id; set => registros_tarjeta_id = value; }
        public DateTime Fecha_entrada { get => fecha_entrada; set => fecha_entrada = value; }
        public DateTime? Fecha_salida { get => fecha_salida; set => fecha_salida = value; }
        public int Peso_entrada { get => peso_entrada; set => peso_entrada = value; }
        public int? Peso_salida { get => peso_salida; set => peso_salida = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public bool Balanza_entrada_sn { get => balanza_entrada_sn; set => balanza_entrada_sn = value; }
        public bool? Balanza_salida_sn { get => balanza_salida_sn; set => balanza_salida_sn = value; }


        #endregion

        public MovimientosCamionesModel()
        {
            repositorio = new MovimientosCamionesRepositorio();
        }

        #region CRUD
        public movimientos_camiones FindById(int id)
        {
            movimientos_camiones unTipo = repositorio.FindMovimientoById(id);
            return unTipo;
        }
        public List<movimientos_camiones> GetAll()
        {
            List<movimientos_camiones> lista = repositorio.GetAllMovimientos();
            return lista;
        }
        public Resultado Insertar(movimientos_camiones movimiento)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(movimiento);

            if (validador.Validar())
            {
                if (repositorio.InsertarMovimiento(movimiento))
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
        public Resultado Editar(movimientos_camiones movimiento)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(movimiento);

            if (validador.Validar())
            {
                if (repositorio.EditarMovimiento(movimiento))
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
        public Resultado Eliminar(movimientos_camiones movimiento)
        {
            Resultado resultado = new Resultado();

            if (repositorio.EliminarMovimiento(movimiento))
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

        public movimientos_camiones FindUltimoMovimientoByRegistro(int id)
        {
            movimientos_camiones unTipo = repositorio.FindUltimoMovimientoByRegistro(id);
            return unTipo;
        }

        public List<movimientos_camiones> GetAllMovimientosByRegistro(int id)
        {
            List<movimientos_camiones> lista = repositorio.GetAllMovimientosByRegistro(id);
            return lista;
        }

        public List<movimientos_camiones> GetAllMovimientosByDate(DateTime desde, DateTime hasta)
        {
            List<movimientos_camiones> lista = repositorio.GetAllMovimientosByDate(desde, hasta);
            return lista;
        }

        public List<movimientos_camiones> GetAllMovimientosFiltrados(DateTime? desde, DateTime? hasta, int? id)
        {
            List<movimientos_camiones> lista = repositorio.GetAllMovimientosFiltrados(desde, hasta, id);
            return lista;
        }

        public List<movimientos_camiones> GetAllMovimientosIncoherentes()
        {
            List<movimientos_camiones> lista = repositorio.GetAllMovimientosIncoherentes();
            return lista;
        }

        #region Auxiliares

        public MovimientosCamionesModel ConvertirModelo(movimientos_camiones movimiento)
        {
            MovimientosCamionesModel modelo = new MovimientosCamionesModel();

            modelo.id = movimiento.id;
            modelo.registros_tarjeta_id = movimiento.registros_tarjeta_id;
            modelo.fecha_entrada = movimiento.fecha_entrada;
            modelo.fecha_salida = movimiento.fecha_salida;
            modelo.peso_entrada = movimiento.peso_entrada;
            modelo.peso_salida = movimiento.peso_salida;
            modelo.created_at = movimiento.created_at;
            modelo.updated_at = movimiento.updated_at;
            modelo.balanza_entrada_sn = movimiento.balanza_entrada_sn;
            modelo.balanza_salida_sn = movimiento.balanza_salida_sn;

            return modelo;
        }

        #endregion
    }
}


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
    public class RegistrosTarjetasModelo
    {
        #region Atributos

        private int id;
        private DateTime fecha;
        private string nro_tarjeta;
        private int? cliente_id;
        private int camion_id;
        private string patente_acoplado;
        private int? proveedor_id;
        private bool carga_sn;
        private bool descarga_sn;
        private bool devolucion_sn;
        private int materias_primas_id;
        private string nombre;
        private string observacion_planta;
        private string observacion_web;
        private bool habilitado_sn;
        private int user_id;
        private Nullable<DateTime> created_at;
        private Nullable<DateTime> updated_at;
        private RegistrosTarjetasRepositorio repositorio;

        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Nro_tarjeta { get => nro_tarjeta; set => nro_tarjeta = value; }
        public int? Cliente_id { get => cliente_id; set => cliente_id = value; }
        public string Patente_acoplado { get => patente_acoplado; set => patente_acoplado = value; }
        public int? Proveedor_id { get => proveedor_id; set => proveedor_id = value; }
        public int Camion_id { get => camion_id; set => camion_id = value; }
        public bool Carga_sn { get => carga_sn; set => carga_sn = value; }
        public bool Descarga_sn { get => descarga_sn; set => descarga_sn = value; }
        public bool Devolucion_sn { get => devolucion_sn; set => devolucion_sn = value; }
        public int Materias_primas_id { get => materias_primas_id; set => materias_primas_id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Observacion_planta { get => observacion_planta; set => observacion_planta = value; }
        public string Observacion_web { get => observacion_web; set => observacion_web = value; }
        public bool Habilitado_sn { get => habilitado_sn; set => habilitado_sn = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public DateTime? Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }




        #endregion

        public RegistrosTarjetasModelo()
        {
            repositorio = new RegistrosTarjetasRepositorio();
        }

        #region CRUD
        public registros_tarjetas FindById(int id)
        {
            registros_tarjetas unTipo = repositorio.FindRegistroTarjetaById(id);
            return unTipo;
        }
        public List<registros_tarjetas> GetAll()
        {
            List<registros_tarjetas> lista = repositorio.GetAllRegistroTarjeta();
            return lista;
        }
        public Resultado Insertar(registros_tarjetas registro)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(registro);

            if (validador.Validar())
            {
                if (repositorio.InsertarRegistroTarjeta(registro))
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
        public Resultado Editar(registros_tarjetas registro)
        {
            Resultado resultado = new Resultado();
            Validador validador = new Validador(registro);

            if (validador.Validar())
            {
                if (repositorio.EditarRegistroTarjeta(registro))
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
        public Resultado Eliminar(registros_tarjetas registro)
        {
            Resultado resultado = new Resultado();

            if (repositorio.EliminarRegistroTarjeta(registro))
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

        public List<registros_tarjetas> GetAllRegistros(DateTime desde, DateTime hasta)
        {
            List<registros_tarjetas> lista = repositorio.GetAllRegistroTarjetaMovimientos(desde, hasta);
            return lista;
        }

        public registros_tarjetas FindUltimoRegistro(string nroTarjeta)
        {
            registros_tarjetas unRegistro = repositorio.FindUltimoRegistro(nroTarjeta);
            return unRegistro;
        }

        #region Auxiliares

        public RegistrosTarjetasModelo ConvertirModelo(registros_tarjetas registro)
        {
            RegistrosTarjetasModelo modelo = new RegistrosTarjetasModelo();
            modelo.id = registro.id;
            modelo.fecha = registro.fecha;
            modelo.nro_tarjeta = registro.nro_tarjeta;
            modelo.cliente_id = registro.cliente_id;
            modelo.proveedor_id = registro.proveedor_id;
            modelo.camion_id = registro.camion_id;
            modelo.patente_acoplado = registro.patente_acoplado;
            modelo.carga_sn = registro.carga_sn;
            modelo.descarga_sn = registro.descarga_sn;
            modelo.devolucion_sn = registro.devolucion_sn;
            modelo.materias_primas_id = registro.materias_primas_id;
            modelo.nombre = registro.nombre;
            modelo.observacion_planta = registro.observacion_planta;
            modelo.observacion_web = registro.observacion_web;
            modelo.habilitado_sn = registro.habilitado_sn;
            modelo.user_id = registro.user_id;
            modelo.created_at = registro.created_at;
            modelo.updated_at = registro.updated_at;

            return modelo;
        }

        #endregion
    }
}


using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class RegistrosTarjetasRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "registros_tarjetas";
        }
        protected override string[] GetColumnas()
        {
            return new string[18] { "id", "fecha", "nro_tarjeta", "cliente_id", "proveedor_id"
                                  , "camion_id", "patente_acoplado", "materiales_id", "carga_sn"
                                  , "descarga_sn", "devolucion_sn", "nombre", "observacion_planta"
                                  , "observacion_web", "habilitado_sn", "user_id", "created_at", "updated_at" };
        }
        public registros_tarjetas FindRegistroTarjetaById(int id)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = FindById(id);
            comando.Connection = conexion;

            MySqlDataReader reader = null;

            try
            {
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    return ConvertirEntidad(reader);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }
        public bool InsertarRegistroTarjeta(registros_tarjetas registro)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", registro.id);
            comando.Parameters.AddWithValue("@fecha", registro.fecha);
            comando.Parameters.AddWithValue("@nro_tarjeta", registro.nro_tarjeta);
            comando.Parameters.AddWithValue("@cliente_id", registro.cliente_id);
            comando.Parameters.AddWithValue("@proveedor_id", registro.proveedor_id);
            comando.Parameters.AddWithValue("@camion_id", registro.camion_id);
            comando.Parameters.AddWithValue("@patente_acoplado", registro.patente_acoplado);
            comando.Parameters.AddWithValue("@materiales_id", registro.materias_primas_id);
            comando.Parameters.AddWithValue("@carga_sn", registro.carga_sn);
            comando.Parameters.AddWithValue("@descarga_sn", registro.descarga_sn);
            comando.Parameters.AddWithValue("@devolucion_sn", registro.devolucion_sn);
            comando.Parameters.AddWithValue("@nombre", registro.nombre);
            comando.Parameters.AddWithValue("@observacion_planta", registro.observacion_planta);
            comando.Parameters.AddWithValue("@observacion_web", registro.observacion_web);
            comando.Parameters.AddWithValue("@habilitado_sn", registro.habilitado_sn);
            comando.Parameters.AddWithValue("@user_id", registro.user_id);
            comando.Parameters.AddWithValue("@created_at", registro.created_at);
            comando.Parameters.AddWithValue("@updated_at", registro.updated_at);

            try
            {
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        public bool EditarRegistroTarjeta(registros_tarjetas registro)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(registro.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@fecha", registro.fecha);
            comando.Parameters.AddWithValue("@nro_tarjeta", registro.nro_tarjeta);
            comando.Parameters.AddWithValue("@cliente_id", registro.cliente_id);
            comando.Parameters.AddWithValue("@proveedor_id", registro.proveedor_id);
            comando.Parameters.AddWithValue("@camion_id", registro.camion_id);
            comando.Parameters.AddWithValue("@patente_acoplado", registro.patente_acoplado);
            comando.Parameters.AddWithValue("@materiales_id", registro.materias_primas_id);
            comando.Parameters.AddWithValue("@carga_sn", registro.carga_sn);
            comando.Parameters.AddWithValue("@descarga_sn", registro.descarga_sn);
            comando.Parameters.AddWithValue("@devolucion_sn", registro.devolucion_sn);
            comando.Parameters.AddWithValue("@nombre", registro.nombre);
            comando.Parameters.AddWithValue("@observacion_planta", registro.observacion_planta);
            comando.Parameters.AddWithValue("@observacion_web", registro.observacion_web);
            comando.Parameters.AddWithValue("@habilitado_sn", registro.habilitado_sn);
            comando.Parameters.AddWithValue("@user_id", registro.user_id);
            comando.Parameters.AddWithValue("@created_at", registro.created_at);
            comando.Parameters.AddWithValue("@updated_at", registro.updated_at);

            try
            {
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        public bool EliminarRegistroTarjeta(registros_tarjetas registro)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(registro.id);
            comando.Connection = conexion;

            try
            {
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        public List<registros_tarjetas> GetAllRegistroTarjeta()
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = GetAll();
            comando.Connection = conexion;

            MySqlDataReader reader = null;

            try
            {
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    return ConvertirLista(reader);
                }
                else
                {
                    return null;
                }
            }
            catch (MySqlException ex)
            {
                return null;
            }

            finally
            {
                conexion.Close();
            }
        }

        public registros_tarjetas FindUltimoRegistro(string nroTarjeta)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getUltimoRegistroTarjeta";
            comando.Connection = conexion;
            comando.Parameters.Add(new MySqlParameter("pNro_Tarjeta", MySqlDbType.VarChar)).Value = nroTarjeta;

            MySqlDataReader reader = null;

            try
            {
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    return ConvertirEntidad(reader);
                }
                else
                {
                    return null;
                }
            }
            catch (MySqlException ex)
            {
                return null;
            }

            finally
            {
                conexion.Close();
            }

        }

        public List<registros_tarjetas> GetAllRegistroTarjetaMovimientos(DateTime desde, DateTime hasta)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getRegistrosTarjeta";
            comando.Connection = conexion;
            comando.Parameters.Add(new MySqlParameter("desde", MySqlDbType.Timestamp)).Value = desde;
            comando.Parameters.Add(new MySqlParameter("hasta", MySqlDbType.Timestamp)).Value = hasta;


            MySqlDataReader reader = null;

            try
            {
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    return ConvertirListaMovimientos(reader);
                }
                else
                {
                    return null;
                }
            }
            catch (MySqlException ex)
            {
                return null;
            }

            finally
            {
                conexion.Close();
            }
        }

        List<registros_tarjetas> ConvertirLista(MySqlDataReader reader)
        {
            List<registros_tarjetas> lista = new List<registros_tarjetas>();
            registros_tarjetas registro;

            while (reader.Read())
            {
                registro = new registros_tarjetas();

                registro.id = Convert.ToInt32(reader.GetString(0));
                registro.fecha = Convert.ToDateTime(reader[1]);
                registro.nro_tarjeta = reader.GetString(2);
                registro.cliente_id = (reader[3] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[3]);
                registro.proveedor_id = (reader[4] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[4]);
                registro.camion_id = Convert.ToInt32(reader.GetString(5));
                registro.patente_acoplado = (reader[6] == DBNull.Value) ? (string)null : Convert.ToString(reader[6]);
                registro.materias_primas_id = Convert.ToInt32(reader[7]);
                registro.carga_sn = Convert.ToBoolean(reader[8]);
                registro.descarga_sn = Convert.ToBoolean(reader[9]);
                registro.devolucion_sn = Convert.ToBoolean(reader[10]);
                registro.nombre = (reader[11] == DBNull.Value) ? (string)null : Convert.ToString(reader[11]);
                registro.observacion_planta = (reader[12] == DBNull.Value) ? (string)null : Convert.ToString(reader[12]);
                registro.observacion_web = (reader[13] == DBNull.Value) ? (string)null : Convert.ToString(reader[13]);
                registro.habilitado_sn = Convert.ToBoolean(reader[14]);
                registro.user_id = Convert.ToInt32(reader[15]);
                registro.created_at = (reader[16] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[16]);
                registro.updated_at = (reader[17] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[17]);

                lista.Add(registro);
            }

            return lista;
        }

        List<registros_tarjetas> ConvertirListaMovimientos(MySqlDataReader reader)
        {
            List<registros_tarjetas> lista = new List<registros_tarjetas>();
            registros_tarjetas registro;

            while (reader.Read())
            {
                registro = new registros_tarjetas();

                registro.id = Convert.ToInt32(reader.GetString(0));
                registro.fecha = Convert.ToDateTime(reader[1]);
                registro.nro_tarjeta = reader.GetString(2);
                registro.cliente_id = (reader[3] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[3]);
                registro.proveedor_id = (reader[4] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[4]);
                registro.camion_id = Convert.ToInt32(reader.GetString(5));
                registro.patente_acoplado = (reader[6] == DBNull.Value) ? (string)null : Convert.ToString(reader[6]);
                registro.materias_primas_id = Convert.ToInt32(reader[7]);
                registro.carga_sn = Convert.ToBoolean(reader[8]);
                registro.descarga_sn = Convert.ToBoolean(reader[9]);
                registro.devolucion_sn = Convert.ToBoolean(reader[10]);
                registro.nombre = (reader[11] == DBNull.Value) ? (string)null : Convert.ToString(reader[11]);
                registro.observacion_planta = (reader[12] == DBNull.Value) ? (string)null : Convert.ToString(reader[12]);
                registro.observacion_web = (reader[13] == DBNull.Value) ? (string)null : Convert.ToString(reader[13]);
                registro.habilitado_sn = Convert.ToBoolean(reader[14]);
                registro.user_id = Convert.ToInt32(reader[15]);
                registro.created_at = (reader[16] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[16]);
                registro.updated_at = (reader[17] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[17]);
                registro.alerta_sn = Convert.ToBoolean(reader[18]);
                registro.tipo = (reader[19] == DBNull.Value) ? (string)null : Convert.ToString(reader[19]);
                registro.razon_social = (reader[20] == DBNull.Value) ? (string)null : Convert.ToString(reader[20]); 
                registro.material = (reader[21] == DBNull.Value) ? (string)null : Convert.ToString(reader[21]);
                registro.patente = (reader[22] == DBNull.Value) ? (string)null : Convert.ToString(reader[22]);

                lista.Add(registro);
            }

            return lista;
        }

        registros_tarjetas ConvertirEntidad(MySqlDataReader reader)
        {
            registros_tarjetas registro = new registros_tarjetas();

            while (reader.Read())
            {
                registro.id = Convert.ToInt32(reader.GetString(0));
                registro.fecha = Convert.ToDateTime(reader[1]);
                registro.nro_tarjeta = reader.GetString(2);
                registro.cliente_id = (reader[3] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[3]);
                registro.proveedor_id = (reader[4] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[4]);
                registro.camion_id = Convert.ToInt32(reader.GetString(5));
                registro.patente_acoplado = (reader[6] == DBNull.Value) ? (string)null : Convert.ToString(reader[6]);
                registro.materias_primas_id = Convert.ToInt32(reader[7]);
                registro.carga_sn = Convert.ToBoolean(reader[8]);
                registro.descarga_sn = Convert.ToBoolean(reader[9]);
                registro.devolucion_sn = Convert.ToBoolean(reader[10]);
                registro.nombre = (reader[11] == DBNull.Value) ? (string)null : Convert.ToString(reader[11]);
                registro.observacion_planta = (reader[12] == DBNull.Value) ? (string)null : Convert.ToString(reader[12]);
                registro.observacion_web = (reader[13] == DBNull.Value) ? (string)null : Convert.ToString(reader[13]);
                registro.habilitado_sn = Convert.ToBoolean(reader[14]);
                registro.user_id = Convert.ToInt32(reader[15]);
                registro.created_at = (reader[16] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[16]);
                registro.updated_at = (reader[17] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[17]);
            }

            return registro;
        }
    }
}

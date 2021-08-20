using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class MovimientosCamionesRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "movimientos_camiones";
        }
        protected override string[] GetColumnas()
        {
            return new string[15] { "id", "registros_tarjeta_id", "balanza_entrada_sn", "fecha_entrada", "peso_entrada", "balanza_salida_sn", "fecha_salida", "peso_salida", "created_at", "updated_at", "user_id", "observacion_planta", "observacion_web", "estado_id", "editado_sn" };
        }
        public movimientos_camiones FindMovimientoById(int id)
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

        public movimientos_camiones FindUltimoMovimientoByRegistro(int id)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getLastMovimientoByRegistro";
            comando.Connection = conexion;
            comando.Parameters.Add(new MySqlParameter("id", MySqlDbType.Int32)).Value = id;

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

        public bool InsertarMovimiento(movimientos_camiones movimiento)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", movimiento.id);
            comando.Parameters.AddWithValue("@registros_tarjeta_id", movimiento.registros_tarjeta_id);
            comando.Parameters.AddWithValue("@balanza_entrada_sn", movimiento.balanza_entrada_sn);
            comando.Parameters.AddWithValue("@fecha_entrada", movimiento.fecha_entrada);
            comando.Parameters.AddWithValue("@peso_entrada", movimiento.peso_entrada);
            comando.Parameters.AddWithValue("@balanza_salida_sn", movimiento.balanza_salida_sn ?? Convert.DBNull);
            comando.Parameters.AddWithValue("@fecha_salida", movimiento.fecha_salida);
            comando.Parameters.AddWithValue("@peso_salida", movimiento.peso_salida);
            comando.Parameters.AddWithValue("@created_at", movimiento.created_at);
            comando.Parameters.AddWithValue("@updated_at", movimiento.updated_at);
            comando.Parameters.AddWithValue("@user_id", movimiento.user_id);
            comando.Parameters.AddWithValue("@observacion_planta", movimiento.observacion_planta);
            comando.Parameters.AddWithValue("@observacion_web", movimiento.observacion_web);
            comando.Parameters.AddWithValue("@estado_id", movimiento.estado_id);
            comando.Parameters.AddWithValue("@editado_sn", movimiento.editado_sn);

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                conexion.Close();
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        public bool EditarMovimiento(movimientos_camiones movimiento)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(movimiento.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@registros_tarjeta_id", movimiento.registros_tarjeta_id);
            comando.Parameters.AddWithValue("@balanza_entrada_sn", movimiento.balanza_entrada_sn);
            comando.Parameters.AddWithValue("@fecha_entrada", movimiento.fecha_entrada);
            comando.Parameters.AddWithValue("@peso_entrada", movimiento.peso_entrada);
            comando.Parameters.AddWithValue("@balanza_salida_sn", movimiento.balanza_salida_sn ?? Convert.DBNull);
            comando.Parameters.AddWithValue("@fecha_salida", movimiento.fecha_salida);
            comando.Parameters.AddWithValue("@peso_salida", movimiento.peso_salida);
            comando.Parameters.AddWithValue("@created_at", movimiento.created_at);
            comando.Parameters.AddWithValue("@updated_at", movimiento.updated_at);
            comando.Parameters.AddWithValue("@user_id", movimiento.user_id);
            comando.Parameters.AddWithValue("@observacion_planta", movimiento.observacion_planta);
            comando.Parameters.AddWithValue("@observacion_web", movimiento.observacion_web);
            comando.Parameters.AddWithValue("@estado_id", movimiento.estado_id);
            comando.Parameters.AddWithValue("@editado_sn", movimiento.editado_sn);

            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                conexion.Close();
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        public bool EliminarMovimiento(movimientos_camiones movimiento)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(movimiento.id);
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

        public List<movimientos_camiones> GetAllMovimientos()
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

        public List<movimientos_camiones> GetAllMovimientosByRegistro(int registroId)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getMovimientosCamionesByRegistro";
            comando.Connection = conexion;
            comando.Parameters.Add(new MySqlParameter("id", MySqlDbType.Int32)).Value = registroId;

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

        public List<movimientos_camiones> GetAllMovimientosByDate(DateTime desde, DateTime hasta)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getMovimientosCamiones";
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

        public List<movimientos_camiones> GetAllMovimientosFiltrados(DateTime? desde, DateTime? hasta, int? id)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getMovimientosCamionesFiltrados";
            comando.Connection = conexion;
            comando.Parameters.Add(new MySqlParameter("@desde", MySqlDbType.Timestamp)).Value = desde;
            comando.Parameters.Add(new MySqlParameter("@hasta", MySqlDbType.Timestamp)).Value = hasta;
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;

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

        public List<movimientos_camiones> GetAllMovimientosIncoherentes()
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getMovimientosIncoherentes";
            comando.Connection = conexion;

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

        List<movimientos_camiones> ConvertirListaMovimientos(MySqlDataReader reader)
        {
            List<movimientos_camiones> lista = new List<movimientos_camiones>();
            movimientos_camiones movimiento;

            while (reader.Read())
            {
                movimiento = new movimientos_camiones();

                movimiento.id = Convert.ToInt32(reader.GetString(0));
                movimiento.registros_tarjeta_id = Convert.ToInt32(reader.GetString(1));
                movimiento.balanza_entrada_sn = Convert.ToBoolean(reader[2]);
                movimiento.fecha_entrada = Convert.ToDateTime(reader[3]);
                movimiento.peso_entrada = Convert.ToInt32(reader.GetString(4));
                movimiento.balanza_salida_sn = (reader[5] == DBNull.Value) ? (bool?)null : Convert.ToBoolean(reader[5]);
                movimiento.fecha_salida = (reader[6] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[6]);
                movimiento.peso_salida = (reader[7] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[7]);
                movimiento.created_at = (reader[8] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[8]);
                movimiento.updated_at = (reader[9] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[9]);
                movimiento.user_id = (reader[10] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[10]);
                movimiento.observacion_planta = (reader[11] == DBNull.Value) ? (string)null : Convert.ToString(reader[11]);
                movimiento.observacion_web = (reader[12] == DBNull.Value) ? (string)null : Convert.ToString(reader[12]);
                movimiento.estado_id = Convert.ToInt32(reader[13]);
                movimiento.editado_sn = Convert.ToBoolean(reader[14]);
                movimiento.correcto = Convert.ToBoolean(reader[15]);
                movimiento.razon_social = (reader[16] == DBNull.Value) ? (string)null : Convert.ToString(reader[16]);
                movimiento.material = (reader[17] == DBNull.Value) ? (string)null : Convert.ToString(reader[17]);
                movimiento.patente = (reader[18] == DBNull.Value) ? (string)null : Convert.ToString(reader[18]);
                movimiento.tarjeta = (reader[19] == DBNull.Value) ? (string)null : Convert.ToString(reader[19]);

                //AUTO CALCULABLE
                if (movimiento.peso_salida == null) { movimiento.peso_salida = 0; }

                movimiento.pesoFinal = (Math.Abs((decimal)movimiento.peso_entrada - (decimal)movimiento.peso_salida)) / 1000;
                movimiento.peso_entrada_tn = (decimal)movimiento.peso_entrada / 1000;

                if(movimiento.peso_salida != null && movimiento.peso_salida != 0)
                {
                    movimiento.peso_salida_tn = (decimal)movimiento.peso_salida / 1000;
                }

                lista.Add(movimiento);
            }

            return lista;
        }

        List<movimientos_camiones> ConvertirLista(MySqlDataReader reader)
        {
            List<movimientos_camiones> lista = new List<movimientos_camiones>();
            movimientos_camiones movimiento;

            while (reader.Read())
            {
                movimiento = new movimientos_camiones();

                movimiento.id = Convert.ToInt32(reader.GetString(0));
                movimiento.registros_tarjeta_id = Convert.ToInt32(reader.GetString(1));
                movimiento.balanza_entrada_sn = Convert.ToBoolean(reader[2]);
                movimiento.fecha_entrada = Convert.ToDateTime(reader[3]);
                movimiento.peso_entrada = Convert.ToInt32(reader.GetString(4));
                movimiento.balanza_salida_sn = (reader[5] == DBNull.Value) ? (bool?)null : Convert.ToBoolean(reader[5]);
                movimiento.fecha_salida = (reader[6] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[6]);
                movimiento.peso_salida = (reader[7] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[7]);
                movimiento.created_at = (reader[8] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[8]);
                movimiento.updated_at = (reader[9] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[9]);
                movimiento.user_id = (reader[10] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[10]);
                movimiento.observacion_planta = (reader[11] == DBNull.Value) ? (string)null : Convert.ToString(reader[11]);
                movimiento.observacion_web = (reader[12] == DBNull.Value) ? (string)null : Convert.ToString(reader[12]);
                movimiento.estado_id = Convert.ToInt32(reader[13]);
                movimiento.editado_sn = Convert.ToBoolean(reader[14]);

                lista.Add(movimiento);
            }

            return lista;
        }

        movimientos_camiones ConvertirEntidad(MySqlDataReader reader)
        {
            try
            {
                movimientos_camiones movimiento = new movimientos_camiones();

                while (reader.Read())
                {
                    movimiento.id = Convert.ToInt32(reader.GetString(0));
                    movimiento.registros_tarjeta_id = Convert.ToInt32(reader.GetString(1));
                    movimiento.balanza_entrada_sn = Convert.ToBoolean(reader[2]);
                    movimiento.fecha_entrada = Convert.ToDateTime(reader[3]);
                    movimiento.peso_entrada = Convert.ToInt32(reader.GetString(4));
                    movimiento.balanza_salida_sn = (reader[5] == DBNull.Value) ? (bool?)null : Convert.ToBoolean(reader[5]);
                    movimiento.fecha_salida = (reader[6] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[6]);
                    movimiento.peso_salida = (reader[7] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[7]);
                    movimiento.created_at = (reader[8] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[8]);
                    movimiento.updated_at = (reader[9] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[9]);
                    movimiento.user_id = (reader[10] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[10]);
                    movimiento.observacion_planta = (reader[11] == DBNull.Value) ? (string)null : Convert.ToString(reader[11]);
                    movimiento.observacion_web = (reader[12] == DBNull.Value) ? (string)null : Convert.ToString(reader[12]);
                    movimiento.estado_id = Convert.ToInt32(reader[13]);
                    movimiento.editado_sn = Convert.ToBoolean(reader[14]);
                }

                return movimiento;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

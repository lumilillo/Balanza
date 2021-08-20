using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class PuertosCOMRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "puerto_com";
        }
        protected override string[] GetColumnas()
        {
            return new string[9] { "id", "ubicacion", "port_name", "data_bits", "baud_rate", "parity", "stop_bits", "discard_null", "threshold" };
        }
        public puerto_com FindPuertoById(int id)
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

        public puerto_com FindPuertoByUbicacion(string ubicacion)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = "SELECT * FROM " + GetNombreTabla() + " WHERE ubicacion = '" + ubicacion + "' ";
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

        public bool InsertarPuerto(puerto_com puerto)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", puerto.id);
            comando.Parameters.AddWithValue("@ubicacion", puerto.ubicacion);
            comando.Parameters.AddWithValue("@port_name", puerto.port_name);
            comando.Parameters.AddWithValue("@data_bits", puerto.data_bits);
            comando.Parameters.AddWithValue("@baud_rate", puerto.baud_rate);
            comando.Parameters.AddWithValue("@parity", puerto.parity);
            comando.Parameters.AddWithValue("@stop_bits", puerto.stop_bits);
            comando.Parameters.AddWithValue("@discard_null", puerto.discard_null);
            comando.Parameters.AddWithValue("@threshold", puerto.threshold);

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
        public bool EditarPuerto(puerto_com puerto)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(puerto.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@ubicacion", puerto.ubicacion);
            comando.Parameters.AddWithValue("@port_name", puerto.port_name);
            comando.Parameters.AddWithValue("@data_bits", puerto.data_bits);
            comando.Parameters.AddWithValue("@baud_rate", puerto.baud_rate);
            comando.Parameters.AddWithValue("@parity", puerto.parity);
            comando.Parameters.AddWithValue("@stop_bits", puerto.stop_bits);
            comando.Parameters.AddWithValue("@discard_null", puerto.discard_null);
            comando.Parameters.AddWithValue("@threshold", puerto.threshold);

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

        public bool EliminarPuerto(puerto_com puerto)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(puerto.id);
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
        public List<puerto_com> GetAllPuertos()
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

        List<puerto_com> ConvertirLista(MySqlDataReader reader)
        {
            List<puerto_com> lista = new List<puerto_com>();
            puerto_com unidad;

            while (reader.Read())
            {
                unidad = new puerto_com();

                unidad.id = Convert.ToInt32(reader.GetString(0));
                unidad.ubicacion = reader.GetString(1);
                unidad.port_name = reader.GetString(2);
                unidad.data_bits = Convert.ToInt32(reader[3]);
                unidad.baud_rate = Convert.ToInt32(reader[4]);
                unidad.parity = reader.GetString(5);
                unidad.stop_bits = reader.GetString(6);
                unidad.discard_null = Convert.ToBoolean(reader[7]);
                unidad.threshold = (reader[8] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[8]);

                lista.Add(unidad);
            }

            return lista;
        }
        puerto_com ConvertirEntidad(MySqlDataReader reader)
        {
            puerto_com unidad = new puerto_com();

            while (reader.Read())
            {
                unidad.id = Convert.ToInt32(reader.GetString(0));
                unidad.ubicacion = reader.GetString(1);
                unidad.port_name = reader.GetString(2);
                unidad.data_bits = Convert.ToInt32(reader[3]);
                unidad.baud_rate = Convert.ToInt32(reader[4]);
                unidad.parity = reader.GetString(5);
                unidad.stop_bits = reader.GetString(6);
                unidad.discard_null = Convert.ToBoolean(reader[7]);
                unidad.threshold = (reader[8] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[8]);
            }

            return unidad;
        }
    }
}

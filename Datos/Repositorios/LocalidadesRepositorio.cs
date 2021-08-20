using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class LocalidadesRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "localidades";
        }
        protected override string[] GetColumnas()
        {
            return new string[8] { "id", "localidad", "provincia_id", "lat", "lon", "fav", "created_at", "updated_at" };
        }
        public localidades FindLocalidadById(int id)
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
        public bool InsertarLocalidad(localidades localidad)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", localidad.id);
            comando.Parameters.AddWithValue("@localidad", localidad.localidad);
            comando.Parameters.AddWithValue("@provincia_id", localidad.provincia_id);
            comando.Parameters.AddWithValue("@lat", localidad.lat);
            comando.Parameters.AddWithValue("@lon", localidad.lon);
            comando.Parameters.AddWithValue("@fav", localidad.fav);
            comando.Parameters.AddWithValue("@created_at", localidad.created_at);
            comando.Parameters.AddWithValue("@updated_at", localidad.updated_at);

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
        public bool EditarLocalidad(localidades localidad)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(localidad.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@localidad", localidad.localidad);
            comando.Parameters.AddWithValue("@provincia_id", localidad.provincia_id);
            comando.Parameters.AddWithValue("@lat", localidad.lat);
            comando.Parameters.AddWithValue("@lon", localidad.lon);
            comando.Parameters.AddWithValue("@fav", localidad.fav);
            comando.Parameters.AddWithValue("@created_at", localidad.created_at);
            comando.Parameters.AddWithValue("@updated_at", localidad.updated_at);

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
        public bool EliminarLocalidad(localidades localidad)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(localidad.id);
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
        public List<localidades> GetAllLocalidades()
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
        public List<localidades> GetLocalidadesByProvincia(int id)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = GetFindByColumnStatement("provincia_id", id.ToString());
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

        List<localidades> ConvertirLista(MySqlDataReader reader)
        {
            List<localidades> lista = new List<localidades>();
            localidades localidad;

            while (reader.Read())
            {
                localidad = new localidades();

                localidad.id = Convert.ToInt32(reader.GetString(0));
                localidad.localidad = reader.GetString(1);
                localidad.provincia_id = Convert.ToInt32(reader.GetString(2));
                localidad.lat = reader.GetString(3);
                localidad.lon = reader.GetString(4);
                localidad.fav = Convert.ToBoolean(reader.GetString(5));
                localidad.created_at = (reader[6] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[6]);
                localidad.created_at = (reader[7] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[7]);

                lista.Add(localidad);
            }

            return lista;
        }
        localidades ConvertirEntidad(MySqlDataReader reader)
        {
            localidades localidad = new localidades();

            while (reader.Read())
            {
                localidad.id = Convert.ToInt32(reader.GetString(0));
                localidad.localidad = reader.GetString(1);
                localidad.provincia_id = Convert.ToInt32(reader.GetString(2));
                localidad.lat = reader.GetString(3);
                localidad.lon = reader.GetString(4);
                localidad.fav = Convert.ToBoolean(reader.GetString(5));
                localidad.created_at = (reader[6] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[6]);
                localidad.created_at = (reader[7] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[7]);
            }

            return localidad;
        }
    }
}

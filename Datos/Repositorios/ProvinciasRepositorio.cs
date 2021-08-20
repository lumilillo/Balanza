using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class ProvinciasRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "provincias";
        }
        protected override string[] GetColumnas()
        {
            return new string[5] { "id", "provincia", "fav", "created_at", "updated_at" };
        }
        public provincias FindProvinciaById(int id)
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
        public bool InsertarProvincia(provincias provincia)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", provincia.id);
            comando.Parameters.AddWithValue("@provincia", provincia.provincia);
            comando.Parameters.AddWithValue("@fav", provincia.fav);
            comando.Parameters.AddWithValue("@created_at", provincia.created_at);
            comando.Parameters.AddWithValue("@updated_at", provincia.updated_at);

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
        public bool EditarProvincia(provincias provincia)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(provincia.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@provincia", provincia.provincia);
            comando.Parameters.AddWithValue("@fav", provincia.fav);
            comando.Parameters.AddWithValue("@created_at", provincia.created_at);
            comando.Parameters.AddWithValue("@updated_at", provincia.updated_at);

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
        public bool EliminarProvincia(provincias provincia)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(provincia.id);
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
        public List<provincias> GetAllProvincias()
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

        List<provincias> ConvertirLista(MySqlDataReader reader)
        {
            List<provincias> lista = new List<provincias>();
            provincias materia;

            while (reader.Read())
            {
                materia = new provincias();

                materia.id = Convert.ToInt32(reader.GetString(0));
                materia.provincia = reader.GetString(1);
                materia.fav = Convert.ToBoolean(reader.GetString(2));
                materia.created_at = (reader[3] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[3]);
                materia.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);

                lista.Add(materia);
            }

            return lista;
        }
        provincias ConvertirEntidad(MySqlDataReader reader)
        {
            provincias materia = new provincias();

            while (reader.Read())
            {
                materia.id = Convert.ToInt32(reader.GetString(0));
                materia.provincia = reader.GetString(1);
                materia.fav = Convert.ToBoolean(reader.GetString(2));
                materia.created_at = (reader[3] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[3]);
                materia.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);
            }

            return materia;
        }
    }
}

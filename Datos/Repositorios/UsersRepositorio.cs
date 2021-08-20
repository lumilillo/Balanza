using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class UsersRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "users";
        }
        protected override string[] GetColumnas()
        {
            return new string[11] { "id", "name", "dni", "legajo", "email", "email_verified_at", "password"
                                  , "api_token", "remember_token", "created_at", "updated_at" };
        }

        public users FindByUserId(int id)
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

        public bool InsertarUser(users user)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", user.id);
            comando.Parameters.AddWithValue("@name", user.name);
            comando.Parameters.AddWithValue("@dni", user.dni);
            comando.Parameters.AddWithValue("@legajo", user.legajo);
            comando.Parameters.AddWithValue("@email", user.email);
            comando.Parameters.AddWithValue("@email_verified_at", user.email_verified_at);
            comando.Parameters.AddWithValue("@password", user.password);
            comando.Parameters.AddWithValue("@api_token", user.api_token);
            comando.Parameters.AddWithValue("@remember_token", user.remember_token);
            comando.Parameters.AddWithValue("@created_at", user.created_at);
            comando.Parameters.AddWithValue("@updated_at", user.updated_at);

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
        public bool EditarUser(users user)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(user.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@name", user.name);
            comando.Parameters.AddWithValue("@dni", user.dni);
            comando.Parameters.AddWithValue("@legajo", user.legajo);
            comando.Parameters.AddWithValue("@email", user.email);
            comando.Parameters.AddWithValue("@email_verified_at", user.email_verified_at);
            comando.Parameters.AddWithValue("@password", user.password);
            comando.Parameters.AddWithValue("@api_token", user.api_token);
            comando.Parameters.AddWithValue("@remember_token", user.remember_token);
            comando.Parameters.AddWithValue("@created_at", user.created_at);
            comando.Parameters.AddWithValue("@updated_at", user.updated_at);

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
        public bool EliminarUser(users user)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(user.id);
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

        public List<users> GetAllUsers()
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

        public users FindByDni(int Dni)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = GetFindByColumnStatement("dni", Dni.ToString());
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

        List<users> ConvertirLista(MySqlDataReader reader)
        {
            List<users> lista = new List<users>();
            users user;

            while (reader.Read())
            {
                user = new users();

                user.id = Convert.ToInt32(reader.GetString(0));
                user.name = reader.GetString(1);
                user.dni = Convert.ToInt32(reader.GetString(2));
                user.legajo = (reader[3] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[3]);
                user.email = (reader[4] == DBNull.Value) ? (string)null : Convert.ToString(reader[4]);
                user.email_verified_at = (reader[5] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[5]);
                user.password = reader.GetString(6);
                user.api_token = (reader[7] == DBNull.Value) ? (string)null : Convert.ToString(reader[7]);
                user.remember_token = (reader[8] == DBNull.Value) ? (string)null : Convert.ToString(reader[8]);
                user.created_at = (reader[9] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[9]);
                user.created_at = (reader[10] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[10]);

                lista.Add(user);
            }

            return lista;
        }
        users ConvertirEntidad(MySqlDataReader reader)
        {
            users user = new users();

            while (reader.Read())
            {
                user.id = Convert.ToInt32(reader.GetString(0));
                user.name = reader.GetString(1);
                user.dni = Convert.ToInt32(reader.GetString(2));
                user.legajo = (reader[3] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[3]);
                user.email = (reader[4] == DBNull.Value) ? (string)null : Convert.ToString(reader[4]);
                user.email_verified_at = (reader[5] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[5]);
                user.password = reader.GetString(6);
                user.api_token = (reader[7] == DBNull.Value) ? (string)null : Convert.ToString(reader[7]);
                user.remember_token = (reader[8] == DBNull.Value) ? (string)null : Convert.ToString(reader[8]);
                user.created_at = (reader[9] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[9]);
                user.created_at = (reader[10] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[10]);
            }

            return user;
        }
    }
}


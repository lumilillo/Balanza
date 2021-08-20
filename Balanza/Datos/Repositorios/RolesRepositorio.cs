using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class RolesRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "roles";
        }

        protected override string[] GetColumnas()
        {
            return new string[5] { "id", "name", "guard_name", "created_at", "updated_at" };
        }

        public roles FindRolById(int id)
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

        public bool InsertarRol(roles rol)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", rol.id);
            comando.Parameters.AddWithValue("@name", rol.name);
            comando.Parameters.AddWithValue("@guard_name", rol.guard_name);
            comando.Parameters.AddWithValue("@created_at", rol.created_at);
            comando.Parameters.AddWithValue("@updated_at", rol.updated_at);

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

        public bool EditarRol(roles rol)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(rol.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", rol.id);
            comando.Parameters.AddWithValue("@name", rol.name);
            comando.Parameters.AddWithValue("@guard_name", rol.guard_name);
            comando.Parameters.AddWithValue("@created_at", rol.created_at);
            comando.Parameters.AddWithValue("@updated_at", rol.updated_at);

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

        public bool EliminarRol(roles rol)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(rol.id);
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

        public List<roles> GetAllRoles()
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

        List<roles> ConvertirLista(MySqlDataReader reader)
        {
            List<roles> lista = new List<roles>();
            roles rol;

            while (reader.Read())
            {
                rol = new roles();

                rol.id = Convert.ToInt32(reader.GetString(0));
                rol.name = reader.GetString(1);
                rol.guard_name = reader.GetString(2);
                rol.created_at = (reader[3] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[3]);
                rol.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);

                lista.Add(rol);
            }

            return lista;
        }
        roles ConvertirEntidad(MySqlDataReader reader)
        {
            roles rol = new roles();

            while (reader.Read())
            {
                rol.id = Convert.ToInt32(reader.GetString(0));
                rol.name = reader.GetString(1);
                rol.guard_name = reader.GetString(2);
                rol.created_at = (reader[3] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[3]);
                rol.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);
            }

            return rol;
        }
    }
}

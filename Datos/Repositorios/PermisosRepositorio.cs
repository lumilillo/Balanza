using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class PermisosRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "permissions";
        }

        protected override string[] GetColumnas()
        {
            return new string[6] { "id", "name", "guard_name", "descripcion", "created_at", "updated_at" };
        }

        public permissions FindPermisoByName(string name)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = GetFindByColumnStatement("name", name);
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

        public permissions FindPermisoById(int id)
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

        public bool InsertarPermiso(permissions permiso)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", permiso.id);
            comando.Parameters.AddWithValue("@name", permiso.name);
            comando.Parameters.AddWithValue("@guard_name", permiso.guard_name);
            comando.Parameters.AddWithValue("@descripcion", permiso.descripcion);
            comando.Parameters.AddWithValue("@created_at", permiso.created_at);
            comando.Parameters.AddWithValue("@updated_at", permiso.updated_at);

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

        public bool EditarPermiso(permissions permiso)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(permiso.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", permiso.id);
            comando.Parameters.AddWithValue("@name", permiso.name);
            comando.Parameters.AddWithValue("@guard_name", permiso.guard_name);
            comando.Parameters.AddWithValue("@descripcion", permiso.descripcion);
            comando.Parameters.AddWithValue("@created_at", permiso.created_at);
            comando.Parameters.AddWithValue("@updated_at", permiso.updated_at);

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

        public bool EliminarPermiso(permissions permiso)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(permiso.id);
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

        public List<permissions> GetAllPermisos()
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

        public List<permissions> GetPermisosByUsuario(int id)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getPermisosByUsuario";
            comando.Connection = conexion;
            comando.Parameters.Add(new MySqlParameter("id", MySqlDbType.Int32)).Value = id;

            MySqlDataReader reader = null;

            try
            {
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    return ConvertirListaConRol(reader);
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

        List<permissions> ConvertirListaConRol(MySqlDataReader reader)
        {
            List<permissions> lista = new List<permissions>();
            permissions permiso;

            while (reader.Read())
            {
                permiso = new permissions();

                permiso.id = Convert.ToInt32(reader.GetString(0));
                permiso.name = reader.GetString(1);
                permiso.guard_name = reader.GetString(2);
                permiso.descripcion = (reader[3] == DBNull.Value) ? (string)null : Convert.ToString(reader[3]);
                permiso.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);
                permiso.created_at = (reader[5] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[5]);
                permiso.rol = reader.GetString(6);

                lista.Add(permiso);
            }

            return lista;
        }

        List<permissions> ConvertirLista(MySqlDataReader reader)
        {
            List<permissions> lista = new List<permissions>();
            permissions permiso;

            while (reader.Read())
            {
                permiso = new permissions();

                permiso.id = Convert.ToInt32(reader.GetString(0));
                permiso.name = reader.GetString(1);
                permiso.guard_name = reader.GetString(2);
                permiso.descripcion = (reader[3] == DBNull.Value) ? (string)null : Convert.ToString(reader[3]);
                permiso.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);
                permiso.created_at = (reader[5] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[5]);

                lista.Add(permiso);
            }

            return lista;
        }

        permissions ConvertirEntidad(MySqlDataReader reader)
        {
            permissions permiso = new permissions();

            while (reader.Read())
            {
                permiso.id = Convert.ToInt32(reader.GetString(0));
                permiso.name = reader.GetString(1);
                permiso.guard_name = reader.GetString(2);
                permiso.descripcion = (reader[3] == DBNull.Value) ? (string)null : Convert.ToString(reader[3]);
                permiso.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);
                permiso.created_at = (reader[5] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[5]);
            }

            return permiso;
        }
    }
}

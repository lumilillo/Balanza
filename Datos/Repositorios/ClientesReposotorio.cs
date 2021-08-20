using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class ClientesReposotorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "clientes";
        }
        protected override string[] GetColumnas()
        {
            return new string[9] { "id", "razon_social", "domicilio", "cp", "localidad_id", "cuit", "user_id", "created_at", "updated_at" };
        }
        public clientes FindClienteById(int id)
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
        public bool InsertarCliente(clientes cliente)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", cliente.id);
            comando.Parameters.AddWithValue("@razon_social", cliente.razon_social);
            comando.Parameters.AddWithValue("@domicilio", cliente.domicilio);
            comando.Parameters.AddWithValue("@cp", cliente.cp);
            comando.Parameters.AddWithValue("@localidad_id", cliente.localidad_id);
            comando.Parameters.AddWithValue("@cuit", cliente.cuit);
            comando.Parameters.AddWithValue("@user_id", cliente.user_id);
            comando.Parameters.AddWithValue("@created_at", cliente.created_at);
            comando.Parameters.AddWithValue("@updated_at", cliente.updated_at);

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
        public bool EditarCliente(clientes cliente)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(cliente.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@razon_social", cliente.razon_social);
            comando.Parameters.AddWithValue("@domicilio", cliente.domicilio);
            comando.Parameters.AddWithValue("@cp", cliente.cp);
            comando.Parameters.AddWithValue("@localidades_id", cliente.localidad_id);
            comando.Parameters.AddWithValue("@cuit", cliente.cuit);
            comando.Parameters.AddWithValue("@users_id", cliente.user_id);
            comando.Parameters.AddWithValue("@created_at", cliente.created_at);
            comando.Parameters.AddWithValue("@updated_at", cliente.updated_at);

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
        public int EliminarCliente(clientes cliente)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(cliente.id);
            comando.Connection = conexion;

            try
            {
                comando.ExecuteNonQuery();
                return 1;
            }
            catch(MySqlException mysqlEx)
            {
                return mysqlEx.Number;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                conexion.Close();
            }
        }
        public List<clientes> GetAllClientes()
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = GetAll() + " ORDER BY razon_social ASC"; //ORDENO ALFABETICAMENTE
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

        public List<clientes> GetClientesConLocalidad()
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getClientes";
            comando.Connection = conexion;

            MySqlDataReader reader = null;

            try
            {
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    return ConvertirVistaLocalidad(reader);
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

        #region SERIALIZACION

        List<clientes> ConvertirLista(MySqlDataReader reader)
        {
            List<clientes> lista = new List<clientes>();
            clientes cliente;

            while (reader.Read())
            {
                cliente = new clientes();

                cliente.id = Convert.ToInt32(reader.GetString(0));
                cliente.razon_social = reader.GetString(1);
                cliente.domicilio = reader.GetString(2); ;
                cliente.cp = (reader[3] == DBNull.Value) ? (string)null : Convert.ToString(reader[3]);
                cliente.localidad_id = (reader[4] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[4]);
                cliente.cuit = reader.GetString(5);
                cliente.user_id = (reader[6] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[6]);
                cliente.created_at = (reader[7] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[7]);
                cliente.created_at = (reader[8] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[8]);

                lista.Add(cliente);
            }

            return lista;
        }

        List<clientes> ConvertirVistaLocalidad(MySqlDataReader reader)
        {
            List<clientes> lista = new List<clientes>();
            clientes cliente;

            while (reader.Read())
            {
                cliente = new clientes();

                cliente.id = Convert.ToInt32(reader.GetString(0));
                cliente.razon_social = reader.GetString(1);
                cliente.domicilio = reader.GetString(2); ;
                cliente.cp = (reader[3] == DBNull.Value) ? (string)null : Convert.ToString(reader[3]);
                cliente.localidad_id = (reader[4] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[4]);
                cliente.cuit = reader.GetString(5);
                cliente.user_id = (reader[6] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[6]);
                cliente.created_at = (reader[7] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[7]);
                cliente.created_at = (reader[8] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[8]);
                cliente.localidad = (reader[9] == DBNull.Value) ? (string)null : Convert.ToString(reader[9]);

                lista.Add(cliente);
            }
            return lista;
        }

        clientes ConvertirEntidad(MySqlDataReader reader)
        {
            clientes proveedor = new clientes();
            while (reader.Read())
            {
                proveedor.id = Convert.ToInt32(reader.GetString(0));
                proveedor.razon_social = reader.GetString(1);
                proveedor.domicilio = reader.GetString(2); ;
                proveedor.cp = (reader[3] == DBNull.Value) ? (string)null : Convert.ToString(reader[8]);
                proveedor.localidad_id = Convert.ToInt32(reader.GetString(4));
                proveedor.cuit = reader.GetString(5);
                proveedor.user_id = Convert.ToInt32(reader.GetString(6));
                proveedor.created_at = (reader[7] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[7]);
                proveedor.created_at = (reader[8] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[8]);
            }

            return proveedor;
        }

        #endregion

    }
}

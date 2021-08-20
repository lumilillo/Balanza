using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class ProveedoresRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "proveedores";
        }
        protected override string[] GetColumnas()
        {
            return new string[9] { "id", "razon_social", "domicilio", "cp", "localidad_id", "cuit", "user_id", "created_at", "updated_at" };
        }
        public proveedores FindProveedorById(int id)
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
        public bool InsertarProveedor(proveedores proveedor)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", proveedor.id);
            comando.Parameters.AddWithValue("@razon_social", proveedor.razon_social);
            comando.Parameters.AddWithValue("@domicilio", proveedor.domicilio);
            comando.Parameters.AddWithValue("@cp", proveedor.cp);
            comando.Parameters.AddWithValue("@localidad_id", proveedor.localidad_id);
            comando.Parameters.AddWithValue("@cuit", proveedor.cuit);
            comando.Parameters.AddWithValue("@user_id", proveedor.user_id);
            comando.Parameters.AddWithValue("@created_at", proveedor.created_at);
            comando.Parameters.AddWithValue("@updated_at", proveedor.updated_at);

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
        public bool EditarProveedor(proveedores proveedor)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(proveedor.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@razon_social", proveedor.razon_social);
            comando.Parameters.AddWithValue("@domicilio", proveedor.domicilio);
            comando.Parameters.AddWithValue("@cp", proveedor.cp);
            comando.Parameters.AddWithValue("@localidad_id", proveedor.localidad_id);
            comando.Parameters.AddWithValue("@cuit", proveedor.cuit);
            comando.Parameters.AddWithValue("@user_id", proveedor.user_id);
            comando.Parameters.AddWithValue("@created_at", proveedor.created_at);
            comando.Parameters.AddWithValue("@updated_at", proveedor.updated_at);

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
        public int EliminarProveedor(proveedores proveedor)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(proveedor.id);
            comando.Connection = conexion;

            try
            {
                comando.ExecuteNonQuery();
                return 1;
            }
            catch (MySqlException mysqlEx)
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
        public List<proveedores> GetAllProveedores()
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
        public List<proveedores> GetProveedoresConLocalidad()
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getProveedores";
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

        List<proveedores> ConvertirLista(MySqlDataReader reader)
        {
            List<proveedores> lista = new List<proveedores>();
            proveedores proveedor;

            while (reader.Read())
            {
                proveedor = new proveedores();

                proveedor.id = Convert.ToInt32(reader.GetString(0));
                proveedor.razon_social = reader.GetString(1);
                proveedor.domicilio = reader.GetString(2); ;
                proveedor.cp = (reader[3] == DBNull.Value) ? (string)null : Convert.ToString(reader[3]);
                proveedor.localidad_id = (reader[4] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[4]);
                proveedor.cuit = reader.GetString(5);
                proveedor.user_id = (reader[6] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[6]);
                proveedor.created_at = (reader[7] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[7]);
                proveedor.created_at = (reader[8] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[8]);

                lista.Add(proveedor);
            }
            return lista;
        }

        List<proveedores> ConvertirVistaLocalidad(MySqlDataReader reader)
        {
            List<proveedores> lista = new List<proveedores>();
            proveedores proveedor;

            while (reader.Read())
            {
                proveedor = new proveedores();

                proveedor.id = Convert.ToInt32(reader.GetString(0));
                proveedor.razon_social = reader.GetString(1);
                proveedor.domicilio = reader.GetString(2); ;
                proveedor.cp = (reader[3] == DBNull.Value) ? (string)null : Convert.ToString(reader[3]);
                proveedor.localidad_id = (reader[4] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[4]);
                proveedor.cuit = reader.GetString(5);
                proveedor.user_id = (reader[6] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[6]);
                proveedor.created_at = (reader[7] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[7]);
                proveedor.created_at = (reader[8] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[8]);
                proveedor.localidad = (reader[9] == DBNull.Value) ? (string)null : Convert.ToString(reader[9]);

                lista.Add(proveedor);
            }
            return lista;
        }

        proveedores ConvertirEntidad(MySqlDataReader reader)
        {
            proveedores proveedor = new proveedores();
            while (reader.Read())
            {
                proveedor.id = Convert.ToInt32(reader.GetString(0));
                proveedor.razon_social = reader.GetString(1);
                proveedor.domicilio = reader.GetString(2); ;
                proveedor.cp = (reader[3] == DBNull.Value) ? (string)null : Convert.ToString(reader[8]);
                proveedor.localidad_id = (reader[4] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[4]);
                proveedor.cuit = reader.GetString(5);
                proveedor.user_id = (reader[6] == DBNull.Value) ? (int?)null : Convert.ToInt32(reader[6]);
                proveedor.created_at = (reader[7] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[7]);
                proveedor.created_at = (reader[8] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[8]);
            }

            return proveedor;
        }

        #endregion

    }
}

using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class ProveedorCamionesRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "proveedor_camiones";
        }
        protected override string[] GetColumnas()
        {
            return new string[5] { "id", "camion_id", "proveedor_id", "created_at", "updated_at" };
        }
        public proveedor_camiones FindProveedorCamionById(int id)
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
        public bool InsertarCamionProveedor(proveedor_camiones camion)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", camion.id);
            comando.Parameters.AddWithValue("@camion_id", camion.camion_id);
            comando.Parameters.AddWithValue("@proveedor_id", camion.proveedor_id);
            comando.Parameters.AddWithValue("@created_at", camion.created_at);
            comando.Parameters.AddWithValue("@updated_at", camion.updated_at);

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
        public bool EditarCamionProveedor(proveedor_camiones camion)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(camion.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@camion_id", camion.camion_id);
            comando.Parameters.AddWithValue("@proveedor_id", camion.proveedor_id);
            comando.Parameters.AddWithValue("@created_at", camion.created_at);
            comando.Parameters.AddWithValue("@updated_at", camion.updated_at);

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
        public int EliminarCamionProveedor(proveedor_camiones camion)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(camion.id);
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
        public proveedor_camiones FindByCamionId(int id)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = GetFindByColumnStatement("camion_id", id.ToString());
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
        public List<proveedor_camiones> GetAllCamionesProveedores()
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

        public proveedor_camiones FindByProveedorYCamion(int idCamion, int idProveedor)
        {
            string[] columnas = new string[2] { "camion_id", "proveedor_id" };
            string[] valores = new string[2] { idCamion.ToString(), idProveedor.ToString() };

            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = GetFindByColumnsStatement(columnas, valores);
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

        List<proveedor_camiones> ConvertirLista(MySqlDataReader reader)
        {
            List<proveedor_camiones> lista = new List<proveedor_camiones>();
            proveedor_camiones camion;

            while (reader.Read())
            {
                camion = new proveedor_camiones();

                camion.id = Convert.ToInt32(reader.GetString(0));
                camion.camion_id = Convert.ToInt32(reader.GetString(1));
                camion.proveedor_id = Convert.ToInt32(reader.GetString(2));
                camion.created_at = (reader[3] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[3]);
                camion.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);

                lista.Add(camion);
            }

            return lista;
        }
        proveedor_camiones ConvertirEntidad(MySqlDataReader reader)
        {
            proveedor_camiones camion = new proveedor_camiones();

            while (reader.Read())
            {
                camion.id = Convert.ToInt32(reader.GetString(0));
                camion.camion_id = Convert.ToInt32(reader.GetString(1));
                camion.proveedor_id = Convert.ToInt32(reader.GetString(2));
                camion.created_at = (reader[3] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[3]);
                camion.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);
            }

            return camion;
        }
    }
}

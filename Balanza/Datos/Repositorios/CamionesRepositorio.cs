using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class CamionesRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "camiones";
        }
        protected override string[] GetColumnas()
        {
            return new string[5] { "id", "tipo_camion_id", "patente_chasis", "created_at", "updated_at" };
        }
        public camiones FindByCamionId(int id)
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
        public bool InsertarCamion(camiones camion)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", camion.id);
            comando.Parameters.AddWithValue("@tipo_camion_id", camion.tipo_camion_id);
            comando.Parameters.AddWithValue("@patente_chasis", camion.patente_chasis);
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
        public bool EditarCamion(camiones camion)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(camion.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@tipo_camion_id", camion.tipo_camion_id);
            comando.Parameters.AddWithValue("@patente_chasis", camion.patente_chasis);
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
        public int EliminarCamion(camiones camion)
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
        public List<camiones> GetAllCamiones()
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
        public List<camiones> GetCamionesByProveedor(int id)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getCamionesProveedor";
            comando.Connection = conexion;
            comando.Parameters.Add(new MySqlParameter("pProveedor_id", MySqlDbType.Int32)).Value = id;

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
        public List<camiones> GetCamionesByCliente(int id)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getCamionesCliente";
            comando.Connection = conexion;
            comando.Parameters.Add(new MySqlParameter("pCliente_id", MySqlDbType.Int32)).Value = id;

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

        public List<camiones> GetCamionesConTipo()
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getCamionesConTipo";
            comando.Connection = conexion;

            MySqlDataReader reader = null;

            try
            {
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    return ConvertirListaConTipo(reader);
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

        public List<camiones> GetCamionesProveedorConTipo(int id)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getCamionesProveedorConTipo";
            comando.Connection = conexion;
            comando.Parameters.Add(new MySqlParameter("pProveedor_id", MySqlDbType.Int32)).Value = id;

            MySqlDataReader reader = null;

            try
            {
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    return ConvertirListaConTipo(reader);
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

        public List<camiones> GetCamionesClienteConTipo(int id)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getCamionesClienteConTipo";
            comando.Connection = conexion;
            comando.Parameters.Add(new MySqlParameter("pCliente_id", MySqlDbType.Int32)).Value = id;

            MySqlDataReader reader = null;

            try
            {
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    return ConvertirListaConTipo(reader);
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

        public camiones FindByPatente(string patente)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = GetFindByColumnStatement("patente_chasis", patente);
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

        public int FindLastId()
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = GetLastId();
            comando.Connection = conexion;

            MySqlDataReader reader = null;

            try
            {
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    int id = 0;

                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader[0]);
                    }

                    return id;
                }
                else
                {
                    return 0;
                }
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


        List<camiones> ConvertirListaConTipo(MySqlDataReader reader)
        {
            List<camiones> lista = new List<camiones>();
            camiones camion;

            while (reader.Read())
            {
                camion = new camiones();

                camion.id = Convert.ToInt32(reader.GetString(0));
                camion.tipo_camion_id = Convert.ToInt32(reader.GetString(1));
                camion.patente_chasis = reader.GetString(2);
                camion.created_at = (reader[3] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[3]);
                camion.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);
                camion.tipoCamion = reader.GetString(5);

                lista.Add(camion);
            }

            return lista;
        }

        List<camiones> ConvertirLista(MySqlDataReader reader)
        {
            List<camiones> lista = new List<camiones>();
            camiones camion;

            while (reader.Read())
            {
                camion = new camiones();

                camion.id = Convert.ToInt32(reader.GetString(0));
                camion.tipo_camion_id = Convert.ToInt32(reader.GetString(1));
                camion.patente_chasis = reader.GetString(2);
                camion.created_at = (reader[3] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[3]);
                camion.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);

                lista.Add(camion);
            }

            return lista;
        }
        camiones ConvertirEntidad(MySqlDataReader reader)
        {
            camiones camion = new camiones();

            while (reader.Read())
            {
                camion.id = Convert.ToInt32(reader.GetString(0));
                camion.tipo_camion_id = Convert.ToInt32(reader.GetString(1));
                camion.patente_chasis = reader.GetString(2);
                camion.created_at = (reader[3] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[3]);
                camion.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);
            }

            return camion;
        }
    }
}

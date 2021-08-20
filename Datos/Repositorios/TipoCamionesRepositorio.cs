using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class TipoCamionesRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "tipo_camiones";
        }
        protected override string[] GetColumnas()
        {
            return new string[5] { "id", "codigo", "descripcion", "created_at", "updated_at" };
        }
        public tipo_camiones FindTipoCamionById(int id)
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
        public bool InsertarTipoCamion(tipo_camiones tipoCamion)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", tipoCamion.id);
            comando.Parameters.AddWithValue("@codigo", tipoCamion.codigo);
            comando.Parameters.AddWithValue("@descripcion", tipoCamion.descripcion);
            comando.Parameters.AddWithValue("@created_at", tipoCamion.created_at);
            comando.Parameters.AddWithValue("@updated_at", tipoCamion.updated_at);

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
        public bool EditarTipoCamion(tipo_camiones tipoCamion)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(tipoCamion.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@codigo", tipoCamion.codigo);
            comando.Parameters.AddWithValue("@descripcion", tipoCamion.descripcion);
            comando.Parameters.AddWithValue("@created_at", tipoCamion.created_at);
            comando.Parameters.AddWithValue("@updated_at", tipoCamion.updated_at);

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
        public bool EliminarTipoCamion(tipo_camiones tipoCamion)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(tipoCamion.id);
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
        public List<tipo_camiones> GetAllTipoCamiones()
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

        List<tipo_camiones> ConvertirLista(MySqlDataReader reader)
        {
            List<tipo_camiones> lista = new List<tipo_camiones>();
            tipo_camiones tipoCamion;

            while (reader.Read())
            {
                tipoCamion = new tipo_camiones();

                tipoCamion.id = Convert.ToInt32(reader.GetString(0));
                tipoCamion.codigo = reader.GetString(1);
                tipoCamion.descripcion = (reader[2] == DBNull.Value) ? (string)null : Convert.ToString(reader[2]);
                tipoCamion.created_at = (reader[3] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[3]);
                tipoCamion.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);

                lista.Add(tipoCamion);
            }

            return lista;
        }
        tipo_camiones ConvertirEntidad(MySqlDataReader reader)
        {
            tipo_camiones tipoCamion = new tipo_camiones();

            while (reader.Read())
            {

                tipoCamion.id = Convert.ToInt32(reader.GetString(0));
                tipoCamion.codigo = reader.GetString(1);
                tipoCamion.descripcion = (reader[2] == DBNull.Value) ? (string)null : Convert.ToString(reader[2]);
                tipoCamion.created_at = (reader[3] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[3]);
                tipoCamion.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);

            }

            return tipoCamion;

        }
    }
}

using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class EstadosRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "estados";
        }
        protected override string[] GetColumnas()
        {
            return new string[6] { "id", "codigo", "descripcion", "color", "created_at", "updated_at" };
        }
        public estados FindTipoCamionById(int id)
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

        public estados FindTipoCamionByCodigo(string codigo)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = GetFindByColumnStatement("codigo", codigo);
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

        public bool InsertarTipoCamion(estados estado)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", estado.id);
            comando.Parameters.AddWithValue("@codigo", estado.codigo);
            comando.Parameters.AddWithValue("@descripcion", estado.descripcion);
            comando.Parameters.AddWithValue("@color", estado.color);
            comando.Parameters.AddWithValue("@created_at", estado.created_at);
            comando.Parameters.AddWithValue("@updated_at", estado.updated_at);

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
        public bool EditarTipoCamion(estados estado)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(estado.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", estado.id);
            comando.Parameters.AddWithValue("@codigo", estado.codigo);
            comando.Parameters.AddWithValue("@descripcion", estado.descripcion);
            comando.Parameters.AddWithValue("@color", estado.color);
            comando.Parameters.AddWithValue("@created_at", estado.created_at);
            comando.Parameters.AddWithValue("@updated_at", estado.updated_at);

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
        public bool EliminarTipoCamion(estados estado)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(estado.id);
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
        public List<estados> GetAllTipoCamiones()
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

        List<estados> ConvertirLista(MySqlDataReader reader)
        {
            List<estados> lista = new List<estados>();
            estados estados;

            while (reader.Read())
            {
                estados = new estados();

                estados.id = Convert.ToInt32(reader.GetString(0));
                estados.codigo = reader.GetString(1);
                estados.descripcion = (reader[2] == DBNull.Value) ? (string)null : Convert.ToString(reader[2]);
                estados.color = (reader[3] == DBNull.Value) ? (string)null : Convert.ToString(reader[3]);
                estados.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);
                estados.created_at = (reader[5] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[5]);

                lista.Add(estados);
            }

            return lista;
        }
        estados ConvertirEntidad(MySqlDataReader reader)
        {
            estados estado = new estados();

            while (reader.Read())
            {

                estado.id = Convert.ToInt32(reader.GetString(0));
                estado.codigo = reader.GetString(1);
                estado.descripcion = (reader[2] == DBNull.Value) ? (string)null : Convert.ToString(reader[2]);
                estado.color = (reader[3] == DBNull.Value) ? (string)null : Convert.ToString(reader[3]);
                estado.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);
                estado.created_at = (reader[5] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[5]);

            }

            return estado;

        }
    }
}

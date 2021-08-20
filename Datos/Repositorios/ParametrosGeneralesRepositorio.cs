using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class ParametrosGeneralesRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "parametros_generales";
        }
        protected override string[] GetColumnas()
        {
            return new string[6] { "id", "codigo", "descripcion", "valor", "created_at", "updated_at" };
        }
        public parametros_generales FindParametroById(int id)
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
        public parametros_generales FindParametroByCodigo(string codigo)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = "SELECT * FROM " + GetNombreTabla() + " WHERE codigo = '" + codigo + "' ";
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
        public bool InsertarParametro(parametros_generales parametro)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", parametro.id);
            comando.Parameters.AddWithValue("@codigo", parametro.codigo);
            comando.Parameters.AddWithValue("@descripcion", parametro.descripcion);
            comando.Parameters.AddWithValue("@valor", parametro.valor);
            comando.Parameters.AddWithValue("@created_at", parametro.created_at);
            comando.Parameters.AddWithValue("@updated_at", parametro.updated_at);

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
        public bool EditarUnidadMedida(parametros_generales parametro)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(parametro.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@codigo", parametro.codigo);
            comando.Parameters.AddWithValue("@descripcion", parametro.descripcion);
            comando.Parameters.AddWithValue("@valor", parametro.valor);
            comando.Parameters.AddWithValue("@created_at", parametro.created_at);
            comando.Parameters.AddWithValue("@updated_at", parametro.updated_at);

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
        public bool EliminarUnidadMedida(parametros_generales parametro)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(parametro.id);
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
        public List<parametros_generales> GetAllUnidadMedida()
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

        List<parametros_generales> ConvertirLista(MySqlDataReader reader)
        {
            List<parametros_generales> lista = new List<parametros_generales>();
            parametros_generales parametro;

            while (reader.Read())
            {
                parametro = new parametros_generales();

                parametro.id = Convert.ToInt32(reader.GetString(0));
                parametro.codigo = reader.GetString(1);
                parametro.descripcion = reader.GetString(2);
                parametro.valor = reader.GetString(3);
                parametro.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);
                parametro.created_at = (reader[5] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[5]);

                lista.Add(parametro);
            }

            return lista;
        }
        parametros_generales ConvertirEntidad(MySqlDataReader reader)
        {
            parametros_generales parametro = new parametros_generales();

            while (reader.Read())
            {
                parametro.id = Convert.ToInt32(reader.GetString(0));
                parametro.codigo = reader.GetString(1);
                parametro.descripcion = reader.GetString(2);
                parametro.valor = reader.GetString(3);
                parametro.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);
                parametro.created_at = (reader[5] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[5]);
            }

            return parametro;
        }
    }
}

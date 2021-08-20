using Entidades.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class UnidadesMedidasRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "unidades_medidas";
        }
        protected override string[] GetColumnas()
        {
            return new string[5] { "id", "codigo", "descripcion", "created_at", "updated_at" };
        }
        public unidades_medidas FindUnidadMedidaById(int id)
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
        public bool InsertarUnidadMedida(unidades_medidas unidad)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", unidad.id);
            comando.Parameters.AddWithValue("@codigo", unidad.codigo);
            comando.Parameters.AddWithValue("@descripcion", unidad.descripcion);
            comando.Parameters.AddWithValue("@created_at", unidad.created_at);
            comando.Parameters.AddWithValue("@updated_at", unidad.updated_at);

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
        public bool EditarUnidadMedida(unidades_medidas unidad)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(unidad.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@codigo", unidad.codigo);
            comando.Parameters.AddWithValue("@descripcion", unidad.descripcion);
            comando.Parameters.AddWithValue("@created_at", unidad.created_at);
            comando.Parameters.AddWithValue("@updated_at", unidad.updated_at);

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
        public bool EliminarUnidadMedida(unidades_medidas unidad)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(unidad.id);
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
        public List<unidades_medidas> GetAllUnidadMedida()
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

        List<unidades_medidas> ConvertirLista(MySqlDataReader reader)
        {
            List<unidades_medidas> lista = new List<unidades_medidas>();
            unidades_medidas unidad;

            while (reader.Read())
            {
                unidad = new unidades_medidas();

                unidad.id = Convert.ToInt32(reader.GetString(0));
                unidad.codigo = reader.GetString(1);
                unidad.descripcion = reader.GetString(2);
                unidad.created_at = (reader[3] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[3]);
                unidad.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);

                lista.Add(unidad);
            }

            return lista;
        }
        unidades_medidas ConvertirEntidad(MySqlDataReader reader)
        {
            unidades_medidas unidad = new unidades_medidas();

            while (reader.Read())
            {
                unidad.id = Convert.ToInt32(reader.GetString(0));
                unidad.codigo = reader.GetString(1);
                unidad.descripcion = reader.GetString(2);
                unidad.created_at = (reader[3] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[3]);
                unidad.created_at = (reader[4] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[4]);
            }

            return unidad;
        }
    }
}

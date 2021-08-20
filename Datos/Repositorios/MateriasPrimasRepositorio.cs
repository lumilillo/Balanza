using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Entidades;
using MySql.Data.MySqlClient;

namespace Datos.Repositorios
{
    public class MateriasPrimasRepositorio : Repositorio
    {
        protected override string GetNombreTabla()
        {
            return "materiales";
        }
        protected override string[] GetColumnas()
        {
            return new string[8] { "id", "codigo", "descripcion", "unidades_medida_id", "materia_prima_sn", "material_venta", "created_at", "updated_at" };
        }
        public materias_primas FindMateriaPrimaById(int id)
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
        public bool InsertarMateria(materias_primas materia)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Insert();
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@id", materia.id);
            comando.Parameters.AddWithValue("@codigo", materia.codigo);
            comando.Parameters.AddWithValue("@descripcion", materia.descripcion);
            comando.Parameters.AddWithValue("@unidades_medida_id", materia.unidades_medida_id);
            comando.Parameters.AddWithValue("@materia_prima_sn", materia.materia_prima_sn);
            comando.Parameters.AddWithValue("@material_venta", materia.material_venta);
            comando.Parameters.AddWithValue("@created_at", materia.created_at);
            comando.Parameters.AddWithValue("@updated_at", materia.updated_at);

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
        public bool EditarMateria(materias_primas materia)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Update(materia.id);
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@codigo", materia.codigo);
            comando.Parameters.AddWithValue("@descripcion", materia.descripcion);
            comando.Parameters.AddWithValue("@unidades_medida_id", materia.unidades_medida_id);
            comando.Parameters.AddWithValue("@materia_prima_sn", materia.materia_prima_sn);
            comando.Parameters.AddWithValue("@material_venta", materia.material_venta);
            comando.Parameters.AddWithValue("@created_at", materia.created_at);
            comando.Parameters.AddWithValue("@updated_at", materia.updated_at);

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
        public int EliminarMateria(materias_primas materia)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = Delete(materia.id);
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

        public List<materias_primas> GetAllMaterias()
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

        public List<materias_primas> GetMateriasPrimas()
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = GetAll() + " WHERE materia_prima_sn IS TRUE";
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

        public List<materias_primas> GetMateriasVenta()
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = GetAll() + " WHERE material_venta IS TRUE";
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

        public List<materias_primas> GetMateriasConUnidad()
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getMaterialesConUnidad";
            comando.Connection = conexion;

            MySqlDataReader reader = null;

            try
            {
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    return ConvertirListaConUnidad(reader);
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

        public List<materias_primas> GetMaterialesNuevos(DateTime lastUpdate)
        {
            MySqlConnection conexion = Conexion.Conectar();
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "getNuevos";
            comando.Parameters.Add(new MySqlParameter("pTabla", MySqlDbType.VarChar)).Value = GetNombreTabla();
            comando.Parameters.Add(new MySqlParameter("pFecha", MySqlDbType.Timestamp)).Value = lastUpdate;
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

        List<materias_primas> ConvertirListaConUnidad(MySqlDataReader reader)
        {
            List<materias_primas> lista = new List<materias_primas>();
            materias_primas materia;

            while (reader.Read())
            {
                materia = new materias_primas();

                materia.id = Convert.ToInt32(reader.GetString(0));
                materia.codigo = reader.GetString(1);
                materia.descripcion = (reader[2] == DBNull.Value) ? (string)null : Convert.ToString(reader[2]);
                materia.unidades_medida_id = Convert.ToInt32(reader.GetString(3));
                materia.materia_prima_sn = Convert.ToBoolean(reader[4]);
                materia.material_venta = Convert.ToBoolean(reader[5]);
                materia.created_at = (reader[6] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[6]);
                materia.created_at = (reader[7] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[7]);
                materia.unidadMedida = reader.GetString(8);

                lista.Add(materia);
            }

            return lista;
        }

        List<materias_primas> ConvertirLista(MySqlDataReader reader)
        {
            List<materias_primas> lista = new List<materias_primas>();
            materias_primas materia;

            while (reader.Read())
            {
                materia = new materias_primas();

                materia.id = Convert.ToInt32(reader.GetString(0));
                materia.codigo = reader.GetString(1);
                materia.descripcion = (reader[2] == DBNull.Value) ? (string)null : Convert.ToString(reader[2]);
                materia.unidades_medida_id = Convert.ToInt32(reader.GetString(3));
                materia.materia_prima_sn = Convert.ToBoolean(reader[4]);
                materia.material_venta = Convert.ToBoolean(reader[5]);
                materia.created_at = (reader[6] == DBNull.Value) ? (DateTime?)null: Convert.ToDateTime(reader[6]);
                materia.created_at = (reader[7] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[7]);

                lista.Add(materia);
            }

            return lista;
        }

        materias_primas ConvertirEntidad(MySqlDataReader reader)
        {
            materias_primas materia = new materias_primas();

            while (reader.Read())
            {
                materia.id = Convert.ToInt32(reader.GetString(0));
                materia.codigo = reader.GetString(1);
                materia.descripcion = (reader[2] == DBNull.Value) ? (string)null : Convert.ToString(reader[2]);
                materia.unidades_medida_id = Convert.ToInt32(reader.GetString(3));
                materia.materia_prima_sn = Convert.ToBoolean(reader[4]);
                materia.material_venta = Convert.ToBoolean(reader[5]);
                materia.created_at = (reader[6] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[6]);
                materia.created_at = (reader[7] == DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(reader[7]);
            }

            return materia;
        }
    }
}

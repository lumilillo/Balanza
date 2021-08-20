using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public abstract class Repositorio
    {
        protected abstract string GetNombreTabla();
        protected abstract string[] GetColumnas();

        protected string GetAll()
        {
            return "SELECT * FROM " + GetNombreTabla();
        }
        protected string FindById(int id)
        {
            return "SELECT * FROM " + GetNombreTabla() + " WHERE id =" + id.ToString();
        }
        protected string Insert()
        {
            string auxColumn = "INSERT INTO " + GetNombreTabla() + " (";
            string auxValues = " VALUES (";
            var columns = GetColumnas();

            for (int i = 0; i < columns.Length - 1; i++)
            {
                auxColumn += columns[i] + ",";
                auxValues += "?,";
            }

            auxColumn += columns[columns.Length - 1] + ")";
            auxValues += "?)";

            return auxColumn + auxValues;
        }
        protected string Update(int id)
        {
            var columns = GetColumnas();
            string auxColumn = "UPDATE " + GetNombreTabla() + " SET ";
            for (int i = 1; i < columns.Length - 1; i++) 
            {
                auxColumn += columns[i] + "=?, ";
            }
            auxColumn += columns[columns.Length - 1] + "=? WHERE id=" + id.ToString();

            return auxColumn;
        }
        protected string Delete(int id)
        {
            return "DELETE FROM " + GetNombreTabla() + " WHERE id=" + id.ToString();
        }
        protected string GetFindByColumnStatement(string columnName, string attValue)
        {
            return "SELECT * FROM " + GetNombreTabla() + " WHERE " + columnName + "= " + "'" + attValue + "'";
        }

        protected string GetFindByColumnsStatement(string[] columnsName, object[] attsValue)
        {
            int arraySize = columnsName.Length;
            string query = "SELECT * FROM " + GetNombreTabla() + " WHERE ";

            for (int i = 0; i < arraySize ; i++)
            {
                if(i != 0 )
                {
                    query += " AND ";
                }

                query += columnsName[i] + "= " + attsValue[i];
            }

            return query;
        }

        protected string GetLastId()
        {
            return "SELECT LAST_INSERT_ID() as id FROM " + GetNombreTabla();
        }
    }
}

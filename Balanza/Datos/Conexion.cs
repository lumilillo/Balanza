using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Datos
{
    public static class Conexion
    {
        public static MySqlConnection Conectar()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(GetConnectionString());
                return conexion;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        static private string GetConnectionString()
        {
            return ConfigurationManager.AppSettings["connString"];
        }
    }
}

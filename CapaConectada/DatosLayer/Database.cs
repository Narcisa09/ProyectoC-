using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DatosLayer
{
    public class Database
    {
        public static string ConnectionString {
            get {
                string cadenaConexion = ConfigurationManager.ConnectionStrings["NWConnection"].ConnectionString;
                SqlConnectionStringBuilder conexionBuilder = new SqlConnectionStringBuilder(cadenaConexion);
                conexionBuilder.ApplicationName = ApplicationName ?? conexionBuilder.ApplicationName;
                conexionBuilder.ConnectTimeout = (ConnectionTimeout > 0) ? ConnectionTimeout : conexionBuilder.ConnectTimeout;
                return conexionBuilder.ToString();
            }
        }

        public static int ConnectionTimeout{ get; set; }

        public static string ApplicationName { get; set; }

        public static SqlConnection GetSqlConnection() {
        
            SqlConnection conexion = new SqlConnection(ConnectionString);
            conexion.Open();
            return conexion;

        }
    }
}

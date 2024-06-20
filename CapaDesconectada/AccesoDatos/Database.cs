using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Database
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["NWConnection"].ConnectionString;
            }
        }

        public static SqlConnection GetSqlConnection()
            {
                var conexion = new SqlConnection(ConnectionString); 
                conexion.Open();
                return conexion;
            }
    }
}

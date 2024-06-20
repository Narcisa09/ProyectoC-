using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DatosLayer
{
    public class CustomerRepository
    {

        public List<Customer> ObtenerTodos() {

            using (var conexion = Database.GetSqlConnection()) {

                String sql = "";
                sql = sql + "SELECT [CustomerID] " + "\n";
                sql = sql + "      ,[CompanyName] " + "\n";
                sql = sql + "      ,[ContactName] " + "\n";
                sql = sql + "      ,[ContactTitle] " + "\n";
                sql = sql + "      ,[Address] " + "\n";
                sql = sql + "      ,[City] " + "\n";
                sql = sql + "      ,[Region] " + "\n";
                sql = sql + "      ,[PostalCode] " + "\n";
                sql = sql + "      ,[Country] " + "\n";
                sql = sql + "      ,[Phone] " + "\n";
                sql = sql + "      ,[Fax] " + "\n";
                sql = sql + "  FROM [dbo].[Customers]";

                SqlCommand commmand = new SqlCommand(sql, conexion);

                SqlDataReader reader = commmand.ExecuteReader();

                List<Customer> customers = new List<Customer>();

                while (reader.Read())
                {
                    var customer = LeerDelDataReader(reader);
                    customers.Add(customer);
                }

                return customers;

            }
        }


        private Customer LeerDelDataReader(SqlDataReader reader)
        {
            Customer customer = new Customer();
            customer.CustomerID = (string)reader["CustomerID"];
            customer.CompanyName = (string)reader["CompanyName"];
            customer.ContactName = reader["ContactName"] == DBNull.Value ? "" : (string)reader["ContactName"];
            customer.ContactTitle = reader["ContactTitle"] == DBNull.Value ? "" : (string)reader["ContactTitle"];
            customer.Address = reader["Address"] == DBNull.Value ? "" : (string)reader["Address"];
            customer.City = reader["City"] == DBNull.Value ? "" : (string)reader["City"];
            customer.Region = reader["Region"] == DBNull.Value ? "" : (string)reader["Region"];
            customer.PostalCode = reader["PostalCode"] == DBNull.Value ? "" : (string)reader["PostalCode"];
            customer.Country = reader["Country"] == DBNull.Value ? "" : (string)reader["Country"];
            customer.Phone = reader["Phone"] == DBNull.Value ? "" : (string)reader["Phone"];
            customer.Fax = reader["Fax"] == DBNull.Value ? "" : (string)reader["Fax"];
            return customer;
        }

        public Customer ObtenerPorID(string id) 
        {
            using (var conexion = Database.GetSqlConnection()) 
            {

                String sql = "";
                sql = sql + "SELECT [CustomerID] " + "\n";
                sql = sql + "      ,[CompanyName] " + "\n";
                sql = sql + "      ,[ContactName] " + "\n";
                sql = sql + "      ,[ContactTitle] " + "\n";
                sql = sql + "      ,[Address] " + "\n";
                sql = sql + "      ,[City] " + "\n";
                sql = sql + "      ,[Region] " + "\n";
                sql = sql + "      ,[PostalCode] " + "\n";
                sql = sql + "      ,[Country] " + "\n";
                sql = sql + "      ,[Phone] " + "\n";
                sql = sql + "      ,[Fax] " + "\n";
                sql = sql + "  FROM [dbo].[Customers] " + "\n";
                sql = sql + " " + "\n";
                sql = sql + $"  Where CustomerID = @customerId;";


                using (SqlCommand command = new SqlCommand(sql, conexion)) 
                {
                    command.Parameters.AddWithValue("customerId", id);

                    var reader = command.ExecuteReader();
                    Customer customer = null;
                    if (reader.Read())
                    {
                        customer = LeerDelDataReader(reader);
                    }
                    return customer;
                }
            }


        }

        public int InsertarCliente(Customer customer)
        {

            using (var conexion = Database.GetSqlConnection())
            {

                String sql = "";
                sql = sql + "INSERT INTO [dbo].[Customers] " + "\n";
                sql = sql + "           ([CustomerID] " + "\n";
                sql = sql + "           ,[CompanyName] " + "\n";
                sql = sql + "           ,[ContactName] " + "\n";
                sql = sql + "           ,[ContactTitle] " + "\n";
                sql = sql + "           ,[Address] " + "\n";
                sql = sql + "           ,[City]) " + "\n";
                sql = sql + "            " + "\n";
                sql = sql + "     VALUES " + "\n";
                sql = sql + "           (@customerId " + "\n";
                sql = sql + "           ,@companyName " + "\n";
                sql = sql + "           ,@contactName " + "\n";
                sql = sql + "           ,@contactTitle " + "\n";
                sql = sql + "           ,@address " + "\n";
                sql = sql + "           ,@city);";


                using (var command = new SqlCommand(sql, conexion))
                {
                    command.Parameters.AddWithValue("customerId",customer.CustomerID);
                    command.Parameters.AddWithValue("companyName", customer.CompanyName);
                    command.Parameters.AddWithValue("contactName", customer.ContactName);
                    command.Parameters.AddWithValue("contactTitle", customer.ContactTitle);
                    command.Parameters.AddWithValue("address", customer.Address);
                    command.Parameters.AddWithValue("city", customer.City);

                    var insertados = command.ExecuteNonQuery();
                    return insertados;
                }

            }
        }

        public int ActualizarCliente(Customer customer) 
        {
            using (var conexion = Database.GetSqlConnection()) 
            {
                string sql = "";
                sql = sql + "UPDATE [dbo].[Customers] " + "\n";
                sql = sql + "   SET [CustomerID] = @customerId " + "\n";
                sql = sql + "      ,[CompanyName] = @companyName " + "\n";
                sql = sql + "      ,[ContactName] = @contactName " + "\n";
                sql = sql + "      ,[ContactTitle] = @contactTitle " + "\n";
                sql = sql + "      ,[Address] = @address " + "\n";
                sql = sql + "      ,[City] = @city " + "\n";
                sql = sql + " WHERE CustomerID = @customerID;";

                using (var comando =new SqlCommand(sql,conexion)) 
                {
                    comando.Parameters.AddWithValue("customerId", customer.CustomerID);
                    comando.Parameters.AddWithValue("companyName", customer.CompanyName);
                    comando.Parameters.AddWithValue("contactName", customer.ContactName);
                    comando.Parameters.AddWithValue("contactTitle", customer.ContactTitle);
                    comando.Parameters.AddWithValue("address", customer.Address);
                    comando.Parameters.AddWithValue("city", customer.City);

                    var actualizados = comando.ExecuteNonQuery();
                    return actualizados;
                }
            }
        }

        public int EliminarCliente(string id)
        {
            using (var conexion = Database.GetSqlConnection())
            {
                String sql = "";
                sql = sql + "DELETE FROM [dbo].[Customers] " + "\n";
                sql = sql + "      WHERE CustomerID = @customerID";

                using (var comando = new SqlCommand(sql,conexion))
                {
                    comando.Parameters.AddWithValue("@customerID", id);
                    int eliminados = comando.ExecuteNonQuery();
                    return eliminados; 
                }

            }
            
        }

    }

}

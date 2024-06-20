using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CustomerRepository
    {
        public DataTable ObtenerTodos() 
        {
            var dataTable = new DataTable();

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

           

            SqlDataAdapter adapter = new SqlDataAdapter(sql, Database.ConnectionString);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public Customer ExtraerInformacionCliente(DataTable table) 
        {
            Customer customer = new Customer();
            foreach (DataRow fila in table.Rows) 
            {
                customer.CustomerID = fila.Field<string>("CustomerID");
                customer.CompanyName = fila.Field<string>("CompanyName");
                customer.ContactName = fila.Field<string>("ContactName");
                customer.ContactTitle = fila.Field<string>("ContactTitle");
                customer.Address = fila.Field<string>("Address");
                customer.City = fila.Field<string>("City");
                customer.Region = fila.Field<string>("Region");
                customer.PostalCode = fila.Field<string>("PostalCode");
                customer.Country = fila.Field<string>("Country");
                customer.Phone = fila.Field<string>("Phone");
                customer.Fax = fila.Field<string>("Fax");

            }
            return customer;
        }


        public Customer ObtenerPorID(string id) 
        {
            using (var conexion = Database.GetSqlConnection()) 
            {
                var dataTable = new DataTable();

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
                sql = sql + "  Where CustomerID = @customerID";

                using (var comando = new SqlCommand(sql, conexion) ) 
                { 
                
                    comando.Parameters.AddWithValue("CustomerID", id);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(dataTable);

                    var cliente = ExtraerInformacionCliente(dataTable);
                    return cliente;
                    
                }
            }
        }

        public int InsertarCliente(Customer cliente) 
        {
            using (var conexion = Database.GetSqlConnection()) 
            {
                String sql = "";
                sql = sql + "INSERT INTO [dbo].[Customers] " + "\n";
                sql = sql + "           ([CustomerID] " + "\n";
                sql = sql + "           ,[CompanyName] " + "\n";
                sql = sql + "           ,[ContactName] " + "\n";
                sql = sql + "           ,[ContactTitle] " + "\n";
                sql = sql + "           ,[Address]) " + "\n";
                sql = sql + "     VALUES " + "\n";
                sql = sql + "           (@customerID " + "\n";
                sql = sql + "           ,@companyName " + "\n";
                sql = sql + "           ,@contactName " + "\n";
                sql = sql + "           ,@contactTitle " + "\n";
                sql = sql + "           ,@address)";

                using (var comando = new SqlCommand(sql,conexion)) 
                {
                    comando.Parameters.AddWithValue("customerID",cliente.CustomerID);
                    comando.Parameters.AddWithValue("companyName", cliente.CompanyName);
                    comando.Parameters.AddWithValue("contactName", cliente.ContactName);
                    comando.Parameters.AddWithValue("contactTitle", cliente.ContactTitle);
                    comando.Parameters.AddWithValue("address", cliente.Address);
                    SqlDataAdapter adapatador = new SqlDataAdapter(comando);
                    adapatador.InsertCommand = comando;
                    return adapatador.InsertCommand.ExecuteNonQuery();
                }
            } 
           

            
        }

        public int ActulizarCliente(Customer cliente) 
        {
            using (var conexion = Database.GetSqlConnection()) 
            {
                String sql = "";
                sql = sql + "UPDATE [dbo].[Customers] " + "\n";
                sql = sql + "   SET [CustomerID] = @customerID " + "\n";
                sql = sql + "      ,[CompanyName] = @companyName " + "\n";
                sql = sql + "      ,[ContactName] = @contactName " + "\n";
                sql = sql + "      ,[ContactTitle] = @contactTitle " + "\n";
                sql = sql + "      ,[Address] = @address " + "\n";
                sql = sql + " " + "\n";
                sql = sql + " WHERE CustomerID = @customerID";

                using (var comando = new SqlCommand(sql,conexion)) 
                {
                    comando.Parameters.AddWithValue("customerID", cliente.CustomerID);
                    comando.Parameters.AddWithValue("companyName", cliente.CompanyName);
                    comando.Parameters.AddWithValue("contactName", cliente.ContactName);
                    comando.Parameters.AddWithValue("contactTitle", cliente.ContactTitle);
                    comando.Parameters.AddWithValue("address", cliente.Address);

                    SqlDataAdapter adapatador = new SqlDataAdapter();
                    adapatador.UpdateCommand = comando;
                    return adapatador.UpdateCommand.ExecuteNonQuery();
                }
            }
        }

        public int EliminarCliente(string id) 
        {
            using (var conexion=Database.GetSqlConnection()) 
            {
                String sql = "";
                sql = sql + "DELETE FROM [dbo].[Customers] " + "\n";
                sql = sql + "      WHERE CustomerID=@customerID";

                using (var comando =new  SqlCommand (sql, conexion) ) 
                {

                    comando.Parameters.AddWithValue("customerID",id);
                    SqlDataAdapter adapter= new SqlDataAdapter();
                    adapter.DeleteCommand = comando;
                    var eliminadas = adapter.DeleteCommand.ExecuteNonQuery();
                    return eliminadas;
                }
            }
        }
    }
}

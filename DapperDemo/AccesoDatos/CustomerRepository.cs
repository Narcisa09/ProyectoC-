using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CustomerRepository
    {
        public List<Customer> ObtenerTodos() 
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
                sql = sql + "  FROM [dbo].[Customers]";
                var clientes = conexion.Query<Customer>(sql).ToList();
                return clientes; 
            }
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
                sql = sql + "  Where CustomerID = @customerID";

                var cliente = conexion.QueryFirstOrDefault<Customer>(sql, new { customerID = id });
                return cliente;


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
                sql = sql + "           ,[Address]) " + "\n";
                sql = sql + "     VALUES " + "\n";
                sql = sql + "           (@customerID " + "\n";
                sql = sql + "           ,@companyName " + "\n";
                sql = sql + "           ,@contactName " + "\n";
                sql = sql + "           ,@contactTitle " + "\n";
                sql = sql + "           ,@address)";

                var insertadas = conexion.Execute(sql, new { 
                
                    customerID = customer.CustomerID,
                    companyName = customer.CompanyName,
                    contactName = customer.ContactName,
                    contactTitle = customer.ContactTitle,
                    address = customer.Address

                });
                return insertadas;
            }
        }

        public int ActualizarCliente(Customer customer) 
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
                sql = sql + " WHERE customerID=@customerID";

                var actualizadas = conexion.Execute(sql, new
                {

                    customerID = customer.CustomerID,
                    companyName = customer.CompanyName,
                    contactName = customer.ContactName,
                    contactTitle = customer.ContactTitle,
                    address = customer.Address
                });
                return actualizadas;
            }
        }

        public int EliminarCliente(string id) 
        {
            using (var conexion = Database.GetSqlConnection()) 
            {
                String sql = "";
                sql = sql + "DELETE FROM [dbo].[Customers] " + "\n";
                sql = sql + "      WHERE CustomerID=@customerID";

                var eliminadas = conexion.Execute(sql, new 
                { 
                    customerID= id
                });
                return eliminadas;
            }
        }
    }

   
}

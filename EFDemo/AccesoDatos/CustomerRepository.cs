using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CustomerRepository
    {
        NorthwindEntities contexto = new NorthwindEntities();


        public List<Customer> ObtenerTodos()
        {
            var clientes = from c in contexto.Customers select c;
            return clientes.ToList();
        }

        public Customer ObtenerPorId(string id) 
        {
            var cliente = from c in contexto.Customers where c.CustomerID == id select c;
            return cliente.FirstOrDefault(); 
        }

        public int InsertarCLiente(Customer customer) 
        {
            contexto.Customers.Add(customer);
            return contexto.SaveChanges();
        }

        public int ActualizarCliente(Customer customer) 
        {
            var registro = ObtenerPorId(customer.CustomerID);
            if (registro != null) 
            {
                registro.CustomerID = customer.CustomerID;
                registro.CompanyName = customer.CompanyName;
                registro.ContactName = customer.ContactName;
                registro.ContactTitle= customer.ContactTitle;
                registro.Address = customer.Address;
            }
            return contexto.SaveChanges();
        }

        public int EliminarCliente(string customerId) 
        {
            var registro = ObtenerPorId(customerId);
            if (registro != null) 
            {
                contexto.Customers.Remove(registro);
                return contexto.SaveChanges();
            }

            return 0;
        }
    }
}

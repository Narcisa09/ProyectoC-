using AccesoDatos;
using CapaDesconectada.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDesconectada
{
    public partial class Form1 : Form
    {

        #region NoTipado
        private void btnObtenerNT_Click(object sender, EventArgs e)
        {
            var customers = cr.ObtenerTodos();
            gridNoTipado.DataSource = customers;

        }

        private void RellenarForm(Customer cliente) 
        {
            if (cliente != null)
            {
                txtCustomerID.Text = cliente.CustomerID;
                txtCompanyName.Text = cliente.CompanyName;
                txtContactName.Text = cliente.ContactName;
                txtContactTittle.Text= cliente.ContactTitle;
                txtAddress.Text = cliente.Address;

            }
        }

        private void btnBuscarNT_Click(object sender, EventArgs e)
        {
            var cliente = cr.ObtenerPorID(txtBusquedaNT.Text);
            RellenarForm(cliente);
        }

        private void btnInsertarNT_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int insertados = cr.InsertarCliente(cliente);
            MessageBox.Show($"{insertados} registros insertados");
        }
        private void btnActualizarNT_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            var actualizadas= cr.ActulizarCliente(cliente);
            MessageBox.Show($"{actualizadas} filas actualizadas");
        }

        private void btnEliminarNT_Click(object sender, EventArgs e)
        {

            var eliminadas = cr.EliminarCliente(txtCustomerID.Text);
            MessageBox.Show($"{eliminadas} filas eliminadas");

        }

        #endregion

        private Customer CrearCliente() 
        {
            var cliente = new Customer
            {
                CustomerID = txtCustomerID.Text,
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTittle.Text,
                Address = txtAddress.Text
            };
            return cliente;
        }



        CustomersTableAdapter adapter = new CustomersTableAdapter();

        #region Tipado
        private void btnObtenerT_Click(object sender, EventArgs e)
        {
            var customers = adapter.GetData();
            gridTipado.DataSource = customers;
        }

        private void btnBuscarT_Click(object sender, EventArgs e)
        {
            var customer = adapter.GetDataByCustomerID(txtBuscarT.Text);
            if (customer !=null) 
            {
                var objetoCustomer = cr.ExtraerInformacionCliente(customer);
                RellenarForm(objetoCustomer);
            }
        }

        private void btnInsertarT_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
             int insertados = adapter.Insert(cliente.CustomerID,cliente.CompanyName,cliente.ContactName,cliente.ContactTitle,
                 cliente.Address,cliente.City,cliente.Region,cliente.PostalCode,cliente.Country,cliente.Phone,cliente.Fax);

            MessageBox.Show($"{insertados} registros insertados");
        }

        private void btnActualizarT_Click(object sender, EventArgs e)
        {
            var fila = adapter.GetDataByCustomerID(txtCustomerID.Text);

            if (fila != null) 
            {
                var original = cr.ExtraerInformacionCliente(fila);
                var modificada = CrearCliente();
                var filas = adapter.ActualizarCliente(modificada.CustomerID,
                    modificada.CompanyName,
                    modificada.ContactName,
                    modificada.Fax,
                    modificada.PostalCode,
                    modificada.Address,
                    modificada.City,
                    modificada.Region,
                    modificada.Phone,
                    modificada.Country,
                    modificada.ContactTitle
                    );

                //var filas = adapter.Update(modificada.CustomerID, modificada.CompanyName,modificada.ContactName,
                //    modificada.ContactTitle,modificada.Address,
                //    modificada.City,modificada.Region,modificada.PostalCode,modificada.Country,modificada.Phone,modificada.Fax,
                //    original.CustomerID,original.CompanyName,original.ContactName,original.ContactTitle,
                //    original.Address,original.City,original.Region,original.PostalCode,
                //    original.Country,original.Phone,original.Fax);
                MessageBox.Show($"{filas} filas modificadas" );
            }
        }

        private void btnEliminarT_Click(object sender, EventArgs e)
        {
           var eliminadas= adapter.EliminarCliente(txtCustomerID.Text);
            MessageBox.Show($"{eliminadas} filas eliminadas");

        }

        #endregion

        private CustomerRepository cr = new CustomerRepository();
        public Form1()
        {
            InitializeComponent();
        }

        
    }
}

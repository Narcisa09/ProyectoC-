using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperDemo
{
    public partial class Form1 : Form
    {
        CustomerRepository cr = new CustomerRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            var clientes = cr.ObtenerTodos();
            grid.DataSource=clientes;
        }

        private Customer CrearCliente() 
        {
            var nuevo = new Customer 
            {
                CustomerID = txtCustomerID.Text,
                CompanyName= txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                Address = txtAddress.Text
            };
            return nuevo;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var nuevoCliente = CrearCliente();
            var insertados = cr.InsertarCliente(nuevoCliente);
            MessageBox.Show($"{insertados} registros insertados");
        }

        private void RellenarForm(Customer customer) 
        {
            txtCustomerID.Text= customer.CustomerID;
            txtCompanyName.Text = customer.CompanyName;
            txtContactName.Text = customer.ContactName;
            txtContactTitle.Text= customer.ContactTitle;
            txtAddress.Text= customer.Address;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var cliente = cr.ObtenerPorID(txtBusqueda.Text);
            if (cliente != null)
            {
                RellenarForm(cliente);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var clienteActualizado = CrearCliente();
            var actualizados = cr.ActualizarCliente(clienteActualizado);
            MessageBox.Show($"{actualizados} registros actualizados");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var eliminadas = cr.EliminarCliente(txtCustomerID.Text);
            MessageBox.Show($"{eliminadas} registros eliminados");
        }
    }
}

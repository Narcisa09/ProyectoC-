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

namespace EFDemo
{
    public partial class Form1 : Form
    {
        public CustomerRepository cr = new CustomerRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            var clientes = cr.ObtenerTodos();
            grid.DataSource = clientes;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var cliente = cr.ObtenerPorId(txtBuscar.Text);
            if (cliente != null) 
            {
                RellenarForm(cliente);
            }
        }
        private void RellenarForm(Customer customer) 
        {
            txtCustomerID.Text=customer.CustomerID;
            txtCompanyName.Text = customer.CompanyName;
            txtContactName.Text=customer.ContactName;
            txtContactTitle.Text=customer.ContactTitle;
            txtAddress.Text = customer.Address;
        }
        private Customer CrearCliente() 
        {
            var nuevo = new Customer 
            {
                CustomerID = txtCustomerID.Text,
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                Address = txtAddress.Text
            };
            return nuevo;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int insertados = cr.InsertarCLiente(cliente);
            MessageBox.Show($"{insertados} Registro insertados");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            var actualizadas = cr.ActualizarCliente(cliente);
            MessageBox.Show($"{actualizadas} filas actualizadas");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var eliminadas = cr.EliminarCliente(txtCustomerID.Text);
            MessageBox.Show($"{eliminadas} filas eliminadas");
        }
    }
}

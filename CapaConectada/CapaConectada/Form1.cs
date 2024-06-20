using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DatosLayer;

namespace CapaConectada
{
    public partial class Form1 : Form
    {
        CustomerRepository cr= new CustomerRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var customers = cr.ObtenerTodos();
            dataGrid.DataSource = customers;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //var filtro =
            //    customers.FindAll(X => X.CompanyName.StartsWith(textBox1.Text));
            //dataGrid.DataSource = filtro;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DatosLayer.Database.ApplicationName = "Demo C# a Sql";
            //DatosLayer.Database.ConnectionTimeout = 30;
            //string cadenaConexion = DatosLayer.Database.ConnectionString;
            //var conexion = DatosLayer.Database.GetSqlConnection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var cliente = cr.ObtenerPorID(txtBuscar.Text);

            txtCutomerId.Text = cliente.CustomerID;
            txtCompanyName.Text = cliente.CompanyName;
            txtAddress.Text = cliente.Address;
            txtCity.Text = cliente.City;
            txtContactTitle.Text = cliente.ContactTitle;
            txtContactName.Text = cliente.ContactName;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            var nuevoCliente = ObtenerNuevoCliente();
            if (nuevoCliente.CustomerID == "") 
            {
                MessageBox.Show("El ID del cliente no puede estar vacio");
                return;
            }
            else 
            {
                var insertados = cr.InsertarCliente(nuevoCliente);
                MessageBox.Show($"{insertados} registros insertados");

            }
        }
        private Customer ObtenerNuevoCliente() 
        {
            var nuevoCliente = new Customer
            {
                CustomerID = txtCutomerId.Text,
                ContactName = txtContactTitle.Text,
                CompanyName = txtCompanyName.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                ContactTitle = txtContactTitle.Text,
            };
            return nuevoCliente;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var nuevoCliente = ObtenerNuevoCliente();
            var actualizadas = cr.ActualizarCliente(nuevoCliente);
            MessageBox.Show($"{actualizadas} filas actualizadas");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var eliminadas = cr.EliminarCliente(txtCutomerId.Text);
            MessageBox.Show($"{eliminadas} filas eliminadas");
        }
    }
}

using Microsoft.Data.SqlClient;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucRecepcion : UserControl
    {
        private UIButton botonSeleccionado = null;
        private string tipoDispositivo = "";

        public ucRecepcion()
        {
            InitializeComponent();
        }

        private void ucRecepcion_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            cmbEstado.SelectedIndex = 0;
            cmbSucursal.SelectedIndex = 0;
            cmbTecnico.SelectedIndex = 0;

            MostrarNumeroOrden();
        }

        public void SeleccionarBoton(UIButton boton)
        {

            if (botonSeleccionado != null)
            {
                botonSeleccionado.FillColor = Color.FromArgb(22, 35, 52);
                botonSeleccionado.RectColor = Color.Gray;
                botonSeleccionado.ForeColor = Color.White;
            }


            boton.FillColor = Color.FromArgb(0, 150, 137);
            boton.RectColor = Color.FromArgb(0, 150, 137);
            boton.ForeColor = Color.FromArgb(22, 35, 52);

            botonSeleccionado = boton;
        }

        private void btnComputadora_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(btnComputadora);
            tipoDispositivo = "computadora";
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(btnTelefono);
            tipoDispositivo = "teléfono";
        }
        private void MostrarNumeroOrden()
        {
            var db = new Conexion_Base_de_Datos();

            using (SqlConnection con = db.ObtenerConexion())
            {
                con.Open();

                string query = "SELECT TOP 1 numero_orden FROM clientes ORDER BY id DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    var resultado = cmd.ExecuteScalar();
                    lblOrden.Text = resultado.ToString();
                }
            }
        }

        private void GuardarRecepcion()
        {
            var db = new Conexion_Base_de_Datos();

            using (SqlConnection con = db.ObtenerConexion())
            {
                con.Open();

                // INSERT Cliente
                string queryCliente = @"INSERT INTO clientes 
                        (nombre, telefono, correo, cedula, pasaporte, tipo_dispositivo)
                        VALUES 
                        (@nombre, @telefono, @correo, @cedula, @pasaporte, @tipo_dispositivo)";

                using (SqlCommand cmd = new SqlCommand(queryCliente, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombres.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefono", txtNumeroTelefonico.Text.Trim());
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@cedula",
                        string.IsNullOrEmpty(txtIdentificacionCliente.Text) ? (object)DBNull.Value : txtIdentificacionCliente.Text.Trim());
                    cmd.Parameters.AddWithValue("@pasaporte",
                        string.IsNullOrEmpty(txtIdentificacionCliente.Text) ? (object)DBNull.Value : txtIdentificacionCliente.Text.Trim());
                    cmd.Parameters.AddWithValue("@tipo_dispositivo", tipoDispositivo);

                    cmd.ExecuteNonQuery();
                }

                // INSERT Dispositivo
                string queryDispositivo = @"INSERT INTO dispositivos 
                        (tipo, marca, modelo, serie_imei, color, estado_llegada)
                        VALUES 
                        (@tipo, @marca, @modelo, @serie_imei, @color, @estado_llegada)";

                using (SqlCommand cmd = new SqlCommand(queryDispositivo, con))
                {
                    cmd.Parameters.AddWithValue("@tipo", tipoDispositivo);
                    cmd.Parameters.AddWithValue("@marca", txtMarca.Text.Trim());
                    cmd.Parameters.AddWithValue("@modelo", txtModelo.Text.Trim());
                    cmd.Parameters.AddWithValue("@serie_imei", txtSerie.Text.Trim());
                    cmd.Parameters.AddWithValue("@color", txtColor.Text.Trim());
                    cmd.Parameters.AddWithValue("@estado_llegada", cmbEstado.SelectedItem?.ToString());

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Recepción guardada correctamente.");
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            GuardarRecepcion();
        }
    }
}

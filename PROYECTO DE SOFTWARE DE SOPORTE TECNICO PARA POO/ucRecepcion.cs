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
            tipoDispositivo = "telefono";
        }

        private void MostrarNumeroOrden()
        {
            var db = new Conexion_Base_de_Datos();

            using (SqlConnection con = db.ObtenerConexion())
            {
                con.Open();

                string query = "SELECT ISNULL(MAX(id), 0) FROM ordenes";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    int ultimoId = Convert.ToInt32(cmd.ExecuteScalar());
                    lblOrden.Text = "ORD-" + DateTime.Now.Year + "-" + (ultimoId + 1).ToString("D3");
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
                        (@nombre, @telefono, @correo, @cedula, @pasaporte, @tipo_dispositivo);
                        SELECT SCOPE_IDENTITY();";

                int idCliente;
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

                    idCliente = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // INSERT Dispositivo
                string queryDispositivo = @"INSERT INTO dispositivos 
                        (tipo, marca, modelo, serie_imei, color, estado_llegada)
                        VALUES 
                        (@tipo, @marca, @modelo, @serie_imei, @color, @estado_llegada);
                        SELECT SCOPE_IDENTITY();";

                int idDispositivo;
                using (SqlCommand cmd = new SqlCommand(queryDispositivo, con))
                {
                    cmd.Parameters.AddWithValue("@tipo", tipoDispositivo);
                    cmd.Parameters.AddWithValue("@marca", txtMarca.Text.Trim());
                    cmd.Parameters.AddWithValue("@modelo", txtModelo.Text.Trim());
                    cmd.Parameters.AddWithValue("@serie_imei", txtSerie.Text.Trim());
                    cmd.Parameters.AddWithValue("@color", txtColor.Text.Trim());
                    cmd.Parameters.AddWithValue("@estado_llegada", cmbEstado.SelectedItem?.ToString());

                    idDispositivo = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // INSERT Orden
                string queryOrden = @"INSERT INTO ordenes 
                (numero_orden, cliente_id, dispositivo_id, tecnico_id, sucursal_id, 
                 descripcion_problema, diagnostico_inicial, estado,
                 costo_estimado, fecha_ingreso, fecha_estimada_entrega)
                VALUES 
                (@numero_orden, @cliente_id, @dispositivo_id, @tecnico_id, @sucursal_id,
                 @descripcion_problema, @diagnostico_inicial, @estado,
                 @costo_estimado, @fecha_ingreso, @fecha_estimada_entrega)";

                using (SqlCommand cmd = new SqlCommand(queryOrden, con))
                {
                    cmd.Parameters.AddWithValue("@cliente_id", idCliente);
                    cmd.Parameters.AddWithValue("@dispositivo_id", idDispositivo);

                    int[] idsTecnicos = { 0, 11, 13, 14 };
                    cmd.Parameters.AddWithValue("@tecnico_id",
                        cmbTecnico.SelectedIndex >= 0 ? (object)idsTecnicos[cmbTecnico.SelectedIndex] : DBNull.Value);

                    int[] idsSucursales = { 1, 2, 3, 4 };
                    cmd.Parameters.AddWithValue("@sucursal_id",
                        cmbSucursal.SelectedIndex >= 0 ? (object)idsSucursales[cmbSucursal.SelectedIndex] : DBNull.Value);

                    cmd.Parameters.AddWithValue("@descripcion_problema", txtDescripcionProblema.Text.Trim());
                    cmd.Parameters.AddWithValue("@diagnostico_inicial", txtObservaciones.Text.Trim());
                    cmd.Parameters.AddWithValue("@estado", "Recibido");
                    cmd.Parameters.AddWithValue("@costo_estimado", decimal.Parse(txtCosto.Text));
                    cmd.Parameters.AddWithValue("@fecha_ingreso", DateTime.Now);
                    cmd.Parameters.AddWithValue("@fecha_estimada_entrega", dtmFecha.Value.Date);
                    cmd.Parameters.AddWithValue("@numero_orden", lblOrden.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Recepción guardada correctamente.");
            MostrarNumeroOrden();
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            if (cmbTecnico.SelectedIndex < 0 || cmbSucursal.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un técnico y una sucursal.");
                return;
            }
            GuardarRecepcion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Datos del cliente
            txtNombres.Text = "";
            txtNumeroTelefonico.Text = "";
            txtCorreo.Text = "";
            txtIdentificacionCliente.Text = "";

            // Datos del dispositivo
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtSerie.Text = "";
            txtColor.Text = "";
            cmbEstado.SelectedIndex = 0;

            // Datos de la reparación
            txtDescripcionProblema.Text = "";
            txtObservaciones.Text = "";
            cmbTecnico.SelectedIndex = 0;
            cmbSucursal.SelectedIndex = 0;
            txtCosto.Text = "0";
            dtmFecha.Value = DateTime.Now;

            // Botón tipo dispositivo
            tipoDispositivo = "";
            if (botonSeleccionado != null)
            {
                botonSeleccionado.FillColor = Color.FromArgb(22, 35, 52);
                botonSeleccionado.RectColor = Color.Gray;
                botonSeleccionado.ForeColor = Color.White;
                botonSeleccionado = null;
            }
        }
    }
}
using Microsoft.Data.SqlClient;
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
    public partial class frmNuevaVenta : Form
    {
        ucRecepcion Unsoloboton = new ucRecepcion();

        private string tipoVentaSeleccionado = "Nuevo";
        private string estadoEquipoSeleccionado = "Nuevo";

        public frmNuevaVenta()
        {
            InitializeComponent();
        }

        private void frmNuevaVenta_Load(object sender, EventArgs e)
        {
            // Opcional: Al abrir el formulario por defecto ya puede iniciar seleccionando ambos "Nuevo"
            Unsoloboton.SeleccionarBoton(btnNuevo);
            Unsoloboton.SeleccionarBoton(btnEstadoNuevo);
        }

        // --- Eventos de los botones de tipo de venta ---
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnNuevo);
            tipoVentaSeleccionado = "Nuevo";

            // REGLA: Si la venta es "Nuevo", el estado del equipo también pasa a ser "Nuevo" automáticamente
            Unsoloboton.SeleccionarBoton(btnEstadoNuevo);
            estadoEquipoSeleccionado = "Nuevo";
        }

        private void btnSegundaMano_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnSegundaMano);
            tipoVentaSeleccionado = "2ª mano";
        }

        // --- Eventos de los botones de estado del equipo ---
        private void btnEstadoNuevo_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnEstadoNuevo);
            estadoEquipoSeleccionado = "Nuevo";
        }

        private void btnEstadoSeminuevo_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnEstadoSeminuevo);
            estadoEquipoSeleccionado = "Seminuevo";
        }

        private void btnEstadoBueno_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnEstadoBueno);
            estadoEquipoSeleccionado = "Bueno";
        }

        // --- Autocompletar cliente al salir de la Cédula ---
        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
                return;

            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    string query = "SELECT nombre, telefono FROM clientes WHERE cedula_pasaporte = @cedula";
                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@cedula", txtCedula.Text.Trim());
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNombreComprador.Text = reader["nombre"].ToString();
                                txtTelefonoComprador.Text = reader["telefono"].ToString();
                            }
                            else
                            {
                                txtNombreComprador.Clear();
                                txtTelefonoComprador.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        // --- Botón Guardar Cambios ---
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim();
            string nombre = txtNombreComprador.Text.Trim();
            string telefono = txtTelefonoComprador.Text.Trim();

            if (string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor ingresa al menos la cédula y el nombre del comprador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    string queryVenta = @"
    INSERT INTO VentasDirectas (
        CedulaCliente, NombreCliente, TelefonoCliente, 
        TipoVenta, MarcaNuevo, ModeloNuevo, EstadoEquipo, 
        PrecioOriginal, FormaPago, GarantiaOfrecida
    ) VALUES (
        @cedulaCliente, @nombreCliente, @telefonoCliente, 
        @tipoVenta, @marcaNuevo, @modeloNuevo, @estadoEquipo, 
        @precioOriginal, @formaPago, @garantia
    )";

                    using (SqlCommand cmdVenta = new SqlCommand(queryVenta, db.oCon))
                    {
                        cmdVenta.Parameters.AddWithValue("@cedulaCliente", cedula);
                        cmdVenta.Parameters.AddWithValue("@nombreCliente", nombre);
                        cmdVenta.Parameters.AddWithValue("@telefonoCliente", telefono);

                        // Estos tres son los que acabamos de habilitar en SQL:
                        cmdVenta.Parameters.AddWithValue("@tipoVenta", tipoVentaSeleccionado);
                        cmdVenta.Parameters.AddWithValue("@marcaNuevo", txtMarca.Text.Trim());
                        cmdVenta.Parameters.AddWithValue("@modeloNuevo", txtModelo.Text.Trim());
                        cmdVenta.Parameters.AddWithValue("@estadoEquipo", estadoEquipoSeleccionado);

                        decimal.TryParse(txtPrecioVenta.Text, out decimal precioVenta);
                        cmdVenta.Parameters.AddWithValue("@precioOriginal", precioVenta);

                        cmdVenta.Parameters.AddWithValue("@formaPago", cmbFormaPago.Text ?? "");
                        cmdVenta.Parameters.AddWithValue("@garantia", txtGarantiaOfrecida.Text.Trim());

                        int filasAfectadas = cmdVenta.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("¡Venta registrada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar la venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la venta: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        // --- Botón Cancelar ---
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
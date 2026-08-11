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
    public partial class ucTradeIn : UserControl
    {
        ucRecepcion Unsoloboton = new ucRecepcion();

        public ucTradeIn()
        {
            InitializeComponent();
        }

        private void btnComputadora_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnComputadora);
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnTelefono);
        }

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
                                txtNombre.Text = reader["nombre"].ToString();
                                txtNumeroTelefonico.Text = reader["telefono"].ToString();
                            }
                            else
                            {
                                txtNombre.Clear();
                                txtNumeroTelefonico.Clear();
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

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    string query = @"
                        INSERT INTO TradeIn (
                            TipoDispositivo, MarcaRecibido, ModeloRecibido, ImeiSerie, 
                            EstadoFisico, EstadoFuncional, ValorAsignado, 
                            CedulaCliente, NombreCliente, TelefonoCliente, 
                            MarcaNuevo, ModeloNuevo, PrecioOriginal, FormaPagoDiferencia, 
                            PrecioEquipoNuevo, ValorTradeIn, DiferenciaAPagar
                        ) VALUES (
                            @tipo, @marcaRecibido, @modeloRecibido, @imei, 
                            @estadoFisico, @estadoFuncional, @valorAsignado, 
                            @cedula, @nombre, @telefono, 
                            @marcaNuevo, @modeloNuevo, @precioOriginal, @formaPago, 
                            @precioEquipoNuevo, @valorTradeIn, @diferencia
                        )";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        // Definición del tipo de dispositivo según tu lógica de negocio
                        string tipoDispositivo = "Computadora";
                        cmd.Parameters.AddWithValue("@tipo", tipoDispositivo);

                        cmd.Parameters.AddWithValue("@marcaRecibido", txtMarcaRecibido.Text);
                        cmd.Parameters.AddWithValue("@modeloRecibido", txtModeloRecibido.Text);
                        cmd.Parameters.AddWithValue("@imei", txtSerieCanje.Text);
                        cmd.Parameters.AddWithValue("@estadoFisico", cmbEstadoFisico.Text ?? "");
                        cmd.Parameters.AddWithValue("@estadoFuncional", cmbEstadoFuncional.Text ?? "");

                        decimal.TryParse(txtValorAsignado.Text, out decimal valorAsignado);
                        cmd.Parameters.AddWithValue("@valorAsignado", valorAsignado);

                        cmd.Parameters.AddWithValue("@cedula", txtCedula.Text);
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtNumeroTelefonico.Text);

                        cmd.Parameters.AddWithValue("@marcaNuevo", txtMarcaNuevo.Text);
                        cmd.Parameters.AddWithValue("@modeloNuevo", txtModeloNuevo.Text);

                        decimal.TryParse(txtPrecioOriginal.Text, out decimal precioOriginal);
                        cmd.Parameters.AddWithValue("@precioOriginal", precioOriginal);

                        cmd.Parameters.AddWithValue("@formaPago", cmbFormaPago.Text ?? "");

                        decimal.TryParse(lblPrecioEquipoNuevo.Text.Replace("$", "").Trim(), out decimal precioEquipoNuevo);
                        cmd.Parameters.AddWithValue("@precioEquipoNuevo", precioEquipoNuevo);

                        decimal.TryParse(lblValorTradeIn.Text.Replace("$", "").Trim(), out decimal valorTradeIn);
                        cmd.Parameters.AddWithValue("@valorTradeIn", valorTradeIn);

                        decimal.TryParse(lblDiferencia.Text.Replace("$", "").Trim(), out decimal diferencia);
                        cmd.Parameters.AddWithValue("@diferencia", diferencia);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("¡Trade-In registrado exitosamente en la base de datos!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Parent.Controls.Remove(this);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar la transacción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el trade-in: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        // Método central para hacer los cálculos automáticos
        private void CalcularTotales()
        {
            // 1. Obtenemos el precio del equipo nuevo (columna central)
            decimal.TryParse(txtPrecioOriginal.Text, out decimal precioNuevo);

            // 2. Obtenemos el valor asignado al equipo usado (columna izquierda)
            decimal.TryParse(txtValorAsignado.Text, out decimal valorTradeIn);

            // 3. Calculamos la diferencia a pagar
            decimal diferencia = precioNuevo - valorTradeIn;
            if (diferencia < 0) diferencia = 0; // Evita valores negativos por seguridad

            // 4. Actualizamos las etiquetas del resumen (tarjeta derecha)
            lblPrecioEquipoNuevo.Text = "$" + precioNuevo.ToString("0.00");
            lblValorTradeIn.Text = "$" + valorTradeIn.ToString("0.00");
            lblDiferencia.Text = "$" + diferencia.ToString("0.00");
        }

        // Eventos que disparan el cálculo automáticamente cuando el usuario escribe
        private void txtPrecioOriginal_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void txtValorAsignado_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }
    }
}
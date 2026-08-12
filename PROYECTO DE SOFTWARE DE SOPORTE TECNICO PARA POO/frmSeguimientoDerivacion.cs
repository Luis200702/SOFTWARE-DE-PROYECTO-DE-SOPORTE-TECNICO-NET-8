using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class frmSeguimientoDerivacion : Form
    {
        private int idOrdenSeleccionada;
        private string sucursalOrigenActual;

        // Recibe el ID de la orden y la sucursal actual desde el módulo de Seguimiento
        public frmSeguimientoDerivacion(int idOrden, string sucursalOrigen)
        {
            InitializeComponent();
            idOrdenSeleccionada = idOrden;
            sucursalOrigenActual = sucursalOrigen;
            CargarSucursales();
        }

        private void CargarSucursales()
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    // Consulta a tu tabla de Sucursales excluyendo la sucursal en la que ya está el equipo
                    string query = "SELECT NombreSucursal FROM Sucursales WHERE NombreSucursal <> @origen";
                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@origen", sucursalOrigenActual);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbSucursalDestino.Items.Add(reader["NombreSucursal"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar sucursales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        private void btnConfirmarDerivacion_Click(object sender, EventArgs e)
        {
            if (cmbSucursalDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecciona una sucursal destino.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    string query = @"
                        INSERT INTO DerivacionesSucursales (
                            IdOrden, SucursalOrigen, SucursalDestino, 
                            Estado, Motivo, Detalle, FechaDerivacion
                        ) VALUES (
                            @idOrden, @origen, @destino, 
                            'Pendiente', @motivo, @detalle, GETDATE()
                        )";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@idOrden", idOrdenSeleccionada);
                        cmd.Parameters.AddWithValue("@origen", sucursalOrigenActual);
                        cmd.Parameters.AddWithValue("@destino", cmbSucursalDestino.Text);
                        cmd.Parameters.AddWithValue("@motivo", txtMotivo.Text.Trim());
                        cmd.Parameters.AddWithValue("@detalle", txtDetalle.Text.Trim());

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("¡Equipo derivado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la derivación: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
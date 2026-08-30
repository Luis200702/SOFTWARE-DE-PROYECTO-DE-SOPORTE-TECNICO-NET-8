using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class frmAggStock : Form
    {
        // Variables globales para guardar los datos que nos envía la pantalla anterior
        private int idRepuestoActual;
        private int idSucursalActual;
        private int stockActual = 0;

        // Modificamos el constructor para recibir los 4 parámetros
        public frmAggStock(int idRepuesto, int idSucursal, string nombreRepuesto, string nombreSucursal)
        {
            InitializeComponent();

            idRepuestoActual = idRepuesto;
            idSucursalActual = idSucursal;

            // Mostramos el nombre del producto y la sucursal en el título de la ventana
            lblProducto.Text = $"{nombreRepuesto} ({nombreSucursal})";
        }

        private void frmAggStock_Load(object sender, EventArgs e)
        {
            CargarStockActual();
        }

        // Consultamos la base de datos para obtener el stock real de ese repuesto en ESA sucursal
        private void CargarStockActual()
        {
            Conexion_Base_de_Datos db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    string query = "SELECT StockActual FROM InventarioSucursal WHERE IdRepuesto = @idRepuesto AND IdSucursal = @idSucursal";
                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@idRepuesto", idRepuestoActual);
                        cmd.Parameters.AddWithValue("@idSucursal", idSucursalActual);

                        object resultado = cmd.ExecuteScalar();
                        if (resultado != null)
                        {
                            stockActual = Convert.ToInt32(resultado);
                            llbStockA.Text = stockActual.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar el stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
            CalcularStockResultante();
        }

        // Se ejecuta cada vez que el usuario escribe un número en la caja de texto
        private void udoAgg_TextChanged(object sender, EventArgs e)
        {
            CalcularStockResultante();
        }

        private void CalcularStockResultante()
        {
            int cantidadAgregar = 0;

            // Si el texto es un número válido, lo sumamos al stock actual
            if (int.TryParse(udoAgg.Text, out cantidadAgregar))
            {
                // Si el control del resultado se llama diferente, cambia "lblStockResultante" por tu nombre real
                lblStockResultante.Text = (stockActual + cantidadAgregar).ToString();
            }
            else
            {
                lblStockResultante.Text = "-----";
            }
        }

        // OJO: Debes hacer doble clic en tu botón verde "Confirmar" en el diseño para enlazar este evento
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int cantidadAgregar = 0;

            if (!int.TryParse(udoAgg.Text, out cantidadAgregar) || cantidadAgregar <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida mayor a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                udoAgg.Focus();
                return;
            }

            Conexion_Base_de_Datos db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    // Actualizamos EXCLUSIVAMENTE el inventario de la sucursal seleccionada
                    string query = @"
                        UPDATE InventarioSucursal 
                        SET StockActual = StockActual + @cantidad 
                        WHERE IdRepuesto = @idRepuesto AND IdSucursal = @idSucursal";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", cantidadAgregar);
                        cmd.Parameters.AddWithValue("@idRepuesto", idRepuestoActual);
                        cmd.Parameters.AddWithValue("@idSucursal", idSucursalActual);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Stock actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cerramos indicando que todo salió bien para que la tabla principal se recargue
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // (Los eventos vacíos que no uses puedes eliminarlos sin problema)
        private void txtCompatible_TextChanged(object sender, EventArgs e) { }
        private void lblProducto_Click(object sender, EventArgs e) { }
        private void llbStockA_Click(object sender, EventArgs e) { }
        private void lblAgregar_Click(object sender, EventArgs e) { }
    }
}
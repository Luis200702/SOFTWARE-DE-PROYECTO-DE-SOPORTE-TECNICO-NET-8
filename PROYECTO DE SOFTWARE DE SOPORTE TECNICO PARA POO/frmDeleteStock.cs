using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class frmDeleteStock : Form
    {
        // Variables globales para guardar los datos que nos envía la pantalla del DataGridView
        private int idRepuestoActual;
        private int idSucursalActual;
        private int stockActual = 0;

        // Modificamos el constructor para recibir los 4 parámetros exactamente igual que en frmAggStock
        public frmDeleteStock(int idRepuesto, int idSucursal, string nombreRepuesto, string nombreSucursal)
        {
            InitializeComponent();

            idRepuestoActual = idRepuesto;
            idSucursalActual = idSucursal;

            // Mostramos el nombre del producto y la sucursal en el título
            lblProducto.Text = $"{nombreRepuesto} ({nombreSucursal})";
        }

        private void frmDeleteStock_Load(object sender, EventArgs e)
        {
            CargarStockActual();
        }

        // Consultamos la base de datos para obtener el stock real
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
            int cantidadReducir = 0;

            // Si el texto es un número válido, lo restamos al stock actual
            if (int.TryParse(udoAgg.Text, out cantidadReducir))
            {
                int stockFinal = stockActual - cantidadReducir;
                lblStockResultante.Text = stockFinal.ToString();

                // Efecto visual: Si la resta da negativo, lo pintamos de rojo para advertir al usuario
                if (stockFinal < 0)
                    lblStockResultante.ForeColor = System.Drawing.Color.Red;
                else
                    lblStockResultante.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                lblStockResultante.Text = "-----";
                lblStockResultante.ForeColor = System.Drawing.Color.Black;
            }
        }

        // OJO: Haz doble clic en tu botón verde "Confirmar" en el diseño para enlazar este evento
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int cantidadReducir = 0;

            if (!int.TryParse(udoAgg.Text, out cantidadReducir) || cantidadReducir <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida mayor a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                udoAgg.Focus();
                return;
            }

            // 🔥 VALIDACIÓN ESTRELLA: No podemos quitar más stock del que existe
            if (cantidadReducir > stockActual)
            {
                MessageBox.Show("No puedes registrar una salida mayor a la cantidad que tienes actualmente en inventario.", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                udoAgg.Focus();
                return;
            }

            Conexion_Base_de_Datos db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    // Restamos la cantidad al inventario de la sucursal actual
                    string query = @"
                        UPDATE InventarioSucursal 
                        SET StockActual = StockActual - @cantidad 
                        WHERE IdRepuesto = @idRepuesto AND IdSucursal = @idSucursal";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", cantidadReducir);
                        cmd.Parameters.AddWithValue("@idRepuesto", idRepuestoActual);
                        cmd.Parameters.AddWithValue("@idSucursal", idSucursalActual);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Stock reducido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
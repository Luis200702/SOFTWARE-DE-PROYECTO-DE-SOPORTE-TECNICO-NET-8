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
    public partial class frmRegistrarEntrega : Form
    {
        public frmRegistrarEntrega()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Cancel;
            this.Close();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            // 1. Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioCosto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                MessageBox.Show("Por favor, completa los campos obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Unimos la Marca y el Modelo para guardarlos en el campo Compatibilidad
            string marcaYModelo = txtMarca.Text.Trim() + " " + txtModelo.Text.Trim();

            // 3. Convertir los textos a números (decimales y enteros)
            decimal precioCosto = 0, precioVenta = 0;
            int cantidadInicial = 0, stockMinimo = 1;

            decimal.TryParse(txtPrecioCosto.Text, out precioCosto);
            decimal.TryParse(txtPrecioVenta.Text, out precioVenta);
            int.TryParse(txtCantidadInicial.Text, out cantidadInicial);
            int.TryParse(txtStockMinimo.Text, out stockMinimo);

            // 4. Iniciar la conexión a la base de datos usando tu clase
            Conexion_Base_de_Datos conexionBD = new Conexion_Base_de_Datos();

            if (conexionBD.abrirConexion())
            {
                // INICIAMOS TRANSACCIÓN
                SqlTransaction transaccion = conexionBD.oCon.BeginTransaction();

                try
                {
                    // --- PASO A: Guardar el Repuesto ---
                    string queryRepuesto = @"
                        INSERT INTO Repuestos (NombreRepuesto, Categoria, Compatibilidad, PrecioCosto, PrecioVenta, Proveedor) 
                        VALUES (@Nombre, @Categoria, @Compatibilidad, @Costo, @Venta, @Proveedor);
                        SELECT SCOPE_IDENTITY();"; // Nos devuelve el ID generado

                    SqlCommand cmdRepuesto = new SqlCommand(queryRepuesto, conexionBD.oCon, transaccion);
                    cmdRepuesto.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    cmdRepuesto.Parameters.AddWithValue("@Categoria", cmbCategoria.Text);
                    cmdRepuesto.Parameters.AddWithValue("@Compatibilidad", marcaYModelo.Trim());
                    cmdRepuesto.Parameters.AddWithValue("@Costo", precioCosto);
                    cmdRepuesto.Parameters.AddWithValue("@Venta", precioVenta);
                    cmdRepuesto.Parameters.AddWithValue("@Proveedor", txtProveedor.Text.Trim());

                    // Obtenemos el ID del nuevo repuesto
                    int idNuevoRepuesto = Convert.ToInt32(cmdRepuesto.ExecuteScalar());

                    // --- PASO B: Guardar el Inventario (¡Aquí está el ajuste clave del texto!) ---
                    string queryInventario = @"
                        INSERT INTO InventarioSucursal (Sucursal, IdRepuesto, StockActual, StockMinimo) 
                        VALUES (@Sucursal, @IdRepuesto, @StockActual, @StockMinimo)";

                    SqlCommand cmdInventario = new SqlCommand(queryInventario, conexionBD.oCon, transaccion);
                    // Pasamos el texto exacto de la sucursal, tal como lo configuramos en la BD
                    cmdInventario.Parameters.AddWithValue("@Sucursal", "Matriz Quevedo");
                    cmdInventario.Parameters.AddWithValue("@IdRepuesto", idNuevoRepuesto);
                    cmdInventario.Parameters.AddWithValue("@StockActual", cantidadInicial);
                    cmdInventario.Parameters.AddWithValue("@StockMinimo", stockMinimo);

                    cmdInventario.ExecuteNonQuery();

                    // Confirmamos que todo salió perfecto
                    transaccion.Commit();
                    conexionBD.cerrarConexion();

                    MessageBox.Show("Repuesto registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cerramos y mandamos la señal OK para recargar la tabla
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Deshacemos todo si hay un error
                    transaccion.Rollback();
                    conexionBD.cerrarConexion();
                    MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class frmRegistrarEntrega : Form
    {
        public frmRegistrarEntrega()
        {
            InitializeComponent();

            // 🔥 Disparamos la magia visual apenas arranca el formulario
            AplicarDiseñoWeb();

            // 🏷️ Cargamos todas las marcas disponibles en el ComboBox de marcas
            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarca, "");
        }

        // --- MÉTODO PARA REPLICAR EL DISEÑO WEB LIMPIO ---
        private void AplicarDiseñoWeb()
        {
            Color fondoBlanco = Color.White;
            Color bordeGris = Color.FromArgb(220, 224, 230);
            Color textoOscuro = Color.FromArgb(60, 60, 60);
            Color verdeTeal = Color.FromArgb(0, 165, 140);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is UITextBox txt)
                {
                    txt.FillColor = fondoBlanco;
                    txt.RectColor = bordeGris;
                    txt.ForeColor = textoOscuro;
                    txt.SymbolColor = verdeTeal;
                }
                else if (ctrl is UIComboBox cmb)
                {
                    cmb.FillColor = fondoBlanco;
                    cmb.RectColor = bordeGris;
                    cmb.ForeColor = textoOscuro;
                }
            }

            try
            {
                if (txtNombre != null) { txtNombre.Symbol = 61467; txtNombre.Watermark = "Modelo del repuesto"; }
                if (txtModelo != null) { txtModelo.Symbol = 61707; txtModelo.Watermark = "Ej. Galaxy S22"; }
                if (txtCantidadInicial != null) { txtCantidadInicial.Symbol = 61893; }
                if (txtStockMinimo != null) { txtStockMinimo.Symbol = 61528; }
                if (txtProveedor != null) { txtProveedor.Symbol = 61447; txtProveedor.Watermark = "Nombre del proveedor"; }

                if (btnCancelar != null)
                {
                    btnCancelar.FillColor = fondoBlanco;
                    btnCancelar.FillHoverColor = Color.FromArgb(245, 245, 245);
                    btnCancelar.ForeColor = textoOscuro;
                    btnCancelar.RectColor = bordeGris;
                    btnCancelar.Cursor = Cursors.Hand;
                }

                if (btnGuardarCambios != null)
                {
                    btnGuardarCambios.FillColor = verdeTeal;
                    btnGuardarCambios.FillHoverColor = Color.FromArgb(0, 180, 155);
                    btnGuardarCambios.ForeColor = fondoBlanco;
                    btnGuardarCambios.RectColor = verdeTeal;
                    btnGuardarCambios.Cursor = Cursors.Hand;
                }
            }
            catch
            {
                // Evitamos que crashee si algún control llega a faltar
            }
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

            // 2. Unimos la Marca (del ComboBox) y el Modelo para guardarlos en Compatibilidad
            string marcaYModelo = cmbMarca.Text.Trim() + " " + txtModelo.Text.Trim();

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
                SqlTransaction transaccion = conexionBD.oCon.BeginTransaction();

                try
                {
                    // --- PASO A: Guardar el Repuesto ---
                    string queryRepuesto = @"
                        INSERT INTO Repuestos (NombreRepuesto, Categoria, Compatibilidad, PrecioCosto, PrecioVenta, Proveedor) 
                        VALUES (@Nombre, @Categoria, @Compatibilidad, @Costo, @Venta, @Proveedor);
                        SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdRepuesto = new SqlCommand(queryRepuesto, conexionBD.oCon, transaccion);
                    cmdRepuesto.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    cmdRepuesto.Parameters.AddWithValue("@Categoria", cmbCategoria.Text);
                    cmdRepuesto.Parameters.AddWithValue("@Compatibilidad", marcaYModelo.Trim());
                    cmdRepuesto.Parameters.AddWithValue("@Costo", precioCosto);
                    cmdRepuesto.Parameters.AddWithValue("@Venta", precioVenta);
                    cmdRepuesto.Parameters.AddWithValue("@Proveedor", txtProveedor.Text.Trim());

                    int idNuevoRepuesto = Convert.ToInt32(cmdRepuesto.ExecuteScalar());

                    // --- PASO B: Guardar el Inventario ---
                    string queryInventario = @"
                        INSERT INTO InventarioSucursal (Sucursal, IdRepuesto, StockActual, StockMinimo) 
                        VALUES (@Sucursal, @IdRepuesto, @StockActual, @StockMinimo)";

                    SqlCommand cmdInventario = new SqlCommand(queryInventario, conexionBD.oCon, transaccion);
                    cmdInventario.Parameters.AddWithValue("@Sucursal", "Matriz Quevedo");
                    cmdInventario.Parameters.AddWithValue("@IdRepuesto", idNuevoRepuesto);
                    cmdInventario.Parameters.AddWithValue("@StockActual", cantidadInicial);
                    cmdInventario.Parameters.AddWithValue("@StockMinimo", stockMinimo);

                    cmdInventario.ExecuteNonQuery();

                    transaccion.Commit();
                    conexionBD.cerrarConexion();

                    MessageBox.Show("Repuesto registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
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
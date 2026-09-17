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
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;

            AplicarDiseñoWeb();


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
                if (cmbProveedor != null) { cmbProveedor.Watermark = "Nombre del proveedor"; }

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
            // CORRECCIÓN: Asignar directamente a la propiedad del formulario
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            // 1. Validaciones básicas de campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtPrecioCosto.Text) ||
            string.IsNullOrWhiteSpace(txtPrecioVenta.Text) ||
            cmbProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, completa los campos obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbProveedor.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un proveedor.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbProveedor.Text.Trim() != cmbMarca.Text.Trim() &&
                cmbProveedor.Text.Trim() != "Otro")
            {
                MessageBox.Show(
                    "El proveedor debe coincidir con la marca seleccionada o seleccionar 'Otro'.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            // 2. CORRECCIÓN: Validación ESTRICTA de tipos numéricos
            if (!decimal.TryParse(txtPrecioCosto.Text, out decimal precioCosto))
            {
                MessageBox.Show(
                    "El precio de costo debe ser un número válido.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (precioCosto <= 0)
            {
                MessageBox.Show(
                    "El precio de costo debe ser mayor que 0.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            if (!decimal.TryParse(txtPrecioVenta.Text, out decimal precioVenta))
            {
                MessageBox.Show(
                    "El precio de venta debe ser un número válido.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (precioVenta <= 0)
            {
                MessageBox.Show(
                    "El precio de venta debe ser mayor que 0.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            // El precio de venta debe ser mayor al costo
            if (precioVenta <= precioCosto)
            {
                MessageBox.Show(
                    "El precio de venta debe ser mayor que el precio de costo.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            // 3. Validación de cantidad inicial
            if (!int.TryParse(txtCantidadInicial.Text, out int cantidadInicial))
            {
                MessageBox.Show(
                    "La cantidad inicial debe ser un número entero válido.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cantidadInicial < 0)
            {
                MessageBox.Show(
                    "La cantidad inicial no puede ser negativa.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            // 4. Validación de stock mínimo
            if (!int.TryParse(txtStockMinimo.Text, out int stockMinimo))
            {
                MessageBox.Show(
                    "El stock mínimo debe ser un número entero válido.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (stockMinimo < 0)
            {
                MessageBox.Show(
                    "El stock mínimo no puede ser negativo.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            // El stock mínimo no puede superar al stock inicial
            if (stockMinimo > cantidadInicial)
            {
                MessageBox.Show(
                    "El stock mínimo no puede ser mayor que la cantidad inicial.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            // 3. Unimos la Marca y el Modelo
            string marcaYModelo = $"{cmbMarca.Text.Trim()} {txtModelo.Text.Trim()}";

            // 4. Iniciar la conexión a la base de datos
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
                    cmdRepuesto.Parameters.AddWithValue("@Proveedor", cmbProveedor.Text.Trim());

                    int idNuevoRepuesto = Convert.ToInt32(cmdRepuesto.ExecuteScalar());

                    // --- PASO B: Guardar el Inventario (CORRECCIÓN IdSucursal) ---
                    string queryInventario = @"
                    INSERT INTO InventarioSucursal
                    (IdSucursal, IdRepuesto, StockActual, StockMinimo)
                    VALUES
                    (
                    (SELECT TOP 1 IdSucursal
                    FROM Sucursales
                    WHERE NombreSucursal = @Sucursal),
                    @IdRepuesto,
                    @StockActual,
                    @StockMinimo
                    )";

                    SqlCommand cmdInventario =
                        new SqlCommand(queryInventario, conexionBD.oCon, transaccion);

                    cmdInventario.Parameters.AddWithValue(
                        "@Sucursal",
                        Sesion.SucursalActual);

                    cmdInventario.Parameters.AddWithValue(
                        "@IdRepuesto",
                        idNuevoRepuesto);

                    cmdInventario.Parameters.AddWithValue(
                        "@StockActual",
                        cantidadInicial);

                    cmdInventario.Parameters.AddWithValue(
                        "@StockMinimo",
                        stockMinimo);

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

        private void txtCantidadInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtPrecioCosto.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtPrecioVenta.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProveedor.Items.Clear();

            if (cmbMarca.SelectedIndex == -1)
            {
                return;
            }

            string marcaSeleccionada = cmbMarca.Text.Trim();

            if (marcaSeleccionada == "Otro")
            {
                cmbProveedor.Items.Add("Otro");
            }
            else
            {
                cmbProveedor.Items.Add(marcaSeleccionada);
                cmbProveedor.Items.Add("Otro");
            }

            cmbProveedor.SelectedIndex = -1;
        }
    }
}
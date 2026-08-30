using Microsoft.Data.SqlClient;
using Sunny.UI;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucTradeIn : UserControl
    {
        ucRecepcion Unsoloboton = new ucRecepcion();
        private string tipoDispositivoSeleccionado = ""; // Controla si es computadora o teléfono

        public ucTradeIn()
        {
            InitializeComponent();
        }

        private void ucTradeIn_Load(object sender, EventArgs e)
        {
            // Cargar marcas generales por defecto al abrir el módulo en ambos ComboBoxes
            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarcaRecibido, "");
            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarcaNuevo, "");
        }

        private void btnComputadora_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnComputadora);
            tipoDispositivoSeleccionado = "computadora";

            //  marcas orientadas a computadoras 
            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarcaRecibido, tipoDispositivoSeleccionado);
            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarcaNuevo, tipoDispositivoSeleccionado);
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnTelefono);
            tipoDispositivoSeleccionado = "telefono";

            // 📱 Cargamos marcas orientadas a teléfonos en ambos ComboBoxes
            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarcaRecibido, tipoDispositivoSeleccionado);
            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarcaNuevo, tipoDispositivoSeleccionado);
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
                        // Tipo de dispositivo dinámico según el botón seleccionado
                        string tipo = string.IsNullOrEmpty(tipoDispositivoSeleccionado) ? "Computadora" : tipoDispositivoSeleccionado;
                        cmd.Parameters.AddWithValue("@tipo", tipo);

                        // Lectura de los ComboBoxes de marcas (.Text para capturar selección o escritura manual)
                        cmd.Parameters.AddWithValue("@marcaRecibido", cmbMarcaRecibido.Text.Trim());
                        cmd.Parameters.AddWithValue("@modeloRecibido", txtModeloRecibido.Text.Trim());
                        cmd.Parameters.AddWithValue("@imei", txtSerieCanje.Text.Trim());
                        cmd.Parameters.AddWithValue("@estadoFisico", cmbEstadoFisico.Text ?? "");
                        cmd.Parameters.AddWithValue("@estadoFuncional", cmbEstadoFuncional.Text ?? "");

                        decimal.TryParse(txtValorAsignado.Text, out decimal valorAsignado);
                        cmd.Parameters.AddWithValue("@valorAsignado", valorAsignado);

                        cmd.Parameters.AddWithValue("@cedula", txtCedula.Text.Trim());
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefono", txtNumeroTelefonico.Text.Trim());

                        cmd.Parameters.AddWithValue("@marcaNuevo", cmbMarcaNuevo.Text.Trim());
                        cmd.Parameters.AddWithValue("@modeloNuevo", txtModeloNuevo.Text.Trim());

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
            decimal.TryParse(txtPrecioOriginal.Text, out decimal precioNuevo);
            decimal.TryParse(txtValorAsignado.Text, out decimal valorTradeIn);

            decimal diferencia = precioNuevo - valorTradeIn;
            if (diferencia < 0) diferencia = 0;

            lblPrecioEquipoNuevo.Text = "$" + precioNuevo.ToString("0.00");
            lblValorTradeIn.Text = "$" + valorTradeIn.ToString("0.00");
            lblDiferencia.Text = "$" + diferencia.ToString("0.00");
        }

        private void txtPrecioOriginal_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void txtValorAsignado_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void btnVerificarRobo_Click(object sender, EventArgs e)
        {
            string imei = txtSerieCanje.Text.Trim();

            if (string.IsNullOrWhiteSpace(imei) || imei.Length != 15)
            {
                MessageBox.Show("Primero ingresa un IMEI válido de 15 dígitos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // URL de consulta de ARCOTEL 
            //"https://www.imei.info/"
            string urlOficial = "https://tucelularlegal.arcotel.gob.ec/consultas/";

            try
            {
                // abrir el navegador web predeterminado de Windows (Chrome, Edge, etc.)
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = urlOficial,
                    UseShellExecute = true
                });

                //Copiar el IMEI al portapapeles para que el técnico solo haga "Ctrl+V" en la página
                Clipboard.SetText(imei);
                MessageBox.Show("El IMEI se ha copiado al portapapeles.\nPégalo en la página que se acaba de abrir para verificar el estado de robo.", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el navegador web: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrecioOriginal_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrecioOriginal.Text))
                return;

            // Convertir la coma a punto solo para poder convertirlo a decimal
            string texto = txtPrecioOriginal.Text.Replace('.', ','); // por si acaso escriben punto
            texto = texto.Replace(',', '.');

            if (decimal.TryParse(texto, System.Globalization.NumberStyles.Any,
                                       System.Globalization.CultureInfo.InvariantCulture, out decimal precio)
                && precio >= 0)
            {
                // Mostramos con coma
                txtPrecioOriginal.Text = precio.ToString("0.00").Replace('.', ',');
            }
            else
            {
                MessageBox.Show("El costo debe ser un número positivo.\nEjemplo: 150,50",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtPrecioOriginal.Focus();
                txtPrecioOriginal.SelectAll();
            }
        }

        private void txtPrecioOriginal_KeyPress(object sender, KeyPressEventArgs e)
        {
            UITextBox txt = sender as UITextBox;
            if (txt == null) return;

            if (char.IsControl(e.KeyChar))
                return;

            // Solo números y coma
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                return;
            }

            // Solo una coma
            if (e.KeyChar == ',' && txt.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void txtValorAsignado_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValorAsignado.Text))
                return;

            // Convertir la coma a punto solo para poder convertirlo a decimal
            string texto = txtValorAsignado.Text.Replace('.', ','); // por si acaso escriben punto
            texto = texto.Replace(',', '.');

            if (decimal.TryParse(texto, System.Globalization.NumberStyles.Any,
                                       System.Globalization.CultureInfo.InvariantCulture, out decimal precio)
                && precio >= 0)
            {
                // Mostrar con coma
                txtValorAsignado.Text = precio.ToString("0.00").Replace('.', ',');
            }
            else
            {
                MessageBox.Show("El costo debe ser un número positivo.\nEjemplo: 150,50",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtValorAsignado.Focus();
                txtValorAsignado.SelectAll();
            }
        }

        private void txtValorAsignado_KeyPress(object sender, KeyPressEventArgs e)
        {
            UITextBox txt = sender as UITextBox;
            if (txt == null) return;

            if (char.IsControl(e.KeyChar))
                return;

            // Solo números y coma
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                return;
            }

            // Solo una coma
            if (e.KeyChar == ',' && txt.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void pnlDispositivoLleva_Click(object sender, EventArgs e)
        {

        }
    }
}
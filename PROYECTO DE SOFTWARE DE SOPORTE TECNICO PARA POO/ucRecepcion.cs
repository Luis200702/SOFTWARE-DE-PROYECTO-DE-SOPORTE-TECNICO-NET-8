using Microsoft.Data.SqlClient;
using Sunny.UI;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucRecepcion : UserControl
    {
        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();
        private List<DispositivoTemporal> listaEquipos = new List<DispositivoTemporal>();
        private int indicePestanaActual = 0;
        private int contadorEquipos = 1;
        private UIButton botonSeleccionado = null;
        private string tipoDispositivo = "";

        public ucRecepcion()
        {
            InitializeComponent();
        }

        private void ucRecepcion_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");

            // 🔥 Tomamos dinámicamente la sucursal activa desde la sesión del usuario
            txtSucursal.Text = Sesion.SucursalActual;

            CargarDatosComboBox();
            cmbEstado.SelectedIndex = 0;
            MostrarNumeroOrden();

            listaEquipos.Add(new DispositivoTemporal());

            btnEquipo.Tag = 0;
            btnEquipo.Click += btnEquipo_Click;

            txtIdentificacionCliente.Leave += txtIdentificacionCliente_Leave;

            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarca, "");
        }

        public void SeleccionarBoton(UIButton boton)
        {
            if (botonSeleccionado != null)
            {
                botonSeleccionado.FillColor = Color.FromArgb(239, 243, 247);
                botonSeleccionado.ForeColor = Color.FromArgb(70, 86, 103);
                botonSeleccionado.RectColor = Color.FromArgb(220, 226, 232);
            }

            boton.FillColor = Color.FromArgb(0, 165, 155);
            boton.ForeColor = Color.FromArgb(255, 255, 255);
            boton.RectColor = Color.FromArgb(0, 165, 155);

            botonSeleccionado = boton;
        }

        private void btnComputadora_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(btnComputadora);
            tipoDispositivo = "computadora";
            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarca, tipoDispositivo);
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(btnTelefono);
            tipoDispositivo = "telefono";
            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarca, tipoDispositivo);
        }

        private void CargarDatosComboBox()
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    string ConsultaTecnicos = "SELECT Id, Nombre FROM Usuarios WHERE Perfil = 'Tecnico'";
                    SqlDataAdapter daTecnicos = new SqlDataAdapter(ConsultaTecnicos, db.oCon);
                    DataTable dtTecnicos = new DataTable();
                    daTecnicos.Fill(dtTecnicos);

                    cmbTecnico.DataSource = dtTecnicos;
                    cmbTecnico.DisplayMember = "Nombre";
                    cmbTecnico.ValueMember = "Id";

                    if (cmbTecnico.Items.Count > 0)
                    {
                        cmbTecnico.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos en los ComboBox: " + ex.Message);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        private void MostrarNumeroOrden()
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    string query = "SELECT ISNULL(MAX(id), 0) FROM ordenes";
                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        int ultimoId = Convert.ToInt32(cmd.ExecuteScalar());
                        lblOrden.Text = "ORD-" + DateTime.Now.Year + "-" + (ultimoId + 1).ToString("D3");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el número de orden: " + ex.Message);
                    lblOrden.Text = "ORD-" + DateTime.Now.Year + "-001";
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
            else
            {
                lblOrden.Text = "ORD-" + DateTime.Now.Year + "-001";
            }
        }

        private void txtIdentificacionCliente_Leave(object sender, EventArgs e)
        {
            string cedula = txtIdentificacionCliente.Text.Trim();
            if (string.IsNullOrEmpty(cedula)) return;

            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    string ConsultaCliente = "SELECT TOP 1 nombre, telefono, correo, telefono_alt, direccion FROM clientes WHERE cedula_pasaporte = @cedula";
                    using (SqlCommand cmd = new SqlCommand(ConsultaCliente, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@cedula", cedula);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNombres.Text = reader["nombre"].ToString();
                                txtNumeroTelefonico.Text = reader["telefono"].ToString();
                                txtCorreo.Text = reader["correo"].ToString();

                                if (txtNumeroTelefonicoAlt != null) txtNumeroTelefonicoAlt.Text = reader["telefono_alt"].ToString();
                                if (txtDireccion != null) txtDireccion.Text = reader["direccion"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar cliente: " + ex.Message);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        private void GuardarRecepcion()
        {
            GuardarDatosEnMemoria();

            if (string.IsNullOrWhiteSpace(txtIdentificacionCliente.Text) ||
                string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroTelefonico.Text))
            {
                MessageBox.Show("Por favor, llena al menos la Cédula, Nombre y Teléfono del cliente para poder continuar.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool guardarSoloCliente = false;
            var primerEquipo = listaEquipos[0];

            if (listaEquipos.Count == 1 && string.IsNullOrEmpty(primerEquipo.Tipo) && string.IsNullOrWhiteSpace(primerEquipo.Modelo))
            {
                guardarSoloCliente = true;
            }
            else
            {
                foreach (var eq in listaEquipos)
                {
                    if (string.IsNullOrEmpty(eq.Tipo) || string.IsNullOrWhiteSpace(eq.Marca) || string.IsNullOrWhiteSpace(eq.Modelo))
                    {
                        MessageBox.Show("Para registrar un dispositivo, debes elegir el Tipo, Marca y Modelo.\n\nSi solo deseas guardar al cliente, limpia los campos del dispositivo y presiona Guardar.", "Faltan datos del equipo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (cmbTecnico.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecciona un técnico asignado para la reparación.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            var oCon = new Conexion_Base_de_Datos();
            int idCliente = 0;

            if (oCon.abrirConexion())
            {
                string consultaBusqueda = "SELECT id FROM clientes WHERE cedula_pasaporte = '" + txtIdentificacionCliente.Text.Trim() + "'";
                SqlCommand cmdBusqueda = new SqlCommand(consultaBusqueda, oCon.oCon);
                object resultado = cmdBusqueda.ExecuteScalar();

                if (resultado != null)
                {
                    idCliente = Convert.ToInt32(resultado);
                }
                oCon.cerrarConexion();
            }

            if (idCliente == 0)
            {
                string campos = "nombre, telefono, correo, cedula_pasaporte, telefono_alt, direccion";
                string datos = "'" + txtNombres.Text.Trim() + "','" + txtNumeroTelefonico.Text + "','" +
                               txtCorreo.Text + "','" + txtIdentificacionCliente.Text + "','" +
                               (txtNumeroTelefonicoAlt != null ? txtNumeroTelefonicoAlt.Text : "") + "','" +
                               (txtDireccion != null ? txtDireccion.Text : "") + "'";

                oCon.insertDatosCliente("clientes", campos, datos);

                if (oCon.abrirConexion())
                {
                    string consultaId = "SELECT id FROM clientes WHERE cedula_pasaporte = '" + txtIdentificacionCliente.Text.Trim() + "'";
                    SqlCommand cmdId = new SqlCommand(consultaId, oCon.oCon);
                    idCliente = Convert.ToInt32(cmdId.ExecuteScalar());
                    oCon.cerrarConexion();
                }
            }

            if (!guardarSoloCliente)
            {
                int tecnicoId = Convert.ToInt32(cmbTecnico.SelectedValue);
                // 🔥 Aseguramos que la sucursal guardada en la orden sea la activa de la sesión
                string sucursal = Sesion.SucursalActual;

                for (int i = 0; i < listaEquipos.Count; i++)
                {
                    var equipo = listaEquipos[i];

                    string camposDisp = "cliente_id, tipo, marca, modelo, serie_imei, color, estado_llegada";
                    string datosDisp = idCliente + ",'" + equipo.Tipo + "','" + equipo.Marca.Trim() + "','" +
                                       equipo.Modelo.Trim() + "','" + equipo.Serie.Trim() + "','" +
                                       equipo.Color.Trim() + "','" + cmbEstado.Items[equipo.IndiceEstado].ToString() + "'";

                    oCon.insertDatosCliente("dispositivos", camposDisp, datosDisp);

                    int idDispositivo = 0;
                    if (oCon.abrirConexion())
                    {
                        string consultaDisp = "SELECT MAX(id) FROM dispositivos WHERE cliente_id = " + idCliente;
                        SqlCommand cmdDisp = new SqlCommand(consultaDisp, oCon.oCon);
                        idDispositivo = Convert.ToInt32(cmdDisp.ExecuteScalar());
                        oCon.cerrarConexion();
                    }

                    string costoAjustado = txtCosto.Text.Replace(",", ".");
                    string fechaEntrega = dtmFecha.Value.ToString("yyyy-MM-dd");
                    string numOrdenFinal = listaEquipos.Count > 1 ? $"{lblOrden.Text}-{i + 1}" : lblOrden.Text;

                    string camposOrd = "numero_orden, cliente_id, dispositivo_id, tecnico_id, sucursal, descripcion_problema, diagnostico_inicial, costo_estimado, fecha_ingreso, fecha_estimada_entrega, estado";
                    string datosOrd = "'" + numOrdenFinal + "'," + idCliente + "," + idDispositivo + "," + tecnicoId + ",'" + sucursal + "','" +
                                      equipo.Problema.Trim() + "','" + equipo.Observaciones.Trim() + "'," + costoAjustado + ",GETDATE(),'" + fechaEntrega + "','Recibido'";

                    oCon.insertDatosCliente("ordenes", camposOrd, datosOrd);
                }
            }

            string mensajeExito = guardarSoloCliente ? "¡Cliente registrado exitosamente en la base de datos!" : "¡Recepción, equipo y orden guardados exitosamente!";
            MessageBox.Show(mensajeExito, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ReiniciarFormularioCompleto();
        }

        private void ReiniciarFormularioCompleto()
        {
            txtNombres.Clear();
            txtNumeroTelefonico.Clear();
            txtCorreo.Clear();
            txtIdentificacionCliente.Clear();

            if (txtNumeroTelefonicoAlt != null) txtNumeroTelefonicoAlt.Clear();
            if (txtDireccion != null) txtDireccion.Clear();

            txtDescripcionProblema.Clear();
            txtObservaciones.Clear();
            txtCosto.Text = "0";
            cmbEstado.SelectedIndex = 0;

            if (cmbTecnico.Items.Count > 0) cmbTecnico.SelectedIndex = 0;

            txtSucursal.Text = Sesion.SucursalActual;

            dtmFecha.Value = DateTime.Now;

            listaEquipos.Clear();
            listaEquipos.Add(new DispositivoTemporal());
            indicePestanaActual = 0;
            contadorEquipos = 1;

            List<Control> controlesABorrar = new List<Control>();
            foreach (Control ctrl in flpEquipos.Controls)
            {
                if (ctrl is Sunny.UI.UIButton btn && btn.Name != "btnEquipo" && btn.Name != "btnAgregarEquipo")
                {
                    controlesABorrar.Add(btn);
                }
            }
            foreach (var ctrl in controlesABorrar)
            {
                flpEquipos.Controls.Remove(ctrl);
            }

            btnEquipo.Tag = 0;
            btnEquipo.FillColor = Color.FromArgb(0, 150, 137);
            btnEquipo.RectColor = Color.FromArgb(0, 150, 137);
            btnEquipo.ForeColor = Color.FromArgb(22, 35, 52);

            tipoDispositivo = "";
            cmbMarca.Text = "";
            if (botonSeleccionado != null)
            {
                botonSeleccionado.FillColor = Color.FromArgb(22, 35, 52);
                botonSeleccionado.RectColor = Color.Gray;
                botonSeleccionado.ForeColor = Color.White;
                botonSeleccionado = null;
            }

            CargarDatosA_Pantalla(0);
            MostrarNumeroOrden();
            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarca, "");
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            GuardarRecepcion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarFormularioCompleto();
        }

        private void GuardarDatosEnMemoria()
        {
            if (listaEquipos.Count == 0) return;

            var equipo = listaEquipos[indicePestanaActual];

            equipo.Tipo = tipoDispositivo;
            equipo.Marca = cmbMarca.Text;
            equipo.Modelo = txtModelo.Text;
            equipo.Serie = txtSerie.Text;
            equipo.Color = txtColor.Text;
            equipo.IndiceEstado = cmbEstado.SelectedIndex;
            equipo.Problema = txtDescripcionProblema.Text;
            equipo.Observaciones = txtObservaciones.Text;
        }

        private void CargarDatosA_Pantalla(int indice)
        {
            var equipo = listaEquipos[indice];

            tipoDispositivo = equipo.Tipo;

            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarca, tipoDispositivo);
            cmbMarca.Text = equipo.Marca;

            txtModelo.Text = equipo.Modelo;
            txtSerie.Text = equipo.Serie;
            txtColor.Text = equipo.Color;
            cmbEstado.SelectedIndex = equipo.IndiceEstado >= 0 ? equipo.IndiceEstado : 0;
            txtDescripcionProblema.Text = equipo.Problema;
            txtObservaciones.Text = equipo.Observaciones;

            if (tipoDispositivo == "computadora")
                SeleccionarBoton(btnComputadora);
            else if (tipoDispositivo == "telefono")
                SeleccionarBoton(btnTelefono);
            else
            {
                if (botonSeleccionado != null)
                {
                    botonSeleccionado.FillColor = Color.FromArgb(22, 35, 52);
                    botonSeleccionado.RectColor = Color.Gray;
                    botonSeleccionado.ForeColor = Color.White;
                    botonSeleccionado = null;
                }
            }

            indicePestanaActual = indice;
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            GuardarDatosEnMemoria();
            listaEquipos.Add(new DispositivoTemporal());

            contadorEquipos++;

            Sunny.UI.UIButton btnNuevo = new Sunny.UI.UIButton();
            btnNuevo.Name = "btnEquipo" + contadorEquipos;
            btnNuevo.Text = "Equipo " + contadorEquipos;
            btnNuevo.Size = new Size(100, 34);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.Margin = new Padding(3, 3, 3, 3);
            btnNuevo.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Radius = 12;

            btnNuevo.Tag = listaEquipos.Count - 1;
            btnNuevo.Click += btnEquipo_Click;

            flpEquipos.Controls.Add(btnNuevo);

            flpEquipos.Controls.Remove(btnAgregarEquipo);
            flpEquipos.Controls.Add(btnAgregarEquipo);

            btnNuevo.PerformClick();
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            Sunny.UI.UIButton botonPresionado = (Sunny.UI.UIButton)sender;

            GuardarDatosEnMemoria();

            foreach (Control ctrl in flpEquipos.Controls)
            {
                if (ctrl is Sunny.UI.UIButton btn && btn.Name != "btnAgregarEquipo")
                {
                    btn.FillColor = Color.FromArgb(22, 35, 52);
                    btn.RectColor = Color.Gray;
                    btn.ForeColor = Color.White;
                }
            }

            botonPresionado.FillColor = Color.FromArgb(0, 150, 137);
            botonPresionado.RectColor = Color.FromArgb(0, 150, 137);
            botonPresionado.ForeColor = Color.FromArgb(22, 35, 52);

            if (botonPresionado.Tag != null)
            {
                int nuevoIndice = Convert.ToInt32(botonPresionado.Tag);
                CargarDatosA_Pantalla(nuevoIndice);
            }
        }

        private void flpEquipos_Click(object sender, EventArgs e) { }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            UITextBox txt = sender as UITextBox;
            if (txt == null) return;
            if (char.IsControl(e.KeyChar)) return;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == ',' && txt.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCosto.Text)) return;

            string texto = txtCosto.Text.Replace('.', ',');
            texto = texto.Replace(',', '.');

            if (decimal.TryParse(texto, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal precio) && precio >= 0)
            {
                txtCosto.Text = precio.ToString("0.00").Replace('.', ',');
            }
            else
            {
                MessageBox.Show("El costo debe ser un número positivo.\nEjemplo: 150,50", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCosto.Focus();
                txtCosto.SelectAll();
            }
        }

        public bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron, RegexOptions.IgnoreCase);
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            string correo = txtCorreo.Text.Trim();

            if (!string.IsNullOrWhiteSpace(correo) && !EsEmailValido(correo))
            {
                txtCorreo.RectColor = Color.Red;
                MessageBox.Show("El formato del correo no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            else
            {
                txtCorreo.RectColor = Color.FromArgb(220, 224, 230);
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;

            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblDatosCliente_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
    }
}
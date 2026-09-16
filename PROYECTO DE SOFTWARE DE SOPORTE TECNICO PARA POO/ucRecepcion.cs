
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
        private DataTable dtClientes;
        private bool cargandoClientes = false;

        public ucRecepcion()
        {
            InitializeComponent();
        }

        private void ucRecepcion_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");


            txtSucursal.Text = Sesion.SucursalActual;

            CargarDatosComboBox();
            CargarClientes();

            cmbEstado.SelectedIndex = 0;
            MostrarNumeroOrden();

            listaEquipos.Add(new DispositivoTemporal());

            btnEquipo.Tag = 0;
            btnEquipo.Click += btnEquipo_Click;

            // Buscar automáticamente el dispositivo cuando se termina de escribir el IMEI/Serie.
            txtSerie.Leave -= txtSerie_Leave;
            txtSerie.Leave += txtSerie_Leave;

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
            string sucursal = Sesion.SucursalActual.Replace("'", "''");
            string consulta = "select u.id as Id, u.nombre as Nombre from usuarios u inner join sucursales s on u.idsucursal = s.idsucursal where u.perfil = 'Tecnico' and s.nombresucursal = '" + sucursal + "' order by u.nombre";

            DataTable dtTecnicos = oCon.retornarRegistrosUsuarios(consulta);

            cmbTecnico.DataSource = dtTecnicos;
            cmbTecnico.DisplayMember = "Nombre";
            cmbTecnico.ValueMember = "Id";

            if (cmbTecnico.Items.Count > 0)
                cmbTecnico.SelectedIndex = 0;
        }

        private void MostrarNumeroOrden()
        {
            try
            {
                string consulta = "select isnull(max(id), 0) as ultimoid from ordenes";
                DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

                if (dt != null && dt.Rows.Count > 0)
                {
                    int ultimoId = Convert.ToInt32(dt.Rows[0]["ultimoid"]);
                    lblOrden.Text = "ORD-" + DateTime.Now.Year + "-" + (ultimoId + 1).ToString("D3");
                }
                else
                {
                    lblOrden.Text = "ORD-" + DateTime.Now.Year + "-001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el número de orden: " + ex.Message);
                lblOrden.Text = "ORD-" + DateTime.Now.Year + "-001";
            }
        }

        private void txtIdentificacionCliente_Leave(object sender, EventArgs e)
        {
            string cedula = txtIdentificacionCliente.Text.Trim();

            if (string.IsNullOrEmpty(cedula))
                return;

            cedula = cedula.Replace("'", "''");

            string consulta = "select top 1 nombre, telefono, correo, telefono_alt, direccion from clientes where cedula_pasaporte = '" + cedula + "'";
            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];

                txtNombres.Text = fila["nombre"].ToString();
                txtNumeroTelefonico.Text = fila["telefono"].ToString();
                txtCorreo.Text = fila["correo"].ToString();

                if (txtNumeroTelefonicoAlt != null)
                    txtNumeroTelefonicoAlt.Text = fila["telefono_alt"].ToString();

                if (txtDireccion != null)
                    txtDireccion.Text = fila["direccion"].ToString();
            }
        }

        private void GuardarRecepcion()
        {
            GuardarDatosEnMemoria();

            if (string.IsNullOrWhiteSpace(txtIdentificacionCliente.Text) ||
                string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroTelefonico.Text))
            {
                MessageBox.Show(
                    "Por favor, llena al menos la Cédula, Nombre y Teléfono del cliente para poder continuar.",
                    "Faltan datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            bool guardarSoloCliente = false;
            var primerEquipo = listaEquipos[0];

            if (listaEquipos.Count == 1 &&
                string.IsNullOrEmpty(primerEquipo.Tipo) &&
                string.IsNullOrWhiteSpace(primerEquipo.Modelo))
            {
                guardarSoloCliente = true;
            }
            else
            {
                foreach (var eq in listaEquipos)
                {
                    if (string.IsNullOrEmpty(eq.Tipo) ||
                        string.IsNullOrWhiteSpace(eq.Marca) ||
                        string.IsNullOrWhiteSpace(eq.Modelo) ||
                        string.IsNullOrWhiteSpace(eq.Serie))
                    {
                        MessageBox.Show(
                            "Para registrar un dispositivo, debes elegir el Tipo, Marca, Modelo y escribir su IMEI/Serie.\n\nSi solo deseas guardar al cliente, limpia los campos del dispositivo y presiona Guardar.",
                            "Faltan datos del equipo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                }

                HashSet<string> seriesUsadas =
                    new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                foreach (var eq in listaEquipos)
                {
                    string serieActual = eq.Serie.Trim();

                    if (!seriesUsadas.Add(serieActual))
                    {
                        MessageBox.Show(
                            "El IMEI/Serie " + serieActual + " está repetido entre los equipos de esta recepción.",
                            "Dispositivo repetido",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (cmbTecnico.SelectedIndex < 0)
                {
                    MessageBox.Show(
                        "Selecciona un técnico asignado para la reparación.",
                        "Faltan datos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            int idCliente = 0;

            string cedula = txtIdentificacionCliente.Text.Trim().Replace("'", "''");
            string consultaCliente = "select id from clientes where cedula_pasaporte = '" + cedula + "'";

            DataTable dtCliente = oCon.retornarRegistrosUsuarios(consultaCliente);

            if (dtCliente != null && dtCliente.Rows.Count > 0)
            {
                idCliente = Convert.ToInt32(dtCliente.Rows[0]["id"]);
            }

            if (idCliente == 0)
            {
                string campos = "nombre, telefono, correo, cedula_pasaporte, telefono_alt, direccion";
                string datos = "'" + txtNombres.Text.Trim() + "','" + txtNumeroTelefonico.Text + "','" +
                               txtCorreo.Text + "','" + txtIdentificacionCliente.Text + "','" +
                               (txtNumeroTelefonicoAlt != null ? txtNumeroTelefonicoAlt.Text : "") + "','" +
                               (txtDireccion != null ? txtDireccion.Text : "") + "'";

                oCon.insertDatosCliente("clientes", campos, datos);

                DataTable dtNuevoCliente = oCon.retornarRegistrosUsuarios(consultaCliente);

                if (dtNuevoCliente != null && dtNuevoCliente.Rows.Count > 0)
                {
                    idCliente = Convert.ToInt32(dtNuevoCliente.Rows[0]["id"]);
                }
            }

            if (!guardarSoloCliente)
            {
                int tecnicoId = Convert.ToInt32(cmbTecnico.SelectedValue);
                string sucursal = Sesion.SucursalActual;

                for (int i = 0; i < listaEquipos.Count; i++)
                {
                    var equipo = listaEquipos[i];

                    int idDispositivo = 0;
                    int idClienteDispositivo = 0;

                    string serie = equipo.Serie.Trim().Replace("'", "''");
                    string consultaDispositivo = @"
                    select top 1
                    d.id,
                    d.cliente_id,
                    o.estado as estado_orden
                    from dispositivos d
                    left join ordenes o on o.dispositivo_id = d.id
                    where d.serie_imei = '" + serie + @"'
                    order by o.id desc";

                    DataTable dtDispositivo = oCon.retornarRegistrosUsuarios(consultaDispositivo);
                    string estadoOrden = "";

                    if (dtDispositivo != null && dtDispositivo.Rows.Count > 0)
                    {
                        DataRow filaDispositivo = dtDispositivo.Rows[0];

                        idDispositivo = Convert.ToInt32(filaDispositivo["id"]);
                        idClienteDispositivo = Convert.ToInt32(filaDispositivo["cliente_id"]);

                        if (filaDispositivo["estado_orden"] != DBNull.Value)
                        {
                            estadoOrden = filaDispositivo["estado_orden"].ToString();
                        }
                    }
                    if (idDispositivo > 0 && !string.IsNullOrWhiteSpace(estadoOrden) &&  estadoOrden != "Entregado")
                    {
                        MessageBox.Show(
                            "El IMEI/Serie " + equipo.Serie.Trim() +
                            " todavía tiene una reparación activa.\n\n" +
                            "Estado actual: " + estadoOrden +
                            "\n\nNo puede ser registrado nuevamente hasta que sea entregado.",
                            "Dispositivo no disponible",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    if (idDispositivo > 0 && estadoOrden == "Entregado")
                    {
                        string camposActualizar = "cliente_id = " + idCliente;
                        string condicionActualizar = "id = " + idDispositivo;

                        oCon.actualizarDatos(
                            "dispositivos",
                            camposActualizar,
                            condicionActualizar);
                    }

                    if (idDispositivo == 0)
                    {
                        string camposDisp = "cliente_id, tipo, marca, modelo, serie_imei, color, estado_llegada";
                        string datosDisp = idCliente + ",'" + equipo.Tipo + "','" + equipo.Marca.Trim() + "','" +
                                           equipo.Modelo.Trim() + "','" + equipo.Serie.Trim() + "','" +
                                           equipo.Color.Trim() + "','" + cmbEstado.Items[equipo.IndiceEstado].ToString() + "'";

                        oCon.insertDatosCliente("dispositivos", camposDisp, datosDisp);

                        DataTable dtNuevoDispositivo = oCon.retornarRegistrosUsuarios(consultaDispositivo);

                        if (dtNuevoDispositivo != null && dtNuevoDispositivo.Rows.Count > 0)
                        {
                            idDispositivo = Convert.ToInt32(dtNuevoDispositivo.Rows[0]["id"]);
                        }
                    }

                    string costoAjustado = txtCosto.Text.Replace(",", ".");
                    string fechaEntrega = dtmFecha.Value.ToString("yyyy-MM-dd");
                    string numOrdenFinal = listaEquipos.Count > 1 ? $"{lblOrden.Text}-{i + 1}" : lblOrden.Text;

                    string camposOrd = "numero_orden, cliente_id, dispositivo_id, tecnico_id, sucursal, descripcion_problema, diagnostico_inicial, costo_estimado, fecha_ingreso, fecha_estimada_entrega, estado";
                    string datosOrd = "'" + numOrdenFinal + "'," + idCliente + "," + idDispositivo + "," + tecnicoId + ",'" + sucursal + "','" +
                                      equipo.Problema.Trim() + "','" + equipo.Observaciones.Trim() + "'," + costoAjustado + ",getdate(),'" + fechaEntrega + "','Recibido'";

                    oCon.insertDatosCliente("ordenes", camposOrd, datosOrd);
                }
            }

            string mensajeExito = guardarSoloCliente
                ? "¡Cliente registrado exitosamente en la base de datos!"
                : "¡Recepción, equipo y orden guardados exitosamente!";

            MessageBox.Show(
                mensajeExito,
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ReiniciarFormularioCompleto();
        }

        private void ReiniciarFormularioCompleto()
        {
            txtNombres.Clear();
            txtNumeroTelefonico.Clear();
            txtCorreo.Clear();
            txtIdentificacionCliente.Clear();
            cmbBuscarCliente.Clear();

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
            equipo.Color = cmbColor.Text;
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
            cmbColor.Text = equipo.Color;
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

        private void txtSerie_Leave(object sender, EventArgs e)
        {
            string serieImei = txtSerie.Text.Trim();

            if (string.IsNullOrWhiteSpace(serieImei))
                return;

            string serie = serieImei.Replace("'", "''");
            string consulta = @"
            select top 1
            d.id,
            d.tipo,
            d.marca,
            d.modelo,
            d.color,
            d.estado_llegada,
            c.cedula_pasaporte,
            o.estado as estado_orden
            from dispositivos d
            inner join clientes c on d.cliente_id = c.id
            left join ordenes o on o.dispositivo_id = d.id
            where d.serie_imei = '" + serie + @"'
            order by o.id desc";

            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];
                string estadoOrden = "";

                if (fila["estado_orden"] != DBNull.Value)
                {
                    estadoOrden = fila["estado_orden"].ToString();
                }

                if (!string.IsNullOrWhiteSpace(estadoOrden) &&
                    estadoOrden != "Entregado")
                {
                    MessageBox.Show(
                        "Este dispositivo todavía tiene una reparación activa.\n\n" +
                        "Estado actual: " + estadoOrden +
                        "\n\nNo puede ser registrado nuevamente hasta que sea entregado.",
                        "Dispositivo no disponible",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                tipoDispositivo = fila["tipo"].ToString();

                if (tipoDispositivo == "telefono")
                    SeleccionarBoton(btnTelefono);
                else if (tipoDispositivo == "computadora")
                    SeleccionarBoton(btnComputadora);

                CatalogoMarcas.CargarMarcasEnComboBox(
                    cmbMarca,
                    tipoDispositivo);

                cmbMarca.Text = fila["marca"].ToString();
                txtModelo.Text = fila["modelo"].ToString();
                string colorRegistrado = fila["color"].ToString().Trim();

                for (int i = 0; i < cmbColor.Items.Count; i++)
                {
                    if (cmbColor.Items[i].ToString().Trim() == colorRegistrado)
                    {
                        cmbColor.SelectedIndex = i;
                        break;
                    }
                }

                string estado = fila["estado_llegada"].ToString();

                if (cmbEstado.Items.Contains(estado))
                    cmbEstado.SelectedItem = estado;

            }
        }
        private void CargarClientes()
        {
            cargandoClientes = true;

            string consulta = "select id, nombre, cedula_pasaporte from clientes order by nombre";

            dtClientes = oCon.retornarRegistrosUsuarios(consulta);

            cmbBuscarCliente.DataSource = dtClientes;
            cmbBuscarCliente.DisplayMember = "nombre";
            cmbBuscarCliente.ValueMember = "id";

            cmbBuscarCliente.SelectedIndex = -1;
            cmbBuscarCliente.Text = "";

            cargandoClientes = false;
        }
        private void txtIdentificacionCliente_TextChanged(object sender, EventArgs e)
        {

        }
        private void cmbBuscarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoClientes)
                return;

            if (cmbBuscarCliente.SelectedIndex < 0)
                return;

            DataRowView filaSeleccionada = cmbBuscarCliente.SelectedItem as DataRowView;

            if (filaSeleccionada == null)
                return;

            int idCliente = Convert.ToInt32(filaSeleccionada["id"]);

            string consulta = "select nombre, telefono, correo, cedula_pasaporte, telefono_alt, direccion " +
                              "from clientes where id = " + idCliente;

            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];

                txtIdentificacionCliente.Text = fila["cedula_pasaporte"].ToString();
                txtNombres.Text = fila["nombre"].ToString();
                txtNumeroTelefonico.Text = fila["telefono"].ToString();
                txtCorreo.Text = fila["correo"].ToString();

                if (txtNumeroTelefonicoAlt != null)
                    txtNumeroTelefonicoAlt.Text = fila["telefono_alt"].ToString();

                if (txtDireccion != null)
                    txtDireccion.Text = fila["direccion"].ToString();
            }
        }
        private void cmbBuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (dtClientes == null)
                return;

            string texto = cmbBuscarCliente.Text.Trim();

            try
            {
                if (string.IsNullOrWhiteSpace(texto))
                {
                    dtClientes.DefaultView.RowFilter = "";
                }
                else
                {
                    texto = texto.Replace("'", "''");

                    dtClientes.DefaultView.RowFilter =
                        "nombre LIKE '" + texto + "%'";
                }
            }
            catch
            {
                dtClientes.DefaultView.RowFilter = "";
            }
        }
    }
}